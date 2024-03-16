using GiaPhaOnline.Domain.Entities;

namespace GiaPhaOnline.Domain.Interfaces;

public interface IFamilyRepository
{
    Task<Family> AddAsync(Family family);
}