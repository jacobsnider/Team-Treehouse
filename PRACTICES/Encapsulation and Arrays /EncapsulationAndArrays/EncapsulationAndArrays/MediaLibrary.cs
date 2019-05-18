using System;

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
            return _items[index];
        }
    }
}
