using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TokenBased_Web_API.Controllers
{
    public class StudentController : ApiController
    {
        [Authorize]
        public IHttpActionResult Get()
        {
            using(ClassroomEntities objClass = new ClassroomEntities())
            {
                return Ok(objClass.Students.ToList());
            }
        }
    }
}
