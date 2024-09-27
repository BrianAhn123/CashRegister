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
            this.label1 = new System.Windows.Forms.Label();
            this.sushibarLabel = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.sushiInput = new System.Windows.Forms.TextBox();
            this.sashimiInput = new System.Windows.Forms.TextBox();
            this.rollInput = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.calcButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.subtotalPrice = new System.Windows.Forms.Label();
            this.taxAmount = new System.Windows.Forms.Label();
            this.totalPrice = new System.Windows.Forms.Label();
            this.tenderedText = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.changeButton = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.changeTotal = new System.Windows.Forms.Label();
            this.recieptPrint = new System.Windows.Forms.Button();
            this.neworderButton = new System.Windows.Forms.Button();
            this.recieptLabel = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(13, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 398);
            this.label1.TabIndex = 0;
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
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label3.Location = new System.Drawing.Point(-75, -14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(619, 57);
            this.label3.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(28, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Number of Sashimi\r\n";
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(28, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Number of Sushi";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Black;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(28, 158);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Number of Rolls";
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Black;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(28, 226);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Subtotal";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Black;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(28, 254);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(25, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Tax";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Black;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(28, 286);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Total";
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
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Black;
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(28, 324);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "Tendered";
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
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Black;
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(35, 390);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 13);
            this.label12.TabIndex = 20;
            this.label12.Text = "Change";
            // 
            // changeTotal
            // 
            this.changeTotal.AutoSize = true;
            this.changeTotal.BackColor = System.Drawing.Color.Black;
            this.changeTotal.ForeColor = System.Drawing.Color.White;
            this.changeTotal.Location = new System.Drawing.Point(139, 390);
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
            this.neworderButton.Location = new System.Drawing.Point(265, 416);
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
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.Black;
            this.label13.Font = new System.Drawing.Font("MS UI Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(226, 61);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(191, 17);
            this.label13.TabIndex = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 466);
            this.Controls.Add(this.recieptLabel);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.neworderButton);
            this.Controls.Add(this.recieptPrint);
            this.Controls.Add(this.changeTotal);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tenderedText);
            this.Controls.Add(this.totalPrice);
            this.Controls.Add(this.taxAmount);
            this.Controls.Add(this.subtotalPrice);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rollInput);
            this.Controls.Add(this.sashimiInput);
            this.Controls.Add(this.sushiInput);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.sushibarLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Sushi Bar";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label sushibarLabel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox sushiInput;
        private System.Windows.Forms.TextBox sashimiInput;
        private System.Windows.Forms.TextBox rollInput;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label subtotalPrice;
        private System.Windows.Forms.Label taxAmount;
        private System.Windows.Forms.Label totalPrice;
        private System.Windows.Forms.TextBox tenderedText;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label changeTotal;
        private System.Windows.Forms.Button recieptPrint;
        private System.Windows.Forms.Button neworderButton;
        private System.Windows.Forms.Label recieptLabel;
        private System.Windows.Forms.Label label13;
    }
}

