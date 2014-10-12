namespace CustomerProgram
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Customer : ICloneable, IComparable<Customer>
    {
        private string firstName;
        private string middleName;
        private string lastName;
        private long id;
        private string permanentAddress;
        private string mobileNumber;
        private string email;
        private List<Payment> payments;
        private CustomerType customerType;
        private string originalName;
        private string originalMiddleName;
        private string originalLastName;
        private long originalID;
        private string originalAddress;
        private string originalMobilPhone;
        private string originalEmail;
        private List<Payment> originalPayments;
        private global::CustomerProgram.CustomerType originalType;

        object ICloneable.Clone()
        {
            return this.Clone();
        }

        public Customer(string name, string middleName, string lastName, long id, string address, string num, string mail, List<Payment> payments, global::CustomerProgram.CustomerType type)
        {
            this.FirstName = name;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.ID = id;
            this.PermanentAddress = address;
            this.MobileNumber = num;
            this.Email = mail;
            this.Payments = payments;
            this.CustomerType = type;
        }

        public string FirstName
        {
            get { return this.firstName; }
            set { this.firstName = value; }
        }

        public string MiddleName
        {
            get { return this.middleName; }
            set { this.middleName = value; }
        }

        public string LastName
        {
            get { return this.lastName; }
            set { this.lastName = value; }
        }

        public long ID
        {
            get { return this.ID; }
            set { this.id = value; }
        }

        public string PermanentAddress
        {
            get { return this.permanentAddress; }
            set { this.permanentAddress = value; }
        }

        public string MobileNumber
        {
            get { return this.mobileNumber; }
            set { this.mobileNumber = value; }
        }

        public string Email
        {
            get { return this.email; }
            set { this.email = value; }
        }

        public List<Payment> Payments
        {
            get { return this.payments; }
            set { this.payments = value; }
        }

        public CustomerType CustomerType
        {
            get { return this.customerType; }
            set { this.customerType = value; }
        }

        public override bool Equals(object param)
        {
            Customer customer = param as Customer;

            if (customer == null)
            {
                return false;
            }

            List<Object> props = new List<Object> { this.FirstName, this.MiddleName, this.LastName, this.ID, this.PermanentAddress, 
                                                    this.MobileNumber, this.Email, this.Payments, this.CustomerType };
            List<Object> cProps = new List<Object> { customer.FirstName, customer.MiddleName, customer.LastName, customer.ID, customer.PermanentAddress, 
                                                     customer.MobileNumber, customer.Email, customer.Payments, customer.CustomerType };
            for (int i = 0; i < props.Count; i++)
                if (!Object.Equals(props[i], cProps[i]))
                    return false;
            
            return true;
        }

        public static bool operator ==(Customer a, Customer b)
        {
            if (a.Equals(b))
                return true;

            return false;
        }

        public static bool operator !=(Customer a, Customer b)
        {
            if (a.Equals(b))
                return false;

            return true;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            List<Object> props = new List<Object> { this.FirstName, this.MiddleName, this.LastName, this.ID, this.PermanentAddress, 
                                                    this.MobileNumber, this.Email, this.Payments, this.CustomerType };


            foreach (var prop in props)
                sb.Append(prop + ", ");


            return sb.ToString();
        }

        public override int GetHashCode()
        {
            return this.FirstName.GetHashCode() ^ this.LastName.GetHashCode() ^
                   this.ID.GetHashCode() ^ this.PermanentAddress.GetHashCode() ^ this.MobileNumber.GetHashCode() ^
                   this.Email.GetHashCode() ^ this.Payments.GetHashCode() ^ this.CustomerType.GetHashCode();
        }

        public Customer Clone()
        {
            Customer original = this;
            var originalName = original.firstName;
            var originalMiddleName = original.middleName;
            var originalLastName = original.lastName;
            var originalID = original.id;
            var originalAddress = original.permanentAddress;
            var originalMobilPhone = original.mobileNumber;
            var originalEmail = original.email;
            var originalPayments = original.payments;
            var originalType = original.customerType;
            Customer result = new Customer(originalName, originalMiddleName, originalLastName, originalID,
                                           originalAddress, originalMobilPhone, originalEmail, originalPayments, originalType);
            return result;
        }

        public int CompareTo(Customer customer)
        {
            if (!Object.Equals(this.FirstName, customer.FirstName))
            {
                return this.FirstName.CompareTo(customer.FirstName);
            }
            if (!Object.Equals(this.MiddleName, customer.MiddleName))
            {
                return this.MiddleName.CompareTo(customer.MiddleName);
            }
            if (!Object.Equals(this.LastName, customer.LastName))
            {
                return this.LastName.CompareTo(customer.LastName);
            }
            if (!Object.Equals(this.ID, customer.ID))
            {
                return customer.ID.CompareTo(this.ID);
            }
            return 0;
        }

    }
} 