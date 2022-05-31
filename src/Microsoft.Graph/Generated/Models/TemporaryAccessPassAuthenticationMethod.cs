using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Casts the previous resource to group.</summary>
    public class TemporaryAccessPassAuthenticationMethod : AuthenticationMethod, IParsable {
        /// <summary>The date and time when the temporaryAccessPass was created.</summary>
        public DateTimeOffset? CreatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(CreatedDateTime)); }
            set { BackingStore?.Set(nameof(CreatedDateTime), value); }
        }
        /// <summary>The state of the authentication method that indicates whether it&apos;s currently usable by the user.</summary>
        public bool? IsUsable {
            get { return BackingStore?.Get<bool?>(nameof(IsUsable)); }
            set { BackingStore?.Set(nameof(IsUsable), value); }
        }
        /// <summary>Determines whether the pass is limited to a one time use. If true, the pass can be used once; if false, the pass can be used multiple times within the temporaryAccessPass lifetime.</summary>
        public bool? IsUsableOnce {
            get { return BackingStore?.Get<bool?>(nameof(IsUsableOnce)); }
            set { BackingStore?.Set(nameof(IsUsableOnce), value); }
        }
        /// <summary>The lifetime of the temporaryAccessPass in minutes starting at startDateTime. Minimum 10, Maximum 43200 (equivalent to 30 days).</summary>
        public int? LifetimeInMinutes {
            get { return BackingStore?.Get<int?>(nameof(LifetimeInMinutes)); }
            set { BackingStore?.Set(nameof(LifetimeInMinutes), value); }
        }
        /// <summary>Details about usability state (isUsable). Reasons can include: enabledByPolicy, disabledByPolicy, expired, notYetValid, oneTimeUsed.</summary>
        public string MethodUsabilityReason {
            get { return BackingStore?.Get<string>(nameof(MethodUsabilityReason)); }
            set { BackingStore?.Set(nameof(MethodUsabilityReason), value); }
        }
        /// <summary>The date and time when the temporaryAccessPass becomes available to use.</summary>
        public DateTimeOffset? StartDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(StartDateTime)); }
            set { BackingStore?.Set(nameof(StartDateTime), value); }
        }
        /// <summary>The temporaryAccessPass used to authenticate. Returned only on creation of a new temporaryAccessPass; returned as NULL with GET.</summary>
        public string TemporaryAccessPass {
            get { return BackingStore?.Get<string>(nameof(TemporaryAccessPass)); }
            set { BackingStore?.Set(nameof(TemporaryAccessPass), value); }
        }
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
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"isUsable", n => { IsUsable = n.GetBoolValue(); } },
                {"isUsableOnce", n => { IsUsableOnce = n.GetBoolValue(); } },
                {"lifetimeInMinutes", n => { LifetimeInMinutes = n.GetIntValue(); } },
                {"methodUsabilityReason", n => { MethodUsabilityReason = n.GetStringValue(); } },
                {"startDateTime", n => { StartDateTime = n.GetDateTimeOffsetValue(); } },
                {"temporaryAccessPass", n => { TemporaryAccessPass = n.GetStringValue(); } },
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
