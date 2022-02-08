using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Intergration.Models
{
    public class Customer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }
        public int Age { get; set; }
        public string Comment { get; set; }
        public string Name { get; set; }
        public string DoctorName { get; set; }
        public string Gender { get; set; }
        public string Mobile { get; set; }
        public string Telephone { get; set; }
        public string AgeLable { get; set; }
        public string Code { get; set; }
        public string Address { get; set; }
        public ICollection<CallComment> CallComments { get; set; }

    }

}
