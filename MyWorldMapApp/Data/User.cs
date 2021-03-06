﻿using System.Collections.Generic;

namespace MyWorldMapApp.Web.Data
{ 
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public IList<TravelDestination> VisitedCountries {get;set;}
    }
}
