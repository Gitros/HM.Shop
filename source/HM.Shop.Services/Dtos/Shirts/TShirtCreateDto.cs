namespace HM.Shop.Services.Dtos.Shirts;

public class TShirtCreateDto
{
    public required string Name { get; set; }
    public Guid ColorId { get; set; }
    public Guid SizeId { get; set; }
}
