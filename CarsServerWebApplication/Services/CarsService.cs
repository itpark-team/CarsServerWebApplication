using CarsServerWebApplication.DbConnector;
using CarsServerWebApplication.Models;

namespace CarsServerWebApplication.Services;

public class CarsService
{
    private AlexCarDbContext _db;

    public CarsService(AlexCarDbContext db)
    {
        _db = db;
    }

    public List<Car> GetAll()
    {
        return _db.Cars.ToList();
    }

    public void DeleteById(int id)
    {
        _db.Cars.Remove(_db.Cars.Find(id));
        _db.SaveChanges();
    }

    public void AddNew(Car car)
    {
        _db.Cars.Add(car);
        _db.SaveChanges();
    }
}