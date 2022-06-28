using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Bills.Reminder.Worker.Core.Application.Cpfl
{
    public class CpflService : ICpflService
    {
        public Task<List<EnergyBill>> GetOpenedCpflBills()
        {
            throw new NotImplementedException();
        }
    }
}
