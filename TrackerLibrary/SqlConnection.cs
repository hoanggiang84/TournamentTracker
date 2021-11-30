using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class SqlConnection : IDataConnection
    {
        /// <summary>
        /// Save a new prize to database
        /// </summary>
        /// <param name="model">Prize information</param>
        /// <returns>The prize information, including the unique identifier</returns>
        public PrizeModel CreatePrize(PrizeModel model)
        {
            // TODO: save prize information to the database
            model.Id = 1;
            return model;
        }
    }
}
