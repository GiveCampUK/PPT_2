namespace Ppt.DataMigration
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.FriendsTextBox = new System.Windows.Forms.TextBox();
            this.FriendsButton = new System.Windows.Forms.Button();
            this.YogaTextBox = new System.Windows.Forms.TextBox();
            this.YogaButton = new System.Windows.Forms.Button();
            this.PrisonerTextBox = new System.Windows.Forms.TextBox();
            this.PrisonerButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PrisonerFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.YogaFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.FriendsFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SqlServerPassword = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SqlServerUsername = new System.Windows.Forms.TextBox();
            this.SqlServerName = new System.Windows.Forms.TextBox();
            this.SqlServerDatabase = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.RunButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(384, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "The Total Awesome PPT Access Migration Tool";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.FriendsTextBox);
            this.groupBox1.Controls.Add(this.FriendsButton);
            this.groupBox1.Controls.Add(this.YogaTextBox);
            this.groupBox1.Controls.Add(this.YogaButton);
            this.groupBox1.Controls.Add(this.PrisonerTextBox);
            this.groupBox1.Controls.Add(this.PrisonerButton);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(454, 193);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Files";
            // 
            // FriendsTextBox
            // 
            this.FriendsTextBox.Location = new System.Drawing.Point(52, 139);
            this.FriendsTextBox.Name = "FriendsTextBox";
            this.FriendsTextBox.Size = new System.Drawing.Size(328, 22);
            this.FriendsTextBox.TabIndex = 8;
            // 
            // FriendsButton
            // 
            this.FriendsButton.Location = new System.Drawing.Point(394, 138);
            this.FriendsButton.Name = "FriendsButton";
            this.FriendsButton.Size = new System.Drawing.Size(54, 23);
            this.FriendsButton.TabIndex = 7;
            this.FriendsButton.Text = "Select";
            this.FriendsButton.UseVisualStyleBackColor = true;
            this.FriendsButton.Click += new System.EventHandler(this.FriendsButton_Click);
            // 
            // YogaTextBox
            // 
            this.YogaTextBox.Location = new System.Drawing.Point(52, 86);
            this.YogaTextBox.Name = "YogaTextBox";
            this.YogaTextBox.Size = new System.Drawing.Size(328, 22);
            this.YogaTextBox.TabIndex = 6;
            // 
            // YogaButton
            // 
            this.YogaButton.Location = new System.Drawing.Point(394, 85);
            this.YogaButton.Name = "YogaButton";
            this.YogaButton.Size = new System.Drawing.Size(54, 23);
            this.YogaButton.TabIndex = 5;
            this.YogaButton.Text = "Select";
            this.YogaButton.UseVisualStyleBackColor = true;
            this.YogaButton.Click += new System.EventHandler(this.YogaButton_Click);
            // 
            // PrisonerTextBox
            // 
            this.PrisonerTextBox.Location = new System.Drawing.Point(52, 34);
            this.PrisonerTextBox.Name = "PrisonerTextBox";
            this.PrisonerTextBox.Size = new System.Drawing.Size(328, 22);
            this.PrisonerTextBox.TabIndex = 4;
            // 
            // PrisonerButton
            // 
            this.PrisonerButton.Location = new System.Drawing.Point(394, 33);
            this.PrisonerButton.Name = "PrisonerButton";
            this.PrisonerButton.Size = new System.Drawing.Size(54, 23);
            this.PrisonerButton.TabIndex = 3;
            this.PrisonerButton.Text = "Select";
            this.PrisonerButton.UseVisualStyleBackColor = true;
            this.PrisonerButton.Click += new System.EventHandler(this.PrisonerButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label5.Location = new System.Drawing.Point(52, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Friends Database";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label4.Location = new System.Drawing.Point(52, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Yoga Teachers";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label3.Location = new System.Drawing.Point(52, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Prisoner Database";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.SqlServerPassword);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.SqlServerUsername);
            this.groupBox2.Controls.Add(this.SqlServerName);
            this.groupBox2.Controls.Add(this.SqlServerDatabase);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(15, 245);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(451, 222);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "SQL Server";
            // 
            // SqlServerPassword
            // 
            this.SqlServerPassword.Location = new System.Drawing.Point(49, 190);
            this.SqlServerPassword.Name = "SqlServerPassword";
            this.SqlServerPassword.Size = new System.Drawing.Size(328, 21);
            this.SqlServerPassword.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label9.Location = new System.Drawing.Point(49, 174);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Password";
            // 
            // SqlServerUsername
            // 
            this.SqlServerUsername.Location = new System.Drawing.Point(49, 141);
            this.SqlServerUsername.Name = "SqlServerUsername";
            this.SqlServerUsername.Size = new System.Drawing.Size(328, 21);
            this.SqlServerUsername.TabIndex = 14;
            // 
            // SqlServerName
            // 
            this.SqlServerName.Location = new System.Drawing.Point(49, 36);
            this.SqlServerName.Name = "SqlServerName";
            this.SqlServerName.Size = new System.Drawing.Size(328, 21);
            this.SqlServerName.TabIndex = 12;
            // 
            // SqlServerDatabase
            // 
            this.SqlServerDatabase.Location = new System.Drawing.Point(49, 88);
            this.SqlServerDatabase.Name = "SqlServerDatabase";
            this.SqlServerDatabase.Size = new System.Drawing.Size(328, 21);
            this.SqlServerDatabase.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label8.Location = new System.Drawing.Point(49, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Server Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label7.Location = new System.Drawing.Point(49, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Database Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label6.Location = new System.Drawing.Point(49, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Username";
            // 
            // RunButton
            // 
            this.RunButton.Location = new System.Drawing.Point(406, 489);
            this.RunButton.Name = "RunButton";
            this.RunButton.Size = new System.Drawing.Size(54, 23);
            this.RunButton.TabIndex = 9;
            this.RunButton.Text = "Run";
            this.RunButton.UseVisualStyleBackColor = true;
            this.RunButton.Click += new System.EventHandler(this.RunButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 536);
            this.Controls.Add(this.RunButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox PrisonerTextBox;
        private System.Windows.Forms.Button PrisonerButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.OpenFileDialog PrisonerFileDialog;
        private System.Windows.Forms.TextBox YogaTextBox;
        private System.Windows.Forms.Button YogaButton;
        private System.Windows.Forms.TextBox FriendsTextBox;
        private System.Windows.Forms.Button FriendsButton;
        private System.Windows.Forms.OpenFileDialog YogaFileDialog;
        private System.Windows.Forms.OpenFileDialog FriendsFileDialog;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox SqlServerPassword;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox SqlServerUsername;
        private System.Windows.Forms.TextBox SqlServerName;
        private System.Windows.Forms.TextBox SqlServerDatabase;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button RunButton;
    }
}

