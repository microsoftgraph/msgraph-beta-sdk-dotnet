// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: ComplexType.cs.tt

namespace Microsoft.Graph.ManagedTenants
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type WorkloadStatus.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    [JsonConverter(typeof(Microsoft.Graph.DerivedTypeConverter))]
    public partial class WorkloadStatus
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkloadStatus"/> class.
        /// </summary>
        public WorkloadStatus()
        {
            this.ODataType = "microsoft.graph.managedTenants.workloadStatus";
        }

        /// <summary>
        /// Gets or sets displayName.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "displayName", Required = Newtonsoft.Json.Required.Default)]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets offboardedDateTime.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "offboardedDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? OffboardedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets onboardedDateTime.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "onboardedDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? OnboardedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets onboardingStatus.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "onboardingStatus", Required = Newtonsoft.Json.Required.Default)]
        public WorkloadOnboardingStatus? OnboardingStatus { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData(ReadData = true)]
        public IDictionary<string, object> AdditionalData { get; set; }

        /// <summary>
        /// Gets or sets @odata.type.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "@odata.type", Required = Newtonsoft.Json.Required.Default)]
        public string ODataType { get; set; }
    
    }
}
