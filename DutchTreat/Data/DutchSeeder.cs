using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DutchTreat.Data
{
    public class DutchSeeder
    {
        private readonly DutchContext _dutchContext;

        public DutchSeeder(DutchContext dutchContext)
        {
            _dutchContext = dutchContext;
        }   
    }
}
