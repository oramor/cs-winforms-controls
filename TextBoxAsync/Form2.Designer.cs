namespace TextBoxAsync
{
    partial class Form2
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
            customTextBox1 = new CustomTextBox();
            customTextBox2 = new CustomTextBox();
            customTextBox3 = new CustomTextBox();
            customTextBox4 = new CustomTextBox();
            SuspendLayout();
            // 
            // customTextBox1
            // 
            customTextBox1.BindingName = "Prop1";
            customTextBox1.Location = new Point(104, 12);
            customTextBox1.Name = "customTextBox1";
            customTextBox1.Size = new Size(246, 23);
            customTextBox1.TabIndex = 0;
            // 
            // customTextBox2
            // 
            customTextBox2.BindingName = "Prop2";
            customTextBox2.Location = new Point(104, 41);
            customTextBox2.Name = "customTextBox2";
            customTextBox2.Size = new Size(246, 23);
            customTextBox2.TabIndex = 1;
            // 
            // customTextBox3
            // 
            customTextBox3.BindingName = "Prop3";
            customTextBox3.Location = new Point(104, 70);
            customTextBox3.Name = "customTextBox3";
            customTextBox3.Size = new Size(246, 23);
            customTextBox3.TabIndex = 2;
            // 
            // customTextBox4
            // 
            customTextBox4.BindingName = "Prop4";
            customTextBox4.Location = new Point(104, 99);
            customTextBox4.Name = "customTextBox4";
            customTextBox4.Size = new Size(246, 23);
            customTextBox4.TabIndex = 3;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(362, 231);
            Controls.Add(customTextBox4);
            Controls.Add(customTextBox3);
            Controls.Add(customTextBox2);
            Controls.Add(customTextBox1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CustomTextBox customTextBox1;
        private CustomTextBox customTextBox2;
        private CustomTextBox customTextBox3;
        private CustomTextBox customTextBox4;
    }
}