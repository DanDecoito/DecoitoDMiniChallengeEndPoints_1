// Daniel Decoito
// 10-25-22
// MiniChallenge 1
// use api with 9 differnt routes
// reviewd by Jeremy Lapham: Every thing works great good program 



using Microsoft.AspNetCore.Mvc;

namespace DecoitoDMiniChallengeEndPoints_1.Controllers;

[ApiController]
[Route("[controller]")]
public class AssignmentController : ControllerBase
{


    [HttpGet]
    [Route("Hello")]
   public string Hello()
   {
    return "Hello ";
   }


    [HttpGet]
    [Route("Adding")]
    public int Adding()
    {
        return 1+2;
    }

    [HttpGet]
    [Route("AskingQuestions")]
    public string AskingQuestions()
    {
        return "Hello Dan, You woke up at 7:00pm";
    }

    [HttpGet]
    [Route("GreaterOrLess")]
    public string GreaterOrLess()
    {
        return "3 is less than 4";
    }

    [HttpGet]
    [Route("MadLibs")]
    public string MadLibs()
    {
        return "___ ate dinner with ____ then they _____ drove to the ____";
    }

    [HttpGet]
    [Route("OddOrEven")]
    public string OddOrEven()
    {
        return "retruns if a number is odd or even";
    }

    [HttpGet]
    [Route("Reverseit")]
    public string Reverseit()
    {
        return "retruns a string foward and in reverse";
    }

    [HttpGet]
    [Route("Magic8Ball")]
    public string Magic8Ball()
    {
        return " Randomly generates responses";
    }

    [HttpGet]
    [Route("FoodPicker")]
    public string FoodPicker()
    {
        return "eat food at joes";
    }

}
