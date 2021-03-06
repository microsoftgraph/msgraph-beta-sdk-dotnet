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
    /// The enum LocalSecurityOptionsSmartCardRemovalBehaviorType.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum LocalSecurityOptionsSmartCardRemovalBehaviorType
    {
    
        /// <summary>
        /// Lock Workstation
        /// </summary>
        LockWorkstation = 0,
	
        /// <summary>
        /// No Action
        /// </summary>
        NoAction = 1,
	
        /// <summary>
        /// Force Logoff
        /// </summary>
        ForceLogoff = 2,
	
        /// <summary>
        /// Disconnect Remote Desktop Session
        /// </summary>
        DisconnectRemoteDesktopSession = 3,
	
    }
}
