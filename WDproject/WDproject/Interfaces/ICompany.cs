using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WDproject.Models;
namespace WDproject.Interfaces
{
    public interface ICompany
    {
        double Capital { get; set; }   
        CompanyStatus Status { get;  set; }
    }
}
