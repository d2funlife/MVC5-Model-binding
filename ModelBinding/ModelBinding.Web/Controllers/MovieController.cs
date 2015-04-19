#region Using statements
using ModelBinding.BusinessLogic.Managers;
using ModelBinding.Contracts.Mangers;
using ModelBinding.Core.Entities;
using ModelBinding.Core.IEntities;
using System.Web.Mvc;

#endregion

namespace ModelBinding.Web.Controllers
{
    public class MovieController : Controller
    {
        private readonly IMovieManger movieManger;

        public MovieController()
        {
            this.movieManger = new MovieManager();
        }

        public ViewResult Index()
        {
            return this.View();
        }

        #region Bind post model
        [HttpPost]
        public ActionResult Create()
        {
            var movie = new Movie
            {
                Title = Request.Form["Title"],
                Director = Request.Form["Director"],
                Rating = double.Parse(Request.Form["Rating"]),
                Year = int.Parse(Request.Form["Year"])
            };

            //do some actions
            return this.View();
        }

        [HttpPost]
        public ActionResult Create(Movie movie)
        {
            //do some actions
            return this.View();
        }
        #endregion

        #region Bind limits
        [HttpPost]
        public ActionResult Change([Bind(Include = "Title, Year")]Movie movie)
        {
            //some actions
            return this.View("Done");
        }

        [HttpPost]
        public ActionResult SecondChange([Bind(Exclude = "Director")]Movie movie)
        {
            //some actions
            return this.View("Done");
        }
        #endregion

        #region Another path to bind
        [HttpPost]
        public ActionResult Change()
        {
            var movie = new Movie();
            this.TryUpdateModel<IEditMovie>(movie);

            //some actions
            return this.View("Done");
        }
        #endregion

        #region Custom model binder
        public ViewResult DefaultEdit(int id)
        {
            var movie = this.movieManger.GetMovie(id);
            return this.View("Edit", movie);
        }

        public ViewResult Edit(Movie movie)
        {
            return this.View("Edit", movie);
        }
        #endregion
    }
}