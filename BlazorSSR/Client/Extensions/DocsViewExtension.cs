﻿using Microsoft.Extensions.DependencyInjection;
using BlazorSSR.Client.Services;
using MudBlazor.Services;
using MudBlazor;

namespace BlazorSSR.Client.Extensions
{
    public static class DocsViewExtension
    {
        public static void TryAddDocsViewServices(this IServiceCollection services)
        {
            services.AddMudServices(config =>
            {
                config.SnackbarConfiguration.PositionClass = Defaults.Classes.Position.BottomLeft;
                config.SnackbarConfiguration.PreventDuplicates = false;
                config.SnackbarConfiguration.NewestOnTop = false;
                config.SnackbarConfiguration.ShowCloseIcon = true;
                config.SnackbarConfiguration.VisibleStateDuration = 10000;
                config.SnackbarConfiguration.HideTransitionDuration = 500;
                config.SnackbarConfiguration.ShowTransitionDuration = 500;
                config.SnackbarConfiguration.SnackbarVariant = Variant.Filled;
            });

            services.AddSingleton<IApiLinkService, ApiLinkService>();
            services.AddSingleton<IMenuService, MenuService>();
            services.AddScoped<IDocsNavigationService, DocsNavigationService>();
        }
    }
}
