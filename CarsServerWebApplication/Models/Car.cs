using System;
using System.Collections.Generic;

namespace CarsServerWebApplication.Models;

public partial class Car
{
    public int Id { get; set; }

    public string Name { get; set; }

    public int ReleaseYear { get; set; }

    public int Price { get; set; }
}
