using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGS_Lib
{
    class Artist : Person
    {
        string artistID;
        public Artist(string artistID, string firstName, string lastName ): base(firstName, lastName)
        {
            this.artistID = artistID;
        }
        public override string toString()
        {
            return $"{this.artistID,-15}|{base.toString()}" ;
            //return this.artistID+"\t\t"+base.toString() ;
        }
        public string ArtistID
        {
            get { return artistID; }
            set { artistID = value; }
        }
        public string GetID()
        {
            return ArtistID;
        }
    }
}
