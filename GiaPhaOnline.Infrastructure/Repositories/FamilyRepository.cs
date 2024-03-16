using GiaPhaOnline.Domain.Entities;
using GiaPhaOnline.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace GiaPhaOnline.Infrastructure.Repositories;

public sealed class FamilyRepository : IFamilyRepository
{
    private readonly GiaPhaOnlineDbContext _context;
    private readonly DbSet<Family> _familyDbSet;
    public FamilyRepository(GiaPhaOnlineDbContext context)
    {
        _context = context;
        _familyDbSet = context.Set<Family>();
    }
    
    public async Task<Family> AddAsync(Family family)
    {
        _familyDbSet.Add(family);
        await _context.SaveChangesAsync();
        return family;
    }
}