using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SoftX.API.Models;
using SoftX.Domain;
using SoftX.Facade.Service;

namespace SoftX.API.Controllers;

[Route("api/v1/employee")]
[ApiController]
public class EmployeeController : ControllerBase
{
    private readonly IEmployeeService employeeService;
    private readonly IMapper mapper;

    public EmployeeController(IEmployeeService employeeService, IMapper mapper)
    {
        this.employeeService = employeeService;
        this.mapper = mapper;
    }

    [HttpGet]
    [Route("getAll")]
    public ActionResult GetAll()
    {
        var response = employeeService.GetAll();
        return Ok(response);
    }

    [HttpGet]
    [Route("getById")]
    public ActionResult GetById(object id)
    {
        var response = employeeService.GetById(id);
        return Ok(response);
    }

    [HttpGet]
    [Route("search")]
    public ActionResult Search(string text)
    {
        var response = employeeService.Search(text);
        return Ok(response);
    }

    [HttpPost]
    [Route("create")]
    public ActionResult Create([FromBody] EmployeeModel request)
    {
        employeeService.Create(mapper.Map<Employee>(request));
        return NoContent();
    }

    [HttpPut]
    [Route("update")]
    public ActionResult Update(EmployeeModel request)
    {
        employeeService.Update(mapper.Map<Employee>(request));
        return NoContent();
    }

    [HttpDelete]
    [Route("{id}")]
    public ActionResult Delete(object id)
    {
        employeeService.Delete(mapper.Map<Employee>(id));
        return NoContent();
    }
}