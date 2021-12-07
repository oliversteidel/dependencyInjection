using DemoLibrary.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    // this demonstrates how to easily replace program logic (e.g. new feature, different database, mocking tests)
    // because of the disconnected structure using dependency injection
    // this class implements the IBusinessLogic-Interface
    // does the same like BusinessLogic.cs, but added some spaces between the console output to show a difference

    // to replace this, in ContainerConfig just RegisterType "BetterBusinessLogic" instead of "BusinessLogic"
    public class BetterBusinessLogic : IBusinessLogic
    {
        ILogger _logger;
        IDataAccess _dataAccess;

        public BetterBusinessLogic(ILogger logger, IDataAccess dataAccess)
        {
            _logger = logger;
            _dataAccess = dataAccess;
        }
        public void ProcessData()
        {


            _logger.Log("Starting the processing of data.");
            Console.WriteLine(); // this is different from "BetterBusinessLogig.cs
            Console.WriteLine("Processing the data");
            Console.WriteLine(); // this is different from "BetterBusinessLogig.cs
            _dataAccess.LoadData();
            _dataAccess.SaveData("ProcessedInfo");
            Console.WriteLine(); // this is different from "BetterBusinessLogig.cs
            _logger.Log("Finished processing of the data.");
        }
    }
}
