namespace Week3_SetC_3
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
            this.Txtbox_calls = new System.Windows.Forms.TextBox();
            this.Txtbox_month = new System.Windows.Forms.TextBox();
            this.Btn_calculate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Txtbox_tolCharge = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Billing period in month";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Number of local calls";
            // 
            // Txtbox_calls
            // 
            this.Txtbox_calls.Location = new System.Drawing.Point(210, 114);
            this.Txtbox_calls.Name = "Txtbox_calls";
            this.Txtbox_calls.Size = new System.Drawing.Size(100, 22);
            this.Txtbox_calls.TabIndex = 2;
            this.Txtbox_calls.TextChanged += new System.EventHandler(this.Txtbox_calls_TextChanged);
            // 
            // Txtbox_month
            // 
            this.Txtbox_month.Location = new System.Drawing.Point(210, 56);
            this.Txtbox_month.Name = "Txtbox_month";
            this.Txtbox_month.Size = new System.Drawing.Size(100, 22);
            this.Txtbox_month.TabIndex = 1;
            this.Txtbox_month.TextChanged += new System.EventHandler(this.Txtbox_month_TextChanged);
            // 
            // Btn_calculate
            // 
            this.Btn_calculate.Location = new System.Drawing.Point(103, 178);
            this.Btn_calculate.Name = "Btn_calculate";
            this.Btn_calculate.Size = new System.Drawing.Size(174, 26);
            this.Btn_calculate.TabIndex = 3;
            this.Btn_calculate.Text = "Calculate Charge";
            this.Btn_calculate.UseVisualStyleBackColor = true;
            this.Btn_calculate.Click += new System.EventHandler(this.Btn_calculate_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Display total Charge";
            // 
            // Txtbox_tolCharge
            // 
            this.Txtbox_tolCharge.Location = new System.Drawing.Point(210, 230);
            this.Txtbox_tolCharge.Name = "Txtbox_tolCharge";
            this.Txtbox_tolCharge.Size = new System.Drawing.Size(100, 22);
            this.Txtbox_tolCharge.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 302);
            this.Controls.Add(this.Txtbox_tolCharge);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Btn_calculate);
            this.Controls.Add(this.Txtbox_month);
            this.Controls.Add(this.Txtbox_calls);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Ex: Set C-3";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txtbox_calls;
        private System.Windows.Forms.TextBox Txtbox_month;
        private System.Windows.Forms.Button Btn_calculate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txtbox_tolCharge;
    }
}

