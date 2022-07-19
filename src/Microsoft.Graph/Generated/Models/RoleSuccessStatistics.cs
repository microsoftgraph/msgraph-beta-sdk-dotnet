using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class RoleSuccessStatistics : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The OdataType property</summary>
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
        /// <summary>The permanentFail property</summary>
        public long? PermanentFail {
            get { return BackingStore?.Get<long?>("permanentFail"); }
            set { BackingStore?.Set("permanentFail", value); }
        }
        /// <summary>The permanentSuccess property</summary>
        public long? PermanentSuccess {
            get { return BackingStore?.Get<long?>("permanentSuccess"); }
            set { BackingStore?.Set("permanentSuccess", value); }
        }
        /// <summary>The removeFail property</summary>
        public long? RemoveFail {
            get { return BackingStore?.Get<long?>("removeFail"); }
            set { BackingStore?.Set("removeFail", value); }
        }
        /// <summary>The removeSuccess property</summary>
        public long? RemoveSuccess {
            get { return BackingStore?.Get<long?>("removeSuccess"); }
            set { BackingStore?.Set("removeSuccess", value); }
        }
        /// <summary>The roleId property</summary>
        public string RoleId {
            get { return BackingStore?.Get<string>("roleId"); }
            set { BackingStore?.Set("roleId", value); }
        }
        /// <summary>The roleName property</summary>
        public string RoleName {
            get { return BackingStore?.Get<string>("roleName"); }
            set { BackingStore?.Set("roleName", value); }
        }
        /// <summary>The temporaryFail property</summary>
        public long? TemporaryFail {
            get { return BackingStore?.Get<long?>("temporaryFail"); }
            set { BackingStore?.Set("temporaryFail", value); }
        }
        /// <summary>The temporarySuccess property</summary>
        public long? TemporarySuccess {
            get { return BackingStore?.Get<long?>("temporarySuccess"); }
            set { BackingStore?.Set("temporarySuccess", value); }
        }
        /// <summary>The unknownFail property</summary>
        public long? UnknownFail {
            get { return BackingStore?.Get<long?>("unknownFail"); }
            set { BackingStore?.Set("unknownFail", value); }
        }
        /// <summary>
        /// Instantiates a new roleSuccessStatistics and sets the default values.
        /// </summary>
        public RoleSuccessStatistics() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
            OdataType = "#microsoft.graph.roleSuccessStatistics";
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
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
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
            writer.WriteStringValue("@odata.type", OdataType);
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
