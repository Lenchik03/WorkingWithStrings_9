namespace З.А_задание_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //задание 1
            //Console.WriteLine("Введите текст");
            //string text = Console.ReadLine();

            //char[] Splitter = new char[] { ' ', ',', '.' };
            //string[] stings = text.Split ( Splitter, StringSplitOptions.RemoveEmptyEntries );
            //int count = 0;
            //for ( int i = 0; i < stings.Length; i++ )
            //{
            //    count ++;
            //}
            //Console.WriteLine( count );

            //задание 2
            //Console.WriteLine("Введите текст");
            //string text = Console.ReadLine();

            //int count = text.Split().Where(x => x[0] == 'b').Count();
            //Console.WriteLine(count);

            //задание 3
            //Console.WriteLine("Введите текст");
            //string text = Console.ReadLine();

            //int count = 0;
            //int r = 0;
            //int k = 0;
            //int t = 0;

            //for (int i = 0; i < text.Length; i++)
            //{
            //    if (text[i] == 'r')
            //        r++;
            //    if (text[i] == 'k')
            //        k++;
            //    if (text[i] == 't')
            //        t++;
            //}
            //Console.WriteLine("r " + r);
            //Console.WriteLine("k " + k);
            //Console.WriteLine("t " + t);

            //задание 4
            //Console.WriteLine("Введите текст");
            //string text = Console.ReadLine();

            //int count = 0;
            //int r = 0;
            //int k = 0;
            //int t = 0;

            //for (int i = 0; i < text.Length; i++)
            //{
            //    if (text[i] == '*')
            //        r++;
            //    if (text[i] == ';')
            //        k++;
            //    if (text[i] == ':')
            //        t++;
            //}
            //Console.WriteLine("* " + r);
            //Console.WriteLine("; " + k);
            //Console.WriteLine(": " + t);

            //задание 6
            //Console.WriteLine("Введите текст");
            //string text = Console.ReadLine();
            //Console.WriteLine(text.IndexOf(':'));

            //int count = 0;
            //int each = 0;


            //for (int i = 0; i < text.Length; i++)
            //{
            //    if (text[i] == ':')
            //    {
            //        Console.WriteLine(i);
            //        each = i;
            //    }
            //}
            //for (int i = 0; i < each ; i++)
            //{
            //    count++;
            //}
            //Console.WriteLine(count);

            //задание 7
            //Console.WriteLine("Введите текст");
            //string text = Console.ReadLine();

            //char[] Splitter = new char[] { ' ', ',', '.' };
            //string[] stings = text.Split(Splitter, StringSplitOptions.RemoveEmptyEntries);
            //int count = 0;
            //foreach (string sting in stings) 
            //{

            //    if( sting.Length == 3)
            //    {
            //        count++;
            //    }
            //}
            //Console.WriteLine(count);

            //здание 9
            //Console.WriteLine("Введите текст");
            //string text = Console.ReadLine();

            //text = text.Replace("abc", "&");

            //Console.WriteLine(text.Count(s => s == '&'));

            //задание 11
            //Console.WriteLine("Введите текст");
            //string text = Console.ReadLine();

            //string ch = "";

            //for(int i = 0; i < text.Length; i++)
            //{
            //    if (!ch.Contains(text[i]))
            //    {
            //        ch += text[i];
            //    }
            //}
            //Console.WriteLine(ch + ch.Length);

            // задание 12
            //Console.WriteLine("Введите текст");
            //string text = Console.ReadLine();

            //int max = int.MinValue;
            //int count = 0;

            //for(int i = 0; i< text.Length; i++)
            //{
            //    if (text[i] == 'a')
            //    {
            //        count++;
            //    }
            //    if (text[i] != 'a')
            //    {
            //        if(count > max)
            //        {
            //            max = count;
            //        }
            //        count = 0;

            //    }
            //}
            //Console.WriteLine(max);

            //задание 13
            //Console.WriteLine("Введите текст");
            //string text = Console.ReadLine();

            //int each = 0;

            //for(int i = 0; i<text.Length; i++)
            //{
            //    if (text[i] == '(')
            //    {
            //        each = i;
            //    }
            //}
            //for(int i = each+1; i< text.Length; i++)
            //{
            //    if (text[i] == ')' )
            //    {
            //        break;  
            //    }
            //    Console.Write(text[i]);
            //}

            //задание 14
            //Console.WriteLine("Введите текст");
            //string text = Console.ReadLine();
            //int max = int.MinValue;
            //int count = 0;

            //for (int i = 0; i < text.Length; i++)
            //{
            //    if (int.TryParse(text[i].ToString(), out int nenushno))
            //    {
            //        count++;
            //    }
            //    else
            //    {
            //        if (count > max)
            //        {
            //            max = count;
            //        }
            //        count = 0;

            //    }
            //}
            //Console.WriteLine(max);

            //задание 15
            //Console.WriteLine("Введите текст");
            //string text = Console.ReadLine();

            //char[] Splitter = new char[] { ' ', ',', '.' };
            //string[] stings = text.Split(Splitter, StringSplitOptions.RemoveEmptyEntries);
            //int count = 0;

            //foreach (string sting in stings)
            //{

            //    if (sting.EndsWith('a'))
            //    {
            //        count++;
            //    }
            //}
            //Console.WriteLine(count);

            //задание 17
            //Console.WriteLine("Введите текст");
            //string text = Console.ReadLine();

            //char[] Splitter = new char[] { ' ', ',', '.' };
            //string[] stings = text.Split(Splitter, StringSplitOptions.RemoveEmptyEntries);
            //int count = 0;

            //foreach (string sting in stings)
            //{

            //    if (sting[sting.Length - 1] == sting[0])
            //    {
            //        Console.WriteLine(sting);
            //    }
            //}

            //задание 18
            //Console.WriteLine("Введите текст");
            //string text = Console.ReadLine();

            //int count = 0;

            //for(int i = 0; i < text.Length; i++)
            //{
            //    if (text[i]  == ':')
            //    {
            //        count++;
            //    }
            //}

            //text = text.Replace(':', ';');

            //Console.WriteLine(text);
            //Console.WriteLine(count);

            //задание 19
            //Console.WriteLine("Введите текст");
            //string text = Console.ReadLine();
            //int count = 0;

            //for (int i = 0; i < text.Length; i++)
            //{
            //    if (text[i] == ':')
            //    {
            //        text = text.Remove(i,1);
            //        count++;
            //    }
            //}

            //Console.WriteLine(text);
            //Console.WriteLine(count);
        }

    }
}
