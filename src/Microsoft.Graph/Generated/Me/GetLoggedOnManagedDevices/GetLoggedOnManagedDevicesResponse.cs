using Microsoft.Kiota.Abstractions.Serialization;
using MicrosoftGraphSdk.Models.Microsoft.Graph;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Me.GetLoggedOnManagedDevices {
    /// <summary>Provides operations to call the getLoggedOnManagedDevices method.</summary>
    public class GetLoggedOnManagedDevicesResponse : IParsable, IAdditionalDataHolder {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public List<MicrosoftGraphSdk.Models.Microsoft.Graph.ManagedDevice> Value { get; set; }
        /// <summary>
        /// Instantiates a new getLoggedOnManagedDevicesResponse and sets the default values.
        /// </summary>
        public GetLoggedOnManagedDevicesResponse() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static GetLoggedOnManagedDevicesResponse CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new GetLoggedOnManagedDevicesResponse();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"value", (o,n) => { (o as GetLoggedOnManagedDevicesResponse).Value = n.GetCollectionOfObjectValues<MicrosoftGraphSdk.Models.Microsoft.Graph.ManagedDevice>(MicrosoftGraphSdk.Models.Microsoft.Graph.ManagedDevice.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<MicrosoftGraphSdk.Models.Microsoft.Graph.ManagedDevice>("value", Value);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
