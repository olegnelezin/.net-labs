using KinoPoisk.KinoPoisk.BL.Mapper;

namespace KinoPoisk.Kinopoisk.Service.IoC;

public class MapperConfigurator
{
    public static void ConfigureServices(IServiceCollection services)
    {
        services.AddAutoMapper(config =>
        {
            config.AddProfile<UsersBLProfile>();
        });
    }
}