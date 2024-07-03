using System;

namespace Lab3
{
    class Start
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n======================\n");
            Console.WriteLine("1.Count a total number of duplicate elements in an Array.\n");
            Console.WriteLine("2.Print all unique elements in an Array.\n");
            Console.WriteLine("3.Merge the Arrays of Same Size.\n");
            Console.WriteLine("4.Maximum and Minimum elements in an Array.\n");
            Console.WriteLine("5.Sort Elements of the Array in Ascending order and Desending order.\n");
            Console.WriteLine("6.Insert elements in an Array.\n");
            Console.WriteLine("7.Delete elements in an Array.\n");
            Console.WriteLine("8. find the Second Samllest and Second Largest number in an Array.\n");
            Console.WriteLine("9.Find Even and Odds elements in an Array.\n");
            Console.WriteLine("10.Find Prime elemennts in an Array.");

            Console.WriteLine("\n======================\n");





            while (true)
            {

                Console.Write("Select any Option : ");

                int slt = Convert.ToInt32(Console.ReadLine());



                while (slt > 10 || slt < 1)
                {
                    Console.WriteLine("Invalid Option...! ");

                    slt = Convert.ToInt32(Console.ReadLine());

                }

                if (slt == 1)
                {
                    Console.Write("enter the total Size of the array : ");

                    int size = Convert.ToInt32(Console.ReadLine());


                    int[] arr = new int[size];

                    int count = 0;

                    int k = 0;

                    int[] store = new int[size];

                    bool flag = true;


                    Console.Write("Enter the  inputed numbers : ");

                    for (int i = 0; i < size; i++)
                    {
                        arr[i] = Convert.ToInt32(Console.ReadLine());
                    }

                    for (int i = 0; i < size; i++)
                    {
                        for (int l = 0; l < k; l++)
                        {
                            if (i == store[l])
                            {


                                flag = false;

                                break;
                            }

                            else
                            {
                                flag = true;
                            }
                        }

                        if (flag == true)
                        {
                            for (int j = i + 1; j < size; j++)
                            {
                                if (arr[i] == arr[j])
                                {
                                    count++;

                                    store[k++] = j;


                                }
                            }
                        }


                    }

                    Console.WriteLine("Total Duplicate Numbers are: {0}", count);



                }

                else if (slt == 2)
                {
                    Console.Write("enter the total Size of the array : ");

                    int size = Convert.ToInt32(Console.ReadLine());


                    int[] arr = new int[size];

                    Console.Write("Enter the  inputed numbers : ");

                    for (int i = 0; i < size; i++)
                    {
                        arr[i] = Convert.ToInt32(Console.ReadLine());
                    }

                    bool flag = true;

                    for (int i = 0; i < arr.Length; i++)
                    {
                        flag = true;
                        for (int j = 0; j < arr.Length; j++)
                        {
                            if (i != j)
                            {
                                if (arr[i] == arr[j])
                                {
                                    flag = false;
                                    break;
                                }

                            }
                        }

                        if (flag == true)
                        {
                            Console.Write(arr[i] + " ");
                        }
                    }



                    Console.WriteLine();
                }

                else if (slt == 3)
                {
                    Console.Write("enter the total Size of the both  array : ");

                    int size = Convert.ToInt32(Console.ReadLine());


                    int[] arr = new int[size];
                    int[] arr2 = new int[size];
                    Console.WriteLine("Enter the inputs of both arrays ");



                    for (int i = 0; i < size; i++)
                    {
                        Console.WriteLine("Enter the {0} input for first array :  ", i + 1);

                        arr[i] = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Enter the {0} input for second array :  ", i + 1);

                        arr2[i] = Convert.ToInt32(Console.ReadLine());
                    }

                    int[] arr3 = new int[size * 2];

                    Console.WriteLine("Output of the merged array ");

                    for (int i = 0; i < size; i++)
                    {
                        arr3[i] = arr[i];

                        arr3[5 + i] = arr2[i];
                    }

                    foreach (int i in arr3)
                    {
                        Console.Write(i + " ");
                    }

                    Console.WriteLine();

                }

                else if (slt == 4)
                {
                    Console.Write("enter the total Size of the array : ");

                    int size = Convert.ToInt32(Console.ReadLine());


                    int[] arr = new int[size];


                    for (int i = 0; i < size; i++)
                    {
                        arr[i] = Convert.ToInt32(Console.ReadLine());
                    }

                    int v = 0;

                    for (int i = 1; i < size; i++)
                    {
                        v = arr[i];

                        for (int j = i - 1; j >= 0; j--)
                        {
                            if (arr[j] > v)
                            {
                                int k;
                                k = arr[j + 1];
                                arr[j + 1] = arr[j];
                                arr[j] = k;
                            }

                            else
                            {
                                break;
                            }
                        }

                    }


                    Console.WriteLine("The Maximum value in array is {0}  and  Minimum value in array is {1}", arr[size - 1], arr[0]);


                }
                else if (slt == 5)
                {
                    Console.Write("enter the total Size of the array : ");

                    int size = Convert.ToInt32(Console.ReadLine());


                    int[] arr = new int[size];


                    for (int i = 0; i < size; i++)
                    {
                        arr[i] = Convert.ToInt32(Console.ReadLine());
                    }


                    int v = 0;

                    for (int i = 1; i < size; i++)
                    {
                        v = arr[i];

                        for (int j = i - 1; j >= 0; j--)
                        {
                            if (arr[j] > v)
                            {
                                int k;
                                k = arr[j + 1];
                                arr[j + 1] = arr[j];
                                arr[j] = k;
                            }

                            else
                            {
                                break;
                            }
                        }

                    }

                    Console.WriteLine("Asending order -");

                    foreach (int i in arr)
                    {
                        Console.WriteLine(i);
                    }

                    Console.WriteLine("Desending Order - ");

                    for (int i = size - 1; i >= 0; i++)
                    {
                        Console.WriteLine(arr[i]);
                    }


                }

                else if (slt == 6)
                {
                    Console.Write("enter the total Size of the array : ");

                    int size = Convert.ToInt32(Console.ReadLine());


                    int[] arr = new int[size];
                }

                else if (slt == 7)
                {
                    Console.Write("enter the total Size of the array : ");

                    int size = Convert.ToInt32(Console.ReadLine());


                    int[] arr = new int[size];

                }
                else if (slt == 8)
                {
                    Console.Write("enter the total Size of the array : ");

                    int size = Convert.ToInt32(Console.ReadLine());


                    int[] arr = new int[size];
                }

                else if (slt == 9)
                {
                    Console.Write("enter the total Size of the array : ");

                    int size = Convert.ToInt32(Console.ReadLine());


                    int[] arr = new int[size];
                }

                else if (slt == 10)
                {
                    Console.Write("Enter the total size of the array: ");

                    int size = Convert.ToInt32(Console.ReadLine());

                    int[] arr = new int[size];

                    Console.WriteLine("Enter the elements of the array:");
                    
                    for (int i = 0; i < size; i++)

                    {
                        arr[i] = Convert.ToInt32(Console.ReadLine());
                    }

                    Console.WriteLine("Prime elements in the array:");
                    
                    for (int i = 0; i < size; i++)
                    {
                        if (arr[i] > 1)
                        {
                            bool isPrime = true;
                            
                            for (int j = 2; j * j <= arr[i]; j++)
                            {
                                if (arr[i] % j == 0)
                                {
                                    isPrime = false;
                                    break;
                                }
                            }
                            if (isPrime)
                            {
                                Console.Write(arr[i] + " ");
                            }
                        }
                    }
                }
            }



            Console.ReadKey();
        }
    }
}