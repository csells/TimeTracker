using System;
using System.Linq;
using Xamarin.Forms;

namespace TimeTracker {
  class MainPage : MasterDetailPage {
    class MenuItem {
      Page page;
      public string Text { get; set; }
      public string Icon { get; set; }
      public Func<Page> PageCreator;

      public Page GetPage() {
        if (this.page == null) {
          var root = PageCreator();
          root.Title = "TimeTracker";
          this.page = new NavigationPage(root);
        }

        return this.page;
      }
    }

    public MainPage() {
      var data = new Repository();

      var template = new DataTemplate(typeof(ImageCell));
      template.SetBinding(ImageCell.TextProperty, "Text");
      template.SetBinding(ImageCell.ImageSourceProperty, "Icon");

      var menuItems = new MenuItem[] {
        new MenuItem { Text = "Projects", Icon = "projects.png", PageCreator = ()=>new ProjectDetailPage(data) },
        new MenuItem { Text = "Timer", Icon = "timer.png", PageCreator = ()=>new TimerDetailPage(data) },
        new MenuItem { Text = "About", Icon = "about.png", PageCreator = ()=>new AboutDetailPage(data) },
      };

      ListView listview;
      this.Master = new ContentPage {
        Icon = "slideout.png",
        Title = "menu",
        Content = listview = new ListView {
          ItemTemplate = template,
          ItemsSource = menuItems,
        },
      };

      listview.ItemSelected += (s, e) => {
        var menuItem = (MenuItem)listview.SelectedItem;
        this.Detail = menuItem.GetPage();
        this.IsPresented = false;
      };

      listview.SelectedItem = menuItems.First(m => m.Text == "Timer");
      this.IsGestureEnabled = true;
    }

  }

}
