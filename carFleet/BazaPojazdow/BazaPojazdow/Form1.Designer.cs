namespace BazaPojazdow
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.rejestracja1 = new BazaPojazdow.Controls.Rejestracja();
            this.typ1 = new BazaPojazdow.Controls.Typ();
            this.paliwo1 = new BazaPojazdow.Controls.Paliwo();
            this.moc = new BazaPojazdow.Controls.FloatData();
            this.pojemnoscSilnika = new BazaPojazdow.Controls.FloatData();
            this.masa = new BazaPojazdow.Controls.FloatData();
            this.spalanie = new BazaPojazdow.Controls.FloatData();
            this.pojemnoscZbiornika = new BazaPojazdow.Controls.FloatData();
            this.button1 = new System.Windows.Forms.Button();
            this.rent1 = new BazaPojazdow.Controls.Rent();
            this.status1 = new BazaPojazdow.Controls.Status();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.carIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrRejDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paliwoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pojSilnikaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.masaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spalanieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pojZbDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zasiegDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.czyWynajetyDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.pojazdDBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pojazdDBBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.rejestracja1);
            this.flowLayoutPanel1.Controls.Add(this.typ1);
            this.flowLayoutPanel1.Controls.Add(this.paliwo1);
            this.flowLayoutPanel1.Controls.Add(this.moc);
            this.flowLayoutPanel1.Controls.Add(this.pojemnoscSilnika);
            this.flowLayoutPanel1.Controls.Add(this.masa);
            this.flowLayoutPanel1.Controls.Add(this.spalanie);
            this.flowLayoutPanel1.Controls.Add(this.pojemnoscZbiornika);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(620, 221);
            this.flowLayoutPanel1.TabIndex = 9;
            // 
            // rejestracja1
            // 
            this.rejestracja1.Location = new System.Drawing.Point(2, 2);
            this.rejestracja1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rejestracja1.Name = "rejestracja1";
            this.rejestracja1.RejestracjaTextboxValue = "";
            this.rejestracja1.RejestracjaTitle = "Nr Rejestracyjny";
            this.rejestracja1.RejestracjaValueValidation = 0;
            this.rejestracja1.Size = new System.Drawing.Size(150, 106);
            this.rejestracja1.TabIndex = 1;
            // 
            // typ1
            // 
            this.typ1.Location = new System.Drawing.Point(156, 2);
            this.typ1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.typ1.Name = "typ1";
            this.typ1.Size = new System.Drawing.Size(150, 106);
            this.typ1.TabIndex = 2;
            this.typ1.TypTextboxValue = "";
            this.typ1.TypTitle = "Typ";
            this.typ1.TypValueValidation = 0;
            // 
            // paliwo1
            // 
            this.paliwo1.Location = new System.Drawing.Point(310, 2);
            this.paliwo1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.paliwo1.Name = "paliwo1";
            this.paliwo1.PaliwoTextboxValue = "";
            this.paliwo1.PaliwoTitle = "Paliwo";
            this.paliwo1.PaliwoValueValidation = 0;
            this.paliwo1.Size = new System.Drawing.Size(150, 106);
            this.paliwo1.TabIndex = 3;
            // 
            // moc
            // 
            this.moc.FloatDataTextboxValue = "";
            this.moc.FloatDataTitle = "Moc";
            this.moc.FloatDataValueValidation = 0;
            this.moc.Location = new System.Drawing.Point(464, 2);
            this.moc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.moc.Name = "moc";
            this.moc.Size = new System.Drawing.Size(150, 106);
            this.moc.TabIndex = 4;
            // 
            // pojemnoscSilnika
            // 
            this.pojemnoscSilnika.FloatDataTextboxValue = "";
            this.pojemnoscSilnika.FloatDataTitle = "Pojemność Silnika";
            this.pojemnoscSilnika.FloatDataValueValidation = 0;
            this.pojemnoscSilnika.Location = new System.Drawing.Point(2, 112);
            this.pojemnoscSilnika.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pojemnoscSilnika.Name = "pojemnoscSilnika";
            this.pojemnoscSilnika.Size = new System.Drawing.Size(150, 106);
            this.pojemnoscSilnika.TabIndex = 5;
            // 
            // masa
            // 
            this.masa.FloatDataTextboxValue = "";
            this.masa.FloatDataTitle = "Masa";
            this.masa.FloatDataValueValidation = 0;
            this.masa.Location = new System.Drawing.Point(156, 112);
            this.masa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.masa.Name = "masa";
            this.masa.Size = new System.Drawing.Size(150, 106);
            this.masa.TabIndex = 6;
            // 
            // spalanie
            // 
            this.spalanie.FloatDataTextboxValue = "";
            this.spalanie.FloatDataTitle = "Spalanie";
            this.spalanie.FloatDataValueValidation = 0;
            this.spalanie.Location = new System.Drawing.Point(310, 112);
            this.spalanie.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.spalanie.Name = "spalanie";
            this.spalanie.Size = new System.Drawing.Size(150, 106);
            this.spalanie.TabIndex = 7;
            // 
            // pojemnoscZbiornika
            // 
            this.pojemnoscZbiornika.FloatDataTextboxValue = "";
            this.pojemnoscZbiornika.FloatDataTitle = "Pojemność Zbiornika";
            this.pojemnoscZbiornika.FloatDataValueValidation = 0;
            this.pojemnoscZbiornika.Location = new System.Drawing.Point(464, 112);
            this.pojemnoscZbiornika.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pojemnoscZbiornika.Name = "pojemnoscZbiornika";
            this.pojemnoscZbiornika.Size = new System.Drawing.Size(150, 106);
            this.pojemnoscZbiornika.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(2, 225);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 41);
            this.button1.TabIndex = 10;
            this.button1.Text = "Dodaj pojazd";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button1_MouseClick);
            // 
            // rent1
            // 
            this.rent1.Ability = true;
            this.rent1.DoDnia = new System.DateTime(2021, 1, 27, 0, 0, 0, 0);
            this.rent1.Location = new System.Drawing.Point(185, 222);
            this.rent1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rent1.Name = "rent1";
            this.rent1.OdDnia = new System.DateTime(2021, 1, 28, 0, 0, 0, 0);
            this.rent1.Rented = false;
            this.rent1.Size = new System.Drawing.Size(259, 125);
            this.rent1.TabIndex = 11;
            this.rent1.RentStatusChanged += new System.EventHandler<bool>(this.rent1_RentStatusChanged);
            // 
            // status1
            // 
            this.status1.ActualStatus = -1;
            this.status1.DefaultColor = System.Drawing.Color.Gray;
            this.status1.DefaultMessage = "";
            this.status1.Location = new System.Drawing.Point(446, 234);
            this.status1.Margin = new System.Windows.Forms.Padding(0);
            this.status1.Name = "status1";
            this.status1.Size = new System.Drawing.Size(153, 81);
            this.status1.StatusColors = new System.Drawing.Color[] {
        System.Drawing.Color.Red,
        System.Drawing.Color.Orange,
        System.Drawing.Color.LawnGreen};
            this.status1.StatusMessages = new string[] {
        "Niedostępny!",
        "W serwisie...",
        "Dostępny"};
            this.status1.TabIndex = 9;
            this.status1.ActualStatusChanged += new System.EventHandler<int>(this.status1_ActualStatusChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.carIdDataGridViewTextBoxColumn,
            this.nrRejDataGridViewTextBoxColumn,
            this.typDataGridViewTextBoxColumn,
            this.paliwoDataGridViewTextBoxColumn,
            this.mocDataGridViewTextBoxColumn,
            this.pojSilnikaDataGridViewTextBoxColumn,
            this.masaDataGridViewTextBoxColumn,
            this.spalanieDataGridViewTextBoxColumn,
            this.pojZbDataGridViewTextBoxColumn,
            this.zasiegDataGridViewTextBoxColumn,
            this.czyWynajetyDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.pojazdDBBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 352);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(620, 89);
            this.dataGridView1.TabIndex = 12;
            // 
            // carIdDataGridViewTextBoxColumn
            // 
            this.carIdDataGridViewTextBoxColumn.DataPropertyName = "CarId";
            this.carIdDataGridViewTextBoxColumn.HeaderText = "CarId";
            this.carIdDataGridViewTextBoxColumn.Name = "carIdDataGridViewTextBoxColumn";
            // 
            // nrRejDataGridViewTextBoxColumn
            // 
            this.nrRejDataGridViewTextBoxColumn.DataPropertyName = "NrRej";
            this.nrRejDataGridViewTextBoxColumn.HeaderText = "NrRej";
            this.nrRejDataGridViewTextBoxColumn.Name = "nrRejDataGridViewTextBoxColumn";
            // 
            // typDataGridViewTextBoxColumn
            // 
            this.typDataGridViewTextBoxColumn.DataPropertyName = "Typ";
            this.typDataGridViewTextBoxColumn.HeaderText = "Typ";
            this.typDataGridViewTextBoxColumn.Name = "typDataGridViewTextBoxColumn";
            // 
            // paliwoDataGridViewTextBoxColumn
            // 
            this.paliwoDataGridViewTextBoxColumn.DataPropertyName = "Paliwo";
            this.paliwoDataGridViewTextBoxColumn.HeaderText = "Paliwo";
            this.paliwoDataGridViewTextBoxColumn.Name = "paliwoDataGridViewTextBoxColumn";
            // 
            // mocDataGridViewTextBoxColumn
            // 
            this.mocDataGridViewTextBoxColumn.DataPropertyName = "Moc";
            this.mocDataGridViewTextBoxColumn.HeaderText = "Moc";
            this.mocDataGridViewTextBoxColumn.Name = "mocDataGridViewTextBoxColumn";
            // 
            // pojSilnikaDataGridViewTextBoxColumn
            // 
            this.pojSilnikaDataGridViewTextBoxColumn.DataPropertyName = "PojSilnika";
            this.pojSilnikaDataGridViewTextBoxColumn.HeaderText = "PojSilnika";
            this.pojSilnikaDataGridViewTextBoxColumn.Name = "pojSilnikaDataGridViewTextBoxColumn";
            // 
            // masaDataGridViewTextBoxColumn
            // 
            this.masaDataGridViewTextBoxColumn.DataPropertyName = "Masa";
            this.masaDataGridViewTextBoxColumn.HeaderText = "Masa";
            this.masaDataGridViewTextBoxColumn.Name = "masaDataGridViewTextBoxColumn";
            // 
            // spalanieDataGridViewTextBoxColumn
            // 
            this.spalanieDataGridViewTextBoxColumn.DataPropertyName = "Spalanie";
            this.spalanieDataGridViewTextBoxColumn.HeaderText = "Spalanie";
            this.spalanieDataGridViewTextBoxColumn.Name = "spalanieDataGridViewTextBoxColumn";
            // 
            // pojZbDataGridViewTextBoxColumn
            // 
            this.pojZbDataGridViewTextBoxColumn.DataPropertyName = "PojZb";
            this.pojZbDataGridViewTextBoxColumn.HeaderText = "PojZb";
            this.pojZbDataGridViewTextBoxColumn.Name = "pojZbDataGridViewTextBoxColumn";
            // 
            // zasiegDataGridViewTextBoxColumn
            // 
            this.zasiegDataGridViewTextBoxColumn.DataPropertyName = "Zasieg";
            this.zasiegDataGridViewTextBoxColumn.HeaderText = "Zasieg";
            this.zasiegDataGridViewTextBoxColumn.Name = "zasiegDataGridViewTextBoxColumn";
            this.zasiegDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // czyWynajetyDataGridViewCheckBoxColumn
            // 
            this.czyWynajetyDataGridViewCheckBoxColumn.DataPropertyName = "CzyWynajety";
            this.czyWynajetyDataGridViewCheckBoxColumn.HeaderText = "CzyWynajety";
            this.czyWynajetyDataGridViewCheckBoxColumn.Name = "czyWynajetyDataGridViewCheckBoxColumn";
            // 
            // pojazdDBBindingSource
            // 
            this.pojazdDBBindingSource.DataSource = typeof(BazaPojazdow.PojazdDB);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 531);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.rent1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.status1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Baza Pojazdów";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pojazdDBBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Controls.FloatData pojemnoscSilnika;
        private Controls.FloatData masa;
        private Controls.FloatData spalanie;
        private Controls.FloatData pojemnoscZbiornika;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Controls.Rejestracja rejestracja1;
        private Controls.Typ typ1;
        private Controls.Paliwo paliwo1;
        private Controls.FloatData moc;
        private Controls.Status status1;
        private System.Windows.Forms.Button button1;
        private Controls.Rent rent1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource pojazdDBBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn carIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrRejDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paliwoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mocDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pojSilnikaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn masaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn spalanieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pojZbDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zasiegDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn czyWynajetyDataGridViewCheckBoxColumn;
    }
}

