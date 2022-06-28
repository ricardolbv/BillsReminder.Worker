using System;
using System.Collections.Generic;
using System.Threading.Tasks;

public interface ICpflService
{
	Task<List<EnergyBill>> GetOpenedCpflBills();
}
