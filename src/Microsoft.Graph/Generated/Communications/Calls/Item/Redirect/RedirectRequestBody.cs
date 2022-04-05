using Microsoft.Graph.Beta.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Communications.Calls.Item.Redirect {
    /// <summary>Provides operations to call the redirect method.</summary>
    public class RedirectRequestBody : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The callbackUri property</summary>
        public string CallbackUri { get; set; }
        /// <summary>The maskCallee property</summary>
        public bool? MaskCallee { get; set; }
        /// <summary>The maskCaller property</summary>
        public bool? MaskCaller { get; set; }
        /// <summary>The targetDisposition property</summary>
        public CallDisposition? TargetDisposition { get; set; }
        /// <summary>The targets property</summary>
        public List<InvitationParticipantInfo> Targets { get; set; }
        /// <summary>The timeout property</summary>
        public int? Timeout { get; set; }
        /// <summary>
        /// Instantiates a new redirectRequestBody and sets the default values.
        /// </summary>
        public RedirectRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static RedirectRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new RedirectRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"callbackUri", (o,n) => { (o as RedirectRequestBody).CallbackUri = n.GetStringValue(); } },
                {"maskCallee", (o,n) => { (o as RedirectRequestBody).MaskCallee = n.GetBoolValue(); } },
                {"maskCaller", (o,n) => { (o as RedirectRequestBody).MaskCaller = n.GetBoolValue(); } },
                {"targetDisposition", (o,n) => { (o as RedirectRequestBody).TargetDisposition = n.GetEnumValue<CallDisposition>(); } },
                {"targets", (o,n) => { (o as RedirectRequestBody).Targets = n.GetCollectionOfObjectValues<InvitationParticipantInfo>(InvitationParticipantInfo.CreateFromDiscriminatorValue).ToList(); } },
                {"timeout", (o,n) => { (o as RedirectRequestBody).Timeout = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("callbackUri", CallbackUri);
            writer.WriteBoolValue("maskCallee", MaskCallee);
            writer.WriteBoolValue("maskCaller", MaskCaller);
            writer.WriteEnumValue<CallDisposition>("targetDisposition", TargetDisposition);
            writer.WriteCollectionOfObjectValues<InvitationParticipantInfo>("targets", Targets);
            writer.WriteIntValue("timeout", Timeout);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
