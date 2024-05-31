using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2Form
{
    public partial class Form2 : Form
    {
        public int MealPlanCost { get; private set; }
        
        public Form2()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        int meal = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            //For the Add Desired Meal Plan Button
            if (listBox.SelectedIndex == 0)
                meal = 560;
            else if (listBox.SelectedIndex == 1)
                meal = 1095;
            else if (listBox.SelectedIndex == 2)
                meal = 1500;
            else
            {
                MessageBox.Show("Select a Meal Plan");
                return;
            }

            //code to have meal plan selected in Form2 to appear in Form1
            MealPlanCost= meal;
            DialogResult= DialogResult.OK;

            //code to close Form2 after meal is selected
            this.Close();
        }

    }
}
