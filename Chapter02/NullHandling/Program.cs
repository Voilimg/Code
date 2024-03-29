using System;
#nullable enable
namespace NullHandling
{
    class Address
    {
        public string? Building;
        public string Street;
        public string City;
        public string Region;
        public string Street = string.Empty;
        public string City = string.Empty;
        public string Region = string.Empty;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int thisCannotBeNull = 4;
            thisCannotBeNull = null;

            int? thisCouldBeNull = null;
            Console.WriteLine(thisCouldBeNull);
            Console.WriteLine(thisCouldBeNull.GetValueOrDefault());

            thisCouldBeNull = 7;
            Console.WriteLine(thisCouldBeNull);
            Console.WriteLine(thisCouldBeNull.GetValueOrDefault());

            var address = new Address();
            address.Building = null;
            address.Street = null;
            address.City = "London";
            address.Region = null;

            if (thisCouldBeNull != null)
            {
                int length = thisCouldBeNull.Length;
            }
            string authorName = null;
            int x = authorName.Length;
            int? y = authorName?.Length;
            var result= authorName?.Length ?? 3;
            Console.WriteLine(result);
        }
    }
}
