using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MvcMovie.Controllers
{
    
    public class HelloWorldController : ControllerBase
    {
        //
        // GET: /HelloWorld/

        public IActionResult index()

        {
            return View();
        }

       

        
        
    }
}
