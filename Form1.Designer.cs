namespace HealingStream
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
            this.StartBTN = new System.Windows.Forms.Button();
            this.StopAndSave = new System.Windows.Forms.Button();
            this.Stop = new System.Windows.Forms.Button();
            this.LogBox = new System.Windows.Forms.RichTextBox();
            this.TotalLBL = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.ResetBTN = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StartBTN
            // 
            this.StartBTN.Location = new System.Drawing.Point(32, 202);
            this.StartBTN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.StartBTN.Name = "StartBTN";
            this.StartBTN.Size = new System.Drawing.Size(83, 41);
            this.StartBTN.TabIndex = 0;
            this.StartBTN.Text = "Start";
            this.StartBTN.UseVisualStyleBackColor = true;
            this.StartBTN.Click += new System.EventHandler(this.button1_Click);
            // 
            // StopAndSave
            // 
            this.StopAndSave.Enabled = false;
            this.StopAndSave.Location = new System.Drawing.Point(131, 202);
            this.StopAndSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.StopAndSave.Name = "StopAndSave";
            this.StopAndSave.Size = new System.Drawing.Size(128, 41);
            this.StopAndSave.TabIndex = 1;
            this.StopAndSave.Text = "Stop And Save";
            this.StopAndSave.UseVisualStyleBackColor = true;
            this.StopAndSave.Click += new System.EventHandler(this.StopAndSave_Click);
            // 
            // Stop
            // 
            this.Stop.Enabled = false;
            this.Stop.Location = new System.Drawing.Point(275, 202);
            this.Stop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(103, 41);
            this.Stop.TabIndex = 2;
            this.Stop.Text = "Stop";
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // LogBox
            // 
            this.LogBox.Location = new System.Drawing.Point(24, 47);
            this.LogBox.Name = "LogBox";
            this.LogBox.Size = new System.Drawing.Size(493, 147);
            this.LogBox.TabIndex = 3;
            this.LogBox.Text = "";
            // 
            // TotalLBL
            // 
            this.TotalLBL.AutoSize = true;
            this.TotalLBL.Location = new System.Drawing.Point(21, 24);
            this.TotalLBL.Name = "TotalLBL";
            this.TotalLBL.Size = new System.Drawing.Size(39, 19);
            this.TotalLBL.TabIndex = 4;
            this.TotalLBL.Text = "Total";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // ResetBTN
            // 
            this.ResetBTN.Location = new System.Drawing.Point(394, 202);
            this.ResetBTN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ResetBTN.Name = "ResetBTN";
            this.ResetBTN.Size = new System.Drawing.Size(103, 41);
            this.ResetBTN.TabIndex = 5;
            this.ResetBTN.Text = "Reset Start";
            this.ResetBTN.UseVisualStyleBackColor = true;
            this.ResetBTN.Click += new System.EventHandler(this.ResetBTN_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(450, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 31);
            this.button1.TabIndex = 6;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Blue;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(331, 12);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 31);
            this.button2.TabIndex = 7;
            this.button2.Text = "Registration 2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 279);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TotalLBL);
            this.Controls.Add(this.LogBox);
            this.Controls.Add(this.ResetBTN);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.StopAndSave);
            this.Controls.Add(this.StartBTN);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Registration 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartBTN;
        private System.Windows.Forms.Button StopAndSave;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.RichTextBox LogBox;
        private System.Windows.Forms.Label TotalLBL;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button ResetBTN;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

