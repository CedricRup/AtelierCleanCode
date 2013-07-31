
using log4net;

namespace Library.OOP
{
    public class CVFactory {

        private static ILog logger = LogManager.GetLogger(typeof(CVFactory));


        public static void insertFormation(CV cv)  {
            logger.Warn("inserting CV :" + cv.ToString());
        }

        public static CV getTableauBord(long intId) {
            return new CV();
        }

    
    }
}