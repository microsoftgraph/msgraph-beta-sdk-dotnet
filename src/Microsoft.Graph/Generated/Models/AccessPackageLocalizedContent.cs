using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class AccessPackageLocalizedContent : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The fallback string, which is used when a requested localization is not available. Required.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DefaultText {
            get { return BackingStore?.Get<string?>("defaultText"); }
            set { BackingStore?.Set("defaultText", value); }
        }
#nullable restore
#else
        public string DefaultText {
            get { return BackingStore?.Get<string>("defaultText"); }
            set { BackingStore?.Set("defaultText", value); }
        }
#endif
        /// <summary>Content represented in a format for a specific locale.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AccessPackageLocalizedText>? LocalizedTexts {
            get { return BackingStore?.Get<List<AccessPackageLocalizedText>?>("localizedTexts"); }
            set { BackingStore?.Set("localizedTexts", value); }
        }
#nullable restore
#else
        public List<AccessPackageLocalizedText> LocalizedTexts {
            get { return BackingStore?.Get<List<AccessPackageLocalizedText>>("localizedTexts"); }
            set { BackingStore?.Set("localizedTexts", value); }
        }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType {
            get { return BackingStore?.Get<string?>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#nullable restore
#else
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new accessPackageLocalizedContent and sets the default values.
        /// </summary>
        public AccessPackageLocalizedContent() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static AccessPackageLocalizedContent CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AccessPackageLocalizedContent();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"defaultText", n => { DefaultText = n.GetStringValue(); } },
                {"localizedTexts", n => { LocalizedTexts = n.GetCollectionOfObjectValues<AccessPackageLocalizedText>(AccessPackageLocalizedText.CreateFromDiscriminatorValue)?.ToList(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("defaultText", DefaultText);
            writer.WriteCollectionOfObjectValues<AccessPackageLocalizedText>("localizedTexts", LocalizedTexts);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
