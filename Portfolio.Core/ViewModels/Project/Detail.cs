using System.Collections.Generic;

namespace Portfolio.Core.ViewModels.Project
{
    public class Detail
    {
        public Detail( string hero, string clientName, string year, string role)
        {
            Hero = hero;
            ClientName = clientName;
            Year = year;
            Role = role;
        }
        public string Hero { get; }
        public string ClientName { get; }
        public string Year { get; }
        public string Role { get; }
    }
}