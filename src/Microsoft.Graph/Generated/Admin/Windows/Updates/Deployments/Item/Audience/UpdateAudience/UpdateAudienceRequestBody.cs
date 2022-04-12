using Microsoft.Graph.Beta.Models.WindowsUpdates;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Admin.Windows.Updates.Deployments.Item.Audience.UpdateAudience {
    /// <summary>Provides operations to call the updateAudience method.</summary>
    public class UpdateAudienceRequestBody : IAdditionalDataHolder, IParsable {
        /// <summary>The addExclusions property</summary>
        public List<UpdatableAsset> AddExclusions { get; set; }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The addMembers property</summary>
        public List<UpdatableAsset> AddMembers { get; set; }
        /// <summary>The removeExclusions property</summary>
        public List<UpdatableAsset> RemoveExclusions { get; set; }
        /// <summary>The removeMembers property</summary>
        public List<UpdatableAsset> RemoveMembers { get; set; }
        /// <summary>
        /// Instantiates a new updateAudienceRequestBody and sets the default values.
        /// </summary>
        public UpdateAudienceRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static UpdateAudienceRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UpdateAudienceRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"addExclusions", n => { AddExclusions = n.GetCollectionOfObjectValues<UpdatableAsset>(UpdatableAsset.CreateFromDiscriminatorValue).ToList(); } },
                {"addMembers", n => { AddMembers = n.GetCollectionOfObjectValues<UpdatableAsset>(UpdatableAsset.CreateFromDiscriminatorValue).ToList(); } },
                {"removeExclusions", n => { RemoveExclusions = n.GetCollectionOfObjectValues<UpdatableAsset>(UpdatableAsset.CreateFromDiscriminatorValue).ToList(); } },
                {"removeMembers", n => { RemoveMembers = n.GetCollectionOfObjectValues<UpdatableAsset>(UpdatableAsset.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<UpdatableAsset>("addExclusions", AddExclusions);
            writer.WriteCollectionOfObjectValues<UpdatableAsset>("addMembers", AddMembers);
            writer.WriteCollectionOfObjectValues<UpdatableAsset>("removeExclusions", RemoveExclusions);
            writer.WriteCollectionOfObjectValues<UpdatableAsset>("removeMembers", RemoveMembers);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
