using Microsoft.AspNetCore.Mvc;
using TermsManagement.Application.Contract.StateQuery;

namespace TermsManagement.Api.Controllers;

[Route("api/v1/State")]
[ApiController]
public class StateController : ControllerBase
{
    private readonly IStateQuery _stateQuery;

    public StateController(IStateQuery stateQuery)
    {
        _stateQuery = stateQuery;
    }


    /// <summary>
    /// دریافت لیست استان ها به همراه شهر های آن و کد شهر
    /// </summary>
    /// <returns></returns>
    [HttpGet]
    public IActionResult GetAll()
    {
        var model = _stateQuery.GetStateWithCity();
        return Ok(model);
    }
}