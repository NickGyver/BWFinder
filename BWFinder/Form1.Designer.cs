
namespace BWFinder
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
            this.BWLibGB = new System.Windows.Forms.GroupBox();
            this.browseLibButton = new System.Windows.Forms.Button();
            this.libPathTB = new System.Windows.Forms.TextBox();
            this.workSpaceGB = new System.Windows.Forms.GroupBox();
            this.outFilesLB = new System.Windows.Forms.ListBox();
            this.startButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.pauseButton = new System.Windows.Forms.Button();
            this.controlGB = new System.Windows.Forms.GroupBox();
            this.saveRepGB = new System.Windows.Forms.GroupBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.saveRepButton = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.entrFoundLBL = new System.Windows.Forms.ToolStripStatusLabel();
            this.BWLibGB.SuspendLayout();
            this.workSpaceGB.SuspendLayout();
            this.controlGB.SuspendLayout();
            this.saveRepGB.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BWLibGB
            // 
            this.BWLibGB.Controls.Add(this.browseLibButton);
            this.BWLibGB.Controls.Add(this.libPathTB);
            this.BWLibGB.Location = new System.Drawing.Point(8, 8);
            this.BWLibGB.Name = "BWLibGB";
            this.BWLibGB.Size = new System.Drawing.Size(458, 47);
            this.BWLibGB.TabIndex = 0;
            this.BWLibGB.TabStop = false;
            this.BWLibGB.Text = "Bad words library:";
            // 
            // browseLibButton
            // 
            this.browseLibButton.Location = new System.Drawing.Point(377, 16);
            this.browseLibButton.Name = "browseLibButton";
            this.browseLibButton.Size = new System.Drawing.Size(75, 23);
            this.browseLibButton.TabIndex = 1;
            this.browseLibButton.Text = "Browse";
            this.browseLibButton.UseVisualStyleBackColor = true;
            this.browseLibButton.Click += new System.EventHandler(this.browseLibButton_Click);
            // 
            // libPathTB
            // 
            this.libPathTB.Location = new System.Drawing.Point(6, 16);
            this.libPathTB.Name = "libPathTB";
            this.libPathTB.PlaceholderText = "Choose .txt file...";
            this.libPathTB.Size = new System.Drawing.Size(365, 23);
            this.libPathTB.TabIndex = 0;
            // 
            // workSpaceGB
            // 
            this.workSpaceGB.Controls.Add(this.outFilesLB);
            this.workSpaceGB.Location = new System.Drawing.Point(8, 118);
            this.workSpaceGB.Name = "workSpaceGB";
            this.workSpaceGB.Size = new System.Drawing.Size(621, 195);
            this.workSpaceGB.TabIndex = 1;
            this.workSpaceGB.TabStop = false;
            this.workSpaceGB.Text = "WorkSpace";
            // 
            // outFilesLB
            // 
            this.outFilesLB.FormattingEnabled = true;
            this.outFilesLB.ItemHeight = 15;
            this.outFilesLB.Location = new System.Drawing.Point(6, 18);
            this.outFilesLB.Name = "outFilesLB";
            this.outFilesLB.Size = new System.Drawing.Size(608, 169);
            this.outFilesLB.TabIndex = 0;
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(6, 22);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(69, 37);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(81, 22);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(69, 37);
            this.stopButton.TabIndex = 1;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // pauseButton
            // 
            this.pauseButton.Location = new System.Drawing.Point(6, 71);
            this.pauseButton.Name = "pauseButton";
            this.pauseButton.Size = new System.Drawing.Size(144, 23);
            this.pauseButton.TabIndex = 2;
            this.pauseButton.Text = "Pause";
            this.pauseButton.UseVisualStyleBackColor = true;
            this.pauseButton.Click += new System.EventHandler(this.pauseButton_Click);
            // 
            // controlGB
            // 
            this.controlGB.Controls.Add(this.startButton);
            this.controlGB.Controls.Add(this.pauseButton);
            this.controlGB.Controls.Add(this.stopButton);
            this.controlGB.Location = new System.Drawing.Point(472, 8);
            this.controlGB.Name = "controlGB";
            this.controlGB.Size = new System.Drawing.Size(157, 104);
            this.controlGB.TabIndex = 3;
            this.controlGB.TabStop = false;
            this.controlGB.Text = "Control";
            // 
            // saveRepGB
            // 
            this.saveRepGB.Controls.Add(this.saveRepButton);
            this.saveRepGB.Controls.Add(this.textBox1);
            this.saveRepGB.Location = new System.Drawing.Point(8, 61);
            this.saveRepGB.Name = "saveRepGB";
            this.saveRepGB.Size = new System.Drawing.Size(458, 51);
            this.saveRepGB.TabIndex = 5;
            this.saveRepGB.TabStop = false;
            this.saveRepGB.Text = "Save Report:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(5, 18);
            this.textBox1.Name = "textBox1";
            this.textBox1.PlaceholderText = "Save report...";
            this.textBox1.Size = new System.Drawing.Size(366, 23);
            this.textBox1.TabIndex = 0;
            // 
            // saveRepButton
            // 
            this.saveRepButton.Location = new System.Drawing.Point(377, 18);
            this.saveRepButton.Name = "saveRepButton";
            this.saveRepButton.Size = new System.Drawing.Size(75, 23);
            this.saveRepButton.TabIndex = 1;
            this.saveRepButton.Text = "Save";
            this.saveRepButton.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1,
            this.toolStripStatusLabel1,
            this.entrFoundLBL});
            this.statusStrip1.Location = new System.Drawing.Point(0, 320);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(641, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(80, 17);
            this.toolStripStatusLabel1.Text = "Entries found:";
            // 
            // entrFoundLBL
            // 
            this.entrFoundLBL.Name = "entrFoundLBL";
            this.entrFoundLBL.Size = new System.Drawing.Size(13, 17);
            this.entrFoundLBL.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 342);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.saveRepGB);
            this.Controls.Add(this.controlGB);
            this.Controls.Add(this.workSpaceGB);
            this.Controls.Add(this.BWLibGB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "BWFinder";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.BWLibGB.ResumeLayout(false);
            this.BWLibGB.PerformLayout();
            this.workSpaceGB.ResumeLayout(false);
            this.controlGB.ResumeLayout(false);
            this.saveRepGB.ResumeLayout(false);
            this.saveRepGB.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox BWLibGB;
        private System.Windows.Forms.Button browseLibButton;
        private System.Windows.Forms.TextBox libPathTB;
        private System.Windows.Forms.GroupBox workSpaceGB;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button pauseButton;
        private System.Windows.Forms.GroupBox controlGB;
        private System.Windows.Forms.ListBox outFilesLB;
        private System.Windows.Forms.GroupBox saveRepGB;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button saveRepButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel entrFoundLBL;
    }
}

