using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace SysTINSClass
{
    public class Usuario
    {
        //Propriedades
        public int Id { get; set;}
        public string? Nome { get; set;}
        public string? Email { get; set;}
        public string? Senha { get; set; }
        public Nivel Nivel { get; set; }
        public bool Ativo { get; set; }

        //Construtores
        public Usuario() 
        {
            Nivel = new(); //Serve para criar um objeto de Nivel 
        }
        public Usuario(string name, string email, string senha, Nivel nivel)
        {
            Nome = name;
            Email = email;
            Senha = senha;
            Nivel = nivel;
        }
        public Usuario(string name, string email, string senha, Nivel nivel, bool ativo)
        {
            Nome = name;
            Email = email;
            Senha = senha;
            Nivel = nivel;
            Ativo = ativo;
        }

        public Usuario(int id, string name, string email, string senha, Nivel nivel, bool ativo)
        {
            Id = id;
            Nome = name;
            Email = email;
            Senha = senha;
            Nivel = nivel;
            Ativo = ativo;
        }

        //Métodos-Funções
        //Inserir
        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "sp_usuario_insert";
            cmd.Parameters.Add("spnome", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value=Nome;
            cmd.Parameters.AddWithValue("spemail", Email);
            cmd.Parameters.AddWithValue("spsenha", Senha);
            cmd.Parameters.AddWithValue("spnivel", Nivel.Id);
            var dr = cmd.ExecuteReader();
            if(dr.Read())
            {
                Id = dr.GetInt32(0);
            }
            cmd.Connection.Close();
        }
        //ObterPorId
        public static Usuario ObterPorID(int id)
        {
            Usuario usuario = new(); // Cria novo objeto usuario
            var cmd = Banco.Abrir(); 
            cmd.CommandText = $"select * from usuarios where id = {id}";
            var dr = cmd.ExecuteReader();
            if(dr.Read()) 
            {
                usuario = new(dr.GetInt32(0), dr.GetString(1), dr.GetString(2), dr.GetString(3), 
                            Nivel.ObterPorID(dr.GetInt32(4)), dr.GetBoolean(5));
            }
            return usuario;
        }
        //ObterLista
        public static List<Usuario> ObterLista()
        {
            List<Usuario> lista = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = $"select * from usuarios order by nome asc";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(new(dr.GetInt32(0), dr.GetString(1), dr.GetString(2), dr.GetString(3),
                            Nivel.ObterPorID(dr.GetInt32(4)), dr.GetBoolean(5)));
            }
            return lista;
        }
        //Atualizar
        public bool Atualizar()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "sp_usuario_altera";
            cmd.Parameters.AddWithValue("spid", Id);
            cmd.Parameters.AddWithValue("spnome", Nome);            
            cmd.Parameters.AddWithValue("spsenha", Senha);
            cmd.Parameters.AddWithValue("spnivel", Nivel.Id);
            cmd.ExecuteNonQuery();
            return cmd.ExecuteNonQuery() > 0 ? true : false;
            //object[,] param = { { "spid", Id } };
            //cmd.Parameters.AddRange(); Espera uma array
        }
        //efetuar login
        public static Usuario EfetuarLogin(string email, string senha)
        {
            Usuario usuario = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = $"select * from usuarios where email = '{email}' and senha = md5('{senha}') and ativo = 1";
            var dr = cmd.ExecuteReader();
            if (dr.Read()) 
            {
                usuario = new(
                            dr.GetInt32(0), dr.GetString(1),
                            dr.GetString(2), dr.GetString(3),
                            Nivel.ObterPorID(dr.GetInt32(4)),
                            dr.GetBoolean(5)
                            );
            }
            return usuario;
        }
    }
}
