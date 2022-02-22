using Microsoft.Kiota.Abstractions.Serialization;
using MicrosoftGraph.Models.Microsoft.Graph.WindowsUpdates;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Admin.Windows.Updates.Deployments.Item.Audience.UpdateAudience {
    public class UpdateAudienceRequestBody : IParsable {
        public List<UpdatableAsset> AddExclusions { get; set; }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public List<UpdatableAsset> AddMembers { get; set; }
        public List<UpdatableAsset> RemoveExclusions { get; set; }
        public List<UpdatableAsset> RemoveMembers { get; set; }
        /// <summary>
        /// Instantiates a new updateAudienceRequestBody and sets the default values.
        /// </summary>
        public UpdateAudienceRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"addExclusions", (o,n) => { (o as UpdateAudienceRequestBody).AddExclusions = n.GetCollectionOfObjectValues<UpdatableAsset>().ToList(); } },
                {"addMembers", (o,n) => { (o as UpdateAudienceRequestBody).AddMembers = n.GetCollectionOfObjectValues<UpdatableAsset>().ToList(); } },
                {"removeExclusions", (o,n) => { (o as UpdateAudienceRequestBody).RemoveExclusions = n.GetCollectionOfObjectValues<UpdatableAsset>().ToList(); } },
                {"removeMembers", (o,n) => { (o as UpdateAudienceRequestBody).RemoveMembers = n.GetCollectionOfObjectValues<UpdatableAsset>().ToList(); } },
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
