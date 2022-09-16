namespace WypozyczalniaSamochodow
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.segmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pricePerDayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberOfPeopleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberOfCarsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.segment = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.priceFrom = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.priceTo = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.idRent = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.days = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.rent = new System.Windows.Forms.Button();
            this.clientName = new System.Windows.Forms.TextBox();
            this.clientContact = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientContactDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberOfDaysDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idSamochoduDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Payment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wynajemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.daysBar = new WypozyczalniaSamochodow.LedBar();
            this.price = new WypozyczalniaSamochodow.ScopeBar();
            this.label12 = new System.Windows.Forms.Label();
            this.toPay = new System.Windows.Forms.Label();
            this.startDate = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wynajemBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.segmentDataGridViewTextBoxColumn,
            this.pricePerDayDataGridViewTextBoxColumn,
            this.numberOfPeopleDataGridViewTextBoxColumn,
            this.numberOfCarsDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.autoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(468, 505);
            this.dataGridView1.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 30;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Nazwa";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 145;
            // 
            // segmentDataGridViewTextBoxColumn
            // 
            this.segmentDataGridViewTextBoxColumn.DataPropertyName = "Segment";
            this.segmentDataGridViewTextBoxColumn.HeaderText = "Segment";
            this.segmentDataGridViewTextBoxColumn.Name = "segmentDataGridViewTextBoxColumn";
            this.segmentDataGridViewTextBoxColumn.Width = 60;
            // 
            // pricePerDayDataGridViewTextBoxColumn
            // 
            this.pricePerDayDataGridViewTextBoxColumn.DataPropertyName = "PricePerDay";
            this.pricePerDayDataGridViewTextBoxColumn.HeaderText = "Cena za dobę";
            this.pricePerDayDataGridViewTextBoxColumn.Name = "pricePerDayDataGridViewTextBoxColumn";
            this.pricePerDayDataGridViewTextBoxColumn.Width = 70;
            // 
            // numberOfPeopleDataGridViewTextBoxColumn
            // 
            this.numberOfPeopleDataGridViewTextBoxColumn.DataPropertyName = "NumberOfPeople";
            this.numberOfPeopleDataGridViewTextBoxColumn.HeaderText = "Ile osób";
            this.numberOfPeopleDataGridViewTextBoxColumn.Name = "numberOfPeopleDataGridViewTextBoxColumn";
            this.numberOfPeopleDataGridViewTextBoxColumn.Width = 40;
            // 
            // numberOfCarsDataGridViewTextBoxColumn
            // 
            this.numberOfCarsDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.numberOfCarsDataGridViewTextBoxColumn.DataPropertyName = "NumberOfCars";
            this.numberOfCarsDataGridViewTextBoxColumn.HeaderText = "ile dostępnych";
            this.numberOfCarsDataGridViewTextBoxColumn.Name = "numberOfCarsDataGridViewTextBoxColumn";
            // 
            // autoBindingSource
            // 
            this.autoBindingSource.DataSource = typeof(WypozyczalniaSamochodow.Auto);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(601, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "FILTRY";
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(544, 38);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(233, 20);
            this.id.TabIndex = 3;
            this.id.TextChanged += new System.EventHandler(this.id_TextChanged);
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(544, 64);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(233, 20);
            this.name.TabIndex = 4;
            this.name.TextChanged += new System.EventHandler(this.id_TextChanged);
            // 
            // segment
            // 
            this.segment.Location = new System.Drawing.Point(544, 90);
            this.segment.Name = "segment";
            this.segment.Size = new System.Drawing.Size(233, 20);
            this.segment.TabIndex = 5;
            this.segment.TextChanged += new System.EventHandler(this.id_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(499, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Id";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(489, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nazwa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(489, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Segment";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(601, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Cena za dobę";
            // 
            // priceFrom
            // 
            this.priceFrom.AutoSize = true;
            this.priceFrom.Location = new System.Drawing.Point(528, 196);
            this.priceFrom.Name = "priceFrom";
            this.priceFrom.Size = new System.Drawing.Size(13, 13);
            this.priceFrom.TabIndex = 12;
            this.priceFrom.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(564, 196);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "zł";
            // 
            // priceTo
            // 
            this.priceTo.AutoSize = true;
            this.priceTo.Location = new System.Drawing.Point(681, 196);
            this.priceTo.Name = "priceTo";
            this.priceTo.Size = new System.Drawing.Size(31, 13);
            this.priceTo.TabIndex = 12;
            this.priceTo.Text = "1000";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(717, 196);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(16, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "zł";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(929, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "WYNAJMIJ";
            // 
            // idRent
            // 
            this.idRent.Location = new System.Drawing.Point(872, 38);
            this.idRent.Name = "idRent";
            this.idRent.Size = new System.Drawing.Size(233, 20);
            this.idRent.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(817, 41);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "Id Auta";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(934, 142);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(35, 13);
            this.label14.TabIndex = 11;
            this.label14.Text = "Ile dni";
            // 
            // days
            // 
            this.days.AutoSize = true;
            this.days.Location = new System.Drawing.Point(934, 197);
            this.days.Name = "days";
            this.days.Size = new System.Drawing.Size(13, 13);
            this.days.TabIndex = 12;
            this.days.Text = "0";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(970, 197);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(21, 13);
            this.label16.TabIndex = 13;
            this.label16.Text = "dni";
            // 
            // rent
            // 
            this.rent.Location = new System.Drawing.Point(1011, 213);
            this.rent.Name = "rent";
            this.rent.Size = new System.Drawing.Size(94, 36);
            this.rent.TabIndex = 9;
            this.rent.Text = "Wynajmij";
            this.rent.UseVisualStyleBackColor = true;
            this.rent.Click += new System.EventHandler(this.rent_Click);
            // 
            // clientName
            // 
            this.clientName.Location = new System.Drawing.Point(872, 64);
            this.clientName.Name = "clientName";
            this.clientName.Size = new System.Drawing.Size(233, 20);
            this.clientName.TabIndex = 7;
            this.clientName.TextChanged += new System.EventHandler(this.id_TextChanged);
            // 
            // clientContact
            // 
            this.clientContact.Location = new System.Drawing.Point(872, 90);
            this.clientContact.Name = "clientContact";
            this.clientContact.Size = new System.Drawing.Size(233, 20);
            this.clientContact.TabIndex = 8;
            this.clientContact.TextChanged += new System.EventHandler(this.id_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(817, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Nazwisko";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(817, 93);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "kontakt";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.clientNameDataGridViewTextBoxColumn,
            this.clientContactDataGridViewTextBoxColumn,
            this.numberOfDaysDataGridViewTextBoxColumn,
            this.idSamochoduDataGridViewTextBoxColumn,
            this.Payment,
            this.dataGridViewTextBoxColumn1,
            this.EndDate});
            this.dataGridView2.DataSource = this.wynajemBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(492, 272);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(613, 245);
            this.dataGridView2.TabIndex = 16;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.Width = 30;
            // 
            // clientNameDataGridViewTextBoxColumn
            // 
            this.clientNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clientNameDataGridViewTextBoxColumn.DataPropertyName = "ClientName";
            this.clientNameDataGridViewTextBoxColumn.HeaderText = "Nazwisko";
            this.clientNameDataGridViewTextBoxColumn.Name = "clientNameDataGridViewTextBoxColumn";
            // 
            // clientContactDataGridViewTextBoxColumn
            // 
            this.clientContactDataGridViewTextBoxColumn.DataPropertyName = "ClientContact";
            this.clientContactDataGridViewTextBoxColumn.HeaderText = "kontakt";
            this.clientContactDataGridViewTextBoxColumn.Name = "clientContactDataGridViewTextBoxColumn";
            // 
            // numberOfDaysDataGridViewTextBoxColumn
            // 
            this.numberOfDaysDataGridViewTextBoxColumn.DataPropertyName = "NumberOfDays";
            this.numberOfDaysDataGridViewTextBoxColumn.HeaderText = "ile dni";
            this.numberOfDaysDataGridViewTextBoxColumn.Name = "numberOfDaysDataGridViewTextBoxColumn";
            this.numberOfDaysDataGridViewTextBoxColumn.Width = 30;
            // 
            // idSamochoduDataGridViewTextBoxColumn
            // 
            this.idSamochoduDataGridViewTextBoxColumn.DataPropertyName = "IdSamochodu";
            this.idSamochoduDataGridViewTextBoxColumn.HeaderText = "id auta";
            this.idSamochoduDataGridViewTextBoxColumn.Name = "idSamochoduDataGridViewTextBoxColumn";
            this.idSamochoduDataGridViewTextBoxColumn.Width = 35;
            // 
            // Payment
            // 
            this.Payment.DataPropertyName = "Payment";
            this.Payment.HeaderText = "Cena";
            this.Payment.Name = "Payment";
            this.Payment.Width = 70;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "StartDate";
            this.dataGridViewTextBoxColumn1.HeaderText = "start";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 70;
            // 
            // EndDate
            // 
            this.EndDate.DataPropertyName = "EndDate";
            this.EndDate.HeaderText = "end";
            this.EndDate.Name = "EndDate";
            this.EndDate.Width = 70;
            // 
            // wynajemBindingSource
            // 
            this.wynajemBindingSource.DataSource = typeof(WypozyczalniaSamochodow.Wynajem);
            // 
            // daysBar
            // 
            this.daysBar.LedbarValueMax = 0;
            this.daysBar.Location = new System.Drawing.Point(820, 166);
            this.daysBar.Max = 50;
            this.daysBar.Name = "daysBar";
            this.daysBar.Size = new System.Drawing.Size(285, 28);
            this.daysBar.TabIndex = 14;
            this.daysBar.ValueMax = 0;
            this.daysBar.LedbarValueChanged += new System.EventHandler<int>(this.daysBar_LedbarValueChanged);
            // 
            // price
            // 
            this.price.BackColor = System.Drawing.SystemColors.ControlDark;
            this.price.Location = new System.Drawing.Point(492, 166);
            this.price.Margin = new System.Windows.Forms.Padding(2);
            this.price.Max = 1000;
            this.price.Name = "price";
            this.price.ScopeValueMax = 0;
            this.price.ScopeValueMin = 0;
            this.price.Size = new System.Drawing.Size(285, 28);
            this.price.TabIndex = 10;
            this.price.ValueMax = 0;
            this.price.ValueMin = 0;
            this.price.ScopeValueChanged += new System.EventHandler<int>(this.price_ScopeValueChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(817, 225);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 13);
            this.label12.TabIndex = 17;
            this.label12.Text = "DO ZAPŁATY:";
            // 
            // toPay
            // 
            this.toPay.AutoSize = true;
            this.toPay.Location = new System.Drawing.Point(901, 225);
            this.toPay.Name = "toPay";
            this.toPay.Size = new System.Drawing.Size(13, 13);
            this.toPay.TabIndex = 18;
            this.toPay.Text = "0";
            // 
            // startDate
            // 
            this.startDate.Location = new System.Drawing.Point(544, 246);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(233, 20);
            this.startDate.TabIndex = 19;
            this.startDate.ValueChanged += new System.EventHandler(this.Form1_Load);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(601, 230);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(120, 13);
            this.label13.TabIndex = 20;
            this.label13.Text = "Pierwszy dzień wynajmu";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 529);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.startDate);
            this.Controls.Add(this.toPay);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.rent);
            this.Controls.Add(this.daysBar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.priceTo);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.days);
            this.Controls.Add(this.priceFrom);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.price);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.clientContact);
            this.Controls.Add(this.segment);
            this.Controls.Add(this.clientName);
            this.Controls.Add(this.idRent);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.id);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wynajemBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource autoBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox segment;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private ScopeBar price;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label priceFrom;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label priceTo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox idRent;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label days;
        private System.Windows.Forms.Label label16;
        private LedBar daysBar;
        private System.Windows.Forms.Button rent;
        private System.Windows.Forms.TextBox clientName;
        private System.Windows.Forms.TextBox clientContact;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn segmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pricePerDayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberOfPeopleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberOfCarsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientKontaktDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource wynajemBindingSource;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label toPay;
        private System.Windows.Forms.DateTimePicker startDate;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientContactDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberOfDaysDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSamochoduDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Payment;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndDate;
    }
}

