using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class RoleSuccessStatistics : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The permanentFail property</summary>
        public long? PermanentFail { get; set; }
        /// <summary>The permanentSuccess property</summary>
        public long? PermanentSuccess { get; set; }
        /// <summary>The removeFail property</summary>
        public long? RemoveFail { get; set; }
        /// <summary>The removeSuccess property</summary>
        public long? RemoveSuccess { get; set; }
        /// <summary>The roleId property</summary>
        public string RoleId { get; set; }
        /// <summary>The roleName property</summary>
        public string RoleName { get; set; }
        /// <summary>The temporaryFail property</summary>
        public long? TemporaryFail { get; set; }
        /// <summary>The temporarySuccess property</summary>
        public long? TemporarySuccess { get; set; }
        /// <summary>The unknownFail property</summary>
        public long? UnknownFail { get; set; }
        /// <summary>
        /// Instantiates a new roleSuccessStatistics and sets the default values.
        /// </summary>
        public RoleSuccessStatistics() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static RoleSuccessStatistics CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new RoleSuccessStatistics();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"permanentFail", n => { PermanentFail = n.GetLongValue(); } },
                {"permanentSuccess", n => { PermanentSuccess = n.GetLongValue(); } },
                {"removeFail", n => { RemoveFail = n.GetLongValue(); } },
                {"removeSuccess", n => { RemoveSuccess = n.GetLongValue(); } },
                {"roleId", n => { RoleId = n.GetStringValue(); } },
                {"roleName", n => { RoleName = n.GetStringValue(); } },
                {"temporaryFail", n => { TemporaryFail = n.GetLongValue(); } },
                {"temporarySuccess", n => { TemporarySuccess = n.GetLongValue(); } },
                {"unknownFail", n => { UnknownFail = n.GetLongValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteLongValue("permanentFail", PermanentFail);
            writer.WriteLongValue("permanentSuccess", PermanentSuccess);
            writer.WriteLongValue("removeFail", RemoveFail);
            writer.WriteLongValue("removeSuccess", RemoveSuccess);
            writer.WriteStringValue("roleId", RoleId);
            writer.WriteStringValue("roleName", RoleName);
            writer.WriteLongValue("temporaryFail", TemporaryFail);
            writer.WriteLongValue("temporarySuccess", TemporarySuccess);
            writer.WriteLongValue("unknownFail", UnknownFail);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
