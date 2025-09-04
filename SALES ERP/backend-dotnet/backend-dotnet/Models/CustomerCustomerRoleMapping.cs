using System;
using System.Collections.Generic;

namespace backend_dotnet.Models;

public partial class CustomerCustomerRoleMapping
{
    public int CustomerId { get; set; }

    public int CustomerRoleId { get; set; }
}
