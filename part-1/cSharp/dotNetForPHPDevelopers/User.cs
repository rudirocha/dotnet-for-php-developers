using System;

namespace dotNetForPHPDevelopers
{
    abstract class User
    {
        protected void disableUser()
        {
            // do something
        }
    }

    interface IPerson
    {
        public void doSomething();
    }

    class Person : User, IPerson
    {
        public string FirstName;
        public string LastName;

        protected DateTime createdAt;

        private string token;

        public Person()
        {
             createdAt = DateTime.Now;
        }

        public Person(string theFirstName, string theLastName)
        {
            FirstName = theFirstName;
            LastName = theLastName;
        }

        public Person(string theFirstName, string theLastName, string theToken)
        {
            FirstName = theFirstName;
            LastName = theLastName;
            createdAt = DateTime.Now;
            token = theToken;
        }

        public string GetToken()
        {
            return token;
        }

        public void doSomething()
        {
            // do something
        }
    }
}
