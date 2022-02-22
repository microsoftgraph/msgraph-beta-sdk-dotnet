using Microsoft.Kiota.Abstractions.Serialization;
using MicrosoftGraph.Models.Microsoft.Graph;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.DeviceManagement.DepOnboardingSettings.Item.ImportedAppleDeviceIdentities.ImportAppleDeviceIdentityList {
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
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"importedAppleDeviceIdentities", (o,n) => { (o as ImportAppleDeviceIdentityListRequestBody).ImportedAppleDeviceIdentities = n.GetCollectionOfObjectValues<ImportedAppleDeviceIdentity>().ToList(); } },
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
