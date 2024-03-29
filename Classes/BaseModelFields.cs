﻿using System;
using System.ComponentModel.DataAnnotations.Schema;
using DomainModel.Interfaces;

namespace DomainModel.Classes
{
    /// <summary>
    /// این یک کلاس میانی است به جهت 
    /// استفاده در کلاس های اصلی و اینترفیس آن
    /// علت وجود ان هم برای اینکه اگر به اینترفیس
    ///  ما یک خاصیت اضافه شد نیاز نباشد
    /// که در تمامی کلاس های زیر مجموعه پیاده ساز شود
    ///  و فقط در این کلاس پیاده سازی
    /// می شود و در بقیه کلاس های پروژه ما اعمال خواهد شد.
    /// تمامی کلاس های مدل ما باید از این کلاس اینهریت شود
    /// </summary>
    public class BaseFieldsTables : IBaseFieldsTables
    {
        public string Description { get; set; }

        #region IBaseFieldsTables Members

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Name { get; set; }

        public Guid UniqId { get; set; }

        public DateTime CreatedDate { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public byte[] RowVersion { get; set; }

        #endregion
    }
}