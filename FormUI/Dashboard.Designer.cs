﻿namespace FormUI
{
    partial class Dashboard
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
            this.peopleFoundListbox = new System.Windows.Forms.ListBox();
            this.lastNameText = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.firstNameInsLabel = new System.Windows.Forms.Label();
            this.firstNameInsText = new System.Windows.Forms.TextBox();
            this.lastNameInsLabel = new System.Windows.Forms.Label();
            this.lastNameInsText = new System.Windows.Forms.TextBox();
            this.emailAddressInsLabel = new System.Windows.Forms.Label();
            this.emailAddressInsText = new System.Windows.Forms.TextBox();
            this.phoneNumberInsLabel = new System.Windows.Forms.Label();
            this.phoneNumberInsText = new System.Windows.Forms.TextBox();
            this.insertRecord = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // peopleFoundListbox
            // 
            this.peopleFoundListbox.FormattingEnabled = true;
            this.peopleFoundListbox.ItemHeight = 25;
            this.peopleFoundListbox.Location = new System.Drawing.Point(26, 139);
            this.peopleFoundListbox.Name = "peopleFoundListbox";
            this.peopleFoundListbox.Size = new System.Drawing.Size(617, 154);
            this.peopleFoundListbox.TabIndex = 0;
            // 
            // lastNameText
            // 
            this.lastNameText.Location = new System.Drawing.Point(150, 40);
            this.lastNameText.Name = "lastNameText";
            this.lastNameText.Size = new System.Drawing.Size(211, 32);
            this.lastNameText.TabIndex = 1;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(26, 43);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(118, 26);
            this.lastNameLabel.TabIndex = 2;
            this.lastNameLabel.Text = "Last Name";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(150, 78);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(143, 38);
            this.searchButton.TabIndex = 3;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // firstNameInsLabel
            // 
            this.firstNameInsLabel.AutoSize = true;
            this.firstNameInsLabel.Location = new System.Drawing.Point(26, 319);
            this.firstNameInsLabel.Name = "firstNameInsLabel";
            this.firstNameInsLabel.Size = new System.Drawing.Size(119, 26);
            this.firstNameInsLabel.TabIndex = 5;
            this.firstNameInsLabel.Text = "First Name";
            this.firstNameInsLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // firstNameInsText
            // 
            this.firstNameInsText.Location = new System.Drawing.Point(150, 316);
            this.firstNameInsText.Name = "firstNameInsText";
            this.firstNameInsText.Size = new System.Drawing.Size(211, 32);
            this.firstNameInsText.TabIndex = 4;
            // 
            // lastNameInsLabel
            // 
            this.lastNameInsLabel.AutoSize = true;
            this.lastNameInsLabel.Location = new System.Drawing.Point(26, 357);
            this.lastNameInsLabel.Name = "lastNameInsLabel";
            this.lastNameInsLabel.Size = new System.Drawing.Size(118, 26);
            this.lastNameInsLabel.TabIndex = 7;
            this.lastNameInsLabel.Text = "Last Name";
            // 
            // lastNameInsText
            // 
            this.lastNameInsText.Location = new System.Drawing.Point(150, 354);
            this.lastNameInsText.Name = "lastNameInsText";
            this.lastNameInsText.Size = new System.Drawing.Size(211, 32);
            this.lastNameInsText.TabIndex = 6;
            // 
            // emailAddressInsLabel
            // 
            this.emailAddressInsLabel.AutoSize = true;
            this.emailAddressInsLabel.Location = new System.Drawing.Point(26, 395);
            this.emailAddressInsLabel.Name = "emailAddressInsLabel";
            this.emailAddressInsLabel.Size = new System.Drawing.Size(68, 26);
            this.emailAddressInsLabel.TabIndex = 9;
            this.emailAddressInsLabel.Text = "Email";
            // 
            // emailAddressInsText
            // 
            this.emailAddressInsText.Location = new System.Drawing.Point(150, 392);
            this.emailAddressInsText.Name = "emailAddressInsText";
            this.emailAddressInsText.Size = new System.Drawing.Size(211, 32);
            this.emailAddressInsText.TabIndex = 8;
            // 
            // phoneNumberInsLabel
            // 
            this.phoneNumberInsLabel.AutoSize = true;
            this.phoneNumberInsLabel.Location = new System.Drawing.Point(26, 436);
            this.phoneNumberInsLabel.Name = "phoneNumberInsLabel";
            this.phoneNumberInsLabel.Size = new System.Drawing.Size(115, 26);
            this.phoneNumberInsLabel.TabIndex = 11;
            this.phoneNumberInsLabel.Text = "Phone No.";
            // 
            // phoneNumberInsText
            // 
            this.phoneNumberInsText.Location = new System.Drawing.Point(150, 433);
            this.phoneNumberInsText.Name = "phoneNumberInsText";
            this.phoneNumberInsText.Size = new System.Drawing.Size(211, 32);
            this.phoneNumberInsText.TabIndex = 10;
            // 
            // insertRecord
            // 
            this.insertRecord.Location = new System.Drawing.Point(430, 316);
            this.insertRecord.Name = "insertRecord";
            this.insertRecord.Size = new System.Drawing.Size(143, 38);
            this.insertRecord.TabIndex = 12;
            this.insertRecord.Text = "Insert";
            this.insertRecord.UseVisualStyleBackColor = true;
            this.insertRecord.Click += new System.EventHandler(this.insertRecord_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 477);
            this.Controls.Add(this.insertRecord);
            this.Controls.Add(this.phoneNumberInsLabel);
            this.Controls.Add(this.phoneNumberInsText);
            this.Controls.Add(this.emailAddressInsLabel);
            this.Controls.Add(this.emailAddressInsText);
            this.Controls.Add(this.lastNameInsLabel);
            this.Controls.Add(this.lastNameInsText);
            this.Controls.Add(this.firstNameInsLabel);
            this.Controls.Add(this.firstNameInsText);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.lastNameText);
            this.Controls.Add(this.peopleFoundListbox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Dashboard";
            this.Text = "SQL Data Access Demo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox peopleFoundListbox;
        private System.Windows.Forms.TextBox lastNameText;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label firstNameInsLabel;
        private System.Windows.Forms.TextBox firstNameInsText;
        private System.Windows.Forms.Label lastNameInsLabel;
        private System.Windows.Forms.TextBox lastNameInsText;
        private System.Windows.Forms.Label emailAddressInsLabel;
        private System.Windows.Forms.TextBox emailAddressInsText;
        private System.Windows.Forms.Label phoneNumberInsLabel;
        private System.Windows.Forms.TextBox phoneNumberInsText;
        private System.Windows.Forms.Button insertRecord;
    }
}

