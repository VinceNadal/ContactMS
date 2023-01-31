import { useState } from "react";

export default function Form() {
  // create a form that has 4 input fields for firstName, lastName, physicalAddress, billingAddress
  // and a submit button
  // use the useState hook to create state variables for each of the input fields

  // create a state variable for the contact input fields using useState hook
  const [formInputs, setFormInputs] = useState({
    firstName: "",
    lastName: "",
    physicalAddress: "",
    billingAddress: "",
  });

  // create handler function to update state variables
  const handleInputChange = (event: React.ChangeEvent<HTMLInputElement>) => {
    const { id, value } = event.target;
    setFormInputs((prev) => ({ ...prev, [id]: value }));
  };

  // create handler function to handle form submission
  const handleSubmit = (event: React.FormEvent<HTMLFormElement>) => {
    event.preventDefault();
    console.log(formInputs);
  };

  return (
    <form onSubmit={handleSubmit}>
      <label htmlFor="firstName">First Name</label>
      <input
        type="text"
        id="firstName"
        value={formInputs.firstName}
        onChange={handleInputChange}
      />
      <label htmlFor="lastName">Last Name</label>
      <input
        type="text"
        id="lastName"
        value={formInputs.lastName}
        onChange={handleInputChange}
      />
      <label htmlFor="physicalAddress">Physical Address</label>
      <input
        type="text"
        id="physicalAddress"
        value={formInputs.physicalAddress}
        onChange={handleInputChange}
      />
      <label htmlFor="billingAddress">Billing Address</label>
      <input
        type="text"
        id="billingAddress"
        value={formInputs.billingAddress}
        onChange={handleInputChange}
      />

      <button type="submit">Submit</button>
    </form>
  );
}
