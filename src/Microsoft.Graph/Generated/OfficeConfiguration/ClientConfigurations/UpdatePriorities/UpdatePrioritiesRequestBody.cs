using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.OfficeConfiguration.ClientConfigurations.UpdatePriorities {
    public class UpdatePrioritiesRequestBody : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public List<string> OfficeConfigurationPolicyIds { get; set; }
        public List<int?> OfficeConfigurationPriorities { get; set; }
        /// <summary>
        /// Instantiates a new updatePrioritiesRequestBody and sets the default values.
        /// </summary>
        public UpdatePrioritiesRequestBody() {
            AdditionalData = new Dictionary<string, object>();
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
