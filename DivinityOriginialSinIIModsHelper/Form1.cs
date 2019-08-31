﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DivinityOriginialSinIIModsHelper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string configurationsFilePath = GetConfigurationsFilePath();
            if (File.Exists(configurationsFilePath))
            {
                using (StreamReader streamReader = new StreamReader(configurationsFilePath))
                {
                    string configuration = streamReader.ReadLine();
                    steamTextBox.Text = configuration.Split('|')[0];
                    documentsTextBox.Text = configuration.Split('|')[1];
                }
            }
            else
            {
                steamTextBox.Text = @"C:\Program Files (x86)\Steam";
                documentsTextBox.Text = Path.Combine(Environment.ExpandEnvironmentVariables("%userprofile%"), "Documents");
            }
        }

        private void SteamButton_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                steamTextBox.Text = folderBrowserDialog.SelectedPath;
        }

        private void DocumentsButton_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                documentsTextBox.Text = folderBrowserDialog.SelectedPath;
        }

        private void MoveButton_Click(object sender, EventArgs e)
        {
            int numberOfNewMods = 0, numberOfUpdatedMods = 0, numberOfUnchangedMods = 0;

            string workshopFolder = string.Concat(steamTextBox.Text, @"\steamapps\workshop\content\435150");
            if (!Directory.Exists(workshopFolder))
            {
                MessageBox.Show("Cannot find the workshop-folder in the selected Steam-folder."
                    + "\n\nEnsure that the game is installed correctly and that you've selected the correct Steam folder.");
                moveTextBox.Text = "Failed operation.";
                return;
            }

            string modsFolder = string.Concat(documentsTextBox.Text, @"\Larian Studios\Divinity Original Sin 2 Definitive Edition\Mods");
            if (!Directory.Exists(modsFolder))
            {
                MessageBox.Show("Cannot find the mods-folder in the selected Documents-folder." +
                    "\n\nEnsure that the game is installed correctly and that you've selected your Documents folder.");
                moveTextBox.Text = "Failed operation.";
                return;
            }
            string[] currentModsFilePaths = Directory.GetFiles(modsFolder);
            List<string> currentModsFileNames = new List<string>();
            foreach (var modFilePath in currentModsFilePaths)
                currentModsFileNames.Add(Path.GetFileName(modFilePath));

            ToggleButtons(false);
            moveTextBox.Text = "Update in progress...";
            string[] subfolders = Directory.GetDirectories(workshopFolder);
            foreach (string folder in subfolders)
            {
                string[] subfolderContent = Directory.GetFiles(folder);
                if (subfolderContent.Length == 0)
                {
                    // Subfolder empty -> Continue with next subfolder.
                    continue;
                }

                string modFilePath = subfolderContent.First();
                string modFileName = Path.GetFileName(modFilePath);
                if (currentModsFileNames.Contains(modFileName))
                {
                    // File with same name already exists.
                    string currentFilePath = string.Concat(modsFolder, @"\" + modFileName);
                    FileInfo newFile = new FileInfo(modFilePath);
                    FileInfo currentFile = new FileInfo(currentFilePath);
                    if (newFile.Length != currentFile.Length ||
                        newFile.LastWriteTime > currentFile.LastWriteTime)
                    {
                        // Files are different -> Replace with new file.
                        File.Delete(currentFilePath);
                        File.Copy(modFilePath, currentFilePath);
                        numberOfUpdatedMods++;
                    }
                    else
                    {
                        // Files are equal -> Keep the current file.
                        numberOfUnchangedMods++;
                    }
                }
                else
                {
                    // New mod to add.
                    string desinationFilePath = string.Concat(modsFolder, @"\" + modFileName);
                    File.Copy(modFilePath, desinationFilePath);
                    numberOfNewMods++;
                }
            }

            moveTextBox.Text = $"New mods: {numberOfNewMods}. Updated mods: {numberOfUpdatedMods}. Unchanged mods: {numberOfUnchangedMods}." +
                $"Total: {numberOfNewMods + numberOfUpdatedMods + numberOfUnchangedMods}.";
            ToggleButtons(true);
        }

        private string GetConfigurationsFilePath()
        {
            string directory = Directory.GetCurrentDirectory();
            string configurationsfile = "dosiimh-configuration.txt";
            return string.Concat(directory, @"\" + configurationsfile);
        }

        private void StoreFoldersButton_Click(object sender, EventArgs e)
        {
            string configurationsFilePath = GetConfigurationsFilePath();
            using (StreamWriter streamWriter = new StreamWriter(configurationsFilePath))
                streamWriter.WriteLine(steamTextBox.Text + "|" + documentsTextBox.Text);
        }

        private void ToggleButtons(bool enabled)
        {
            steamButton.Enabled = enabled;
            documentsButton.Enabled = enabled;
            moveButton.Enabled = enabled;
            storeFoldersButton.Enabled = enabled;
        }
    }
}
