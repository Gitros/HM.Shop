using HM.Shop.Services.Dtos.Shirts;
using HM.Shop.Services.Services.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace HM.Shop.Api.Controllers;

[Route(nameof(TShirtController))]
[ApiController]
public class TShirtController(ITShirtService tShirtService) : Controller
{
    [HttpGet]
    public async Task<IEnumerable<TShirtDto>> GetAsync() => await tShirtService.GetAsync();

    [HttpGet("{id}")]
    public async Task<TShirtDto> GetByIdAsync(Guid id) => await tShirtService.GetByIdAsync(id);

    [HttpPost]
    public async Task<TShirtDto> CreateAsync(TShirtCreateDto request) => await tShirtService.CreateAsync(request);

    [HttpPut]
    public async Task<TShirtDto> UpdateAsync(TShirtDto updateDto) => await tShirtService.UpdateAsync(updateDto);

    [HttpDelete("{id}")]
    public async Task DeleteAsync(Guid id) => await tShirtService.DeleteAsync(id);
}
