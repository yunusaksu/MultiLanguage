using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MultiLanguageYeniCodeFirst.Models
{
    public class Yazi
    {
        public int YaziId { get; set; }
        public string Title { get; set; }
        [Display(Name = "İçerik")]
        public string Icerik { get; set; }

        [ForeignKey("Language")]
        public int LangId { get; set; }
        public virtual Language Language { get; set; }
    }
}