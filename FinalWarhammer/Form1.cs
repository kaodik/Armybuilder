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
    public partial class Form1 : Form
    {
        DataLayer dataHandler = new DataLayer();// call to ctor, if crash will point to the connection.
        List<Recrute> roster = new List<Recrute>();
        List<Recrute> army = new List<Recrute>();
        Recrute currentRecrute;//creating object referance for isolateing the student
        bool addingNew = false;
        Recrute rec;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            roster = dataHandler.getRecuitFromDB(); // created roster list and catches the data as it passes to the form
            //setting binding Source
            recruteBindingSource.DataSource = roster;

        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            recruteBindingSource.MoveFirst();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            recruteBindingSource.MovePrevious();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            recruteBindingSource.MoveNext();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            recruteBindingSource.MoveLast();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            addingNew = true;
            Recrute newRecrute = new Recrute();
            roster.Add(newRecrute);
            recruteBindingSource.MoveLast();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            currentRecrute.RecuitName = recuitNameTextBox.Text;
            currentRecrute.Price = priceTextBox.Text;
            currentRecrute.Health = healthTextBox.Text;
            currentRecrute.Speed = speedTextBox.Text;
            currentRecrute.Attack = attackTextBox.Text;
            currentRecrute.Defence = defenceTextBox.Text;


            if (addingNew)
            {
                dataHandler.addNewRecrute(currentRecrute);

                recuitIDTextBox.Text = dataHandler.getNewRecordID();

                addingNew = false;
            }
            else //edit
            {
                dataHandler.editRecrute(currentRecrute);//applying the method
            }
        }

        private void recruteBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            picBox.Image = null;
            currentRecrute = (Recrute) recruteBindingSource.Current;
            try
            {
                if (currentRecrute != null)
                {
                    if (currentRecrute.PicName != "")
                        picBox.Image = Image.FromFile(currentRecrute.PicName);
                }
            }
            catch(Exception ex)
            {

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure?",
                                               "DELETE",
                                               MessageBoxButtons.YesNoCancel);
            if (dr == DialogResult.Yes)
            {
                dataHandler.deleteRecruteFromDB(currentRecrute);// deletes from db
                recruteBindingSource.RemoveCurrent();//removes from app
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            rec = new Recrute( recuitNameTextBox.Text, priceTextBox.Text, healthTextBox.Text,
                speedTextBox.Text, attackTextBox.Text, defenceTextBox.Text, picNameTextBox.Text);
        }

        private void btnAddtoArmy_Click(object sender, EventArgs e)
        {
            army.Add(currentRecrute);
        }

        private void BtnViewArmy_Click(object sender, EventArgs e)
        {
            ArmyStats ar = new ArmyStats(army);
            ar.Show();
            this.Hide();
        }

        private void btnAddPic_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
             currentRecrute.PicName = openFileDialog1.FileName;
            
            dataHandler.addPic(currentRecrute);

            if (currentRecrute.RecuitID == "1")
            {   recruteBindingSource.MoveNext();
                recruteBindingSource.MovePrevious();
            }
            else
            {
                recruteBindingSource.MovePrevious();
                recruteBindingSource.MoveNext();
            }
        }
    }
}
