using ApiDemo.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiDemo.Controllers
{
    [ApiController]
    [Route("api/items")]
    public class ItemsController : ControllerBase
    {
        private readonly List<Item> _items = new List<Item>();

        [HttpGet]
        public IEnumerable<Item> GetItems()
        {
            return _items;
        }

        [HttpGet("{id}")]
        public ActionResult<Item> GetItem(int id)
        {
            var item = _items.FirstOrDefault(x => x.Id == id);
            if(item == null)
            {
                return NotFound();
            }
            return item;
        }

        [HttpPost]
        public IActionResult CreateItem(Item item)
        {
            item.Id = _items.Count + 1;
            _items.Add(item);
            return CreatedAtAction(nameof(GetItem), new { id = item.Id }, item);
        }

    }
}
