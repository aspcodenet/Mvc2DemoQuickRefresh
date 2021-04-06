using System.Collections.Generic;

namespace Mvc2DemoQuickRefresh.ViewModels
{
    public class HomePlayersViewModel
    {
        public List<Item> Items { get; set; }

        public class Item
        {
            public string Name { get; set; }
            public int Jersey { get; set; }
        }
    }
}