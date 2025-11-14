using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BeeBuzz.Data.Entities
{
    public class Organization
    {
        [Required]
        public string organizationID { get; set; }

        public int uniqID { get; set; }

    }
}
