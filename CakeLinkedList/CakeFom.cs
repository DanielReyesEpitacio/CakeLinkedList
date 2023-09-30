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
    public partial class CakeFom : Form
    {
        public event Action OnAction;
        public CakeFom()
        {
            InitializeComponent();
        }

        private void ExecuteOnAction()
        {
            OnAction?.Invoke();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ExecuteOnAction();
        }
    }
}
