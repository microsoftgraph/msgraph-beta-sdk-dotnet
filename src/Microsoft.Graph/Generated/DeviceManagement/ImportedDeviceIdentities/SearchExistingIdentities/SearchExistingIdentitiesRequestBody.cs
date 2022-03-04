using Microsoft.Kiota.Abstractions.Serialization;
using MicrosoftGraphSdk.Models.Microsoft.Graph;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.DeviceManagement.ImportedDeviceIdentities.SearchExistingIdentities {
    public class SearchExistingIdentitiesRequestBody : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public List<ImportedDeviceIdentity> ImportedDeviceIdentities { get; set; }
        /// <summary>
        /// Instantiates a new searchExistingIdentitiesRequestBody and sets the default values.
        /// </summary>
        public SearchExistingIdentitiesRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static SearchExistingIdentitiesRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SearchExistingIdentitiesRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"importedDeviceIdentities", (o,n) => { (o as SearchExistingIdentitiesRequestBody).ImportedDeviceIdentities = n.GetCollectionOfObjectValues<ImportedDeviceIdentity>(ImportedDeviceIdentity.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<ImportedDeviceIdentity>("importedDeviceIdentities", ImportedDeviceIdentities);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
