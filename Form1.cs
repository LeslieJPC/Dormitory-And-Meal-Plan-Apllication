using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2Form
{//Coded by Leslie Cofer
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        int dormitory = 0, meal = 0, total = 0;
        private void button1_Click(object sender, EventArgs e)
        {//For the Add Button
            if (listBox1.SelectedIndex == 0)
                dormitory = 1500;
            else if (listBox1.SelectedIndex == 1)
                dormitory = 1600;
            else if (listBox1.SelectedIndex == 2)
                dormitory = 1200;
            else if (listBox1.SelectedIndex == 3)
                dormitory = 1800;
            else 
            {
                MessageBox.Show("Select a Dorm");
                return;
            }
            label4.Text = dormitory.ToString("C");
        }

        private void button2_Click(object sender, EventArgs e)
        {//Code for the Meal. Form1 opens Form2 when "View Meal Plan" is selected

            Form2 form2 = new Form2();
            form2.ShowDialog();
            if (form2.DialogResult == DialogResult.OK)
            {
                UpdateMeal(form2.MealPlanCost);
            }

            //total = Form1.
            //form2.ShowDialog();
            //meal = form2.mealPlan;
            //label5.Text = meal.ToString("C");
            //DisplayTotal();
        }
        public void UpdateMeal(int SelectedMealCost)
        {
            //to display the amount for the meal elected
            meal= SelectedMealCost;
            label5.Text = meal.ToString("C");
            DisplayTotal();
        }
        private void DisplayTotal()
        {
            //label5.Text = meal.ToString("C");
            total = dormitory + meal;
            label6.Text = total.ToString("C");
        }
        private void button3_Click(object sender, EventArgs e)
        {// code for Reset button
            Reset();
        }
        private void Reset()
        {
            listBox1.SelectedIndex = -1;
            label4.Text = "";
            label5.Text = "";
            label6.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Exit();
        }
        private void Exit()
        {
            MessageBox.Show("Enjoy Your Semester");
            Application.Exit();
        }

        //internal static void Receivedata(int listbox)
        //{
           
        //   MessageBox.Show("Select a Plan");
        //}
    }
}
