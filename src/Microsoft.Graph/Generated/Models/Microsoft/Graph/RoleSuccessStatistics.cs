using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to call the completeSetup method.</summary>
    public class RoleSuccessStatistics : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public int? PermanentFail { get; set; }
        public int? PermanentSuccess { get; set; }
        public int? RemoveFail { get; set; }
        public int? RemoveSuccess { get; set; }
        public string RoleId { get; set; }
        public string RoleName { get; set; }
        public int? TemporaryFail { get; set; }
        public int? TemporarySuccess { get; set; }
        public int? UnknownFail { get; set; }
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
                {"permanentFail", (o,n) => { (o as RoleSuccessStatistics).PermanentFail = n.GetIntValue(); } },
                {"permanentSuccess", (o,n) => { (o as RoleSuccessStatistics).PermanentSuccess = n.GetIntValue(); } },
                {"removeFail", (o,n) => { (o as RoleSuccessStatistics).RemoveFail = n.GetIntValue(); } },
                {"removeSuccess", (o,n) => { (o as RoleSuccessStatistics).RemoveSuccess = n.GetIntValue(); } },
                {"roleId", (o,n) => { (o as RoleSuccessStatistics).RoleId = n.GetStringValue(); } },
                {"roleName", (o,n) => { (o as RoleSuccessStatistics).RoleName = n.GetStringValue(); } },
                {"temporaryFail", (o,n) => { (o as RoleSuccessStatistics).TemporaryFail = n.GetIntValue(); } },
                {"temporarySuccess", (o,n) => { (o as RoleSuccessStatistics).TemporarySuccess = n.GetIntValue(); } },
                {"unknownFail", (o,n) => { (o as RoleSuccessStatistics).UnknownFail = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("permanentFail", PermanentFail);
            writer.WriteIntValue("permanentSuccess", PermanentSuccess);
            writer.WriteIntValue("removeFail", RemoveFail);
            writer.WriteIntValue("removeSuccess", RemoveSuccess);
            writer.WriteStringValue("roleId", RoleId);
            writer.WriteStringValue("roleName", RoleName);
            writer.WriteIntValue("temporaryFail", TemporaryFail);
            writer.WriteIntValue("temporarySuccess", TemporarySuccess);
            writer.WriteIntValue("unknownFail", UnknownFail);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
