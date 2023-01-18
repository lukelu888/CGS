using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CGS_P1
{
     public class Gallery
    {
        public Gallery() { }
        /*  Curators curators = new Curators();
            public void AddCurator()
            {

                // we dont do input validation here, here is just for display error
                string curatorID = "";
                Console.WriteLine("enter the curatorID:");
                List<string> curatorsIDList = new List<string>();
                curatorsIDList = curators.Select(p => p.CuratorID).ToList();
                for (int i = 0; i < curators.Count; i++)
                {
                    curatorsIDList.Add(curators[i].GetID());
                    //  curatorsList.Add(curators[i].CuratorID);
                }
                foreach (Curator cur in curators)
                {
                    curatorsIDList.Add(cur.GetID());
                }
                curatorID = Console.ReadLine();
                while (curatorID.Length != 5 || curatorsIDList.Contains(curatorID))
                {
                    Console.WriteLine("Invalid curator ID, try agaagin");
                    curatorID = Console.ReadLine();
                }

                Console.WriteLine("Enter the first name:");
                string firstName = Console.ReadLine();
                Console.WriteLine("Enter the last name:");
                string lastName = Console.ReadLine();
                while (firstName.Length + lastName.Length > 40)
                {
                    Console.WriteLine("first name less than 40 chars!try again");
                    Console.WriteLine("Enter the first name:");
                    firstName = Console.ReadLine();
                    Console.WriteLine("Enter the last name:");
                    lastName = Console.ReadLine();
                }

                Curator curator = new Curator(firstName, lastName, curatorID);

                curators.add(curator);
                Console.WriteLine("Success adding curator!");

            }
        */



        Curators myCurators = new Curators();

        public void showSelectLinq()
        {
            Curator c1 = new Curator("yinglin", "lu", "11111");
            Curator c2 = new Curator("jab", "lu", "21111");
            Curator c3 = new Curator("perter", "lu", "41111");
            Console.WriteLine(c1);

            //this dont work only if Curator only have properties, no field
            //myCurators.add(new Curator() { CuratorID = "12345", FirstName = "luke", LastName = "lu", Commission = 0 });
            Console.ReadLine();
            myCurators.add(c1);
            Console.WriteLine(c2);
            myCurators.add(c2);
            myCurators.add(c3);

            
            

            List<string> items = myCurators.Select(p=>(p.CuratorID +"-"+p.FirstName+" "+p.LastName )).ToList();
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
        }
        public bool CuratorIDVerifier(string curatorID)
        {
            bool flag = false;
            foreach (Curator cur in myCurators)
            {
                if (cur.GetID() == curatorID)
                    flag = true;
            }
            return flag;
        }
        public void AddCurator()
        {
            Console.WriteLine("Please ther curatorID:");
            string curatorID = Console.ReadLine();
            if (curatorID.Length != 5)
            {
                Console.WriteLine("Error. The curatorID should be 5 characters.");
            }
            else
            {
                
                if (CuratorIDVerifier(curatorID))
                {
                    Console.WriteLine("Error! This ID already existes");
                }
                else
                {
                    Console.WriteLine("Please enter the first name: ");
                    string firstname = Console.ReadLine();
                    Console.WriteLine("Please enter the last name: ");
                    string lastname = Console.ReadLine();
                    if (firstname.Length + lastname.Length > 40)
                    {
                        Console.WriteLine("Error! Names should be less than 40 characters.");
                    }
                    else
                    {
                        Curator curator = new Curator(firstname, lastname, curatorID);
                        myCurators.add(curator);
                        Console.WriteLine("Success! The curator added to the gallery");
                        Console.WriteLine("This is the info you added:");
                        Console.WriteLine("CuratorID\tFirstName\tLastName\tCommission");
                        Console.WriteLine(curator.toString() );


                    }
                }

            }

        }


        Artists myArtists = new Artists();
        public bool ArtistIDVerifier(string artistID)
        {
            foreach (Artist art in myArtists)
            {
                if (art.ArtistID == artistID)
                    return true;
            }
            return false;
        }
        public void AddArtist()
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
                        Artist artist = new Artist(firstName, lastName, artistID);
                        myArtists.Add(artist);
                        Console.WriteLine("Success! The artist added to the gallery");
                        Console.WriteLine("This is the info you added:");
                        Console.WriteLine("ArtistID\tFirstName\tLastName");
                        Console.WriteLine(artist.toString()); 
                    }
                }
            }
        }

        ArtPieces myArtPieces = new ArtPieces();

        public bool PieceIDVerifier(string pieceID)
        {
            foreach (ArtPiece piece in myArtPieces)
            {
                if (piece.PieceID == pieceID)
                    return true;
            }
            return false;
        }
        public void AddArtPiece()
        {
            Console.WriteLine("enter the art piece ID:");
            string artPieceID = Console.ReadLine();
            if (artPieceID.Length != 5)
                Console.WriteLine("error!artPieceID must have 5 chars!");
            else
            {
                //if (myArtPieces.Select(p => p.PieceID).ToList().Contains(artPieceID))
                //    Console.WriteLine("Error!This ID already existes");
                if (PieceIDVerifier(artPieceID))
                    Console.WriteLine("Error!This ID already existes");
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
                                if (status != 'D' && status != 'O')
                                    Console.WriteLine("Error! status should be 'D' or 'O'. ");
                                else
                                {

                                    ArtPiece artPiece = new ArtPiece(artPieceID, artistID, curatorID, title, year, value);
                                    artPiece.ChangeStatus(status);
                                    myArtPieces.Add(artPiece);
                                    Console.WriteLine("Success in adding artpiece!");
                                    Console.WriteLine("This is the info you added:");
                                    Console.WriteLine("ArtPieceID\tArtistID\tCuratorID\tTitle\t\tYear\t\tEstimate\tValue\t\tStatus");
                                    Console.WriteLine(artPiece.toString()); 
                                }

                            }


                        }
                    }        
                    
                }
            }
        }

        //inconsistent accessibility
        //cannot instantiate  a private class inside a public class, cannot access to private class , because public class means share, cannot access private class. 
        private ArtPiece GetArtPiece(string artPieceID)//return type must be more accessible than method access modifier
        {
            foreach(ArtPiece artPiece in myArtPieces)
            {
                if(artPiece.GetID()==artPieceID)
                    return artPiece;
            }
            return null;
        }
        private Curator GetCurator(string curatorID) // return an class object 
        {
            foreach(Curator curator in myCurators)
            {
                if(curator.GetID()==curatorID)
                    return curator;
            }
            return null;
        }
        public bool SellArtPiece()
        {
            Console.WriteLine("pls enter your artpiece ID:");
            string artPieceID = Console.ReadLine();
            ArtPiece artPiece = GetArtPiece(artPieceID);

            if (PieceIDVerifier(artPieceID) == false || Char.ToUpper(artPiece.Status) == 'S')
            {
                Console.WriteLine("Error! that artpiece not exist! or art piece Status is sold!");
                return false;
            }
            else
            {
                Console.WriteLine("enter the estimale:");
                double estimate = double.Parse(Console.ReadLine());
                if (artPiece.Value > estimate)
                {
                    Console.WriteLine("error! estimate less than value cannot sell!");
                    return false;
                }
                else
                {
                    artPiece.ChangeStatus('S');
                    artPiece.PricePaid(estimate);
                    double commission = artPiece.CalculateComm(estimate);

               /*     foreach (Curator cur in myCurators)
                    {
                        if (cur.CuratorID == artPiece.CuratorID)
                        {
                            cur.SetComm(commission);
                            Console.WriteLine("Congrat!you success sell the artPiece!");
                            return true;
                        }
    
                    }
                    Console.WriteLine("no curator find!");
                    return false;
*/

                    Curator curator = GetCurator(artPiece.CuratorID);
                    if (curator == null)
                    {
                        Console.WriteLine("Error! curator not exist!");
                        return false;
                    }
                    else
                    {
                        curator.SetComm(commission);
                        Console.WriteLine("Congrat!you success sell the artPiece!");
                        Console.WriteLine("This is the info you changed:");
                        Console.WriteLine("ArtPieceID\tArtistID\tCuratorID\tTitle\t\tYear\t\tEstimate\tValue\t\tStatus");
                        Console.WriteLine(artPiece.toString()); 

                        return true;
                    }

                }
            }

        } 
