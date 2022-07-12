using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>iOS available update version details</summary>
    public class IosAvailableUpdateVersion : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The expiration date of the update.</summary>
        public DateTimeOffset? ExpirationDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("expirationDateTime"); }
            set { BackingStore?.Set("expirationDateTime", value); }
        }
        /// <summary>The posting date of the update.</summary>
        public DateTimeOffset? PostingDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("postingDateTime"); }
            set { BackingStore?.Set("postingDateTime", value); }
        }
        /// <summary>The version of the update.</summary>
        public string ProductVersion {
            get { return BackingStore?.Get<string>("productVersion"); }
            set { BackingStore?.Set("productVersion", value); }
        }
        /// <summary>List of supported devices for the update.</summary>
        public List<string> SupportedDevices {
            get { return BackingStore?.Get<List<string>>("supportedDevices"); }
            set { BackingStore?.Set("supportedDevices", value); }
        }
        /// <summary>
        /// Instantiates a new iosAvailableUpdateVersion and sets the default values.
        /// </summary>
        public IosAvailableUpdateVersion() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static IosAvailableUpdateVersion CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new IosAvailableUpdateVersion();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"expirationDateTime", n => { ExpirationDateTime = n.GetDateTimeOffsetValue(); } },
                {"postingDateTime", n => { PostingDateTime = n.GetDateTimeOffsetValue(); } },
                {"productVersion", n => { ProductVersion = n.GetStringValue(); } },
                {"supportedDevices", n => { SupportedDevices = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDateTimeOffsetValue("expirationDateTime", ExpirationDateTime);
            writer.WriteDateTimeOffsetValue("postingDateTime", PostingDateTime);
            writer.WriteStringValue("productVersion", ProductVersion);
            writer.WriteCollectionOfPrimitiveValues<string>("supportedDevices", SupportedDevices);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
