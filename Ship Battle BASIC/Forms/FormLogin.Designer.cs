namespace Ship_Battle_BASIC
{
    partial class FormLogin
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
            textBoxUserName = new System.Windows.Forms.TextBox();
            buttonLogin = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // textBoxUserName
            // 
            textBoxUserName.Location = new System.Drawing.Point(15, 61);
            textBoxUserName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            textBoxUserName.Name = "textBoxUserName";
            textBoxUserName.Size = new System.Drawing.Size(171, 23);
            textBoxUserName.TabIndex = 0;
            textBoxUserName.Text = "Enter your name";
            // 
            // buttonLogin
            // 
            buttonLogin.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            buttonLogin.Location = new System.Drawing.Point(13, 101);
            buttonLogin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new System.Drawing.Size(171, 43);
            buttonLogin.TabIndex = 2;
            buttonLogin.Text = "LOGIN/REG";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(49, 9);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(95, 37);
            label1.TabIndex = 1;
            label1.Text = "GAME";
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(199, 156);
            Controls.Add(buttonLogin);
            Controls.Add(label1);
            Controls.Add(textBoxUserName);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "FormLogin";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Login";
            FormClosing += Login_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Label label1;
    }
}