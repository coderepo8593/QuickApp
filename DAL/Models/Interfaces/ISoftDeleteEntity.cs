using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Models.Interfaces
{
    public interface ISoftDeleteEntity
    {
        bool IsDeleted { get; set; }
    }
}
