using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models.Security {
    public class UserAccount : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>The accountName property</summary>
        public string AccountName {
            get { return BackingStore?.Get<string>(nameof(AccountName)); }
            set { BackingStore?.Set(nameof(AccountName), value); }
        }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>The azureAdUserId property</summary>
        public string AzureAdUserId {
            get { return BackingStore?.Get<string>(nameof(AzureAdUserId)); }
            set { BackingStore?.Set(nameof(AzureAdUserId), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The domainName property</summary>
        public string DomainName {
            get { return BackingStore?.Get<string>(nameof(DomainName)); }
            set { BackingStore?.Set(nameof(DomainName), value); }
        }
        /// <summary>The userPrincipalName property</summary>
        public string UserPrincipalName {
            get { return BackingStore?.Get<string>(nameof(UserPrincipalName)); }
            set { BackingStore?.Set(nameof(UserPrincipalName), value); }
        }
        /// <summary>The userSid property</summary>
        public string UserSid {
            get { return BackingStore?.Get<string>(nameof(UserSid)); }
            set { BackingStore?.Set(nameof(UserSid), value); }
        }
        /// <summary>
        /// Instantiates a new userAccount and sets the default values.
        /// </summary>
        public UserAccount() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
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
            writer.WriteStringValue("userPrincipalName", UserPrincipalName);
            writer.WriteStringValue("userSid", UserSid);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
