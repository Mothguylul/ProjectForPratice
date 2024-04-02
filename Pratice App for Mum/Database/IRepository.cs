namespace Pratice_App_for_Mum.Database
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Pratice_App_for_Mum.Models;

    public interface IRepository
    {
        IEnumerable<Town> GetTowns();

        IEnumerable<Worker> GetWorkers();

        IEnumerable<Assignment> GetAssignments();

        bool CreateAssignment(Assignment assignment);

        bool DeleteAssignment(int workersId);

        bool CreateNewTown(string newTown);

        bool DeleteTown(int townId);
    }
}
