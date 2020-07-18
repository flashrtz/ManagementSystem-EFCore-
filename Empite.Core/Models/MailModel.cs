using System;
using System.Collections.Generic;
using System.Text;

namespace Empit.Core.Models
{
    public class MailModel
    {

    //    public int Id { get; set; }
        public List<string> Recipients { get; set; }
        public string Subject  { get; set; }
        public string Content { get; set; }
      //  public DateTime ToDate { get; set; }

    }
}
