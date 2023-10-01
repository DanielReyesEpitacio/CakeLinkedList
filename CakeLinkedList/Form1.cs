using CakeLinkedList.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CakeLinkedList
{
    public partial class form1 : Form
    {
        private ListaEnlazada<Cake> cakes;
        public form1()
        {
            cakes = new ListaEnlazada<Cake>();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //cakes.add(new Cake("Manzana", 8, "Rojo", 423.12, 16, "La zarza"));
            //cakes.add(new Cake("Pera", 7, "Rojo", 553.12, 26, "La morena"));
            updateGridView(cakes.ToList<Cake>());

        }

        //Este método se ejecuta al dar click en el botón "guardar" de la clase "CakeForm"
        public void onSubmitCakeForm(SaveCakeEvent evt)
        {
            switch (evt.actionType)
            {
                case "Agregar al inicio":
                    cakes.addHead(evt.cake);
                    updateGridView(cakes.ToList<Cake>());
                    MessageBox.Show("Pastel agregado al inicio de la lista", "Notificación");
                    break;
                case "Agregar al final":
                    cakes.add(evt.cake);
                    updateGridView(cakes.ToList<Cake>());
                    MessageBox.Show("Pastel agregado al final de la lista", "Notificación");
                    break;
                default:
                    MessageBox.Show("Accion no definida");
                    break;
            }
        }

        
        private void reverseButton_Click(object sender, EventArgs e)
        {
            updateGridView(cakes.Reverse<Cake>().ToList<Cake>());
        }

        private void sortButton_Click(object sender, EventArgs e)
        {
            updateGridView(cakes.ToList<Cake>());
        }

        //validaciones al editar una celda
        private void cakeGridView_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            List<string> columns = new List<string> { "size", "price", "portions", "weight" };
            if (columns.Contains(cakeGridView.Columns[e.ColumnIndex].Name))
            {
                if (!double.TryParse(e.FormattedValue.ToString(), out double valor))
                {
                    if (!(valor > 0))
                    {
                        e.Cancel = true;
                        MessageBox.Show(this, "Introduzca un número válido mayor a 0");
                    }
                }
            }
            else
            {
                if (string.IsNullOrEmpty(e.FormattedValue.ToString()))
                {
                    e.Cancel = true;
                    MessageBox.Show("El campo no puede quedar vacío");
                }
            }
        }

        //Abre el formulario para crear un nuevo pastel
        private void addCakeButton_Click(object sender, EventArgs e)
        {
            CakeForm form = new CakeForm(this);
            form.Show();
        }


        private void updateGridView(List<Cake> list)
        {
            cakeGridView.DataSource = null;
            cakeGridView.DataSource = list;
        }
    }
}
