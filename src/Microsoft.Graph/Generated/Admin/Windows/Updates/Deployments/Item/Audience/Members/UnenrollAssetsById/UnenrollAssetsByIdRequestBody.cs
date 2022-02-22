using Microsoft.Kiota.Abstractions.Serialization;
using MicrosoftGraph.Models.Microsoft.Graph.WindowsUpdates;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Admin.Windows.Updates.Deployments.Item.Audience.Members.UnenrollAssetsById {
    public class UnenrollAssetsByIdRequestBody : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public List<string> Ids { get; set; }
        public string MemberEntityType { get; set; }
        public UpdateCategory? UpdateCategory { get; set; }
        /// <summary>
        /// Instantiates a new unenrollAssetsByIdRequestBody and sets the default values.
        /// </summary>
        public UnenrollAssetsByIdRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"ids", (o,n) => { (o as UnenrollAssetsByIdRequestBody).Ids = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"memberEntityType", (o,n) => { (o as UnenrollAssetsByIdRequestBody).MemberEntityType = n.GetStringValue(); } },
                {"updateCategory", (o,n) => { (o as UnenrollAssetsByIdRequestBody).UpdateCategory = n.GetEnumValue<UpdateCategory>(); } },
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
            writer.WriteEnumValue<UpdateCategory>("updateCategory", UpdateCategory);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
