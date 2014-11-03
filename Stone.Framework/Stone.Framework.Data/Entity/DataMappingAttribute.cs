using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Stone.Framework.Data.Entity
{
    public class DataMappingAttribute : Attribute
    {
        private string columnname;
        private DbType dbtype;

        public DataMappingAttribute(string columnName, DbType dbType)
        {
            this.columnname = columnName;
            this.dbtype = dbType;
        }

        public string ColumnName
        {
            get { return columnname; }
        }

        public DbType DbType
        {
            get { return dbtype; }
        }
    }
}
