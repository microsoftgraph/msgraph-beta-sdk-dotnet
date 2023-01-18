using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class AuditUserIdentity : UserIdentity, IParsable {
        /// <summary>For user sign ins, the identifier of the tenant that the user is a member of.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public string? HomeTenantId {
            get { return BackingStore?.Get<string?>("homeTenantId"); }
            set { BackingStore?.Set("homeTenantId", value); }
        }
#else
        public string HomeTenantId {
            get { return BackingStore?.Get<string>("homeTenantId"); }
            set { BackingStore?.Set("homeTenantId", value); }
        }
#endif
        /// <summary>For user sign ins, the name of the tenant that the user is a member of. Only populated in cases where the home tenant has provided affirmative consent to Azure AD to show the tenant content.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public string? HomeTenantName {
            get { return BackingStore?.Get<string?>("homeTenantName"); }
            set { BackingStore?.Set("homeTenantName", value); }
        }
#else
        public string HomeTenantName {
            get { return BackingStore?.Get<string>("homeTenantName"); }
            set { BackingStore?.Set("homeTenantName", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new AuditUserIdentity and sets the default values.
        /// </summary>
        public AuditUserIdentity() : base() {
            OdataType = "#microsoft.graph.auditUserIdentity";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new AuditUserIdentity CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AuditUserIdentity();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"homeTenantId", n => { HomeTenantId = n.GetStringValue(); } },
                {"homeTenantName", n => { HomeTenantName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("homeTenantId", HomeTenantId);
            writer.WriteStringValue("homeTenantName", HomeTenantName);
        }
    }
}
