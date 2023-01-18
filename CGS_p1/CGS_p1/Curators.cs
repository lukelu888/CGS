using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace CGS_P1
{
    /*    class Curators : CollectionBase
        {

            //indexer is a way of making the array-like structure having setter and getter properties,
            // we dont use Properties directly because array is reference type, any change to the newly created array will afftect original one, we have to put the setters and getters with .Clone() as int[], which means we have to create a new object of it, that's a waste of memory
            // if use indexer, we just access to single value at that index, no need for the whole array, so wont affect original array,this is safer
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

           //indexer can ve overloaded, but array cannot
           //indexer can use string as key but array can only use int
            public Artist this[string index, int key]
            {
                get { return (Artist)List[key]; }
                set { List[key] = value; }

            }


        }*/

    class Curators : CollectionBase, IEnumerable<Curator>
    {

      /*  public void add(Curator cur)
        {
            List.Add(cur); // List is one unique object, the type inside list is object 
                           //  List.Add(1);    // 1 will cast back to Curator, string can cast back also
        }

        fact:  1. name of constructor is identical to name of class
                2. this refer to current class
            conslusion : User this instead of the class name


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
        }*/


        //struct can only access to fields not methods(can bypass), so use List(indexer) not List<curator> struct 
        private List<Curator> curators=new List<Curator>();

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



    }
}
