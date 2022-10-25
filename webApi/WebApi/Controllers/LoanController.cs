using Microsoft.AspNetCore.Mvc;
using WebApi.Controllers.Base;
using WebApi.Data;
using WebApi.Models;

namespace WebApi.Controllers;

[ApiController, Route ("api/[controller]")]
public class LoanController : ApiControllerBase<Loan>
{
    public LoanController(DataContext context, ILogger<Loan> logger) : base(context, logger)
    {
            
    }
}