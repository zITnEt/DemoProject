﻿using DemoApplication.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApplication.Requests.ConsumerRequests
{
    public class AddBalanceRequest: IRequest<bool>
    {
        public AddBalanceModel AddBalanceModel { get; set; }        
    }
}
