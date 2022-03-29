using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    public class ImageViewer
    {
        private readonly Image _image;

        public ImageViewer(Image image)
        {
            _image = image;
        }

        public void ApplyFilter(IFilter filter)
        {
            filter.Apply(_image);
        }
    }
}
