﻿using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
  public interface ICategoryBL
    {
        public Task<List<Category>> GetAllBL();
    }
}
