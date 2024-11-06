using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SysTINSClass
{
    public class Endereco
    {     
        public int Id { get; set; }
        public Cliente Cliente { get; set; }
        public string? CEP { get; set; }
        public string? Logradouro { get; set; }
        public string? Numero { get; set; }
        public string? Complemento { get; set; }
        public string? Bairro { get; set; }
        public string? Cidade { get; set; }
        public string? UF { get; set; }
        public string? Tipo_endereco { get; set; }

        //Construtores
        public Endereco() { Cliente = new(); }
        public Endereco(Cliente cliente, string? cep, string? logradouro, string? numero, string? complemento,
                         string? bairro, string? cidade, string? uf, string? tipo_endereco)
        {
            Cliente = cliente;
            CEP = cep;
            Logradouro = logradouro;
            Numero = numero;
            Complemento = complemento;
            Bairro = bairro;
            Cidade = cidade;
            UF = uf;
            Tipo_endereco = tipo_endereco;
        }
        public Endereco(int id, Cliente cliente, string? cep, string? logradouro, string? numero, string? complemento,
                         string? bairro, string? cidade, string? uf, string? tipo_endereco)
        {
            Id = id;
            Cliente = cliente;
            CEP = cep;
            Logradouro = logradouro;
            Numero = numero;
            Complemento = complemento;
            Bairro = bairro;
            Cidade = cidade;
            UF = uf;
            Tipo_endereco = tipo_endereco;
        }

        //Métodos
        /// <summary>
        /// Insere um novo cliente
        /// </summary>
        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "sp_endereco_insert";
            cmd.Parameters.AddWithValue("spcliente_id", Cliente);
            cmd.Parameters.AddWithValue("spcep", CEP);
            cmd.Parameters.AddWithValue("splogradouro", Logradouro);
            cmd.Parameters.AddWithValue("spnumero", Numero);
            cmd.Parameters.AddWithValue("spcomplemento", Complemento);
            cmd.Parameters.AddWithValue("spbairro", Bairro);
            cmd.Parameters.AddWithValue("spcidade", Cidade);
            cmd.Parameters.AddWithValue("spuf", UF);
            cmd.Parameters.AddWithValue("sptipo_endereco", Tipo_endereco);
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
            cmd.CommandText = "sp_endereco_update";
            cmd.Parameters.AddWithValue("spid", Id);            
            if (cmd.ExecuteNonQuery() > 0)
            {
                cmd.Connection.Close();
                resposta = true;
            }
            return resposta;
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
        public static List<Cliente> ObterListaPorClienteID
            ()
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
