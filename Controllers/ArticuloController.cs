using Microsoft.AspNetCore.Mvc;
using solid.Services;

namespace solid.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ArticuloController : ControllerBase
{

    public  ArticuloController() {
    }

    [HttpPost]
    async public void saveVideo([FromBody] VideoRequest request) {
      try {
        // logs
        Console.WriteLine($"Info: vamos a guardar el video {request.titulo}");
        // guardar articulo
        using (FileStream fs = new FileStream($@"./storage/articulos/{request.titulo}.txt", FileMode.Create))
        {
          using var writer = new StreamWriter(fs);
          await writer.WriteLineAsync(request.contenido);
        }
        // logs
        Console.WriteLine($"Info: artículo {request.titulo} guardado");
      }catch (Exception ex) {
        Console.WriteLine($"Error: no se pudo guardar el video {request.titulo} - {ex.Message}");
      }
    }
}

public record VideoRequest(string titulo, string contenido) {}
