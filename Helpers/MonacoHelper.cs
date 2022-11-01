using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RBLXex.Helpers
{
    internal class MonacoHelper
    {
        public static string GetCode(WebBrowser editor)
        {
            return editor.Document.InvokeScript("GetText", new string[0]).ToString();
        }

        public static void SetCode(WebBrowser editor, string content)
        {
            editor.Document.InvokeScript("SetText", new object[] { content });
        }

        public static void AddIntellisense(WebBrowser editor, string method, string kind)
        {
            editor.Document.InvokeScript("AddIntellisense", new object[] { method, kind, method, method });
        }
    }
}
