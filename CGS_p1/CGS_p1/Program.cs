using System;
namespace CGS_P1
{
    public class CGS
    {
        public static void Main()
        {
            /*   Artist artist = new Artist("yinglin", "lu", "11111");
               Console.WriteLine(artist.toString());

               Curator curator = new Curator("yinglin", "lu", "11111");
               Console.WriteLine(curator.toString());*/


            /*         ArtPiece artPiece = new ArtPiece("pieceID", "curatorID", "artistID", "title", 2000, 50);
                     Console.WriteLine(artPiece.Value);
                     Console.WriteLine(artPiece.PieceID);
                     Console.WriteLine(artPiece.toString());*/
            /*
                        ArtPiece artPiece = new ArtPiece("pieceID", "curatorID", "artistID", "title", 2000, 50);
                        ArtPieces artPieces = new ArtPieces();
                        artPieces.Add(artPiece);
                        List<string> pieceIDList = new List<string>();
                        pieceIDList= artPieces.Select(p => p.GetID()).ToList();
                        Console.WriteLine(pieceIDList.Count);
                        foreach (string pieceID in pieceIDList)
                        {
                            Console.WriteLine(pieceID);
                        }
            */

            Gallery gallery = new Gallery();
           
            

            gallery.showSelectLinq();

            while (true)
            {
                Console.WriteLine("\tComputerized Gallery System\n" +
                                   "======================================\n" +
                                   "1.Add Curator.\n" +
                                   "2.Add Artist.\n" +
                                   "3.Add Art piece.\n" +
                                   "4.Sell Art piece.\n" +
                                   "5.Display All info.\n" +
                                   "6.Exit.\n" +
                                   "======================================\n");

                Console.WriteLine("Plz enter your choice(1-5):");
                int choice;
                while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 5)
                {
                    Console.WriteLine("wrong input! try input number 1-5!");
                }
                switch (choice)
                {
                    case 1:
                        gallery.AddCurator();

                        break;
                    case 2:
                        gallery.AddArtist();

                        break;
                    case 3:
                        gallery.AddArtPiece();

                        break;
                    case 4:
                        gallery.SellArtPiece();

                        break;
                    case 5:
                        gallery.ListCurators();
                        gallery.ListArtists();
                        gallery.ListArtpieces();
                        break;
                    case 6:
                        Environment.Exit(0);
                        break;

                }

            }


            /*
                        //test indexer
                        Curators myCurators = new Curators();
                        Curator curator1 = new Curator("yinglin", "lu", "11111");
                        Curator curator2 = new Curator("jabra", "jabra", "22222");
                        myCurators.add(curator1);
                        myCurators.add(curator2);
                        Console.WriteLine("how many curators inside myCurators:"+myCurators.Count);


                        foreach (Curator cur in myCurators)
                        {
                            Console.WriteLine(cur.toString());
                        }

                        for (int i = 0; i < myCurators.Count; i++)
                        {
                            if (myCurators[i].GetID()=="11111")
                            {
                                myCurators.RemoveAt(i) ;
                            }
                        }
                        Console.WriteLine("how many curators inside myCurators:" + myCurators.Count);
                        foreach (Curator cur in myCurators)
                        {
                            Console.WriteLine(cur.toString());
                        }
            */
            Console.ReadKey();

        }
    }
}
