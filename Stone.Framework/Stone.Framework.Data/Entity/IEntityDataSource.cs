using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stone.Framework.Data.Entity
{
    internal interface IEntityDataSource : IEnumerable<string>, IDisposable
    {
        Object this[string columnName]
        {
            get;
        }

        Object this[int iIndex]
        {
            get;
        }

        bool ContainsColumn(string columnName);

    }
}
