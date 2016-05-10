using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timetable
{
    class Timetable
    {
        private Dictionary<DayOfWeek, List<string>> timetable = new Dictionary<DayOfWeek, List<string>>();
        public IReadOnlyList<string> AllTheClasses;
        public IReadOnlyList<string> BringBookClasses;
        public IReadOnlyList<string> Classes;
        private string[] noBookClasses;
        private DateTime dayToShow;

        public Timetable(string timetableRaw)
        {
            timetableRaw = timetableRaw.Replace("\r", "");

            int noBookSplitIndex = timetableRaw.IndexOf('\n');
            noBookClasses = timetableRaw.Substring(1, noBookSplitIndex - 1).Split(',');
            var week = timetableRaw.Substring(noBookSplitIndex + 1).Split(new[] { "\n\n" }, StringSplitOptions.None).ToArray();
            
            var dayOfWeek = DayOfWeek.Monday;

            foreach (var day in week)
            {
                timetable.Add(dayOfWeek, new List<string>());

                foreach (var lesson in day.Split('\n'))
                    timetable[dayOfWeek].Add(lesson.Split('|')[0]);

                dayOfWeek++;
            }

            AllTheClasses = timetable.Values.SelectMany(a => a).Distinct().ToList().AsReadOnly();
            UpdateClassDay();
            UpdateClasses();
        }

        public void ChangeAt(int i, string s)
        {
            timetable[dayToShow.DayOfWeek][i] = s;
            UpdateClasses();
        }

        public void InsertAt(int i, string s)
        {
            ValidityCheck(s);
            timetable[dayToShow.DayOfWeek].Insert(i, s);
            UpdateClasses();
        }

        public void Add(string s)
        {
            ValidityCheck(s);
            timetable[dayToShow.DayOfWeek].Add(s);
            UpdateClasses();
        }

        private void ValidityCheck(string s)
        {
            if (!AllTheClasses.Contains(s))
                throw new ArgumentException($"\"{s}\" is not a valid class name");
        }

        public void RemoveAt(int i)
        {
            timetable[dayToShow.DayOfWeek].RemoveAt(i);
            UpdateClasses();
        }

        public void MoveAt(int i, bool up)
        {
            var temp = timetable[dayToShow.DayOfWeek][i];
            timetable[dayToShow.DayOfWeek][i] = timetable[dayToShow.DayOfWeek][i + (up ? -1 : 1)];
            timetable[dayToShow.DayOfWeek][i + (up ? -1 : 1)] = temp;
            UpdateClasses();
        }

        private List<string> GetBringBookClasses()
        {
            var noDupesNoFrees = RemoveFreeClasses(timetable[dayToShow.DayOfWeek].Distinct());

            List<string> bringBookClasses;
            if (noDupesNoFrees.Count % 2 == 1)
            {
                bringBookClasses = Every2nd(noDupesNoFrees.Take(noDupesNoFrees.Count - 1));
                if (dayToShow.Day % 2 == 1)
                    bringBookClasses.Add(noDupesNoFrees.Last());
            }
            else
                bringBookClasses = Every2nd(noDupesNoFrees);

            return bringBookClasses;
        }

        public void UpdateClassDay()
        {
            dayToShow = DateTime.Now;

            if (dayToShow.Hour > 12 || dayToShow.DayOfWeek == DayOfWeek.Sunday)
            {
                do
                {
                    dayToShow = dayToShow.AddDays(1);
                }
                while (dayToShow.DayOfWeek == DayOfWeek.Sunday);
            }
        }

        private void UpdateClasses()
        {
            Classes = GetClasses().AsReadOnly();
            BringBookClasses = GetBringBookClasses().AsReadOnly();
        }

        private List<string> GetClasses() => timetable[dayToShow.DayOfWeek];

        private List<string> RemoveFreeClasses(IEnumerable<string> classes) => classes.Where(@class => !noBookClasses.Contains(@class)).ToList();

        private static List<string> Every2nd(IEnumerable<string> classes) => classes.Where((t, i) => i % 2 == 1).ToList();
    }

    static class Extensions
    {
        public static List<T> Clone<T>(this List<T> listToClone) where T : ICloneable
        {
            return listToClone.Select(item => (T)item.Clone()).ToList();
        }
    }
}
