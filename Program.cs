namespace _3_StaticFilesExample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();
            
            app.UseStaticFiles();
            
            app.MapGet("/", () => "Hello World!");

            //http://localhost:5000/
            //http://localhost:5000/imgCertificationPythonComputerVision.jpg
            app.Run();
        }
    }
}
