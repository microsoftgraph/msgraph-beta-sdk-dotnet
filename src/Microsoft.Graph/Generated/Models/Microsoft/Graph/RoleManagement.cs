using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to manage the roleManagement singleton.</summary>
    public class RoleManagement : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public RbacApplicationMultiple CloudPC { get; set; }
        /// <summary>The RbacApplication for Device Management</summary>
        public RbacApplicationMultiple DeviceManagement { get; set; }
        /// <summary>Read-only. Nullable.</summary>
        public RbacApplication Directory { get; set; }
        /// <summary>Container for roles and assignments for entitlement management resources.</summary>
        public RbacApplication EntitlementManagement { get; set; }
        /// <summary>
        /// Instantiates a new RoleManagement and sets the default values.
        /// </summary>
        public RoleManagement() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static RoleManagement CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new RoleManagement();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"cloudPC", (o,n) => { (o as RoleManagement).CloudPC = n.GetObjectValue<RbacApplicationMultiple>(RbacApplicationMultiple.CreateFromDiscriminatorValue); } },
                {"deviceManagement", (o,n) => { (o as RoleManagement).DeviceManagement = n.GetObjectValue<RbacApplicationMultiple>(RbacApplicationMultiple.CreateFromDiscriminatorValue); } },
                {"directory", (o,n) => { (o as RoleManagement).Directory = n.GetObjectValue<RbacApplication>(RbacApplication.CreateFromDiscriminatorValue); } },
                {"entitlementManagement", (o,n) => { (o as RoleManagement).EntitlementManagement = n.GetObjectValue<RbacApplication>(RbacApplication.CreateFromDiscriminatorValue); } },
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
