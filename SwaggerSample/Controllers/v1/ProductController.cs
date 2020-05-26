using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SwaggerSample.Models;
using System;
using System.Collections.Generic;

namespace SwaggerSample.Controllers.v1
{
    /// <summary>
    /// Api Product, retorna e adiciona produtos
    /// </summary>
    [Route("v1/products")]
    public class ProductController : Controller
    {
        private static readonly List<Product> _products = new List<Product>()
        {
            new Product("Copo", "Copo legal", 10.000M),
            new Product("Moletom", "Moletom GAP preto", 25.000M),
            new Product("Teckpix", "Nem preciso falar nada", 50.000M),
        };

        /// <summary>
        /// Retorna a lista com todos os produtos
        /// </summary>
        /// <returns>products</returns>
        [HttpGet]
        [Route("")]
        public ActionResult<List<Product>> GetProducts()
        {
            return _products;
        }

        /// <summary>
        /// Adiciona um novo produto
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///     POST /Todo
        ///     {
        ///        "id": 1,
        ///        "name": "Item1",
        ///        "isComplete": true
        ///     }
        ///
        /// </remarks>
        /// <param name="product">É um produto :D</param>
        [HttpPost]
        [Route("")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [Produces("application/json")]
        public IActionResult AddProduct([FromBody] Product product)
        {
            if (product == null)
            {
                throw new ArgumentNullException("The product cannot be null");
            }

            _products.Add(product);

            return Ok(product);
        }
    }

    
}
