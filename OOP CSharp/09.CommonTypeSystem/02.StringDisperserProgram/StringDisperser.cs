namespace StringDisperserProgram
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Collections;

    public class StringDisperser : IEnumerable<char>, ICloneable, IComparable<StringDisperser>
    {
        private List<string> strings;
        private string chars;

        public StringDisperser(params string[] args)
        {
            this.Strings = args.ToList();
            this.strings.ForEach(x => this.chars += x);
        }

        public StringDisperser Clone()
        {
            return new StringDisperser(this.chars);

        }

        object ICloneable.Clone()
        {
            return this.Clone();
        }

        public string Chars
        {
            get { return this.chars; }
            set { this.chars = value; }
        }

        public List<string> Strings
        {
            get { return this.strings; }
            set
            {
                if (value.Contains(null))
                    throw new ArgumentNullException("There is a null paramether passes as a string!");
                this.strings = value;
            }
        }

        public char this[int index]
        {
            get { return this.chars.ElementAt(index); }
            set { this.chars = this.chars.Substring(0, value) + value + this.chars.Substring(value + 1); }
        }

        public override bool Equals(object obj)
        {
            StringDisperser stringDisperser = obj as StringDisperser;

            if (stringDisperser == null)
            {
                return false;
            }

            if (!Object.Equals(this.chars, stringDisperser.chars))
            {
                return false;
            }

            return true;
        }

        public override int GetHashCode()
        {
            int hashCode = (this.chars ?? "").GetHashCode();

            return hashCode;
        }

        public IEnumerator<char> GetEnumerator()
        {
            for (int i = 0; i < this.chars.Length; i++)
            {
                yield return this.chars[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public int CompareTo(StringDisperser other)
        {
            int compareResult = string.Compare(this.chars, other.chars);

            if (compareResult != 0)
            {
                return compareResult;
            }

            return 0;
        }

        public static bool operator ==(StringDisperser stringDisperser, StringDisperser otherString)
        {
            return StringDisperser.Equals(stringDisperser, otherString);
        }

        public static bool operator !=(StringDisperser stringDisperser, StringDisperser otherString)
        {
            return !StringDisperser.Equals(stringDisperser, otherString);
        }
    }
}
