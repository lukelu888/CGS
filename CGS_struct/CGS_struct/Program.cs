using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using static CGS_struct.Program;

namespace CGS_struct
{
    class Program
    {

        public static int Factorial(int n)
        {
            if (n > 1)
                return n * Factorial(n - 1);
            /* else
                 return 1;*/

            return 1;
        }
        static void Main(string[] args)
        {
            /*            Console.WriteLine(Factorial(0));
                        Console.WriteLine(Factorial(1));
                        Console.WriteLine(Factorial(2));
                        Console.WriteLine(Factorial(3));*/




            AddCurator();
            ListCurators();
            AddArtist();
            ListArtists();
            AddArtPiece();
            ListArtPieces();

            while (true)
            {
                SellArtPiece();
                ListArtPieces();
                ListCurators();

            }

        }

        public struct Curator // struct is always public 
        {
            public string curatorID; // var should also be public 
            public string firstName;
            public string lastName;
            public double commission;
        }

        public struct Artist
        {
            public string artistID;
            public string firstName;
            public string lastName;
        }
        public struct ArtPiece
        {

            public string pieceID, curatorID, artistID, title;
            public int year;
            public double estimate, value;
            public char status;

        }

        static int index_curators = 0;
        static Curator[] myCurators = new Curator[10];
        static int index_artists = 0;
        static Artist[] myArtists = new Artist[10];
        static int index_artPiece = 0;
        static ArtPiece[] myArtPieces = new ArtPiece[10];

        public int num;
        public static void ListCurators()
        {

            Console.WriteLine("The info for Curators:\n" +
                                "CuratorID\tFirstName\tLastName\tCommission");
            for (int i = 0; i < myCurators.Length; i++)
            {
                if (myCurators[i].curatorID != null)
                    Console.WriteLine(myCurators[i].curatorID + "\t\t" + myCurators[i].firstName + "\t\t" + myCurators[i].lastName + "\t\t" + myCurators[i].commission);
                else
                    break;
            }
        }

        public static void ListArtists()
        {

            Console.WriteLine("The info for Artists:\n" +
                                "ArtistID\tFirstName\tLastName");
            for (int i = 0; i < myArtists.Length; i++)
            {
                if (myArtists[i].artistID != null)
                    Console.WriteLine(myArtists[i].artistID + "\t\t" + myArtists[i].firstName + "\t\t" + myArtists[i].lastName);
                else
                    break;
            }
        }

        public static void ListArtPieces()
        {

            Console.WriteLine("The info for ArtPieces:\n" +
                                "ArtPieceID\tArtistID\tCuratorID\tTitle\t\tYear\t\tEstimate\tValue\t\tStatus");
            for (int i = 0; i < myArtPieces.Length; i++)
            {
                if (myArtPieces[i].pieceID != null)
                    Console.WriteLine(myArtPieces[i].pieceID + "\t\t" + myArtPieces[i].artistID + "\t\t" + myArtPieces[i].curatorID + "\t\t" + myArtPieces[i].title + "\t\t" + myArtPieces[i].year + "\t\t" + myArtPieces[i].estimate + "\t\t" + myArtPieces[i].value + "\t\t" + myArtPieces[i].status);
                else
                    break;
            }
        }
        public static bool CuratorIDVerifier(string curatorID)
        {
            for (int i = 0; i < myCurators.Length; i++)
            {
                if (myCurators[i].curatorID == curatorID)
                    return true;
            }

            return false;
        }
        public static void AddCurator()
        {
            Console.WriteLine("enter curatorID:");
            string curatorID = Console.ReadLine();
            if (curatorID.Length != 5 || CuratorIDVerifier(curatorID))
            {
                Console.WriteLine("invalid ID! curatorId must be 5 char and not exist in current list!");
            }
            else
            {
                Console.WriteLine("enter first name:");
                string firstName = Console.ReadLine();
                Console.WriteLine("enter last name:");
                string lastName = Console.ReadLine();
                if (firstName.Length + lastName.Length > 40)
                {
                    Console.WriteLine("first and last name must be less than 40");
                }
                else
                {
                    //struct constructor, increase size of array dynamically with CopyTo method
                    /*               Curator cur = new Curator();
                                   cur.curatorID=curatorID;
                                   cur.firstName=firstName;
                                   cur.lastName=lastName;
                                   cur.commission = 0;

                                   Curator[] newList=new Curator[myCurators.Length+1];
                                   myCurators.CopyTo(newList,0);
                                   newList[index_curators] = cur;
                                   myCurators = newList;
                                   index_curators++;*/




                    myCurators[index_curators].curatorID = curatorID;
                    myCurators[index_curators].firstName = firstName;
                    myCurators[index_curators].lastName = lastName;
                    myCurators[index_curators].commission = 0;
                    index_curators++;
                    Console.WriteLine("Success! curator added!");
                }
            }
        }




        public static bool ArtistIDVerifier(string artistID)
        {
            for (int i = 0; i < myArtists.Length; i++)
            {
                if (myArtists[i].artistID == artistID)
                    return true;
            }
            return false;
        }
        public static void AddArtist()
        {
            Console.WriteLine("enter the artistID:");
            string artistID = Console.ReadLine();
            if (artistID.Length != 5)
                Console.WriteLine("error!artistID must have 5 chars!");
            else
            {
                if (ArtistIDVerifier(artistID))
                    Console.WriteLine("Error!This ID already existes");
                else
                {
                    Console.WriteLine("enter first name:");
                    string firstName = Console.ReadLine();
                    Console.WriteLine("enter last name:");
                    string lastName = Console.ReadLine();
                    if (firstName.Length + lastName.Length > 40)
                        Console.WriteLine("Error! Names should be less than 40 characters.");
                    else
                    {
                        myArtists[index_artists].artistID = artistID;
                        myArtists[index_artists].firstName = firstName;
                        myArtists[index_artists].lastName = lastName;
                        index_artists++;

                        Console.WriteLine("Success! The artist added to the gallery");

                    }
                }
            }
        }


