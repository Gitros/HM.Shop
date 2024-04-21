using HM.Shop.Domain.Shirts;
using HM.Shop.Infrastructure.Sqlite.Db;
using HM.Shop.Services.Dtos.Shirts;
using HM.Shop.Services.Services.Contracts;

namespace HM.Shop.Services.Services;

public class TShirtService(HMContext dbContext) : ITShirtService
{
    public async Task<TShirtDto> CreateAsync(TShirtCreateDto request)
    {
        var result = await dbContext.TShirts.AddAsync(new TShirt
        {
            Name = request.Name,
            ColorId = request.ColorId,
            SizeId = request.SizeId
        });
    }

    public Task DeleteAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<TShirtDto>> GetAsync()
    {
        throw new NotImplementedException();
    }

    public Task<TShirtDto> GetByIdAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<TShirtDto> UpdateAsync(TShirtDto dto)
    {
        throw new NotImplementedException();
    }
}
