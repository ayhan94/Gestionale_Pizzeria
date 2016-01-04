using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestionale_Pizzeria.Models.BusinessLogic
{
    public interface IRequest
    {
        void Insert();
        void Modify();
        void Cancel();
    }
}
