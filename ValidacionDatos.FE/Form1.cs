using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ValidacionDatos.FE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Btt_Limpiar_Click(object sender, EventArgs e)
        {
            Mtb_CUIL.Text = string.Empty;
            Lb_ValorDNI.Text = string.Empty;
        }

        private void Btt_ExtraerDNI_Click(object sender, EventArgs e)
        {
            string CUIL = Mtb_CUIL.Text;
            string DNI;
            char ch;
            bool completo = true;
            if (CUIL.Length != 12) completo = false;
            else
            {
                for (int i = 0; i < 12; i++)
                {
                    ch = CUIL[i];
                    if ((ch == ' ') || (ch == '_'))
                    {
                        completo = false;
                        break;
                    }
                }
            }
            if (!completo)
            {
                MessageBox.Show("El CUIL está incompleto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DNI = CUIL.Substring(2, 8);
                Lb_ValorDNI.Text = DNI;
            }
        }
        private void Tb_Patente_TextChanged(object sender, EventArgs e)
        {
        }
        private void Btt_ValidarPatente_Click(object sender, EventArgs e)
        {
            Tb_Patente.Text = Tb_Patente.Text.Trim().ToUpper();
            string patente = Tb_Patente.Text;
            bool error = false;
            char ch;
            char formato;
            if (Tb_Patente.Text.Length == 6)
            {
                formato = 'V';
            }
            else if (Tb_Patente.Text.Length == 7)
            {
                formato = 'M';
            }
            else
            {
                formato = 'E';
            }

            switch (formato)
            {
                case 'V':
                    for (int i = 0; i < 3; i++)
                    {
                        ch = patente[i];
                        if (!char.IsLetter(ch))
                        {
                            error = true;
                            break;
                        }
                    }
                    for (int i = 3; i < 6; i++)
                    {
                        ch = patente[i];
                        if (!char.IsDigit(ch))
                        {
                            error = true;
                            break;
                        }
                    }
                    if (!error)
                    {
                        MessageBox.Show($"La patente {patente} con formato:\n" +
                            "AAANNN\n" +
                            "ha sido validada.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("La patente no coincide con nigún formato oficial.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                case 'M':
                    for (int i = 0; i < 2; i++)
                    {
                        ch = patente[i];
                        if (!char.IsLetter(ch))
                        {
                            error = true;
                            break;
                        }
                    }
                    for (int i = 2; i < 5; i++)
                    {
                        ch = patente[i];
                        if (!char.IsDigit(ch))
                        {
                            error = true;
                            break;
                        }
                    }
                    for (int i = 5; i < 7; i++)
                    {
                        ch = patente[i];
                        if (!char.IsLetter(ch))
                        {
                            error = true;
                            break;
                        }
                    }
                    if (!error)
                    {
                        MessageBox.Show($"La patente {patente} con formato:\n" +
                            "AANNNAA\n" +
                            "ha sido validada.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("La patente no coincide con nigún formato oficial.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                case 'E':
                    MessageBox.Show("La patente contiene una cantidad errónea de caracteres.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }
    }
}
