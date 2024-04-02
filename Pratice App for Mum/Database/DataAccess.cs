namespace Pratice_App_for_Mum.Database
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public static class DataAccess
    {
        private static readonly IRepository Repo;

        static DataAccess()
        {
            Repo = new Repository();
        }

        public static IRepository Repository => Repo;
    }
}
