﻿using System;
using ApplicationTemplate.Services;
using Assignment6Cottrell.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Assignment6Cottrell;

/// <summary>
///     Used for registration of new interfaces
/// </summary>
internal class Startup
{
    public IServiceProvider ConfigureServices()
    {
        IServiceCollection services = new ServiceCollection();

        services.AddLogging(builder =>
        {
            builder.AddConsole();
            builder.AddFile("app.log");
        });

        // Add new lines of code here to register any interfaces and concrete services you create
        services.AddTransient<IMainService, MainService>();

        return services.BuildServiceProvider();
    }
}
