using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace phoneBookWFA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static phoneBookData db;
        protected static phoneBookData App
        {
            get
            {
                if (db == null)
                    db = new phoneBookData();
                return db;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            string file = string.Format("{0}//data.dat", Application.StartupPath);
            if (File.Exists(file))
                App.Phonebook.ReadXml(file);
            phonebookBindingSource.DataSource = App.Phonebook;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            //Delete row and save
            if(MessageBox.Show("Poistetaanko rivi varmasti?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                phonebookBindingSource.RemoveCurrent();
                App.Phonebook.AcceptChanges();
                App.Phonebook.WriteXml(string.Format("{0}//data.dat", Application.StartupPath));
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool flag = true;
            int i;
            //Check phone number. phonenumber can only contain numbers
            if (txtPhone.Text.Length > 0 && !int.TryParse(txtPhone.Text, out i))
            {
                flag = false;
            }
            if (flag) {
                try
                {
                    phonebookBindingSource.EndEdit();
                    App.Phonebook.AcceptChanges();
                    App.Phonebook.WriteXml(string.Format("{0}//data.dat", Application.StartupPath));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Tarkasta puhelinnumero!");
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            try
            {
                App.Phonebook.AddPhonebookRow(App.Phonebook.NewPhonebookRow());
                phonebookBindingSource.MoveLast();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string txt = txtSearch.Text;
            if(txt.Length >= 3)
            {
                //Get searches. Remove case sensitivicy 
                var query = from o in App.Phonebook
                            where o.firstName.ToLower().Contains(txt.ToLower()) || o.lastName.ToLower().Contains(txt.ToLower()) || o.phonenumber.ToLower().Contains(txt.ToLower()) || o.address.ToLower().Contains(txt.ToLower()) || o.postalCode.ToLower().Contains(txt.ToLower()) || o.City.ToLower().Contains(txt.ToLower())
                            select o;
                if(query.Count() > 0)
                {
                    //IF no data can be foud, show every row
                    dataGridView1.DataSource = query.ToList();
                }
                
            }
            else
            {
                dataGridView1.DataSource = phonebookBindingSource;
            }
        }
    }
}
