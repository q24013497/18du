using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Model
{
  public  class Region//地区
    {
        [Key]
        //主键
    public int Id { get; set; }

        public string Name { get; set; }//名称

        public int Pid { get; set; }//Pid
    }
}
