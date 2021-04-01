using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteSenac.db
{
    static class FuncionarioDAO
    {

        // Métodos de manipulação de dados: listar, cadastrar, apagar...
        public static DataTable listar()
        {
            // Instanciar o classe de conexão com o bd:
            Banco objBanco = new Banco();
            // Criar a "tabela" que será preenchida com os dados do BD:
            DataTable tabela = new DataTable();
            // Conectar com o banco:
            objBanco.Conectar();
            // Criar um objeto do tipo SQLiteCommand:
            var cmd = objBanco.conexao.CreateCommand();
            // Qual comando SQL será executado:
            cmd.CommandText = "SELECT * FROM Funcionarios";
            // Executar e obter os dados da consulta em um obj SQLiteDA:
            MySqlDataAdapter da = new MySqlDataAdapter(cmd.CommandText, objBanco.conexao);
            // Preencher uma "tabela" com os dados retornados do BD:
            da.Fill(tabela);
            // Desconectar:
            objBanco.Desconectar();
            // Devolver a tabela preenchida para quem chamar este método:
            return tabela;
        }
        public static bool cadastrar(Funcionario func)
        {
            // Instanciar e conectar ao banco:
            Banco banco = new Banco();
            try
            {
                banco.Conectar();
                // Criar o objeto SQLiteCommand:
                var cmd = banco.conexao.CreateCommand();
                // Definir qual comando DML (Insert - Delete - Update) será executado:
                cmd.CommandText = "INSERT INTO Funcionarios (Nome, Setor, Email, Telefone, Funcao) values (@nome, @setor, @email, @telefone, @funcao)";
                // Definir a substituição dos parametros:
                cmd.Parameters.AddWithValue("@nome", func.Nome);
                cmd.Parameters.AddWithValue("@setor", func.Setor);
                cmd.Parameters.AddWithValue("@email", func.Email);
                cmd.Parameters.AddWithValue("@telefone", func.Telefone);
                cmd.Parameters.AddWithValue("@funcao", func.Funcao);
                // Executar:
                cmd.ExecuteNonQuery();
                // Desconectar
                banco.Desconectar();
                // Se chegou até aqui é pq deu certo!
                // Retornar true:
                return true;
            }
            catch
            {
                // Desconectar
                banco.Desconectar();
                // Se chegou aqui é pq deu algum erro!
                // Retornar false:
                return false;
            }
        }
        public static DataTable buscarUsuario(int id)
        {
            // Definir o objeto de "tabela" que será preenchido com a consulta:
            DataTable tabela = new DataTable();
            // Instanciar e conectar ao banco:
            Banco banco = new Banco();
            banco.Conectar();
            // Criar o objeto SQLiteCommand:
            var cmd = banco.conexao.CreateCommand();
            // Definir qual comando DQL será executado:
            cmd.CommandText = "SELECT * FROM Funcionarios WHERE id = " + id;
            // Executar e "atribuir" o resultado em um objeto SQLiteDA
            MySqlDataAdapter da = new MySqlDataAdapter(cmd.CommandText, banco.conexao);
            // Definir qual "tabela" será preenchida com o resultado da consulta:
            da.Fill(tabela);
            // Desconectar:
            banco.Desconectar();
            return tabela;
        }
        public static bool excluir(int id)
        {
            // comandos para manipulação:
            // Instanciar e conectar ao banco:
            Banco banco = new Banco();
            try
            {
                banco.Conectar();
                // Criar o objeto SQLiteCommand:
                var cmd = banco.conexao.CreateCommand();
                // Definir qual comando DML (Insert - Delete - Update) será executado:
                cmd.CommandText = "DELETE FROM Funcionarios WHERE id = @id";
                // Definir a substituição dos parametros:
                cmd.Parameters.AddWithValue("@id", id);
                // Executar:
                cmd.ExecuteNonQuery();
                // Desconectar
                banco.Desconectar();
                // Se chegou até aqui é pq deu certo!
                // Retornar true:
                return true;
            }
            catch
            {
                // Desconectar
                banco.Desconectar();
                // Se chegou aqui é pq deu algum erro!
                // Retornar false:
                return false;
            }
        }

        public static bool editar(Funcionario func, int id)
        {
            // comandos para manipulação:
            // Instanciar e conectar ao banco:
            Banco banco = new Banco();
            try
            {
                banco.Conectar();
                // Criar o objeto SQLiteCommand:
                var cmd = banco.conexao.CreateCommand();
                // Definir qual comando DML (Insert - Delete - Update) será executado:
                cmd.CommandText = "UPDATE Funcionarios SET Nome = @nome, Setor = @setor, Email = @email, Telefone = @telefone, Funcao = @funcao WHERE id = @id";
                // Definir a substituição dos parametros:
                cmd.Parameters.AddWithValue("@nome", func.Nome);
                cmd.Parameters.AddWithValue("@setor", func.Setor);
                cmd.Parameters.AddWithValue("@email", func.Email);
                cmd.Parameters.AddWithValue("@telefone", func.Telefone);
                cmd.Parameters.AddWithValue("@funcao", func.Funcao);
                cmd.Parameters.AddWithValue("@id", id);
                // Executar:
                cmd.ExecuteNonQuery();
                // Desconectar
                banco.Desconectar();
                // Se chegou até aqui é pq deu certo!
                // Retornar true:
                return true;
            }
            catch
            {
                // Desconectar
                banco.Desconectar();
                // Se chegou aqui é pq deu algum erro!
                // Retornar false:
                return false;
            }
        }
    }
}
