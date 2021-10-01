﻿using Congo.WebApi.Data.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Congo.WebApi.Data;
using Congo.WebApi.Data.ProductAccess;

using Congo.WebApi.Commands;


namespace Congo.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class DemoProductController : Controller
    {
        //THIS IS PURELY FOR DEMO PURPOSES 
        //Mediatr is wired up to this controller and our calls made are to a mock DB access layer called DemoProductDataAccess
        private readonly CongoContext _congoDb;
        private readonly IMediator _mediator;//we create this so we cn inject the mediatr service when the project is first built
        public DemoProductController(CongoContext congoDb, IMediator mediator)
        {
            _congoDb = congoDb;
            _mediator = mediator;
        }
        
        [HttpGet]
        public async Task<List<Product>> Get()
        {
            return await _mediator.Send(new GetProductListQuery());
        }
        
    }
}
