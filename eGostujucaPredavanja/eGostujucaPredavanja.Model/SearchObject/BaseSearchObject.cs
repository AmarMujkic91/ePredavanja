using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eGostujucaPredavanja.Model.SearchObject
{
    //Paginacija 
    public class BaseSearchObject
    {
        public int? Page { get; set; }

        public int? PageSize { get; set; }
    }
}
