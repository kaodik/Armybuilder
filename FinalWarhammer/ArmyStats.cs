using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalWarhammer
{
    public partial class ArmyStats : Form
    {
        public static List<Recrute> armyCopy = new List<Recrute>();
        int totalPrice, totalHealth, totalAttack; 


        public ArmyStats()
        {
            InitializeComponent();
        }

        

        public ArmyStats(List<Recrute> ar)
        {
            InitializeComponent();
            armyCopy = ar;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Application.OpenForms["Form1"].Show();
            this.Close();
        }

        private void ArmyStats_Load(object sender, EventArgs e)
        {
            foreach (Recrute rec in armyCopy)
            {
                lstBoxArmy.Items.Add(rec.RecuitName + " - " + rec.Price + " Gold");
                totalPrice += int.Parse(rec.Price);
                totalHealth += int.Parse(rec.Health);
            }

            updateControls();
        }

        public void updateControls()
        {
            lblTotalCost.Text = totalPrice.ToString();
            lblTotalHealth.Text = totalHealth.ToString();
        }
    }
}
