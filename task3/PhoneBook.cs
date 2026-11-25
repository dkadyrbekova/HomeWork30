using System;
using System.Collections.Generic;

namespace task3
{
    public class PhoneBook
    {
        private List<Contact> contacts = new List<Contact>();

        public int Count
        {
            get { return contacts.Count; }
        }
        // получить / изменить контакт по позиции
        public Contact this[int index]
        {
            get
            {
                if (index < 0 || index >= contacts.Count)
                    throw new IndexOutOfRangeException("Индекс вне диапазона.");
                return contacts[index];
            }
            set
            {
                if (index < 0 || index >= contacts.Count)
                    throw new IndexOutOfRangeException("Индекс вне диапазона.");
                contacts[index] = value;
            }
        }

        // получить контакт по имени (регистр важен)
        public Contact this[string name]
        {
            get
            {
                foreach (var contact in contacts)
                {
                    if (contact.Name == name)
                        return contact;
                }
                throw new KeyNotFoundException($"Контакт с именем '{name}' не найден.");
            }
        }

        public void Add(Contact contact)
        {
            contacts.Add(contact);
        }

        public void Remove(Contact contact)
        {
            contacts.Remove(contact);
        }

        public void Remove(string name)
        {
            Remove(this[name]);
        }
    }
}