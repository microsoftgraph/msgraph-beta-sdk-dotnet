using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.TenantRelationships.ManagedTenants.ManagementActions.Item.Apply {
    /// <summary>Provides operations to call the apply method.</summary>
    public class ApplyRequestBody : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public List<string> ExcludeGroups { get; set; }
        public bool? IncludeAllUsers { get; set; }
        public List<string> IncludeGroups { get; set; }
        public string ManagementTemplateId { get; set; }
        public string TenantGroupId { get; set; }
        public string TenantId { get; set; }
        /// <summary>
        /// Instantiates a new applyRequestBody and sets the default values.
        /// </summary>
        public ApplyRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static ApplyRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ApplyRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"excludeGroups", (o,n) => { (o as ApplyRequestBody).ExcludeGroups = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"includeAllUsers", (o,n) => { (o as ApplyRequestBody).IncludeAllUsers = n.GetBoolValue(); } },
                {"includeGroups", (o,n) => { (o as ApplyRequestBody).IncludeGroups = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"managementTemplateId", (o,n) => { (o as ApplyRequestBody).ManagementTemplateId = n.GetStringValue(); } },
                {"tenantGroupId", (o,n) => { (o as ApplyRequestBody).TenantGroupId = n.GetStringValue(); } },
                {"tenantId", (o,n) => { (o as ApplyRequestBody).TenantId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfPrimitiveValues<string>("excludeGroups", ExcludeGroups);
            writer.WriteBoolValue("includeAllUsers", IncludeAllUsers);
            writer.WriteCollectionOfPrimitiveValues<string>("includeGroups", IncludeGroups);
            writer.WriteStringValue("managementTemplateId", ManagementTemplateId);
            writer.WriteStringValue("tenantGroupId", TenantGroupId);
            writer.WriteStringValue("tenantId", TenantId);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
