namespace DivinityOriginialSinIIModsHelper
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
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.steamButton = new System.Windows.Forms.Button();
            this.documentsButton = new System.Windows.Forms.Button();
            this.steamTextBox = new System.Windows.Forms.TextBox();
            this.documentsTextBox = new System.Windows.Forms.TextBox();
            this.steamLabel = new System.Windows.Forms.Label();
            this.documentsLabel = new System.Windows.Forms.Label();
            this.moveButton = new System.Windows.Forms.Button();
            this.moveLabel = new System.Windows.Forms.Label();
            this.moveTextBox = new System.Windows.Forms.TextBox();
            this.steamDefault = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.storeFoldersButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // folderBrowserDialog
            // 
            this.folderBrowserDialog.ShowNewFolderButton = false;
            // 
            // steamButton
            // 
            this.steamButton.Location = new System.Drawing.Point(12, 27);
            this.steamButton.Name = "steamButton";
            this.steamButton.Size = new System.Drawing.Size(123, 23);
            this.steamButton.TabIndex = 0;
            this.steamButton.Text = "Steam Folder";
            this.steamButton.UseVisualStyleBackColor = true;
            this.steamButton.Click += new System.EventHandler(this.SteamButton_Click);
            // 
            // documentsButton
            // 
            this.documentsButton.Location = new System.Drawing.Point(12, 105);
            this.documentsButton.Name = "documentsButton";
            this.documentsButton.Size = new System.Drawing.Size(123, 23);
            this.documentsButton.TabIndex = 1;
            this.documentsButton.Text = "Documents Folder";
            this.documentsButton.UseVisualStyleBackColor = true;
            this.documentsButton.Click += new System.EventHandler(this.DocumentsButton_Click);
            // 
            // steamTextBox
            // 
            this.steamTextBox.Enabled = false;
            this.steamTextBox.Location = new System.Drawing.Point(12, 62);
            this.steamTextBox.Name = "steamTextBox";
            this.steamTextBox.Size = new System.Drawing.Size(642, 20);
            this.steamTextBox.TabIndex = 2;
            // 
            // documentsTextBox
            // 
            this.documentsTextBox.Enabled = false;
            this.documentsTextBox.Location = new System.Drawing.Point(12, 134);
            this.documentsTextBox.Name = "documentsTextBox";
            this.documentsTextBox.Size = new System.Drawing.Size(642, 20);
            this.documentsTextBox.TabIndex = 3;
            // 
            // steamLabel
            // 
            this.steamLabel.AutoSize = true;
            this.steamLabel.Location = new System.Drawing.Point(12, 9);
            this.steamLabel.Name = "steamLabel";
            this.steamLabel.Size = new System.Drawing.Size(102, 13);
            this.steamLabel.TabIndex = 4;
            this.steamLabel.Text = "Select Steam Folder";
            // 
            // documentsLabel
            // 
            this.documentsLabel.AutoSize = true;
            this.documentsLabel.Location = new System.Drawing.Point(9, 89);
            this.documentsLabel.Name = "documentsLabel";
            this.documentsLabel.Size = new System.Drawing.Size(126, 13);
            this.documentsLabel.TabIndex = 5;
            this.documentsLabel.Text = "Select Documents Folder";
            // 
            // moveButton
            // 
            this.moveButton.Location = new System.Drawing.Point(12, 182);
            this.moveButton.Name = "moveButton";
            this.moveButton.Size = new System.Drawing.Size(123, 23);
            this.moveButton.TabIndex = 6;
            this.moveButton.Text = "Move";
            this.moveButton.UseVisualStyleBackColor = true;
            this.moveButton.Click += new System.EventHandler(this.MoveButton_Click);
            // 
            // moveLabel
            // 
            this.moveLabel.AutoSize = true;
            this.moveLabel.Location = new System.Drawing.Point(12, 166);
            this.moveLabel.Name = "moveLabel";
            this.moveLabel.Size = new System.Drawing.Size(63, 13);
            this.moveLabel.TabIndex = 7;
            this.moveLabel.Text = "Move Mods";
            // 
            // moveTextBox
            // 
            this.moveTextBox.Enabled = false;
            this.moveTextBox.Location = new System.Drawing.Point(12, 211);
            this.moveTextBox.Name = "moveTextBox";
            this.moveTextBox.Size = new System.Drawing.Size(642, 20);
            this.moveTextBox.TabIndex = 8;
            // 
            // steamDefault
            // 
            this.steamDefault.AutoSize = true;
            this.steamDefault.Location = new System.Drawing.Point(141, 9);
            this.steamDefault.Name = "steamDefault";
            this.steamDefault.Size = new System.Drawing.Size(216, 13);
            this.steamDefault.TabIndex = 9;
            this.steamDefault.Text = "The default is C:\\Program Files (x86)\\Steam.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(141, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(505, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Ensure this is where Divinity is installed (it\'s possible to have different insta" +
    "llation-paths for different games).";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(141, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "This should contain a steamapp-folder.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(141, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(401, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Beware - older versions of duplicate mods in your mods-folder, if any, will be de" +
    "leted.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(141, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(337, 26);
            this.label4.TabIndex = 13;
            this.label4.Text = "The default is C:\\Users\\<your username>\\Documents.\r\nThis should be prefilled by t" +
    "he program, if not, select the correct folder.";
            // 
            // storeFoldersButton
            // 
            this.storeFoldersButton.Location = new System.Drawing.Point(499, 4);
            this.storeFoldersButton.Name = "storeFoldersButton";
            this.storeFoldersButton.Size = new System.Drawing.Size(155, 23);
            this.storeFoldersButton.TabIndex = 14;
            this.storeFoldersButton.Text = "Store Folder Locations";
            this.storeFoldersButton.UseVisualStyleBackColor = true;
            this.storeFoldersButton.Click += new System.EventHandler(this.StoreFoldersButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 246);
            this.Controls.Add(this.storeFoldersButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.steamDefault);
            this.Controls.Add(this.moveTextBox);
            this.Controls.Add(this.moveLabel);
            this.Controls.Add(this.moveButton);
            this.Controls.Add(this.documentsLabel);
            this.Controls.Add(this.steamLabel);
            this.Controls.Add(this.documentsTextBox);
            this.Controls.Add(this.steamTextBox);
            this.Controls.Add(this.documentsButton);
            this.Controls.Add(this.steamButton);
            this.Name = "Form1";
            this.Text = "Divinity Original Sin II - Mods Helper";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Button steamButton;
        private System.Windows.Forms.Button documentsButton;
        private System.Windows.Forms.TextBox steamTextBox;
        private System.Windows.Forms.TextBox documentsTextBox;
        private System.Windows.Forms.Label steamLabel;
        private System.Windows.Forms.Label documentsLabel;
        private System.Windows.Forms.Button moveButton;
        private System.Windows.Forms.Label moveLabel;
        private System.Windows.Forms.TextBox moveTextBox;
        private System.Windows.Forms.Label steamDefault;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button storeFoldersButton;
    }
}