/*
        public bool CheckArtPieceIDAndStatus(string artpID)
        {
            foreach(ArtPiece art in myArtPieces)
            {
                if (art.GetID() == artpID)
                    if (art.Status != 'S')
                        return true;

            }
            return false;
        }
        public double getValue(string artpieceID)
        {
            double value = 0;
            foreach(ArtPiece art in myArtPieces)
            {
                if (art.GetID() == artpieceID)
                    value= art.Value;
            }
            return value;
        }
        public void ChangeStatus(string artpieceID)
        {
            foreach(ArtPiece piece in myArtPieces)
            {
                if(piece.GetID() == artpieceID)
                {
                    piece.ChangeStatus('S');
                }
            }
        }
        public string GetCuratorIDFromArtPiece(string artPieceID)
        {
            string curatorID = "";
            foreach (ArtPiece piece in myArtPieces)
            {
                if (piece.GetID() == artPieceID)
                {
                    curatorID = piece.CuratorID;
                }
            }
            return curatorID;
        }

        public void setCommission(string curatorID, double value, double estimate)
        {
            double commission = 0.0;
            commission = (estimate - value) * 0.1;
            foreach (Curator cur in myCurators)
            {
                if(cur.GetID() == curatorID)
                {
                    cur.SetComm(commission);
                }
            }
        }
        public void SellArtPieces()
        {
            Console.WriteLine("pls enter artpieceID:");
            string artPieceID = Console.ReadLine();
            if(CheckArtPieceIDAndStatus(artPieceID)==false)
                Console.WriteLine("Error!either artpieceId or status not correct!");
            else
            {
                Console.WriteLine("pls enter the estimate:");
                double estimate = Convert.ToDouble(Console.ReadLine());
                double value = getValue(artPieceID);
                if(estimate < value)
                    Console.WriteLine("Error! estimate less than value cannot sell");
                else
                {
                    ChangeStatus(artPieceID);
                    string curatorID = GetCuratorIDFromArtPiece(artPieceID);
                    setCommission(curatorID, value, estimate);
                }
            }
        }
*/

        public void ListArtists()
        {
            Console.WriteLine("All info of Artists:");
            Console.WriteLine("ArtistID\tFirstName\tLastName");
            foreach (Artist artist in myArtists)
            {
                Console.WriteLine(artist.toString());
            }
            Console.WriteLine();
        }

        public void ListCurators()
        {
            Console.WriteLine("All info of curators:");
            Console.WriteLine("CuratorID\tFirstName\tLastName\tCommission");
            foreach (Curator curator in myCurators)
            {
                Console.WriteLine(curator.toString());
            }
            Console.WriteLine();
        }

        public void ListArtpieces()

        {
            Console.WriteLine("All info of ArtPieces:");
            Console.WriteLine("ArtPieceID\tArtistID\tCuratorID\tTitle\t\tYear\t\tEstimate\tValue\t\tStatus");
            foreach (ArtPiece artPiece in myArtPieces)
            {
                Console.WriteLine(artPiece.toString());
            }
            Console.WriteLine();
        }
    }
}
