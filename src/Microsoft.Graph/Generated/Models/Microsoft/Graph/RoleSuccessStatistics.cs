using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class RoleSuccessStatistics : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public long? PermanentFail { get; set; }
        public long? PermanentSuccess { get; set; }
        public long? RemoveFail { get; set; }
        public long? RemoveSuccess { get; set; }
        public string RoleId { get; set; }
        public string RoleName { get; set; }
        public long? TemporaryFail { get; set; }
        public long? TemporarySuccess { get; set; }
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
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"permanentFail", (o,n) => { (o as RoleSuccessStatistics).PermanentFail = n.GetLongValue(); } },
                {"permanentSuccess", (o,n) => { (o as RoleSuccessStatistics).PermanentSuccess = n.GetLongValue(); } },
                {"removeFail", (o,n) => { (o as RoleSuccessStatistics).RemoveFail = n.GetLongValue(); } },
                {"removeSuccess", (o,n) => { (o as RoleSuccessStatistics).RemoveSuccess = n.GetLongValue(); } },
                {"roleId", (o,n) => { (o as RoleSuccessStatistics).RoleId = n.GetStringValue(); } },
                {"roleName", (o,n) => { (o as RoleSuccessStatistics).RoleName = n.GetStringValue(); } },
                {"temporaryFail", (o,n) => { (o as RoleSuccessStatistics).TemporaryFail = n.GetLongValue(); } },
                {"temporarySuccess", (o,n) => { (o as RoleSuccessStatistics).TemporarySuccess = n.GetLongValue(); } },
                {"unknownFail", (o,n) => { (o as RoleSuccessStatistics).UnknownFail = n.GetLongValue(); } },
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
