
using Desaprendiendo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Desaprendiendo.Models.DomainModel;
using Microsoft.AspNetCore.Mvc;

namespace Desaprendiendo.Services.Repository
{
    public class LeccionRepository : GenericRepository<Lección>, ILeccionRepository
    {
        public LeccionRepository(DBContextEF dbContext)
            : base(dbContext)
        {
        }
    }
}

