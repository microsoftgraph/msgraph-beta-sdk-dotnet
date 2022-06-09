using Microsoft.Graph.Beta.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Me.Drives.Item.Root.Invite {
    /// <summary>Provides operations to call the invite method.</summary>
    public class InvitePostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The expirationDateTime property</summary>
        public string ExpirationDateTime {
            get { return BackingStore?.Get<string>(nameof(ExpirationDateTime)); }
            set { BackingStore?.Set(nameof(ExpirationDateTime), value); }
        }
        /// <summary>The message property</summary>
        public string Message {
            get { return BackingStore?.Get<string>(nameof(Message)); }
            set { BackingStore?.Set(nameof(Message), value); }
        }
        /// <summary>The password property</summary>
        public string Password {
            get { return BackingStore?.Get<string>(nameof(Password)); }
            set { BackingStore?.Set(nameof(Password), value); }
        }
        /// <summary>The recipients property</summary>
        public List<DriveRecipient> Recipients {
            get { return BackingStore?.Get<List<DriveRecipient>>(nameof(Recipients)); }
            set { BackingStore?.Set(nameof(Recipients), value); }
        }
        /// <summary>The requireSignIn property</summary>
        public bool? RequireSignIn {
            get { return BackingStore?.Get<bool?>(nameof(RequireSignIn)); }
            set { BackingStore?.Set(nameof(RequireSignIn), value); }
        }
        /// <summary>The retainInheritedPermissions property</summary>
        public bool? RetainInheritedPermissions {
            get { return BackingStore?.Get<bool?>(nameof(RetainInheritedPermissions)); }
            set { BackingStore?.Set(nameof(RetainInheritedPermissions), value); }
        }
        /// <summary>The roles property</summary>
        public List<string> Roles {
            get { return BackingStore?.Get<List<string>>(nameof(Roles)); }
            set { BackingStore?.Set(nameof(Roles), value); }
        }
        /// <summary>The sendInvitation property</summary>
        public bool? SendInvitation {
            get { return BackingStore?.Get<bool?>(nameof(SendInvitation)); }
            set { BackingStore?.Set(nameof(SendInvitation), value); }
        }
        /// <summary>
        /// Instantiates a new invitePostRequestBody and sets the default values.
        /// </summary>
        public InvitePostRequestBody() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static InvitePostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new InvitePostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"expirationDateTime", n => { ExpirationDateTime = n.GetStringValue(); } },
                {"message", n => { Message = n.GetStringValue(); } },
                {"password", n => { Password = n.GetStringValue(); } },
                {"recipients", n => { Recipients = n.GetCollectionOfObjectValues<DriveRecipient>(DriveRecipient.CreateFromDiscriminatorValue).ToList(); } },
                {"requireSignIn", n => { RequireSignIn = n.GetBoolValue(); } },
                {"retainInheritedPermissions", n => { RetainInheritedPermissions = n.GetBoolValue(); } },
                {"roles", n => { Roles = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"sendInvitation", n => { SendInvitation = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("expirationDateTime", ExpirationDateTime);
            writer.WriteStringValue("message", Message);
            writer.WriteStringValue("password", Password);
            writer.WriteCollectionOfObjectValues<DriveRecipient>("recipients", Recipients);
            writer.WriteBoolValue("requireSignIn", RequireSignIn);
            writer.WriteBoolValue("retainInheritedPermissions", RetainInheritedPermissions);
            writer.WriteCollectionOfPrimitiveValues<string>("roles", Roles);
            writer.WriteBoolValue("sendInvitation", SendInvitation);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
