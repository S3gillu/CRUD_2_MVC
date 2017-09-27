using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication2.Models;
using System.Data.Entity;
namespace WebApplication2.Models
{
    public class Context :Dbcontext

    {
        public Context()
            : base("Context")
        {
        }
      public Dbset <employe> Employes { get; set; }


    }
}