// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EnumType.cs.tt


namespace Microsoft.Graph
{
    using System;
    using Newtonsoft.Json;

    /// <summary>
    /// The enum ConditionalAccessRule.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum ConditionalAccessRule
    {
    
        /// <summary>
        /// All Apps
        /// </summary>
        AllApps = 0,
	
        /// <summary>
        /// First Party Apps
        /// </summary>
        FirstPartyApps = 1,
	
        /// <summary>
        /// Office365
        /// </summary>
        Office365 = 2,
	
        /// <summary>
        /// App Id
        /// </summary>
        AppId = 3,
	
        /// <summary>
        /// Acr
        /// </summary>
        Acr = 4,
	
        /// <summary>
        /// App Filter
        /// </summary>
        AppFilter = 5,
	
        /// <summary>
        /// All Users
        /// </summary>
        AllUsers = 6,
	
        /// <summary>
        /// Guest
        /// </summary>
        Guest = 7,
	
        /// <summary>
        /// Group Id
        /// </summary>
        GroupId = 8,
	
        /// <summary>
        /// Role Id
        /// </summary>
        RoleId = 9,
	
        /// <summary>
        /// User Id
        /// </summary>
        UserId = 10,
	
        /// <summary>
        /// All Device Platforms
        /// </summary>
        AllDevicePlatforms = 11,
	
        /// <summary>
        /// Device Platform
        /// </summary>
        DevicePlatform = 12,
	
        /// <summary>
        /// All Locations
        /// </summary>
        AllLocations = 13,
	
        /// <summary>
        /// Inside Corpnet
        /// </summary>
        InsideCorpnet = 14,
	
        /// <summary>
        /// All Trusted Locations
        /// </summary>
        AllTrustedLocations = 15,
	
        /// <summary>
        /// Location Id
        /// </summary>
        LocationId = 16,
	
        /// <summary>
        /// All Devices
        /// </summary>
        AllDevices = 17,
	
        /// <summary>
        /// Device Filter
        /// </summary>
        DeviceFilter = 18,
	
        /// <summary>
        /// Device State
        /// </summary>
        DeviceState = 19,
	
        /// <summary>
        /// Unknown Future Value
        /// </summary>
        UnknownFutureValue = 20,
	
    }
}
