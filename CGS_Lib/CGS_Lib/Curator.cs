using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGS_Lib
{
    class Curator : Person
    {
        string curatorID;
        double commission;
        const double commRate = 0.10; //const is private
                                       // const normally all upper case  , but can violate convension
        public Curator(string firstName, string lastName, string curatorID): base(firstName, lastName)
        {
            commission = 0;
            this.curatorID = curatorID;
           
            
        }

        // prop double tab is setting properties
        public string CuratorID {
            get { return this.curatorID; }
            set { curatorID = value; } 
        }
       // public string CuratorID {get;set;}

        public double Commission
        {
            get { return this.commission; }
            set { this.commission = value; }
        }
        public override string toString()
        //public string toString()  // still works and hide base toString(), but not professional 
        {
            //string str = String.Format("{0,-15}{1}{2,-15}", this.curatorID, base.toString(), this.commission);
            //return this.curatorID+"\t\t"+base.toString() +"\t\t"+ this.commission;
            return $"{this.curatorID,-15}|{ base.toString(),-30}|{this.commission,-15}";
            
        }
        public string GetID()
        {
           // return this.curatorID;
            return CuratorID;
        }

        public void ClearCommand()
        {
            Console.Clear();
        }
        public void SetComm(double comm)
        {
            //this.commision += price * commRate;
            Commission += comm; // both work but this better using property
        }
        public int MyProperty { get; set; } // prop tab tab
    }
}

