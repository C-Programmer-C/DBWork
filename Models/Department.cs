using System;
using System.Collections.Generic;

namespace DBWork.Models;

public partial class Department
{
	public int DepartmentId { get; set; }

	public string Name { get; set; } = null!;

	public int DirectorId { get; set; }

	public virtual Staff Director { get; set; } = null!;

	public virtual ICollection<Staff> Staff { get; set; } = new List<Staff>();
}