        public static bool PieceIDVerifier(string pieceID)
        {
            for (int i = 0; i < myArtPieces.Length; i++)
            {
                if (myArtPieces[i].pieceID == pieceID)
                    return true;
            }
            return false;
        }
        public static void AddArtPiece()
        {
            Console.WriteLine("enter the art piece ID:");
            string artPieceID = Console.ReadLine();
            if (artPieceID.Length != 5)
                Console.WriteLine("error!artPieceID must have 5 chars!");
            else
            {
                if (myArtPieces.Select(p => p.pieceID).ToList().Contains(artPieceID))
                    Console.WriteLine("Error!This ID already existes");
                /*    if (PieceIDVerifier(artPieceID))
                        Console.WriteLine("Error!This ID already existes");*/
                else
                {
                    Console.WriteLine("Enter the ArtistID:");
                    string artistID = Console.ReadLine();

                    Console.WriteLine("Enter the CuratorID:");
                    string curatorID = Console.ReadLine();
                    if (ArtistIDVerifier(artistID) == false && CuratorIDVerifier(curatorID) == false)
                    {
                        Console.WriteLine("Error! artistID or curatorID must exist before!");

                    }

                    else
                    {
                        Console.WriteLine("Enter the title:");
                        string title = Console.ReadLine();
                        if (title.Length > 40)
                            Console.WriteLine("Error!Title less than 40 chars!");
                        else
                        {
                            Console.WriteLine("Enter the year:");
                            string yearInput = Console.ReadLine();
                            if (yearInput.Length != 4)
                                Console.WriteLine("Error! year is 4 digit!");
                            else
                            {
                                int year = int.Parse(yearInput);
                                Console.WriteLine("Enter the value of art piece:");
                                double value = double.Parse(Console.ReadLine());
                                //double value = Convert.ToDouble(Console.ReadLine());

                                Console.WriteLine("Enter the status of art piece:");
                                char status = Char.ToUpper((char)Console.Read());

                                Console.ReadLine();// from console.read()  to console.readLine() need to clean the buffer
                                if (status != 'D' && status != 'O')
                                    Console.WriteLine("Error! status should be 'D' or 'O'. ");
                                else
                                {
                                    myArtPieces[index_artPiece].pieceID = artPieceID;
                                    myArtPieces[index_artPiece].artistID = artistID;
                                    myArtPieces[index_artPiece].curatorID = curatorID;
                                    myArtPieces[index_artPiece].title = title;
                                    myArtPieces[index_artPiece].year = year;
                                    myArtPieces[index_artPiece].value = value;
                                    myArtPieces[index_artPiece].status = status;
                                    index_artPiece++;
                                    Console.WriteLine("Success in adding artpiece!");


                                }

                            }


                        }
                    }

                }
            }
        }


        /*
                //struct is value type like int,not a reference type like class, so struct cannot be nullable, which make it impossible to return a struct for art piece
                public static ArtPiece GetArtPiece(string artPieceID)
                {
                    ArtPiece? artPiece=null;
                    for (int i = 0; i < myArtPieces.Length; i++)
                    {
                        if (myArtPieces[i].pieceID==artPieceID)
                        {
                            artPiece = myArtPieces[i];
                            break;
                        }
                    }
                    return artPiece; 
                }
        */
        public static bool CheckPieceIDAndStatus(string artPieceID)
        {
            for (int i = 0; i < myArtPieces.Length; i++)
            {
                if (myArtPieces[i].pieceID == artPieceID && myArtPieces[i].status != 'S')
                {
                    return true;
                }
            }
            return false;
        }
        public static void SellArtPiece()
        {
            Console.WriteLine("pls enter your artpiece ID:");
            string artPieceID = Console.ReadLine();
            if (!CheckPieceIDAndStatus(artPieceID))
            {
                Console.WriteLine("Error!either artpieceId or status not correct!");
            }
            else
            {
                Console.WriteLine("enter the estimate:");
                double estimate = Convert.ToDouble(Console.ReadLine());
                for (int i = 0; i < myArtPieces.Length; i++)
                {
                    if (myArtPieces[i].pieceID == artPieceID)
                    {
                        if (estimate < myArtPieces[i].value)
                        {
                            Console.WriteLine("Error! estimate less than value cannot sell!");
                        }
                        else
                        {
                            myArtPieces[i].estimate = estimate;
                            myArtPieces[i].status = 'S';
                            double commission = (estimate - myArtPieces[i].value) * 0.25;
                            for (int j = 0; j < myCurators.Length; j++)
                            {
                                if (myArtPieces[i].curatorID == myCurators[j].curatorID)
                                {
                                    myCurators[j].commission = commission;
                                    Console.WriteLine($"congrats! you successfully sell the artpiece with id {artPieceID}!");
                                    break;
                                }
                            }
                        }




                        break;
                    }
                }

            }


        }
    }
}
