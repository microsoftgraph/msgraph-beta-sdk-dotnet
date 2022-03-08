using Microsoft.Kiota.Abstractions.Serialization;
using MicrosoftGraphSdk.Models.Microsoft.Graph.WindowsUpdates;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Admin.Windows.Updates.UpdatableAssets.UnenrollAssets {
    /// <summary>Provides operations to call the unenrollAssets method.</summary>
    public class UnenrollAssetsRequestBody : IParsable, IAdditionalDataHolder {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public List<UpdatableAsset> Assets { get; set; }
        public MicrosoftGraphSdk.Models.Microsoft.Graph.WindowsUpdates.UpdateCategory? UpdateCategory { get; set; }
        /// <summary>
        /// Instantiates a new unenrollAssetsRequestBody and sets the default values.
        /// </summary>
        public UnenrollAssetsRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static UnenrollAssetsRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UnenrollAssetsRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"assets", (o,n) => { (o as UnenrollAssetsRequestBody).Assets = n.GetCollectionOfObjectValues<UpdatableAsset>(UpdatableAsset.CreateFromDiscriminatorValue).ToList(); } },
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
