using System;
using System.Collections.Generic;
using System.Text;

namespace Pump.Models
{
    public enum MenuItemType
    {
        NewRoutine,
        CurrentRoutine,
        About
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
