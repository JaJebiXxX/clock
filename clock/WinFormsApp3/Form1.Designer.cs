namespace WinFormsApp3
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
            zegar = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)zegar).BeginInit();
            SuspendLayout();
            // 
            // zegar
            // 
            zegar.Location = new Point(100, 100);
            zegar.Margin = new Padding(4);
            zegar.Name = "zegar";
            zegar.Size = new Size(420, 420);
            zegar.TabIndex = 0;
            zegar.TabStop = false;
            zegar.Paint += pictureBox1_Paint;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 250;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(632, 603);
            Controls.Add(zegar);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)zegar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox zegar;
        private System.Windows.Forms.Timer timer1;
    }
}
