using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace XePKL.Areas.Admin.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Mời bạn nhập tài khoản")]
        public string UserName { set; get; }

        [Required(ErrorMessage = "Mời bạn nhập mật khảu")]
        public string PassWord { set; get; }

        public bool RememberMe { set; get; }
    }
}