namespace First_MethodOpt_
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
            this.AddFunction = new System.Windows.Forms.Button();
            this.txtX1 = new System.Windows.Forms.TextBox();
            this.TxtResult = new System.Windows.Forms.TextBox();
            this.txtX2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_sign = new System.Windows.Forms.ComboBox();
            this.txt_AllFunction = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtX2F = new System.Windows.Forms.TextBox();
            this.txtX1F = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtF_max = new System.Windows.Forms.TextBox();
            this.txtF_min = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // AddFunction
            // 
            this.AddFunction.Location = new System.Drawing.Point(292, 9);
            this.AddFunction.Name = "AddFunction";
            this.AddFunction.Size = new System.Drawing.Size(75, 23);
            this.AddFunction.TabIndex = 0;
            this.AddFunction.Text = "Add";
            this.AddFunction.UseVisualStyleBackColor = true;
            this.AddFunction.Click += new System.EventHandler(this.AddFunction_Click);
            // 
            // txtX1
            // 
            this.txtX1.Location = new System.Drawing.Point(12, 12);
            this.txtX1.Name = "txtX1";
            this.txtX1.Size = new System.Drawing.Size(58, 20);
            this.txtX1.TabIndex = 1;
            // 
            // TxtResult
            // 
            this.TxtResult.Location = new System.Drawing.Point(228, 10);
            this.TxtResult.Name = "TxtResult";
            this.TxtResult.Size = new System.Drawing.Size(58, 20);
            this.TxtResult.TabIndex = 2;
            // 
            // txtX2
            // 
            this.txtX2.Location = new System.Drawing.Point(100, 11);
            this.txtX2.Name = "txtX2";
            this.txtX2.Size = new System.Drawing.Size(58, 20);
            this.txtX2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "x1";
            // 
            // cmb_sign
            // 
            this.cmb_sign.FormattingEnabled = true;
            this.cmb_sign.Items.AddRange(new object[] {
            ">",
            ">=",
            "<",
            "<=",
            "="});
            this.cmb_sign.Location = new System.Drawing.Point(188, 11);
            this.cmb_sign.Name = "cmb_sign";
            this.cmb_sign.Size = new System.Drawing.Size(34, 21);
            this.cmb_sign.TabIndex = 5;
            // 
            // txt_AllFunction
            // 
            this.txt_AllFunction.Location = new System.Drawing.Point(12, 38);
            this.txt_AllFunction.Multiline = true;
            this.txt_AllFunction.Name = "txt_AllFunction";
            this.txt_AllFunction.Size = new System.Drawing.Size(163, 327);
            this.txt_AllFunction.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(164, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "x2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(185, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Function";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(396, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "x2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(308, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "x1";
            // 
            // txtX2F
            // 
            this.txtX2F.Location = new System.Drawing.Point(332, 61);
            this.txtX2F.Name = "txtX2F";
            this.txtX2F.Size = new System.Drawing.Size(58, 20);
            this.txtX2F.TabIndex = 10;
            // 
            // txtX1F
            // 
            this.txtX1F.Location = new System.Drawing.Point(244, 62);
            this.txtX1F.Name = "txtX1F";
            this.txtX1F.Size = new System.Drawing.Size(58, 20);
            this.txtX1F.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(420, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(185, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "F(max)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(185, 162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "F(min)";
            // 
            // txtF_max
            // 
            this.txtF_max.Location = new System.Drawing.Point(229, 134);
            this.txtF_max.Name = "txtF_max";
            this.txtF_max.Size = new System.Drawing.Size(58, 20);
            this.txtF_max.TabIndex = 16;
            // 
            // txtF_min
            // 
            this.txtF_min.Location = new System.Drawing.Point(229, 162);
            this.txtF_min.Name = "txtF_min";
            this.txtF_min.Size = new System.Drawing.Size(58, 20);
            this.txtF_min.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 377);
            this.Controls.Add(this.txtF_min);
            this.Controls.Add(this.txtF_max);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtX2F);
            this.Controls.Add(this.txtX1F);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_AllFunction);
            this.Controls.Add(this.cmb_sign);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtX2);
            this.Controls.Add(this.TxtResult);
            this.Controls.Add(this.txtX1);
            this.Controls.Add(this.AddFunction);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddFunction;
        private System.Windows.Forms.TextBox txtX1;
        private System.Windows.Forms.TextBox TxtResult;
        private System.Windows.Forms.TextBox txtX2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_sign;
        private System.Windows.Forms.TextBox txt_AllFunction;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtX2F;
        private System.Windows.Forms.TextBox txtX1F;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtF_max;
        private System.Windows.Forms.TextBox txtF_min;
    }
}

