using System.Data;
using System.Xml.Linq;

namespace Projeto_CRUD_Lançamentos_Financeiros
{
    public partial class Form1 : Form
    {

        decimal saldo = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btncredito_Click(object sender, EventArgs e)
        {

            lbltipo3.Text = "Crédito";
            decimal valor;
            if (!decimal.TryParse(txbvalor.Text, out valor))
            {
                MessageBox.Show("Digite um valor válido!");
                return;
            }

            string descricao = txbdesc.Text;
            DateTime data = date.Value;

            Lancamentos lanc = new Lancamentos();
            lanc.valor = valor;
            lanc.descricao = descricao;
            lanc.data_lançamento = data;
            lanc.tipo = "Crédito";


            bool retorno = lanc.salvarLancamento();
            valor = +valor;
            saldo += valor;
            label1.Text = "Valor Creditado: R$ " + valor.ToString();


            MessageBox.Show("Crédito lançado com sucesso!");


            txbvalor.Text = "";
            txbdesc.Text = "";
            lbltipo3.Text = "";
            label1.Text = "";
        }

        private void btndebito_Click(object sender, EventArgs e)
        {
            lbltipo3.Text = "Débito";


            decimal valor;
            if (!decimal.TryParse(txbvalor.Text, out valor))
            {
                MessageBox.Show("Digite um valor válido!");
                return;
            }


            string descricao = txbdesc.Text;
            DateTime data = date.Value;


            Lancamentos lanc = new Lancamentos();
            lanc.valor = valor;
            lanc.descricao = descricao;
            lanc.data_lançamento = data;
            lanc.tipo = "Débito";
            bool retorno = lanc.salvarLancamento();

            saldo -= valor;


            label1.Text = "Valor Debitado: R$ " + saldo.ToString();


            MessageBox.Show("Débito lançado com sucesso!");


            txbvalor.Text = "";
            txbdesc.Text = "";
            lbltipo3.Text = "";
            label1.Text = "";
        }

        private void btnconsultar_Click(object sender, EventArgs e)
        {
            Banco bd = new Banco();

            string sql = "select * from lancamentos";
            DataTable dt = bd.executarConsulta(sql);

            // Mostra os dados na tabela da tela
            dataGridView1.DataSource = dt;

            decimal saldoTotal = 0;
            decimal totalcredito = 0;
            decimal totaldebito = 0;

            // Para cada linha da tabela (cada lançamento)
            foreach (DataRow linha in dt.Rows)
            {
                // Pega o tipo do lançamento (Crédito ou Débito)
                string tipo = linha["tipo"].ToString();

                // Pega o valor
                decimal valor = Convert.ToDecimal(linha["valor"]);

                // Se for crédito, soma e tal
                if (tipo == "Crédito")
                {
                    saldoTotal += valor;
                    totalcredito += valor;
                }
                else if (tipo == "Débito")
                {
                    saldoTotal -= valor;
                    totaldebito += valor;
                }


            }

            // Mostra o saldo na tela
            lblsaldo.Text = "Saldo atual: R$ " + saldoTotal.ToString();
            lbltocre.Text = "Total Creditado: R$ " + totalcredito.ToString();
            lbltode.Text = "Total Debitado: R$ " + totaldebito.ToString();

        }

        private void btnfiltro_Click(object sender, EventArgs e)
        {
            Lancamentos lanc = new Lancamentos();
            string filtro = cbfiltros.Text; // pega o texto do combobox

            DataTable resultado = lanc.consultaLancamento(filtro);

            if (resultado != null)
            {
                dataGridView1.DataSource = resultado; // mostra no DataGridView
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }




        private void txbid_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            Lancamentos lanc = new Lancamentos();
            lanc.id = int.Parse(txbid.Text);
            lanc.valor = decimal.Parse(txbvalor2.Text);
            lanc.descricao = txbdesc2.Text;
            bool retorno = lanc.editarLancamento();

            if (retorno)
            {
                MessageBox.Show(lanc.descricao + " atualizado com sucesso!");
            }
            else
            {
                MessageBox.Show("Erro ao atualizar " + lanc.descricao);
            }
        }

        private void btnver_Click(object sender, EventArgs e)
        {
            Lancamentos lanc = new Lancamentos();
            lanc.verlancamentos(int.Parse(txbid.Text));

            txbdesc2.Text = lanc.descricao;
            txbvalor2.Text = lanc.valor.ToString();
        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {
            Lancamentos lanc = new Lancamentos();

            lanc.id = int.Parse(txbid.Text);
            bool retorno = lanc.excluirLancamento();

            if (retorno)
            {
                MessageBox.Show("Excluído com sucesso!");
            }
            else
            {
                MessageBox.Show("Erro ao excluir!");
            }
        }
    }


}

