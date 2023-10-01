using CakeLinkedList.models;
using System;
using System.Windows.Forms;

namespace CakeLinkedList
{
    public partial class CakeForm : Form
    {
        private form1 listener;

        public CakeForm(form1 listener)
        {
            InitializeComponent();
            this.listener = listener;
            actionTypeComboBox.SelectedIndex = 0;
        }

        private void addCakeButton_Click(object sender, EventArgs e)
        {
            if (accurateData())
            {
                Cake cake = new Cake();
                cake.flavor = flavorTxt.Text;
                cake.size = int.Parse(sizeTxt.Text);
                cake.color = colorTxt.Text;
                cake.price = double.Parse(priceTxt.Text);
                cake.portions = int.Parse(portionsTxt.Text);
                cake.distributor = distributorTxt.Text;
                this.Close();
                listener.onSubmitCakeForm(new SaveCakeEvent(cake, actionTypeComboBox.SelectedItem.ToString()));
            }

        }
        //Aunque las validaciones de los datos evitan ingresar información incorrecta, dejar los campos vacíos proboca exepción
        private bool accurateData()
        {
            bool ok = false;
            if (flavorTxt.Text != "")
            {
                if(int.TryParse(sizeTxt.Text, out _)){
                    if (colorTxt.Text != "")
                    {
                        if(double.TryParse(priceTxt.Text, out _))
                        {
                            if(int.TryParse(portionsTxt.Text, out _))
                            {
                                if (distributorTxt.Text != "")
                                {
                                    ok = true;
                                }
                                else
                                {
                                    MessageBox.Show("Ingrese un distribuidor", "Notificación");
                                    distributorTxt.Focus();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Ingrese una porción", "Notificación");
                                portionsTxt.Focus();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Ingrese un precio", "Notificación");
                            priceTxt.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Debe ingresar un color", "Notificación");
                        colorTxt.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese un tamaño", "Notificación");          
                    sizeTxt.Focus();
                }
            }
            else
            {
                MessageBox.Show("No puede dejar el sabor vacío", "Notificación");
                flavorTxt.Focus();
            }
            return ok;
        }

        //Impide que se ingrese un caracter que no sea un número.
        private void sizeTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        //Impide que se agregue un caracter que no sea un número.
        private void portionsTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        //Solo permite ingresar caracteres que sean números y un punto decimal.
        private void priceTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true; 
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
