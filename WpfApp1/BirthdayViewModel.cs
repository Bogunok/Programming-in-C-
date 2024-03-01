using System;
using System.Collections.Generic;
using System.Linq;
/* File: BirthdayViewModel.cs
 * Connection between View and BirthdayModel
 * Author: Yelyzaveta Bohun
 */

namespace WpfApp1
{
    internal class BirthdayViewModel
    {
        private BirthdayModel _birthday;

        public BirthdayViewModel()
        {
            _birthday = new BirthdayModel();
        }

        public DateTime Birthdate
        {
            get { return _birthday != null ? _birthday.Birthdate : DateTime.Now; }
            set
            {
                if (_birthday == null) _birthday = new BirthdayModel(); 
                _birthday.Birthdate = value;
            }
        }

        public int Age
        {
            get { return _birthday != null ? _birthday.CalculateAge() : 0; }
        }

        public bool TodayIsClientBirthday
        {
            get { return _birthday != null ? _birthday.TodayIsClientBirthday() : false; }
        }

        public string WesternZodiac
        {
            get { return _birthday != null ? _birthday.WesternZodiac() : string.Empty; }
        }

        public string ChineseZodiac
        {
            get { return _birthday != null ? _birthday.ChineseZodiac() : string.Empty; }
        }
    }
}
