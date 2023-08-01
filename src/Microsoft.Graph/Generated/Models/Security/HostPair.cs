using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models.Security {
    public class HostPair : Entity, IParsable {
        /// <summary>The childHost property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Host? ChildHost {
            get { return BackingStore?.Get<Host?>("childHost"); }
            set { BackingStore?.Set("childHost", value); }
        }
#nullable restore
#else
        public Host ChildHost {
            get { return BackingStore?.Get<Host>("childHost"); }
            set { BackingStore?.Set("childHost", value); }
        }
#endif
        /// <summary>The firstSeenDateTime property</summary>
        public DateTimeOffset? FirstSeenDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("firstSeenDateTime"); }
            set { BackingStore?.Set("firstSeenDateTime", value); }
        }
        /// <summary>The lastSeenDateTime property</summary>
        public DateTimeOffset? LastSeenDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastSeenDateTime"); }
            set { BackingStore?.Set("lastSeenDateTime", value); }
        }
        /// <summary>The linkKind property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LinkKind {
            get { return BackingStore?.Get<string?>("linkKind"); }
            set { BackingStore?.Set("linkKind", value); }
        }
#nullable restore
#else
        public string LinkKind {
            get { return BackingStore?.Get<string>("linkKind"); }
            set { BackingStore?.Set("linkKind", value); }
        }
#endif
        /// <summary>The parentHost property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Host? ParentHost {
            get { return BackingStore?.Get<Host?>("parentHost"); }
            set { BackingStore?.Set("parentHost", value); }
        }
#nullable restore
#else
        public Host ParentHost {
            get { return BackingStore?.Get<Host>("parentHost"); }
            set { BackingStore?.Set("parentHost", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new HostPair CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new HostPair();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"childHost", n => { ChildHost = n.GetObjectValue<Host>(Host.CreateFromDiscriminatorValue); } },
                {"firstSeenDateTime", n => { FirstSeenDateTime = n.GetDateTimeOffsetValue(); } },
                {"lastSeenDateTime", n => { LastSeenDateTime = n.GetDateTimeOffsetValue(); } },
                {"linkKind", n => { LinkKind = n.GetStringValue(); } },
                {"parentHost", n => { ParentHost = n.GetObjectValue<Host>(Host.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<Host>("childHost", ChildHost);
            writer.WriteDateTimeOffsetValue("firstSeenDateTime", FirstSeenDateTime);
            writer.WriteDateTimeOffsetValue("lastSeenDateTime", LastSeenDateTime);
            writer.WriteStringValue("linkKind", LinkKind);
            writer.WriteObjectValue<Host>("parentHost", ParentHost);
        }
    }
}
