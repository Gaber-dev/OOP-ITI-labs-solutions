using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_6
{
    class Trainee : Person
    {
        public string NID { get; set; }
        public int IntakeNumber { get; set; }

        public override string ToString()
        {
            return $"{base.ToString()}, NID: {NID}, IntakeNumber: {IntakeNumber}";
        }

        public override Person Clone()
        {
            Person c = (Person)this.MemberwiseClone();

            // City , street , zipcode


            c.address = new Address();
            c.address.City = this.address.City;
            c.address.Street = this.address.Street;
            c.address.ZipCode = this.address.ZipCode;

            return c;
        }
    }
}
