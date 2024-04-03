using System;
using System.Collections.Generic;

namespace Adventure_Chest.ViewModels
{
    public class CartViewModel
    {
        public IEnumerable<(CharacterViewModel Character, int Quantity)> Items { get; set; }
    }
}