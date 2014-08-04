using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace TimeTracker {
  class AboutDetailPage : ContentPage {
    Repository data;

    public AboutDetailPage(Repository data) {
      this.data = data;
      this.Content = new Label { Text = "AboutDetailPage" };
    }
  }
}
