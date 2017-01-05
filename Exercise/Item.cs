﻿namespace Exercise
{
    public abstract class Item : LibObject, IRegistarable
    {
        public Item(int amount, int year)
        {
            AvailableAmount = amount;
            ObjType = ObjectType.Item;
            YearCreated = year;
        }

        public abstract RegisteredObject GetRegistrationInfo();
    }

    public class Book : Item
    {
        public Book(string author, string title, int year, int amount) : base(amount, year)
        {
            NameOrTitle = title;
            Author = author;
        }
        public string Author { get; set; }

        public override RegisteredObject GetRegistrationInfo()
        {
            return new RegisteredObject
            {
                Info = "Book Name: " + NameOrTitle + " , Author: " + Author + " Year: " + YearCreated,
                AvailableAmount = AvailableAmount
            };
        }
    }

    public class Video : Item
    {
        public Video(string producer, string title, int year, int amount) : base(amount, year)
        {
            NameOrTitle = title;
            Producer = producer;
        }

        public string Producer { get; set; }

        public override RegisteredObject GetRegistrationInfo()
        {
            return new RegisteredObject
            {
                Info = "Title: " + NameOrTitle + ", By: " + Producer + " Year: " + YearCreated,
                AvailableAmount = AvailableAmount
            };
        }

    }
}
