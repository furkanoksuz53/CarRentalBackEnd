using Core.Entities;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Entities.Concrete
{
    public class CreditCard : IEntity
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public long CardNumber { get; set; }

        public int ExpiringYear { get; set; }

        public int ExpiringMonth { get; set; }

        public int CVC { get; set; }

    }
}