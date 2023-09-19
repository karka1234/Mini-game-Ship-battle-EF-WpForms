namespace Ship_Battle_BASIC
{
    partial class FormModeChoose
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
            buttonSingle = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            buttonMulti = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            buttonPlayerStats = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // buttonSingle
            // 
            buttonSingle.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            buttonSingle.Location = new System.Drawing.Point(12, 49);
            buttonSingle.Name = "buttonSingle";
            buttonSingle.Size = new System.Drawing.Size(119, 86);
            buttonSingle.TabIndex = 0;
            buttonSingle.Text = "Single";
            buttonSingle.UseVisualStyleBackColor = true;
            buttonSingle.Click += buttonSingle_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(36, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(192, 37);
            label1.TabIndex = 1;
            label1.Text = "Choose mode";
            // 
            // buttonMulti
            // 
            buttonMulti.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            buttonMulti.Location = new System.Drawing.Point(137, 49);
            buttonMulti.Name = "buttonMulti";
            buttonMulti.Size = new System.Drawing.Size(119, 86);
            buttonMulti.TabIndex = 2;
            buttonMulti.Text = "Multi";
            buttonMulti.UseVisualStyleBackColor = true;
            buttonMulti.Click += buttonMulti_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(91, 138);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(80, 37);
            label2.TabIndex = 3;
            label2.Text = "Stats";
            // 
            // buttonPlayerStats
            // 
            buttonPlayerStats.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            buttonPlayerStats.Location = new System.Drawing.Point(14, 178);
            buttonPlayerStats.Name = "buttonPlayerStats";
            buttonPlayerStats.Size = new System.Drawing.Size(242, 56);
            buttonPlayerStats.TabIndex = 4;
            buttonPlayerStats.Text = "Players";
            buttonPlayerStats.UseVisualStyleBackColor = true;
            buttonPlayerStats.Click += buttonPlayerStats_Click;
            // 
            // FormModeChoose
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(274, 253);
            Controls.Add(buttonPlayerStats);
            Controls.Add(label2);
            Controls.Add(buttonMulti);
            Controls.Add(label1);
            Controls.Add(buttonSingle);
            Name = "FormModeChoose";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "ModeChoose";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button buttonSingle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonMulti;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonPlayerStats;
    }
}