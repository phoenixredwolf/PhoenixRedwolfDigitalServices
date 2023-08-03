using System.ComponentModel.DataAnnotations;

namespace PhoenixRedwolfDigitalServices.Models
{
    public class Contact
    {
        [Required]
        public string Name { get; set; } = string.Empty;
        public string Company { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string State { get; set; } = string.Empty;
        public int Zip { get; set; } = 00000;
        public string OfficePhone { get; set; } = string.Empty;
        public string CellPhone { get; set; } = string.Empty;
        [Required]
        public string Details { get; set; } = string.Empty;
        public DateTime Date { get; set; }
        public DateTime Time { get; set; }
    }
}
