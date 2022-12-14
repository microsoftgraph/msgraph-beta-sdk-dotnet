using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.DeviceAppManagement.VppTokens.Item.RevokeLicenses {
    /// <summary>
    /// Provides operations to call the revokeLicenses method.
    /// </summary>
    public class RevokeLicensesPostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The notifyManagedDevices property</summary>
        public bool? NotifyManagedDevices {
            get { return BackingStore?.Get<bool?>("notifyManagedDevices"); }
            set { BackingStore?.Set("notifyManagedDevices", value); }
        }
        /// <summary>The revokeUntrackedLicenses property</summary>
        public bool? RevokeUntrackedLicenses {
            get { return BackingStore?.Get<bool?>("revokeUntrackedLicenses"); }
            set { BackingStore?.Set("revokeUntrackedLicenses", value); }
        }
        /// <summary>
        /// Instantiates a new revokeLicensesPostRequestBody and sets the default values.
        /// </summary>
        public RevokeLicensesPostRequestBody() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static RevokeLicensesPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new RevokeLicensesPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"notifyManagedDevices", n => { NotifyManagedDevices = n.GetBoolValue(); } },
                {"revokeUntrackedLicenses", n => { RevokeUntrackedLicenses = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("notifyManagedDevices", NotifyManagedDevices);
            writer.WriteBoolValue("revokeUntrackedLicenses", RevokeUntrackedLicenses);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
