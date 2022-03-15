using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Knapsack_Problem;

namespace KnapsackForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int count, seed, cap;

            if(!int.TryParse(txtCount.Text, out count))
                return;
            if (!int.TryParse(txtCap.Text, out cap))
                return;
            if (!int.TryParse(txtSeed.Text, out seed))
                return;

            Generator generator = new Generator(count, seed);
            Solver solver = new Solver();

            if(chckSort.Checked)
                solver.SolveSort(cap, generator.getItems());
            else
                solver.Solve(cap, generator.getItems());

            txtItems.Text = "Id\tWeight\tValue" + Environment.NewLine + generator.ToString();
            txtKnapsack.Text = "Id\tWeight\tValue" + Environment.NewLine + solver.ToString();
            lblWeight.Text = "Total weight: " + solver.getWeight().ToString();
            lblValue.Text = "Total value: " + solver.getValue().ToString();
        }

        private void txtVerifyColor(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null)
            {
                if(int.TryParse(textBox.Text, out int tmp))
                {
                     textBox.BackColor = Color.LightGreen;
                }
                else
                {
                    if (!(textBox.Text.Length > 0))
                        textBox.BackColor = Color.White;
                    else
                        textBox.BackColor = Color.LightCoral;
                }                 
            }
        }
    }
}
