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
    /// The type DeploymentState.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    [JsonConverter(typeof(Microsoft.Graph.DerivedTypeConverter))]
    public partial class DeploymentState
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeploymentState"/> class.
        /// </summary>
        public DeploymentState()
        {
            this.ODataType = "microsoft.graph.windowsUpdates.deploymentState";
        }

        /// <summary>
        /// Gets or sets reasons.
        /// Specifies the reasons the deployment has its state value. Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "reasons", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<DeploymentStateReason> Reasons { get; set; }
    
        /// <summary>
        /// Gets or sets requestedValue.
        /// Specifies the requested state of the deployment. Supports a subset of the values for requestedDeploymentStateValue. Possible values are: none, paused.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "requestedValue", Required = Newtonsoft.Json.Required.Default)]
        public RequestedDeploymentStateValue? RequestedValue { get; set; }
    
        /// <summary>
        /// Gets or sets value.
        /// Specifies the state of the deployment. Supports a subset of the values for deploymentStateValue. Possible values are: scheduled, offering, paused. Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "value", Required = Newtonsoft.Json.Required.Default)]
        public DeploymentStateValue? Value { get; set; }
    
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
