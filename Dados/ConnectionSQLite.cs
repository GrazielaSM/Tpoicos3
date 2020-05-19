using Entidade;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    public class ConnectionSQLite
    {

        // Declarar um atributo tipo SQLliteConnection
        
            private static SQLiteConnection sqliteConnection;

            private static SQLiteConnection DbConnection()
            {
                sqliteConnection = new SQLiteConnection (@"Data Source = c:\tmp\dbcliente.sqlite");
                sqliteConnection.Open();
                return sqliteConnection;
            }
            //Criação do arquivo SQL
            private static void createDataBaseSQLite(string databaseName)
        {
            try
            {
                if(!File.Exists(@"c:\temp\" + databaseName))
                SQLiteConnection.CreateFile(@"C:\temp\" + databaseName);
            }
            catch (Exception)
            {
                throw;
            }
        }
        //Criação da tabela SQL
        public static void CreateTableSQLite(string tableName)
        {
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "CREATE TABLE IF NOT EXISTE" + tableName + "( idLoja int, nome varchar(30), cnpj varchar(13)";
                    cmd.CommandText = "CREATE TABLE IF NOT EXISTE" + tableName + "( idProduto int, nomeProduto varchar(30), descricao varchar(30)";
                    cmd.CommandText = "CREATE TABLE IF NOT EXISTE" + tableName + "( idFornecedor int, nomeFornecedor varchar(30), cnpjFornecedor varchar(13),enderecoFornecedor varchar (80)";
                    cmd.CommandText = "CREATE TABLE IF NOT EXISTE" + tableName + "( idCliente int, nomeCliente varchar(30), endereco  varchar(30)";
                    cmd.CommandText = "CREATE TABLE IF NOT EXISTE" + tableName + "( notaFiscal int, data varchar(30), valorTotal int)";
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                throw;
            }

        }
        //Inclusão das infromações na tabela
        public static void Add(Loja loja)
        {

            using (var cmd = DbConnection().CreateCommand())
            {
                cmd.CommandText = "INSERT INTO Loja(idLoja, nomeLoja, cnpj) values( @IdLoja,@NomeLoja,@Cnpj)";
                cmd.Parameters.AddWithValue("@IdLoja", loja.IdLoja);
                cmd.Parameters.AddWithValue("@NomeLoja", loja.NomeLoja);
                cmd.Parameters.AddWithValue("@Cnpj", loja.Cnpj);
                cmd.ExecuteNonQuery();

            }

        }
        public static void Add2(Produto produto)
        {

            using (var cmd = DbConnection().CreateCommand())
            {
                cmd.CommandText = "INSERT INTO Produto(idProduto, nomeProduto, descricao) values( @IdProduto,@NomeProduto,@descricao)";
                cmd.Parameters.AddWithValue("@IdProduto", produto.IdProduto);
                cmd.Parameters.AddWithValue("@NomeProduto", produto.NomeProduto);
                cmd.Parameters.AddWithValue("@Descricao", produto.Descricao);
                cmd.ExecuteNonQuery();

            }

        }
        public static void Add3(Fornecedor fornecedor)
        {

            using (var cmd = DbConnection().CreateCommand())
            {
                cmd.CommandText = "INSERT INTO Loja(idFornecedor, nomeFornecedo, cnpjFornecedor,enderecoFornecedor) values( @IdFornecedor,@NomeFornecedor,@CnpjFornecedor,@EnderecoFornecedor)";
                cmd.Parameters.AddWithValue("@IdFornecedor", fornecedor.IdFornecedor);
                cmd.Parameters.AddWithValue("@NomeFornecedor", fornecedor.NomeFornecedor);
                cmd.Parameters.AddWithValue("@CnpjFornecedor", fornecedor.CnpjFornecedor);
                cmd.Parameters.AddWithValue("@EnderecoFornecedor", fornecedor.EnderecoFornecedor);
                cmd.ExecuteNonQuery();

            }

        }
        public static void Add4(Cliente cliente)
        {

            using (var cmd = DbConnection().CreateCommand())
            {
                cmd.CommandText = "INSERT INTO Loja(idCliente , nomeCliente, endereco) values( @IdCliente,@NomeCliente,@Endereco)";
                cmd.Parameters.AddWithValue("@IdCliente", cliente.IdCliente);
                cmd.Parameters.AddWithValue("@NomeCliente", cliente.NomeCliente);
                cmd.Parameters.AddWithValue("@Endereco", cliente.Endereco);
                cmd.ExecuteNonQuery();

            }

        }
        public static void Add5(Venda venda)
        {

            using (var cmd = DbConnection().CreateCommand())
            {
                cmd.CommandText = "INSERT INTO Loja( notaFiscal, data, valorTotal) values( @NotaFiscal,@Data,@ValorTotal)";
                cmd.Parameters.AddWithValue("@NotaFiscal", venda.NotaFiscal);
                cmd.Parameters.AddWithValue("@Data", venda.Data);
                cmd.Parameters.AddWithValue("@ValorTotal", venda.ValorTotal);
                cmd.ExecuteNonQuery();

            }

        }
        

        //Consultar dados da tabela
        public static DataTable GetAll()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            using (var cmd = DbConnection().CreateCommand())
            {
                cmd.CommandText = "Select idLoja, nomeLoja, cnpj from loja";
                cmd.CommandText = "Select idProduto, nomeProduto, descricao from produto";
                cmd.CommandText = "Select idFornecedor, nomeFornecedo, cnpjFornecedor,enderecoFornecedor from loja";
                cmd.CommandText = "Select idCliente , nomeCliente, endereco from cliente";
                cmd.CommandText = "Select notaFiscal, data, valorTotal from venda";
                da = new SQLiteDataAdapter(cmd.CommandText, DbConnection());
                da.Fill(dt);
                return dt;
            }
        }

    }
}
