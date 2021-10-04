using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Portfolio.Models
{
    public class ContactMe
    {   [Required(ErrorMessage = "لطفا نام خود را وارد کنید")]
        [MaxLength(100,ErrorMessage = "تعداد کلمات بیش از حد مجاز است")]
        [MinLength(5,ErrorMessage = "تعداد کلمات کمتر از حد مجاز است")]
        public string Name { get; set; }

        [Required(ErrorMessage = "لطفا ایمیل خود را وارد کنید")]
        [MaxLength(200, ErrorMessage = "تعداد کلمات بیش از حد مجاز است")]
        [MinLength(5, ErrorMessage = "تعداد کلمات کمتر از حد مجاز است")]
        [EmailAddress(ErrorMessage = "لطفا به صورت ایمیل وارد کنید")]
        public string Email { get; set; }

        [Required(ErrorMessage = "لطفا موضوع  خود را وارد کنید")]
        [MaxLength(500, ErrorMessage = "تعداد کلمات بیش از حد مجاز است")]
        [MinLength(4, ErrorMessage = "تعداد کلمات کمتر از حد مجاز است")]
        public string Subject { get; set; }


        [Required(ErrorMessage = "لطفا پیام خود را وارد کنید")]
        [MinLength(8, ErrorMessage = "تعداد کلمات کمتر از حد مجاز است")]
        public string Message { get; set; }

        public string Service { get; set; }

        public SelectList Services { get; set; }
    }
}
