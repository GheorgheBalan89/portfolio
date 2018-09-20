using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Core.Models
{
    public class NavigationItem
    {
        public string Url { get; set; }
        public string Label { get; set; }
        public bool IsPublished { get; set; }
        public bool IsHidden { get; set; }
        public List<NavigationItem> Children { get; set; }
    }
}
