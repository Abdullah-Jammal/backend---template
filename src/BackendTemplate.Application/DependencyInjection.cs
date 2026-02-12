using BackendTemplate.Application.Todos;
using Microsoft.Extensions.DependencyInjection;

namespace BackendTemplate.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddScoped<ITodoService, TodoService>();
        return services;
    }
}
