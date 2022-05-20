using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the tenantRelationship singleton.</summary>
    public class DelegatedAdminServiceManagementDetail : Entity, IParsable {
        /// <summary>The serviceId property</summary>
        public string ServiceId {
            get { return BackingStore?.Get<string>(nameof(ServiceId)); }
            set { BackingStore?.Set(nameof(ServiceId), value); }
        }
        /// <summary>The URL of the management portal for the managed service. Read-only.</summary>
        public string ServiceManagementUrl {
            get { return BackingStore?.Get<string>(nameof(ServiceManagementUrl)); }
            set { BackingStore?.Set(nameof(ServiceManagementUrl), value); }
        }
        /// <summary>The name of a managed service. Read-only.</summary>
        public string ServiceName {
            get { return BackingStore?.Get<string>(nameof(ServiceName)); }
            set { BackingStore?.Set(nameof(ServiceName), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new DelegatedAdminServiceManagementDetail CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DelegatedAdminServiceManagementDetail();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"serviceId", n => { ServiceId = n.GetStringValue(); } },
                {"serviceManagementUrl", n => { ServiceManagementUrl = n.GetStringValue(); } },
                {"serviceName", n => { ServiceName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("serviceId", ServiceId);
            writer.WriteStringValue("serviceManagementUrl", ServiceManagementUrl);
            writer.WriteStringValue("serviceName", ServiceName);
        }
    }
}
