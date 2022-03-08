using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Admin.Windows.Updates.Deployments.Item.Audience.Members.Item.AddMembersById {
    /// <summary>Provides operations to call the addMembersById method.</summary>
    public class AddMembersByIdRequestBody : IParsable, IAdditionalDataHolder {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public List<string> Ids { get; set; }
        public string MemberEntityType { get; set; }
        /// <summary>
        /// Instantiates a new addMembersByIdRequestBody and sets the default values.
        /// </summary>
        public AddMembersByIdRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static AddMembersByIdRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AddMembersByIdRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"ids", (o,n) => { (o as AddMembersByIdRequestBody).Ids = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"memberEntityType", (o,n) => { (o as AddMembersByIdRequestBody).MemberEntityType = n.GetStringValue(); } },
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
