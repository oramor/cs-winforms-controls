namespace SmartRefControl
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
            smartRefControl1 = new SmartRefControlNew();
            SuspendLayout();
            // 
            // smartRefControl1
            // 
            smartRefControl1.Host = smartRefControl1;
            smartRefControl1.IsDropDown = false;
            smartRefControl1.Location = new Point(93, 31);
            smartRefControl1.Name = "smartRefControl1";
            smartRefControl1.Size = new Size(100, 23);
            smartRefControl1.TabIndex = 0;
            smartRefControl1.Text = "smartRefControl1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(475, 238);
            Controls.Add(smartRefControl1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private SmartRefControlNew smartRefControl1;
    }
}