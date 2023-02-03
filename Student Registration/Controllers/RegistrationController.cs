using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Student_Registration.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegistrationController : ControllerBase
    {
        [HttpGet]
        public string Greetings ()
        {
            return "Hello there";
        }
    }
}


/* CRUD                                                 HTTP VERBS
        CREATE- a NEW record                        ----POST
        READ - a RETRIEVE a single/list of records  ----GET
        UPDATE - MODIFY an existing record         -----PUT
        DELETE - REMOVE an existing record         -----DELETE */
