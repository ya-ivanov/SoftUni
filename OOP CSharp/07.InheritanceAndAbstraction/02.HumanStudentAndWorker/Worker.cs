namespace HumanStudentAndWorker
{
    using System;

    class Worker : Human
    {
        private double weekSalary;
        private double workHoursPerDay;

        public Worker(string firstname, string lastname, double weekSalary, double workHoursPerDay)
            : base(firstname, lastname)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public double WeekSalary
        {
            get { return this.weekSalary; }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("The week salary shoud be zero or positive.");
                this.weekSalary = value;
            }
        }
        public double WorkHoursPerDay
        {
            get { return this.workHoursPerDay; }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("The worker should work at least one hour per day.");
                this.workHoursPerDay = value;
            }
        }
        public double MoneyPerHour()
        {
            return this.WeekSalary / (5 * this.WorkHoursPerDay);
        }

        public override string ToString()
        {
            return String.Format(
                "Firstname: {0}, Lastname: {1}\nMoney Per Hour: {2}, Week Salary: {3}, Work hours per day: {4}",
                this.FirstName, this.LastName, this.MoneyPerHour(), this.WeekSalary, this.WorkHoursPerDay);
        }
    }
}
