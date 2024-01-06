using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace NguyenTrungDoan195.Models{
     [Table("SinhVien")]
    public class SinhVien{
        [Key]
        public string MaSinhVien { get; set; }
        [Display(Name = "Mã Sinh Viên")]
        
        public string SoBaoDanh { get; set; }
     
        public double Diem { get; set; }   
    }
}