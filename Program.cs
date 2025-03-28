using Microsoft.Extensions.DependencyInjection;
using WinFormsBlazorTutorial.Services;

namespace WinFormsBlazorTutorial
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            var services = new ServiceCollection();
            services.AddWindowsFormsBlazorWebView();
            services.AddSingleton<IPersonService, PersonService>();
            services.AddTransient<Form1>();

            var serviceProvider = services.BuildServiceProvider();

            Application.Run(serviceProvider.GetRequiredService<Form1>());
        }
    }
}