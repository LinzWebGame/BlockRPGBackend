using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BlockRPGBackend.Modules
{
    /// <summary>
    /// 用户
    /// </summary>
    [Table("users")]
    public class Users
    {
        /// <summary>
        /// 用户ID
        /// </summary>
        /// <value></value>
        [Key]
        //[ScaffoldColumn(false)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public long Id { get; set; }

        /// <summary>
        /// 用户名
        /// </summary>
        /// <value></value>
        [StringLength(maximumLength: 128)]
        [Required]
        [Column("username")]
        public string UserName { get; set; }

        /// <summary>
        /// 邮箱地址
        /// </summary>
        /// <value></value>
        [StringLength(maximumLength: 128)]
        [Required]
        [Column("email")]
        public string Email { get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        /// <value></value>
        [StringLength(maximumLength: 256)]
        [Column("password")]
        public string Password { get; set; }

        /// <summary>
        /// 注册IP
        /// </summary>
        /// <value></value>
        [StringLength(maximumLength: 16)]
        [Column("registerip")]
        public string RegisterIP { get; set; }

        /// <summary>
        /// token
        /// </summary>
        /// <value></value>
        [StringLength(maximumLength: 32)]
        [Column("token")]
        public string Token { get; set; }

        /// <summary>
        /// 金额
        /// </summary>
        /// <value></value>
        [Column("amount", TypeName = "decimal(8, 2)")]
        public decimal Amount { get; set; }

        /// <summary>
        /// 订单创建时间
        /// </summary>
        /// <value></value>
        [Column("registertime")]
        public DateTime RegisterTime { get; set; }

        /// <summary>
        /// 最近一次登录时间
        /// </summary>
        /// <value></value>
        [Column("lastlogintime")]
        public DateTime LastLoginTime { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        /// <value></value>
        [Column("status")]
        public byte status { get; set; }
    }//End Class
}