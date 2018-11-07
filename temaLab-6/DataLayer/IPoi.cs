using System;

namespace DataLayer
{
    public interface IPoi
    {
        City City { get; set; }
        Guid? CityId { get; set; }
        string Description { get; }
        Guid Id { get; }
        string Name { get; }
    }
}