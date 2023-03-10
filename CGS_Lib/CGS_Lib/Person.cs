using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGS_Lib
{
    abstract class Person
    {
        string firstName;// default private not protected
        string lastName;
        //protected string lastName;

        public Person(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }


        /*   public abstract string DisplayName();
          */
       /* public static string toString()
        {
            return this.firstName + " " + lastName;// static cannot have nullable field because go to compiler first
        }*/
        public void Update(string _fn, string _ln)
        {
            this.firstName= _fn; // _ is for update
            this.lastName = _ln;
        }
        public virtual string toString()
        {
            //return this.firstName + "\t\t" + this.lastName;
            string str = $"{this.firstName,-15}|{this.lastName,-15}";
            return str;
        }
    }
}
