using BaiTap_CodeFirst_ThanhGiang.Models;
using Microsoft.EntityFrameworkCore;

namespace BaiTap_CodeFirst_ThanhGiang.Data_access
{
    public class QLNhanVienDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseSqlServer("Data Source=LAPTOP-9TOR6RJG;Initial Catalog=QuanLyNhanSu;Integrated Security=True;Encrypt=False");
        }
        public DbSet<CongTy> CongTy { get; set; }
        public DbSet<PhongBan> PhongBan { get; set; }
        public DbSet<NhanVien> NhanVien { get; set;}
    }
}
