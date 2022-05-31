using Microsoft.Graph.Beta.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Users.Item.Authentication.PasswordlessMicrosoftAuthenticatorMethods.Item.Device.RegisteredOwners.Item.User.GetMailTips {
    /// <summary>Provides operations to call the getMailTips method.</summary>
    public class GetMailTipsPostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The EmailAddresses property</summary>
        public List<string> EmailAddresses {
            get { return BackingStore?.Get<List<string>>(nameof(EmailAddresses)); }
            set { BackingStore?.Set(nameof(EmailAddresses), value); }
        }
        /// <summary>The MailTipsOptions property</summary>
        public MailTipsType? MailTipsOptions {
            get { return BackingStore?.Get<MailTipsType?>(nameof(MailTipsOptions)); }
            set { BackingStore?.Set(nameof(MailTipsOptions), value); }
        }
        /// <summary>
        /// Instantiates a new getMailTipsPostRequestBody and sets the default values.
        /// </summary>
        public GetMailTipsPostRequestBody() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static GetMailTipsPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new GetMailTipsPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"emailAddresses", n => { EmailAddresses = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"mailTipsOptions", n => { MailTipsOptions = n.GetEnumValue<MailTipsType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfPrimitiveValues<string>("emailAddresses", EmailAddresses);
            writer.WriteEnumValue<MailTipsType>("mailTipsOptions", MailTipsOptions);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
