using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>A mapping of application identifiers to associated domains.</summary>
    public class MacOSAssociatedDomainsItem : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>The application identifier of the app to associate domains with.</summary>
        public string ApplicationIdentifier {
            get { return BackingStore?.Get<string>("applicationIdentifier"); }
            set { BackingStore?.Set("applicationIdentifier", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Determines whether data should be downloaded directly or via a CDN.</summary>
        public bool? DirectDownloadsEnabled {
            get { return BackingStore?.Get<bool?>("directDownloadsEnabled"); }
            set { BackingStore?.Set("directDownloadsEnabled", value); }
        }
        /// <summary>The list of domains to associate.</summary>
        public List<string> Domains {
            get { return BackingStore?.Get<List<string>>("domains"); }
            set { BackingStore?.Set("domains", value); }
        }
        /// <summary>
        /// Instantiates a new macOSAssociatedDomainsItem and sets the default values.
        /// </summary>
        public MacOSAssociatedDomainsItem() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static MacOSAssociatedDomainsItem CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MacOSAssociatedDomainsItem();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"applicationIdentifier", n => { ApplicationIdentifier = n.GetStringValue(); } },
                {"directDownloadsEnabled", n => { DirectDownloadsEnabled = n.GetBoolValue(); } },
                {"domains", n => { Domains = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("applicationIdentifier", ApplicationIdentifier);
            writer.WriteBoolValue("directDownloadsEnabled", DirectDownloadsEnabled);
            writer.WriteCollectionOfPrimitiveValues<string>("domains", Domains);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
