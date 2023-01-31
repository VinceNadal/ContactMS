using API.Data;
using API.DTOs;
using API.Models;
using AutoMapper;

namespace API.Services
{
    public class JsonContactService
    {
        // Use JsonFileRepository to read and write data
        private readonly JsonFileRepository _repository;
        private readonly IMapper _mapper;

        public JsonContactService(JsonFileRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public ReadContactDto GetContact(Guid id)
        {
            return _mapper.Map<ReadContactDto>(_repository.GetContact(id));
        }

        public ReadContactDto UpdateContact(UpdateContactDto contactDto)
        {
            var contact = _mapper.Map<Contact>(contactDto);
            _repository.UpdateContact(contact);
            return _mapper.Map<ReadContactDto>(contact);
        }

        public ReadContactDto CreateContact(CreateContactDto contactDto)
        {
            var contact = _mapper.Map<Contact>(contactDto);
            _repository.AddContact(contact);
            return _mapper.Map<ReadContactDto>(contact);
        }

        public void DeleteContact(Guid id)
        {
            _repository.DeleteContact(id);
        }

        // Get all contacts
        public List<ReadContactDto> GetContacts()
        {
            return _mapper.Map<List<ReadContactDto>>(_repository.GetAllContacts());
        }
    }
}
