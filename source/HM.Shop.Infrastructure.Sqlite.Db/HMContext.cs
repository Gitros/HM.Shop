using HM.Shop.Domain.ClothingParameters;
using HM.Shop.Domain.Shirts;
using HM.Shop.Domain.Skirts;
using Microsoft.EntityFrameworkCore;

namespace HM.Shop.Infrastructure.Sqlite.Db;

public class HMContext : DbContext
{
    #region Skirts
    public DbSet<Skirt> Skirts => Set<Skirt>();
    #endregion

    #region Shirts
    public DbSet<TShirt> TShirts => Set<TShirt>();
    #endregion

    #region ClothingParameters
    public DbSet<Color> Colors => Set<Color>();
    public DbSet<Size> Sizes => Set<Size>();
    #endregion

    public string DbPath { get; }

    public HMContext()
    {
        var folder = Environment.SpecialFolder.LocalApplicationData;
        var path = Environment.GetFolderPath(folder);
        DbPath = System.IO.Path.Join(path, "hm.db");
    }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite($"Data Source={DbPath}");
}