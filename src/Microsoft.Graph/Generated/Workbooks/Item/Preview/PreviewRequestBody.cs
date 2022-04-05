using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Workbooks.Item.Preview {
    /// <summary>Provides operations to call the preview method.</summary>
    public class PreviewRequestBody : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The allowEdit property</summary>
        public bool? AllowEdit { get; set; }
        /// <summary>The chromeless property</summary>
        public bool? Chromeless { get; set; }
        /// <summary>The page property</summary>
        public string Page { get; set; }
        /// <summary>The viewer property</summary>
        public string Viewer { get; set; }
        /// <summary>The zoom property</summary>
        public double? Zoom { get; set; }
        /// <summary>
        /// Instantiates a new previewRequestBody and sets the default values.
        /// </summary>
        public PreviewRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static PreviewRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PreviewRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"allowEdit", (o,n) => { (o as PreviewRequestBody).AllowEdit = n.GetBoolValue(); } },
                {"chromeless", (o,n) => { (o as PreviewRequestBody).Chromeless = n.GetBoolValue(); } },
                {"page", (o,n) => { (o as PreviewRequestBody).Page = n.GetStringValue(); } },
                {"viewer", (o,n) => { (o as PreviewRequestBody).Viewer = n.GetStringValue(); } },
                {"zoom", (o,n) => { (o as PreviewRequestBody).Zoom = n.GetDoubleValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("allowEdit", AllowEdit);
            writer.WriteBoolValue("chromeless", Chromeless);
            writer.WriteStringValue("page", Page);
            writer.WriteStringValue("viewer", Viewer);
            writer.WriteDoubleValue("zoom", Zoom);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
