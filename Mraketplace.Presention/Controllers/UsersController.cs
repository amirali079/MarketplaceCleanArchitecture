using Microsoft.AspNetCore.Mvc;
using Mraketplace.Presention.DTOs.RequestModels;
using Mraketplace.Presention.DTOs.ResponseModels;


[ApiController]
[Route("user-apis")]
public class UsersController : ControllerBase
{
    
    [HttpGet("get-user-summary")]
    public UserSummaryResponseModel GetUserFunction()
    {

        return new UserSummaryResponseModel();
    }
    
    [HttpPost("login")]
    public string LoginUser(LoginRequestModel loginRequest)
    {

        return "";
    }
    
    
    
}