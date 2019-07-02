using System;

namespace CinameApp
{
    public class Hall
    {
        private static int ID;

        public readonly int uniqueId;
        public string Name { get; set; }
        public float Price { get; set; }

        private Seat[,] seats;

        public Hall(string name,float price,int rowCount,int positionCount)
        {
            ID++;
            uniqueId = ID;
            Name = name;
            Price = price;
            seats = new Seat[rowCount, positionCount];

            CreateSeats(rowCount, positionCount);
        }


        private void CreateSeats(int row, int pos)
        {
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < pos; j++)
                {
                    Seat seat = new Seat();
                    seat.Status = "empty";

                    seats[i, j] = seat;  
                }
            }
        }

        public void GetStatusPost(int row,int pos)
        {
            Console.WriteLine($"{seats[row,pos].Status}");
        }

        public void BuyTicket(int row, int pos,float money)
        {
            if(seats[row, pos].Status == "empty")
            {
                if (money>= Price)
                {
                    seats[row, pos].Status = "bought";
                    Console.WriteLine("Congratulations");
                    return;
                }
                Console.WriteLine("Money is not enough!");
                return;
            }
            Console.WriteLine("Position is not empty");
        }
    }
}