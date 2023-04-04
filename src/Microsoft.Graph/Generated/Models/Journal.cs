using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class Journal : Entity, IParsable {
        /// <summary>The account property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.Account? Account {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Account?>("account"); }
            set { BackingStore?.Set("account", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.Account Account {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Account>("account"); }
            set { BackingStore?.Set("account", value); }
        }
#endif
        /// <summary>The balancingAccountId property</summary>
        public Guid? BalancingAccountId {
            get { return BackingStore?.Get<Guid?>("balancingAccountId"); }
            set { BackingStore?.Set("balancingAccountId", value); }
        }
        /// <summary>The balancingAccountNumber property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? BalancingAccountNumber {
            get { return BackingStore?.Get<string?>("balancingAccountNumber"); }
            set { BackingStore?.Set("balancingAccountNumber", value); }
        }
#nullable restore
#else
        public string BalancingAccountNumber {
            get { return BackingStore?.Get<string>("balancingAccountNumber"); }
            set { BackingStore?.Set("balancingAccountNumber", value); }
        }
#endif
        /// <summary>The code property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Code {
            get { return BackingStore?.Get<string?>("code"); }
            set { BackingStore?.Set("code", value); }
        }
#nullable restore
#else
        public string Code {
            get { return BackingStore?.Get<string>("code"); }
            set { BackingStore?.Set("code", value); }
        }
#endif
        /// <summary>The displayName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName {
            get { return BackingStore?.Get<string?>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#nullable restore
#else
        public string DisplayName {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#endif
        /// <summary>The journalLines property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<JournalLine>? JournalLines {
            get { return BackingStore?.Get<List<JournalLine>?>("journalLines"); }
            set { BackingStore?.Set("journalLines", value); }
        }
#nullable restore
#else
        public List<JournalLine> JournalLines {
            get { return BackingStore?.Get<List<JournalLine>>("journalLines"); }
            set { BackingStore?.Set("journalLines", value); }
        }
#endif
        /// <summary>The lastModifiedDateTime property</summary>
        public DateTimeOffset? LastModifiedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastModifiedDateTime"); }
            set { BackingStore?.Set("lastModifiedDateTime", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Journal CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Journal();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"account", n => { Account = n.GetObjectValue<Microsoft.Graph.Beta.Models.Account>(Microsoft.Graph.Beta.Models.Account.CreateFromDiscriminatorValue); } },
                {"balancingAccountId", n => { BalancingAccountId = n.GetGuidValue(); } },
                {"balancingAccountNumber", n => { BalancingAccountNumber = n.GetStringValue(); } },
                {"code", n => { Code = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"journalLines", n => { JournalLines = n.GetCollectionOfObjectValues<JournalLine>(JournalLine.CreateFromDiscriminatorValue)?.ToList(); } },
                {"lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.Account>("account", Account);
            writer.WriteGuidValue("balancingAccountId", BalancingAccountId);
            writer.WriteStringValue("balancingAccountNumber", BalancingAccountNumber);
            writer.WriteStringValue("code", Code);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteCollectionOfObjectValues<JournalLine>("journalLines", JournalLines);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
        }
    }
}
