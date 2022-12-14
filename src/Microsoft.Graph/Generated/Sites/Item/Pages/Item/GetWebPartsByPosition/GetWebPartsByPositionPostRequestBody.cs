using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Sites.Item.Pages.Item.GetWebPartsByPosition {
    /// <summary>
    /// Provides operations to call the getWebPartsByPosition method.
    /// </summary>
    public class GetWebPartsByPositionPostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The columnId property</summary>
        public double? ColumnId {
            get { return BackingStore?.Get<double?>("columnId"); }
            set { BackingStore?.Set("columnId", value); }
        }
        /// <summary>The horizontalSectionId property</summary>
        public double? HorizontalSectionId {
            get { return BackingStore?.Get<double?>("horizontalSectionId"); }
            set { BackingStore?.Set("horizontalSectionId", value); }
        }
        /// <summary>The isInVerticalSection property</summary>
        public bool? IsInVerticalSection {
            get { return BackingStore?.Get<bool?>("isInVerticalSection"); }
            set { BackingStore?.Set("isInVerticalSection", value); }
        }
        /// <summary>The webPartIndex property</summary>
        public double? WebPartIndex {
            get { return BackingStore?.Get<double?>("webPartIndex"); }
            set { BackingStore?.Set("webPartIndex", value); }
        }
        /// <summary>
        /// Instantiates a new getWebPartsByPositionPostRequestBody and sets the default values.
        /// </summary>
        public GetWebPartsByPositionPostRequestBody() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static GetWebPartsByPositionPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new GetWebPartsByPositionPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"columnId", n => { ColumnId = n.GetDoubleValue(); } },
                {"horizontalSectionId", n => { HorizontalSectionId = n.GetDoubleValue(); } },
                {"isInVerticalSection", n => { IsInVerticalSection = n.GetBoolValue(); } },
                {"webPartIndex", n => { WebPartIndex = n.GetDoubleValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDoubleValue("columnId", ColumnId);
            writer.WriteDoubleValue("horizontalSectionId", HorizontalSectionId);
            writer.WriteBoolValue("isInVerticalSection", IsInVerticalSection);
            writer.WriteDoubleValue("webPartIndex", WebPartIndex);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
