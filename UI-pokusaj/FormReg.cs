﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace UI_pokusaj
{

    public partial class FormReg : Form
    {
        public FormReg()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void FormReg_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void buttonReg_Click(object sender, EventArgs e)
        {
            const int min = 6;
            string p = textBoxPW.Text;
            if (p.Length < min)
            {
                MessageBox.Show("Lozinka mora da ima BAREM 6 karaktera. Pokusajte opet!");
            }

            if (textBoxUsername1.Text == "" || textBoxPW.Text == "" || textBoxConfirm.Text == ""
                || textBoxCity.Text == "" || textBoxAdress.Text == "" || textBoxNAME.Text == "" 
                || textBoxSURNAME.Text == "" || textBoxPN.Text == "")
            {
                MessageBox.Show("Molimo Vas popunite sva polja u formularu za registraciju. Hvala!"); 
            }

         
            else if(textBoxPW.Text == textBoxConfirm.Text)
            {
                MessageBox.Show("Uspešno ste kreirali korisnički nalog.");

                // upis svih podataka vezanih za korisnika u bazu //
                // ime,prezime,brtel,grad,adresa,username i pw //

                textBoxUsername1.Text = "";
                textBoxPW.Text = "";
                textBoxConfirm.Text = "";
                textBoxCity.Text = "";
                textBoxAdress.Text = "";
                textBoxNAME.Text = "";
                textBoxSURNAME.Text = "";
                textBoxPN.Text = "";

            } 
        else
            {
                MessageBox.Show("Pokušajte ponovo!", "Lozinke se ne poklapaju");
                textBoxPW.Text = "";
                textBoxConfirm.Text = "";
                textBoxPW.Focus();
            }
            

        }

        private void textBoxPN_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            textBoxPN.MaxLength = 10;
        }

        private void checkBoxShow_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShow.Checked)
            {
                textBoxPW.PasswordChar = '\0';
                textBoxConfirm.PasswordChar = '\0';
            }
        else
            {
                textBoxPW.PasswordChar = '•';
                textBoxConfirm.PasswordChar = '•';
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {
            new LogInForm().Show();
            this.Hide();
        }
    }
}
