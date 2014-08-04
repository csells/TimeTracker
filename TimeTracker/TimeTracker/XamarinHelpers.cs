using System.Collections.Generic;

static class XamarinHelpers {
  public static void AddRange<T>(this IList<T> dest, IEnumerable<T> src) {
    foreach (var item in src) { dest.Add(item); }
  }
}

