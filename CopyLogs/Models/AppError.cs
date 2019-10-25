using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CopyLogs.Models
{
    public class AppError
    {
        [Column("id_appError")]
        public Guid Id { get; set; }

        [Column("errorText")]
        public string ErrorText {get; set;}

        [Column("datetime")]
        public DateTime DateTime { get; set; }
    }
}
