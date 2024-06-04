using OfficeOpenXml;
using QuanLyPhongTro.DTO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyPhongTro.BLL
{
    public class ExcelHelper
    {
        private string _excelFilePath;

        public ExcelHelper(string excelFilePath)
        {
            _excelFilePath = excelFilePath;
        }

        public void UpdateCustomerInfo(Customer customer)
        {
            try
            {
                if (!File.Exists(_excelFilePath))
                {
                    MessageBox.Show("Lỗi: Không tìm thấy file Excel.");
                    return;
                }

                using (var excelPackage = new ExcelPackage(new FileInfo(_excelFilePath)))
                {
                    var worksheet = excelPackage.Workbook.Worksheets.FirstOrDefault();
                    if (worksheet == null)
                    {
                        // Tạo worksheet mới nếu không có worksheet
                        worksheet = excelPackage.Workbook.Worksheets.Add("Sheet1");
                    }

                    // Kiểm tra số hàng để thêm vào hàng tiếp theo
                    int rowIndex = FindCustomerRow(worksheet, customer.MaKH);

                    if (rowIndex > 0)
                    {
                        // Cập nhật dữ liệu khách hàng nếu đã tồn tại
                        worksheet.Cells[$"B{rowIndex}"].Value = customer.HoTenKH;
                        worksheet.Cells[$"C{rowIndex}"].Value = customer.GioiTinhKH;
                        worksheet.Cells[$"D{rowIndex}"].Value = customer.NgaySinh.ToString("yyyy-MM-dd");
                        worksheet.Cells[$"E{rowIndex}"].Value = customer.QueQuan;
                        worksheet.Cells[$"F{rowIndex}"].Value = customer.CMND;
                        worksheet.Cells[$"G{rowIndex}"].Value = customer.SDT;
                        worksheet.Cells[$"H{rowIndex}"].Value = customer.SoThangThue;
                        worksheet.Cells[$"I{rowIndex}"].Value = customer.MaP;
                    }
                    else
                    {
                        // Thêm khách hàng mới vào cuối file
                        int newRow = worksheet.Dimension == null ? 1 : worksheet.Dimension.End.Row + 1;

                        worksheet.Cells[$"A{newRow}"].Value = customer.MaKH;
                        worksheet.Cells[$"B{newRow}"].Value = customer.HoTenKH;
                        worksheet.Cells[$"C{newRow}"].Value = customer.GioiTinhKH;
                        worksheet.Cells[$"D{newRow}"].Value = customer.NgaySinh.ToString("yyyy-MM-dd");
                        worksheet.Cells[$"E{newRow}"].Value = customer.QueQuan;
                        worksheet.Cells[$"F{newRow}"].Value = customer.CMND;
                        worksheet.Cells[$"G{newRow}"].Value = customer.SDT;
                        worksheet.Cells[$"H{newRow}"].Value = customer.SoThangThue;
                        worksheet.Cells[$"I{newRow}"].Value = customer.MaP;
                    }

                    // Lưu file Excel
                    excelPackage.Save();
                    MessageBox.Show("Cập nhật thông tin khách hàng thành công.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private int FindCustomerRow(ExcelWorksheet worksheet, string maKH)
        {
            // Kiểm tra xem worksheet có dữ liệu hay không
            if (worksheet.Dimension == null)
            {
                return -1; // Không có dữ liệu trong worksheet
            }

            for (int row = 1; row <= worksheet.Dimension.End.Row; row++)
            {
                var cellValue = worksheet.Cells[row, 1].Text;
                if (cellValue == maKH)
                {
                    return row;
                }
            }
            return -1;
        }
    }
}
