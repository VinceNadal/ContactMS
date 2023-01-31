import { CreateContact } from './../interfaces/CreateContact';
import axios from "axios";
import { Contact } from "../interfaces/Contact";

// create axios configuration
export const api = axios.create({
  baseURL: 'http://localhost:5000/api',
});

// Asynchronous function to get all contacts from the api
export const getContacts = async (): Promise<Contact[]> => {
  const response = await api.get('/contacts');
  return response.data;
}

// Asynchronous function to get a single contact from the api
export const getContact = async (id: string): Promise<Contact> => {
  const response = await api.get(`/contacts/${id}`);
  return response.data;
}

// Asynchronous function to create a new contact
export const createContact = async (contact: CreateContact): Promise<Contact> => {
  const response = await api.post('/contacts', contact);
  return response.data;
}

// Asynchronous function to update a contact
export const updateContact = async (contact: Contact): Promise<Contact> => {
  const response = await api.put(`/contacts/${contact.id}`, contact);
  return response.data;
}

// Asynchronous function to delete a contact
export const deleteContact = async (id: string): Promise<void> => {
  await api.delete(`/contacts/${id}`);
}