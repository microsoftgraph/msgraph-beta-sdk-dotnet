// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type User Experience Analytics Work From Anywhere Metric.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class UserExperienceAnalyticsWorkFromAnywhereMetric : Entity
    {
    
		///<summary>
		/// The UserExperienceAnalyticsWorkFromAnywhereMetric constructor
		///</summary>
        public UserExperienceAnalyticsWorkFromAnywhereMetric()
        {
            this.ODataType = "microsoft.graph.userExperienceAnalyticsWorkFromAnywhereMetric";
        }
	
        /// <summary>
        /// Gets or sets metric devices.
        /// The work from anywhere metric devices.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "metricDevices", Required = Newtonsoft.Json.Required.Default)]
        public IUserExperienceAnalyticsWorkFromAnywhereMetricMetricDevicesCollectionPage MetricDevices { get; set; }
    
    }
}

