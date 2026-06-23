namespace ECommercePlatform
{
    class Program
    {
        static int LinearSearch(Product[] products, int targetId)
        {
            int comparisons = 0;
            for (int i = 0; i < products.Length; i++)
            {
                comparisons++;
                if (products[i].ProductId == targetId)
                {
                    Console.WriteLine("Comparisons made (Linear Search): " + comparisons);
                    return i;
                }
            }
            Console.WriteLine("Comparisons made (Linear Search): " + comparisons);
            return -1;
        }

        static int BinarySearch(Product[] sortedProducts, int targetId)
        {
            int low = 0, high = sortedProducts.Length - 1, comparisons = 0;
            while (low <= high)
            {
                int mid = (low + high) / 2;
                comparisons++;
                if (sortedProducts[mid].ProductId == targetId)
                {
                    Console.WriteLine("Comparisons made (Binary Search): " + comparisons);
                    return mid;
                }
                else if (sortedProducts[mid].ProductId < targetId)
                    low = mid + 1;
                else
                    high = mid - 1;
            }
            Console.WriteLine("Comparisons made (Binary Search): " + comparisons);
            return -1;
        }

        static void SortById(Product[] products)
        {
            int n = products.Length;
            for (int i = 0; i < n - 1; i++)
                for (int j = 0; j < n - i - 1; j++)
                    if (products[j].ProductId > products[j + 1].ProductId)
                    {
                        Product temp = products[j];
                        products[j] = products[j + 1];
                        products[j + 1] = temp;
                    }
        }

        static void Main(string[] args)
        {
            Product[] products = new Product[]
            {
                new Product(105, "Wireless Mouse", "Electronics"),
                new Product(102, "Cotton T-Shirt", "Clothing"),
                new Product(108, "Bluetooth Speaker", "Electronics"),
                new Product(101, "Running Shoes", "Footwear"),
                new Product(110, "Coffee Mug", "Home & Kitchen"),
                new Product(104, "Yoga Mat", "Fitness"),
                new Product(107, "Backpack", "Accessories")
            };

            Console.WriteLine("===== All Products =====");
            foreach (Product p in products)
                p.DisplayProduct();

            Console.Write("\nEnter Product ID to search: ");
            int searchId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n===== Linear Search =====");
            int linearIndex = LinearSearch(products, searchId);
            if (linearIndex != -1)
                products[linearIndex].DisplayProduct();
            else
                Console.WriteLine("Product not found.");

            Product[] sorted = (Product[])products.Clone();
            SortById(sorted);

            Console.WriteLine("\n===== Sorted Products =====");
            foreach (Product p in sorted)
                p.DisplayProduct();

            Console.WriteLine("\n===== Binary Search =====");
            int binaryIndex = BinarySearch(sorted, searchId);
            if (binaryIndex != -1)
                sorted[binaryIndex].DisplayProduct();
            else
                Console.WriteLine("Product not found.");

            Console.WriteLine("\n===== Time Complexity =====");
            Console.WriteLine("Linear Search -> O(n)");
            Console.WriteLine("Binary Search -> O(log n) [requires sorted array]");

            Console.ReadKey();
        }
    }
}
