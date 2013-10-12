namespace DemoForm
{
    partial class Form1
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
            this.LeftOperand = new System.Windows.Forms.NumericUpDown();
            this.RightOperand = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.LeftOperand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightOperand)).BeginInit();
            this.SuspendLayout();
            // 
            // LeftOperand
            // 
            this.LeftOperand.Location = new System.Drawing.Point(13, 13);
            this.LeftOperand.Name = "LeftOperand";
            this.LeftOperand.Size = new System.Drawing.Size(75, 20);
            this.LeftOperand.TabIndex = 0;
            // 
            // RightOperand
            // 
            this.RightOperand.Location = new System.Drawing.Point(162, 13);
            this.RightOperand.Name = "RightOperand";
            this.RightOperand.Size = new System.Drawing.Size(80, 20);
            this.RightOperand.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "+";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(93, 52);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.DisplayResultButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 85);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RightOperand);
            this.Controls.Add(this.LeftOperand);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.LeftOperand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightOperand)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown LeftOperand;
        private System.Windows.Forms.NumericUpDown RightOperand;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}

