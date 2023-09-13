namespace Ship_Battle_BASIC
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            label2 = new System.Windows.Forms.Label();
            labelUserName = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            currentScore = new System.Windows.Forms.Label();
            gameStartButton = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            labelTotalScore = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.ColumnHeadersVisible = false;
            dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new System.Drawing.Point(215, 14);
            dataGridView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.DarkGray;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.DarkGray;
            dataGridView1.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.DarkGray;
            dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            dataGridView1.ShowCellErrors = false;
            dataGridView1.ShowCellToolTips = false;
            dataGridView1.ShowEditingIcon = false;
            dataGridView1.ShowRowErrors = false;
            dataGridView1.Size = new System.Drawing.Size(469, 464);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(13, 14);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(94, 21);
            label2.TabIndex = 4;
            label2.Text = "Connected:";
            // 
            // labelUserName
            // 
            labelUserName.AutoSize = true;
            labelUserName.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            labelUserName.Location = new System.Drawing.Point(29, 35);
            labelUserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelUserName.Name = "labelUserName";
            labelUserName.Size = new System.Drawing.Size(101, 25);
            labelUserName.TabIndex = 5;
            labelUserName.Text = "userName";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(13, 284);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(144, 30);
            label3.TabIndex = 6;
            label3.Text = "Current Score";
            // 
            // currentScore
            // 
            currentScore.AutoSize = true;
            currentScore.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            currentScore.Location = new System.Drawing.Point(29, 314);
            currentScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            currentScore.Name = "currentScore";
            currentScore.Size = new System.Drawing.Size(164, 37);
            currentScore.TabIndex = 7;
            currentScore.Text = "scoreOutput";
            // 
            // gameStartButton
            // 
            gameStartButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            gameStartButton.Location = new System.Drawing.Point(13, 99);
            gameStartButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            gameStartButton.Name = "gameStartButton";
            gameStartButton.Size = new System.Drawing.Size(170, 53);
            gameStartButton.TabIndex = 8;
            gameStartButton.Text = "Single Player";
            gameStartButton.UseVisualStyleBackColor = true;
            gameStartButton.Click += gameStartButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(13, 60);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(110, 25);
            label1.TabIndex = 9;
            label1.Text = "Total Score:";
            // 
            // labelTotalScore
            // 
            labelTotalScore.AutoSize = true;
            labelTotalScore.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            labelTotalScore.Location = new System.Drawing.Point(119, 60);
            labelTotalScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelTotalScore.Name = "labelTotalScore";
            labelTotalScore.Size = new System.Drawing.Size(64, 25);
            labelTotalScore.TabIndex = 10;
            labelTotalScore.Text = "label4";
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(694, 489);
            Controls.Add(labelTotalScore);
            Controls.Add(label1);
            Controls.Add(gameStartButton);
            Controls.Add(currentScore);
            Controls.Add(label3);
            Controls.Add(labelUserName);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "Form1";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label currentScore;
        private System.Windows.Forms.Button gameStartButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelTotalScore;
    }
}

