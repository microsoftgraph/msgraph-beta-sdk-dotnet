using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.DeviceManagement.AndroidManagedStoreAccountEnterpriseSettings.RequestSignupUrl {
    /// <summary>Provides operations to call the requestSignupUrl method.</summary>
    public class RequestSignupUrlRequestBody : IParsable, IAdditionalDataHolder {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public string HostName { get; set; }
        /// <summary>
        /// Instantiates a new requestSignupUrlRequestBody and sets the default values.
        /// </summary>
        public RequestSignupUrlRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static RequestSignupUrlRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new RequestSignupUrlRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"hostName", (o,n) => { (o as RequestSignupUrlRequestBody).HostName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("hostName", HostName);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
