using Rest.DAL;
using Rest.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Rest
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "RestService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select RestService.svc or RestService.svc.cs at the Solution Explorer and start debugging.
    public class RestService : IRestService
    {
        DataClassContext db = new DataClassContext();
        public string SendData(string id)
        {
            //throw new WebFaultException(HttpStatusCode.Forbidden);
            DataClass ob = db.dataClass.Find(1);
            return "Nazwa obiektu: " + ob.name;
        }
    }
}
