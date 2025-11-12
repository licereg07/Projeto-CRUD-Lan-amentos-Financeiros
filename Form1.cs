using System.Data;
using System.Xml.Linq;

namespace Projeto_CRUD_Lançamentos_Financeiros
{
    public partial class Form1 : Form
    {

        decimal saldo;
        public Form1()
        {
            InitializeComponent();
        }

        private void btncredito_Click(object sender, EventArgs e)
        {
            lbltipo2.Text = "Crédito";
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

            MessageBox.Show("Crédito lançado com sucesso!");

            valor = +valor;
            saldo += valor;

            lblsaldo.Text = "Saldo atual: " + saldo.ToString();


            txbvalor.Text = (" ");
            txbdesc.Text = (" ");
            lbltipo2.Text = (" ");
        }

        private void btndebito_Click(object sender, EventArgs e)
        {
            lbltipo2.Text = "Débito";
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

            lblsaldo.Text = "Saldo atual: " + saldo.ToString();

            MessageBox.Show("Débito lançado com sucesso!");

            valor = -valor;
            saldo += valor;

            lblsaldo.Text = "Saldo atual: " + saldo.ToString();


            txbvalor.Text = (" ");
            txbdesc.Text = (" ");
            lbltipo2.Text = (" ");
        }

        private void btnconsultar_Click(object sender, EventArgs e)
        {
            // Cria a conexão com o banco
            Banco bd = new Banco();

            // Busca todos os lançamentos
            string sql = "select * from lancamentos";
            DataTable dt = bd.executarConsulta(sql);

            // Mostra os dados na tabela da tela
            dataGridView1.DataSource = dt;

            // Agora vamos calcular o saldo
            decimal saldoTotal = 0;

            // Para cada linha da tabela (cada lançamento)
            foreach (DataRow linha in dt.Rows)
            {
                // Pega o tipo do lançamento (Crédito ou Débito)
                string tipo = linha["tipo"].ToString();

                // Pega o valor
                decimal valor = Convert.ToDecimal(linha["valor"]);

                // Se for crédito, soma. Se for débito, subtrai.
                if (tipo == "Crédito")
                {
                    saldoTotal += valor;
                }
                else if (tipo == "Débito")
                {
                    saldoTotal -= valor;
                }
            }

            // Mostra o saldo na tela
            lblsaldo.Text = "Saldo atual: R$ " + saldoTotal.ToString("N2");
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
    }
}

