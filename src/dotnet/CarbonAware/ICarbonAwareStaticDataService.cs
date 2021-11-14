﻿using System;
using System.Collections.Generic;
namespace CarbonAware
{
    /// <summary>
    /// Interface for a static data services that simply gives a list 
    /// of emissions data for client side processing.
    /// </summary>
    public interface ICarbonAwareStaticDataService
    {
        /// <summary>
        /// Retrieve all data as a List for client side processing.
        /// </summary>
        /// <returns>A List&lt;EmissionsData&gt; of all data available.</returns>
        List<EmissionsData> GetData();
    }
}
