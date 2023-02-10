using problem_solving;
using System.Security.Cryptography.X509Certificates;

namespace Declaring_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            /////////////////BinarySearch
            //var BinarySearch = new BinarySearch();
            //int[] nums = { -1, 0, 3, 5, 9, 12 };
            //int target = 9;
            //int x = BinarySearch.Search(nums, target);


            /////////////First bad Version
            //var FirstBadVersion = new FirstBadVersionClass();
            //int x = FirstBadVersion.FirstBadVersion(2);


            /////////////////search insert position
            int[] nums = { 1,3 };
            int target = 2;
            var SS = new SearchInsertPositionClass();
            int x = SS.InsertSearchPosition(nums, target);




            Console.WriteLine(nums[nums.Length/2]);
            Console.WriteLine(x);
        }


    }
}

