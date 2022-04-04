using Microsoft.Kiota.Abstractions.Serialization;
using MicrosoftGraphSdk.Models.Microsoft.Graph;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.DeviceManagement.Templates.ImportOffice365DeviceConfigurationPolicies {
    /// <summary>Provides operations to call the importOffice365DeviceConfigurationPolicies method.</summary>
    public class ImportOffice365DeviceConfigurationPoliciesResponse : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The value property</summary>
        public List<DeviceManagementIntent> Value { get; set; }
        /// <summary>
        /// Instantiates a new importOffice365DeviceConfigurationPoliciesResponse and sets the default values.
        /// </summary>
        public ImportOffice365DeviceConfigurationPoliciesResponse() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static ImportOffice365DeviceConfigurationPoliciesResponse CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ImportOffice365DeviceConfigurationPoliciesResponse();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"value", (o,n) => { (o as ImportOffice365DeviceConfigurationPoliciesResponse).Value = n.GetCollectionOfObjectValues<DeviceManagementIntent>(DeviceManagementIntent.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<DeviceManagementIntent>("value", Value);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
