using System.Linq;
using Xamarin.Forms;

namespace TimeTracker {
  class TimerPage : ContentPage {
    public TimerPage() {
      this.Title = "Timer";
      this.Content = new Label { Text = "TimerDetailPage" };
    }

    //protected override void OnAppearing() {
    //  base.OnAppearing();
    //  if (App.Data.Projects.Count() == 0) {
    //    DisplayAlert("Project Required", "You need to create a project before you can start time tracking. Don't worry, it'll just take a second.", "OK", null);
    //    Navigation.PushAsync(new NewProjectPage());
    //  }
    //}

  }

}
