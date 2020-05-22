using System;
using System.Collections.Generic;
using System.Text;

/**
Описать класс «запись», содержащий следующие закрытые поля:

• фамилия, имя;

• номер телефона;

• дата рождения(массив из трех чисел).

Предусмотреть свойства для получения состояния объекта.

Описать класс «записная книжка», содержащий закрытый массив записей. Обеспечить следующие возможности:

• вывод на экран информации о человеке, номер телефона которого введен с клавиатуры; если такого нет, выдать на дисплей соответствующее сообщение;

• поиск людей, день рождения которых сегодня или в заданный день;

• поиск людей, день рождения которых будет на следующей неделе;

• поиск людей, номер телефона которых начинается на три заданных цифры.

Написать программу, демонстрирующую все разработанные элементы классов.

*/






namespace ElevenVariant
{
    class Note
    {
        // приватные поля
        private string initials;
        private string phoneNumber;
        private int[] birthday;
        // геттеры и сеттеры
        public string Initials
        {
            get => initials;
            set
            {
                if(value != "" || value != null)
                {
                    initials = value;
                }
            }
        }
        public string PhoneNumber
        {
            get => phoneNumber;
            set
            {
                if (value != "" || value != null)
                {
                    phoneNumber = value;
                }
            }
        }
        public int[] Birthday
        {
            get => birthday;
            set
            {
                if(value != null || value.Length > 0)
                {
                    birthday = value;
                }
            }
        }
        // конструкторы
        public Note()
        {
            initials = "";
            phoneNumber = "";
            birthday = new int[3];

        }
        public Note(string initials, string phoneNumber, int[] birthday)
        {
            this.initials = initials;
            this.phoneNumber = phoneNumber;
            this.birthday = birthday;
        }
        // переопределенный метод ToString()
        public override string ToString()
        {
            return $"Имя фамилия: {initials}\n" +
                $"Номер телефона: {phoneNumber}\n" +
                $"Дата рождения: {string.Join(".", birthday)}";
        }
    }
}
