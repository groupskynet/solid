namespace solid.Services;

public class Logger {
  public void Info(string message) {
    Console.WriteLine($"Info: {message}");
  }

  public void Error(string message, Exception ex) {
    Console.WriteLine($"Error: {message} - {ex.Message}");
  }

  public void Fatal(string message, Exception ex) {
    Console.WriteLine($"Fatal: {message} - {ex.Message}");
  }
}
