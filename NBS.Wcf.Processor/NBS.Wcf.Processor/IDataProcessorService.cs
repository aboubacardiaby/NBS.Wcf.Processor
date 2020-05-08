using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Xml.Linq;

namespace NBS.Wcf.Processor
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IDataProcessorService
    {

        [OperationContract]
        [WebGet(UriTemplate = "/{processrequest}", ResponseFormat = WebMessageFormat.Xml, BodyStyle = WebMessageBodyStyle.Bare)]
        XElement GetRequest(string processrequest);

        [OperationContract]
        [WebInvoke(Method ="POST", UriTemplate ="/processrequest", RequestFormat =WebMessageFormat.Xml,BodyStyle =WebMessageBodyStyle.Bare, ResponseFormat = WebMessageFormat.Xml)]
        void processrequest( XElement processrequest);

        // TODO: Add your service operations here
    }


   
    }

