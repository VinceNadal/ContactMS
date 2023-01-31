import { Contact } from "../interfaces/Contact";

interface Props {
  contacts: Contact[];
}

export default function ContactList({ contacts }: Props) {
  return (
    <>
      <h2>Contact List</h2>
      <ul>
        {contacts.map((contact) => (
          <li key={contact.id}>
            <p>First Name: {contact.firstName}</p>
            <p>Last Name: {contact.lastName}</p>
            <p>Physical Address: {contact.physicalAddress}</p>
            <p>Billing Address: {contact.billingAddress}</p>
          </li>
        ))}
      </ul>
    </>
  );
}
