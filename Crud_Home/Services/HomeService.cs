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
}
