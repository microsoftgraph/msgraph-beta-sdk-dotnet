using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class RecentNotebookLinks : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The OdataType property</summary>
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
        /// <summary>Opens the notebook in the OneNote client, if it&apos;s installed.</summary>
        public ExternalLink OneNoteClientUrl {
            get { return BackingStore?.Get<ExternalLink>("oneNoteClientUrl"); }
            set { BackingStore?.Set("oneNoteClientUrl", value); }
        }
        /// <summary>Opens the notebook in OneNote on the web.</summary>
        public ExternalLink OneNoteWebUrl {
            get { return BackingStore?.Get<ExternalLink>("oneNoteWebUrl"); }
            set { BackingStore?.Set("oneNoteWebUrl", value); }
        }
        /// <summary>
        /// Instantiates a new recentNotebookLinks and sets the default values.
        /// </summary>
        public RecentNotebookLinks() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static RecentNotebookLinks CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new RecentNotebookLinks();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"oneNoteClientUrl", n => { OneNoteClientUrl = n.GetObjectValue<ExternalLink>(ExternalLink.CreateFromDiscriminatorValue); } },
                {"oneNoteWebUrl", n => { OneNoteWebUrl = n.GetObjectValue<ExternalLink>(ExternalLink.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteObjectValue<ExternalLink>("oneNoteClientUrl", OneNoteClientUrl);
            writer.WriteObjectValue<ExternalLink>("oneNoteWebUrl", OneNoteWebUrl);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
