using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DataModel.EF
{
    [MetadataType(typeof(ProductCategory.Metadata))]
    public partial class ProductCategory
    {
        //public bool IsChildren { get; set; }
        sealed class Metadata
        {
            public long ID { get; set; }

            [StringLength(250)]
            [Display(Name = "Tên Danh Mục")]
            public string Name { get; set; }

            [StringLength(250)]
            [Display(Name = "Tên Danh Mục(Không Dấu)")]
            public string MetaTitle { get; set; }

            public long? ParentID { get; set; }

            public int? DisplayOrder { get; set; }

            [StringLength(250)]
            [Display(Name = "Tiêu Đề SEO")]
            public string SeoTitle { get; set; }

            [Display(Name = "Ngày Tạo")]
            public DateTime? CreatedDate { get; set; }

            [StringLength(50)]
            [Display(Name = "Người Tạo")]
            public string CreatedBy { get; set; }

            [Display(Name = "Ngày Cập Nhật")]
            public DateTime? ModifiedDate { get; set; }

            [StringLength(50)]
            [Display(Name = "Người Cập Nhật")]
            public string ModifiedBy { get; set; }

            [StringLength(250)]
            public string MetaKeywords { get; set; }

            [StringLength(250)]
            public string MetaDescriptions { get; set; }
            [Display(Name = "Trạng Thái")]
            public bool? Status { get; set; }
            [Display(Name = "Hiển thị")]

            public bool? ShowOnHome { get; set; }
        }
    }
}
