namespace HM.Shop.Services.Dtos.Shirts;

public class TshirtDto
{
    public Guid Id { get; set; }
    public required string Name { get; set; }
    public Guid ColorId { get; set; }
    public required string ColorName { get; set; }
    public required string RGBValue { get; set; }
    public Guid SizeId { get; set; }
    public required string SizeName { get; set; }
}
