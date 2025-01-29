﻿using eGostujucaPredavanja.Model.Requests;
using eGostujucaPredavanja.Model.SearchObject;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eGostujucaPredavanja.Services
{                                                                                         //ovo je boxig
    public interface ICRUDService<TModel, TSearch,TInsert,TUpdate> : IService<TModel,TSearch> where TModel : class where TSearch : BaseSearchObject
    {
         TModel Insert(TInsert request);

         TModel Update(int id, TUpdate request);
    }
}
