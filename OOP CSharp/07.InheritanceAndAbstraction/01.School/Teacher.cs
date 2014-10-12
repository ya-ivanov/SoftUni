namespace School
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    class Teacher : Person
    {
        private HashSet<Discipline> disciplines;

        public Teacher(string name)
            : base(name)
        { }

        public Teacher(string name, string details)
            : base(name, details)
        { }

        public Teacher(string name, HashSet<Discipline> disciplines, string details = null)
            : this(name, details)
        {
            this.Disciplines = disciplines;
        }

        public HashSet<Discipline> Disciplines
        {
            get { return this.disciplines; }
            set
            {
                if (value == null || value.Count == 0)
                    throw new ArgumentException("There should be at least one discipline.");
                this.disciplines = value;
            }
        }

        public override string ToString()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append(String.Format("Name: {0}, Details: {1}", this.Name, this.Details == null ? "" : this.Details));

            if (this.disciplines != null)
            {
                strBuilder.Append("\nDisciplines:\n");
                foreach (var discipline in this.disciplines)
                    strBuilder.AppendLine(discipline.ToString());
            }
            return strBuilder.ToString();
        }
    }
}
