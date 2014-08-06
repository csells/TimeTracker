using System.Linq;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TimeTracker {
  class TimerPage : ContentPage {
    bool createNewProjectAttempted;

    public TimerPage() {
      this.Title = "Timer";
      this.Content = new Label { Text = "TimerPage" };
    }

    protected override void OnAppearing() {
      base.OnAppearing();
      if (App.Data.Projects.Count() == 0) {
        CreateNewProject();
      }
    }

    async Task CreateNewProject() {
      if (createNewProjectAttempted) { return; }

      createNewProjectAttempted = true;
      await DisplayAlert("Project Required", "You need to create a project before you can start time tracking. Don't worry, it'll just take a second.", "OK", null);
      await Navigation.PushModalAsync(new NewProjectPage());
    }

  }

}
