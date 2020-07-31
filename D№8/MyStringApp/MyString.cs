using System;

namespace MyStringApp
{
    class MyString
    {
        private char[] valueC { get; set; }

        //наверное не так надо было делать?
        public char this[int index]
        {
            get
            {
                return valueC[index];
            }
            set
            {
                valueC[index] = value;
            }
        }

        public int Length {
            get
            {
                return valueC.Length;
            }
        }

        public MyString()
        {

        }

        public static MyString Name
        {
            get
            {
                return new MyString { valueC = new char[] { 'П','Р','И','В','Е','Т'} };
            }
        }

        //капец 
        public static implicit operator MyString(string sourse)
        {
            char[] arrChar = new char[sourse.Length];
            for (int i = 0; i < sourse.Length; i++)
            {
                arrChar[i] = sourse[i];
            }

            return new MyString
            {
                valueC = arrChar
            };
        }

        public MyString(string Value)
        {
            valueC = new char[Value.Length];
            for (int i = 0; i < Value.Length; i++)
            {
                valueC[i] = Value[i];
            } 
        }
        
        public bool Contains(char s)
        {
            if (char.Equals(valueC, s)) return true;
            return false;   
        }

        public bool Contains(string s)
        {
            if (s.Length <= Length)
            {
                if (string.Equals(s,Convert.ToString(valueC))) return true;
            }
            return false;
        }

        public int IndexOf(char s)
        {
            for (int i = 0; i < valueC.Length; i++)
            {
                if (char.Equals(valueC[i], s)) return i;
            }
            throw new ArgumentException();
        }

        public string Concat(string s)
        {
            string valueS = "";
            for (int i = 0; i < valueC.Length; i++)
            {
                valueS += Convert.ToString(valueC[i]);
            }
            return valueS + s;
        }

        public void CopyTo(ref char[] arrChar, int index)
        {
            if (arrChar.Length <= index)
                throw new ArgumentException();

            int count = 0;
            for (int i = index; i < arrChar.Length; i++)
            {
                if (count >= valueC.Length) return;
                arrChar[i] = valueC[count];
                count++;
            }
        }

        public void CopyTo(ref MyString arrChar, int index)
        {
            if (arrChar.Length <= index)
                throw new ArgumentException();

            int count = 0;
            for (int i = index; i < arrChar.Length; i++)
            {
                if (count >= valueC.Length) return;
                arrChar[i] = valueC[count];
                count++;
            }
        }

        public static MyString operator +(MyString c1, MyString c2)
        {
            
            var c3 = new char[c1.Length + c2.Length];
            c1.CopyTo(ref c3, 0);
            c2.CopyTo(ref c3, c2.Length);
            return new MyString { valueC = c3 };
        }

        public override string ToString()
        {
            string valueS = "";
            for (int i = 0; i < valueC.Length; i++)
            {
                valueS += Convert.ToString(valueC[i]);
            }
            return valueS;
        }

    }
}
