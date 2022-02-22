using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Admin.Windows.Updates.Deployments.Item.Audience.Members.Item.RemoveMembersById {
    public class RemoveMembersByIdRequestBody : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public List<string> Ids { get; set; }
        public string MemberEntityType { get; set; }
        /// <summary>
        /// Instantiates a new removeMembersByIdRequestBody and sets the default values.
        /// </summary>
        public RemoveMembersByIdRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"ids", (o,n) => { (o as RemoveMembersByIdRequestBody).Ids = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"memberEntityType", (o,n) => { (o as RemoveMembersByIdRequestBody).MemberEntityType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfPrimitiveValues<string>("ids", Ids);
            writer.WriteStringValue("memberEntityType", MemberEntityType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
