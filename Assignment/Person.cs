using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Assignment
{
    #region Question 1
    //1.Define a struct "Person" with properties "Name" and "Age". Create an array of three "Person" objects and
    //populate it with data.Then, write a C# program to display the details of all the persons in the array.

    #endregion
    internal struct Person
    {
        #region Attributes
        private string?[] name;
        private int?[] age;
        private int size;
        #endregion

        #region constructor
        public Person(int size)
        {
            this.size = size;
            name = new string?[size];
            age = new int?[size];
        }
        
        #endregion


        #region properties
        public int Size { get { return size; } }

        public string this[int index]
        {
            get
            {
                return $"Person Name is: {name[index]} And his age is {age[index]}";
            }
        }

        #endregion

        #region methods
        public void addPerson(int position, string PersonName, int PersonAge)
        {
            if(name is not null && age is not null)
            {
                if (position >= 0 && position < size) {
                    name[position] = PersonName;
                    age[position] = PersonAge;
                }
            }
        }

        public string getOlderAge() {
            int? oldestAge = age[0];
            for (int i = 1; i < age.Length; i++) {
                if (age[i] > oldestAge)
                {
                    oldestAge = age[i];
                }
                
            }
            return $"Oldest age is {oldestAge}";

        }
        #endregion


    }
}
