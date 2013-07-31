using System;
using System.Collections.Specialized;
using System.Configuration;

namespace Library.Comment
{
    public class SConfig
    {
        private static object locker = new Object();
        private static SConfig conf;

        private NameValueCollection properties;

        private SConfig()
        {

            properties = ConfigurationManager.AppSettings;

        }

        public static SConfig GetInstance()
        {

            lock (locker)
            {
                if (conf == null)
                {
                    conf = new SConfig();
                }

            }
            return conf;
        }

        public String getProperty(String key)
        {
            return properties[key];
        }



    }
}
