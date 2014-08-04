using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace TimeTracker {
  class ProjectDetailPage : ContentPage {
    Repository data;

    public ProjectDetailPage(Repository data) {
      this.data = data;
      this.Content = new Label { Text = "ProjectDetailPage" };
    }
  }
}
