using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class RoleManagement : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public RbacApplicationMultiple CloudPC { get; set; }
        /// <summary>The RbacApplication for Device Management</summary>
        public RbacApplicationMultiple DeviceManagement { get; set; }
        /// <summary>Read-only. Nullable.</summary>
        public RbacApplication Directory { get; set; }
        /// <summary>Container for all entitlement management resources in Azure AD identity governance.</summary>
        public RbacApplication EntitlementManagement { get; set; }
        /// <summary>
        /// Instantiates a new RoleManagement and sets the default values.
        /// </summary>
        public RoleManagement() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"cloudPC", (o,n) => { (o as RoleManagement).CloudPC = n.GetObjectValue<RbacApplicationMultiple>(); } },
                {"deviceManagement", (o,n) => { (o as RoleManagement).DeviceManagement = n.GetObjectValue<RbacApplicationMultiple>(); } },
                {"directory", (o,n) => { (o as RoleManagement).Directory = n.GetObjectValue<RbacApplication>(); } },
                {"entitlementManagement", (o,n) => { (o as RoleManagement).EntitlementManagement = n.GetObjectValue<RbacApplication>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<RbacApplicationMultiple>("cloudPC", CloudPC);
            writer.WriteObjectValue<RbacApplicationMultiple>("deviceManagement", DeviceManagement);
            writer.WriteObjectValue<RbacApplication>("directory", Directory);
            writer.WriteObjectValue<RbacApplication>("entitlementManagement", EntitlementManagement);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
