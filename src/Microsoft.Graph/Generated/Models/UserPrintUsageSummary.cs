using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class UserPrintUsageSummary : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The completedJobCount property</summary>
        public int? CompletedJobCount {
            get { return BackingStore?.Get<int?>("completedJobCount"); }
            set { BackingStore?.Set("completedJobCount", value); }
        }
        /// <summary>The incompleteJobCount property</summary>
        public int? IncompleteJobCount {
            get { return BackingStore?.Get<int?>("incompleteJobCount"); }
            set { BackingStore?.Set("incompleteJobCount", value); }
        }
        /// <summary>The OdataType property</summary>
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
        /// <summary>The user property</summary>
        public Identity User {
            get { return BackingStore?.Get<Identity>("user"); }
            set { BackingStore?.Set("user", value); }
        }
        /// <summary>The userDisplayName property</summary>
        public string UserDisplayName {
            get { return BackingStore?.Get<string>("userDisplayName"); }
            set { BackingStore?.Set("userDisplayName", value); }
        }
        /// <summary>The userPrincipalName property</summary>
        public string UserPrincipalName {
            get { return BackingStore?.Get<string>("userPrincipalName"); }
            set { BackingStore?.Set("userPrincipalName", value); }
        }
        /// <summary>
        /// Instantiates a new userPrintUsageSummary and sets the default values.
        /// </summary>
        public UserPrintUsageSummary() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static UserPrintUsageSummary CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UserPrintUsageSummary();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"completedJobCount", n => { CompletedJobCount = n.GetIntValue(); } },
                {"incompleteJobCount", n => { IncompleteJobCount = n.GetIntValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"user", n => { User = n.GetObjectValue<Identity>(Identity.CreateFromDiscriminatorValue); } },
                {"userDisplayName", n => { UserDisplayName = n.GetStringValue(); } },
                {"userPrincipalName", n => { UserPrincipalName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("completedJobCount", CompletedJobCount);
            writer.WriteIntValue("incompleteJobCount", IncompleteJobCount);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteObjectValue<Identity>("user", User);
            writer.WriteStringValue("userDisplayName", UserDisplayName);
            writer.WriteStringValue("userPrincipalName", UserPrincipalName);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
