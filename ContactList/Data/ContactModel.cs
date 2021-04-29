using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactList.Data
{
    public class ContactModel
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Имя")]
        public string Name { get; set; }
        [Display(Name = "Фамилия")]
        public string Surname { get; set; }
        [Display(Name = "Отчество")]
        public string Patronymic { get; set; }
        [Display(Name = "Дата рождения")]
        [DataType(DataType.Date)]
        public DateTime Birthday { get; set; }
        [Display(Name = "Компания")]
        public string Company { get; set; }
        [Display(Name = "Должность")]
        public string Position { get; set; }
        [Required]
        [Display(Name = "Номер телефона")]
        public string Phone { get; set; }
        [Display(Name = "Дополнительный номер")]
        public string DopPhone { get; set; }
        [Display(Name = "Почта")]
        public string Email { get; set; }
        [Display(Name = "Дополнительная почта")]
        public string DopEmail { get; set; }
        [Display(Name = "Skype")]
        public string Skype { get; set; }
        [Display(Name = "Дополнительный Skype")]
        public string DopSkype { get; set; }
        [Display(Name = "Другое")]
        public string Other { get; set; }
    }
}
