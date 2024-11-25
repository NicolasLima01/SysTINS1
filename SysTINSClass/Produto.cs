
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
        public string? Cod_barras { get; set; }
        public string? Descricao { get; set; }
        public double? Valor_unidade { get; set; }
        public string? Unidade_venda { get; set; }
        public Categoria Categoria { get; set; }
        public double? Estoque_minimo { get; set; }
        public double? Classe_desconto { get; set; }
        public DateTime Data_cadastro { get; set; }

        //Construtores

        public Produto() { Categoria = new(); }
        public Produto(string? cod_barras, string? descricao) // Usado para FrmPedidoNovo
        {
            Cod_barras = cod_barras;
            Descricao = descricao;
            Categoria = new();
        }
        
        //construtor com todos nulos, não nulos e sem id
        public Produto(string? cod_barras, string? descricao, double? valor_unidade,
                        string? unidade_venda, Categoria categoria, double? estoque_minimo, double? classe_desconto)
        {
            Cod_barras = cod_barras;
            Descricao = descricao;
            Valor_unidade = valor_unidade;
            Unidade_venda = unidade_venda;
            Categoria = categoria;
            Estoque_minimo = estoque_minimo;
            Classe_desconto = classe_desconto;        
        }
        //construtor para atualizar no form de produtos
        public Produto(int id, string? cod_barras, string? descricao, double? valor_unidade, string? unidade_venda,
                        Categoria categoria, double? estoque_minimo, double? classe_desconto)
        {
            Id = id;
            Cod_barras = cod_barras;
            Descricao = descricao;
            Valor_unidade = valor_unidade;
            Unidade_venda = unidade_venda;
            Categoria = categoria;
            Estoque_minimo = estoque_minimo;
            Classe_desconto = classe_desconto;
        }
        //construtor com todos nulos, não nulos e id
        public Produto(int id, string?cod_barras, string? descricao, double? valor_unidade, string? unidade_venda, 
                        Categoria categoria, double? estoque_minimo, double? classe_desconto, DateTime data_cadastro)
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

        /// <summary>
        /// Insere um novo produto
        /// </summary>
        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "sp_produto_insert";
            cmd.Parameters.AddWithValue("spcod_barras", Cod_barras);
            cmd.Parameters.AddWithValue("spdescricao", Descricao);
            cmd.Parameters.AddWithValue("spvalor_unit", Valor_unidade);
            cmd.Parameters.AddWithValue("spunidade_venda", Unidade_venda);
            cmd.Parameters.AddWithValue("spcategoria_id", Categoria.Id);
            cmd.Parameters.AddWithValue("spestoque_minimo", Estoque_minimo);
            cmd.Parameters.AddWithValue("spclasse_desconto", Classe_desconto);
            Id = Convert.ToInt32(cmd.ExecuteScalar());
            cmd.Connection.Close();
        }

        /// <summary>
        /// Atualiza os dados de um produto
        /// </summary>
        /// <returns></returns>
        public bool Atualizar()
        {
            bool resposta = false;
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "sp_produto_update";
            cmd.Parameters.AddWithValue("spid", Id);
            cmd.Parameters.AddWithValue("sp_cod_barras", Cod_barras);
            cmd.Parameters.AddWithValue("spdescricao", Descricao);
            cmd.Parameters.AddWithValue("spvalor_unidade", Valor_unidade);
            cmd.Parameters.AddWithValue("spunidade_venda", Unidade_venda);
            cmd.Parameters.AddWithValue("spcategoria_id", Categoria.Id);
            cmd.Parameters.AddWithValue("spestoque_minimo", Estoque_minimo);
            cmd.Parameters.AddWithValue("spclasse_desconto", Classe_desconto);
            cmd.ExecuteNonQuery();
            if (cmd.ExecuteNonQuery() > 0)
            {
                cmd.Connection.Close();
                resposta = true;
            }
            return resposta;
        }

        /// <summary>
        /// Faz a consulta de um produto através do ID
        /// </summary>
        /// <param name="id">Id do produto</param>
        /// <returns></returns>
        public static Produto ConsultarPorID(int id)
        {
            Produto produto = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = $"select * from produtos where id = {id}";            
            var dr = cmd.ExecuteReader();
            if (dr.Read()) 
            {
                produto = new(dr.GetInt32(0), dr.GetString(1), dr.GetString(2), dr.GetDouble(3), dr.GetString(4),
                        Categoria.ConsultarPorId(dr.GetInt32(5)), dr.GetDouble(6), dr.GetDouble(7), dr.GetDateTime(9));
            }
            return produto;
        }

        /// <summary>
        /// Obtem uma lista com todos os produtos
        /// </summary>
        /// <returns></returns>
        public static List<Produto> ObterLista()
        { 
            List<Produto> lista = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = $"select * from produtos order by descricao asc";
            var dr = cmd.ExecuteReader();
            while (dr.Read()) 
            {
                lista.Add(new(dr.GetInt32(0), dr.GetString(1), dr.GetString(2), dr.GetDouble(3), dr.GetString(4),
                        Categoria.ConsultarPorId(dr.GetInt32(5)), dr.GetDouble(6), dr.GetDouble(7), dr.GetDateTime(9)));
            }
            return lista;
        }
    }
}
