using System.Collections.Generic;

namespace Portfolio.Core.ViewModels.Project
{
    public class Detail
    {
        public Detail(List<ProjectDetailsViewModel> details, string hero, string clientName, string year, string role)
        {
            Details = details;
            Hero = hero;
            ClientName = clientName;
            Year = year;
            Role = role;
        }
        public List<ProjectDetailsViewModel> Details { get; }
        public string Hero { get; }
        public string ClientName { get; }
        public string Year { get; }
        public string Role { get; }
    }
}