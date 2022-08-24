using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models.Security {
    public class UserAccount : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>The user account&apos;s displayed name.</summary>
        public string AccountName {
            get { return BackingStore?.Get<string>("accountName"); }
            set { BackingStore?.Set("accountName", value); }
        }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>The user object identifier in Azure AD.</summary>
        public string AzureAdUserId {
            get { return BackingStore?.Get<string>("azureAdUserId"); }
            set { BackingStore?.Set("azureAdUserId", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The name of the Active Directory domain of which the user is a member.</summary>
        public string DomainName {
            get { return BackingStore?.Get<string>("domainName"); }
            set { BackingStore?.Set("domainName", value); }
        }
        /// <summary>The OdataType property</summary>
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
        /// <summary>The user principal name of the account in Azure AD.</summary>
        public string UserPrincipalName {
            get { return BackingStore?.Get<string>("userPrincipalName"); }
            set { BackingStore?.Set("userPrincipalName", value); }
        }
        /// <summary>The local security identifier of the user account.</summary>
        public string UserSid {
            get { return BackingStore?.Get<string>("userSid"); }
            set { BackingStore?.Set("userSid", value); }
        }
        /// <summary>
        /// Instantiates a new userAccount and sets the default values.
        /// </summary>
        public UserAccount() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
            OdataType = "#microsoft.graph.security.userAccount";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static UserAccount CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UserAccount();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"accountName", n => { AccountName = n.GetStringValue(); } },
                {"azureAdUserId", n => { AzureAdUserId = n.GetStringValue(); } },
                {"domainName", n => { DomainName = n.GetStringValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"userPrincipalName", n => { UserPrincipalName = n.GetStringValue(); } },
                {"userSid", n => { UserSid = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("accountName", AccountName);
            writer.WriteStringValue("azureAdUserId", AzureAdUserId);
            writer.WriteStringValue("domainName", DomainName);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("userPrincipalName", UserPrincipalName);
            writer.WriteStringValue("userSid", UserSid);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
