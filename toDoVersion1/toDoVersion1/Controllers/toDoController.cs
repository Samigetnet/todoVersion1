using System;
using Microsoft.AspNetCore.Mvc;
using VIlla.database;
using VIlla.models;

namespace VIlla.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class toDoController : ControllerBase
    {
        //get all todo lists
        [HttpGet]

        public ActionResult<IEnumerable<userinformation>> getTOdo()
        {
            var TODO = dataStore.store;
            if (TODO == null)
            {
                return StatusCode(StatusCodes.Status404NotFound);
            }
            return Ok(TODO);
        }
        // get task by username 
        [HttpGet("username")]
        public ActionResult<userinformation> getbyusername(string username)
        {
            if (username == null)
            {
                return StatusCode(StatusCodes.Status400BadRequest);
            }

            return Ok(dataStore.store.FirstOrDefault(user => user.username == username));

        }

        //add to do on the list endpoint
        [HttpPut]
        public ActionResult addtodo([FromBody] userinformation userinfo)
        {
            if (userinfo == null)
            {
                return StatusCode(StatusCodes.Status400BadRequest);
            }
            dataStore.store.Add(userinfo);
            return StatusCode(StatusCodes.Status200OK);



        }

        [HttpDelete("username")]

        public ActionResult deletetodo(string username, string confirmation_yes_no)
        {
            if (username == null)
            {
                return StatusCode(StatusCodes.Status400BadRequest);
            }
            else if (confirmation_yes_no == "no" || confirmation_yes_no == "NO")
            {
                return StatusCode(StatusCodes.Status401Unauthorized);
            }
            var tobedeleted = dataStore.store.FirstOrDefault(user => user.username == username);
            dataStore.store.Remove(tobedeleted);
            return Ok();
        }




    }
}

