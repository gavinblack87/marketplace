using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using IgsApi.Models;
using Microsoft.EntityFrameworkCore;

namespace IgsApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IgsController : ControllerBase
    {
        private readonly ItemContext _context;

        public IgsController(ItemContext context) => _context = context;
    
        //GET: api/items
        [HttpGet]
        public ActionResult<IEnumerable<Item>> GetItems()
        {
            return _context.Items;
        }

        //GET:      api/items/n
        [HttpGet("{id}")]
        
        public ActionResult<Item> GetItems(int id)
        {
            var itemsItem = _context.Items.Find(id);

            if (itemsItem == null)
            {
                return NotFound();
            }

            return itemsItem;
        }
        
        //POST:     api/items
        [HttpPost]
        public ActionResult<Item> PostItem(Item item)
        {
            _context.Items.Add(item);
            _context.SaveChanges();

            return CreatedAtAction("GetItem", new Item{Id = item.Id}, item);
        }

        //PUT:      api/items/n
        [HttpPut("{id}")]
        public ActionResult PutItem(int id, Item item)
        {
            if (id != item.Id)
            {
                return BadRequest();
            }

            _context.Entry(item).State = EntityState.Modified;
            _context.SaveChanges();

            return NoContent();
        }

        //DELETE:   api/commands/n
        [HttpDelete("{id}")]
        public ActionResult<Item> DeleteItem(int id)
        {
            var item = _context.Items.Find(id);

            if (item == null)
            {
                return NotFound();
            }

            _context.Items.Remove(item);
            _context.SaveChanges();

            return item;
        }
    }
    }
