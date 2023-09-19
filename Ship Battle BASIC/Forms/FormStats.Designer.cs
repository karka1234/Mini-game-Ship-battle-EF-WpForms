namespace Ship_Battle_BASIC
{
    partial class FormStats
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
            dataGridView1 = new System.Windows.Forms.DataGridView();
            label1 = new System.Windows.Forms.Label();
            buttonBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new System.Drawing.Point(12, 49);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new System.Drawing.Size(531, 343);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(148, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(218, 37);
            label1.TabIndex = 2;
            label1.Text = "Player statistics";
            // 
            // buttonBack
            // 
            buttonBack.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            buttonBack.Location = new System.Drawing.Point(425, 398);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new System.Drawing.Size(118, 61);
            buttonBack.TabIndex = 4;
            buttonBack.Text = "Back";
            buttonBack.UseVisualStyleBackColor = true;
            buttonBack.Click += buttonBack_Click;
            // 
            // FormStats
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(556, 469);
            Controls.Add(buttonBack);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "FormStats";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "StatsForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonBack;
    }
}