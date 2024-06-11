namespace solid.Services;

public class FileRepository
{
  async public void Save(string path, string content) {
    using (FileStream fs = new FileStream(path, FileMode.Create))
    {
      using var writer = new StreamWriter(fs);
      await writer.WriteLineAsync(content);
    }
  }
}
