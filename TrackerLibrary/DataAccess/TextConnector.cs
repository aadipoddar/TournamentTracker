using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TrackerLibrary.Models;
using TrackerLibrary.DataAccess.TextHelpers;

namespace TrackerLibrary.DataAccess
{
    public class TextConnector : IDataConnection
    {
        private const string PrizesFile = "PrizeModel.csv";

        // TODO - Wire up the CreatePrize for the text files.
        public PrizeModel CreatePrize(PrizeModel model)
        {
            // Load The Text File
            // Convert the text to List<PrizeMode>
            List<PrizeModel> prizes = PrizesFile.FullFilePath().LoadFile().ConvertToPrizeModels();


            // Find the max ID
            int currentId = 1;

            if (prizes.Count > 0)
            {
                currentId = prizes.OrderByDescending(x => x.Id).First().Id + 1;
            }

            model.Id = currentId;


            // Add new record with the new ID (max + 1)
            prizes.Add(model);


            // Convert the prize to list<string>
            // Save the list<string> to the test file
            prizes.SaveToPrizeFile(PrizesFile);

            return model;
        }
    }
}
