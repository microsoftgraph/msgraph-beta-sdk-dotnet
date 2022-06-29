using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of activityStatistics entities.</summary>
    public class ProviderTenantSetting : Entity, IParsable {
        /// <summary>The azureTenantId property</summary>
        public string AzureTenantId {
            get { return BackingStore?.Get<string>(nameof(AzureTenantId)); }
            set { BackingStore?.Set(nameof(AzureTenantId), value); }
        }
        /// <summary>The enabled property</summary>
        public bool? Enabled {
            get { return BackingStore?.Get<bool?>(nameof(Enabled)); }
            set { BackingStore?.Set(nameof(Enabled), value); }
        }
        /// <summary>The lastModifiedDateTime property</summary>
        public DateTimeOffset? LastModifiedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(LastModifiedDateTime)); }
            set { BackingStore?.Set(nameof(LastModifiedDateTime), value); }
        }
        /// <summary>The provider property</summary>
        public string Provider {
            get { return BackingStore?.Get<string>(nameof(Provider)); }
            set { BackingStore?.Set(nameof(Provider), value); }
        }
        /// <summary>The vendor property</summary>
        public string Vendor {
            get { return BackingStore?.Get<string>(nameof(Vendor)); }
            set { BackingStore?.Set(nameof(Vendor), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ProviderTenantSetting CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ProviderTenantSetting();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"azureTenantId", n => { AzureTenantId = n.GetStringValue(); } },
                {"enabled", n => { Enabled = n.GetBoolValue(); } },
                {"lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"provider", n => { Provider = n.GetStringValue(); } },
                {"vendor", n => { Vendor = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("azureTenantId", AzureTenantId);
            writer.WriteBoolValue("enabled", Enabled);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteStringValue("provider", Provider);
            writer.WriteStringValue("vendor", Vendor);
        }
    }
}
