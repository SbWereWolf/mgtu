//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EmailManager
{
    using System;
    using System.Collections.Generic;
    
    public partial class Emails
    {
        public long Id { get; set; }
        public long UserId { get; set; }
        public string Email { get; set; }
    
        public virtual Users Users { get; set; }
    }
}
