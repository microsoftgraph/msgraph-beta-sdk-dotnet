using Microsoft.Graph.Beta.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Groups.Item.CalendarView.Item.Instances.Item.ExceptionOccurrences.Item.Decline {
    public class DeclinePostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The Comment property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Comment {
            get { return BackingStore?.Get<string?>("comment"); }
            set { BackingStore?.Set("comment", value); }
        }
#nullable restore
#else
        public string Comment {
            get { return BackingStore?.Get<string>("comment"); }
            set { BackingStore?.Set("comment", value); }
        }
#endif
        /// <summary>The ProposedNewTime property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public TimeSlot? ProposedNewTime {
            get { return BackingStore?.Get<TimeSlot?>("proposedNewTime"); }
            set { BackingStore?.Set("proposedNewTime", value); }
        }
#nullable restore
#else
        public TimeSlot ProposedNewTime {
            get { return BackingStore?.Get<TimeSlot>("proposedNewTime"); }
            set { BackingStore?.Set("proposedNewTime", value); }
        }
#endif
        /// <summary>The SendResponse property</summary>
        public bool? SendResponse {
            get { return BackingStore?.Get<bool?>("sendResponse"); }
            set { BackingStore?.Set("sendResponse", value); }
        }
        /// <summary>
        /// Instantiates a new declinePostRequestBody and sets the default values.
        /// </summary>
        public DeclinePostRequestBody() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static DeclinePostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeclinePostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"Comment", n => { Comment = n.GetStringValue(); } },
                {"ProposedNewTime", n => { ProposedNewTime = n.GetObjectValue<TimeSlot>(TimeSlot.CreateFromDiscriminatorValue); } },
                {"SendResponse", n => { SendResponse = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("Comment", Comment);
            writer.WriteObjectValue<TimeSlot>("ProposedNewTime", ProposedNewTime);
            writer.WriteBoolValue("SendResponse", SendResponse);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
