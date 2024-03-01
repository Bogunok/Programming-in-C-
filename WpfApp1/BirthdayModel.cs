using System;
/*
 * File: BirthdayModel.cs
 * Main logic of a program
 * Author: Yelyzaveta Bohun
 */
namespace WpfApp1
{
    internal class BirthdayModel
    {
        private DateTime _dateOfBirth;
        public DateTime Birthdate
        {
            get { return _dateOfBirth; }
            set { _dateOfBirth = value; }
        }


        public int CalculateAge()
        {
            DateTime current = DateTime.Now;
            int age = current.Year - _dateOfBirth.Year;

            if (current.Month < _dateOfBirth.Month || (current.Month == _dateOfBirth.Month && current.Day < _dateOfBirth.Day))
            {
                age--;
            }
            return age;
        }

        public bool TodayIsClientBirthday()
        {
            DateTime current = DateTime.Now;
            if (current.Month == _dateOfBirth.Month && current.Day == _dateOfBirth.Day) return true;
            return false;
        }


        public string WesternZodiac()
        {
            DateTime[] westernZodiacDates = new DateTime[]
            {
                new DateTime(_dateOfBirth.Year, 1, 20),   // Aquarius
                new DateTime(_dateOfBirth.Year, 2, 19),   // Pisces
                new DateTime(_dateOfBirth.Year, 3, 21),   // Aries
                new DateTime(_dateOfBirth.Year, 4, 20),   // Taurus
                new DateTime(_dateOfBirth.Year, 5, 21),   // Gemini
                new DateTime(_dateOfBirth.Year, 6, 21),   // Cancer
                new DateTime(_dateOfBirth.Year, 7, 23),   // Leo
                new DateTime(_dateOfBirth.Year, 8, 23),   // Virgo
                new DateTime(_dateOfBirth.Year, 9, 23),   // Libra
                new DateTime(_dateOfBirth.Year, 10, 23),  // Scorpio
                new DateTime(_dateOfBirth.Year, 11, 22),  // Sagittarius
                new DateTime(_dateOfBirth.Year, 12, 22),  // Capricorn

            };

            string[] zodiacSigns = { "Capricorn", "Aquarius", "Pisces", "Aries", "Taurus", "Gemini", "Cancer", "Leo", "Virgo", "Libra", "Scorpio", "Sagittarius" };

            for (int i = 0; i < westernZodiacDates.Length; i++)
            {
                if (_dateOfBirth < westernZodiacDates[i]) return zodiacSigns[i];
            }

            return zodiacSigns[0];
        }

        public string ChineseZodiac()
        {
            int yearOfZodiac = _dateOfBirth.Year % 12;

            string[] zodiacSigns = { "Monkey", "Rooster", "Dog", "Pig", "Rat", "Ox", "Tiger", "Rabbit", "Dragon", "Snake", "Horse", "Goat" };

            return zodiacSigns[yearOfZodiac];
        }
    }
}
