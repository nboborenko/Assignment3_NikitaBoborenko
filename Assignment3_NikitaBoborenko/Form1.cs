using System;
using System.Windows.Forms;

namespace Assignment3_NikitaBoborenko
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static string GetBmiMessage(double bmi)
        {
            if (bmi < 18.1)
            {
                return "Underweight";
            }
            else if (bmi < 25)
            {
                return "Normal weight";
            }
            else if (bmi < 30)
            {
                return "Overweight";
            }
            else
            {
                return "Obesity";
            }
        }

        private void calculate_btn_Click(object sender, EventArgs e)
        {
            try
            {

                double weight_input_int = Convert.ToDouble(weight_input.Text);
                double height_input_int = Convert.ToDouble(height_input.Text);



                double bmi_output = weight_input_int / Math.Pow(height_input_int, 2);
                bmi_count_lbl.Text = "BMI: " + bmi_output.ToString();
                bmi_status_lbl.Text = "Status: " + GetBmiMessage(bmi_output);
            }
            catch
            {
                MessageBox.Show("Input is wrong");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
