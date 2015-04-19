#region Usins statements
using ModelBinding.Core.IEntities;
#endregion

namespace ModelBinding.Core.Entities
{
    public class Movie : IEditMovie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Director { get; set; }
        public double Rating { get; set; }
        public int Year { get; set; }
    }
}