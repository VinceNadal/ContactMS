using API.DTOs;
using API.Services;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactsController : ControllerBase
    {
        private readonly JsonContactService _service;

        public ContactsController(JsonContactService service)
        {
            _service = service;
        }

        // Create a read contact http get request handler
        [HttpGet("{id}", Name = "GetContact")]
        public ActionResult<ReadContactDto> GetContact(Guid id)
        {
            var contact = _service.GetContact(id);
            if (contact != null)
            {
                return Ok(contact);
            }
            return NotFound();
        }

        // Create a read all contacts get request handler
        [HttpGet]
        public ActionResult<IEnumerable<ReadContactDto>> GetContacts()
        {
            return Ok(_service.GetContacts());
        }

        // Create a create contact post request handler
        [HttpPost]
        public ActionResult<ReadContactDto> CreateContact(CreateContactDto contactDto)
        {
            var contact = _service.CreateContact(contactDto);
            return CreatedAtRoute(nameof(GetContact), new { Id = contact.Id }, contact);
        }

        // Create an update contact put request handler
        [HttpPut("{id}")]
        public ActionResult UpdateContact(Guid id, UpdateContactDto contactDto)
        {
            var contact = _service.GetContact(id);
            if (contact == null)
            {
                return NotFound();
            }
            _service.UpdateContact(contactDto);
            return NoContent();
        }

        // Create a delete contact delete request handler
        [HttpDelete("{id}")]
        public ActionResult DeleteContact(Guid id)
        {
            var contact = _service.GetContact(id);
            if (contact == null)
            {
                return NotFound();
            }
            _service.DeleteContact(id);
            return NoContent();
        }
    }
}
