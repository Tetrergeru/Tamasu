﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Tamagochi
{
    class Instructions
    {
        public static void GetInstructions()
        {
            Console.WriteLine(@"
Это игра тамагочи-студент
Для комфортной жизнедеятельности студента нам необходимо поддерживать три шкалы
с помощью определенных, влияющих на них, действий:
Сытость - просто покорми его (команда ""eat {название_еды}"").
Доступная еда: 
                   Сыт Сч И
            Яблоко (1, 3, 0)
            Дошик  (-1, 6, 0)
            Каша   (4, -1, 0)
            Булка  (1, 1, 0)

Пример:
eat Яблоко


Интеллект - шкала повышается при прохождении мини-игры в зависимости от полученных очков (команда ""learn""),
но он падает при развлечениях.
Мини-игра - устный счет, нужно просто ввести сумму чисел


Счастье - повышается при выполнении развлечений (команда ""do {название_развлечения}"")
Доступные развлечения:
                   Сыт Сч И
           Датка  (-2, 8, -6)
        Прогулка  (-1, 3, -1)
       Зомбоящик  (-2, 4, -2)
     Аутирование  (-1, 2, 0)
Пример:
do Датка
            
Нажмите клавишу для начала игры");
            Console.ReadKey();
            Console.Clear();
        }
    }
}