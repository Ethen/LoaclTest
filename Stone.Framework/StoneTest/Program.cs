using Stone.Framework.Data.DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace StoneTest
{
    class Program
    {
        private static DbCommand GetDbCommand(string commandText,string commandType)
        {
            DbCommand cmd = new SqlCommand();
            cmd.CommandText = commandText.Trim();
            cmd.CommandType = (CommandType)Enum.Parse(typeof(CommandType), commandType);
            // todo: populate cmd
            //if (this.parameters != null && parameters.param != null && parameters.param.Length > 0)
            //{
            //    foreach (dataOperationsDataCommandParametersParam param in this.parameters.param)
            //    {
            //        cmd.Parameters.Add(param.GetDbParameter());
            //    }
            //}
            return cmd;
        }

        static void Main(string[] args)
        {
            //DataCommand command = DataCommandManager.GetDataCommand("Contacts.QuerySearchList");

            string sql = "SELECT TOP 20  Orderid,Uid,Receivable FROM  dbo.Flt_Account_Detail WITH(NOLOCK)";
            string conn = "Data Source=flightdb.fat.qa.nt.ctripcorp.com,55666;Initial Catalog=FltOrderDB;Integrated Security=True";
            DataCommand command = new DataCommand(conn, GetDbCommand(sql, "Text"));
            var list=command.ExecuteEntityList<AccountDetail>();
            foreach (var item in list)
            {
                Console.WriteLine(item.Receivable);
            }
            Console.WriteLine(list.Count);
            Console.Read();
        }
    }
}
