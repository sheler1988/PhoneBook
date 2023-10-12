namespace MyApplication
{
    partial class RegisterForm
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
            buttonregister = new Dtat.Windows.Forms.Button();
            buttonreset = new Dtat.Windows.Forms.Button();
            buttonlogin = new Dtat.Windows.Forms.Button();
            buttonexit = new Dtat.Windows.Forms.Button();
            textBoxusername = new Dtat.Windows.Forms.TextBox();
            textBoxpassword = new Dtat.Windows.Forms.TextBox();
            textBoxfullname = new Dtat.Windows.Forms.TextBox();
            labelusername = new Dtat.Windows.Forms.Label();
            labelpassword = new Dtat.Windows.Forms.Label();
            labelfullname = new Dtat.Windows.Forms.Label();
            SuspendLayout();
            // 
            // buttonregister
            // 
            buttonregister.Location = new System.Drawing.Point(82, 100);
            buttonregister.Name = "buttonregister";
            buttonregister.Size = new System.Drawing.Size(75, 23);
            buttonregister.TabIndex = 6;
            buttonregister.Text = "Re&gister";
            buttonregister.UseVisualStyleBackColor = true;
            buttonregister.Click += buttonregister_Click;
            // 
            // buttonreset
            // 
            buttonreset.Location = new System.Drawing.Point(163, 100);
            buttonreset.Name = "buttonreset";
            buttonreset.Size = new System.Drawing.Size(75, 23);
            buttonreset.TabIndex = 7;
            buttonreset.Text = "&Reset";
            buttonreset.UseVisualStyleBackColor = true;
            // 
            // buttonlogin
            // 
            buttonlogin.Location = new System.Drawing.Point(244, 100);
            buttonlogin.Name = "buttonlogin";
            buttonlogin.Size = new System.Drawing.Size(75, 23);
            buttonlogin.TabIndex = 8;
            buttonlogin.Text = "&Login";
            buttonlogin.UseVisualStyleBackColor = true;
            // 
            // buttonexit
            // 
            buttonexit.Location = new System.Drawing.Point(325, 100);
            buttonexit.Name = "buttonexit";
            buttonexit.Size = new System.Drawing.Size(75, 23);
            buttonexit.TabIndex = 9;
            buttonexit.Text = "E&xit";
            buttonexit.UseVisualStyleBackColor = true;
            // 
            // textBoxusername
            // 
            textBoxusername.Location = new System.Drawing.Point(82, 10);
            textBoxusername.Name = "textBoxusername";
            textBoxusername.Size = new System.Drawing.Size(318, 23);
            textBoxusername.TabIndex = 1;
            // 
            // textBoxpassword
            // 
            textBoxpassword.Location = new System.Drawing.Point(82, 39);
            textBoxpassword.Name = "textBoxpassword";
            textBoxpassword.Size = new System.Drawing.Size(318, 23);
            textBoxpassword.TabIndex = 3;
            textBoxpassword.UseSystemPasswordChar = true;
            // 
            // textBoxfullname
            // 
            textBoxfullname.Location = new System.Drawing.Point(82, 71);
            textBoxfullname.Name = "textBoxfullname";
            textBoxfullname.Size = new System.Drawing.Size(318, 23);
            textBoxfullname.TabIndex = 5;
            // 
            // labelusername
            // 
            labelusername.AutoSize = true;
            labelusername.Location = new System.Drawing.Point(12, 13);
            labelusername.Name = "labelusername";
            labelusername.Size = new System.Drawing.Size(60, 15);
            labelusername.TabIndex = 0;
            labelusername.Text = "&Username";
            // 
            // labelpassword
            // 
            labelpassword.AutoSize = true;
            labelpassword.Location = new System.Drawing.Point(12, 42);
            labelpassword.Name = "labelpassword";
            labelpassword.Size = new System.Drawing.Size(57, 15);
            labelpassword.TabIndex = 2;
            labelpassword.Text = "&Password";
            // 
            // labelfullname
            // 
            labelfullname.AutoSize = true;
            labelfullname.Location = new System.Drawing.Point(12, 74);
            labelfullname.Name = "labelfullname";
            labelfullname.Size = new System.Drawing.Size(61, 15);
            labelfullname.TabIndex = 4;
            labelfullname.Text = "&Full Name";
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(409, 133);
            ControlBox = false;
            Controls.Add(labelfullname);
            Controls.Add(labelpassword);
            Controls.Add(labelusername);
            Controls.Add(textBoxfullname);
            Controls.Add(textBoxpassword);
            Controls.Add(textBoxusername);
            Controls.Add(buttonexit);
            Controls.Add(buttonlogin);
            Controls.Add(buttonreset);
            Controls.Add(buttonregister);
            MaximumSize = new System.Drawing.Size(425, 172);
            MinimumSize = new System.Drawing.Size(425, 172);
            Name = "RegisterForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Register";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Dtat.Windows.Forms.Button buttonregister;
        private Dtat.Windows.Forms.Button buttonreset;
        private Dtat.Windows.Forms.Button buttonlogin;
        private Dtat.Windows.Forms.Button buttonexit;
        private Dtat.Windows.Forms.TextBox textBoxusername;
        private Dtat.Windows.Forms.TextBox textBoxpassword;
        private Dtat.Windows.Forms.TextBox textBoxfullname;
        private Dtat.Windows.Forms.Label labelusername;
        private Dtat.Windows.Forms.Label labelpassword;
        private Dtat.Windows.Forms.Label labelfullname;
    }
}