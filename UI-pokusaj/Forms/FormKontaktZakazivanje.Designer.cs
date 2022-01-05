﻿namespace UI_pokusaj.Forms
{
    partial class FormKontaktZakazivanje
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
            this.labelVrstaZiv = new System.Windows.Forms.Label();
            this.labelVeterinar = new System.Windows.Forms.Label();
            this.textBoxRazlogPregledaUnos = new System.Windows.Forms.TextBox();
            this.labelRazlogPregleda = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.labelDatum = new System.Windows.Forms.Label();
            this.buttonOtkaziPregled = new System.Windows.Forms.Button();
            this.buttonZakazi = new System.Windows.Forms.Button();
            this.bazaDataSet1 = new UI_pokusaj.BazaDataSet();
            this.bindingSourceVlasnik = new System.Windows.Forms.BindingSource(this.components);
            this.vlasnikTableAdapter = new UI_pokusaj.BazaDataSetTableAdapters.VlasnikTableAdapter();
            this.bindingSourceZivotinja = new System.Windows.Forms.BindingSource(this.components);
            this.ljubimacTableAdapter = new UI_pokusaj.BazaDataSetTableAdapters.LjubimacTableAdapter();
            this.textBoxImeZivotinje = new System.Windows.Forms.TextBox();
            this.labelImeZiv = new System.Windows.Forms.Label();
            this.comboBoxIzborVeterinara = new System.Windows.Forms.ComboBox();
            this.bindingSourceVeterinar = new System.Windows.Forms.BindingSource(this.components);
            this.textBoxUnosVrsteZivotinje = new System.Windows.Forms.TextBox();
            this.veterinarTableAdapter = new UI_pokusaj.BazaDataSetTableAdapters.VeterinarTableAdapter();
            this.labelPolZiv = new System.Windows.Forms.Label();
            this.labelDatumRodj = new System.Windows.Forms.Label();
            this.labelRasaZiv = new System.Windows.Forms.Label();
            this.labelNoviLjubimac = new System.Windows.Forms.Label();
            this.buttonDa = new System.Windows.Forms.Button();
            this.buttonNe = new System.Windows.Forms.Button();
            this.textBoxUnosrase = new System.Windows.Forms.TextBox();
            this.radioButtonPolM = new System.Windows.Forms.RadioButton();
            this.radioButtonPolZ = new System.Windows.Forms.RadioButton();
            this.dateTimePickerrodj = new System.Windows.Forms.DateTimePicker();
            this.labelIzborVrste = new System.Windows.Forms.Label();
            this.labelIyborImena = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.buttonDodajLjubimca = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bazaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceVlasnik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceZivotinja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceVeterinar)).BeginInit();
            this.SuspendLayout();
            // 
            // labelVrstaZiv
            // 
            this.labelVrstaZiv.AutoSize = true;
            this.labelVrstaZiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVrstaZiv.Location = new System.Drawing.Point(3, 245);
            this.labelVrstaZiv.Name = "labelVrstaZiv";
            this.labelVrstaZiv.Size = new System.Drawing.Size(126, 22);
            this.labelVrstaZiv.TabIndex = 3;
            this.labelVrstaZiv.Text = "Vrsta životinje:";
            this.labelVrstaZiv.Visible = false;
            // 
            // labelVeterinar
            // 
            this.labelVeterinar.AutoSize = true;
            this.labelVeterinar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVeterinar.Location = new System.Drawing.Point(391, 140);
            this.labelVeterinar.Name = "labelVeterinar";
            this.labelVeterinar.Size = new System.Drawing.Size(88, 22);
            this.labelVeterinar.TabIndex = 5;
            this.labelVeterinar.Text = "Veterinar:";
            // 
            // textBoxRazlogPregledaUnos
            // 
            this.textBoxRazlogPregledaUnos.Location = new System.Drawing.Point(551, 100);
            this.textBoxRazlogPregledaUnos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxRazlogPregledaUnos.Name = "textBoxRazlogPregledaUnos";
            this.textBoxRazlogPregledaUnos.Size = new System.Drawing.Size(243, 22);
            this.textBoxRazlogPregledaUnos.TabIndex = 6;
            this.textBoxRazlogPregledaUnos.TextChanged += new System.EventHandler(this.textBoxRazlogPregledaUnos_TextChanged);
            // 
            // labelRazlogPregleda
            // 
            this.labelRazlogPregleda.AutoSize = true;
            this.labelRazlogPregleda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRazlogPregleda.Location = new System.Drawing.Point(391, 98);
            this.labelRazlogPregleda.Name = "labelRazlogPregleda";
            this.labelRazlogPregleda.Size = new System.Drawing.Size(145, 22);
            this.labelRazlogPregleda.TabIndex = 7;
            this.labelRazlogPregleda.Text = "Razlog pregleda:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(551, 181);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(243, 22);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // labelDatum
            // 
            this.labelDatum.AutoSize = true;
            this.labelDatum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDatum.Location = new System.Drawing.Point(391, 181);
            this.labelDatum.Name = "labelDatum";
            this.labelDatum.Size = new System.Drawing.Size(67, 22);
            this.labelDatum.TabIndex = 9;
            this.labelDatum.Text = "Datum:";
            // 
            // buttonOtkaziPregled
            // 
            this.buttonOtkaziPregled.Location = new System.Drawing.Point(551, 224);
            this.buttonOtkaziPregled.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonOtkaziPregled.Name = "buttonOtkaziPregled";
            this.buttonOtkaziPregled.Size = new System.Drawing.Size(119, 43);
            this.buttonOtkaziPregled.TabIndex = 10;
            this.buttonOtkaziPregled.Text = "Otkazi Pregled";
            this.buttonOtkaziPregled.UseVisualStyleBackColor = true;
            this.buttonOtkaziPregled.Click += new System.EventHandler(this.buttonOtkaziPregled_Click);
            // 
            // buttonZakazi
            // 
            this.buttonZakazi.Location = new System.Drawing.Point(676, 224);
            this.buttonZakazi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonZakazi.Name = "buttonZakazi";
            this.buttonZakazi.Size = new System.Drawing.Size(119, 43);
            this.buttonZakazi.TabIndex = 11;
            this.buttonZakazi.Text = "Zakazi pregled";
            this.buttonZakazi.UseVisualStyleBackColor = true;
            this.buttonZakazi.Click += new System.EventHandler(this.buttonZakazi_Click);
            // 
            // bazaDataSet1
            // 
            this.bazaDataSet1.DataSetName = "BazaDataSet";
            this.bazaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingSourceVlasnik
            // 
            this.bindingSourceVlasnik.DataMember = "Vlasnik";
            this.bindingSourceVlasnik.DataSource = this.bazaDataSet1;
            // 
            // vlasnikTableAdapter
            // 
            this.vlasnikTableAdapter.ClearBeforeFill = true;
            // 
            // bindingSourceZivotinja
            // 
            this.bindingSourceZivotinja.DataMember = "Ljubimac";
            this.bindingSourceZivotinja.DataSource = this.bazaDataSet1;
            this.bindingSourceZivotinja.CurrentChanged += new System.EventHandler(this.bindingSourceZivotinja_CurrentChanged);
            // 
            // ljubimacTableAdapter
            // 
            this.ljubimacTableAdapter.ClearBeforeFill = true;
            // 
            // textBoxImeZivotinje
            // 
            this.textBoxImeZivotinje.Location = new System.Drawing.Point(141, 209);
            this.textBoxImeZivotinje.Name = "textBoxImeZivotinje";
            this.textBoxImeZivotinje.Size = new System.Drawing.Size(240, 22);
            this.textBoxImeZivotinje.TabIndex = 14;
            this.textBoxImeZivotinje.Visible = false;
            this.textBoxImeZivotinje.TextChanged += new System.EventHandler(this.textBoxImeZivotinje_TextChanged);
            // 
            // labelImeZiv
            // 
            this.labelImeZiv.AutoSize = true;
            this.labelImeZiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelImeZiv.Location = new System.Drawing.Point(3, 207);
            this.labelImeZiv.Name = "labelImeZiv";
            this.labelImeZiv.Size = new System.Drawing.Size(112, 22);
            this.labelImeZiv.TabIndex = 15;
            this.labelImeZiv.Text = "Ime životinje:";
            this.labelImeZiv.Visible = false;
            // 
            // comboBoxIzborVeterinara
            // 
            this.comboBoxIzborVeterinara.DataSource = this.bindingSourceVeterinar;
            this.comboBoxIzborVeterinara.DisplayMember = "Ime";
            this.comboBoxIzborVeterinara.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxIzborVeterinara.FormattingEnabled = true;
            this.comboBoxIzborVeterinara.Location = new System.Drawing.Point(551, 138);
            this.comboBoxIzborVeterinara.Name = "comboBoxIzborVeterinara";
            this.comboBoxIzborVeterinara.Size = new System.Drawing.Size(241, 24);
            this.comboBoxIzborVeterinara.TabIndex = 16;
            this.comboBoxIzborVeterinara.ValueMember = "VeterinarID";
            this.comboBoxIzborVeterinara.SelectedIndexChanged += new System.EventHandler(this.comboBoxIzborVeterinara_SelectedIndexChanged);
            // 
            // bindingSourceVeterinar
            // 
            this.bindingSourceVeterinar.DataMember = "Veterinar";
            this.bindingSourceVeterinar.DataSource = this.bazaDataSet1;
            // 
            // textBoxUnosVrsteZivotinje
            // 
            this.textBoxUnosVrsteZivotinje.Location = new System.Drawing.Point(141, 247);
            this.textBoxUnosVrsteZivotinje.Name = "textBoxUnosVrsteZivotinje";
            this.textBoxUnosVrsteZivotinje.Size = new System.Drawing.Size(240, 22);
            this.textBoxUnosVrsteZivotinje.TabIndex = 17;
            this.textBoxUnosVrsteZivotinje.Visible = false;
            this.textBoxUnosVrsteZivotinje.TextChanged += new System.EventHandler(this.textBoxUnosVrsteZivotinje_TextChanged);
            // 
            // veterinarTableAdapter
            // 
            this.veterinarTableAdapter.ClearBeforeFill = true;
            // 
            // labelPolZiv
            // 
            this.labelPolZiv.AutoSize = true;
            this.labelPolZiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.labelPolZiv.Location = new System.Drawing.Point(3, 331);
            this.labelPolZiv.Name = "labelPolZiv";
            this.labelPolZiv.Size = new System.Drawing.Size(41, 22);
            this.labelPolZiv.TabIndex = 18;
            this.labelPolZiv.Text = "Pol:";
            this.labelPolZiv.Visible = false;
            // 
            // labelDatumRodj
            // 
            this.labelDatumRodj.AutoSize = true;
            this.labelDatumRodj.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.labelDatumRodj.Location = new System.Drawing.Point(3, 370);
            this.labelDatumRodj.Name = "labelDatumRodj";
            this.labelDatumRodj.Size = new System.Drawing.Size(132, 22);
            this.labelDatumRodj.TabIndex = 19;
            this.labelDatumRodj.Text = "Datum rođenja:";
            this.labelDatumRodj.Visible = false;
            // 
            // labelRasaZiv
            // 
            this.labelRasaZiv.AutoSize = true;
            this.labelRasaZiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.labelRasaZiv.Location = new System.Drawing.Point(3, 286);
            this.labelRasaZiv.Name = "labelRasaZiv";
            this.labelRasaZiv.Size = new System.Drawing.Size(126, 22);
            this.labelRasaZiv.TabIndex = 21;
            this.labelRasaZiv.Text = "Rasa životinje:";
            this.labelRasaZiv.Visible = false;
            this.labelRasaZiv.Click += new System.EventHandler(this.label9_Click);
            // 
            // labelNoviLjubimac
            // 
            this.labelNoviLjubimac.AutoSize = true;
            this.labelNoviLjubimac.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.labelNoviLjubimac.Location = new System.Drawing.Point(103, 44);
            this.labelNoviLjubimac.Name = "labelNoviLjubimac";
            this.labelNoviLjubimac.Size = new System.Drawing.Size(126, 22);
            this.labelNoviLjubimac.TabIndex = 22;
            this.labelNoviLjubimac.Text = "Novi ljubimac?";
            // 
            // buttonDa
            // 
            this.buttonDa.Location = new System.Drawing.Point(124, 82);
            this.buttonDa.Name = "buttonDa";
            this.buttonDa.Size = new System.Drawing.Size(75, 23);
            this.buttonDa.TabIndex = 23;
            this.buttonDa.Text = "Da";
            this.buttonDa.UseVisualStyleBackColor = true;
            this.buttonDa.Click += new System.EventHandler(this.buttonDa_Click);
            // 
            // buttonNe
            // 
            this.buttonNe.Location = new System.Drawing.Point(124, 111);
            this.buttonNe.Name = "buttonNe";
            this.buttonNe.Size = new System.Drawing.Size(75, 23);
            this.buttonNe.TabIndex = 24;
            this.buttonNe.Text = " Ne";
            this.buttonNe.UseVisualStyleBackColor = true;
            this.buttonNe.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBoxUnosrase
            // 
            this.textBoxUnosrase.Location = new System.Drawing.Point(141, 288);
            this.textBoxUnosrase.Name = "textBoxUnosrase";
            this.textBoxUnosrase.Size = new System.Drawing.Size(240, 22);
            this.textBoxUnosrase.TabIndex = 25;
            this.textBoxUnosrase.Visible = false;
            // 
            // radioButtonPolM
            // 
            this.radioButtonPolM.AutoSize = true;
            this.radioButtonPolM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.radioButtonPolM.Location = new System.Drawing.Point(154, 329);
            this.radioButtonPolM.Name = "radioButtonPolM";
            this.radioButtonPolM.Size = new System.Drawing.Size(45, 26);
            this.radioButtonPolM.TabIndex = 26;
            this.radioButtonPolM.TabStop = true;
            this.radioButtonPolM.Text = "M";
            this.radioButtonPolM.UseVisualStyleBackColor = true;
            this.radioButtonPolM.Visible = false;
            // 
            // radioButtonPolZ
            // 
            this.radioButtonPolZ.AutoSize = true;
            this.radioButtonPolZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.radioButtonPolZ.Location = new System.Drawing.Point(205, 329);
            this.radioButtonPolZ.Name = "radioButtonPolZ";
            this.radioButtonPolZ.Size = new System.Drawing.Size(42, 26);
            this.radioButtonPolZ.TabIndex = 27;
            this.radioButtonPolZ.TabStop = true;
            this.radioButtonPolZ.Text = "Ž";
            this.radioButtonPolZ.UseVisualStyleBackColor = true;
            this.radioButtonPolZ.Visible = false;
            // 
            // dateTimePickerrodj
            // 
            this.dateTimePickerrodj.Location = new System.Drawing.Point(141, 370);
            this.dateTimePickerrodj.Name = "dateTimePickerrodj";
            this.dateTimePickerrodj.Size = new System.Drawing.Size(240, 22);
            this.dateTimePickerrodj.TabIndex = 28;
            this.dateTimePickerrodj.Visible = false;
            // 
            // labelIzborVrste
            // 
            this.labelIzborVrste.AutoSize = true;
            this.labelIzborVrste.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.labelIzborVrste.Location = new System.Drawing.Point(391, 19);
            this.labelIzborVrste.Name = "labelIzborVrste";
            this.labelIzborVrste.Size = new System.Drawing.Size(126, 22);
            this.labelIzborVrste.TabIndex = 29;
            this.labelIzborVrste.Text = "Vrsta životinje:";
            // 
            // labelIyborImena
            // 
            this.labelIyborImena.AutoSize = true;
            this.labelIyborImena.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.labelIyborImena.Location = new System.Drawing.Point(391, 54);
            this.labelIyborImena.Name = "labelIyborImena";
            this.labelIyborImena.Size = new System.Drawing.Size(112, 22);
            this.labelIyborImena.TabIndex = 30;
            this.labelIyborImena.Text = "Ime životinje:";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.bindingSourceZivotinja;
            this.comboBox1.DisplayMember = "Vrsta";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(551, 17);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(244, 24);
            this.comboBox1.TabIndex = 31;
            this.comboBox1.ValueMember = "LjubimacID";
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.bindingSourceZivotinja;
            this.comboBox2.DisplayMember = "Ime";
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(551, 56);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(243, 24);
            this.comboBox2.TabIndex = 32;
            this.comboBox2.ValueMember = "LjubimacID";
            // 
            // buttonDodajLjubimca
            // 
            this.buttonDodajLjubimca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.buttonDodajLjubimca.Location = new System.Drawing.Point(141, 416);
            this.buttonDodajLjubimca.Name = "buttonDodajLjubimca";
            this.buttonDodajLjubimca.Size = new System.Drawing.Size(75, 33);
            this.buttonDodajLjubimca.TabIndex = 33;
            this.buttonDodajLjubimca.Text = "Dodaj ljubimca";
            this.buttonDodajLjubimca.UseVisualStyleBackColor = true;
            this.buttonDodajLjubimca.Visible = false;
            this.buttonDodajLjubimca.Click += new System.EventHandler(this.buttonDodajLjubimca_Click);
            // 
            // FormKontaktZakazivanje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(1063, 608);
            this.Controls.Add(this.buttonDodajLjubimca);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.labelIyborImena);
            this.Controls.Add(this.labelIzborVrste);
            this.Controls.Add(this.dateTimePickerrodj);
            this.Controls.Add(this.radioButtonPolZ);
            this.Controls.Add(this.radioButtonPolM);
            this.Controls.Add(this.textBoxUnosrase);
            this.Controls.Add(this.buttonNe);
            this.Controls.Add(this.buttonDa);
            this.Controls.Add(this.labelNoviLjubimac);
            this.Controls.Add(this.labelRasaZiv);
            this.Controls.Add(this.labelDatumRodj);
            this.Controls.Add(this.labelPolZiv);
            this.Controls.Add(this.textBoxUnosVrsteZivotinje);
            this.Controls.Add(this.comboBoxIzborVeterinara);
            this.Controls.Add(this.labelImeZiv);
            this.Controls.Add(this.textBoxImeZivotinje);
            this.Controls.Add(this.buttonZakazi);
            this.Controls.Add(this.buttonOtkaziPregled);
            this.Controls.Add(this.labelDatum);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.labelRazlogPregleda);
            this.Controls.Add(this.textBoxRazlogPregledaUnos);
            this.Controls.Add(this.labelVeterinar);
            this.Controls.Add(this.labelVrstaZiv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormKontaktZakazivanje";
            this.Load += new System.EventHandler(this.FormKontaktZakazivanje_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bazaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceVlasnik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceZivotinja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceVeterinar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelVrstaZiv;
        private System.Windows.Forms.Label labelVeterinar;
        private System.Windows.Forms.TextBox textBoxRazlogPregledaUnos;
        private System.Windows.Forms.Label labelRazlogPregleda;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label labelDatum;
        private System.Windows.Forms.Button buttonOtkaziPregled;
        private System.Windows.Forms.Button buttonZakazi;
        private BazaDataSet bazaDataSet1;
        private System.Windows.Forms.BindingSource bindingSourceVlasnik;
        private BazaDataSetTableAdapters.VlasnikTableAdapter vlasnikTableAdapter;
        private System.Windows.Forms.BindingSource bindingSourceZivotinja;
        private BazaDataSetTableAdapters.LjubimacTableAdapter ljubimacTableAdapter;
        private System.Windows.Forms.TextBox textBoxImeZivotinje;
        private System.Windows.Forms.Label labelImeZiv;
        private System.Windows.Forms.ComboBox comboBoxIzborVeterinara;
        private System.Windows.Forms.TextBox textBoxUnosVrsteZivotinje;
        private System.Windows.Forms.BindingSource bindingSourceVeterinar;
        private BazaDataSetTableAdapters.VeterinarTableAdapter veterinarTableAdapter;
        private System.Windows.Forms.Label labelPolZiv;
        private System.Windows.Forms.Label labelDatumRodj;
        private System.Windows.Forms.Label labelRasaZiv;
        private System.Windows.Forms.Label labelNoviLjubimac;
        private System.Windows.Forms.Button buttonDa;
        private System.Windows.Forms.Button buttonNe;
        private System.Windows.Forms.TextBox textBoxUnosrase;
        private System.Windows.Forms.RadioButton radioButtonPolM;
        private System.Windows.Forms.RadioButton radioButtonPolZ;
        private System.Windows.Forms.DateTimePicker dateTimePickerrodj;
        private System.Windows.Forms.Label labelIzborVrste;
        private System.Windows.Forms.Label labelIyborImena;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button buttonDodajLjubimca;
    }
}