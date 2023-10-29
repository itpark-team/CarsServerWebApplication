using CarsServerWebApplication.DbConnector;
using CarsServerWebApplication.Models;
using CarsServerWebApplication.Services;
using Microsoft.AspNetCore.Mvc;

namespace CarsServerWebApplication.Controllers;

[ApiController]
[Route("cars/")]
public class CarsController : ControllerBase
{
    private CarsService _carsService;

    public CarsController(CarsService carsService)
    {
        _carsService = carsService;
    }

    [HttpGet("get-all")]
    public List<Car> GetAll()
    {
        return _carsService.GetAll();
    }

    [HttpDelete("delete-by-id/{id}")]
    public void DeleteById(int id)
    {
        _carsService.DeleteById(id);
    }

    [HttpPost("add-new")]
    public void AddNew(Car car)
    {
        _carsService.AddNew(car);
    }
}