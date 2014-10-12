namespace HumanStudentAndWorker
{
    using System;

    public abstract class Human
    {
        private string firstname;
        private string lastname;

        public Human(string firstname, string lastname)
        {
            this.firstname = firstname;
            this.lastname = lastname;
        }

        public string FirstName
        {
            get { return this.firstname; }
            set
            {
                if (value == null || value == "")
                    throw new ArgumentException("Firstname shouldn't be null or empty.");
                this.firstname = value;
            }
        }
        public string LastName
        {
            get { return this.lastname; }
            set
            {
                if (value == null || value == "")
                    throw new ArgumentException("Lastname shouldn't be null or empty.");
                this.lastname = value;
            }
        }

        public override string ToString()
        {
            return String.Format("Firstname: {0}, Lastname: {1}", this.firstname, this.lastname);
        }
    }
}
