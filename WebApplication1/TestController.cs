using System.Collections.Generic;
using System.Web.Http;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(Test request)
        {
            return Content(@"
<html>
    <body>
        <button class=""button1"">mvc</button>
        <button class=""button2"">api</button>
        <script src=""/test.js"" type=""text/javascript""></script>
    </body>
</html>
            ", "text/html");
        }
    }
    
    public class TestController : Controller
    {
        public ActionResult Index(Test request)
        {
            return Json(request);
        }
    }

    public class ApiTestController : ApiController
    {
        [System.Web.Http.HttpPost]
        [System.Web.Http.Route("api/test")]
        public IHttpActionResult Index([FromBody]Test request)
        {
            return Ok(request);
        }
    }

    public class Test
    {
        public IEnumerable<TestEnum> Filter { get; set; }

        public enum TestEnum
        {
            Val1 = 1,
            Val2 = 2,
            Val3 = 3,
            Val4 = 4
        }
    }
}