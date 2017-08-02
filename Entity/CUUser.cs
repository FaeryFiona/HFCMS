using System;
using System.Collections.Generic;
using System.Text;
using NetRube.Data;
namespace HFCMS.Entity
{


    [TableName("CUUser")]
    [PrimaryKey("Id")]
    public class CUUser
    {
        
        public Int32? Id { get;set; }
        public String LoginName { get;set; }
        public String UserName { get;set; }
        public String PassWord { get;set; }
        public Int32? UserType { get;set; }
        public String RealName { get;set; }
        public Int32? EnableMultiLogin { get;set; }
        public Int32? LoginTimes { get;set; }
        public Int32? DepartId { get;set; }
        public String RoleId { get;set; }
        public String Phone { get;set; }
        public String Email { get;set; }
        public String Address { get;set; }
        public String TitleUrl { get;set; }
        public Int32? Sex { get;set; }
        public String Remark { get;set; }
        public String Theme { get;set; }
        public Int32? State { get;set; }
        public String LoginIp { get;set; }
        public DateTime? LoginTime { get;set; }
        public String ThirdId { get;set; }
        public DateTime? EndTime { get;set; }
        public DateTime? CreateTime { get;set; }
        public Int32? CreateId { get;set; }
    }
}