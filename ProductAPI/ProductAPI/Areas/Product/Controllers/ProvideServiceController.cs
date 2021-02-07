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
    public class ProvideServiceController : ControllerBase
    {
        private readonly IProvideServiceService _provideServiceService;
        public ProvideServiceController(IProvideServiceService provideServiceService)
        {
            _provideServiceService = provideServiceService;
        }
        [HttpGet]
        [ActionName("GetAll")]
        public IActionResult GetAll()
        {
            var res = _provideServiceService.GetAll();
            return Ok(res);
        }
        [HttpGet("{Id}")]
        [ActionName("GetById")]
        public IActionResult GetById(long Id)
        {
            var res = _provideServiceService.GetById(Id);
            return Ok(res);
        }
        [HttpPost]
        [ActionName("Save")]
        public IActionResult Post([FromBody] ProvideServiceRequest viewModel)
        {
            var res = _provideServiceService.Add(viewModel);
            return Ok(res);
        }
        [HttpPost]
        [ActionName("Update")]
        public IActionResult Update([FromBody] ProvideServiceRequest viewModel)
        {
            var res = _provideServiceService.Update(viewModel);
            return Ok(res);
        }
        [HttpPost]
        [ActionName("Delete")]
        public IActionResult Delete(Value model)
        {
            var res = _provideServiceService.Delete(model.Id);
            return Ok(res);
        }
    }
}