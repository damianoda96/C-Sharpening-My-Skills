using System;

namespace test_console
{
    class User
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public int ID { get; set; }

        public User(string name, string email, int id)
        {
            this.Name = name;
            this.Email = email;
            this.ID = id;
        }
    }

    class MainClass
    {
        public static void Swap(int[] nums, int pos1, int pos2)
        {
            int temp = nums[pos1];
            nums[pos1] = nums[pos2];
            nums[pos2] = temp;

            //return nums;
        }

        public static int GetMin(int[] nums, int start)
        {
            int min_pos = start;

            for(int i = start; i < nums.Length; i++)
            {
                if(nums[i] < nums[min_pos])
                {
                    min_pos = i;
                }
            }

            return min_pos;
        }

        public static int[] SelectionSort(int[] nums) // O(n^2)
        {
            for(int i = 0; i < nums.Length - 1; i++)
            {
                int k = GetMin(nums, i);

                if(i != k)
                {
                    Swap(nums, i, k);
                }
            }

            return nums;
        }

        public static void Quicksort(int[] nums, int l, int r)
        {
            int i, j, x;

            i = l;
            j = r;

            x = nums[(l + r) / 2]; // pivot element

            while(true)
            {
                while(nums[i] < x)
                {
                    i++;
                }
                while(x < nums[j])
                {
                    j--;
                }
                if(i <= j)
                {
                    Swap(nums, i, j);
                    i++;
                    j--;
                }
                if(i > j)
                {
                    break;
                }
            }
            if(l < j)
            {
                Quicksort(nums, l, j);
            }
            if(i < r)
            {
                Quicksort(nums, i, r);
            }
        }


        public static void Quicksort(int[] nums) // O(Nlog(N))
        {
            Quicksort(nums, 0, nums.Length - 1);
        }

        public static void Main(string[] args)
        {
            // Random C# things
            /*User[] users = new User[5];
            string name;

            for(int i = 0; i < users.Length; i++)
            {
                Console.WriteLine("Enter my name, boss.");
                name = Console.ReadLine();
                users[i] = new User(name, "esh", i);

            }

            for(int i = 0; i < users.Length; i++)
            {
                Console.WriteLine("Name: {0}" , users[i].Name);
            }*/

            int[] nums = { 1, 3, 6, 2, 0, 5, 9 };

            //nums = SelectionSort(nums);
            Quicksort(nums);

            foreach (int num in nums)
            {
                Console.WriteLine(num);
            }

            // sort this as fast as possible


        }
    }
}
