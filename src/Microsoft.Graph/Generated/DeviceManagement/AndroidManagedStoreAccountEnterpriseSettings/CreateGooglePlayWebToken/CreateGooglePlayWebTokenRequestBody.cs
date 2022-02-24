using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.DeviceManagement.AndroidManagedStoreAccountEnterpriseSettings.CreateGooglePlayWebToken {
    public class CreateGooglePlayWebTokenRequestBody : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public string ParentUri { get; set; }
        /// <summary>
        /// Instantiates a new createGooglePlayWebTokenRequestBody and sets the default values.
        /// </summary>
        public CreateGooglePlayWebTokenRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"parentUri", (o,n) => { (o as CreateGooglePlayWebTokenRequestBody).ParentUri = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("parentUri", ParentUri);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
