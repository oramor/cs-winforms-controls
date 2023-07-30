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
            this.customTextBox1 = new TextBoxAsync.CustomTextBox();
            this.customTextBox2 = new TextBoxAsync.CustomTextBox();
            this.customTextBox3 = new TextBoxAsync.CustomTextBox();
            this.customTextBox4 = new TextBoxAsync.CustomTextBox();
            this.reloadButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // customTextBox1
            // 
            this.customTextBox1.BindingName = "Prop1";
            this.customTextBox1.Location = new System.Drawing.Point(149, 20);
            this.customTextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.customTextBox1.Name = "customTextBox1";
            this.customTextBox1.Size = new System.Drawing.Size(350, 31);
            this.customTextBox1.TabIndex = 0;
            // 
            // customTextBox2
            // 
            this.customTextBox2.BindingName = "Prop2";
            this.customTextBox2.Location = new System.Drawing.Point(149, 68);
            this.customTextBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.customTextBox2.Name = "customTextBox2";
            this.customTextBox2.Size = new System.Drawing.Size(350, 31);
            this.customTextBox2.TabIndex = 1;
            // 
            // customTextBox3
            // 
            this.customTextBox3.BindingName = "Prop3";
            this.customTextBox3.Location = new System.Drawing.Point(149, 117);
            this.customTextBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.customTextBox3.Name = "customTextBox3";
            this.customTextBox3.Size = new System.Drawing.Size(350, 31);
            this.customTextBox3.TabIndex = 2;
            // 
            // customTextBox4
            // 
            this.customTextBox4.BindingName = "Prop4";
            this.customTextBox4.Location = new System.Drawing.Point(149, 165);
            this.customTextBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.customTextBox4.Name = "customTextBox4";
            this.customTextBox4.Size = new System.Drawing.Size(350, 31);
            this.customTextBox4.TabIndex = 3;
            // 
            // reloadButton
            // 
            this.reloadButton.Location = new System.Drawing.Point(149, 231);
            this.reloadButton.Name = "reloadButton";
            this.reloadButton.Size = new System.Drawing.Size(112, 34);
            this.reloadButton.TabIndex = 4;
            this.reloadButton.Text = "Reload";
            this.reloadButton.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 385);
            this.Controls.Add(this.reloadButton);
            this.Controls.Add(this.customTextBox4);
            this.Controls.Add(this.customTextBox3);
            this.Controls.Add(this.customTextBox2);
            this.Controls.Add(this.customTextBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomTextBox customTextBox1;
        private CustomTextBox customTextBox2;
        private CustomTextBox customTextBox3;
        private CustomTextBox customTextBox4;
        private Button reloadButton;
    }
}