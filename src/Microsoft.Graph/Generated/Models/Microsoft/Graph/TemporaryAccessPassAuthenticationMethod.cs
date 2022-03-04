using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class TemporaryAccessPassAuthenticationMethod : AuthenticationMethod, IParsable {
        /// <summary>The date and time when the temporaryAccessPass was created.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>The state of the authentication method that indicates whether it's currently usable by the user.</summary>
        public bool? IsUsable { get; set; }
        /// <summary>Determines whether the pass is limited to a one time use. If true, the pass can be used once; if false, the pass can be used multiple times within the temporaryAccessPass lifetime.</summary>
        public bool? IsUsableOnce { get; set; }
        /// <summary>The lifetime of the temporaryAccessPass in minutes starting at startDateTime. Minimum 10, Maximum 43200 (equivalent to 30 days).</summary>
        public int? LifetimeInMinutes { get; set; }
        /// <summary>Details about usability state (isUsable). Reasons can include: enabledByPolicy, disabledByPolicy, expired, notYetValid, oneTimeUsed.</summary>
        public string MethodUsabilityReason { get; set; }
        /// <summary>The date and time when the temporaryAccessPass becomes available to use.</summary>
        public DateTimeOffset? StartDateTime { get; set; }
        /// <summary>The temporaryAccessPass used to authenticate. Returned only on creation of a new temporaryAccessPass; returned as NULL with GET.</summary>
        public string TemporaryAccessPass { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new TemporaryAccessPassAuthenticationMethod CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TemporaryAccessPassAuthenticationMethod();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"createdDateTime", (o,n) => { (o as TemporaryAccessPassAuthenticationMethod).CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"isUsable", (o,n) => { (o as TemporaryAccessPassAuthenticationMethod).IsUsable = n.GetBoolValue(); } },
                {"isUsableOnce", (o,n) => { (o as TemporaryAccessPassAuthenticationMethod).IsUsableOnce = n.GetBoolValue(); } },
                {"lifetimeInMinutes", (o,n) => { (o as TemporaryAccessPassAuthenticationMethod).LifetimeInMinutes = n.GetIntValue(); } },
                {"methodUsabilityReason", (o,n) => { (o as TemporaryAccessPassAuthenticationMethod).MethodUsabilityReason = n.GetStringValue(); } },
                {"startDateTime", (o,n) => { (o as TemporaryAccessPassAuthenticationMethod).StartDateTime = n.GetDateTimeOffsetValue(); } },
                {"temporaryAccessPass", (o,n) => { (o as TemporaryAccessPassAuthenticationMethod).TemporaryAccessPass = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteBoolValue("isUsable", IsUsable);
            writer.WriteBoolValue("isUsableOnce", IsUsableOnce);
            writer.WriteIntValue("lifetimeInMinutes", LifetimeInMinutes);
            writer.WriteStringValue("methodUsabilityReason", MethodUsabilityReason);
            writer.WriteDateTimeOffsetValue("startDateTime", StartDateTime);
            writer.WriteStringValue("temporaryAccessPass", TemporaryAccessPass);
        }
    }
}
