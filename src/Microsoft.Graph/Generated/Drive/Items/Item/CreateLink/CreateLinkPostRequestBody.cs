using Microsoft.Graph.Beta.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Drive.Items.Item.CreateLink {
    /// <summary>Provides operations to call the createLink method.</summary>
    public class CreateLinkPostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The expirationDateTime property</summary>
        public DateTimeOffset? ExpirationDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(ExpirationDateTime)); }
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
        /// <summary>The retainInheritedPermissions property</summary>
        public bool? RetainInheritedPermissions {
            get { return BackingStore?.Get<bool?>(nameof(RetainInheritedPermissions)); }
            set { BackingStore?.Set(nameof(RetainInheritedPermissions), value); }
        }
        /// <summary>The scope property</summary>
        public string Scope {
            get { return BackingStore?.Get<string>(nameof(Scope)); }
            set { BackingStore?.Set(nameof(Scope), value); }
        }
        /// <summary>The type property</summary>
        public string Type {
            get { return BackingStore?.Get<string>(nameof(Type)); }
            set { BackingStore?.Set(nameof(Type), value); }
        }
        /// <summary>
        /// Instantiates a new createLinkPostRequestBody and sets the default values.
        /// </summary>
        public CreateLinkPostRequestBody() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static CreateLinkPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CreateLinkPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"expirationDateTime", n => { ExpirationDateTime = n.GetDateTimeOffsetValue(); } },
                {"message", n => { Message = n.GetStringValue(); } },
                {"password", n => { Password = n.GetStringValue(); } },
                {"recipients", n => { Recipients = n.GetCollectionOfObjectValues<DriveRecipient>(DriveRecipient.CreateFromDiscriminatorValue).ToList(); } },
                {"retainInheritedPermissions", n => { RetainInheritedPermissions = n.GetBoolValue(); } },
                {"scope", n => { Scope = n.GetStringValue(); } },
                {"type", n => { Type = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDateTimeOffsetValue("expirationDateTime", ExpirationDateTime);
            writer.WriteStringValue("message", Message);
            writer.WriteStringValue("password", Password);
            writer.WriteCollectionOfObjectValues<DriveRecipient>("recipients", Recipients);
            writer.WriteBoolValue("retainInheritedPermissions", RetainInheritedPermissions);
            writer.WriteStringValue("scope", Scope);
            writer.WriteStringValue("type", Type);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
