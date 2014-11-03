using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stone.Framework.Data.Entity
{
    public class ReferencedEntityAttribute : Attribute
    {
        #region Property

        private Type e_type;
        public Type Type
        {
            get { return e_type; }
        }

        public string Prefix
        {
            get;
            set;
        }

        public string ConditionalProperty
        {
            get;
            set;
        }

        #endregion 

        public ReferencedEntityAttribute(Type type)
        {
            e_type = type;
        }
    }
}
