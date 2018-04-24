using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using EmployeeDataAccess;

namespace TokenAuthWebService.Controllers
{
    [Authorize]
    public class EmployeesController : ApiController
    {
        public IEnumerable<EmployeeModel> Get()
        {
            var sqlite = new SQLiteWorker();

            return sqlite.GetEmploees();
        } 
    }
}
