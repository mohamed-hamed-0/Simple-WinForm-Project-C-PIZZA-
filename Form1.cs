using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Pizza
{
    public partial class Form1 : Form
    {
        double price = 0;
        public Form1()
        {
            InitializeComponent();

        }
       
        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked)
            {
                label13.Text = "Think Crust";
            }
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton7.Checked)
            {
                label15.Text = "Take Out";
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                label12.Text = "Small";

            }
            CalculateTotal();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                label12.Text = "Meduim";

            }

            CalculateTotal();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings(); CalculateTotal();
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings(); CalculateTotal();
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {
            
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                label12.Text = "Larg";

            }
            CalculateTotal();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked) 
            {
                label13.Text = "Thin Crust";
            }
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
        private void UpdateToppings()
        {
            string toppings = "";

            if (checkBox1.Checked) toppings += "Extra Cheese, ";
            if (checkBox2.Checked) toppings += "Onion, ";
            if (checkBox3.Checked) toppings += "Mushrooms, ";
            if (checkBox4.Checked) toppings += "Olives, ";
            if (checkBox5.Checked) toppings += "Tomatoes, ";
            if (checkBox6.Checked) toppings += "Green Peppers, ";

            if (toppings == "")
            {
                label14.Text = "NULL";
            }
            else
            {
                toppings = toppings.TrimEnd(',', ' ');
                label14.Text = toppings;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
            CalculateTotal();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings(); CalculateTotal();
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings(); CalculateTotal();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings(); CalculateTotal();
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton6.Checked)
            {
                label15.Text = "Eat In";
            }
        }

        private void label15_Click(object sender, EventArgs e)
        {
            
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }
        // دالة تحديث السعر وتحديث ملخص التوبينج مع بعض
        private void CalculateTotal()
        {
            double basePrice = 0;

            // حساب سعر الحجم حسب الأزرار بتاعتك
            if (radioButton1.Checked) basePrice = 40;     // Small
            else if (radioButton2.Checked) basePrice = 50; // Medium
            else if (radioButton3.Checked) basePrice = 60; // Large

            // حساب الإضافات (كل CheckBox بـ 5 دولار)
            double toppingsPrice = 0;
            if (checkBox1.Checked) toppingsPrice += 5;
            if (checkBox2.Checked) toppingsPrice += 5;
            if (checkBox3.Checked) toppingsPrice += 5;
            if (checkBox4.Checked) toppingsPrice += 5;
            if (checkBox5.Checked) toppingsPrice += 5;
            if (checkBox6.Checked) toppingsPrice += 5;

            // السعر الإجمالي
            double totalPrice = basePrice + toppingsPrice;

            // عرض السعر في label16
            if (basePrice == 0)
            {
                label16.Text = "NULL";
            }
            else
            {
                label16.Text = "$" + totalPrice.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Confirm","Are You Sure ?",MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
            if (result == DialogResult.OK) 
            {
                groupBox1.Enabled = false;
                groupBox2.Enabled = false;
                groupBox3.Enabled = false;
                groupBox4.Enabled = false;
                groupBox5.Enabled = false;
                button1.Enabled= false;

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            groupBox2.Enabled = true;
            groupBox3.Enabled = true;
            groupBox4.Enabled = true;
            groupBox5.Enabled = true;
            button1.Enabled = true;

            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
            radioButton6.Checked = false;
            radioButton7.Checked = false;

            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;

            label12.Text = "NULL"; // Size
            label14.Text = "NULL"; // Toppings
            label13.Text = "NULL"; // Crust Type
            label15.Text = "NULL"; // Where to Eat
            label16.Text = "NULL"; // Total Price
        }
    }
}
