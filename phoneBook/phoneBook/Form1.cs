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

namespace phoneBook
{
    public partial class Puhelinluettelo : Form
    {
        public Puhelinluettelo()
        {
            InitializeComponent();
        }

        static phoneBookData db;
        protected static phoneBookData app
        {
            get
            {
                if (db == null)
                    db = new phoneBookData();
                return db;
            }
        }
        private void Puhelinluettelo_Load(object sender, EventArgs e)
        {
            string file = string.Format("{0}//data.dat", Application.StartupPath);
            if (File.Exists(file))
                app.PhoneBook.ReadXml(file);
            phoneBookBindingSource.DataSource = app.PhoneBook;
            panel1.Enabled = true;
        }

        //Add new row to bottom
        private void btnNew_Click(object sender, EventArgs e)
        {
            try {
                app.PhoneBook.AddPhoneBookRow(app.PhoneBook.NewPhoneBookRow());
                phoneBookBindingSource.MoveLast();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //Delete selected row from database
        private void btnDel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Haluatko varmasti poistaa?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    phoneBookBindingSource.RemoveCurrent();
                    app.PhoneBook.AcceptChanges();
                    app.PhoneBook.WriteXml(string.Format("{0}//data.dat", Application.StartupPath));
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool flag = true;
            //Validate phonenumber. Phonenumber can only contain numbers
            if (txtNumber.Text.Length > 0)
            {
                string c = String.Concat(txtNumber.Text.Where(a => !Char.IsWhiteSpace(a)));
                int value;
                if (!int.TryParse(c, out value))
                {
                    flag = false;
                }
            }
            if (flag)
            {
                try
                {
                    //Save data
                    phoneBookBindingSource.EndEdit();
                    app.PhoneBook.AcceptChanges();
                    app.PhoneBook.WriteXml(string.Format("{0}//data.dat", Application.StartupPath));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Tarkasta puhelinnnumeron muoto!");
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            //Check if seatch field is more than 3 characters.
            string txt = txtSearch.Text;
            if(txt.Length >= 3)
            {
                var query = from o in app.PhoneBook
                            //check if anything contains search word. Ingore case sensitivity
                            where(o.firstName.ToLower().Contains(txt.ToLower())) || (o.lastName.ToLower().Contains(txt.ToLower())) || (o.address.ToLower().Contains(txt.ToLower())) || (o.city.ToLower().Contains(txt.ToLower())) || (o.phoneNumber.Contains(txt)) || (o.postalCode.Contains(txt))
                            select o;
                //if search doesn't find anything, show full list
                if(query.Count() > 0)
                    dataGridView1.DataSource = query.ToList();
            }
            else { dataGridView1.DataSource = phoneBookBindingSource; }
        }
    }
}
