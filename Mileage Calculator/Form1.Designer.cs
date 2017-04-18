namespace Mileage_Calculator
{
    partial class MessageCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MessageCalculator));
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.StartingMileageLabel = new System.Windows.Forms.Label();
            this.EndingMileageLabel = new System.Windows.Forms.Label();
            this.amountLabel = new System.Windows.Forms.Label();
            this.calculatedAmountLabel = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.calculateButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(181, 24);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(160, 24);
            this.numericUpDown1.TabIndex = 0;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // StartingMileageLabel
            // 
            this.StartingMileageLabel.AutoSize = true;
            this.StartingMileageLabel.Location = new System.Drawing.Point(40, 30);
            this.StartingMileageLabel.Name = "StartingMileageLabel";
            this.StartingMileageLabel.Size = new System.Drawing.Size(113, 18);
            this.StartingMileageLabel.TabIndex = 1;
            this.StartingMileageLabel.Text = "Starting Mileage";
            // 
            // EndingMileageLabel
            // 
            this.EndingMileageLabel.AutoSize = true;
            this.EndingMileageLabel.Location = new System.Drawing.Point(40, 68);
            this.EndingMileageLabel.Name = "EndingMileageLabel";
            this.EndingMileageLabel.Size = new System.Drawing.Size(108, 18);
            this.EndingMileageLabel.TabIndex = 2;
            this.EndingMileageLabel.Text = "Ending Mileage";
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.Location = new System.Drawing.Point(40, 111);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(102, 18);
            this.amountLabel.TabIndex = 3;
            this.amountLabel.Text = "Amount Owed";
            // 
            // calculatedAmountLabel
            // 
            this.calculatedAmountLabel.AutoSize = true;
            this.calculatedAmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.calculatedAmountLabel.Location = new System.Drawing.Point(236, 111);
            this.calculatedAmountLabel.Name = "calculatedAmountLabel";
            this.calculatedAmountLabel.Size = new System.Drawing.Size(29, 20);
            this.calculatedAmountLabel.TabIndex = 4;
            this.calculatedAmountLabel.Text = "$0";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(181, 62);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(160, 24);
            this.numericUpDown2.TabIndex = 5;
            this.numericUpDown2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(43, 157);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(125, 30);
            this.calculateButton.TabIndex = 6;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            // 
            // MessageCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 211);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.calculatedAmountLabel);
            this.Controls.Add(this.amountLabel);
            this.Controls.Add(this.EndingMileageLabel);
            this.Controls.Add(this.StartingMileageLabel);
            this.Controls.Add(this.numericUpDown1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MessageCalculator";
            this.Text = "Mileage Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label StartingMileageLabel;
        private System.Windows.Forms.Label EndingMileageLabel;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.Label calculatedAmountLabel;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Button calculateButton;
    }
}

