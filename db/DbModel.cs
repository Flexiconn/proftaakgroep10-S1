using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EntityFrameworkExample
{
    public class DbModel
    {
        public class plantData
        {
            [Key]
            public string plantID { get; set; }



        }

        public class meetData
        {
            [Key]
            public string deviceNaam { get; set; }
            public float co2Gehalte { get; set; }
            public float zuurstofGehalte { get; set; }
            public string plantID { get; set; }



        }






    }
}
