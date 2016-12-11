using Demo.Token.Based.Auth.Owin.Web.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Demo.Token.Based.Auth.Owin.Web.Api.Controllers
{
    public class OrdersController : ApiController
    {
        [Authorize]
        public IHttpActionResult Get()
        {
            return Ok(OrderModel.CreateOrders());
        }
    }
}
