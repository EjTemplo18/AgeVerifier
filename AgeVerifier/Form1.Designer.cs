namespace AgeVerifier
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
            textBoxInputOutput = new TextBox();
            label1 = new Label();
            buttonVerifyAge = new Button();
            SuspendLayout();
            // 
            // textBoxInputOutput
            // 
            textBoxInputOutput.Location = new Point(143, 80);
            textBoxInputOutput.Name = "textBoxInputOutput";
            textBoxInputOutput.Size = new Size(125, 27);
            textBoxInputOutput.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(98, 83);
            label1.Name = "label1";
            label1.Size = new Size(39, 20);
            label1.TabIndex = 1;
            label1.Text = "Age:";
            // 
            // buttonVerifyAge
            // 
            buttonVerifyAge.Location = new Point(117, 113);
            buttonVerifyAge.Name = "buttonVerifyAge";
            buttonVerifyAge.Size = new Size(127, 40);
            buttonVerifyAge.TabIndex = 2;
            buttonVerifyAge.Text = "Verify Age";
            buttonVerifyAge.UseVisualStyleBackColor = true;
            buttonVerifyAge.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(372, 243);
            Controls.Add(buttonVerifyAge);
            Controls.Add(label1);
            Controls.Add(textBoxInputOutput);
            Name = "Form1";
            Text = "Age Verifier";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxInputOutput;
        private Label label1;
        private Button buttonVerifyAge;
    }
}
