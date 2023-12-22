﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StyleX.Models
{
    [Table("Order")]
    public class Order
    {
        [Key]
        public int OrderID { get; set; }
        public double TransportFee { get; set; } = 30000;
        public double BasePrice { get; set; } //tổng tiền
        public double NetPrice { get; set; } //thành tiền

        public string Address { get; set; } = null!;
        public string PhoneNumber { get; set; } = null!;
        public string Message { get; set; } = null!;
        public int Status { get; set; } = 0; //0.đang xử lý, 1.đang giao hàng, 2.giao hàng thành công, 3.hủy. nếu nhận được yêu cầu sửa thì quay lại 0
        public double PercentSale { get; set; } // số % khuyến mại
        public DateTime CreateAt { get; set; } = DateTime.Now;
        public DateTime UpdateAt { get; set; } = DateTime.Now;
        public int AccountID { get; set; }
        public Account Account { get; set; } = null!;
    }
}
