using System;
using System.Collections.Generic;

namespace DBWork.Models;

public partial class Order
{
	public int OrderId { get; set; }

	public int? Cost { get; set; }

	public string? TimeExecution { get; set; }

	public string FullnameClient { get; set; } = null!;

	public virtual ICollection<StaffOrder> StaffOrders { get; set; } = new List<StaffOrder>();
}
