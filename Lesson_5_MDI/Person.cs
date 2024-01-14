using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_5_MDI
{
    [Serializable]
    public class Person
    {
        public string Surname { get; set; }
        public string Name { get; set; }
        public string SecondName { get; set; }
        public DateTime DateBorn { get; set; }
        public string PlaceBorn { get; set; }

    }
}
