namespace HM.Shop.Domain.ClothingParameters;

public class Color
{
    public Guid Id { get; set; }
    public required string Name { get; set; }
    public required string RGBValue { get; set; }
}
