using Microsoft.Kiota.Abstractions.Serialization;
using MicrosoftGraphSdk.Models.Microsoft.Graph;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Users.Item.GetEffectiveDeviceEnrollmentConfigurations {
    /// <summary>Provides operations to call the getEffectiveDeviceEnrollmentConfigurations method.</summary>
    public class GetEffectiveDeviceEnrollmentConfigurationsResponse : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The value property</summary>
        public List<DeviceEnrollmentConfiguration> Value { get; set; }
        /// <summary>
        /// Instantiates a new getEffectiveDeviceEnrollmentConfigurationsResponse and sets the default values.
        /// </summary>
        public GetEffectiveDeviceEnrollmentConfigurationsResponse() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static GetEffectiveDeviceEnrollmentConfigurationsResponse CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new GetEffectiveDeviceEnrollmentConfigurationsResponse();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"value", (o,n) => { (o as GetEffectiveDeviceEnrollmentConfigurationsResponse).Value = n.GetCollectionOfObjectValues<DeviceEnrollmentConfiguration>(DeviceEnrollmentConfiguration.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<DeviceEnrollmentConfiguration>("value", Value);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
