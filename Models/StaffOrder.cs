using System;
using System.Collections.Generic;

namespace DBWork.Models;

public partial class StaffOrder
{
	public int OrderStaffId { get; set; }

	public int StaffId { get; set; }

	public int OrderId { get; set; }

	public virtual Order Order { get; set; } = null!;

	public virtual Staff Staff { get; set; } = null!;
}
