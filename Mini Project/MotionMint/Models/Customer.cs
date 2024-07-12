using System;
using System.Collections.Generic;

namespace Motion_Mint.Models;

public partial class Customer
{
    public int Id { get; set; }

    public string? Custname { get; set; }

    public string? Address { get; set; }

    public int? Mobile { get; set; }
}
