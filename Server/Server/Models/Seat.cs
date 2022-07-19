namespace Server.Models
{
    internal class Seat
    {
        bool isAvailable;
        double price;

        public Seat()
        {
            isAvailable = true;
        }

        public Seat(double price)
        {
            isAvailable = true;
            this.price = price;
        }

        public Seat( Seat seat)
        {
            isAvailable = true;
            this.price = seat.price;
        }
    }
}
