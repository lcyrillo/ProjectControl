using System;

namespace ProjectControl.Models
{
    public class Profile
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int CreatedBy { get; set; }

        public int? DeletedBy { get; set; }

        public DateTime InputDate { get; set; }

        public DateTime? DeleteDate { get; set; }

        public int Status { get; set; }
    }
}