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
        /// Insere um novo endereco no banco de dados
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
        /// Atualiza as informações do endereco no banco de dados
        /// </summary>
        /// <returns></returns>
        public bool Atualizar()
        {
            bool resposta = false;
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_endereco_update";
            cmd.Parameters.AddWithValue("spid", Id);
            cmd.Parameters.AddWithValue("spcliente_id", Cliente);
            cmd.Parameters.AddWithValue("spcep", CEP);
            cmd.Parameters.AddWithValue("splogradouro", Logradouro);
            cmd.Parameters.AddWithValue("spnumero", Numero);
            cmd.Parameters.AddWithValue("spcomplemento", Complemento);
            cmd.Parameters.AddWithValue("spbairro", Bairro);
            cmd.Parameters.AddWithValue("spcidade", Cidade);
            cmd.Parameters.AddWithValue("spuf", UF);
            cmd.Parameters.AddWithValue("sptipo_endereco", Tipo_endereco);
            if (cmd.ExecuteNonQuery() > 0)
            {
                cmd.Connection.Close();
                resposta = true;
            }
            return resposta;
        }
        /// <summary>
        /// Exclui um endereço do banco de dados
        /// </summary>
        /// <param name="id">Id do cliente a ser deletado</param>
        public void Excluir(int id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_endereco_delete";
            cmd.Parameters.AddWithValue("spid", id);
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }
        /// <summary>
        /// Obtem uma lista contendo todos os enderecos do cliente
        /// </summary>
        /// <returns></returns>
        public static List<Endereco> ListarPorClienteID(int ClienteId)
        {
            List<Endereco>enderecos = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = $"select * from enderecos where cliente_id = {ClienteId}";
            var dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                enderecos.Add(new(dr.GetInt32(0), Cliente.ConsultarPorId(dr.GetInt32(1)), dr.GetString(2), dr.GetString(3), dr.GetString(4),
                        dr.GetString(5),dr.GetString(6), dr.GetString(7), dr.GetString(8), dr.GetString(9)));
            }
            return enderecos;
           
        }
    }
}
