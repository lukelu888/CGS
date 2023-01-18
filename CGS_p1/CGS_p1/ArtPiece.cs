using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGS_P1
{
    internal class ArtPiece
    {
        string pieceID,curatorID, artistID,title;
        int year;
        double estimate, value;
        char status;
        int testNum;

        public ArtPiece(string pieceID, string artistID, string curatorID, string title,int year,  double value)
        {
            this.pieceID = pieceID;
            this.artistID = artistID;
            this.curatorID = curatorID;
            this.title = title;
            this.year = year;
            this.value = value;

            this.estimate = 0;
            this.status = 'D';
        }

        public string PieceID
        {
            get { return this.pieceID; }
            set { this.pieceID = value; }
        }
        //public string PieceID { get; set; }    //   shorthand will be blocked by Main() and also only be fully accessed by inheritance class, Main() is not inheritance, cannot access to shorthand
     
        
        public string CuratorID
        {
            get { return this.curatorID; }
            set { this.curatorID = value; }
        }
      
        
        public string Title
        {
            get { return this.title; }
            set { this.title = value; }
        }
        public int Year
        {
            get { return this.year; }
            set { this.year = value; }
        }
     
        public double Estimate {
            get { return this.estimate; }
            set { this.estimate = value; }
        }
           
        // dont need getters and setters for artistID and curatorID, because we dont get it here
        public char Status {
            get { return this.status; }
            set { this.status = value; }
        }
        /*public double Value {
            get { return value; }
            set { value = value; } // if use shorthand then will because this , and cause error, so when the prop name is Value, we cannot use shorthand
        }*/
        public double Value
        {
            get { return value; }
            set { this.value = value; } 
        }

        public int TestNum { get => testNum; set => testNum = value; }



        /*        public double Value
                {
                    private get { return value; }
                    set { this.value = value; }
                }*/

        /*public double Value
        {
            get { return value; }
        }//use only get is ok
*/
        /*      public double Value
              {
                  set { this.value = value; }
              }// use only set 
      */
        public string GetID()
        {
            return PieceID;
        }
        public string toString()
        {
            return PieceID + "\t\t"+ this.artistID + "\t\t" + this.curatorID + "\t\t"+ Title + "\t\t" + Year +  "\t\t" + Estimate + "\t\t" +Value+ "\t\t"+ Status;
        }
        public void ChangeStatus(char status)
        {
            Status = Char.ToUpper(status);
        }
        public double PricePaid(double estimate)
        {
            Estimate = estimate;
            return Estimate;   
        }
        public double CalculateComm(double estimate)
        {
            
            double difference = /* PricePaid(estimate)*/estimate - Value;
           
            return difference * 0.25;
          
        }
        public double CalculateComm()
        {

            double difference = Estimate - Value;
          
            return difference * 0.25;
        
        }
    }
}
