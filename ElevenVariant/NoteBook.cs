using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ElevenVariant
{
    class NoteBook
    {
        private List<Note> notes;

        public NoteBook()
        {
            this.notes = new List<Note>();
        }

        public Note SearchByPhone(string phone)
        {
            int count = 0;
            foreach (Note note in notes)
            {
                if (note.PhoneNumber == phone)
                {
                    return note;
                }
            }

            return null;
        }
        // др сегодня или поиск по дате
        public IEnumerable<Note> SearchByBirthday(int[] birthday, int[] today)
        {
            foreach (Note Note in notes)
            {
                if (birthday[0] == Note.Birthday[0] && birthday[1] == Note.Birthday[1]
                    || today[0] == Note.Birthday[0] && today[1] == Note.Birthday[1])
                {
                    yield return Note;
                }
            }
        }
        // др на следующей неделе
        public IEnumerable<Note> SearchByBirthday(params int[] currentWeek)
        {
            const int DAYS_IN_WEEK = 7;
            int[] months = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            int[] nextWeek = { currentWeek[0] + DAYS_IN_WEEK, currentWeek[1] };
            if (nextWeek[0] > months[nextWeek[1]])
            {
                nextWeek[0] -= months[nextWeek[1]];
                nextWeek[1] = (nextWeek[1] + 1) % months.Length;
            }

            foreach (Note Note in notes)
            {
                if (Note.Birthday[0] >= currentWeek[0] && Note.Birthday[1] >= currentWeek[1]
                    && Note.Birthday[0] <= nextWeek[0] && Note.Birthday[1] <= nextWeek[1])
                {
                    yield return Note;
                }
            }
        }

        public IEnumerable<Note> SearchByPhoneThatStartWith(string numbers)
        {
            foreach (Note note in notes)
            {
                if (note.PhoneNumber.StartsWith(numbers))
                {
                    yield return note;
                }
            }
        }
        public void AddNote(Note note)
        {
            notes.Add(note);
        }
        public void PrintAllNotes()
        {
            foreach(Note note in notes)
            {
                Console.WriteLine(note);
                Console.WriteLine("------------------------------");
            }
        }
    }
}
