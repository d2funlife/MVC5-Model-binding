#region Using statements

using ModelBinding.BusinessLogic.Managers;
using ModelBinding.Contracts.Mangers;
using ModelBinding.Core.Entities;
using ModelBinding.Core.IEntities;
using System.Collections.Generic;
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

        #region GET
        public ViewResult Index()
        {
            return this.View();
        }

        public ViewResult BaseBinding()
        {
            return this.View();
        }

        public ViewResult LimitBinding()
        {
            return this.View();
        }

        public ViewResult AltBinding()
        {
            return this.View();
        }

        public ViewResult CustomBinding()
        {
            return this.View();
        }

        [HttpGet]
        public ViewResult CollectionBinding()
        {
            return this.View();
        }
        #endregion

        #region Bind post model
        [HttpPost]
        public ActionResult CreateWithouBinding()
        {
            var movie = new Movie
            {
                Title = Request.Form["Title"],
                Director = Request.Form["Director"],
                Rating = double.Parse(Request.Form["Rating"]),
                Year = int.Parse(Request.Form["Year"])
            };

            //do some actions
            return this.View("BaseBinding");
        }

        [HttpPost]
        public ActionResult CreateWithBinding(Movie movie)
        {
            //do some actions
            return this.View("BaseBinding");
        }
        #endregion

        #region Limit bindings
        [HttpPost]
        public ActionResult BindInclude([Bind(Include = "Title, Year")]Movie movie)
        {
            //some actions
            return this.View("LimitBinding");
        }

        [HttpPost]
        public ActionResult BindExclude([Bind(Exclude = "Director")]Movie movie)
        {
            //some actions
            return this.View("LimitBinding");
        }
        #endregion

        #region Alternative binding
        [HttpPost]
        public ActionResult AlternativeBinding()
        {
            var movie = new Movie();
            this.TryUpdateModel<IEditMovie>(movie);

            //some actions
            return this.View("AltBinding");
        }
        #endregion

        #region Custom model binder
        [HttpGet]
        public ViewResult BindingDefault(int id)
        {
            var movie = this.movieManger.GetMovie(id);
            return this.View("CustomBinding", movie);
        }

        [HttpGet]
        public ViewResult BindingCustom(Movie movie)
        {
            return this.View("CustomBinding", movie);
        }
        #endregion

        #region Collection binding
        [HttpPost]
        public ActionResult CollectionBinding(ICollection<Movie> movies)
        {
            //some actions
            return this.View("CollectionBinding");
        }
        #endregion
    }
}