namespace Pratice_App_for_Mum
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Security.Policy;
    using System.Text;
    using System.Threading.Tasks;

    internal class Mission
    {
        public int WorkersID { get; set; }

        public int ID { get; set; }

        public string EndDateM { get; set; } = string.Empty;

        public string StartDateM { get; set; } = string.Empty;

        public string Client { get; set; } = string.Empty;
    }
}
