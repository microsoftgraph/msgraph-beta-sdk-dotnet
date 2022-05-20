using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class OfficeConfiguration : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>List of office Client configuration.</summary>
        public List<OfficeClientConfiguration> ClientConfigurations {
            get { return BackingStore?.Get<List<OfficeClientConfiguration>>(nameof(ClientConfigurations)); }
            set { BackingStore?.Set(nameof(ClientConfigurations), value); }
        }
        /// <summary>List of office Client check-in status.</summary>
        public List<OfficeClientCheckinStatus> TenantCheckinStatuses {
            get { return BackingStore?.Get<List<OfficeClientCheckinStatus>>(nameof(TenantCheckinStatuses)); }
            set { BackingStore?.Set(nameof(TenantCheckinStatuses), value); }
        }
        /// <summary>Entity that describes tenant check-in statues</summary>
        public OfficeUserCheckinSummary TenantUserCheckinSummary {
            get { return BackingStore?.Get<OfficeUserCheckinSummary>(nameof(TenantUserCheckinSummary)); }
            set { BackingStore?.Set(nameof(TenantUserCheckinSummary), value); }
        }
        /// <summary>
        /// Instantiates a new OfficeConfiguration and sets the default values.
        /// </summary>
        public OfficeConfiguration() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static OfficeConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new OfficeConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"clientConfigurations", n => { ClientConfigurations = n.GetCollectionOfObjectValues<OfficeClientConfiguration>(OfficeClientConfiguration.CreateFromDiscriminatorValue).ToList(); } },
                {"tenantCheckinStatuses", n => { TenantCheckinStatuses = n.GetCollectionOfObjectValues<OfficeClientCheckinStatus>(OfficeClientCheckinStatus.CreateFromDiscriminatorValue).ToList(); } },
                {"tenantUserCheckinSummary", n => { TenantUserCheckinSummary = n.GetObjectValue<OfficeUserCheckinSummary>(OfficeUserCheckinSummary.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<OfficeClientConfiguration>("clientConfigurations", ClientConfigurations);
            writer.WriteCollectionOfObjectValues<OfficeClientCheckinStatus>("tenantCheckinStatuses", TenantCheckinStatuses);
            writer.WriteObjectValue<OfficeUserCheckinSummary>("tenantUserCheckinSummary", TenantUserCheckinSummary);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
