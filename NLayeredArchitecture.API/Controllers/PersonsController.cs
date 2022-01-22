using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NLayeredArchitecture.API.DTOs;
using NLayeredArchitecture.Core.Models;
using NLayeredArchitecture.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NLayeredArchitecture.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonsController : ControllerBase
    {
        private readonly IService<Person> _service;
        private readonly IMapper _mapper;

        public PersonsController(IService<Person> service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var persons = await _service.GetAllAsync();
            return Ok(_mapper.Map<IEnumerable<PersonDto>>(persons));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var person = await _service.GetByIdAsync(id);
            return Ok(_mapper.Map<PersonDto>(person));
        }

        [HttpPost]
        public async Task<IActionResult> Save(PersonDto personDto)
        {
            var person = await _service.AddAsync(_mapper.Map<Person>(personDto));
            return Created(string.Empty, _mapper.Map<PersonDto>(person));
        }

        [HttpPut]
        public IActionResult Update(PersonDto personDto)
        {
            var person = _service.Update(_mapper.Map<Person>(personDto));
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var product = _service.GetByIdAsync(id).Result;
            _service.Remove(product);
            return NoContent();
        }
    }
}
