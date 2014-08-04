using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TimeTracker {
  class Repository {
    public Repository() {
      // TODO: remove dummy data
      Projects = new Project[] {
        new Project() { Name = "CCH Assessment" },
        new Project() { Name = "CCH Implementation" },
      };
    }

    public IEnumerable<Project> Projects { get; private set; }
  }
}
