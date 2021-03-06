﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HireAVehicle.Entity;

namespace HireAVehicle.Repository.Interfaces
{
    public interface IPaymentRepository : IRepository<Payment>
    {
        bool PaymentMethodSelect(Ride ride);
    }
}
