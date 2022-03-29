using Adapter;
using Factory;
using Source;
using ThirdPartyFilter;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = System.Console.ReadLine();
            var filter = ImageFiltersFactory.GetFilter(input);

            var imageViewer = new Viewer<Image>(new Image());

            imageViewer.ApplyFilter(filter);
        }
    }
}
