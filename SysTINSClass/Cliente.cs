using Google.Protobuf;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysTINSClass
{
    public class Cliente
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? CPF { get; set; }
        public string? Telefone { get; set; }
        public string? Email { get; set; }
        public DateTime? Data_nasc {  get; set; }
        public DateTime? Data_cad {  get; set; }
        public bool? Ativo {  get; set; }
        //Um dos atributos terá como atributo uma lista de endereços
        public List<Endereco> Enderecos { get; set; }

        public Cliente() { Enderecos = new(); }
        
        public Cliente(string? nome, string? cpf, string? telefone, string? email, DateTime? data_nasc, DateTime? data_cad, bool? ativo, List<Endereco> enderecos)
        {
            Nome = nome;
            CPF = cpf;
            Telefone = telefone;
            Email = email;
            Data_nasc = data_nasc;
            Ativo = ativo;
            Enderecos = enderecos;
        }
        public Cliente(int id, string? nome, string? cpf, string? telefone, string? email, DateTime? data_nasc, DateTime? data_cad, bool? ativo)
        {
            Id = id;
            Nome = nome;
            CPF = cpf;
            Telefone = telefone;
            Email = email;
            Data_nasc = data_nasc;
            Data_cad = data_cad;
            Ativo = ativo;
        }
        public Cliente(int id, string? nome, string? cpf, string? telefone, string? email, DateTime? data_nasc, DateTime? data_cad, bool? ativo, List<Endereco> enderecos)
        {
            Id = id;
            Nome = nome;
            CPF = cpf;
            Telefone = telefone;
            Email = email;
            Data_nasc = data_nasc;
            Data_cad = data_cad;
            Ativo = ativo;
            Enderecos = enderecos;
        }

        //Métodos

        /// <summary>
        /// Insere um novo cliente
        /// </summary>
        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "sp_cliente_insert";
            cmd.Parameters.AddWithValue("spnome", Nome);
            cmd.Parameters.AddWithValue("spcpf", CPF);
            cmd.Parameters.AddWithValue("sptelefone", Telefone);
            cmd.Parameters.AddWithValue("spemail", Email);
            cmd.Parameters.AddWithValue("spdatanasc", Data_nasc);
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }
        /// <summary>
        /// Atualiza as infrormações do cliente
        /// </summary>
        /// <returns></returns>
        public bool Atualizar()
        {
            bool resposta = false;
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_cliente_update";
            cmd.Parameters.AddWithValue("spid", Id);
            cmd.Parameters.AddWithValue("spnome", Nome);
            cmd.Parameters.AddWithValue("spcpf", CPF);
            cmd.Parameters.AddWithValue("sptelefone", Telefone);
            cmd.Parameters.AddWithValue("spdatanasc", Data_nasc);
            if (cmd.ExecuteNonQuery() > 0)
            {
                cmd.Connection.Close();
                resposta = true;
            }
            return resposta;
        }
        public void Archivar()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_cliente_update";
             cmd.Parameters.AddWithValue("spid", Id);
        }
        /// <summary>
        /// Faz uma consulta ao cliente através do id
        /// </summary>
        /// <param name="id">Id do cliente</param>
        /// <returns></returns>
        public static Cliente ConsultarPorId(int id)
        {
            Cliente cliente = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = $"select * from clientes where id = {id}";
            var dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                cliente = new(dr.GetInt32(0), dr.GetString(1), dr.GetString(2), dr.GetString(3), dr.GetString(4),
                            dr.GetDateTime(5), dr.GetDateTime(6), dr.GetBoolean(7));
            }
            return cliente;
        }
        /// <summary>
        /// Obtem uma lista contendo todos os clientes
        /// </summary>
        /// <returns></returns>
        public static List<Cliente> ObterLista()
        {
            List<Cliente> clientes = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = $"select * from clientes orber by asc";
            var dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                clientes.Add(new(dr.GetInt32(0), dr.GetString(1), dr.GetString(2), dr.GetString(3), dr.GetString(4),
                            dr.GetDateTime(5), dr.GetDateTime(6), dr.GetBoolean(7)));
            }
            return clientes;
        }

    }
}
