using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation.Results;

namespace Dados
{
    public class ClienteRepository
    {

        public string Insert(Cliente cliente)
        {
            string resp = "";
            try
            {
                Connection.getConnection();

                SqlCommand SqlCmd = new SqlCommand
                {
                    Connection = Connection.SqlCon,
                    CommandText = "INSERT INTO cliente (nome, email, tipoPessoa) VALUES (@pNome, @pEmail, @pTipoPessoa) ",
                    CommandType = CommandType.Text
                };
                SqlCmd.Parameters.AddWithValue("pNome", cliente.Nome);
                SqlCmd.Parameters.AddWithValue("pEmail", cliente.Email);
                SqlCmd.Parameters.AddWithValue("pTipoPessoa", cliente.tipoPessoa);

                //executa o stored procedure
                resp = SqlCmd.ExecuteNonQuery() == 1 ? "SUCESSO" : "FALHA";
            }
            catch (Exception ex)
            {
                resp = ex.Message;
            }
            finally
            {
                if (Connection.SqlCon.State == ConnectionState.Open)
                    Connection.SqlCon.Close();
            }

            return resp;
        }

        public string Update(Cliente cliente)
        {
            string resp = "";
            try
            {
                Connection.getConnection();

                string updateSql = String.Format("UPDATE cliente SET " +
                                    "Nome = @pNome, email = @pEmail " +
                                    "WHERE id = @pId ");
                SqlCommand SqlCmd = new SqlCommand(updateSql, Connection.SqlCon);
                SqlCmd.Parameters.AddWithValue("pNome", cliente.Nome);
                SqlCmd.Parameters.AddWithValue("pEmail", cliente.Email);
                SqlCmd.Parameters.AddWithValue("pId", cliente.Id);

                //executa o stored procedure
                resp = SqlCmd.ExecuteNonQuery() == 1 ? "SUCESSO" : "FALHA";
            }
            catch (Exception ex)
            {
                resp = ex.Message;
            }
            finally
            {
                if (Connection.SqlCon.State == ConnectionState.Open)
                    Connection.SqlCon.Close();
            }
            return resp;
        }

        public string Remove(int idCliente)
        {
            string resp = "";
            try
            {
                Connection.getConnection();

                string updateSql = String.Format("DELETE FROM cliente " +
                                    "WHERE id = @pId ");
                SqlCommand SqlCmd = new SqlCommand(updateSql, Connection.SqlCon);
                SqlCmd.Parameters.AddWithValue("pId", idCliente);

                //executa o stored procedure
                resp = SqlCmd.ExecuteNonQuery() == 1 ? "SUCESSO" : "FALHA";
            }
            catch (Exception ex)
            {
                resp = ex.Message;
            }
            finally
            {
                if (Connection.SqlCon.State == ConnectionState.Open)
                    Connection.SqlCon.Close();
            }
            return resp;
        }

        public DataTable getAll()
        {
            DataTable DtResultado = new DataTable("cliente");
            try
            {
                Connection.getConnection();
                String sqlSelect = "select * from cliente";

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = Connection.SqlCon;
                SqlCmd.CommandText = sqlSelect;
                SqlCmd.CommandType = CommandType.Text;
                SqlDataAdapter SqlData = new SqlDataAdapter(SqlCmd);
                SqlData.Fill(DtResultado);
            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;
        }

        public DataTable filterByName(string pNome)
        {
            DataTable DtResultado = new DataTable("cliente");
            string selectSql;
            try
            {
                Connection.getConnection();
                if (!string.IsNullOrEmpty(pNome))
                {
                    selectSql = String.Format("SELECT * FROM cliente WHERE nome LIKE @pNome");
                    pNome = '%' + pNome + '%';
                }
                else
                {
                    selectSql = String.Format("SELECT * FROM cliente");
                }
                SqlCommand SqlCmd = new SqlCommand(selectSql, Connection.SqlCon);
                if (!string.IsNullOrEmpty(pNome))
                    SqlCmd.Parameters.AddWithValue("pNome", pNome);
                SqlDataAdapter SqlData = new SqlDataAdapter(SqlCmd);
                SqlData.Fill(DtResultado);
            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;
        }


    }
}
