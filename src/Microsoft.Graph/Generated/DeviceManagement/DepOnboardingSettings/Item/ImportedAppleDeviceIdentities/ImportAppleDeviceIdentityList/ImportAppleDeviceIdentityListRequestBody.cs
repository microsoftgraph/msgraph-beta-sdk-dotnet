using Microsoft.Kiota.Abstractions.Serialization;
using MicrosoftGraphSdk.Models.Microsoft.Graph;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.DeviceManagement.DepOnboardingSettings.Item.ImportedAppleDeviceIdentities.ImportAppleDeviceIdentityList {
    public class ImportAppleDeviceIdentityListRequestBody : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public List<ImportedAppleDeviceIdentity> ImportedAppleDeviceIdentities { get; set; }
        public bool? OverwriteImportedDeviceIdentities { get; set; }
        /// <summary>
        /// Instantiates a new importAppleDeviceIdentityListRequestBody and sets the default values.
        /// </summary>
        public ImportAppleDeviceIdentityListRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static ImportAppleDeviceIdentityListRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ImportAppleDeviceIdentityListRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"importedAppleDeviceIdentities", (o,n) => { (o as ImportAppleDeviceIdentityListRequestBody).ImportedAppleDeviceIdentities = n.GetCollectionOfObjectValues<ImportedAppleDeviceIdentity>(ImportedAppleDeviceIdentity.CreateFromDiscriminatorValue).ToList(); } },
                {"overwriteImportedDeviceIdentities", (o,n) => { (o as ImportAppleDeviceIdentityListRequestBody).OverwriteImportedDeviceIdentities = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<ImportedAppleDeviceIdentity>("importedAppleDeviceIdentities", ImportedAppleDeviceIdentities);
            writer.WriteBoolValue("overwriteImportedDeviceIdentities", OverwriteImportedDeviceIdentities);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
