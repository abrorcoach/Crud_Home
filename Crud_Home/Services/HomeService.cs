using Crud_Home.Models;

namespace Crud_Home.Services;

public class HomeService
{
    private List<Home> homes;

    public HomeService()
    {
        homes = new List<Home>();
    }

    public Home AddHome(Home home)
    {
        home.Id = Guid.NewGuid();
        homes.Add(home);

        return home;
    }

    public Home GetById(Guid id)
    {
        foreach (var home in homes)
        {
            if (home.Id == id)
            {
                return home;
            }
        }

        return null;
    }

    public bool DeleteHome(Guid id)
    {
        var homeDb = GetById(id);
        if (homeDb is null)
        {
            return false;
        }

        homes.Remove(homeDb);

        return true;
    }

    public bool UpdateHome(Home home)
    {
        var homeDb = GetById(home.Id);
        if (homeDb is null)
        {
            return false;
        }

        var index = homes.IndexOf(homeDb);
        homes[index] = home;
        return true;
    }

    public List<Home> GetAllHomes()
    {
        return homes;
    }

    public List<Home> GetHomesByPrice(double minPrice, double maxPrice)
    {
        var homeByPrice = new List<Home>();

        foreach (var homeDb in homes)
        {
            if (homeDb.Price >= minPrice && homeDb.Price <= maxPrice)
            {
                homeByPrice.Add(homeDb);
            }
        }

        return homeByPrice;
    }

    public List<Home> GetHomesByFloor(int floor)
    {
        var homeByFloor = new List<Home>();

        foreach (var homeDb in homes)
        {
            if (homeDb.Floor == floor)
            {
                homeByFloor.Add(homeDb);
            }
        }

        return homeByFloor;
    }

    public bool BuyHomeById(Guid id)
    {
        var homeDb = GetById(id);

        if (homeDb is null)
        {
            return false;
        }
        if (homeDb.Quantity == 1)
        {
            homes.Remove(homeDb);
        }

        homeDb.Quantity--;
        return true;
    }

    public void DataSeed()
    {
        var Home1 = new Home()
        {
            Id = Guid.NewGuid(),
            Location = "Yunusobod",
            Rooms = 3,
            Price = 120000,
            Floor = 8,
            Quantity = 2
        };
        var Home2 = new Home()
        {
            Id = Guid.NewGuid(),
            Location = "Yunusobod",
            Rooms = 2,
            Price = 80000,
            Floor = 3,
            Quantity = 1
        };
        var Home3 = new Home()
        {
            Id = Guid.NewGuid(),
            Location = "Yunusobod",
            Rooms = 4,
            Price = 160000,
            Floor = 5,
            Quantity = 2
        };
    }

}
