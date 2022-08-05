
namespace EncryptionApplication
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.encryptButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.inputBrowseFolders = new System.Windows.Forms.Button();
            this.inputDirTextbox = new System.Windows.Forms.TextBox();
            this.outputDirTextbox = new System.Windows.Forms.TextBox();
            this.outputBrowseFolders = new System.Windows.Forms.Button();
            this.keyTextbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.filesCompletedCounter = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // encryptButton
            // 
            this.encryptButton.Location = new System.Drawing.Point(178, 293);
            this.encryptButton.Name = "encryptButton";
            this.encryptButton.Size = new System.Drawing.Size(128, 40);
            this.encryptButton.TabIndex = 0;
            this.encryptButton.Text = "Encrypt";
            this.encryptButton.UseVisualStyleBackColor = true;
            this.encryptButton.Click += new System.EventHandler(this.encryptButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Input Directory";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Output Directory";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // inputBrowseFolders
            // 
            this.inputBrowseFolders.Location = new System.Drawing.Point(373, 56);
            this.inputBrowseFolders.Name = "inputBrowseFolders";
            this.inputBrowseFolders.Size = new System.Drawing.Size(94, 23);
            this.inputBrowseFolders.TabIndex = 6;
            this.inputBrowseFolders.Text = "Browse Folders";
            this.inputBrowseFolders.UseVisualStyleBackColor = true;
            this.inputBrowseFolders.Click += new System.EventHandler(this.Button2_Click);
            // 
            // inputDirTextbox
            // 
            this.inputDirTextbox.Location = new System.Drawing.Point(175, 56);
            this.inputDirTextbox.Name = "inputDirTextbox";
            this.inputDirTextbox.Size = new System.Drawing.Size(200, 23);
            this.inputDirTextbox.TabIndex = 7;
            // 
            // outputDirTextbox
            // 
            this.outputDirTextbox.Location = new System.Drawing.Point(175, 111);
            this.outputDirTextbox.Name = "outputDirTextbox";
            this.outputDirTextbox.Size = new System.Drawing.Size(200, 23);
            this.outputDirTextbox.TabIndex = 9;
            // 
            // outputBrowseFolders
            // 
            this.outputBrowseFolders.Location = new System.Drawing.Point(373, 111);
            this.outputBrowseFolders.Name = "outputBrowseFolders";
            this.outputBrowseFolders.Size = new System.Drawing.Size(94, 23);
            this.outputBrowseFolders.TabIndex = 8;
            this.outputBrowseFolders.Text = "Browse Folders";
            this.outputBrowseFolders.UseVisualStyleBackColor = true;
            this.outputBrowseFolders.Click += new System.EventHandler(this.outputBrowseFolders_Click);
            // 
            // keyTextbox
            // 
            this.keyTextbox.Location = new System.Drawing.Point(175, 166);
            this.keyTextbox.Name = "keyTextbox";
            this.keyTextbox.Size = new System.Drawing.Size(292, 23);
            this.keyTextbox.TabIndex = 12;
            this.keyTextbox.TextChanged += new System.EventHandler(this.keyTextbox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Key";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(35, 214);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(432, 23);
            this.progressBar.TabIndex = 13;
            this.progressBar.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // filesCompletedCounter
            // 
            this.filesCompletedCounter.AutoSize = true;
            this.filesCompletedCounter.Location = new System.Drawing.Point(175, 257);
            this.filesCompletedCounter.Name = "filesCompletedCounter";
            this.filesCompletedCounter.Size = new System.Drawing.Size(0, 15);
            this.filesCompletedCounter.TabIndex = 14;
            this.filesCompletedCounter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.filesCompletedCounter.Click += new System.EventHandler(this.label4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 355);
            this.Controls.Add(this.filesCompletedCounter);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.keyTextbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.outputDirTextbox);
            this.Controls.Add(this.outputBrowseFolders);
            this.Controls.Add(this.inputDirTextbox);
            this.Controls.Add(this.inputBrowseFolders);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.encryptButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Contrast Injector Tools LLC Encryptor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button encryptButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button inputBrowseFolders;
        private System.Windows.Forms.TextBox inputDirTextbox;
        private System.Windows.Forms.TextBox outputDirTextbox;
        private System.Windows.Forms.Button outputBrowseFolders;
        private System.Windows.Forms.TextBox keyTextbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label filesCompletedCounter;
    }
}

