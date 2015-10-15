using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_test_task.Models
{
    public class ListModel
    {
        // ID Элемента
        [Key]
        public int applicationId { get; set; }
        // Ф.И.О.
        [Display(Name = "Название")]
        [Required(ErrorMessage = "Поле должно быть установлено")]
        public virtual string full_name { get; set; }
        // Почта
        [Required]
        public string mail { get; set; }
        // Телефон
        [Required]
        public string fone { get; set; }
        // Должность
        [Required]
        public string vacancy { get; set; }
        // Опыт работы
        [Required]
        public string experience { get; set; }
        // Профессиональные навыки
        [Required]
        public string professional_skills { get; set; }
        // Личные качества
        [Required]
        [DataType(DataType.Password)]
        public string personal_qualities { get; set; }
    }
}