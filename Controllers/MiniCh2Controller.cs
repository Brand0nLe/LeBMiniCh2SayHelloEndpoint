//Brandon Le
//10-25-22
//Mini Challenge 2 - Say Hello Endpoint
//Web API project that will take the users input in the url and print it back into a statement as
//"Hello {name} I hope you're having a great day today! You're doing great! You got this!"
//Peer Review: Jessie Lamzon
//Code is working well and runs without errors.  Good job!



using Microsoft.AspNetCore.Mvc;

namespace MiniCh2SayHelloEndpoint.Controllers;

[ApiController]
[Route("[controller]")]
public class MiniCh2Controller : ControllerBase
{
    [HttpGet]
    [Route("Hello/{name}")]
    public string SayHello(string name)
    {
        return $"Hello {name}! I hope you're having a great day today! You're doing great! You got this! :)";
    }
}
