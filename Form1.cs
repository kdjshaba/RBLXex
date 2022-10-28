using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeAreDevs_API;

namespace RBLXex
{
    public partial class Form1 : Form
    {
        private readonly ExploitAPI api = new ExploitAPI();
        private readonly WebClient webClient = new WebClient();

        private Point lastPoint;

        private bool busyAttaching = false;

        private static readonly string robloxName = "RobloxPlayerBeta";
        private static readonly string monacoPath = Path.Combine(Application.StartupPath, @"monaco");
        
        public Form1()
        {
            InitializeComponent();
        }

        //Custom Functions
        private int LerpInt(float from, float to, float speed)
        {
            return (int)Math.Round(from * (1 - speed) + to * speed);
        }

        private void SetupIntellisense()
        {
            void AddIntellisense(string label, string kind, string detail, string insertText)
            {
                string text = "\"" + label + "\"";
                string text2 = "\"" + kind + "\"";
                string text3 = "\"" + detail + "\"";
                string text4 = "\"" + insertText + "\"";

                Editor.Document.InvokeScript("AddIntellisense", new object[]
                {
                    label,
                    kind,
                    detail,
                    insertText
                });
            }

            foreach (string text in File.ReadAllLines(monacoPath + "/globalf.txt"))
            {
                bool flag = text.Contains(':');

                if (flag)
                {
                    AddIntellisense(text, "Function", text, text.Substring(1));
                }
                else
                {
                    AddIntellisense(text, "Function", text, text);
                }
            }

            foreach (string text in File.ReadLines(monacoPath + "/globalv.txt"))
            {
                AddIntellisense(text, "Variable", text, text);
            }

            foreach (string text in File.ReadLines(monacoPath + "/globalns.txt"))
            {
                AddIntellisense(text, "Class", text, text);
            }

            foreach (string text in File.ReadLines(monacoPath + "/classfunc.txt"))
            {
                AddIntellisense(text, "Method", text, text);
            }

            foreach (string text in File.ReadLines(monacoPath + "/base.txt"))
            {
                AddIntellisense(text, "Keyword", text, text);
            }
        }

        private string GetEditorValue() {
            object[] args = new string[0];
            object obj = Editor.Document.InvokeScript("GetText", args);
            string script = obj.ToString();

            return script;
        }

        private void SetEditorValue(string value)
        {
            Editor.Document.InvokeScript("SetText", new object[] { value });
        }

        private void ShowMessage(string msg) { 
            Task.Run(() => { MessageBox.Show(msg); }); 
        }

        private bool IsAppRunning(string appName)
        {
            //Checks if an app is running

            if (Process.GetProcesses().Any((p) => p.ProcessName.Contains(appName))) { return true; }

            return false;
        }

        private void PrepareForAttachment()
        {
            //Bypass API launch error by deleting a finj.exe (kinda hacky ik but it has to be done)
            //Error was "You are using an outdated version of the WeAreDevs_API"

            //Removing finj.exe fixes it somehow (I didnt read the documentation so I dont understand this)
            
            try
            {
                //File.Delete(@".\WRDAPICONF.json");
                //File.Delete(@".\exploit-main.dll");
                //File.Delete(@".\FastColorTextBox.xml");
                //File.Delete(@".\kernel64.sys.dll");
                //File.Delete(@".\Newtonsoft.Json.dll");
                File.Delete(@".\finj.exe");
            }
            catch { }
        }

        private void CloseProcess(string name)
        {
            //Closes any process that has the name specified

            Process[] processes = null;

            try
            {
                processes = Process.GetProcessesByName(name);

                Process mainProcess = processes[0];

                if (!mainProcess.HasExited)
                {
                    mainProcess.Kill();
                }
            }
            finally
            {
                if (processes != null)
                {
                    foreach (Process process in processes)
                    {
                        process.Dispose();
                    }
                }
            }
        }

