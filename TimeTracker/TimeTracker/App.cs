using Xamarin.Forms;

namespace TimeTracker {
  public class App {
    static App() {
      Data = new Repository();
    }

    internal static Repository Data { get; private set; }
    public static Page GetMainPage() { return new MainPage(); }
  }
}
