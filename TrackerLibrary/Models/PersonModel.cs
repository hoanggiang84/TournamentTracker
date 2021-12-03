namespace TrackerLibrary.Models
{
    public class PersonModel
    {
        public string  FirstName { get; set; }
        public string  LastName { get; set; }
        public string  EmailAddress { get; set; }
        public string  CellphoneNumber { get; set; }
        public int Id { get; internal set; }

        public string FullName { get { return $"{FirstName} {LastName}"; } }
    }
}