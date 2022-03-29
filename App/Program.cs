using Adapter;
using ThirdPartyFilter;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            var imageViewer = new ImageViewer(new object());
            imageViewer.ApplyFilter(new Blur());
        }
    }
}
