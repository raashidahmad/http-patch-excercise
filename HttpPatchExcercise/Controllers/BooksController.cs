﻿using HttpPatchExcercise.Models;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace HttpPatchExcercise.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        public BooksController() { }

        [HttpGet]
        public IActionResult Get()
        {
            return new ObjectResult(this.GetBook());
        }

        [HttpPatch]
        public IActionResult PatchBook([FromBody] JsonPatchDocument<Book> data)
        {
            var book = this.GetBook();
            if (data != null)
            {
                data.ApplyTo(book, ModelState);
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
            }
            return Ok(book);
        }

        private Book GetBook()
        {
            return new Book() { Id = 1, Title = "Databases", Description = "Description of the Book", Author = "Some Author" };
        }
    }
}