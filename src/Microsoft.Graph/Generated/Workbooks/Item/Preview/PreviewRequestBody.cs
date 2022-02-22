using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Workbooks.Item.Preview {
    public class PreviewRequestBody : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public bool? AllowEdit { get; set; }
        public bool? Chromeless { get; set; }
        public string Page { get; set; }
        public string Viewer { get; set; }
        public double? Zoom { get; set; }
        /// <summary>
        /// Instantiates a new previewRequestBody and sets the default values.
        /// </summary>
        public PreviewRequestBody() {
            AdditionalData = new Dictionary<string, object>();
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
