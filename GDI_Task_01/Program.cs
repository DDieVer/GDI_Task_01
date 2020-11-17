using System;

namespace GDI_Task_01
{

        class Program
        {
            static void Main(string[] args)
            {
                int gold;//наше золото
                int price = 5;//цена кристала
                int crystals;//число кристалов
                bool chek;//булевая переменная для проврки

                Console.Write("Введите сколько у вас монет: ");
                gold = Convert.ToInt32(Console.ReadLine());

                Console.Write($"Цена кристалла {price} монет.\nВведите сколько вам нужно кристалов: ");
                crystals = Convert.ToInt32(Console.ReadLine());

                chek = gold >= price * crystals;
                crystals *= Convert.ToInt32(chek);
                gold -= price * crystals;

                Console.WriteLine($"Ваша сумка:\nЗолотых монет: {gold} $;\nКристаллов: {crystals} ♦");
            }
        }
    
}
