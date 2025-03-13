using System;
using System.Collections.Generic;

namespace materials_dbPr5.Models;

public partial class MaterialType
{
    public short Id { get; set; }

    public string TypeMaterial { get; set; } = null!;

    public virtual ICollection<Material> Materials { get; set; } = new List<Material>();
}
