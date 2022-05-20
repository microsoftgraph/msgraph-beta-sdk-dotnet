using Microsoft.Graph.Beta.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.DeviceManagement.ImportedDeviceIdentities.ImportDeviceIdentityList {
    /// <summary>Provides operations to call the importDeviceIdentityList method.</summary>
    public class ImportDeviceIdentityListPostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The importedDeviceIdentities property</summary>
        public List<ImportedDeviceIdentity> ImportedDeviceIdentities {
            get { return BackingStore?.Get<List<ImportedDeviceIdentity>>(nameof(ImportedDeviceIdentities)); }
            set { BackingStore?.Set(nameof(ImportedDeviceIdentities), value); }
        }
        /// <summary>The overwriteImportedDeviceIdentities property</summary>
        public bool? OverwriteImportedDeviceIdentities {
            get { return BackingStore?.Get<bool?>(nameof(OverwriteImportedDeviceIdentities)); }
            set { BackingStore?.Set(nameof(OverwriteImportedDeviceIdentities), value); }
        }
        /// <summary>
        /// Instantiates a new importDeviceIdentityListPostRequestBody and sets the default values.
        /// </summary>
        public ImportDeviceIdentityListPostRequestBody() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static ImportDeviceIdentityListPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ImportDeviceIdentityListPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"importedDeviceIdentities", n => { ImportedDeviceIdentities = n.GetCollectionOfObjectValues<ImportedDeviceIdentity>(ImportedDeviceIdentity.CreateFromDiscriminatorValue).ToList(); } },
                {"overwriteImportedDeviceIdentities", n => { OverwriteImportedDeviceIdentities = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<ImportedDeviceIdentity>("importedDeviceIdentities", ImportedDeviceIdentities);
            writer.WriteBoolValue("overwriteImportedDeviceIdentities", OverwriteImportedDeviceIdentities);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
