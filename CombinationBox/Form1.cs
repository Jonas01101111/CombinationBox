using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CombinationBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

       

        private void btnInsert_Click(object sender, EventArgs e)
        {
            cbxLista.Items.Add(tbTexto.Text);
            tbTexto.Text = "";
            lbQuantidade.Text = cbxLista.Items.Count.ToString();
            cbxLista.Select();
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            if (cbxLista.Sorted == false)
            {
                cbxLista.Sorted = true;
            }
            else
            {
                cbxLista.Sorted = false;
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (cbxLista.SelectedIndex != -1)
            {
                cbxLista.Items.RemoveAt(int.Parse(tbIndice.Text));
            }
            lbQuantidade.Text = cbxLista.Items.Count.ToString();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (cbxLista.SelectedIndex != -1)
            {
                tbTextoCombo.Text= cbxLista.SelectedItem.ToString();
                tbIndice.Text= cbxLista.SelectedIndex.ToString();
            }
        }

        
    }
}