        private void Attach()
        {
            ShowMessage("Attachment process has begun, this may take a while to startup");

            PrepareForAttachment();

            busyAttaching = true;
            api.LaunchExploit(); //Begin attaching

            while (!api.isAPIAttached()) { Thread.Sleep(50); }

            busyAttaching = false;
            CloseProcess("finj"); //Close the annoying command prompt after attachment

            ShowMessage("Attachment has finished");
        }

        //UI Events
        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AttachButton_Click(object sender, EventArgs e)
        {
            if (busyAttaching) { ShowMessage("Busy attaching, please wait."); return; }
            if (!IsAppRunning(robloxName)) { ShowMessage("Cant attach without ROBLOX running."); return; }
            if (api.isAPIAttached()) { ShowMessage("Already attached to ROBLOX client."); return; }

            Task.Run(() => {
                Attach();
            });
        }

        private void ExecuteButton_Click(object sender, EventArgs e)
        {
            void SendEditorValueToApi()
            {
                //I have to use this because it requires a switch back to the UI thread to get editors value
                api.SendLuaScript(GetEditorValue());
            }

            if (busyAttaching) { ShowMessage("Busy attaching, please wait."); return; }
            if (!IsAppRunning(robloxName)) { ShowMessage("Cant attach or execute without ROBLOX running."); return; }

            Task.Run(() => {
                if (!api.isAPIAttached()) { Attach(); }

                Invoke(new MethodInvoker(SendEditorValueToApi));
            });
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            SetEditorValue("");
        }

        private void OpenFileButton_Click(object sender, EventArgs e)
        {
            //Open a file to change the content of the text editor
            OpenFileDialog dialog = new OpenFileDialog();

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                dialog.Title = "Open";
                SetEditorValue(File.ReadAllText(dialog.FileName));
            }
        }

        private void SaveFileButton_Click(object sender, EventArgs e)
        {
            //Create a new file with contents of the text editor
            SaveFileDialog dialog = new SaveFileDialog { Filter = "Lua File|*.lua|Text File|*.txt" };

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                using (Stream stream = File.Open(dialog.FileName, FileMode.CreateNew))
                using (StreamWriter writer = new StreamWriter(stream))
                {
                    writer.Write(GetEditorValue());
                }
            }
        }

        private void TopBar_MouseDown(object sender, MouseEventArgs mouse)
        {
            lastPoint = new Point(mouse.X, mouse.Y);
        }

        private void TopBar_MouseMove(object sender, MouseEventArgs mouse)
        {
            if (mouse.Button == MouseButtons.Left)
            {
                //Normal Movement
                //this.Left += mouse.X - lastPoint.X;
                //this.Top += mouse.Y - lastPoint.Y;

                //Interpolated movement
                this.Top = LerpInt(this.Top, this.Top + (mouse.Y - lastPoint.Y), 0.175f);
                this.Left = LerpInt(this.Left, this.Left + (mouse.X - lastPoint.X), 0.175f);
            }
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            webClient.Proxy = null;

            //Edit the registry to make sure the WebBrowser emulates a browser correctly so Monaco can run in it
            //I tried using WebView2 but it didnt work properly so I have to use stupid WebBrowser that is inneficient and uses alot more memory
            //also WebView2 was more difficult to get info out of so

            try {
                //Get the registry key
                RegistryKey key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Internet Explorer\\Main\\FeatureControl\\FEATURE_BROWSER_EMULATION", true);
                
                string friendlyName = AppDomain.CurrentDomain.FriendlyName;
                bool flag2 = key.GetValue(friendlyName) == null;

                if (flag2)
                {
                    key.SetValue(friendlyName, 11001, RegistryValueKind.DWord); //Set the registry
                }
            } catch {}

            Editor.Url = new Uri(string.Format(monacoPath + "/index.html", Directory.GetCurrentDirectory()));

            await Task.Delay(100); //Wait 0.1 seconds so website can load up

            SetupIntellisense();
        }
    }
}