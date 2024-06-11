using Microsoft.AspNetCore.Mvc;
using solid.Services;

namespace solid.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ArticuloController : ControllerBase
{
    private readonly Logger _loggin;
    private readonly FileRepository _file;

    public  ArticuloController() {
      _loggin = new Logger();
      _file = new FileRepository();
    }

    [HttpPost]
    public void saveVideo([FromBody] VideoRequest request) {
      try {
        // logs
        this._loggin.Info($"vamos a guardar el video {request.titulo}");
        // guardar articulo
        _file.Save($@"./storage/articulos/{request.titulo}.txt", request.contenido);
        // logs
        this._loggin.Info($"artículo {request.titulo} guardado");
      }catch (Exception ex) {
        _loggin.Error("Error al guardar el video", ex);
      }
    }
}

public record VideoRequest(string titulo, string contenido) {}
