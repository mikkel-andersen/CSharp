namespace ParkingTicketMachine.Models
{
    public class ParkingTicketMachine
    {
        public int minutesPrKr;
        public int coinsToInsert;
        public int amountInserted;
        public DateTime timeNow;
        public DateTime PaidUntil { get; set; }

        public ParkingTicketMachine()
        {
            amountInserted = 0;
            timeNow = DateTime.Now;
        }

        public int MinutesPrKr => minutesPrKr;
        public int CoinsToInsert => coinsToInsert;
        public int AmountInserted => amountInserted;
        public DateTime TimeNow => timeNow;
        public string Info => $"Amount Inserted: {amountInserted} Kr";

        public void InsertCoin(int kr)
        {
            amountInserted += kr;
        }
    }
}