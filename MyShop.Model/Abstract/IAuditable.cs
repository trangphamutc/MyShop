﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop.Model.Models
{
    public interface IAuditable
    {
        DateTime? CreatedDate { set; get; }
        string CreatedBy { set; get; }
        DateTime? UpdatedDate { set; get; }
        string UpdatedBy { set; get; }
        string MetaKeyword { set; get; }
        string MetaDescription { set; get; }



    }
}
