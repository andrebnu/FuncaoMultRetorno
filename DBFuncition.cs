﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncaoMultRetorno   
{
    public static class DBFunction
    {

        public static SqlConnection Connection { get; set; } = new SqlConnection(@"Data Source=MASTER-PC\SQLSERVER14;Integrated Security=True");
        /// <summary>
        /// this funnction select all elements selected in the table, the table already include .dbo
        /// </summary>
        /// <param name="table"></param>
        /// <param name="element"></param>
        /// <returns>List<string>  wh</returns>
        public static List<string> GenericUnitSelect(string element, string table)
        {
            List<string> returnElements = new List<string>();
            string select = $"SELECT {element} from dbo.{table}";

            SqlCommand cmd = new SqlCommand(select, Connection);
            Connection.Open();

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                returnElements.Add(dr[0].ToString());
            }
            dr.Close();
            Connection.Close();
            return returnElements;
        }
        public static List<string> GenericUnitSelect(string element, string table, string where)
        {
            List<string> returnElements = new List<string>();
            string select = $"SELECT {element} from dbo.{table} where {where}";
            // select PlacaDoVeiculo from dbo.Vaga  where IdVaga = 3;  

            SqlCommand cmd = new SqlCommand(select, Connection);
            Connection.Open();

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                returnElements.Add(dr[0].ToString());
            }
            dr.Close();
            Connection.Close();
            return returnElements;
        }
        public static void GenericExecute(string command)
        {
            SqlCommand cmd = new SqlCommand(command, Connection);
            Connection.Open();
            cmd.ExecuteNonQuery();
            Connection.Close();
        }

        /// <summary>
        /// Select all values from all elements  from given Table, alred have ddo. before table
        /// </summary>
        /// <param name="table"></param>
        /// <returns></returns>
        public static List<string[]> GenericSelectALL(string table)
        {
            List<string[]> lista = new List<string[]>();
            string select = $"SELECT * From dbo.{table}";
            SqlCommand cmd = new SqlCommand(select, Connection);
            Connection.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {

                string[] vetor = new string[dr.FieldCount];
                for (int i = 0; i < vetor.Length; i++)
                {
                    vetor[i] = dr[i].ToString();
                }
                lista.Add(vetor);
            }
            dr.Close();
            Connection.Close();
            return lista;

        }
    }
}
