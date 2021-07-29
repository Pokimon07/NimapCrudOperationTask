

namespace NimapCurdOperation.EntityModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    public partial class tbl_Products
    {
        

        public int ProductId { get; set; }
         [Required(ErrorMessage = "Please Enter Product Name")]
         [StringLength(50, ErrorMessage = "Please Enter only 50 character or Number")]
        public string ProductName { get; set; }
         [Required(ErrorMessage = "Please Enter Category Id")]
         [StringLength(50, ErrorMessage = "Please Enter only 50 character or Number")]
        public string CategoryId { get; set; }
                [Required(ErrorMessage = "Please Enter Category Name")]
        [StringLength(50,ErrorMessage = "Please Enter only 50 character or Number")]
        public string CategoryName { get; set; }
    }
}
