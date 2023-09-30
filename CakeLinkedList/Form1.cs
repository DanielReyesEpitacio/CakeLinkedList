﻿using CakeLinkedList.models;
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
    public partial class Form1 : Form
    {
        private ListaEnlazada<Cake> cakes;
        public Form1()
        {
            cakes = new ListaEnlazada<Cake>();
            InitializeComponent();
        }

        //Este método se ejecuta al dar click en el botón "guardar" de la clase "CakeForm"
        public void onSubmitCakeForm(Cake model)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cakes.add(new Cake("Manzana",8,"Rojo",423.12,16,"La zarza"));
            cakes.add(new Cake("Pera", 7, "Rojo", 553.12, 26, "La morena"));
            updateGridView(cakes.ToList<Cake>());

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CakeForm form = new CakeForm(this);
            form.Show();
        }

        private void updateGridView(List<Cake> list)
        {
            cakeGridView.DataSource = null;
            cakeGridView.DataSource = list;

        }

        private void reverseButton_Click(object sender, EventArgs e)
        {
            updateGridView(cakes.Reverse<Cake>().ToList<Cake>());
        }

        private void insertHeadButton_Click(object sender, EventArgs e)
        {
            //Llamar al formulario
            cakes.addHead(new Cake("Durazno", 7, "Naranja", 553.12, 26, "La morena"));
            updateGridView(cakes.ToList<Cake>());
        }

        private void insertCakeButton_Click(object sender, EventArgs e)
        {
            cakes.add(new Cake("Moras Azules", 7, "Morado", 553.12, 26, "La morena"));
            updateGridView(cakes.ToList<Cake>());
        }

        private void sortButton_Click(object sender, EventArgs e)
        {
            updateGridView(cakes.ToList<Cake>());
        }

        //validaciones al editar una celda
        private void cakeGridView_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            
        }

    }
}
