using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DBWork.Models;

public partial class User
{
	public int UserId { get; set; }

	public string? Email { get; set; }

	public string? Password { get; set; }

	public virtual Staff UserNavigation { get; set; } = null!;

	public string role { get; set; }
}
