using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessEntity.Product.Master.RequestDTO;
using BusinessService.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ProductAPI.Areas.Product.Controllers
{
    [Area("Product")]
    [Produces("application/json")]
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly ICustomersService _customersService;

        public CustomersController(ICustomersService customersService)
        {
            _customersService = customersService;
        }

        [HttpGet]
        [ActionName("GetAll")]
        public IActionResult GetAll()
        {
            var res = _customersService.GetAll();
            return Ok(res);
        }
        [HttpGet("{Id}")]
        [ActionName("GetById")]
        public IActionResult GetById(long Id)
        {
            var res = _customersService.GetById(Id);
            return Ok(res);
        }
        [HttpPost]
        [ActionName("Save")]
        public IActionResult Post([FromBody] CustomersRequest viewModel)
        {
            var res = _customersService.Add(viewModel);
            return Ok(res);
        }
        [HttpPost]
        [ActionName("Update")]
        public IActionResult Update([FromBody] CustomersRequest viewModel)
        {
            var res = _customersService.Update(viewModel);
            return Ok(res);
        }
        [HttpPost]
        [ActionName("Delete")]
        public IActionResult Delete(Value model)
        {
            var res = _customersService.Delete(model.Id);
            return Ok(res);
        }
    }
}