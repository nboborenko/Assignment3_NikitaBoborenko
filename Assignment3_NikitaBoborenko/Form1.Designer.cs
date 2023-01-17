namespace Assignment3_NikitaBoborenko
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bmi_status_lbl = new System.Windows.Forms.Label();
            this.bmi_count_lbl = new System.Windows.Forms.Label();
            this.weight_input = new System.Windows.Forms.TextBox();
            this.height_input = new System.Windows.Forms.TextBox();
            this.calculate_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(21, 165);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(512, 84);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // bmi_status_lbl
            // 
            this.bmi_status_lbl.AutoSize = true;
            this.bmi_status_lbl.Location = new System.Drawing.Point(29, 214);
            this.bmi_status_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bmi_status_lbl.Name = "bmi_status_lbl";
            this.bmi_status_lbl.Size = new System.Drawing.Size(40, 13);
            this.bmi_status_lbl.TabIndex = 1;
            this.bmi_status_lbl.Text = "Status:";
            // 
            // bmi_count_lbl
            // 
            this.bmi_count_lbl.AutoSize = true;
            this.bmi_count_lbl.Location = new System.Drawing.Point(29, 182);
            this.bmi_count_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bmi_count_lbl.Name = "bmi_count_lbl";
            this.bmi_count_lbl.Size = new System.Drawing.Size(29, 13);
            this.bmi_count_lbl.TabIndex = 0;
            this.bmi_count_lbl.Text = "BMI:";
            // 
            // weight_input
            // 
            this.weight_input.Location = new System.Drawing.Point(119, 70);
            this.weight_input.Margin = new System.Windows.Forms.Padding(2);
            this.weight_input.Name = "weight_input";
            this.weight_input.Size = new System.Drawing.Size(76, 20);
            this.weight_input.TabIndex = 1;
            this.weight_input.Text = "2";
            // 
            // height_input
            // 
            this.height_input.Location = new System.Drawing.Point(119, 106);
            this.height_input.Margin = new System.Windows.Forms.Padding(2);
            this.height_input.Name = "height_input";
            this.height_input.Size = new System.Drawing.Size(76, 20);
            this.height_input.TabIndex = 2;
            // 
            // calculate_btn
            // 
            this.calculate_btn.Location = new System.Drawing.Point(21, 142);
            this.calculate_btn.Margin = new System.Windows.Forms.Padding(2);
            this.calculate_btn.Name = "calculate_btn";
            this.calculate_btn.Size = new System.Drawing.Size(87, 19);
            this.calculate_btn.TabIndex = 3;
            this.calculate_btn.Text = "Calculate";
            this.calculate_btn.UseVisualStyleBackColor = true;
            this.calculate_btn.Click += new System.EventHandler(this.calculate_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 73);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Weight (kilograms):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 106);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Height (meters):";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.bmi_status_lbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bmi_count_lbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.calculate_btn);
            this.Controls.Add(this.height_input);
            this.Controls.Add(this.weight_input);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox weight_input;
        private System.Windows.Forms.TextBox height_input;
        private System.Windows.Forms.Button calculate_btn;
        private System.Windows.Forms.Label bmi_status_lbl;
        private System.Windows.Forms.Label bmi_count_lbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

