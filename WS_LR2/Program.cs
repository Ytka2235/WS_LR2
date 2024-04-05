internal class Program
{
    enum Days
    {
        Понедельник = 1,
        Вторник,
        Среда,
        Четверг,
        Пятница,
        Суббота,
        Воскресенье
    }
    enum times
    {
        Утро = 1,
        День,
        Вечер,
        Ночь
    }

    private static void Main(string[] args)
    {
        try
        {
            Days D = (Days)Convert.ToInt32(Console.ReadLine());
            int T = Convert.ToInt32(Console.ReadLine());
            if (T >= 0 & T <= 23)
            {
                Console.WriteLine("Сейчас "+ D +", "+Times(T));
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
        catch 
        {
            Console.WriteLine("Error");
        }
    }
        
    static times Times(int x)
    {
        times times  = new times();
        if (x >= 7 & x <= 12) times = (times)1;
        if (x >= 13 & x <= 18) times = (times)2;
        if (x >= 18 & x <= 23) times = (times)3;
        if (x >= 0 & x <= 6) times = (times)4;
        return times;
    }


}
