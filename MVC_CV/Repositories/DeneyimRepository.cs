using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVC_CV.Models.Entity; // Assuming TblDeneyimler is defined in this namespace

namespace MVC_CV.Repositories
{
    public class DeneyimRepository : GenericRepository<TblDeneyimler>
    {
        DbCvEntities db = new DbCvEntities(); // Assuming DbCvEntities is your database context
        

    }
}