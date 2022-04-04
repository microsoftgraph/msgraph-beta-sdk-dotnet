using Microsoft.Kiota.Abstractions.Serialization;
using MicrosoftGraphSdk.Models.Microsoft.Graph;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Workbooks.Item.Invite {
    /// <summary>Provides operations to call the invite method.</summary>
    public class InviteRequestBody : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The expirationDateTime property</summary>
        public string ExpirationDateTime { get; set; }
        /// <summary>The message property</summary>
        public string Message { get; set; }
        /// <summary>The password property</summary>
        public string Password { get; set; }
        /// <summary>The recipients property</summary>
        public List<DriveRecipient> Recipients { get; set; }
        /// <summary>The requireSignIn property</summary>
        public bool? RequireSignIn { get; set; }
        /// <summary>The retainInheritedPermissions property</summary>
        public bool? RetainInheritedPermissions { get; set; }
        /// <summary>The roles property</summary>
        public List<string> Roles { get; set; }
        /// <summary>The sendInvitation property</summary>
        public bool? SendInvitation { get; set; }
        /// <summary>
        /// Instantiates a new inviteRequestBody and sets the default values.
        /// </summary>
        public InviteRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static InviteRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new InviteRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"expirationDateTime", (o,n) => { (o as InviteRequestBody).ExpirationDateTime = n.GetStringValue(); } },
                {"message", (o,n) => { (o as InviteRequestBody).Message = n.GetStringValue(); } },
                {"password", (o,n) => { (o as InviteRequestBody).Password = n.GetStringValue(); } },
                {"recipients", (o,n) => { (o as InviteRequestBody).Recipients = n.GetCollectionOfObjectValues<DriveRecipient>(DriveRecipient.CreateFromDiscriminatorValue).ToList(); } },
                {"requireSignIn", (o,n) => { (o as InviteRequestBody).RequireSignIn = n.GetBoolValue(); } },
                {"retainInheritedPermissions", (o,n) => { (o as InviteRequestBody).RetainInheritedPermissions = n.GetBoolValue(); } },
                {"roles", (o,n) => { (o as InviteRequestBody).Roles = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"sendInvitation", (o,n) => { (o as InviteRequestBody).SendInvitation = n.GetBoolValue(); } },
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
