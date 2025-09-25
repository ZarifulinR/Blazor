using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PV_319;

public partial class Direction
{
    [Key]
    [Required]
    public byte direction_id { get; set; }
    [Required]
    public string? direction_name { get; set; }
}
