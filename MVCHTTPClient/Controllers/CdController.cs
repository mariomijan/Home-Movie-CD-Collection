using MVCHTTPClient.CdReference;
using MVCHTTPClient.GenreReference;
using MVCHTTPClient.Models;
using System.Web.Mvc;

namespace MVCHTTPClient.Controllers
{

    public class CdController : Controller
    {
        GenreServiceClient genreObj = new GenreServiceClient();
        CdServiceClient cdObj = new CdServiceClient();

        //Display all the genres on Index page
        public ActionResult Index()
        {
            var genre = genreObj.GetAllGenres();
            return View(genre);
        }

        //Display cds and genre name on Cd page, by selected genre
        public ActionResult cds(int id)
        {
            CollectionViewModel viewModel = new CollectionViewModel();
            viewModel.Genre = genreObj.GetGenre(id);
            viewModel.Cds = cdObj.GetAllCdsByGenre(id);
            return View(viewModel);

        }
    }
}
