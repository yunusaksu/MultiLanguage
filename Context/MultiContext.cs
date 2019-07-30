using MultiLanguageYeniCodeFirst.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MultiLanguageYeniCodeFirst.Context
{
    public class MultiContext : DbContext
    {
        public DbSet<Yazi> Yazis { get; set; }
        public DbSet<Language> Languages { get; set; }
    }
}