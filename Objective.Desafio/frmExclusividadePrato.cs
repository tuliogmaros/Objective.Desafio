using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Objective.Desafio
{
    public partial class frmExclusividadePrato : Form
    {
        public string Exclusividade { get; set; }
        public string PratoAdicionado { get; set; }
        public string PratoComparado { get; set; }

        public frmExclusividadePrato(string pratoAdicionado, string pratoComparado)
        {
            InitializeComponent();
            PratoAdicionado = pratoAdicionado;
            PratoComparado = pratoComparado;
        }

        private void btnOKComplete_Click(object sender, EventArgs e)
        {
            Exclusividade = txtRespostaComplete.Text;
            this.Close();
        }

        private void btnCancelarComplete_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmExclusividadePrato_Load(object sender, EventArgs e)
        {
            lblCompletar.Text = lblCompletar.Text.Replace("pratoAdicionado", PratoAdicionado).Replace("pratoComparado", PratoComparado);
        }
    }
}
