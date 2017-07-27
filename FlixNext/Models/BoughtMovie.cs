using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FlixNext.Models
{
    public class BoughtMovie
    {
        [Key]
        public int BoughtMovieID { get; set; }
        public double ReceiptNumber { get; set; }
        public double CostToBuy { get; set; }
        public bool Bought { get; set; }
        public DateTime BoughtDate { get; set; }

        [ForeignKey("Account")]
        public int AccountID { get; set; }
        public virtual ICollection<Account> Accounts { get; set; }

        [ForeignKey("MovieList")]
        public int MovieListID { get; set; }
        public virtual MovieList MovieList { get; set; }

    }
}