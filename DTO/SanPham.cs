﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class SanPham
    {
        public string MaSanPham {  get; set; }
        public string MaLoaiSanPham { get; set; }
        public string TenSanPham { get; set; }
        public string DonViTinh {  get; set; }
        public decimal GiaBan { get; set; }
        public int SoLuong {  get; set; }
        public byte[] Anh {  get; set; }
        public string TrangThai { get; set; }

        public SanPham() 
        {
            MaSanPham = string.Empty;
            MaLoaiSanPham = string.Empty;
            TenSanPham= string.Empty;
            DonViTinh = string.Empty;
            Anh = [];
            TrangThai = "Chờ xử lý";
        }

        public SanPham(string maSanPham, string maLoaiSanPham, string tenSanPham, string donViTinh, decimal giaBan, int soLuong, byte[] anh, string trangThai)
        {
            MaSanPham = maSanPham;
            MaLoaiSanPham = maLoaiSanPham;
            TenSanPham = tenSanPham;
            DonViTinh = donViTinh;
            GiaBan = giaBan;
            SoLuong = soLuong;
            Anh = anh;
            TrangThai = trangThai;
        }
    }
}
