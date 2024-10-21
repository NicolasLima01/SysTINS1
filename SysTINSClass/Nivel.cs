using Org.BouncyCastle.Asn1.X509;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysTINSClass
{
    public class Nivel
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Sigla { get; set; }

        public Nivel() { } //Metodo construtor(new)

        public Nivel(int id, string? sigla)
        {
            Id = id;
            Sigla = sigla;
        }
        public Nivel(int id, string? nome, string? sigla)
        {
            Id = id;
            Nome = nome;
            Sigla = sigla;
        }

        //Inserir
        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = $"insert niveis (nome, sigla) values ('{Nome}','{Sigla}')";
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }
        //Consultar por id
        public static Nivel ObterPorID(int id)
        {
            Nivel nivel = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = $"select id, nome, sigla from niveis where id = {id}";
            var dr = cmd.ExecuteReader();
            if(dr.Read())
            {
                //nivel.Id = dr.GetInt32(0);
                //nivel.Nome = dr.GetString(1);
                //nivel.Sigla = dr.GetString(2);

                nivel = new(dr.GetInt32(0), dr.GetString(1), dr.GetString(2));
            }
            return nivel;
        }
        //Obter lista
        public static List<Nivel> ObterLista()
        {
            List<Nivel> lista = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "select * from niveis";
            var dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                lista.Add(new(dr.GetInt32(0), dr.GetString(1), dr.GetString(2)));
            }
            cmd.Connection.Close();
            return lista;
        }
        //Atualizar
        public bool Atualizar()
        {                       
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = $"update niveis set nome '{Nome}', sigla '{Sigla}' where id = {Id}";
            cmd.ExecuteNonQuery();
            return cmd.ExecuteNonQuery() > 0 ? true : false;            
        }
        //Deletar
        public void Excluir(int id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = $"delete from niveis where id = {id}";
            cmd.ExecuteNonQuery();
        }
    }
}
