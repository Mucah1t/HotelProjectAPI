using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessageCategoryController : ControllerBase
    {
        private readonly IMessageCategoryService _messageCategoryService;

        public MessageCategoryController(IMessageCategoryService messageCategoryService)
        {
            _messageCategoryService = messageCategoryService;
        }

        [HttpGet]
        public IActionResult MessageCategoryList()
        {
            var values = _messageCategoryService.TGetList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddMessageCategory(MessageCategory messageCategory)
        {
            _messageCategoryService.TInsert(messageCategory);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteMessageCategoryList(int id)
        {
            var vDelete = _messageCategoryService.TGetByID(id);
            _messageCategoryService.TDelete(vDelete);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateMessageCategoryList(MessageCategory messageCategory)
        {
            _messageCategoryService.TUpdate(messageCategory);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetMessageCategoryList(int id)
        {
            var vGet = _messageCategoryService.TGetByID(id);
            return Ok(vGet);
        }
    }
}
