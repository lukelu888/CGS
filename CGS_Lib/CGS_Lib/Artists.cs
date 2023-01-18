using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGS_Lib
{
    class Artists : CollectionBase
    {
        public void Add(Artist artist)
        {
            List.Add(artist);
        }
        public Artist this[int index]
        {
            get { return (Artist)List[index]; }
            set { List[index] = value; }
        }

    }

/*
    class Artists : CollectionBase, IEnumerable<Artist>
    {
        public void Add(Artist artist)
        {
            List.Add(artist);
        }
        public Artist this[int index]
        {
            get { return (Artist)List[index]; }
            set { List[index] = value; }
        }


        public IEnumerator<Artist> GetEnumerator()
        {
            return ((IEnumerable<Artist>)List).GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return List.GetEnumerator();
        }
    }*/
}
