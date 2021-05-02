using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace InventarioTI
{
    public partial class FormMenuPrincipal : Form
    {
        Thread theredAbriJanelaCadastroPecas;
        public FormMenuPrincipal()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            theredAbriJanelaCadastroPecas = new Thread(abriJanelaCadastro);
            theredAbriJanelaCadastroPecas.SetApartmentState(ApartmentState.STA);
            theredAbriJanelaCadastroPecas.Start();
        }

        private void abriJanelaCadastro(object obj)
        {
            Application.Run(new FormCadastrarPecas());
        }
    }
}
