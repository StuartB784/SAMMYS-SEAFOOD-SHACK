namespace SAMMYS_SEAFOOD_SHACK
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
            this.lobsterLabel = new System.Windows.Forms.Label();
            this.musselLabel = new System.Windows.Forms.Label();
            this.saltyWaterLabel = new System.Windows.Forms.Label();
            this.lobsterInput = new System.Windows.Forms.TextBox();
            this.musselsInput = new System.Windows.Forms.TextBox();
            this.saltywaterInput = new System.Windows.Forms.TextBox();
            this.receipt = new System.Windows.Forms.Label();
            this.calcTotalButton = new System.Windows.Forms.Button();
            this.subtotal = new System.Windows.Forms.Label();
            this.taxButton = new System.Windows.Forms.Label();
            this.total = new System.Windows.Forms.Label();
            this.subtotalOutput = new System.Windows.Forms.Label();
            this.taxOutput = new System.Windows.Forms.Label();
            this.totalOutput = new System.Windows.Forms.Label();
            this.divideLabel = new System.Windows.Forms.Label();
            this.tenderedBox = new System.Windows.Forms.Label();
            this.changeLabel = new System.Windows.Forms.Label();
            this.changeOutput = new System.Windows.Forms.Label();
            this.calcChange = new System.Windows.Forms.Button();
            this.printreceiptButton = new System.Windows.Forms.Button();
            this.tenderedInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lobsterLabel
            // 
            this.lobsterLabel.AutoSize = true;
            this.lobsterLabel.Location = new System.Drawing.Point(12, 9);
            this.lobsterLabel.Name = "lobsterLabel";
            this.lobsterLabel.Size = new System.Drawing.Size(42, 13);
            this.lobsterLabel.TabIndex = 0;
            this.lobsterLabel.Text = "Lobster";
            // 
            // musselLabel
            // 
            this.musselLabel.AutoSize = true;
            this.musselLabel.Location = new System.Drawing.Point(12, 43);
            this.musselLabel.Name = "musselLabel";
            this.musselLabel.Size = new System.Drawing.Size(45, 13);
            this.musselLabel.TabIndex = 1;
            this.musselLabel.Text = "Mussels";
            // 
            // saltyWaterLabel
            // 
            this.saltyWaterLabel.AutoSize = true;
            this.saltyWaterLabel.Location = new System.Drawing.Point(12, 80);
            this.saltyWaterLabel.Name = "saltyWaterLabel";
            this.saltyWaterLabel.Size = new System.Drawing.Size(62, 13);
            this.saltyWaterLabel.TabIndex = 2;
            this.saltyWaterLabel.Text = "Salty Water";
            // 
            // lobsterInput
            // 
            this.lobsterInput.Location = new System.Drawing.Point(83, 9);
            this.lobsterInput.Name = "lobsterInput";
            this.lobsterInput.Size = new System.Drawing.Size(40, 20);
            this.lobsterInput.TabIndex = 3;
            // 
            // musselsInput
            // 
            this.musselsInput.Location = new System.Drawing.Point(83, 43);
            this.musselsInput.Name = "musselsInput";
            this.musselsInput.Size = new System.Drawing.Size(40, 20);
            this.musselsInput.TabIndex = 4;
            // 
            // saltywaterInput
            // 
            this.saltywaterInput.Location = new System.Drawing.Point(83, 80);
            this.saltywaterInput.Name = "saltywaterInput";
            this.saltywaterInput.Size = new System.Drawing.Size(40, 20);
            this.saltywaterInput.TabIndex = 5;
            // 
            // receipt
            // 
            this.receipt.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.receipt.Location = new System.Drawing.Point(193, 9);
            this.receipt.Name = "receipt";
            this.receipt.Size = new System.Drawing.Size(321, 318);
            this.receipt.TabIndex = 6;
            // 
            // calcTotalButton
            // 
            this.calcTotalButton.Location = new System.Drawing.Point(36, 106);
            this.calcTotalButton.Name = "calcTotalButton";
            this.calcTotalButton.Size = new System.Drawing.Size(122, 23);
            this.calcTotalButton.TabIndex = 7;
            this.calcTotalButton.Text = "Calculate Total";
            this.calcTotalButton.UseVisualStyleBackColor = true;
            // 
            // subtotal
            // 
            this.subtotal.AutoSize = true;
            this.subtotal.Location = new System.Drawing.Point(12, 134);
            this.subtotal.Name = "subtotal";
            this.subtotal.Size = new System.Drawing.Size(53, 13);
            this.subtotal.TabIndex = 8;
            this.subtotal.Text = "Sub-Total";
            // 
            // taxButton
            // 
            this.taxButton.AutoSize = true;
            this.taxButton.Location = new System.Drawing.Point(12, 158);
            this.taxButton.Name = "taxButton";
            this.taxButton.Size = new System.Drawing.Size(25, 13);
            this.taxButton.TabIndex = 9;
            this.taxButton.Text = "Tax";
            // 
            // total
            // 
            this.total.AutoSize = true;
            this.total.Location = new System.Drawing.Point(12, 185);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(31, 13);
            this.total.TabIndex = 10;
            this.total.Text = "Total";
            // 
            // subtotalOutput
            // 
            this.subtotalOutput.AutoSize = true;
            this.subtotalOutput.Location = new System.Drawing.Point(141, 134);
            this.subtotalOutput.Name = "subtotalOutput";
            this.subtotalOutput.Size = new System.Drawing.Size(28, 13);
            this.subtotalOutput.TabIndex = 11;
            this.subtotalOutput.Text = "0.00";
            // 
            // taxOutput
            // 
            this.taxOutput.AutoSize = true;
            this.taxOutput.Location = new System.Drawing.Point(141, 158);
            this.taxOutput.Name = "taxOutput";
            this.taxOutput.Size = new System.Drawing.Size(28, 13);
            this.taxOutput.TabIndex = 12;
            this.taxOutput.Text = "0.00";
            // 
            // totalOutput
            // 
            this.totalOutput.AutoSize = true;
            this.totalOutput.Location = new System.Drawing.Point(141, 185);
            this.totalOutput.Name = "totalOutput";
            this.totalOutput.Size = new System.Drawing.Size(28, 13);
            this.totalOutput.TabIndex = 13;
            this.totalOutput.Text = "0.00";
            // 
            // divideLabel
            // 
            this.divideLabel.BackColor = System.Drawing.Color.SeaGreen;
            this.divideLabel.Location = new System.Drawing.Point(12, 207);
            this.divideLabel.Name = "divideLabel";
            this.divideLabel.Size = new System.Drawing.Size(164, 10);
            this.divideLabel.TabIndex = 14;
            // 
            // tenderedBox
            // 
            this.tenderedBox.AutoSize = true;
            this.tenderedBox.Location = new System.Drawing.Point(12, 232);
            this.tenderedBox.Name = "tenderedBox";
            this.tenderedBox.Size = new System.Drawing.Size(53, 13);
            this.tenderedBox.TabIndex = 15;
            this.tenderedBox.Text = "Tendered";
            // 
            // changeLabel
            // 
            this.changeLabel.AutoSize = true;
            this.changeLabel.Location = new System.Drawing.Point(12, 281);
            this.changeLabel.Name = "changeLabel";
            this.changeLabel.Size = new System.Drawing.Size(44, 13);
            this.changeLabel.TabIndex = 16;
            this.changeLabel.Text = "Change";
            // 
            // changeOutput
            // 
            this.changeOutput.AutoSize = true;
            this.changeOutput.Location = new System.Drawing.Point(141, 281);
            this.changeOutput.Name = "changeOutput";
            this.changeOutput.Size = new System.Drawing.Size(28, 13);
            this.changeOutput.TabIndex = 17;
            this.changeOutput.Text = "0.00";
            // 
            // calcChange
            // 
            this.calcChange.Location = new System.Drawing.Point(36, 255);
            this.calcChange.Name = "calcChange";
            this.calcChange.Size = new System.Drawing.Size(122, 23);
            this.calcChange.TabIndex = 18;
            this.calcChange.Text = "Calculate Change";
            this.calcChange.UseVisualStyleBackColor = true;
            // 
            // printreceiptButton
            // 
            this.printreceiptButton.Location = new System.Drawing.Point(36, 304);
            this.printreceiptButton.Name = "printreceiptButton";
            this.printreceiptButton.Size = new System.Drawing.Size(122, 23);
            this.printreceiptButton.TabIndex = 19;
            this.printreceiptButton.Text = "Print Receipt";
            this.printreceiptButton.UseVisualStyleBackColor = true;
            // 
            // tenderedInput
            // 
            this.tenderedInput.Location = new System.Drawing.Point(117, 225);
            this.tenderedInput.Name = "tenderedInput";
            this.tenderedInput.Size = new System.Drawing.Size(59, 20);
            this.tenderedInput.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(526, 336);
            this.Controls.Add(this.tenderedInput);
            this.Controls.Add(this.printreceiptButton);
            this.Controls.Add(this.calcChange);
            this.Controls.Add(this.changeOutput);
            this.Controls.Add(this.changeLabel);
            this.Controls.Add(this.tenderedBox);
            this.Controls.Add(this.divideLabel);
            this.Controls.Add(this.totalOutput);
            this.Controls.Add(this.taxOutput);
            this.Controls.Add(this.subtotalOutput);
            this.Controls.Add(this.total);
            this.Controls.Add(this.taxButton);
            this.Controls.Add(this.subtotal);
            this.Controls.Add(this.calcTotalButton);
            this.Controls.Add(this.receipt);
            this.Controls.Add(this.saltywaterInput);
            this.Controls.Add(this.musselsInput);
            this.Controls.Add(this.lobsterInput);
            this.Controls.Add(this.saltyWaterLabel);
            this.Controls.Add(this.musselLabel);
            this.Controls.Add(this.lobsterLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lobsterLabel;
        private System.Windows.Forms.Label musselLabel;
        private System.Windows.Forms.Label saltyWaterLabel;
        private System.Windows.Forms.TextBox lobsterInput;
        private System.Windows.Forms.TextBox musselsInput;
        private System.Windows.Forms.TextBox saltywaterInput;
        private System.Windows.Forms.Label receipt;
        private System.Windows.Forms.Button calcTotalButton;
        private System.Windows.Forms.Label subtotal;
        private System.Windows.Forms.Label taxButton;
        private System.Windows.Forms.Label total;
        private System.Windows.Forms.Label subtotalOutput;
        private System.Windows.Forms.Label taxOutput;
        private System.Windows.Forms.Label totalOutput;
        private System.Windows.Forms.Label divideLabel;
        private System.Windows.Forms.Label tenderedBox;
        private System.Windows.Forms.Label changeLabel;
        private System.Windows.Forms.Label changeOutput;
        private System.Windows.Forms.Button calcChange;
        private System.Windows.Forms.Button printreceiptButton;
        private System.Windows.Forms.TextBox tenderedInput;
    }
}

