namespace Comision
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btCalcular_Click(object sender, EventArgs e)
        {

            if (txtCod.Text == "")
            {
                MessageBox.Show("El campo codigo no puede estar vacío.");
                txtCod.Focus();
                return;
            }

            if (txtSeccion.Text == "")
            {
                MessageBox.Show("El campo seccion no puede estar vacío.");
                txtSeccion.Focus();
                return;
            }

            if (txtImp.Text == "")
            {
                MessageBox.Show("El campo importe no puede estar vacío.");
                txtImp.Focus();
                return;
            }

            string cod = txtCod.Text;
            string seccion = txtSeccion.Text;

            double Importe = double.Parse(txtImp.Text);
            double acumulador = 0;
            double ImpFinal = 0;


            double comm;
            double comAYB;
            double comres;
            double comz;
            double comAyBZ;
            double comResZ;
            double AcuCom;

            if (cod == "M")
            {
                acumulador = (Importe * 0.01) + Importe;
                comm = acumulador;


                if (seccion == "A" || seccion == "B")
                {
                    comAYB = (Importe * 0.05) + acumulador;
                    comres = 0;
                }
                else
                {
                    comres = (Importe * 0.08) + acumulador;
                    comAYB = 0;
                }

                ImpFinal = comAYB + comres;

                string Cadena = "ComM: " + comm + ", " + "ComAYB: " + comAYB + ", " + "Comres: " + comres + ", " + "Importe Final: " + ImpFinal;

                MessageBox.Show(Cadena);

            }


            if (cod == "Z")
            {
                acumulador = (Importe * 0.02) + Importe;
                comz = acumulador;


                if (seccion == "A" || seccion == "B")
                {
                    comAyBZ = (Importe * 0.05) + acumulador;
                    comResZ = 0;
                }
                else
                {
                    comResZ = (Importe * 0.08) + acumulador;
                    comAyBZ = 0;
                }

                ImpFinal = comAyBZ + comResZ;

                string Cadena = "ComZ: " + comz + ", " + "ComAYBZ: " + comAyBZ + ", " + "ComresZ: " + comResZ + ", " + "Importe Final: " + ImpFinal;

                MessageBox.Show(Cadena);

            }



            if (cod == "X")
            {
                Close();

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {


            Close();


        }

        private void txtSeccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten letras");
            }
        }

        private void txtImp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten numeros");
            }
        }

        private void txtCod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten letras");
            }
        }

        private void txtCod_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCod.Text))
            {
                txtCod.Tag = false;
            }
            else
            {
                txtCod.Tag = true;
            }
        }

        private void txtSeccion_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSeccion.Text))
            {
                txtSeccion.Tag = false;
            }
            else
            {
                txtSeccion.Tag = true;
            }
        }

        private void txtImp_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtImp.Text))
            {
                txtImp.Tag = false;
            }
            else
            {
                txtImp.Tag = true;
            }
        }
    }
}