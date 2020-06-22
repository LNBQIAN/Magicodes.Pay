﻿using System.Collections.Generic;
using System.Threading.Tasks;
using Magicodes.Pay.Allinpay.Dto;

namespace Magicodes.Pay.Allinpay
{
    public interface IAllinpayAppService
    {
        Task<WeChatMiniPayOutput> WeChatMiniPay(WeChatMiniPayInput input);

        Task<JsApiPayOutput> WeChatJsApiPay(JsApiPayInput input);

        bool PayNotifyHandler(Dictionary<string, string> dic);
    }
}
