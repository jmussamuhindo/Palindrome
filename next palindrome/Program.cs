using System;
public class Project_6
{
    public static void Main()
    {
        int Arr_count = int.Parse(Console.ReadLine());
        
        for (int i = 0; i < Arr_count; i++)
        {
            string Hint_number = Console.ReadLine().TrimEnd();
            char[] Rev_number = Hint_number.ToCharArray();
            int n = Hint_number.Length;
            for (int j = 0; j < n / 2; j++)
            {
                Rev_number[n - j - 1] = Rev_number[j];
            }
            if (String.Compare(new string(Rev_number), Hint_number) > 0)
            {
                Console.WriteLine(new string(Rev_number));
                continue;
            }           
            int mid = (n - 1) / 2;
            for (int j = mid; j >= 0; j--)
            {
                if (Rev_number[j] != '9')
                {
                    Rev_number[j]++;
                    break;
                }
                else
                    Rev_number[j] = '0';
            }
            for (int j = 0; j < n / 2; j++)
            {
                Rev_number[n - j - 1] = Rev_number[j];
            }
            string Pal_number = new string(Rev_number);
            if (Rev_number[0] == '0')
            {
                Rev_number[0] = '1';
                Pal_number = new string(Rev_number) + "1";
            }
            Console.WriteLine(Pal_number);
        }
    }
}