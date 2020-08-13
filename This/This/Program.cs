using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace This
{
    class Program
    {   //p238
        class Employee
        {
            private string Name;
            private string Position;

            public void SetName(string Name) {
                this.Name = Name;
            }

            public string GetName()
            {
                return Name;
            }

            public void SetPosition(string Position) {
                this.Position = Position;
            }

            public string GetPosition() {
                return this.Position;
            }
        }
        static void Main(string[] args)
        {
        }
    }
}
