using System.Diagnostics.Eventing.Reader;

namespace Objective.Desafio
{
    public partial class frmPrincipal : Form
    {
        private List<Prato> _listaPratos = new List<Prato>();

        public frmPrincipal()
        {
            InitializeComponent();
            AdicionarPratosExistentes();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            IniciarJogo();
        }

        private void IniciarJogo()
        {
            foreach (var item in _listaPratos.OrderByDescending(o => !string.IsNullOrEmpty(o.Tipo?.Nome)))
            {
                if (MessageBox.Show($"O prato que você pensou é {(item.Tipo == null ? item.Nome : item.Tipo.Nome)}?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var listaFiltrada = _listaPratos.Where(w => w.Tipo == item.Tipo);
                    var exclusividadeFiltrada = listaFiltrada.Where(w => !string.IsNullOrEmpty(w.Exclusividade));

                    if (exclusividadeFiltrada.Any())
                    {
                        foreach (var itensExlusividade in exclusividadeFiltrada)
                        {
                            if (MessageBox.Show($"O prato que você pensou é {(itensExlusividade.Exclusividade)}?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                if (MessageBox.Show($"O prato que você pensou é {(itensExlusividade.Nome)}?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                {
                                    MessageBox.Show("Acertei de novo!", "Jogo Gourmet", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                                    return;
                                }
                            }
                        }
                    }

                    foreach (var itensFiltrados in listaFiltrada)
                    {
                        if (MessageBox.Show($"O prato que você pensou é {(item.Tipo != null ? item.Nome : item.Tipo.Nome)}?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            MessageBox.Show("Acertei de novo!", "Jogo Gourmet", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            return;
                        }
                        else
                        {
                            AdicionarPrato(itensFiltrados.Tipo, itensFiltrados.Nome);
                            return;
                        }
                    }
                }

                else if (_listaPratos.Where(w => w.Tipo != item.Tipo).Any())
                {
                    var listaFiltrada = _listaPratos.Where(w => w.Tipo != item.Tipo);
                    var exclusividadeFiltrada = listaFiltrada.Where(w => !string.IsNullOrEmpty(w.Exclusividade));

                    if (exclusividadeFiltrada.Any())
                    {
                        foreach (var itensExlusividade in exclusividadeFiltrada)
                        {
                            if (MessageBox.Show($"O prato que você pensou é {(itensExlusividade.Exclusividade)}?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                if (MessageBox.Show($"O prato que você pensou é {(itensExlusividade.Nome)}?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                {
                                    MessageBox.Show("Acertei de novo!", "Jogo Gourmet", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                                    return;
                                }
                            }
                        }
                    }

                    foreach (var itensFiltrados in listaFiltrada)
                    {
                        if (MessageBox.Show($"O prato que você pensou é {(itensFiltrados.Tipo == null ? itensFiltrados.Nome : itensFiltrados.Tipo.Nome)}?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            MessageBox.Show("Acertei de novo!", "Jogo Gourmet", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            return;
                        }
                        else
                        {
                            AdicionarPrato(null, itensFiltrados.Nome);
                            return;
                        }
                    }
                }
            }
        }

        private void AdicionarPratosExistentes()
        {
            _listaPratos.Add(new Prato()
            {
                Nome = "Lasanha",
                Tipo = new Tipo() { Nome = "massa"}
            });

            _listaPratos.Add(new Prato()
            {
                Nome = "Bolo de chocolate"
            });
        }

        private void AdicionarPrato(Tipo? tipo = null, string pratoComparado = "")
        {
            var frmQuest = new frmQuestionarioPrato(pratoComparado);
            frmQuest.ShowDialog();

            _listaPratos.Add(new Prato()
            {
                Nome = frmQuest.Prato,
                Exclusividade = frmQuest.Exclusividade,
                Tipo = tipo ?? new Tipo()
            });
        }
    }
}
