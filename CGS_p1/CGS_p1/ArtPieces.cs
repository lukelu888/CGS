using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGS_P1
{
    class ArtPieces : CollectionBase
    {
        public void Add(ArtPiece artPiece)
        {
            List.Add(artPiece);
        }



        public ArtPiece this[int index]
        {
            get { return (ArtPiece)List[index]; }
            set { List[index] = value; }
        }


    }

       /* class ArtPieces : CollectionBase, IEnumerable<ArtPiece> //IEnumerable only works for private List<ArtPiece>, if use List, this cannot iterate because this is infinite range
        {
            public void Add(ArtPiece artPiece)
            {
                List.Add(artPiece);
            }



            public ArtPiece this[int index]
            {
                get { return (ArtPiece)List[index]; }
                set { List[index] = value; }
            }

            public IEnumerator<ArtPiece> GetEnumerator()
            {
                return ((IEnumerable<ArtPiece>)List).GetEnumerator(); //IEnumerable only works for private List<ArtPiece>, if use List, this cannot iterate because this is infinite range
            }

            System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
            {
                return List.GetEnumerator();
            }


            *//*       private List<ArtPiece> artPieces = new List<ArtPiece>();


                   public void Add(ArtPiece artPiece)
                   {
                       this.artPieces.Add(artPiece);

                   }

                   public ArtPiece this[int index] // using indexer
                   {
                       get { return artPieces[index]; }
                       set { artPieces[index] = value; }
                   }
                   public IEnumerator<ArtPiece> GetEnumerator()
                   {
                       return ((IEnumerable<ArtPiece>)artPieces).GetEnumerator();
                   }

                   System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
                   {
                       return artPieces.GetEnumerator();
                   }*//*
        }*/
}
