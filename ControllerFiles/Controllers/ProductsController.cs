using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebapiThetys.BAL;
using WebapiThetys.Model;

namespace WebapiThetys.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductBAL _productBAL;
        public ProductsController(IProductBAL productBAL)
        {
            _productBAL = productBAL;
        }
        [HttpPost]
        public ActionResult Create(ProductRequest products)
        {
            try
            {
                var _products = new Products()
                {
                    Id=Guid.NewGuid(),
                    Pname = products.Pname,
                    Pcategory = products.Pcategory,
                    Price = products.Price,
                    Details = products.Details
                };
                var result = _productBAL.AddProduct(_products);
                if (result != null)
                {

                    return Ok("Successful Adding....");
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (Exception exception)
            {
                return Ok("Exception:" + exception.Message);
            }

        }

        [HttpGet]
        public ActionResult GetAll()
        {
            try
            {               
                var result = _productBAL.GetAll();
                if (result != null)
                {

                    return Ok(result);
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (Exception exception)
            {
                return Ok("Exception:" + exception.Message);
            }
        }

        [HttpGet]
        [Route("{id:guid}")]
        public ActionResult GetId([FromRoute]Guid id)
        {
            try
            {
                var result = _productBAL.GetID(id);
                if (result != null)
                {

                    return Ok(result);
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (Exception exception)
            {
                return Ok("Exception:" + exception.Message);
            }
        }

        [HttpPut]
        [Route("{id:guid}")]
        public ActionResult Modify([FromRoute] Guid id,Products products)
        {
            try
            {
                if (id != products.Id)
                {
                    return BadRequest();
                }
                else
                {
                    var _products = new Products()
                    {
                        Id = products.Id,
                        Pname = products.Pname,
                        Pcategory=products.Pcategory,
                        Price=products.Price,
                        Details=products.Details
                    };
                    var result = _productBAL.Modify(_products);
                    if (result != null)
                    {

                        return Ok("Successful Updating....");
                    }
                    else
                    {
                        return BadRequest();
                    }
                }
                
            }
            catch (Exception exception)
            {
                return Ok("Exception:" + exception.Message);
            }

        }

        [HttpDelete]
        [Route("{id:guid}")]
        public ActionResult Remove([FromRoute] Guid id)
        {
            try
            {
                var result = _productBAL.Remove(id);
                if (result != null)
                {

                    return Ok("Deleted");
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (Exception exception)
            {
                return Ok("Exception:" + exception.Message);
            }
        }
    }
}
