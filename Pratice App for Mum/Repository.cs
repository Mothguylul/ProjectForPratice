namespace Pratice_App_for_Mum;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Repository : IRepository
{
    private List<Town> towns = new List<Town>
        {
           new Town() { TownID = 1, Name = "Town1" },
           new Town() { TownID = 2, Name = "Town2" },
           new Town() { TownID = 3, Name = "Town3" },
        };

    private List<Mission> missions = new List<Mission>();

    private List<Worker> workers = new List<Worker>
        {
          new Worker() { Id = 1, TownId = 1, Name = "John", Mobil = 01737400374, Email = "johnson89@gmail.com", BirthDate = "05.09.1985 (30 jahre)" },
          new Worker() { Id = 2, TownId = 2, Name = "Peter", Mobil = 7348939, Email = "peterparker89@gmail.com", BirthDate = "03.06.2000 (24 jahre)" },
          new Worker() { Id = 3, TownId = 3, Name = "Paul", Mobil = 02434374, Email = "paul89@gmail.com", BirthDate = "02.06.2010(14 Jahre)" },
          new Worker() { Id = 4, TownId = 1, Name = "Max", Mobil = 01737400374, Email = "max89@gmail.com", BirthDate = "05.09.1985 (30 jahre)" },
          new Worker() { Id = 5, TownId = 2, Name = "Paul", Mobil = 01737400374, Email = "paul89@gmail.com", BirthDate = "05.09.1985 (30 jahre)" },
          new Worker() { Id = 6, TownId = 3, Name = "Ina", Mobil = 01737400374, Email = "ina89@gmail.com", BirthDate = "05.09.1985 (30 jahre)" },
        };

    public IEnumerable<Mission> GetMissions()
    {
        return missions;
    }

    public IEnumerable<Town> GetTowns()
    {
        return towns;
    }

    public IEnumerable<Worker> GetWorkers()
    {
        return workers;
    }
}
