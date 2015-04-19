#region Usign statements

using ModelBinding.Core.Entities;

#endregion

namespace ModelBinding.Contracts.Mangers
{
    public interface IMovieManger
    {
        Movie GetMovie(int id);
    }
}