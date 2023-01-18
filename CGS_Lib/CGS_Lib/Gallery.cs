using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;
using static CGS_Lib.Constants;
using System.Windows.Forms;

namespace CGS_Lib { 

    public class Gallery
    {
        public Gallery() { }
        Curators myCurators = new Curators();
        Artists myArtists = new Artists();
        ArtPieces myArtPieces = new ArtPieces();
        string curatorsFilePath = DIRPATH + "curators.txt";
        string artistsFilePath = DIRPATH + "artists.txt";
        string artPiecesFilePath = DIRPATH + "artPieces.txt";



        #region Curators
        //curator
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
                        Console.WriteLine($"{"CuratorID",-15}{"FirstName",-15}{"LastName",-15}{"Commission",-15}\n");
                        Console.WriteLine(curator.toString());


                    }
                }

            }

        }
        public string AddCurator(string curatorID, string firstName, string lastName)
        {
            string message;
            if (curatorID.Length != 5)
            {
                message = "Error. The curatorID should be 5 characters.";
            }
            else
            {

                if (CuratorIDVerifier(curatorID))
                {
                    message = "Error! This ID already existes";
                }
                else
                {

                    if (firstName.Length + lastName.Length > 40)
                    {
                        message = "Error! Names should be less than 40 characters.";
                    }
                    else
                    {
                        Curator curator = new Curator(firstName, lastName, curatorID);
                        myCurators.add(curator);
                        message = "Success! The curator added to the gallery\n" + "This is the info you added:\n" + $"{"CuratorID",-15}{"FirstName",-15}{"LastName",-15}{"Commission",-15}\n" + curator.toString();

                    }
                }

            }

            return message;
        }
        public void ListCurators()
        {
            Console.WriteLine("All info of curators:");
            Console.WriteLine($"{"CuratorID",-15}{"FirstName",-15}{"LastName",-15}{"Commission",-15}");
            foreach (Curator curator in myCurators)
            {
                Console.WriteLine(curator.toString());
            }
            Console.WriteLine();
        }
        public string getAllCuratorsInfo()
        {
            string info = $"All info of curators:\n" + $"{"CuratorID",-15}{"FirstName",-15}{"LastName",-15}{"Commission",-15}\n";
            foreach (Curator cur in myCurators)
            {
                info += cur.toString() + "\n";
                //info += cur.toString();
                //info+=Environment.NewLine;
            }
            return info;

        }
        public string SaveCuratorsIntoFile()
        {

            if (myCurators.Count != 0)
            {
                string info = $"All info of curators:\n" + $"{"CuratorID",-15}{"FirstName",-15}{"LastName",-15}{"Commission",-15}\n";
                foreach (Curator cur in myCurators)
                {
                    info += cur.toString() + "\n";
                }
                try
                {
                    /*this not working, because each time header will be overwrite
                     * 
                     * if (!File.Exists(curatorsFilePath))
                    {
                        // Create header to file.
                        string header = $"All info of curators:\n" + $"{"CuratorID",-15}{"FirstName",-15}{"LastName",-15}{"Commission",-15}\n";
                        File.WriteAllText(curatorsFilePath, header);
                    }*/



                    using (StreamWriter sw = new StreamWriter(curatorsFilePath))
                    //using (StreamWriter sw = new StreamWriter(@"..\.\.\..\curators.txt"))
                    //using (StreamWriter sw = new StreamWriter(@".\txtFile\curators.txt"))
                    {
                        sw.WriteLine(info);
                    }


                    // this will replace above stream reader block
                    File.WriteAllText(curatorsFilePath, info);
                }
                catch (IOException ex)
                {

                    return ex.Message;
                }
                return $"Success!All curators are saved to the file @{curatorsFilePath}";
            }
            else
            {
                return "Curators are empty! nothing to save!";
            }



        }
        public string appendCuratorInFile(string curatorID)
        {

            foreach (Curator cur in myCurators)
            {
                if (cur.GetID() == curatorID)
                {
                    try
                    {
                        if (!File.Exists(curatorsFilePath))
                        {
                            // Create a file to write to.
                            string header = $"All info of curators:\n" + $"{"CuratorID",-15}{"FirstName",-15}{"LastName",-15}{"Commission",-15}\n";
                            File.WriteAllText(curatorsFilePath, header);
                        }
                        //File.AppendAllLines(curatorsFilePath, cur.toString());//worng , not work with string argument, must be IEnumerable<string>
                        File.AppendAllText(curatorsFilePath, cur.toString());
                        return $"Curator with id {curatorID} is succssfully appended to file @ {curatorsFilePath}";

                        //using (StreamWriter sw = new StreamWriter(curatorsFilePath, true))
                        //{
                        //    sw.WriteLine(cur.toString());
                        //    return $"Curator with id {curatorID} is succssfully appended to file @ {curatorsFilePath}";
                        //}
                    }
                    catch (Exception ex)
                    {

                        return ex.Message;
                    }
                }
            }

            return $"the curator with ID {curatorID} not exist!";
        }

        public string updateCuratorInFile(string curatorID, string firstName, string lastName)
        {
            foreach (Curator cur in myCurators)
            {
                if (cur.GetID() == curatorID)
                {
                    //MessageBox.Show("inside foreach find curator");
                    string[] lines = File.ReadAllLines(curatorsFilePath);
                    //MessageBox.Show("before find line " + string.Concat(lines));
                    for (int i = 0; i < lines.Length; i++)
                    {
                        string[] parts = lines[i].Replace(" ", String.Empty).Split('|');
                        //MessageBox.Show("inside for parts=" + string.Join("", parts));
                        if (parts[0] == curatorID)
                        {
                            //MessageBox.Show("find that line :" + lines[i]);
                            parts[1] = firstName;
                            parts[2] = lastName;
                            string newline = $"{parts[0],-15}|{parts[1],-15}|{parts[2],-15}|{cur.Commission,-15}";
                            lines[i] = newline;
                            //MessageBox.Show("find that line and change it:" + lines[i]);
                            break;
                        }
                    }
                    //MessageBox.Show("before write :" + String.Concat(lines));
                    File.WriteAllLines(curatorsFilePath, lines);

                    return $"Success! the info of curatorId {curatorID} is updated!";
                }
            }
            return $"the curator with ID {curatorID} not exist!";
        }

        public string updateCuratorInFileV2(string curatorID, string firstName, string lastName)
        {
            string tempFile = Path.GetTempFileName();
            foreach (Curator cur in myCurators)
            {
                if (cur.GetID() == curatorID)
                {
                    using (StreamWriter sw = new StreamWriter(tempFile))
                    using (StreamReader sr = new StreamReader(curatorsFilePath))
                    {
                        string line;
                        string[] arr;
                        //while (sr.Peek()!=-1)
                        //{
                        //    line = sr.ReadLine();
                        //    arr = line.Replace(" ","").Split('|');

                        //    if (arr[0]==curatorID)
                        //    {
                        //        arr[1] = firstName;
                        //        arr[2] = lastName;

                        //        line = $"{arr[0],-15}|{arr[1],-15}|{arr[2],-15}|{cur.Commission,-15}";
                        //    }
                        //    sw.WriteLine(line);
                        //}

                        while ((line = sr.ReadLine()) != null)
                        {

                            arr = line.Replace(" ", "").Split('|');

                            if (arr[0] == curatorID)
                            {
                                arr[1] = firstName;
                                arr[2] = lastName;

                                line = $"{arr[0],-15}|{arr[1],-15}|{arr[2],-15}|{cur.Commission,-15}";
                            }
                            sw.WriteLine(line);
                        }

                    }
                    File.Delete(curatorsFilePath);
                    File.Move(tempFile, curatorsFilePath);

                    return $"Success! the info of curatorId {curatorID} is updated!";
                }
            }
            return $"the curator with ID {curatorID} not exist!";


            /*   string tempFile = Path.GetTempFileName();

               using (var sr = new StreamReader("file.txt"))
               using (var sw = new StreamWriter(tempFile))
               {
                   string line;

                   while ((line = sr.ReadLine()) != null)
                   {
                       if (line != "removeme")
                           sw.WriteLine(line);
                   }
               }

               File.Delete("file.txt");
               File.Move(tempFile, "file.txt");*/


        }


        #endregion


        #region Artist

        //artist method
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
                        Artist artist = new Artist(artistID, firstName, lastName);
                        myArtists.Add(artist);
                        Console.WriteLine("Success! The artist added to the gallery");
                        Console.WriteLine("This is the info you added:");
                        Console.WriteLine($"{"ArtistID",-15}{"FirstName",-15}{"LastName",-15}");
                        Console.WriteLine(artist.toString());
                    }
                }
            }


        }
        public string AddArtist(string artistID, string firstName, string lastName)
        {
            string message;
            if (artistID.Length != 5)
                message = "error!artistID must have 5 chars!";
            else
            {
                if (ArtistIDVerifier(artistID))
                    message = "Error!This ID already existes";
                else
                {

                    if (firstName.Length + lastName.Length > 40)
                        message = "Error! Names should be less than 40 characters.";
                    else
                    {
                        Artist artist = new Artist(artistID, firstName, lastName);
                        myArtists.Add(artist);
                        message = "Success! The artist added to the gallery\n" + "This is the info you added:\n" + $"{"ArtistID",-15}{"FirstName",-15}{"LastName",-15}\n" + artist.toString();
                    }
                }
            }
            return message;
        }
        public void ListArtists()
        {
            Console.WriteLine("All info of Artists:");
            Console.WriteLine($"{"ArtistID",-15}{"FirstName",-15}{"LastName",-15}");
            foreach (Artist artist in myArtists)
            {
                Console.WriteLine(artist.toString());
            }
            Console.WriteLine();
        }
        public string getAllArtistsInfo()
        {
            string info = "All info of artists:\n" + $"{"ArtistID",-15}{"FirstName",-15}{"LastName",-15}\n";
            foreach (Artist artist in myArtists)
            {
                info += artist.toString() + "\n";
            }
            return info;
        }

        public string SaveArtistsIntoFile()
        {
            string info = $"All info of Artists:\n" + $"{"ArtistID",-15}{"FirstName",-15}{"LastName",-15}\n";
            foreach (Artist artist in myArtists)
            {
                info += artist.toString() + "\n";
            }
            try
            {
                using (StreamWriter sw = new StreamWriter(artistsFilePath))
                {
                    sw.WriteLine(info);
                }
            }
            catch (IOException ex)
            {

                return ex.Message.ToString();
            }

            return $"Success!All artists are saved to the file @{artistsFilePath}";

        }
        #endregion











        //art piece method
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
            /*
                if (myArtPieces.Select(p => p.PieceID).ToList().Contains(artPieceID))
                    Console.WriteLine("Error!This ID already existes");
            */
                if (PieceIDVerifier(artPieceID))
                    Console.WriteLine("Error!This ID already existes");
                else
                {
                    Console.WriteLine("Enter the ArtistID:");
                    string artistID = Console.ReadLine();

                    Console.WriteLine("Enter the CuratorID:");
                    string curatorID = Console.ReadLine();
                    if (ArtistIDVerifier(artistID) == false || CuratorIDVerifier(curatorID) == false)
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
                                    Console.WriteLine($"{"ArtPieceID",-15}{"ArtistID",-15}{"CuratorID",-15}{"Title",-15}{"Year",-15}{"Estimate",-15}{"Value",-15}{"Status",-15}");
                                    Console.WriteLine(artPiece.toString());
                                }
                            }
                        }
                    }
                }
            }
        }

        public string AddArtPiece(string artPieceID, string artistID, string curatorID, string title, string year, string value, char status)
        {
            string message;
            if (artPieceID.Length != 5)
                message = "error!artPieceID must have 5 chars!";
            else
            {
                if (PieceIDVerifier(artPieceID))
                    message = "Error!This ID already existes";
                else
                {

                    if (ArtistIDVerifier(artistID) == false || CuratorIDVerifier(curatorID) == false)
                    {
                        message = "Error! artistID or curatorID must exist before!";

                    }

                    else
                    {

                        if (title.Length > 40)
                            message = "Error!Title less than 40 chars!";
                        else
                        {

                            if (year.Length != 4)
                                message = "Error! year is 4 digit!";
                            else
                            {
                                int year_num = int.Parse(year);
                                double value_num = Double.Parse(value);

                                ArtPiece artPiece = new ArtPiece(artPieceID, artistID, curatorID, title, year_num, value_num, status);

                                myArtPieces.Add(artPiece);
                                message = "Success in adding artpiece!\n" +
                                            "This is the info you added:\n" +
                                            $"{"ArtPieceID",-15}{"ArtistID",-15}{"CuratorID",-15}{"Title",-15}{"Year",-15}{"Estimate",-15}{"Value",-15}{"Status",-15}\n" +
                                            artPiece.toString();


                            }


                        }
                    }

                }
            }
            return message;
        }

        /* sellArtPiece() Prof way
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


        //cannot instantiate  an private class inside a public class, cannot access to private class because public class means share, cannot access private class. 
        private ArtPiece GetArtPiece(string artPieceID)//return type must be more accessible than method access modifier
        {
            foreach (ArtPiece artPiece in myArtPieces)
            {
                if (artPiece.GetID() == artPieceID)
                    return artPiece;
            }
            return null;
        }
        private Curator GetCurator(string curatorID) // return an class object 
        {
            foreach (Curator curator in myCurators)
            {
                if (curator.GetID() == curatorID)
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
                        Console.WriteLine($"{"ArtPieceID",-15}{"ArtistID",-15}{"CuratorID",-15}{"Title",-15}{"Year",-15}{"Estimate",-15}{"Value",-15}{"Status",-15}");
                        Console.WriteLine(artPiece.toString());

                        return true;
                    }

                }
            }

        }
        public string SellArtPiece(string artPieceID, string estimate_str)
        {
            string successOrErrorMessage = "";
            ArtPiece artPiece = GetArtPiece(artPieceID);

            if (PieceIDVerifier(artPieceID) == false || Char.ToUpper(artPiece.Status) == 'S')
            {
                successOrErrorMessage = "Error! that artpiece not exist! or art piece Status is sold!";

            }
            else
            {

                double estimate = double.Parse(estimate_str);
                if (artPiece.Value > estimate)
                {
                    successOrErrorMessage = "error! estimate less than value cannot sell!";

                }
                else
                {
                    if (MessageBox.Show("Do you wnat to contigue again?","confirm",MessageBoxButtons.YesNo,MessageBoxIcon.Question/*,MessageBoxDefaultButton.Button1*//*,MessageBoxOptions.ServiceNotification*/)==DialogResult.Yes)
                    {
                        MessageBox.Show("message box work in lib!");
                    }




                    artPiece.ChangeStatus('S');
                    artPiece.PricePaid(estimate);
                    double commission = artPiece.CalculateComm(estimate);

                    //foreach (Curator cur in myCurators)
                    //{
                    //    if (cur.CuratorID == artPiece.CuratorID)
                    //    {
                    //        cur.SetComm(commission);
                    //        Console.WriteLine("Congrat!you success sell the artPiece!");
                    //        return true;
                    //    }

                    //}
                    //Console.WriteLine("no curator find!");
                    //return false;


                    Curator curator = GetCurator(artPiece.CuratorID);
                    if (curator == null)
                    {
                        successOrErrorMessage = "Error! curator not exist!";

                    }
                    else
                    {
                        curator.SetComm(commission);
                        successOrErrorMessage = "Congrat!you success sell the artPiece!\n" +
                                "This is the info you changed:\n" +
                                $"{"ArtPieceID",-15}{"ArtistID",-15}{"CuratorID",-15}{"Title",-15}{"Year",-15}{"Estimate",-15}{"Value",-15}{"Status",-15}\n" +
                                artPiece.toString();


                    }

                }
            }
            return successOrErrorMessage;
        }

       /* public List<object> SellArtPiece(string artPieceID, string estimate_str)
        {
            List<object> result = new List<object>();
            bool successTransaction = false;
            string successOrErrorMessage;
            string artPieceInfo = "";
            ArtPiece artPiece = GetArtPiece(artPieceID);

            if (PieceIDVerifier(artPieceID) == false || Char.ToUpper(artPiece.Status) == 'S')
            {
                successOrErrorMessage = "Error! that artpiece not exist! or art piece Status is sold!";

            }
            else
            {

                double estimate = double.Parse(estimate_str);
                if (artPiece.Value > estimate)
                {
                    successOrErrorMessage = "error! estimate less than value cannot sell!";

                }
                else
                {
                    artPiece.ChangeStatus('S');
                    artPiece.PricePaid(estimate);
                    double commission = artPiece.CalculateComm(estimate);

                    //foreach (Curator cur in myCurators)
                    //{
                    //    if (cur.CuratorID == artPiece.CuratorID)
                    //    {
                    //        cur.SetComm(commission);
                    //        Console.WriteLine("Congrat!you success sell the artPiece!");
                    //        return true;
                    //    }

                    //}
                    //Console.WriteLine("no curator find!");
                    //return false;


                    Curator curator = GetCurator(artPiece.CuratorID);
                    if (curator == null)
                    {
                        successOrErrorMessage = "Error! curator not exist!";

                    }
                    else
                    {
                        successTransaction = true;
                        curator.SetComm(commission);
                        successOrErrorMessage = "Congrat!you success sell the artPiece!\n" +
                                "This is the info you changed:\n" +
                                $"{"ArtPieceID",-15}{"ArtistID",-15}{"CuratorID",-15}{"Title",-15}{"Year",-15}{"Estimate",-15}{"Value",-15}{"Status",-15}\n" +
                                artPiece.toString();
                        artPieceInfo = artPiece.toString();


                    }

                }
            }
            result.Add(successTransaction);
            result.Add(successOrErrorMessage);
            result.Add(artPieceInfo);
            return result;
        }*/
        public List<object> findArtPiece(string artPieceID,string estimate_str)
        {
            List<object> result = new List<object>();
            bool ans=false;
            string message;
            ArtPiece artPiece = GetArtPiece(artPieceID);
            double estimate;
            if (!Double.TryParse(estimate_str,out estimate))
            {
                message = "estimate must be a decimal number!";
            }
            else
            {
                if (artPiece != null && estimate >= artPiece.Value)
                {
                    message = artPiece.toString();
                    ans = true;
                }
                else
                {
                    message = $"that artPiece with id {artPieceID} dont exist or estimate {estimate} less than value!\n";
                }
            }

            
           
            result.Add(ans);
            result.Add(message);
            return result;
        }

        public void ListArtpieces()

        {
            Console.WriteLine("All info of ArtPieces:");
            Console.WriteLine($"{"ArtPieceID",-15}{"ArtistID",-15}{"CuratorID",-15}{"Title",-15}{"Year",-15}{"Estimate",-15}{"Value",-15}{"Status",-15}");
            foreach (ArtPiece artPiece in myArtPieces)
            {
                Console.WriteLine(artPiece.toString());
            }
            Console.WriteLine();
        }
        public string getAllArtPiecesInfo()
        {
            string info = "All info of Art Pieces:\n" + $"{"ArtPieceID",-15}{"ArtistID",-15}{"CuratorID",-15}{"Title",-15}{"Year",-15}{"Estimate",-15}{"Value",-15}{"Status",-15}\n";
            foreach (ArtPiece artPiece in myArtPieces)
            {
                info += artPiece.toString() + "\n";
            }
            return info;
        }

        public string SaveArtPiecesIntoFile()
        {
            string info = "All info of artPieces:\n" + $"{"ArtPieceID",-15}{"ArtistID",-15}{"CuratorID",-15}{"Title",-15}{"Year",-15}{"Estimate",-15}{"Value",-15}{"Status",-15}\n";
            foreach (ArtPiece ap in myArtPieces)
            {
                info += ap.toString() + "\n";
            }
            try
            {
                using (StreamWriter sw = new StreamWriter(artPiecesFilePath))
                {
                    sw.WriteLine(info);
                }
            }
            catch (IOException ex)
            {

                return ex.Message;
            }
            return $"Success!Art Pieces infos are updated @ {artPiecesFilePath}";
        }





        /*      AddCurator with input validation

            Curators curator    s = new Curators();
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

            }*/








    }
}
