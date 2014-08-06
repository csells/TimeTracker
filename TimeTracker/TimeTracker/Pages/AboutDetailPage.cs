using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace TimeTracker {
  class AboutPage : ContentPage {
    public AboutPage() {
      this.Title = "About";
      this.Content = new Label { Text = "AboutDetailPage" };
    }
  }
}
