using System;
using System.Linq;

namespace ElevenVariant
{
    class Program
    {
        static void Main(string[] args)
        {
            NoteBook noteBook = new NoteBook();
            noteBook.AddNote(new Note("Власов Владимир", "88005553535", new int[] { 19, 9, 2000 }));
            noteBook.AddNote(new Note("Иванов Иван", "89005553535", new int[] { 19, 9, 1984 }));
            noteBook.AddNote(new Note("Петров Петр", "86005553535", new int[] { 18, 6, 1992 }));
            noteBook.AddNote(new Note("Сидоров Сидор", "84005553535", new int[] { 20, 9, 2002 }));
            noteBook.AddNote(new Note("Абрамов Абрам", "82005553535", new int[] { 18, 5, 1993 }));
            noteBook.AddNote(new Note("Наруто Узумаки", "82005553535", new int[] { 20, 5, 1993 }));

            Console.WriteLine($"Вывод по номеру телефона:\n{noteBook.SearchByPhone("88005553535")}");
            Console.WriteLine();
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Поиск по дате рождения:");
            foreach (Note note in noteBook.SearchByBirthday(16, 5, 2000))
            {
                Console.WriteLine(note);
                Console.WriteLine();
            }
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Поиск по дате рождения(на следующей неделе):");
            foreach (Note note in noteBook.SearchByBirthday(18, 5, 2020))
            {
                Console.WriteLine(note);
                Console.WriteLine();
            }
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Поиск по дате рождения(сегодня или по дате рождения):");
            foreach (Note note in noteBook.SearchByBirthday(new int[] { 19, 9, 1984 }, new int[] { 18, 5, 2020 }))
            {
                Console.WriteLine(note);
                Console.WriteLine();
            }
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Поиск по первым трем цифрам номера:");
            foreach (Note note in noteBook.SearchByPhoneThatStartWith("820"))
            {
                Console.WriteLine(note);
                Console.WriteLine();
            }
        }
    }
}
