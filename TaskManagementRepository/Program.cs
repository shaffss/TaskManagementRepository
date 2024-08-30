using Commons;
using Commons.Models;
using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace TaskManagementRepository
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string relativePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "config.json");
            string content = File.ReadAllText(relativePath);
            Config config = JsonSerializer.Deserialize<Config>(content);
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1(config));
        }
    }
}