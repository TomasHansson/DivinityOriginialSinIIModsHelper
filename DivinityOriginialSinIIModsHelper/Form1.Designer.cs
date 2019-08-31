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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.steamButton = new System.Windows.Forms.Button();
            this.documentsButton = new System.Windows.Forms.Button();
            this.documentsLabel = new System.Windows.Forms.Label();
            this.moveButton = new System.Windows.Forms.Button();
            this.moveLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.storeFoldersButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.steamTextBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.documentsTextBox = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.moveTextBox = new System.Windows.Forms.RichTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // folderBrowserDialog
            // 
            this.folderBrowserDialog.ShowNewFolderButton = false;
            // 
            // steamButton
            // 
            this.steamButton.Font = new System.Drawing.Font("Footlight MT Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.steamButton.Location = new System.Drawing.Point(8, 215);
            this.steamButton.Name = "steamButton";
            this.steamButton.Size = new System.Drawing.Size(180, 30);
            this.steamButton.TabIndex = 0;
            this.steamButton.Text = "Select Steam Folder";
            this.steamButton.UseVisualStyleBackColor = true;
            this.steamButton.Click += new System.EventHandler(this.SteamButton_Click);
            // 
            // documentsButton
            // 
            this.documentsButton.Font = new System.Drawing.Font("Footlight MT Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.documentsButton.Location = new System.Drawing.Point(9, 347);
            this.documentsButton.Name = "documentsButton";
            this.documentsButton.Size = new System.Drawing.Size(180, 30);
            this.documentsButton.TabIndex = 1;
            this.documentsButton.Text = "Select Documents Folder";
            this.documentsButton.UseVisualStyleBackColor = true;
            this.documentsButton.Click += new System.EventHandler(this.DocumentsButton_Click);
            // 
            // documentsLabel
            // 
            this.documentsLabel.AutoSize = true;
            this.documentsLabel.Font = new System.Drawing.Font("Footlight MT Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.documentsLabel.Location = new System.Drawing.Point(12, 270);
            this.documentsLabel.Name = "documentsLabel";
            this.documentsLabel.Size = new System.Drawing.Size(270, 20);
            this.documentsLabel.TabIndex = 5;
            this.documentsLabel.Text = "• Step 2: Select Documents Folder";
            // 
            // moveButton
            // 
            this.moveButton.Font = new System.Drawing.Font("Footlight MT Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moveButton.Location = new System.Drawing.Point(9, 498);
            this.moveButton.Name = "moveButton";
            this.moveButton.Size = new System.Drawing.Size(180, 30);
            this.moveButton.TabIndex = 6;
            this.moveButton.Text = "Copy Mods";
            this.moveButton.UseVisualStyleBackColor = true;
            this.moveButton.Click += new System.EventHandler(this.MoveButton_Click);
            // 
            // moveLabel
            // 
            this.moveLabel.AutoSize = true;
            this.moveLabel.Font = new System.Drawing.Font("Footlight MT Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moveLabel.Location = new System.Drawing.Point(12, 403);
            this.moveLabel.Name = "moveLabel";
            this.moveLabel.Size = new System.Drawing.Size(166, 20);
            this.moveLabel.TabIndex = 7;
            this.moveLabel.Text = "• Step 3: Copy Mods";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Footlight MT Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 432);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(582, 54);
            this.label3.TabIndex = 12;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Footlight MT Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 299);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(486, 36);
            this.label4.TabIndex = 13;
            this.label4.Text = "- The default is C:\\Users\\<your username>\\Documents.\r\n- This should be prefilled " +
    "by the program, if not, select the correct folder.";
            // 
            // storeFoldersButton
            // 
            this.storeFoldersButton.Font = new System.Drawing.Font("Footlight MT Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storeFoldersButton.Location = new System.Drawing.Point(8, 651);
            this.storeFoldersButton.Name = "storeFoldersButton";
            this.storeFoldersButton.Size = new System.Drawing.Size(180, 30);
            this.storeFoldersButton.TabIndex = 14;
            this.storeFoldersButton.Text = "Store Folder Locations";
            this.storeFoldersButton.UseVisualStyleBackColor = true;
            this.storeFoldersButton.Click += new System.EventHandler(this.StoreFoldersButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Footlight MT Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(37, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(591, 39);
            this.label5.TabIndex = 15;
            this.label5.Text = "Divinity Original Sin II - Mods Helper";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(80, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(481, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "_______________________________________________________________________________";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Footlight MT Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(646, 18);
            this.label7.TabIndex = 17;
            this.label7.Text = "This tool will copy your downloaded mods from the Workshop-folder to your Documen" +
    "ts-folder.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Footlight MT Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(228, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "• Step 1: Select Steam Folder";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Footlight MT Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(13, 130);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(398, 72);
            this.label9.TabIndex = 19;
            this.label9.Text = resources.GetString("label9.Text");
            // 
            // steamTextBox
            // 
            this.steamTextBox.Font = new System.Drawing.Font("Footlight MT Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.steamTextBox.Location = new System.Drawing.Point(194, 215);
            this.steamTextBox.Multiline = false;
            this.steamTextBox.Name = "steamTextBox";
            this.steamTextBox.Size = new System.Drawing.Size(468, 30);
            this.steamTextBox.TabIndex = 20;
            this.steamTextBox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 248);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(481, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "_______________________________________________________________________________";
            // 
            // documentsTextBox
            // 
            this.documentsTextBox.Font = new System.Drawing.Font("Footlight MT Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.documentsTextBox.Location = new System.Drawing.Point(195, 347);
            this.documentsTextBox.Multiline = false;
            this.documentsTextBox.Name = "documentsTextBox";
            this.documentsTextBox.Size = new System.Drawing.Size(468, 30);
            this.documentsTextBox.TabIndex = 22;
            this.documentsTextBox.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 380);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(481, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "_______________________________________________________________________________";
            // 
            // moveTextBox
            // 
            this.moveTextBox.Font = new System.Drawing.Font("Footlight MT Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moveTextBox.Location = new System.Drawing.Point(195, 498);
            this.moveTextBox.Multiline = false;
            this.moveTextBox.Name = "moveTextBox";
            this.moveTextBox.ReadOnly = true;
            this.moveTextBox.Size = new System.Drawing.Size(468, 30);
            this.moveTextBox.TabIndex = 24;
            this.moveTextBox.Text = "";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(80, 549);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(481, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "_______________________________________________________________________________";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Footlight MT Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 574);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(270, 20);
            this.label11.TabIndex = 26;
            this.label11.Text = "• Optional: Store Folder Locations";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Footlight MT Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(13, 603);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(599, 36);
            this.label12.TabIndex = 27;
            this.label12.Text = "- This will create a file (dosiimh-configuration.txt) in this programs location t" +
    "o store your\r\n   selected folders, which will be preloaded next time you start t" +
    "he program.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(674, 691);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.moveTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.documentsTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.steamTextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.storeFoldersButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.moveLabel);
            this.Controls.Add(this.moveButton);
            this.Controls.Add(this.documentsLabel);
            this.Controls.Add(this.documentsButton);
            this.Controls.Add(this.steamButton);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(690, 730);
            this.MinimumSize = new System.Drawing.Size(690, 730);
            this.Name = "Form1";
            this.Text = "Divinity Original Sin II - Mods Helper";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Button steamButton;
        private System.Windows.Forms.Button documentsButton;
        private System.Windows.Forms.Label documentsLabel;
        private System.Windows.Forms.Button moveButton;
        private System.Windows.Forms.Label moveLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button storeFoldersButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox steamTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox documentsTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox moveTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}

