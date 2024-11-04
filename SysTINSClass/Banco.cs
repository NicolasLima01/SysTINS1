using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysTINSClass
{
    //classe Banco é a nossa classe de conexão 
    public static class Banco //static pois não precisaremos criar uma instância de Banco para conectar às nossas bases
    {
        /// <summary>
        /// Método para abrir conexão
        /// </summary>
        /// <returns></returns>
        public static MySqlCommand Abrir() 
        {
            string strcon = @"Server=127.0.0.1;database=systinsdb01;user=root;password=";
            MySqlConnection cn = new(strcon);
            MySqlCommand cmd = new();
            try
            {
                cn.Open();
                cmd.Connection = cn;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }

            return cmd;
        }
    }
}