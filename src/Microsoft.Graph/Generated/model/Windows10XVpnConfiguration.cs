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
    /// The type Windows10XVpn Configuration.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class Windows10XVpnConfiguration : DeviceManagementResourceAccessProfileBase
    {
    
		///<summary>
		/// The Windows10XVpnConfiguration constructor
		///</summary>
        public Windows10XVpnConfiguration()
        {
            this.ODataType = "microsoft.graph.windows10XVpnConfiguration";
        }
	
        /// <summary>
        /// Gets or sets authentication certificate id.
        /// ID to the Authentication Certificate
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "authenticationCertificateId", Required = Newtonsoft.Json.Required.Default)]
        public Guid? AuthenticationCertificateId { get; set; }
    
        /// <summary>
        /// Gets or sets custom xml.
        /// Custom XML commands that configures the VPN connection. (UTF8 byte encoding)
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "customXml", Required = Newtonsoft.Json.Required.Default)]
        public byte[] CustomXml { get; set; }
    
        /// <summary>
        /// Gets or sets custom xml file name.
        /// Custom Xml file name.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "customXmlFileName", Required = Newtonsoft.Json.Required.Default)]
        public string CustomXmlFileName { get; set; }
    
    }
}

