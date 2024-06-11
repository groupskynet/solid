class SimpsonsDrawer {
  public void Draw(Cartoon[] simpsons) {
    foreach (var simpson in simpsons) {
      simpson.Draw();
    }
  }
}
