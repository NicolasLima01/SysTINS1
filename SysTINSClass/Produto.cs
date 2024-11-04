using Mysqlx.Prepare;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysTINSClass
{
    public class Produto
    {
        //Propriedades

        public int Id { get; set; }
        public int? Cod_barras { get; set; }
        public string? Descricao { get; set; }
        public double? Valor_unidade { get; set; }
        public double? Unidade_venda { get; set; }
        public Categoria Categoria { get; set; }
        public double? Estoque_minimo { get; set; }
        public double? Classe_desconto { get; set; }
        public DateTime Data_cadastro { get; set; }

        //Construtores

        public Produto() { }
        //Construtor com todos os não nulos e sem id
        public Produto(int? cod_barras, string? descricao, double? valor_unidade, 
                        double? unidade_venda, Categoria categoria, double? estoque_minimo, DateTime data_cadastro)
        {
            Cod_barras = cod_barras;
            Descricao = descricao;
            Valor_unidade = valor_unidade;
            Unidade_venda = unidade_venda;
            Categoria = categoria;
            Estoque_minimo = estoque_minimo;
            Data_cadastro = data_cadastro;
        }
        //construtor com todos nulos, não nulos e sem id
        public Produto(int? cod_barras, string? descricao, double? valor_unidade,
                        double? unidade_venda, Categoria categoria, double? estoque_minimo, double? classe_desconto, DateTime data_cadastro)
        {
            Cod_barras = cod_barras;
            Descricao = descricao;
            Valor_unidade = valor_unidade;
            Unidade_venda = unidade_venda;
            Categoria = categoria;
            Estoque_minimo = estoque_minimo;
            Classe_desconto = classe_desconto;
            Data_cadastro = data_cadastro;            
        }
        //construtor com todos nulos, não nulos e id
        public Produto(int id, int? cod_barras, string? descricao, double? valor_unidade,
                        double? unidade_venda, Categoria categoria, double? estoque_minimo, double? classe_desconto, DateTime data_cadastro)
        {
            Id = id;
            Cod_barras = cod_barras;
            Descricao = descricao;
            Valor_unidade = valor_unidade;
            Unidade_venda = unidade_venda;
            Categoria = categoria;
            Estoque_minimo = estoque_minimo;
            Classe_desconto = classe_desconto;
            Data_cadastro = data_cadastro;
        }

        //Métodos
        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "sp_produto_insert";
            cmd.Parameters.AddWithValue("spid", Id);
            cmd.Parameters.AddWithValue("sp_cod_barras", Cod_barras);
            cmd.Parameters.AddWithValue("spdescricao", Descricao);
            cmd.Parameters.AddWithValue("spvalor_unidade", Valor_unidade);
            cmd.Parameters.AddWithValue("spunidade_venda", Unidade_venda);
            cmd.Parameters.AddWithValue("spcategoria", Categoria);
            cmd.Parameters.AddWithValue("spestoque_minimo", Estoque_minimo);
            cmd.Parameters.AddWithValue("spclasse_desconto", Classe_desconto);
            cmd.Parameters.AddWithValue("spdata_cadastro", Data_cadastro);
            var dr = cmd.ExecuteReader();
        }

        public bool Atualizar()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "sp_produto_update";
            cmd.Parameters.AddWithValue("spid", Id);
            cmd.Parameters.AddWithValue("sp_cod_barras", Cod_barras);
            cmd.Parameters.AddWithValue("spdescricao", Descricao);
            cmd.Parameters.AddWithValue("spvalor_unidade", Valor_unidade);
            cmd.Parameters.AddWithValue("spunidade_venda", Unidade_venda);
            cmd.Parameters.AddWithValue("spcategoria", Categoria);
            cmd.Parameters.AddWithValue("spestoque_minimo", Estoque_minimo);
            cmd.Parameters.AddWithValue("spclasse_desconto", Classe_desconto);
            cmd.Parameters.AddWithValue("spdata_cadastro", Data_cadastro);
            cmd.ExecuteNonQuery();
            return cmd.ExecuteNonQuery() > 0 ? true : false;
        }

        public static Produto ConsultarPorID(int id)
        {
            Produto produto = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = $"select * from produtos where id = {id}";            
            var dr = cmd.ExecuteReader();
            if (dr.Read()) 
            {
                produto = new(dr.GetInt32(0), dr.GetInt32(1), dr.GetString(2), dr.GetDouble(3), dr.GetDouble(3),
                        Categoria.ConsultarPorId(dr.GetInt32(4)), dr.GetDouble(5), dr.GetDouble(6), dr.GetDateTime(7));
            }
            return produto;
        }
        public static List<Produto> ObterLista()
        { 
            List<Produto> lista = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = $"select * from produtos";
            var dr = cmd.ExecuteReader();
            while (dr.Read()) 
            {
                lista.Add(new(dr.GetInt32(0), dr.GetInt32(1), dr.GetString(2), dr.GetDouble(3), dr.GetDouble(3),
                        Categoria.ConsultarPorId(dr.GetInt32(4)), dr.GetDouble(5), dr.GetDouble(6), dr.GetDateTime(7)));
            }
            return lista;
        }








    }
}
