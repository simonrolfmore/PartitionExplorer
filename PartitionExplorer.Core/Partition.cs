﻿using System.Collections.Generic;
using System.Linq;

namespace PartitionExplorer.Core
{
    public class Partition
    {
        private readonly List<string> _items;
        private int _partitionIndex;
        
        public Partition(int partitionIndex)
        {
            _items = new List<string>();
        }

        public void AddItem(string item)
        {
            _items.Add(item);
        }

        public IEnumerable<string> Items
        {
            get
            {
                return _items;
            }
        }

        public int Count
        {
            get
            {
                return _items.Count();
            }
        }
    }
}
