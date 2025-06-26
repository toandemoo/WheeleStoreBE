using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Project.Services.interfaces;
using ProjectBE.Models;
using ProjectBE.Services.interfaces;

namespace ProjectBE.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PaymentController : ControllerBase
    {
        private readonly IVnPayService _vnPayService;
        private readonly IOrderService _orderService;
        public PaymentController(IVnPayService vnPayService, IOrderService orderService)
        {

            _vnPayService = vnPayService;
            _orderService = orderService;
        }

        [HttpPost]
        [Authorize]
        public IActionResult CreatePaymentUrlVnpay(PaymentInformationModel model)
        {
            var url = _vnPayService.CreatePaymentUrl(model, HttpContext);

            return Ok(new { url = url });
        }


        [HttpGet]
        public async Task<IActionResult> PaymentCallbackVnpay()
        {
            var response = _vnPayService.PaymentExecute(Request.Query);

            if (response.Success)
            {
                await _orderService.Update(Project.Entities.OrderStatusEnum.Confirmed, int.Parse(response.OrderId));
            }
            // return Ok(response);
            return Redirect("http://localhost:5173/payment");
        }

    }
}