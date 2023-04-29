using Xamarin.Forms;

namespace TabbedPageSample {
  public partial class App : Application {
    public App() {
      InitializeComponent();

      MainPage = new MainTabbedPage();
    }

    protected override void OnStart() {
      // Method intentionally left empty.
    }

    protected override void OnSleep() {
      // Method intentionally left empty.
    }

    protected override void OnResume() {
      // Method intentionally left empty.
    }
  }
}
