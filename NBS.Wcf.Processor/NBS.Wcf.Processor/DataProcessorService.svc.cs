using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Xml.Linq;

namespace NBS.Wcf.Processor
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class DataProcessorService : IDataProcessorService
    {
        public XElement GetRequest(string processrequest)
        {
            return XElement.Parse("<Service><Notification> Service on and live</Notification></Service>");
        }

        public void processrequest(XElement processrequest)
        {
            var FileName = $@"{DateTime.Now.Ticks}.xml";
            try
            {
                string root = @"C:\NBSData";
                // If directory does not exist, don't even try   
                if (!Directory.Exists(root))
                {
                    Directory.CreateDirectory(root);
                }
                string file = string.Format("{0}\\{1}", root, FileName);
                processrequest.Save(file); 
            }
            catch (Exception exec)
            {

                throw;
            }
        }
    }
}
