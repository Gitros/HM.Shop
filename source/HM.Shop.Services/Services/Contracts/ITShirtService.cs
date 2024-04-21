using HM.Shop.Services.Dtos.Shirts;

namespace HM.Shop.Services.Services.Contracts;

public interface ITShirtService
{
    Task<TShirtDto> CreateAsync(TShirtCreateDto request);
    Task<IEnumerable<TShirtDto>> GetAsync();
    Task<TShirtDto> GetByIdAsync(Guid id);
    Task DeleteAsync(Guid id);
    Task<TShirtDto> UpdateAsync(TShirtDto dto);
}
