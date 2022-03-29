using Adapter;
using ThirdPartyFilter;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            var amazingFilterAdapter = new AmazingFilterAdapter(new AmazingFilter());
            var imageViewer = new ImageViewer(new object());

            imageViewer.ApplyFilter(new Blur());
            imageViewer.ApplyFilter(amazingFilterAdapter);
        }
    }
}
