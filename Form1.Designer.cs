namespace RBLXex
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.top_bar = new System.Windows.Forms.Panel();
            this.seperator = new System.Windows.Forms.Panel();
            this.logo = new System.Windows.Forms.PictureBox();
            this.minimize_button = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.open_file_button = new System.Windows.Forms.Button();
            this.save_file_button = new System.Windows.Forms.Button();
            this.close_button = new System.Windows.Forms.Button();
            this.execute_button = new System.Windows.Forms.Button();
            this.editor = new System.Windows.Forms.WebBrowser();
            this.attach_button = new System.Windows.Forms.Button();
            this.clear_button = new System.Windows.Forms.Button();
            this.options_button = new System.Windows.Forms.Button();
            this.top_bar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // top_bar
            // 
            this.top_bar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.top_bar.Controls.Add(this.seperator);
            this.top_bar.Controls.Add(this.logo);
            this.top_bar.Controls.Add(this.minimize_button);
            this.top_bar.Controls.Add(this.title);
            this.top_bar.Controls.Add(this.open_file_button);
            this.top_bar.Controls.Add(this.save_file_button);
            this.top_bar.Controls.Add(this.close_button);
            this.top_bar.ForeColor = System.Drawing.Color.White;
            this.top_bar.Location = new System.Drawing.Point(0, 0);
            this.top_bar.Name = "top_bar";
            this.top_bar.Size = new System.Drawing.Size(650, 34);
            this.top_bar.TabIndex = 0;
            this.top_bar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.top_bar_MouseDown);
            this.top_bar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.top_bar_MouseMove);
            // 
            // seperator
            // 
            this.seperator.BackColor = System.Drawing.Color.White;
            this.seperator.Location = new System.Drawing.Point(233, 8);
            this.seperator.Name = "seperator";
            this.seperator.Size = new System.Drawing.Size(1, 20);
            this.seperator.TabIndex = 9;
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.Transparent;
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(3, 0);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(34, 34);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 8;
            this.logo.TabStop = false;
            // 
            // minimize_button
            // 
            this.minimize_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.minimize_button.FlatAppearance.BorderSize = 0;
            this.minimize_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimize_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimize_button.ForeColor = System.Drawing.Color.White;
            this.minimize_button.Location = new System.Drawing.Point(556, 0);
            this.minimize_button.Name = "minimize_button";
            this.minimize_button.Size = new System.Drawing.Size(47, 34);
            this.minimize_button.TabIndex = 7;
            this.minimize_button.Text = "-";
            this.minimize_button.UseVisualStyleBackColor = false;
            this.minimize_button.Click += new System.EventHandler(this.minimize_button_Click);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.Color.Transparent;
            this.title.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(40, 4);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(79, 25);
            this.title.TabIndex = 6;
            this.title.Text = "RBLXex";
            // 
            // open_file_button
            // 
            this.open_file_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.open_file_button.FlatAppearance.BorderSize = 0;
            this.open_file_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.open_file_button.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.open_file_button.ForeColor = System.Drawing.Color.White;
            this.open_file_button.Location = new System.Drawing.Point(240, 5);
            this.open_file_button.Name = "open_file_button";
            this.open_file_button.Size = new System.Drawing.Size(102, 25);
            this.open_file_button.TabIndex = 3;
            this.open_file_button.Text = "Open File";
            this.open_file_button.UseVisualStyleBackColor = false;
            this.open_file_button.Click += new System.EventHandler(this.open_file_button_Click);
            // 
            // save_file_button
            // 
            this.save_file_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.save_file_button.FlatAppearance.BorderSize = 0;
            this.save_file_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save_file_button.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_file_button.ForeColor = System.Drawing.Color.White;
            this.save_file_button.Location = new System.Drawing.Point(124, 5);
            this.save_file_button.Name = "save_file_button";
            this.save_file_button.Size = new System.Drawing.Size(103, 25);
            this.save_file_button.TabIndex = 4;
            this.save_file_button.Text = "Save File";
            this.save_file_button.UseVisualStyleBackColor = false;
            this.save_file_button.Click += new System.EventHandler(this.save_file_button_Click);
            // 
            // close_button
            // 
            this.close_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.close_button.FlatAppearance.BorderSize = 0;
            this.close_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close_button.ForeColor = System.Drawing.Color.White;
            this.close_button.Location = new System.Drawing.Point(603, 0);
            this.close_button.Name = "close_button";
            this.close_button.Size = new System.Drawing.Size(47, 34);
            this.close_button.TabIndex = 5;
            this.close_button.Text = "X";
            this.close_button.UseVisualStyleBackColor = false;
            this.close_button.Click += new System.EventHandler(this.close_button_Click);
            // 
            // execute_button
            // 
            this.execute_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(59)))), ((int)(((byte)(115)))));
            this.execute_button.FlatAppearance.BorderSize = 0;
            this.execute_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.execute_button.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.execute_button.ForeColor = System.Drawing.Color.White;
            this.execute_button.Location = new System.Drawing.Point(0, 332);
            this.execute_button.Name = "execute_button";
            this.execute_button.Size = new System.Drawing.Size(163, 34);
            this.execute_button.TabIndex = 2;
            this.execute_button.Text = "Execute";
            this.execute_button.UseVisualStyleBackColor = false;
            this.execute_button.Click += new System.EventHandler(this.execute_button_Click);
            // 
            // editor
            // 
            this.editor.Location = new System.Drawing.Point(0, 34);
            this.editor.MinimumSize = new System.Drawing.Size(20, 20);
            this.editor.Name = "editor";
            this.editor.Size = new System.Drawing.Size(650, 298);
            this.editor.TabIndex = 10;
            // 
            // attach_button
            // 
            this.attach_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(38)))), ((int)(((byte)(77)))));
            this.attach_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.attach_button.FlatAppearance.BorderSize = 0;
            this.attach_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.attach_button.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attach_button.ForeColor = System.Drawing.Color.White;
            this.attach_button.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.attach_button.Location = new System.Drawing.Point(163, 332);
            this.attach_button.Name = "attach_button";
            this.attach_button.Size = new System.Drawing.Size(162, 34);
            this.attach_button.TabIndex = 5;
            this.attach_button.Text = "Attach";
            this.attach_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.attach_button.UseVisualStyleBackColor = false;
            this.attach_button.Click += new System.EventHandler(this.attach_button_Click);
            // 
            // clear_button
            // 
            this.clear_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.clear_button.FlatAppearance.BorderSize = 0;
            this.clear_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clear_button.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear_button.ForeColor = System.Drawing.Color.White;
            this.clear_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.clear_button.Location = new System.Drawing.Point(325, 332);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(163, 34);
            this.clear_button.TabIndex = 3;
            this.clear_button.Text = "Clear";
            this.clear_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.clear_button.UseVisualStyleBackColor = false;
            this.clear_button.Click += new System.EventHandler(this.clear_button_Click);
            // 
            // options_button
            // 
            this.options_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.options_button.FlatAppearance.BorderSize = 0;
            this.options_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.options_button.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.options_button.ForeColor = System.Drawing.Color.White;
            this.options_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.options_button.Location = new System.Drawing.Point(488, 332);
            this.options_button.Name = "options_button";
            this.options_button.Size = new System.Drawing.Size(162, 34);
            this.options_button.TabIndex = 11;
            this.options_button.Text = "Options";
            this.options_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.options_button.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(650, 366);
            this.Controls.Add(this.options_button);
            this.Controls.Add(this.editor);
            this.Controls.Add(this.attach_button);
            this.Controls.Add(this.clear_button);
            this.Controls.Add(this.execute_button);
            this.Controls.Add(this.top_bar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "RBLXex";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.top_bar.ResumeLayout(false);
            this.top_bar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel top_bar;
        private System.Windows.Forms.Button execute_button;
        private System.Windows.Forms.Button clear_button;
        private System.Windows.Forms.Button open_file_button;
        private System.Windows.Forms.Button save_file_button;
        private System.Windows.Forms.Button close_button;
        private System.Windows.Forms.Button minimize_button;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button attach_button;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Panel seperator;
        private System.Windows.Forms.WebBrowser editor;
        private System.Windows.Forms.Button options_button;
    }
}