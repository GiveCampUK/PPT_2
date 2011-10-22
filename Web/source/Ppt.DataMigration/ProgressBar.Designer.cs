namespace Ppt.DataMigration
{
    partial class ProgressBar
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
            this.migrationProgress = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.migrationMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // migrationProgress
            // 
            this.migrationProgress.Location = new System.Drawing.Point(24, 110);
            this.migrationProgress.Name = "migrationProgress";
            this.migrationProgress.Size = new System.Drawing.Size(394, 23);
            this.migrationProgress.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Migration Status";
            // 
            // migrationMessage
            // 
            this.migrationMessage.Location = new System.Drawing.Point(21, 45);
            this.migrationMessage.Name = "migrationMessage";
            this.migrationMessage.Size = new System.Drawing.Size(397, 62);
            this.migrationMessage.TabIndex = 2;
            this.migrationMessage.Click += new System.EventHandler(this.label2_Click);
            // 
            // ProgressBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 145);
            this.Controls.Add(this.migrationMessage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.migrationProgress);
            this.Name = "ProgressBar";
            this.Text = "ProgressBar";
            this.Load += new System.EventHandler(this.ProgressBar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar migrationProgress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label migrationMessage;
    }
}