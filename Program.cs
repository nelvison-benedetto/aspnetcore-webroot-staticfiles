using Microsoft.Extensions.FileProviders;

namespace _3_StaticFilesExample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(new WebApplicationOptions() { 
                WebRootPath = "wwwroot"  //impostiamo la cartella wwwroot come cartella per i file statici
            });
            var app = builder.Build();
            
            app.UseStaticFiles(); //w this tutti i files statici nella cartella wwwroot sono accessibili tramite diretto url req
            app.UseStaticFiles(new StaticFileOptions() {  //static file middlewarare
                FileProvider = new PhysicalFileProvider(
                    Path.Combine(builder.Environment.ContentRootPath, "mywwwroot")
                ),
            });
            app.MapGet("/", () => "Hello World!");

            //http://localhost:xxx/img1.jpg
            //http://localhost:xxx/img2.jpg
            //http://localhost:xxx/img3.jpg
            app.Run();
        }
    }
}
