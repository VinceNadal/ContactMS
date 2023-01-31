import { useState } from "react";
import ContactList from "./components/ContactList";
import Form from "./components/Form";
import { Contact } from "./interfaces/Contact";

function App() {
  const [contacts, setContacts] = useState<Contact[]>([]);

  return (
    <div className="App">
      <h1>Contact Management System</h1>

      <Form />
      <ContactList contacts={contacts} />
    </div>
  );
}

export default App;
