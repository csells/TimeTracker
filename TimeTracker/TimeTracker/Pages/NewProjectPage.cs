using Xamarin.Forms;

namespace TimeTracker {
  class NewProjectPage : ContentPage {
    public NewProjectPage() {
      this.Content = new TableView() {
        Intent = TableIntent.Form,
        Root = new TableRoot("New Project") {
          new TableSection {
            new EntryCell {
              Label = "Project Name",
            },
            new EntryCell {
              Label = "Project Description",
            },
          },
        },
      };
    }

  }

}
