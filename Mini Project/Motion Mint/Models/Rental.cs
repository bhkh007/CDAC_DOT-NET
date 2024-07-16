using System;
using System.Collections.Generic;

namespace Motion_Mint.Models;

public partial class Rental
{
    public int Id { get; set; }

    public string? Carid { get; set; }

    public int? Custid { get; set; }

    public int? Fee { get; set; }

    public DateOnly? Sdate { get; set; }

    public DateOnly? Edate { get; set; }
}
