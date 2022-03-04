using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class OfficeConfiguration : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>List of office Client configuration.</summary>
        public List<OfficeClientConfiguration> ClientConfigurations { get; set; }
        /// <summary>List of office Client check-in status.</summary>
        public List<OfficeClientCheckinStatus> TenantCheckinStatuses { get; set; }
        /// <summary>Entity that describes tenant check-in statues</summary>
        public OfficeUserCheckinSummary TenantUserCheckinSummary { get; set; }
        /// <summary>
        /// Instantiates a new OfficeConfiguration and sets the default values.
        /// </summary>
        public OfficeConfiguration() {
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
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"clientConfigurations", (o,n) => { (o as OfficeConfiguration).ClientConfigurations = n.GetCollectionOfObjectValues<OfficeClientConfiguration>(OfficeClientConfiguration.CreateFromDiscriminatorValue).ToList(); } },
                {"tenantCheckinStatuses", (o,n) => { (o as OfficeConfiguration).TenantCheckinStatuses = n.GetCollectionOfObjectValues<OfficeClientCheckinStatus>(OfficeClientCheckinStatus.CreateFromDiscriminatorValue).ToList(); } },
                {"tenantUserCheckinSummary", (o,n) => { (o as OfficeConfiguration).TenantUserCheckinSummary = n.GetObjectValue<OfficeUserCheckinSummary>(OfficeUserCheckinSummary.CreateFromDiscriminatorValue); } },
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
