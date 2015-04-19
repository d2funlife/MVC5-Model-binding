#region Using statements

using ModelBinding.Core.Entities;
using System;
using System.Web.Mvc;

#endregion

namespace ModelBinding.Web.ModelBind
{
    public class MovieModelBinderProvider : IModelBinderProvider
    {
        public IModelBinder GetBinder(Type modelType)
        {
            if (typeof(Movie) != modelType)
                return null;
            return new MovieModelBinder();
        }
    }
}