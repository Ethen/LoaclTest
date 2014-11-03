using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Stone.Framework.Data.Entity
{
    internal class DataRowEntitySource : IEntityDataSource
    {
        private class RowColumnNameEnumerator : IEnumerator<string>
        {
            private IEnumerator m_InternalEnumeator;

            public RowColumnNameEnumerator(DataRow dr)
            {
                m_InternalEnumeator = dr.Table.Columns.GetEnumerator();
            }

            public string Current
            {
                get
                {
                    DataColumn column = m_InternalEnumeator.Current as DataColumn;
                    return column.ColumnName;
                }
            }

            object System.Collections.IEnumerator.Current
            {
                get { return Current; }
            }

            public bool MoveNext()
            {
                return m_InternalEnumeator.MoveNext();
            }

            public void Reset()
            {
                m_InternalEnumeator.Reset();
            }

            public void Dispose()
            {
                return;
            }
        }


        private DataRow e_DataRow;

        public DataRowEntitySource(DataRow dr)
        {
            e_DataRow = dr;
        }

        public object this[string columnName]
        {
            get { return e_DataRow[columnName]; }
        }

        public object this[int iIndex]
        {
            get { return e_DataRow[iIndex]; }
        }

        public bool ContainsColumn(string columnName)
        {
            return e_DataRow.Table.Columns.Contains(columnName);
        }

        public IEnumerator<string> GetEnumerator()
        {
            return new RowColumnNameEnumerator(e_DataRow);
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<string>)this).GetEnumerator();
        }

        public void Dispose()
        {
            return;
        }
    }
}
