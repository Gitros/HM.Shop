using HM.Shop.Domain.ClothingParameters;

namespace HM.Shop.Domain.Shirts;

public class TShirt
{
    public Guid Id { get; set; }
    public required string Name { get; set; }
    public Guid ColorId { get; set; }
    public Color? Color { get; set; }
    public Guid SizeId { get; set; }
    public Size? Size { get; set; }
}
