using Microsoft.Kiota.Abstractions.Serialization;
using MicrosoftGraph.Models.Microsoft.Graph.WindowsUpdates;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Admin.Windows.Updates.Deployments.Item.Audience.Exclusions.Item.RemoveMembers {
    public class RemoveMembersRequestBody : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public List<UpdatableAsset> Assets { get; set; }
        /// <summary>
        /// Instantiates a new removeMembersRequestBody and sets the default values.
        /// </summary>
        public RemoveMembersRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"assets", (o,n) => { (o as RemoveMembersRequestBody).Assets = n.GetCollectionOfObjectValues<UpdatableAsset>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<UpdatableAsset>("assets", Assets);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
