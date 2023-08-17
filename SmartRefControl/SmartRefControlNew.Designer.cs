namespace SmartRefControl
{
    partial class SmartRefControlNew
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox = new TextBox();
            SuspendLayout();
            // 
            // textBox
            // 
            textBox.Anchor = AnchorStyles.Right;
            textBox.BorderStyle = BorderStyle.None;
            textBox.Name = "textBox";
            textBox.Size = new Size(100, 16);
            textBox.TabIndex = 0;
            textBox.MouseDoubleClick += TextBox_MouseDoubleClick;
            // 
            // SmartRefControl
            // 
            Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            BackColor = Color.Maroon;
            Controls.Add(textBox);
            MinimumSize = new Size(100, 20);
            Padding = new Padding(0, 0, 3, 0);
            Size = new Size(200, 20);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox;
    }
}
