using Microsoft.Kiota.Abstractions.Serialization;
using MicrosoftGraph.Models.Microsoft.Graph.WindowsUpdates;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Admin.Windows.Updates.UpdatableAssets.UnenrollAssets {
    public class UnenrollAssetsRequestBody : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public List<UpdatableAsset> Assets { get; set; }
        public UpdateCategory? UpdateCategory { get; set; }
        /// <summary>
        /// Instantiates a new unenrollAssetsRequestBody and sets the default values.
        /// </summary>
        public UnenrollAssetsRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"assets", (o,n) => { (o as UnenrollAssetsRequestBody).Assets = n.GetCollectionOfObjectValues<UpdatableAsset>().ToList(); } },
                {"updateCategory", (o,n) => { (o as UnenrollAssetsRequestBody).UpdateCategory = n.GetEnumValue<UpdateCategory>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<UpdatableAsset>("assets", Assets);
            writer.WriteEnumValue<UpdateCategory>("updateCategory", UpdateCategory);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
