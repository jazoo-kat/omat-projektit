namespace phoneBook
{
    partial class Puhelinluettelo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.phoneBookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.phoneBookData = new phoneBook.phoneBookData();
            this.txtPostal = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.txtLast = new System.Windows.Forms.TextBox();
            this.txtFirst = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postalCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phoneBookBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneBookData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.txtPostal);
            this.panel1.Controls.Add(this.txtAddress);
            this.panel1.Controls.Add(this.txtCity);
            this.panel1.Controls.Add(this.txtNumber);
            this.panel1.Controls.Add(this.txtLast);
            this.panel1.Controls.Add(this.txtFirst);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(57, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(669, 488);
            this.panel1.TabIndex = 0;
            // 
            // txtEmail
            // 
            this.txtEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phoneBookBindingSource, "email", true));
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.25F);
            this.txtEmail.Location = new System.Drawing.Point(265, 250);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(367, 41);
            this.txtEmail.TabIndex = 13;
            // 
            // phoneBookBindingSource
            // 
            this.phoneBookBindingSource.DataMember = "PhoneBook";
            this.phoneBookBindingSource.DataSource = this.phoneBookData;
            // 
            // phoneBookData
            // 
            this.phoneBookData.DataSetName = "phoneBookData";
            this.phoneBookData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtPostal
            // 
            this.txtPostal.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phoneBookBindingSource, "postalCode", true));
            this.txtPostal.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.25F);
            this.txtPostal.Location = new System.Drawing.Point(265, 374);
            this.txtPostal.Name = "txtPostal";
            this.txtPostal.Size = new System.Drawing.Size(367, 41);
            this.txtPostal.TabIndex = 12;
            // 
            // txtAddress
            // 
            this.txtAddress.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phoneBookBindingSource, "address", true));
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.25F);
            this.txtAddress.Location = new System.Drawing.Point(265, 315);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(367, 41);
            this.txtAddress.TabIndex = 11;
            // 
            // txtCity
            // 
            this.txtCity.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phoneBookBindingSource, "city", true));
            this.txtCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.25F);
            this.txtCity.Location = new System.Drawing.Point(265, 432);
            this.txtCity.Name = "txtCity";
            this.txtCity.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtCity.Size = new System.Drawing.Size(367, 41);
            this.txtCity.TabIndex = 10;
            // 
            // txtNumber
            // 
            this.txtNumber.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phoneBookBindingSource, "phoneNumber", true));
            this.txtNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.25F);
            this.txtNumber.Location = new System.Drawing.Point(265, 180);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(367, 41);
            this.txtNumber.TabIndex = 9;
            // 
            // txtLast
            // 
            this.txtLast.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phoneBookBindingSource, "lastName", true));
            this.txtLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.25F);
            this.txtLast.Location = new System.Drawing.Point(265, 108);
            this.txtLast.Name = "txtLast";
            this.txtLast.Size = new System.Drawing.Size(367, 41);
            this.txtLast.TabIndex = 8;
            // 
            // txtFirst
            // 
            this.txtFirst.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phoneBookBindingSource, "firstName", true));
            this.txtFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.25F);
            this.txtFirst.Location = new System.Drawing.Point(265, 41);
            this.txtFirst.Name = "txtFirst";
            this.txtFirst.Size = new System.Drawing.Size(367, 41);
            this.txtFirst.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.25F);
            this.label7.Location = new System.Drawing.Point(24, 432);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 36);
            this.label7.TabIndex = 6;
            this.label7.Text = "Kaupunki";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.25F);
            this.label6.Location = new System.Drawing.Point(24, 374);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(182, 36);
            this.label6.TabIndex = 5;
            this.label6.Text = "Postinumero";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.25F);
            this.label5.Location = new System.Drawing.Point(24, 315);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 36);
            this.label5.TabIndex = 4;
            this.label5.Text = "Osoite";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.25F);
            this.label4.Location = new System.Drawing.Point(24, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 36);
            this.label4.TabIndex = 3;
            this.label4.Text = "Sähköposti";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.25F);
            this.label3.Location = new System.Drawing.Point(24, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(216, 36);
            this.label3.TabIndex = 2;
            this.label3.Text = "Puhelinnumero";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.25F);
            this.label2.Location = new System.Drawing.Point(24, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sukunimi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.25F);
            this.label1.Location = new System.Drawing.Point(24, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Etunimi";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.phoneNumberDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.postalCodeDataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.phoneBookBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(747, 132);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(744, 420);
            this.dataGridView1.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.25F);
            this.label8.Location = new System.Drawing.Point(768, 79);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 36);
            this.label8.TabIndex = 14;
            this.label8.Text = "Hae";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.25F);
            this.txtSearch.Location = new System.Drawing.Point(940, 79);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(367, 41);
            this.txtSearch.TabIndex = 14;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.btnNew.Location = new System.Drawing.Point(87, 582);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(123, 36);
            this.btnNew.TabIndex = 15;
            this.btnNew.Text = "Uusi";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.btnClear.Location = new System.Drawing.Point(566, 582);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(123, 36);
            this.btnClear.TabIndex = 16;
            this.btnClear.Text = "Poista";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.btnSave.Location = new System.Drawing.Point(322, 582);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(123, 36);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "Tallenna";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Visible = false;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "firstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "Etunimi";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "lastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "Sukunimi";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "phoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "Puhelinnumero";
            this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Sähköposti";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Osoite";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // postalCodeDataGridViewTextBoxColumn
            // 
            this.postalCodeDataGridViewTextBoxColumn.DataPropertyName = "postalCode";
            this.postalCodeDataGridViewTextBoxColumn.HeaderText = "Postinumero";
            this.postalCodeDataGridViewTextBoxColumn.Name = "postalCodeDataGridViewTextBoxColumn";
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "city";
            this.cityDataGridViewTextBoxColumn.HeaderText = "Postitoimipaikka";
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            // 
            // Puhelinluettelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1658, 897);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "Puhelinluettelo";
            this.Text = "Puhelinluettelo";
            this.Load += new System.EventHandler(this.Puhelinluettelo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phoneBookBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneBookData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPostal;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.TextBox txtLast;
        private System.Windows.Forms.TextBox txtFirst;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.BindingSource phoneBookBindingSource;
        private phoneBookData phoneBookData;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postalCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
    }
}

