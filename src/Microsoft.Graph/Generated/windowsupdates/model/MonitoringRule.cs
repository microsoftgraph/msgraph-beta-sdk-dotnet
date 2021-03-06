// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: ComplexType.cs.tt

namespace Microsoft.Graph.WindowsUpdates
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type MonitoringRule.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    [JsonConverter(typeof(Microsoft.Graph.DerivedTypeConverter))]
    public partial class MonitoringRule
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MonitoringRule"/> class.
        /// </summary>
        public MonitoringRule()
        {
            this.ODataType = "microsoft.graph.windowsUpdates.monitoringRule";
        }

        /// <summary>
        /// Gets or sets action.
        /// The action triggered when the threshold for the given signal is met. Possible values are: alertError, pauseDeployment.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "action", Required = Newtonsoft.Json.Required.Default)]
        public MonitoringAction? Action { get; set; }
    
        /// <summary>
        /// Gets or sets signal.
        /// The signal to monitor. Possible values are: rollback.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "signal", Required = Newtonsoft.Json.Required.Default)]
        public MonitoringSignal? Signal { get; set; }
    
        /// <summary>
        /// Gets or sets threshold.
        /// The threshold for a signal at which to trigger action. An integer from 1 to 100 (inclusive).
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "threshold", Required = Newtonsoft.Json.Required.Default)]
        public Int32? Threshold { get; set; }
    
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
