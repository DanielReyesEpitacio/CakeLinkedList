using CakeLinkedList.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CakeLinkedList
{
    public partial class CakeForm : Form
    {
        private Form1 listener;

        public CakeForm(Form1 listener)
        {
            this.listener = listener;
        }

        //Modificar el objeto  de tipo pastel (Cake) y enviarlo al form1
        private void button1_Click(object sender, EventArgs e)
        {
            Cake cake = new Cake();

            listener.onSubmitCakeForm(cake);
        }
    }
}
