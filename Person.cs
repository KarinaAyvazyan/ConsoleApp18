using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    public class Person:Manage
    {
        //math class ;string methods ,(builder); structure;DateTime ,Recordnery
        public string  FirstName{get;set;}
        public DateTime DOB { get; set; }

        public  override Person Copy()
        {
          //  return (Person)this.MemberwiseClone();
            return new Person
            {
                FirstName = this.FirstName,
                DOB = this.DOB
            };
        }
    }
}
