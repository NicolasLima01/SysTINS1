using Mysqlx.Prepare;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysTINSClass
{
    public class Categoria
    {
        //Propriedades/atributos
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Sigla { get; set; }

        //Métodos Construtores
        public Categoria() { }
        public Categoria(int id, string? nome)
        {
            Id = id;
            Nome = nome;
        }
        public Categoria(int id, string? nome, string? sigla)
        {
            Id = id;
            Nome = nome;
            Sigla = sigla;
        }

        //Métodos

        /// <summary>
        /// Insere uma nova categoria 
        /// </summary>
        public void Inserir() 
        { 
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_categoria_insert";
            cmd.Parameters.AddWithValue("spid", Id);
            cmd.Parameters.AddWithValue("spnome", Nome);
            cmd.Parameters.AddWithValue("spsigla", Sigla);
            var dr = cmd.ExecuteReader();
        }
        /// <summary>
        /// Atualiza os valores do objeto de Categoria
        /// </summary>
        /// <returns></returns>
        public bool Atualizar() 
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_categoria_update";
            cmd.Parameters.AddWithValue("spid", Id);
            cmd.Parameters.AddWithValue("spnome", Nome);
            cmd.Parameters.AddWithValue("spsigla", Sigla);
            cmd.ExecuteNonQuery();
            return cmd.ExecuteNonQuery() > 0 ? true : false;  
        }
        /// <summary>
        /// Deleta um objeto de Categoria
        /// </summary>
        /// <param name="id">Id da Categoria</param>
        public void Excluir(int id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_categoria_delete";
            cmd.Parameters.AddWithValue ("spid", id);
            cmd.ExecuteNonQuery();
        }
        /// <summary>
        /// Faz uma consulta através do id da Categoria
        /// </summary>
        /// <param name="id">Id da Categoria</param>
        /// <returns></returns>
        public static Categoria ConsultarPorID(int id)
        {
            Categoria categoria = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = $"select * from categorias where id = {id}";
            var dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                categoria = new(dr.GetInt32(0), dr.GetString(1), dr.GetString(2));
            }
            return categoria;
        } 
        /// <summary>
        /// Apresenta uma lista contendo todas as categorias
        /// </summary>
        /// <returns></returns>
        public static List<Categoria> ObterLista()
        {
            List<Categoria> lista = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = "select * from categorias";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(new(dr.GetInt32(0), dr.GetString(1), dr.GetString(2)));
            }
            return lista;
        }
    }
}
