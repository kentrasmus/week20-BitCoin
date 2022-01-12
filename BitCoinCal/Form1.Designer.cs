namespace BitCoinCal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.CurrencyMenu = new System.Windows.Forms.ComboBox();
            this.GetRatesBta = new System.Windows.Forms.Button();
            this.amountofBitcoins = new System.Windows.Forms.TextBox();
            this.Result = new System.Windows.Forms.TextBox();
            this.resultlab = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CurrencyMenu
            // 
            this.CurrencyMenu.FormattingEnabled = true;
            this.CurrencyMenu.Items.AddRange(new object[] {
            "EUR",
            "USD",
            "GBP"});
            this.CurrencyMenu.Location = new System.Drawing.Point(91, 55);
            this.CurrencyMenu.Name = "CurrencyMenu";
            this.CurrencyMenu.Size = new System.Drawing.Size(121, 23);
            this.CurrencyMenu.TabIndex = 0;
            this.CurrencyMenu.Text = "Slect Currency";
            // 
            // GetRatesBta
            // 
            this.GetRatesBta.Location = new System.Drawing.Point(243, 128);
            this.GetRatesBta.Name = "GetRatesBta";
            this.GetRatesBta.Size = new System.Drawing.Size(75, 23);
            this.GetRatesBta.TabIndex = 1;
            this.GetRatesBta.Text = "Get Rates";
            this.GetRatesBta.UseVisualStyleBackColor = true;
            this.GetRatesBta.Click += new System.EventHandler(this.GetRatesBta_Click);
            // 
            // amountofBitcoins
            // 
            this.amountofBitcoins.Location = new System.Drawing.Point(91, 128);
            this.amountofBitcoins.Name = "amountofBitcoins";
            this.amountofBitcoins.PlaceholderText = "Amount of bitcoins";
            this.amountofBitcoins.Size = new System.Drawing.Size(121, 23);
            this.amountofBitcoins.TabIndex = 2;
            // 
            // Result
            // 
            this.Result.Location = new System.Drawing.Point(91, 204);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(100, 23);
            this.Result.TabIndex = 3;
            this.Result.Visible = false;
            // 
            // resultlab
            // 
            this.resultlab.AutoSize = true;
            this.resultlab.Location = new System.Drawing.Point(91, 175);
            this.resultlab.Name = "resultlab";
            this.resultlab.Size = new System.Drawing.Size(36, 15);
            this.resultlab.TabIndex = 4;
            this.resultlab.Text = "result";
            this.resultlab.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resultlab);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.amountofBitcoins);
            this.Controls.Add(this.GetRatesBta);
            this.Controls.Add(this.CurrencyMenu);
            this.Name = "Form1";
            this.Text = "BitCoinCal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CurrencyMenu;
        private System.Windows.Forms.Button GetRatesBta;
        private System.Windows.Forms.TextBox amountofBitcoins;
        private System.Windows.Forms.TextBox Result;
        private System.Windows.Forms.Label resultlab;
    }
}

