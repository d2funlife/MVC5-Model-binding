#region Using statements

using ModelBinding.BusinessLogic.Managers;
using System.Web.Mvc;

#endregion

namespace ModelBinding.Web.ModelBind
{
    public class MovieModelBinder : IModelBinder
    {
        public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            var value = bindingContext.ValueProvider.GetValue(bindingContext.ModelName);
            if (value == null)
                return null;
            if (string.IsNullOrEmpty(value.AttemptedValue))
                return null;

            int movieId;
            if (!int.TryParse(value.AttemptedValue, out movieId))
                return null;

            var movieManager = new MovieManager();
            var movie = movieManager.GetMovie(movieId);
            return movie;
        }
    }
}