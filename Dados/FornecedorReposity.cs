using FluentValidation.Results;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    public class FornecedorRepository
    {

        public string Insert(Fornecedor fornecedor)
        {
            string resp = "";
            try
            {
                Connection.getConnection();

                SqlCommand SqlCmd = new SqlCommand
                {
                    Connection = Connection.SqlCon,
                    CommandText = "INSERT INTO Fornecedor (Nome, Email, TipoPessoa, Cpf_cnpj, Razao_social, Rua, Numero, Bairro, Cidade, Complemento, Cep, Telefone, Celular) " +
                    "VALUES (@pNome, @pEmail, @pTipoPessoa, @pCpf_cnpj, @pRazao_social, @pRua, @pNumero, @pBairro, @pCidade, @pComplemento, @pCep, @pTelefone, @pCelular) ",
                    CommandType = CommandType.Text
                };
                SqlCmd.Parameters.AddWithValue("@pNome", fornecedor.Nome);
                SqlCmd.Parameters.AddWithValue("@pEmail", fornecedor.Email);
                SqlCmd.Parameters.AddWithValue("@pTipoPessoa", fornecedor.tipoPessoa);
                SqlCmd.Parameters.AddWithValue("@pCpf_cnpj", fornecedor.Cpf_cnpj);
                SqlCmd.Parameters.AddWithValue("@pRazao_social", fornecedor.Razao_social);
                SqlCmd.Parameters.AddWithValue("@pRua", fornecedor.Rua);
                SqlCmd.Parameters.AddWithValue("@pNumero", fornecedor.Numero);
                SqlCmd.Parameters.AddWithValue("@pBairro", fornecedor.Bairro);
                SqlCmd.Parameters.AddWithValue("@pCidade", fornecedor.Cidade);
                SqlCmd.Parameters.AddWithValue("@pComplemento", fornecedor.Complemento);
                SqlCmd.Parameters.AddWithValue("@pCep", fornecedor.Cep);
                SqlCmd.Parameters.AddWithValue("@pTelefone", fornecedor.Telefone);
                SqlCmd.Parameters.AddWithValue("@pCelular", fornecedor.Celular);

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

        public string Update(Fornecedor fornecedor)
        {
            string resp = "";
            try
            {
                Connection.getConnection();

                string updateSql = String.Format("UPDATE Fornecedor SET " +
                                    "Nome = @pNome, Email = @pEmail, TipoPessoa = @pTipoPessoa, Cpf_cnpj = @pCpf_cnpj, Razao_social = @pRazao_social, Rua = @pRua, Numero = @pNumero, Bairro = @pBairro, Cidade = @pCidade, Complemento = @pComplemento, Cep = @pCep, Telefone = @pTelefone, Celular = @pCelular " +
                                    "WHERE Id = @pId ");
                SqlCommand SqlCmd = new SqlCommand(updateSql, Connection.SqlCon);
                SqlCmd.Parameters.AddWithValue("@pNome", fornecedor.Nome);
                SqlCmd.Parameters.AddWithValue("@pEmail", fornecedor.Email);
                SqlCmd.Parameters.AddWithValue("@pTipoPessoa", fornecedor.tipoPessoa);
                SqlCmd.Parameters.AddWithValue("@pCpf_cnpj", fornecedor.Cpf_cnpj);
                SqlCmd.Parameters.AddWithValue("@pRazao_social", fornecedor.Razao_social);
                SqlCmd.Parameters.AddWithValue("@pRua", fornecedor.Rua);
                SqlCmd.Parameters.AddWithValue("@pNumero", fornecedor.Numero);
                SqlCmd.Parameters.AddWithValue("@pBairro", fornecedor.Bairro);
                SqlCmd.Parameters.AddWithValue("@pCidade", fornecedor.Cidade);
                SqlCmd.Parameters.AddWithValue("@pComplemento", fornecedor.Complemento);
                SqlCmd.Parameters.AddWithValue("@pCep", fornecedor.Cep);
                SqlCmd.Parameters.AddWithValue("@pTelefone", fornecedor.Telefone);
                SqlCmd.Parameters.AddWithValue("@pCelular", fornecedor.Celular);
                SqlCmd.Parameters.AddWithValue("@pId", fornecedor.Id);

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

        public string Remove(int idFornecedor)
        {
            string resp = "";
            try
            {
                Connection.getConnection();

                string updateSql = String.Format("DELETE FROM Fornecedor " +
                                    "WHERE Id = @pId ");
                SqlCommand SqlCmd = new SqlCommand(updateSql, Connection.SqlCon);
                SqlCmd.Parameters.AddWithValue("pId", idFornecedor);

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
            DataTable DtResultado = new DataTable("Fornecedor");
            try
            {
                Connection.getConnection();
                String sqlSelect = "select * from Fornecedor";

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = Connection.SqlCon;
                SqlCmd.CommandText = sqlSelect;
                SqlCmd.CommandType = CommandType.Text;
                SqlDataAdapter SqlData = new SqlDataAdapter(SqlCmd);
                SqlData.Fill(DtResultado);
            }
            catch (Exception)
            {
                DtResultado = null;
            }
            return DtResultado;
        }

        public DataTable filterByName(string pNome)
        {
            DataTable DtResultado = new DataTable("Fornecedor");
            string selectSql;
            try
            {
                Connection.getConnection();
                if (!string.IsNullOrEmpty(pNome))
                {
                    selectSql = String.Format("SELECT * FROM Fornecedor WHERE Nome LIKE @pNome");
                    pNome = '%' + pNome + '%';
                }
                else
                {
                    selectSql = String.Format("SELECT * FROM Fornecedor");
                }
                SqlCommand SqlCmd = new SqlCommand(selectSql, Connection.SqlCon);
                if (!string.IsNullOrEmpty(pNome))
                    SqlCmd.Parameters.AddWithValue("pNome", pNome);
                SqlDataAdapter SqlData = new SqlDataAdapter(SqlCmd);
                SqlData.Fill(DtResultado);
            }
            catch (Exception)
            {
                DtResultado = null;
            }
            return DtResultado;
        }

        public DataTable filterByEmail(string email)
        {
            DataTable DtResultado = new DataTable("Fornecedor");
            string selectSql;
            try
            {
                Connection.getConnection();
                selectSql = "SELECT * FROM Fornecedor WHERE Email = @pEmail";
                SqlCommand SqlCmd = new SqlCommand(selectSql, Connection.SqlCon);
                SqlCmd.Parameters.AddWithValue("@pEmail", email);
                SqlDataAdapter SqlData = new SqlDataAdapter(SqlCmd);
                SqlData.Fill(DtResultado);
            }
            catch (Exception)
            {
                DtResultado = null;
            }
            finally
            {
                if (Connection.SqlCon.State == ConnectionState.Open)
                    Connection.SqlCon.Close();
            }
            return DtResultado;
        }
    }
}
