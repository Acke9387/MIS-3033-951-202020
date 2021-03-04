namespace Classes3
{
    public class Address
    {
        public int StreetNumber { get; set; }
        public string StreetName { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public int Zipcode { get; set; }


        public Address()
        {
            StreetNumber = 0;
            StreetName = string.Empty;
            State = string.Empty;
            City = string.Empty;
            Zipcode = 0;

        }
    }
}