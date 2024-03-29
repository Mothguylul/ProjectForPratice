namespace Pratice_App_for_Mum.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Security.Policy;
    using System.Text;
    using System.Threading.Tasks;

    public class Assignment
    {
        public int WorkerId { get; set; }

        public int Id { get; set; }

        public string EndDate { get; set; } = string.Empty;

        public string StartDate { get; set; } = string.Empty;

        public bool Paused { get; set; } = false;

        public string Notes { get; set; } = string.Empty;
    }
}
