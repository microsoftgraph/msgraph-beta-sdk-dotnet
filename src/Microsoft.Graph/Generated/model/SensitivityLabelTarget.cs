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
    /// The enum SensitivityLabelTarget.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
	[System.Flags]
    public enum SensitivityLabelTarget
    {
    
        /// <summary>
        /// Email
        /// </summary>
        Email = 1,
	
        /// <summary>
        /// Site
        /// </summary>
        Site = 2,
	
        /// <summary>
        /// Unified Group
        /// </summary>
        UnifiedGroup = 4,
	
        /// <summary>
        /// Unknown Future Value
        /// </summary>
        UnknownFutureValue = 8,
	
    }
}