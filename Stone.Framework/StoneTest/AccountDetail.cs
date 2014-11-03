using Stone.Framework.Data.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace StoneTest
{
    public class AccountDetail
    {
        [DataMapping("Orderid", DbType.Int32)]
        public int OrderId { get; set; }

        [DataMapping("Uid", DbType.String)]
        public string Uid { get; set; }


        [DataMapping("Receivable", DbType.Decimal)]
        public decimal Receivable { get; set; }
    }
}
