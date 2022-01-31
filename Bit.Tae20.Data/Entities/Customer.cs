using System;
using Bit.Tae20.Data.Enumerations;

namespace Bit.Tae20.Data.Entities
{
    public class Customer
    {
        #region Properties

        public int Id { get; set; }

        public string Name { get; set; }

        public int Zipcode { get; set; }

        public DateTime CreatedDate { get; set; }
        
        public string CreatedBy { get; set; }

        public DateTime? LastModifiedDate { get; set; }

        public string LastModifiedBy { get; set; }

        public RowStatus Status { get; set; }

        #endregion
    }
}
