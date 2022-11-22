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
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>List of office Client configuration.</summary>
        public List<OfficeClientConfiguration> ClientConfigurations {
            get { return BackingStore?.Get<List<OfficeClientConfiguration>>("clientConfigurations"); }
            set { BackingStore?.Set("clientConfigurations", value); }
        }
        /// <summary>The OdataType property</summary>
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
        /// <summary>List of office Client check-in status.</summary>
        public List<OfficeClientCheckinStatus> TenantCheckinStatuses {
            get { return BackingStore?.Get<List<OfficeClientCheckinStatus>>("tenantCheckinStatuses"); }
            set { BackingStore?.Set("tenantCheckinStatuses", value); }
        }
        /// <summary>Entity that describes tenant check-in statues</summary>
        public OfficeUserCheckinSummary TenantUserCheckinSummary {
            get { return BackingStore?.Get<OfficeUserCheckinSummary>("tenantUserCheckinSummary"); }
            set { BackingStore?.Set("tenantUserCheckinSummary", value); }
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
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static OfficeConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new OfficeConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"clientConfigurations", n => { ClientConfigurations = n.GetCollectionOfObjectValues<OfficeClientConfiguration>(OfficeClientConfiguration.CreateFromDiscriminatorValue)?.ToList(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"tenantCheckinStatuses", n => { TenantCheckinStatuses = n.GetCollectionOfObjectValues<OfficeClientCheckinStatus>(OfficeClientCheckinStatus.CreateFromDiscriminatorValue)?.ToList(); } },
                {"tenantUserCheckinSummary", n => { TenantUserCheckinSummary = n.GetObjectValue<OfficeUserCheckinSummary>(OfficeUserCheckinSummary.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<OfficeClientConfiguration>("clientConfigurations", ClientConfigurations);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteCollectionOfObjectValues<OfficeClientCheckinStatus>("tenantCheckinStatuses", TenantCheckinStatuses);
            writer.WriteObjectValue<OfficeUserCheckinSummary>("tenantUserCheckinSummary", TenantUserCheckinSummary);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
