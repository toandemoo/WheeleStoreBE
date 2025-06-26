using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjectBE.Models;

namespace ProjectBE.Services.interfaces
{
    public interface IVnPayService
    {
        string CreatePaymentUrl(PaymentInformationModel model, HttpContext context);
        PaymentResponseModel PaymentExecute(IQueryCollection collections);

    }
}