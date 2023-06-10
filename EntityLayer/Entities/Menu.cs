using System;
using System.Collections.Generic;

namespace EntityLayer.Entities
{
    public partial class Menu
    {
        public int Id { get; set; }
        public string? MenuAdi { get; set; }
        public int? UstMenuId { get; set; }
    }
}
