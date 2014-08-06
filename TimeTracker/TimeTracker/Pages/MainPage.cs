using System;
using System.Linq;
using Xamarin.Forms;

namespace TimeTracker {
  class MainPage : TabbedPage {
    public MainPage() {
      this.Children.AddRange(new Page[] {
        new ProjectsPage(),
        new TimerPage(),
        new AboutPage(),
      });

      this.SelectedItem = this.Children.Cast<Page>().Select(p => p.Title == "Projects");
    }

  }

}
