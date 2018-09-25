using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrameerPuzzels2
{
    class Scientist
    {
        // Fields
        private string name;
        private int birthYear;
        private int deathYear;

        // Properties
        public string Name { get => name; set => name = value; }
        public int BirthYear { get => birthYear; set => birthYear = value; }
        public int DeathYear { get => deathYear; set => deathYear = value; }


        // Constructor
        public Scientist(string name, int birthYear, int deathYear)
        {
            this.name = name;
            this.birthYear = birthYear;
            this.deathYear = deathYear;
        }

    }
}
