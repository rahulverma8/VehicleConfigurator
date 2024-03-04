using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace vehicle_configurator.Models;

public partial class User
{
    [Required(ErrorMessage = "Password is required")]
    [StringLength(100, MinimumLength = 3, ErrorMessage = "Password correction")]
    [Column("password")]
    public string? Password { get; set; }
    public string? Username { get; set; }
}