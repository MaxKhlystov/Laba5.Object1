namespace Laba5.Objeckt
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
            components = new System.ComponentModel.Container();
            pbMain = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            txtLog = new RichTextBox();
            txtBoxPoint = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)pbMain).BeginInit();
            SuspendLayout();
            // 
            // pbMain
            // 
            pbMain.Location = new Point(0, 0);
            pbMain.Margin = new Padding(3, 4, 3, 4);
            pbMain.Name = "pbMain";
            pbMain.Size = new Size(751, 601);
            pbMain.TabIndex = 0;
            pbMain.TabStop = false;
            pbMain.Click += pbMain_Click;
            pbMain.Paint += pbMain_Paint;
            pbMain.MouseClick += PbMain;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 30;
            timer1.Tick += timer1_Tick;
            // 
            // txtLog
            // 
            txtLog.Location = new Point(758, 0);
            txtLog.Margin = new Padding(3, 4, 3, 4);
            txtLog.Name = "txtLog";
            txtLog.Size = new Size(220, 600);
            txtLog.TabIndex = 1;
            txtLog.Text = "";
            // 
            // txtBoxPoint
            // 
            txtBoxPoint.Location = new Point(671, 0);
            txtBoxPoint.Margin = new Padding(3, 4, 3, 4);
            txtBoxPoint.Name = "txtBoxPoint";
            txtBoxPoint.Size = new Size(81, 34);
            txtBoxPoint.TabIndex = 2;
            txtBoxPoint.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 600);
            Controls.Add(txtBoxPoint);
            Controls.Add(txtLog);
            Controls.Add(pbMain);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pbMain).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private PictureBox pbMain;
        private System.Windows.Forms.Timer timer1;
        private RichTextBox txtLog;
        private RichTextBox txtBoxPoint;
    }
}