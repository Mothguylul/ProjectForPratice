namespace Pratice_App_for_Mum
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public interface IRepository
    {
        IEnumerable<Town> GetTowns();

        IEnumerable<Worker> GetWorkers();

        IEnumerable<Mission> GetMissions();

        bool CreateNewTown(string newTown);

        bool DeleteTown(int townId);
    }
}
