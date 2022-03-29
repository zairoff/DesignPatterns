using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    public class ImageViewer
    {
        private readonly object _obj;

        public ImageViewer(object obj)
        {
            _obj = obj;
        }

        public void ApplyFilter(IFilter filter)
        {
            filter.Apply(_obj);
        }
    }
}
