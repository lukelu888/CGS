using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGS_Lib
{
    class Curators : CollectionBase
    {

        public void add(Curator cur)
        {
            List.Add(cur); // List is one unique object, the type inside list is object 
                           //  List.Add(1);    // 1 will cast back to Curator, string can cast back also
        }

        /* fact:  1. name of constructor is identical to name of class
                 2. this refer to current class
             conslusion : User this instead of the class name*/


        public Curator this[int index] // using indexer
        {
            get { return (Curator)List[index]; } // type casting: potentially casting , not conversion
            set { List[index] = value; }
        }

        public void remove(int index)
        {
            List.RemoveAt(index);
        }

        public void remove(Curator cur)
        {
            List.Remove(cur);
        }


    }
   /* class Curators :CollectionBase,IEnumerable<Curator>
    {

        public void add(Curator cur)
        {
            List.Add(cur); // List is one unique object, the type inside list is object 
         //  List.Add(1);    // 1 will cast back to Curator, string can cast back also
        }

       *//* fact:  1. name of constructor is identical to name of class
                2. this refer to current class
            conslusion : User this instead of the class name*//*


        public Curator this[int index] // using indexer
        {
            get { return (Curator)List[index]; } // type casting: potentially casting , not conversion
            set { List[index] = value; }
        }
        public IEnumerator<Curator> GetEnumerator()
        {
            return ((IEnumerable<Curator>)List).GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return List.GetEnumerator();
        }

        *//*       
                    //struct can only access to fields not methods(can bypass), so use List(indexer) not List<curator> struct 
                    private List<Curator> curators;

                    public void add(Curator cur)
                    {
                        curators.Add(cur); 

                    }

                    public Curator this[int index] // using indexer
                    {
                        get { return curators[index]; } 
                        set { curators[index] = value; }
                    }
             public IEnumerator<Curator> GetEnumerator()
             {
                 return ((IEnumerable<Curator>)curators).GetEnumerator();
             }

             System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
             {
                 return curators.GetEnumerator();
             }
            *//*


    }*/
}
