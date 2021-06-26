
namespace ChangeCalculator
{
    partial class Change
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
            this.PriceInput = new System.Windows.Forms.TextBox();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PayedInput = new System.Windows.Forms.TextBox();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PriceInput
            // 
            this.PriceInput.Location = new System.Drawing.Point(156, 36);
            this.PriceInput.Name = "PriceInput";
            this.PriceInput.Size = new System.Drawing.Size(200, 39);
            this.PriceInput.TabIndex = 0;
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Location = new System.Drawing.Point(37, 39);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(56, 32);
            this.PriceLabel.TabIndex = 1;
            this.PriceLabel.Text = "Pris:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Betalat:";
            // 
            // PayedInput
            // 
            this.PayedInput.Location = new System.Drawing.Point(156, 96);
            this.PayedInput.Name = "PayedInput";
            this.PayedInput.Size = new System.Drawing.Size(200, 39);
            this.PayedInput.TabIndex = 2;
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(37, 171);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(319, 46);
            this.SubmitButton.TabIndex = 4;
            this.SubmitButton.Text = "Beräkna växel";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 260);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PayedInput);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.PriceInput);
            this.Name = "Form1";
            this.Text = "Växel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PriceInput;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PayedInput;
        private System.Windows.Forms.Button SubmitButton;
    }
}

