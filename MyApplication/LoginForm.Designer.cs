using System;

namespace MyApplication
{
    partial class LoginForm : Infrastructure.BaseForm
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
            buttonlogin = new Dtat.Windows.Forms.Button();
            buttonreset = new Dtat.Windows.Forms.Button();
            buttonregister = new Dtat.Windows.Forms.Button();
            buttonexit = new Dtat.Windows.Forms.Button();
            label1 = new Dtat.Windows.Forms.Label();
            label2 = new Dtat.Windows.Forms.Label();
            usernameTextBox = new Dtat.Windows.Forms.TextBox();
            passwordTextBox = new Dtat.Windows.Forms.TextBox();
            SuspendLayout();
            // 
            // buttonlogin
            // 
            buttonlogin.Location = new System.Drawing.Point(71, 74);
            buttonlogin.Name = "buttonlogin";
            buttonlogin.Size = new System.Drawing.Size(75, 23);
            buttonlogin.TabIndex = 4;
            buttonlogin.Text = "&Login";
            buttonlogin.UseVisualStyleBackColor = true;
            buttonlogin.Click += buttonlogin_Click;
            // 
            // buttonreset
            // 
            buttonreset.Location = new System.Drawing.Point(152, 74);
            buttonreset.Name = "buttonreset";
            buttonreset.Size = new System.Drawing.Size(75, 23);
            buttonreset.TabIndex = 5;
            buttonreset.Text = "&Reset";
            buttonreset.UseVisualStyleBackColor = true;
            // 
            // buttonregister
            // 
            buttonregister.Location = new System.Drawing.Point(233, 74);
            buttonregister.Name = "buttonregister";
            buttonregister.Size = new System.Drawing.Size(75, 23);
            buttonregister.TabIndex = 6;
            buttonregister.Text = "Re&gister";
            buttonregister.UseVisualStyleBackColor = true;
            // 
            // buttonexit
            // 
            buttonexit.Location = new System.Drawing.Point(314, 74);
            buttonexit.Name = "buttonexit";
            buttonexit.Size = new System.Drawing.Size(75, 23);
            buttonexit.TabIndex = 7;
            buttonexit.Text = "E&xit";
            buttonexit.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(11, 20);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(54, 15);
            label1.TabIndex = 0;
            label1.Text = "&Usernme";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(11, 48);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(59, 15);
            label2.TabIndex = 2;
            label2.Text = "&PassWord";
            // 
            // usernameTextBox
            // 
            usernameTextBox.Location = new System.Drawing.Point(71, 16);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new System.Drawing.Size(318, 23);
            usernameTextBox.TabIndex = 1;
            usernameTextBox.TextChanged += textBox1_TextChanged;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new System.Drawing.Point(71, 45);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new System.Drawing.Size(318, 23);
            passwordTextBox.TabIndex = 3;
            passwordTextBox.UseSystemPasswordChar = true;
            // 
            // LoginForm
            // 
            AcceptButton = buttonlogin;
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            CancelButton = buttonexit;
            ClientSize = new System.Drawing.Size(404, 111);
            ControlBox = false;
            Controls.Add(passwordTextBox);
            Controls.Add(usernameTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonexit);
            Controls.Add(buttonregister);
            Controls.Add(buttonreset);
            Controls.Add(buttonlogin);
            MaximumSize = new System.Drawing.Size(420, 150);
            MinimumSize = new System.Drawing.Size(420, 150);
            Name = "LoginForm";
            Text = "LoginForm";
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Dtat.Windows.Forms.Button buttonlogin;
        private Dtat.Windows.Forms.Button buttonreset;
        private Dtat.Windows.Forms.Button buttonregister;
        private Dtat.Windows.Forms.Button buttonexit;
        private Dtat.Windows.Forms.Label label1;
        private Dtat.Windows.Forms.Label label2;
        private Dtat.Windows.Forms.TextBox usernameTextBox;
        private Dtat.Windows.Forms.TextBox passwordTextBox;
    }
}