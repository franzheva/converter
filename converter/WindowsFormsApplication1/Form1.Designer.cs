namespace WindowsFormsApplication1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.currency_cb = new System.Windows.Forms.ComboBox();
            this.USD_price_tb = new System.Windows.Forms.TextBox();
            this.converted_price_tb = new System.Windows.Forms.TextBox();
            this.Convert_btn = new System.Windows.Forms.Button();
            this.clear_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Put the price (USD):*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "convert to:";
            // 
            // currency_cb
            // 
            this.currency_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.currency_cb.FormattingEnabled = true;
            this.currency_cb.Items.AddRange(new object[] {
            "UAN",
            "EUR",
            "GPB"});
            this.currency_cb.Location = new System.Drawing.Point(86, 62);
            this.currency_cb.Name = "currency_cb";
            this.currency_cb.Size = new System.Drawing.Size(53, 21);
            this.currency_cb.TabIndex = 2;
            // 
            // USD_price_tb
            // 
            this.USD_price_tb.Location = new System.Drawing.Point(149, 32);
            this.USD_price_tb.Name = "USD_price_tb";
            this.USD_price_tb.Size = new System.Drawing.Size(100, 20);
            this.USD_price_tb.TabIndex = 3;
            this.USD_price_tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.USD_price_tb_KeyPress);
            // 
            // converted_price_tb
            // 
            this.converted_price_tb.Location = new System.Drawing.Point(149, 63);
            this.converted_price_tb.Name = "converted_price_tb";
            this.converted_price_tb.Size = new System.Drawing.Size(100, 20);
            this.converted_price_tb.TabIndex = 4;
            // 
            // Convert_btn
            // 
            this.Convert_btn.Location = new System.Drawing.Point(64, 114);
            this.Convert_btn.Name = "Convert_btn";
            this.Convert_btn.Size = new System.Drawing.Size(75, 23);
            this.Convert_btn.TabIndex = 5;
            this.Convert_btn.Text = "Convert";
            this.Convert_btn.UseVisualStyleBackColor = true;
            this.Convert_btn.Click += new System.EventHandler(this.Convert_btn_Click);
            // 
            // clear_btn
            // 
            this.clear_btn.Location = new System.Drawing.Point(159, 114);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(75, 23);
            this.clear_btn.TabIndex = 6;
            this.clear_btn.Text = "Clear";
            this.clear_btn.UseVisualStyleBackColor = true;
            this.clear_btn.Click += new System.EventHandler(this.clear_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 158);
            this.Controls.Add(this.clear_btn);
            this.Controls.Add(this.Convert_btn);
            this.Controls.Add(this.converted_price_tb);
            this.Controls.Add(this.USD_price_tb);
            this.Controls.Add(this.currency_cb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Price converter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox currency_cb;
        private System.Windows.Forms.TextBox USD_price_tb;
        private System.Windows.Forms.TextBox converted_price_tb;
        private System.Windows.Forms.Button Convert_btn;
        private System.Windows.Forms.Button clear_btn;
    }
}

