namespace test_data_gen
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
            this.test_data_gen = new System.Windows.Forms.Button();
            this.labelstuff = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // test_data_gen
            // 
            this.test_data_gen.Location = new System.Drawing.Point(12, 27);
            this.test_data_gen.Name = "test_data_gen";
            this.test_data_gen.Size = new System.Drawing.Size(75, 23);
            this.test_data_gen.TabIndex = 0;
            this.test_data_gen.Text = "generate";
            this.test_data_gen.UseVisualStyleBackColor = true;
            this.test_data_gen.Click += new System.EventHandler(this.test_data_gen_Click);
            // 
            // labelstuff
            // 
            this.labelstuff.AutoSize = true;
            this.labelstuff.Location = new System.Drawing.Point(12, 9);
            this.labelstuff.Name = "labelstuff";
            this.labelstuff.Size = new System.Drawing.Size(38, 15);
            this.labelstuff.TabIndex = 1;
            this.labelstuff.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1471, 450);
            this.Controls.Add(this.labelstuff);
            this.Controls.Add(this.test_data_gen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button generateBtn;
        private Button button1;
        private Button generatorBtn;
        private Button test_data_gen;
        private Label labelstuff;
    }
}