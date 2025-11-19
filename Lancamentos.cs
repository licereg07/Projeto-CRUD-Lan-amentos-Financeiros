using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Projeto_CRUD_Lançamentos_Financeiros
{
    internal class Lancamentos
    {
        public int id;
        public decimal valor;
        public string descricao;
        public DateTime data_lançamento;
        public string tipo;

  

    public bool salvarLancamento()
        {
            Banco bd = new Banco();
            SqlConnection cn = bd.abrirConexao();
            SqlTransaction tran = cn.BeginTransaction();
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = cn;
            cmd.Transaction = tran;
            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "insert into lancamentos " + "values (@valor, @descricao, @data_lancamento, @tipo)";
            cmd.Parameters.AddWithValue("@valor", valor);
            cmd.Parameters.AddWithValue("@descricao", descricao);
            cmd.Parameters.AddWithValue("@data_lancamento", data_lançamento);
            cmd.Parameters.AddWithValue("@tipo", tipo);

            try
            {
                cmd.ExecuteNonQuery();
                tran.Commit();
                return true;
            }
            catch (Exception ex)
            {
                tran.Rollback();
                return false;
            }
            finally
            {
                bd.fecharConexao();
            }
        }

        public bool excluirLancamento()
        {
            Banco bd = new Banco();
            SqlConnection cn = bd.abrirConexao();
            SqlTransaction tran = cn.BeginTransaction();
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = cn;
            cmd.Transaction = tran;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from lancamentos where id = @id";

            cmd.Parameters.Add("@id", SqlDbType.Int);
            cmd.Parameters[0].Value = id;

            try
            {
                cmd.ExecuteNonQuery();
                tran.Commit();
                return true;
            }
            catch (Exception ex)
            {
                tran.Rollback();
                return false;
            }
            finally
            {
                bd.fecharConexao();
            }
        }

        public bool editarLancamento()
        {
            Banco bd = new Banco();

            SqlConnection cn = bd.abrirConexao();
            SqlTransaction tran = cn.BeginTransaction();
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = cn;
            cmd.Transaction = tran;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update lancamentos set valor = @valor, descricao = @descricao where id = @id";

            cmd.Parameters.Add("@valor", SqlDbType.Real);
            cmd.Parameters.Add("@descricao", SqlDbType.VarChar);
            cmd.Parameters.Add("@id", SqlDbType.Int);
            cmd.Parameters[0].Value = valor;
            cmd.Parameters[1].Value = descricao;
            cmd.Parameters[2].Value = id;


            try
            {
                cmd.ExecuteNonQuery();
                tran.Commit();
                return true;
            }
            catch
            {
                tran.Rollback();
                return false;
            }
            finally
            {
                bd.fecharConexao();
            }

        }

        public DataTable consultaLancamento(string filtro)
        {
            Banco bd = new Banco();
            DataTable tabela = new DataTable();

            try
            {
                SqlConnection cn = bd.abrirConexao();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;

                // Monta o SQL dependendo do filtro
                if (filtro == "Todos")
                {
                    cmd.CommandText = "SELECT * FROM lancamentos";
                }
                else
                {
                    cmd.CommandText = "SELECT * FROM lancamentos WHERE tipo = @filtro";
                    cmd.Parameters.AddWithValue("@filtro", filtro);
                }

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabela);

                return tabela;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao consultar: " + ex.Message);
                return null;
            }
            finally
            {
                bd.fecharConexao();
            }
        }

        public Lancamentos verlancamentos(int id)
        {
            Banco bd = new Banco();

            try
            {
                SqlConnection cn = bd.abrirConexao();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "select * from lancamentos";

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    if (reader.GetInt32(0) == id)
                    {
                        this.id = reader.GetInt32(0);
                        this.descricao = reader.GetString(2);
                        this.valor = reader.GetDecimal(1);
                        this.data_lançamento = DateTime.Parse(reader.GetString(3));
                        this.tipo = reader.GetString(4);

                        return this;
                    }
                }

                return null;

            }
            catch (Exception ex)
            {

                return null;
            }
            finally
            {
                bd.fecharConexao();
            }
        }
    } 
}
