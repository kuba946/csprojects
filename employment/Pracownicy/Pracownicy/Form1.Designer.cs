
namespace Pracownicy
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
            this.imie = new System.Windows.Forms.TextBox();
            this.status1 = new Pracownicy.Controls.Status();
            this.imieLabel = new System.Windows.Forms.Label();
            this.nazwiskoLabel = new System.Windows.Forms.Label();
            this.nazwisko = new System.Windows.Forms.TextBox();
            this.kontaktLabel = new System.Windows.Forms.Label();
            this.kontakt = new System.Windows.Forms.TextBox();
            this.statusLabel = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.Label();
            this.dodaj = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pracownikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.imieFilter = new System.Windows.Forms.TextBox();
            this.nazwiskoFilter = new System.Windows.Forms.TextBox();
            this.kontaktFilter = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.statusFilter = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.idOperacje = new System.Windows.Forms.TextBox();
            this.zatrudnij = new System.Windows.Forms.Button();
            this.urlop = new System.Windows.Forms.Button();
            this.zwolnij = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pracownikBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // imie
            // 
            this.imie.Location = new System.Drawing.Point(12, 32);
            this.imie.Name = "imie";
            this.imie.Size = new System.Drawing.Size(100, 20);
            this.imie.TabIndex = 0;
            // 
            // status1
            // 
            this.status1.ActualStatus = -1;
            this.status1.DefaultColor = System.Drawing.Color.Gray;
            this.status1.DefaultMessage = "";
            this.status1.Location = new System.Drawing.Point(497, 16);
            this.status1.Margin = new System.Windows.Forms.Padding(0);
            this.status1.Name = "status1";
            this.status1.Size = new System.Drawing.Size(150, 81);
            this.status1.StatusColors = new System.Drawing.Color[] {
        System.Drawing.Color.Red,
        System.Drawing.Color.Orange,
        System.Drawing.Color.LawnGreen};
            this.status1.StatusMessages = new string[] {
        "Niezatrudniony",
        "Urlop",
        "Zatrudniony"};
            this.status1.TabIndex = 2;
            this.status1.ActualStatusChanged += new System.EventHandler<int>(this.status1_ActualStatusChanged);
            // 
            // imieLabel
            // 
            this.imieLabel.AutoSize = true;
            this.imieLabel.Location = new System.Drawing.Point(48, 16);
            this.imieLabel.Name = "imieLabel";
            this.imieLabel.Size = new System.Drawing.Size(26, 13);
            this.imieLabel.TabIndex = 3;
            this.imieLabel.Text = "Imię";
            // 
            // nazwiskoLabel
            // 
            this.nazwiskoLabel.AutoSize = true;
            this.nazwiskoLabel.Location = new System.Drawing.Point(156, 16);
            this.nazwiskoLabel.Name = "nazwiskoLabel";
            this.nazwiskoLabel.Size = new System.Drawing.Size(53, 13);
            this.nazwiskoLabel.TabIndex = 5;
            this.nazwiskoLabel.Text = "Nazwisko";
            // 
            // nazwisko
            // 
            this.nazwisko.Location = new System.Drawing.Point(130, 32);
            this.nazwisko.Name = "nazwisko";
            this.nazwisko.Size = new System.Drawing.Size(100, 20);
            this.nazwisko.TabIndex = 4;
            // 
            // kontaktLabel
            // 
            this.kontaktLabel.AutoSize = true;
            this.kontaktLabel.Location = new System.Drawing.Point(269, 16);
            this.kontaktLabel.Name = "kontaktLabel";
            this.kontaktLabel.Size = new System.Drawing.Size(50, 13);
            this.kontaktLabel.TabIndex = 7;
            this.kontaktLabel.Text = "Konktakt";
            // 
            // kontakt
            // 
            this.kontakt.Location = new System.Drawing.Point(250, 32);
            this.kontakt.Name = "kontakt";
            this.kontakt.Size = new System.Drawing.Size(100, 20);
            this.kontakt.TabIndex = 6;
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(427, 16);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(35, 13);
            this.statusLabel.TabIndex = 7;
            this.statusLabel.Text = "status";
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Location = new System.Drawing.Point(404, 35);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(35, 13);
            this.status.TabIndex = 8;
            this.status.Text = "status";
            // 
            // dodaj
            // 
            this.dodaj.Location = new System.Drawing.Point(668, 29);
            this.dodaj.Name = "dodaj";
            this.dodaj.Size = new System.Drawing.Size(75, 23);
            this.dodaj.TabIndex = 9;
            this.dodaj.Text = "Dodaj";
            this.dodaj.UseVisualStyleBackColor = true;
            this.dodaj.Click += new System.EventHandler(this.dodaj_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn,
            this.contactDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pracownikBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 100);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(574, 319);
            this.dataGridView1.TabIndex = 10;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "Surname";
            this.surnameDataGridViewTextBoxColumn.HeaderText = "Surname";
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            // 
            // contactDataGridViewTextBoxColumn
            // 
            this.contactDataGridViewTextBoxColumn.DataPropertyName = "Contact";
            this.contactDataGridViewTextBoxColumn.HeaderText = "Contact";
            this.contactDataGridViewTextBoxColumn.Name = "contactDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // pracownikBindingSource
            // 
            this.pracownikBindingSource.DataSource = typeof(Pracownicy.Pracownik);
            // 
            // imieFilter
            // 
            this.imieFilter.Location = new System.Drawing.Point(668, 100);
            this.imieFilter.Name = "imieFilter";
            this.imieFilter.Size = new System.Drawing.Size(120, 20);
            this.imieFilter.TabIndex = 11;
            this.imieFilter.TextChanged += new System.EventHandler(this.imieFilter_TextChanged);
            // 
            // nazwiskoFilter
            // 
            this.nazwiskoFilter.Location = new System.Drawing.Point(668, 126);
            this.nazwiskoFilter.Name = "nazwiskoFilter";
            this.nazwiskoFilter.Size = new System.Drawing.Size(120, 20);
            this.nazwiskoFilter.TabIndex = 12;
            this.nazwiskoFilter.TextChanged += new System.EventHandler(this.nazwiskoFilter_TextChanged);
            // 
            // kontaktFilter
            // 
            this.kontaktFilter.Location = new System.Drawing.Point(668, 152);
            this.kontaktFilter.Name = "kontaktFilter";
            this.kontaktFilter.Size = new System.Drawing.Size(120, 20);
            this.kontaktFilter.TabIndex = 13;
            this.kontaktFilter.TextChanged += new System.EventHandler(this.kontaktFilter_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(592, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Imię";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(592, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Nazwisko";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(592, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Kontakt";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(592, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Status";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(650, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "F I L T R Y";
            // 
            // statusFilter
            // 
            this.statusFilter.Location = new System.Drawing.Point(668, 178);
            this.statusFilter.Name = "statusFilter";
            this.statusFilter.Size = new System.Drawing.Size(120, 20);
            this.statusFilter.TabIndex = 21;
            this.statusFilter.TextChanged += new System.EventHandler(this.statusFilter_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(635, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "O P E R A C J E";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(592, 269);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Id Pracownika";
            // 
            // idOperacje
            // 
            this.idOperacje.Location = new System.Drawing.Point(668, 266);
            this.idOperacje.Name = "idOperacje";
            this.idOperacje.Size = new System.Drawing.Size(120, 20);
            this.idOperacje.TabIndex = 24;
            // 
            // zatrudnij
            // 
            this.zatrudnij.Location = new System.Drawing.Point(595, 301);
            this.zatrudnij.Name = "zatrudnij";
            this.zatrudnij.Size = new System.Drawing.Size(193, 29);
            this.zatrudnij.TabIndex = 25;
            this.zatrudnij.Text = "ZATRUDNIJ";
            this.zatrudnij.UseVisualStyleBackColor = true;
            this.zatrudnij.Click += new System.EventHandler(this.zatrudnij_Click);
            // 
            // urlop
            // 
            this.urlop.Location = new System.Drawing.Point(595, 336);
            this.urlop.Name = "urlop";
            this.urlop.Size = new System.Drawing.Size(193, 29);
            this.urlop.TabIndex = 26;
            this.urlop.Text = "WYŚLIJ NA URLOP";
            this.urlop.UseVisualStyleBackColor = true;
            this.urlop.Click += new System.EventHandler(this.urlop_Click);
            // 
            // zwolnij
            // 
            this.zwolnij.Location = new System.Drawing.Point(595, 371);
            this.zwolnij.Name = "zwolnij";
            this.zwolnij.Size = new System.Drawing.Size(193, 29);
            this.zwolnij.TabIndex = 27;
            this.zwolnij.Text = "ZWOLNIJ";
            this.zwolnij.UseVisualStyleBackColor = true;
            this.zwolnij.Click += new System.EventHandler(this.zwolnij_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.zwolnij);
            this.Controls.Add(this.urlop);
            this.Controls.Add(this.zatrudnij);
            this.Controls.Add(this.idOperacje);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.statusFilter);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kontaktFilter);
            this.Controls.Add(this.nazwiskoFilter);
            this.Controls.Add(this.imieFilter);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dodaj);
            this.Controls.Add(this.status);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.kontaktLabel);
            this.Controls.Add(this.kontakt);
            this.Controls.Add(this.nazwiskoLabel);
            this.Controls.Add(this.nazwisko);
            this.Controls.Add(this.imieLabel);
            this.Controls.Add(this.status1);
            this.Controls.Add(this.imie);
            this.Name = "Form1";
            this.Text = "Pracownicy";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pracownikBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox imie;
        private Controls.Status status1;
        private System.Windows.Forms.Label imieLabel;
        private System.Windows.Forms.Label nazwiskoLabel;
        private System.Windows.Forms.TextBox nazwisko;
        private System.Windows.Forms.Label kontaktLabel;
        private System.Windows.Forms.TextBox kontakt;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.Button dodaj;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource pracownikBindingSource;
        private System.Windows.Forms.TextBox imieFilter;
        private System.Windows.Forms.TextBox nazwiskoFilter;
        private System.Windows.Forms.TextBox kontaktFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox statusFilter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox idOperacje;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button zatrudnij;
        private System.Windows.Forms.Button urlop;
        private System.Windows.Forms.Button zwolnij;
    }
}

