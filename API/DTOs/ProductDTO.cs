using Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace DTOs
{
    public class ProductDTO
    {
        public int id { get; set; }
        public string Name { get; set; }

        public int Amount { get; set; }
        public decimal Price { get; set; }

        public string Details { get; set; }

        public string Image { get; set; }
        public string Status { get; set; }

        // Thiet lap quan he 1-n, mot loai san pham co nhieu san pham
        public int Category_Id { get; set; }
        public virtual Category Category { get; set; }

    }
}