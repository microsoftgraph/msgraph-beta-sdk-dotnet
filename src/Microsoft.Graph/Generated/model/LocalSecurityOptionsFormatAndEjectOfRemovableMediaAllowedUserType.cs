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
    /// The enum LocalSecurityOptionsFormatAndEjectOfRemovableMediaAllowedUserType.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum LocalSecurityOptionsFormatAndEjectOfRemovableMediaAllowedUserType
    {
    
        /// <summary>
        /// Not Configured
        /// </summary>
        NotConfigured = 0,
	
        /// <summary>
        /// Administrators
        /// </summary>
        Administrators = 1,
	
        /// <summary>
        /// Administrators And Power Users
        /// </summary>
        AdministratorsAndPowerUsers = 2,
	
        /// <summary>
        /// Administrators And Interactive Users
        /// </summary>
        AdministratorsAndInteractiveUsers = 3,
	
    }
}