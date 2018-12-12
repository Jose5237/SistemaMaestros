using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistema_maestros1
{
    class Validaciones
    {
        public void SoloLetras(KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se aceptan letras", "¡Error de caracteres!");
            }
        }

        public void SoloNumeros(KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se aceptan números", "¡Error de caracteres!");
            }
        }

        bool bandera = true;
        public void SoloNumerosDecimal(KeyPressEventArgs e)
        {
            

            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if(Char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            
            else if(e.KeyChar.ToString().Equals(".") && bandera)
            {
                e.Handled = false;
                bandera = false;   
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se aceptan números decimales y un solo punto", "¡Error de caracteres!");
                //bandera = false;
            }
            
        }

        public void SoloLetrasYComas(KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if(e.KeyChar.ToString().Equals(",") || e.KeyChar.ToString().Equals("."))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se aceptan letras", "¡Error de caracteres!");
            }
        }
    }
}
