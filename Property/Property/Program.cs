using System;

namespace Property
{
    class BirthdayInfo{
        private string name;
        private DateTime birthday;

        public string Name {
            get {   //읽기전용
                return name;
            }
            set {   //쓰기전용
                name = value;
            }
        }
        public DateTime Birthday {
            get {
                return birthday;
            }
            set {
                birthday = value;
            }
        }

        public int Age {
            get {
                return new DateTime(DateTime.Now.Subtract(birthday).Ticks).Year;
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            BirthdayInfo birth = new BirthdayInfo();
            birth.Name = "수영";   //Name의 set
            birth.Birthday = new DateTime(2000, 10, 19);  //Birthday의 set
       //     birth.Age = 2020;
            Console.WriteLine(birth.Name);  //Name의 get
            Console.WriteLine(birth.Birthday);  //Birthday의 get
            Console.WriteLine(birth.Age);  //Age의 get
        }
    }
}
