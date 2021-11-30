namespace TrackerLibrary.Models
{
    public class PrizeModel
    {
        public int Id { get; set; }
        public int PlaceNumber { get; set; }
        public string  PlaceName { get; set; }
        public decimal PrizeAmount { get; set; }
        public double PrizePercentage { get; set; }

        public PrizeModel()
        {
        }

        public PrizeModel(string name, string number, string amount, string percentage)
        {
            PlaceName = name;
            int.TryParse(number, out int placeNum);
            PlaceNumber = placeNum;

            decimal.TryParse(amount, out decimal prizeAmount);
            PrizeAmount = prizeAmount;

            double.TryParse(percentage, out double prizePercentage);
            PrizePercentage = prizePercentage;
        }
    }
}