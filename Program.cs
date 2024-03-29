using Projeto_Web_Lh_Pets_versão_1;

namespace Projeto_web_LH_Pets_alunos__1_;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        var app = builder.Build();

        app.MapGet("/", () => "Projeto_web_LH_Pets_alunos-(1)");

         app.UseStaticFiles();
         app.MapGet("/index", (HttpContext contexto)=> {
contexto.Response.Redirect("index.html", false);
});

Banco dba=new Banco();
app.MapGet("/listaClientes", (HttpContext contexto) =>{
contexto.Response.WriteAsync( dba.GetListaString());
});

        app.Run();
    }
}
