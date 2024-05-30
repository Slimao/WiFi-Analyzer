﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WiFi_Analyzer.Models;

public class IPAddressInfo
{
    public string PrivateIPv4 { get; set; } = null!;
    public string SubnetMask { get; set; } = null!;
    public string? PublicIPv4 { get; set; }
}
