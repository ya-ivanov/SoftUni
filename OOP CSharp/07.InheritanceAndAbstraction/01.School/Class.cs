namespace School
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    class Class
    {
        private string textIdentifier;
        private HashSet<Student> students;
        private HashSet<Teacher> teachers;

        public Class(string textIdentifier)
        {
            this.TextIdentifier = textIdentifier;
        }

        public Class(string textIdentifier, HashSet<Student> students, HashSet<Teacher> teachers) : this(textIdentifier)
        {
            this.Students = students;
            this.Teachers = teachers;
        }

        public HashSet<Student> Students
        {
            get { return this.students; }
            set
            {
                if (value == null || value.Count == 0)
                    throw new ArgumentException("The class should countain at least one student.");
                this.students = value;
            }
        }

        public HashSet<Teacher> Teachers
        {
            get { return this.teachers; }
            set
            {
                if (value == null || value.Count == 0)
                    throw new ArgumentException("The class should countain at least one teacher.");
                this.teachers = value;
            }
        }

        public string TextIdentifier
        {
            get { return this.textIdentifier; }
            set
            {
                if (value == null || value == "")
                    throw new ArgumentException("The text identifier can't be null or empty.");
                this.textIdentifier = value;
            }
        }

        public override string ToString()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append(String.Format(
                "Text Identifier: {0}\nStudents:\n", this.textIdentifier));

            foreach (var student in this.students)
                strBuilder.AppendLine(student.ToString());

            strBuilder.Append("Teachers:\n");

            foreach (var teacher in this.teachers)
                strBuilder.AppendLine(teacher.ToString());

            return strBuilder.ToString();
        }
    }
}
