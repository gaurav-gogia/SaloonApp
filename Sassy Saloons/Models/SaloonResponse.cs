﻿using System.Collections.Generic;

namespace Sassy_Saloons.Models
{
    public class SearchResult
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PinCode { get; set; }
        public string SalonName { get; set; }
        public string Speciality { get; set; }
        public string ShortDesc { get; set; }
    }

    public class SaloonResponse
    {
        public List<SearchResult> SearchResults { get; set; }
    }
}