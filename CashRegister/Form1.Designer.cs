namespace CashRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.background = new System.Windows.Forms.Label();
            this.sushibarLabel = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.titleBlock = new System.Windows.Forms.Label();
            this.sashimiLabel = new System.Windows.Forms.Label();
            this.sushiInput = new System.Windows.Forms.TextBox();
            this.sashimiInput = new System.Windows.Forms.TextBox();
            this.rollInput = new System.Windows.Forms.TextBox();
            this.sushiLabel = new System.Windows.Forms.Label();
            this.rollsLabel = new System.Windows.Forms.Label();
            this.calcButton = new System.Windows.Forms.Button();
            this.subtotalLabel = new System.Windows.Forms.Label();
            this.taxLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.subtotalPrice = new System.Windows.Forms.Label();
            this.taxAmount = new System.Windows.Forms.Label();
            this.totalPrice = new System.Windows.Forms.Label();
            this.tenderedText = new System.Windows.Forms.TextBox();
            this.tenderedLabel = new System.Windows.Forms.Label();
            this.changeButton = new System.Windows.Forms.Button();
            this.changeLabel = new System.Windows.Forms.Label();
            this.changeTotal = new System.Windows.Forms.Label();
            this.recieptPrint = new System.Windows.Forms.Button();
            this.neworderButton = new System.Windows.Forms.Button();
            this.recieptLabel = new System.Windows.Forms.Label();
            this.recieptStart = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // background
            // 
            this.background.BackColor = System.Drawing.Color.Black;
            this.background.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.background.Location = new System.Drawing.Point(13, 59);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(178, 398);
            this.background.TabIndex = 0;
            // 
            // sushibarLabel
            // 
            this.sushibarLabel.AutoSize = true;
            this.sushibarLabel.BackColor = System.Drawing.Color.Black;
            this.sushibarLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sushibarLabel.ForeColor = System.Drawing.Color.White;
            this.sushibarLabel.Location = new System.Drawing.Point(12, 9);
            this.sushibarLabel.Name = "sushibarLabel";
            this.sushibarLabel.Size = new System.Drawing.Size(78, 20);
            this.sushibarLabel.TabIndex = 1;
            this.sushibarLabel.Text = "Sushi Bar";
            this.sushibarLabel.Click += new System.EventHandler(this.sushibarLabel_Click);
            // 
            // titleBlock
            // 
            this.titleBlock.BackColor = System.Drawing.Color.Black;
            this.titleBlock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.titleBlock.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.titleBlock.Location = new System.Drawing.Point(-75, -14);
            this.titleBlock.Name = "titleBlock";
            this.titleBlock.Size = new System.Drawing.Size(619, 57);
            this.titleBlock.TabIndex = 2;
            // 
            // sashimiLabel
            // 
            this.sashimiLabel.AutoSize = true;
            this.sashimiLabel.BackColor = System.Drawing.Color.Black;
            this.sashimiLabel.ForeColor = System.Drawing.Color.White;
            this.sashimiLabel.Location = new System.Drawing.Point(28, 80);
            this.sashimiLabel.Name = "sashimiLabel";
            this.sashimiLabel.Size = new System.Drawing.Size(95, 13);
            this.sashimiLabel.TabIndex = 4;
            this.sashimiLabel.Text = "Number of Sashimi\r\n";
            // 
            // sushiInput
            // 
            this.sushiInput.Location = new System.Drawing.Point(130, 112);
            this.sushiInput.Name = "sushiInput";
            this.sushiInput.Size = new System.Drawing.Size(48, 20);
            this.sushiInput.TabIndex = 5;
            this.sushiInput.TextChanged += new System.EventHandler(this.sushiInput_TextChanged);
            // 
            // sashimiInput
            // 
            this.sashimiInput.Location = new System.Drawing.Point(130, 77);
            this.sashimiInput.Name = "sashimiInput";
            this.sashimiInput.Size = new System.Drawing.Size(48, 20);
            this.sashimiInput.TabIndex = 6;
            this.sashimiInput.TextChanged += new System.EventHandler(this.sashimiInput_TextChanged);
            // 
            // rollInput
            // 
            this.rollInput.Location = new System.Drawing.Point(130, 151);
            this.rollInput.Name = "rollInput";
            this.rollInput.Size = new System.Drawing.Size(48, 20);
            this.rollInput.TabIndex = 7;
            this.rollInput.TextChanged += new System.EventHandler(this.rollInput_TextChanged);
            // 
            // sushiLabel
            // 
            this.sushiLabel.AutoSize = true;
            this.sushiLabel.BackColor = System.Drawing.Color.Black;
            this.sushiLabel.ForeColor = System.Drawing.Color.White;
            this.sushiLabel.Location = new System.Drawing.Point(28, 119);
            this.sushiLabel.Name = "sushiLabel";
            this.sushiLabel.Size = new System.Drawing.Size(85, 13);
            this.sushiLabel.TabIndex = 8;
            this.sushiLabel.Text = "Number of Sushi";
            // 
            // rollsLabel
            // 
            this.rollsLabel.AutoSize = true;
            this.rollsLabel.BackColor = System.Drawing.Color.Black;
            this.rollsLabel.ForeColor = System.Drawing.Color.White;
            this.rollsLabel.Location = new System.Drawing.Point(28, 158);
            this.rollsLabel.Name = "rollsLabel";
            this.rollsLabel.Size = new System.Drawing.Size(82, 13);
            this.rollsLabel.TabIndex = 9;
            this.rollsLabel.Text = "Number of Rolls";
            // 
            // calcButton
            // 
            this.calcButton.Enabled = false;
            this.calcButton.Location = new System.Drawing.Point(54, 189);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(98, 22);
            this.calcButton.TabIndex = 10;
            this.calcButton.Text = "Calculate Price";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // subtotalLabel
            // 
            this.subtotalLabel.AutoSize = true;
            this.subtotalLabel.BackColor = System.Drawing.Color.Black;
            this.subtotalLabel.ForeColor = System.Drawing.Color.White;
            this.subtotalLabel.Location = new System.Drawing.Point(28, 226);
            this.subtotalLabel.Name = "subtotalLabel";
            this.subtotalLabel.Size = new System.Drawing.Size(46, 13);
            this.subtotalLabel.TabIndex = 11;
            this.subtotalLabel.Text = "Subtotal";
            // 
            // taxLabel
            // 
            this.taxLabel.AutoSize = true;
            this.taxLabel.BackColor = System.Drawing.Color.Black;
            this.taxLabel.ForeColor = System.Drawing.Color.White;
            this.taxLabel.Location = new System.Drawing.Point(28, 254);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(25, 13);
            this.taxLabel.TabIndex = 12;
            this.taxLabel.Text = "Tax";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.BackColor = System.Drawing.Color.Black;
            this.totalLabel.ForeColor = System.Drawing.Color.White;
            this.totalLabel.Location = new System.Drawing.Point(28, 286);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(31, 13);
            this.totalLabel.TabIndex = 13;
            this.totalLabel.Text = "Total";
            // 
            // subtotalPrice
            // 
            this.subtotalPrice.AutoSize = true;
            this.subtotalPrice.BackColor = System.Drawing.Color.Black;
            this.subtotalPrice.ForeColor = System.Drawing.Color.White;
            this.subtotalPrice.Location = new System.Drawing.Point(139, 226);
            this.subtotalPrice.Name = "subtotalPrice";
            this.subtotalPrice.Size = new System.Drawing.Size(13, 13);
            this.subtotalPrice.TabIndex = 14;
            this.subtotalPrice.Text = "0";
            // 
            // taxAmount
            // 
            this.taxAmount.AutoSize = true;
            this.taxAmount.BackColor = System.Drawing.Color.Black;
            this.taxAmount.ForeColor = System.Drawing.Color.White;
            this.taxAmount.Location = new System.Drawing.Point(139, 254);
            this.taxAmount.Name = "taxAmount";
            this.taxAmount.Size = new System.Drawing.Size(13, 13);
            this.taxAmount.TabIndex = 15;
            this.taxAmount.Text = "0";
            // 
            // totalPrice
            // 
            this.totalPrice.AutoSize = true;
            this.totalPrice.BackColor = System.Drawing.Color.Black;
            this.totalPrice.ForeColor = System.Drawing.Color.White;
            this.totalPrice.Location = new System.Drawing.Point(139, 286);
            this.totalPrice.Name = "totalPrice";
            this.totalPrice.Size = new System.Drawing.Size(13, 13);
            this.totalPrice.TabIndex = 16;
            this.totalPrice.Text = "0";
            // 
            // tenderedText
            // 
            this.tenderedText.Location = new System.Drawing.Point(109, 321);
            this.tenderedText.Name = "tenderedText";
            this.tenderedText.Size = new System.Drawing.Size(69, 20);
            this.tenderedText.TabIndex = 17;
            this.tenderedText.TextChanged += new System.EventHandler(this.tenderedText_TextChanged);
            // 
            // tenderedLabel
            // 
            this.tenderedLabel.AutoSize = true;
            this.tenderedLabel.BackColor = System.Drawing.Color.Black;
            this.tenderedLabel.ForeColor = System.Drawing.Color.White;
            this.tenderedLabel.Location = new System.Drawing.Point(28, 324);
            this.tenderedLabel.Name = "tenderedLabel";
            this.tenderedLabel.Size = new System.Drawing.Size(53, 13);
            this.tenderedLabel.TabIndex = 18;
            this.tenderedLabel.Text = "Tendered";
            // 
            // changeButton
            // 
            this.changeButton.Enabled = false;
            this.changeButton.Location = new System.Drawing.Point(54, 347);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(98, 20);
            this.changeButton.TabIndex = 19;
            this.changeButton.Text = "Change";
            this.changeButton.UseVisualStyleBackColor = true;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // changeLabel
            // 
            this.changeLabel.AutoSize = true;
            this.changeLabel.BackColor = System.Drawing.Color.Black;
            this.changeLabel.ForeColor = System.Drawing.Color.White;
            this.changeLabel.Location = new System.Drawing.Point(35, 390);
            this.changeLabel.Name = "changeLabel";
            this.changeLabel.Size = new System.Drawing.Size(44, 13);
            this.changeLabel.TabIndex = 20;
            this.changeLabel.Text = "Change";
            // 
            // changeTotal
            // 
            this.changeTotal.AutoSize = true;
            this.changeTotal.BackColor = System.Drawing.Color.Black;
            this.changeTotal.ForeColor = System.Drawing.Color.White;
            this.changeTotal.Location = new System.Drawing.Point(97, 390);
            this.changeTotal.Name = "changeTotal";
            this.changeTotal.Size = new System.Drawing.Size(13, 13);
            this.changeTotal.TabIndex = 21;
            this.changeTotal.Text = "0";
            // 
            // recieptPrint
            // 
            this.recieptPrint.Enabled = false;
            this.recieptPrint.Location = new System.Drawing.Point(38, 416);
            this.recieptPrint.Name = "recieptPrint";
            this.recieptPrint.Size = new System.Drawing.Size(126, 20);
            this.recieptPrint.TabIndex = 22;
            this.recieptPrint.Text = "Print Reciept";
            this.recieptPrint.UseVisualStyleBackColor = true;
            this.recieptPrint.Click += new System.EventHandler(this.recieptPrint_Click);
            // 
            // neworderButton
            // 
            this.neworderButton.Enabled = false;
            this.neworderButton.Location = new System.Drawing.Point(271, 321);
            this.neworderButton.Name = "neworderButton";
            this.neworderButton.Size = new System.Drawing.Size(104, 23);
            this.neworderButton.TabIndex = 23;
            this.neworderButton.Text = "New Order";
            this.neworderButton.UseVisualStyleBackColor = true;
            this.neworderButton.Click += new System.EventHandler(this.neworderButton_Click);
            // 
            // recieptLabel
            // 
            this.recieptLabel.AutoSize = true;
            this.recieptLabel.BackColor = System.Drawing.Color.Black;
            this.recieptLabel.Font = new System.Drawing.Font("MS UI Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recieptLabel.ForeColor = System.Drawing.Color.White;
            this.recieptLabel.Location = new System.Drawing.Point(227, 61);
            this.recieptLabel.Name = "recieptLabel";
            this.recieptLabel.Size = new System.Drawing.Size(0, 11);
            this.recieptLabel.TabIndex = 24;
            // 
            // recieptStart
            // 
            this.recieptStart.BackColor = System.Drawing.Color.Black;
            this.recieptStart.Font = new System.Drawing.Font("MS UI Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recieptStart.ForeColor = System.Drawing.Color.White;
            this.recieptStart.Location = new System.Drawing.Point(226, 61);
            this.recieptStart.Name = "recieptStart";
            this.recieptStart.Size = new System.Drawing.Size(191, 17);
            this.recieptStart.TabIndex = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 466);
            this.Controls.Add(this.recieptLabel);
            this.Controls.Add(this.recieptStart);
            this.Controls.Add(this.neworderButton);
            this.Controls.Add(this.recieptPrint);
            this.Controls.Add(this.changeTotal);
            this.Controls.Add(this.changeLabel);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.tenderedLabel);
            this.Controls.Add(this.tenderedText);
            this.Controls.Add(this.totalPrice);
            this.Controls.Add(this.taxAmount);
            this.Controls.Add(this.subtotalPrice);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.taxLabel);
            this.Controls.Add(this.subtotalLabel);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.rollsLabel);
            this.Controls.Add(this.sushiLabel);
            this.Controls.Add(this.rollInput);
            this.Controls.Add(this.sashimiInput);
            this.Controls.Add(this.sushiInput);
            this.Controls.Add(this.sashimiLabel);
            this.Controls.Add(this.sushibarLabel);
            this.Controls.Add(this.background);
            this.Controls.Add(this.titleBlock);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Sushi Bar";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label background;
        private System.Windows.Forms.Label sushibarLabel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label titleBlock;
        private System.Windows.Forms.Label sashimiLabel;
        private System.Windows.Forms.TextBox sushiInput;
        private System.Windows.Forms.TextBox sashimiInput;
        private System.Windows.Forms.TextBox rollInput;
        private System.Windows.Forms.Label sushiLabel;
        private System.Windows.Forms.Label rollsLabel;
        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.Label subtotalLabel;
        private System.Windows.Forms.Label taxLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label subtotalPrice;
        private System.Windows.Forms.Label taxAmount;
        private System.Windows.Forms.Label totalPrice;
        private System.Windows.Forms.TextBox tenderedText;
        private System.Windows.Forms.Label tenderedLabel;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Label changeLabel;
        private System.Windows.Forms.Label changeTotal;
        private System.Windows.Forms.Button recieptPrint;
        private System.Windows.Forms.Button neworderButton;
        private System.Windows.Forms.Label recieptLabel;
        private System.Windows.Forms.Label recieptStart;
    }
}

