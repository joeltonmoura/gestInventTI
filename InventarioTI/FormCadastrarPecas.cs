using InventarioTI.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace InventarioTI
{
    public partial class FormCadastrarPecas : Form
    {
        private ConnectBd conn ;
        private string queryPecasAll; 
        public FormCadastrarPecas()
        {
            InitializeComponent();
            conn = new ConnectBd();
        }

        private void txtNomePeca_Leave(object sender, EventArgs e)
        {
            if (txtNomePeca.Text == "")
            {
                txtNomePeca.Text = "nome da peça";
                txtNomePeca.ForeColor = Color.DarkGray;
            }
        }

        private void txtNomePeca_Enter(object sender, EventArgs e)
        {
            if(txtNomePeca.Text == "nome da peça")
            {
                txtNomePeca.Text = null;
                txtNomePeca.ForeColor = Color.Black;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (txtModeloPeca.Text == "")
            {
                txtModeloPeca.Text = "modelo peça";
                txtModeloPeca.ForeColor = Color.DarkGray;
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (txtModeloPeca.Text == "modelo peça")
            {
                txtModeloPeca.Text = null;
                txtModeloPeca.ForeColor = Color.Black;
            }
        }

        private void FormCadastrarPecas_Load(object sender, EventArgs e)
        {
            atualizarDataGridPecas();

        }

        private void atualizarDataGridPecas()
        {
            try
            {
                queryPecasAll = @"SELECT * FROM ST_SELECTALLPECAS()";
                dgvPecas.DataSource = null;
                dgvPecas.DataSource = conn.executeDataTable(queryPecasAll);
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex);
            }
        }

        private void btnAddPeca_MouseHover(object sender, EventArgs e)
        {
            btnAddPeca.BackColor = ColorTranslator.FromHtml("#00a000");
           
        }

        private void btnAddPeca_MouseLeave(object sender, EventArgs e)
        {
            btnAddPeca.BackColor = Color.LimeGreen;
        }

        private void btnEditarPeca_MouseHover(object sender, EventArgs e)
        {
            btnEditarPeca.BackColor = ColorTranslator.FromHtml("#f0f000");
        }

        private void btnEditarPeca_MouseLeave(object sender, EventArgs e)
        {
            btnEditarPeca.BackColor = Color.Gold;
        }


        private void btnAddPeca_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this.txtMarcaPeca.Text);

            try
            {
                queryPecasAll = @"SELECT * FROM ST_SELECTALLPECAS()";
                dgvPecas.DataSource = null;
                dgvPecas.DataSource = conn.executeDataTable(queryPecasAll);
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex);
            }

        }

        private void txtMarcaPeca_Enter(object sender, EventArgs e)
        {
            if (txtMarcaPeca.Text == "marca peça")
            {
                txtMarcaPeca.Text = null;
                txtMarcaPeca.ForeColor = Color.Black;
            }
        }

        private void txtMarcaPeca_Leave(object sender, EventArgs e)
        {
            if (txtMarcaPeca.Text == "")
            {
                txtMarcaPeca.Text = "marca peça";
                txtMarcaPeca.ForeColor = Color.DarkGray;
            }
        }
    }
}
