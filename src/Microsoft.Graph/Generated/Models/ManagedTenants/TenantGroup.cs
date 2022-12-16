using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models.ManagedTenants {
    /// <summary>
    /// Provides operations to manage the admin singleton.
    /// </summary>
    public class TenantGroup : Entity, IParsable {
        /// <summary>A flag indicating whether all managed tenant are included in the tenant group. Required. Read-only.</summary>
        public bool? AllTenantsIncluded {
            get { return BackingStore?.Get<bool?>("allTenantsIncluded"); }
            set { BackingStore?.Set("allTenantsIncluded", value); }
        }
        /// <summary>The display name for the tenant group. Optional. Read-only.</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
        /// <summary>The collection of management action associated with the tenant group. Optional. Read-only.</summary>
        public List<ManagementActionInfo> ManagementActions {
            get { return BackingStore?.Get<List<ManagementActionInfo>>("managementActions"); }
            set { BackingStore?.Set("managementActions", value); }
        }
        /// <summary>The collection of management intents associated with the tenant group. Optional. Read-only.</summary>
        public List<ManagementIntentInfo> ManagementIntents {
            get { return BackingStore?.Get<List<ManagementIntentInfo>>("managementIntents"); }
            set { BackingStore?.Set("managementIntents", value); }
        }
        /// <summary>The collection of managed tenant identifiers include in the tenant group. Optional. Read-only.</summary>
        public List<string> TenantIds {
            get { return BackingStore?.Get<List<string>>("tenantIds"); }
            set { BackingStore?.Set("tenantIds", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new TenantGroup CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TenantGroup();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"allTenantsIncluded", n => { AllTenantsIncluded = n.GetBoolValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"managementActions", n => { ManagementActions = n.GetCollectionOfObjectValues<ManagementActionInfo>(ManagementActionInfo.CreateFromDiscriminatorValue)?.ToList(); } },
                {"managementIntents", n => { ManagementIntents = n.GetCollectionOfObjectValues<ManagementIntentInfo>(ManagementIntentInfo.CreateFromDiscriminatorValue)?.ToList(); } },
                {"tenantIds", n => { TenantIds = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteBoolValue("allTenantsIncluded", AllTenantsIncluded);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteCollectionOfObjectValues<ManagementActionInfo>("managementActions", ManagementActions);
            writer.WriteCollectionOfObjectValues<ManagementIntentInfo>("managementIntents", ManagementIntents);
            writer.WriteCollectionOfPrimitiveValues<string>("tenantIds", TenantIds);
        }
    }
}
