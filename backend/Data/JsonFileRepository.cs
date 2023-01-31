using API.Models;
using System.Text.Json;

namespace API.Data
{
    public class JsonFileRepository
    {
        // create a property of List of Contacts
        public List<Contact> Contacts { get; private set; }

        // Create a repository that reads contents inside contacts.json and stores it on Contacts property
        public JsonFileRepository()
        {
            // Read contents of contacts.json file and store it on a string variable
            string json = File.ReadAllText("contacts.json");

            // Deserialize the string variable into a List of Contacts
            Contacts = JsonSerializer.Deserialize<List<Contact>>(json);
        }

        // CRUD
        // Create a method to get all contacts
        public List<Contact> GetAllContacts()
        {
            return Contacts;
        }

        // Create a method to get a single contact
        public Contact GetContact(Guid id)
        {
            // Find the contact in the Contacts property
            return Contacts.Find(contact => contact.Id == id);
        }

        // Create a method to add contact
        public void AddContact(Contact contact)
        {
            // Add the contact to the Contacts property
            Contacts.Add(contact);

            // Write the Contacts property to the contacts.json file
            WriteContacts();
        }

        // Create a method to update contact
        public void UpdateContact(Contact contact)
        {
            // Find the contact in the Contacts property
            var index = Contacts.FindIndex(existingContact => existingContact.Id == contact.Id);

            // Update the contact in the Contacts property
            Contacts[index] = contact;

            // Write the Contacts property to the contacts.json file
            WriteContacts();
        }

        // Create a method to delete contact
        public void DeleteContact(Guid id)
        {
            // Find the contact in the Contacts property
            var index = Contacts.FindIndex(existingContact => existingContact.Id == id);

            // Remove the contact from the Contacts property
            Contacts.RemoveAt(index);

            // Write the Contacts property to the contacts.json file
            WriteContacts();
        }

        // Create a method to save the Contacts property to the contacts.json file
        private void WriteContacts()
        {
            // Serialize the Contacts property into a string
            string json = JsonSerializer.Serialize(Contacts);

            // Write the string to the contacts.json file
            File.WriteAllText("contacts.json", json);
        }
    }
}
