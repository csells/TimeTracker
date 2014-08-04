using Xamarin.Forms;

namespace TimeTracker {
  class TimerDetailPage : ContentPage {
    Repository data;

    public TimerDetailPage(Repository data) {
      this.data = data;
      this.Content = new Label { Text = "TimerDetailPage" };
    }
  }
}
