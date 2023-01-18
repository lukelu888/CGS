using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGS_P1
{
    class Artist : Person
    {
        string artistID;
        public Artist(string firstName, string lastName, string artistID): base(firstName, lastName)
        {
            this.artistID = artistID;
        }
        public override string toString()
        {
            return this.artistID+"\t\t"+base.toString() ;
            // return this.firstName + " " + base.lastName + " with artistID " + artistID;
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
