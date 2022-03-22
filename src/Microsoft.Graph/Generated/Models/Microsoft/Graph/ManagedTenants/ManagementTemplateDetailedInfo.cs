using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph.ManagedTenants {
    public class ManagementTemplateDetailedInfo : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The management category for the management template. Possible values are: custom, devices, identity, unknownFutureValue. Required. Read-only.</summary>
        public ManagementCategory? Category { get; set; }
        /// <summary>The display name for the management template. Required. Read-only.</summary>
        public string DisplayName { get; set; }
        /// <summary>The unique identifier for the management template. Required. Read-only.</summary>
        public string ManagementTemplateId { get; set; }
        public int? Version { get; set; }
        /// <summary>
        /// Instantiates a new managementTemplateDetailedInfo and sets the default values.
        /// </summary>
        public ManagementTemplateDetailedInfo() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static ManagementTemplateDetailedInfo CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ManagementTemplateDetailedInfo();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"category", (o,n) => { (o as ManagementTemplateDetailedInfo).Category = n.GetEnumValue<ManagementCategory>(); } },
                {"displayName", (o,n) => { (o as ManagementTemplateDetailedInfo).DisplayName = n.GetStringValue(); } },
                {"managementTemplateId", (o,n) => { (o as ManagementTemplateDetailedInfo).ManagementTemplateId = n.GetStringValue(); } },
                {"version", (o,n) => { (o as ManagementTemplateDetailedInfo).Version = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<ManagementCategory>("category", Category);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("managementTemplateId", ManagementTemplateId);
            writer.WriteIntValue("version", Version);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
