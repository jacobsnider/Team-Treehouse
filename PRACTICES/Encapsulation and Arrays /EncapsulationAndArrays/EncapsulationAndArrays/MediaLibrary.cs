﻿using System;

namespace Treehouse.MediaLibrary
{
    public class MediaLibrary
    {

        private MediaType[] _items; 

        public MediaLibrary(MediaType[] items)
        {
            _items = items;
        };

        public MediaType GetItemAt(int index)
        {
            if (index < _items.Length)
            {
                return _items[index];
            }
            else 
            {
                System.Console.WriteLine("An element at index " + index + " doesn't exist in the media library.");

                return null;
            }
        }
    }
}
