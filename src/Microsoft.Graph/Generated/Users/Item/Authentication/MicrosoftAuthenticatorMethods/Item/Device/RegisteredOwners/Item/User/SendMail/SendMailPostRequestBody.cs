using Microsoft.Graph.Beta.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Users.Item.Authentication.MicrosoftAuthenticatorMethods.Item.Device.RegisteredOwners.Item.User.SendMail {
    /// <summary>Provides operations to call the sendMail method.</summary>
    public class SendMailPostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The Message property</summary>
        public Microsoft.Graph.Beta.Models.Message Message {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Message>(nameof(Message)); }
            set { BackingStore?.Set(nameof(Message), value); }
        }
        /// <summary>The SaveToSentItems property</summary>
        public bool? SaveToSentItems {
            get { return BackingStore?.Get<bool?>(nameof(SaveToSentItems)); }
            set { BackingStore?.Set(nameof(SaveToSentItems), value); }
        }
        /// <summary>
        /// Instantiates a new sendMailPostRequestBody and sets the default values.
        /// </summary>
        public SendMailPostRequestBody() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static SendMailPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SendMailPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"message", n => { Message = n.GetObjectValue<Microsoft.Graph.Beta.Models.Message>(Microsoft.Graph.Beta.Models.Message.CreateFromDiscriminatorValue); } },
                {"saveToSentItems", n => { SaveToSentItems = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.Message>("message", Message);
            writer.WriteBoolValue("saveToSentItems", SaveToSentItems);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
