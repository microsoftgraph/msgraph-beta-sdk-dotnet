using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.OfficeConfiguration.ClientConfigurations.UpdatePriorities {
    /// <summary>Provides operations to call the updatePriorities method.</summary>
    public class UpdatePrioritiesRequestBody : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The officeConfigurationPolicyIds property</summary>
        public List<string> OfficeConfigurationPolicyIds { get; set; }
        /// <summary>The officeConfigurationPriorities property</summary>
        public List<int?> OfficeConfigurationPriorities { get; set; }
        /// <summary>
        /// Instantiates a new updatePrioritiesRequestBody and sets the default values.
        /// </summary>
        public UpdatePrioritiesRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static UpdatePrioritiesRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UpdatePrioritiesRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"officeConfigurationPolicyIds", (o,n) => { (o as UpdatePrioritiesRequestBody).OfficeConfigurationPolicyIds = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"officeConfigurationPriorities", (o,n) => { (o as UpdatePrioritiesRequestBody).OfficeConfigurationPriorities = n.GetCollectionOfPrimitiveValues<int?>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfPrimitiveValues<string>("officeConfigurationPolicyIds", OfficeConfigurationPolicyIds);
            writer.WriteCollectionOfPrimitiveValues<int?>("officeConfigurationPriorities", OfficeConfigurationPriorities);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
