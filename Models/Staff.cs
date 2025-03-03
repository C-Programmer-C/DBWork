using System;
using System.Collections.Generic;

namespace DBWork.Models;

public partial class Staff
{
	public int StaffId { get; set; }

	public string? Surname { get; set; }

	public string? Name { get; set; }

	public string? Patronymic { get; set; }

	public string? Telephone { get; set; }

	public int DepartmentId { get; set; }

	public virtual Department Department { get; set; } = null!;

	public virtual ICollection<Department> Departments { get; set; } = new List<Department>();

	public virtual ICollection<StaffOrder> StaffOrders { get; set; } = new List<StaffOrder>();

	public virtual User? User { get; set; }
}
