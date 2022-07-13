using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.PrivilegedApproval.Item.RoleInfo.SelfActivate {
    /// <summary>Provides operations to call the selfActivate method.</summary>
    public class SelfActivatePostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The duration property</summary>
        public string Duration {
            get { return BackingStore?.Get<string>("duration"); }
            set { BackingStore?.Set("duration", value); }
        }
        /// <summary>The reason property</summary>
        public string Reason {
            get { return BackingStore?.Get<string>("reason"); }
            set { BackingStore?.Set("reason", value); }
        }
        /// <summary>The ticketNumber property</summary>
        public string TicketNumber {
            get { return BackingStore?.Get<string>("ticketNumber"); }
            set { BackingStore?.Set("ticketNumber", value); }
        }
        /// <summary>The ticketSystem property</summary>
        public string TicketSystem {
            get { return BackingStore?.Get<string>("ticketSystem"); }
            set { BackingStore?.Set("ticketSystem", value); }
        }
        /// <summary>
        /// Instantiates a new selfActivatePostRequestBody and sets the default values.
        /// </summary>
        public SelfActivatePostRequestBody() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static SelfActivatePostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SelfActivatePostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"duration", n => { Duration = n.GetStringValue(); } },
                {"reason", n => { Reason = n.GetStringValue(); } },
                {"ticketNumber", n => { TicketNumber = n.GetStringValue(); } },
                {"ticketSystem", n => { TicketSystem = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("duration", Duration);
            writer.WriteStringValue("reason", Reason);
            writer.WriteStringValue("ticketNumber", TicketNumber);
            writer.WriteStringValue("ticketSystem", TicketSystem);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
