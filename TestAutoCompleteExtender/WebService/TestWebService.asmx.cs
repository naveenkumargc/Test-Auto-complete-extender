using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Services;
using System.Web.Services;

namespace TestAutoCompleteExtender.WebService
{
    /// <summary>
    /// Summary description for TestWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]
    public class TestWebService : System.Web.Services.WebService
    {
        [WebMethod]
        public List<string> GetSampleData(string prefixText, int count, string contextKey)
        {
            //In real scenario, use the context key and process db to get some data and send the info.
            //For now, just send some dummy data.

            List<string> returnList = new List<string>();
            returnList.Add("AB");
            returnList.Add("ABC");
            returnList.Add("ABCD");
            returnList.Add("ABCDE");
            returnList.Add("ABCDEF");

            return returnList;
        }
    }
}
