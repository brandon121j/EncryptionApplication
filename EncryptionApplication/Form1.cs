using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace EncryptionApplication
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            string configMacKey = config.AppSettings.Settings["macKey"].Value;

            string configInputDirectory = config.AppSettings.Settings["inputFolderDirectory"].Value;

            string configOutputDirectory = config.AppSettings.Settings["outputFolderDirectory"].Value;

            keyTextbox.Text = configMacKey;

            inputDirTextbox.Text = configInputDirectory;

            outputDirTextbox.Text = configOutputDirectory;

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            FolderBrowserDialog inputFolderDialog = new FolderBrowserDialog();
            
            inputFolderDialog.ShowNewFolderButton = true;

            inputFolderDialog.RootFolder = Environment.SpecialFolder.Desktop;

            inputFolderDialog.SelectedPath = inputDirTextbox.Text;

            DialogResult dialogResults = inputFolderDialog.ShowDialog();

            if (dialogResults == DialogResult.OK)
            {
                inputDirTextbox.Text = inputFolderDialog.SelectedPath;
                config.AppSettings.Settings["inputFolderDirectory"].Value = inputDirTextbox.Text;
                config.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("appSettings");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        public void outputBrowseFolders_Click(object sender, EventArgs e)
        {
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            FolderBrowserDialog outputFolderDialog = new FolderBrowserDialog();

            outputFolderDialog.RootFolder = Environment.SpecialFolder.Desktop;

            outputFolderDialog.SelectedPath = outputDirTextbox.Text;

            Console.WriteLine(config.AppSettings.Settings["inputFolderDirectory"].Value);

            outputFolderDialog.ShowNewFolderButton = true;

            DialogResult dialogResults = outputFolderDialog.ShowDialog();

            if (dialogResults == DialogResult.OK)
            {
                outputDirTextbox.Text = outputFolderDialog.SelectedPath;
                config.AppSettings.Settings["outputFolderDirectory"].Value = outputDirTextbox.Text;
                config.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("appSettings");
            }

        }

        private void encryptButton_Click(object sender, EventArgs e)
        {
            progressBar.Value = 0;

            string[] inputFiles = Directory.GetFiles(inputDirTextbox.Text);

            int fileCount = inputFiles.Count();

            progressBar.Minimum = 0;

            progressBar.Maximum = fileCount;

            string outputFolder = outputDirTextbox.Text;

            string macKey = keyTextbox.Text;
       
            foreach (string file in inputFiles)
            {
                string inputFileName = Path.GetFileName(file);

                string outputFile = Path.Combine(outputFolder, inputFileName);

                outputFile = Path.ChangeExtension(outputFile, ".ems");

                EncryptionCode.EncryptFile(file, outputFile, macKey);

                progressBar.Value++;

                filesCompletedCounter.Text = $"{progressBar.Value} of {progressBar.Maximum} files encrypted";

                filesCompletedCounter.Update();

            }

            filesCompletedCounter.Text = $"All {progressBar.Value} files encrypted!";

            filesCompletedCounter.Update();

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void keyTextbox_TextChanged(object sender, EventArgs e)
        {
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            config.AppSettings.Settings["macKey"].Value = keyTextbox.Text;

            config.Save(ConfigurationSaveMode.Modified);

            ConfigurationManager.RefreshSection("appSettings");
        }
    }
}
