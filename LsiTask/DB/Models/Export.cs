using System;
using System.ComponentModel.DataAnnotations;

namespace LsiTask.DB.Models
{
    public class Export :BaseModel
    {
        public string Name { get; set; }

        public DateTime Date { get; set; }

        public string Username { get; set; }

        public string Local { get; set; }

    }
}
