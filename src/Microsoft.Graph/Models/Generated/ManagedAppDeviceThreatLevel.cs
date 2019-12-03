// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Model\EnumType.cs.tt


namespace Microsoft.Graph
{
    using Newtonsoft.Json;

    /// <summary>
    /// The enum ManagedAppDeviceThreatLevel.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum ManagedAppDeviceThreatLevel
    {
    
        /// <summary>
        /// Not Configured
        /// </summary>
        NotConfigured = 0,
	
        /// <summary>
        /// Secured
        /// </summary>
        Secured = 1,
	
        /// <summary>
        /// Low
        /// </summary>
        Low = 2,
	
        /// <summary>
        /// Medium
        /// </summary>
        Medium = 3,
	
        /// <summary>
        /// High
        /// </summary>
        High = 4,
	
    }
}