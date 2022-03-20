using ConcertApp.Domain.Enums;

namespace ConcertApp.Domain
{
    public class Band
    {
        public Guid BandId { get; set; }
        public string Name { get; set; }
        public Genre Genre { get; set; }
    }
}
