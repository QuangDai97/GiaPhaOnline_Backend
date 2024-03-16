using GiaPhaOnline.Domain.Enums;

namespace GiaPhaOnline.Domain.Entities
{
    public sealed class Family
    {
        public string Id { get; set; } = Ulid.NewUlid().ToString();
        public Status Status { get; set; }
        public int CreatedBy { get; set; }
        public DateTimeOffset CreatedDate { get; set; }
        public List<Person> People { get; set; }
    }
}
