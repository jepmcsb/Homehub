﻿using System;
using System.Collections.Generic;

namespace HomeHub.DataModel;

public partial class Business
{
    public int UserId { get; set; }

    public string Email { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string BusinessName { get; set; } = null!;

    public string RepresentativeName { get; set; } = null!;

    public string ContactNo { get; set; } = null!;

    public string OfferList { get; set; } = null!;
    public char BusinessType { get; set; }
    public string CompanyAddress { get; set; } = null!;

    //public ApplicationUser ApplicationUser { get; set; }
}
