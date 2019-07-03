using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Models
{
    public class Content
    {
        public int Id{ get; set; }
        [Display(Name = "名前")]
        [StringLength(32)]
        [MaxLength(32)]
        [Required(ErrorMessage = "名前は必須入力です。")]
        public string Name { get; set; }
        [Display(Name = "コメント")]
        [StringLength(256)]
        [MaxLength(256)]
        [Required(ErrorMessage ="コメントは必須入力です。")]
        public string Comment { get; set; }
        [Display(Name = "投稿日時")]
        public DateTime CreateAt { get; set; }
    }
}
