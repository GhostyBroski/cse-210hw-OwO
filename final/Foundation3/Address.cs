

class Address
    {
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string StateProvince { get; set; }
        public string Country { get; set; }

        public Address(string streetAddress, string city, string stateProvince, string country)
        {
            StreetAddress = streetAddress;
            City = city;
            StateProvince = stateProvince;
            Country = country;
        }

        public bool IsInUSA()
        {
            return Country.ToLower() == "usa";
        }

        public string GetAddressLabel()
        {
            return $"{StreetAddress}, {City}, {StateProvince}, {Country}";
        }
    }