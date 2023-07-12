using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models.Networkaccess {
    public class EnrichedAuditLogs : Entity, IParsable {
        /// <summary>Exchange Online enriched audit logs settings.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public EnrichedAuditLogsSettings? Exchange {
            get { return BackingStore?.Get<EnrichedAuditLogsSettings?>("exchange"); }
            set { BackingStore?.Set("exchange", value); }
        }
#nullable restore
#else
        public EnrichedAuditLogsSettings Exchange {
            get { return BackingStore?.Get<EnrichedAuditLogsSettings>("exchange"); }
            set { BackingStore?.Set("exchange", value); }
        }
#endif
        /// <summary>SharePoint Online enriched audit logs settings.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public EnrichedAuditLogsSettings? Sharepoint {
            get { return BackingStore?.Get<EnrichedAuditLogsSettings?>("sharepoint"); }
            set { BackingStore?.Set("sharepoint", value); }
        }
#nullable restore
#else
        public EnrichedAuditLogsSettings Sharepoint {
            get { return BackingStore?.Get<EnrichedAuditLogsSettings>("sharepoint"); }
            set { BackingStore?.Set("sharepoint", value); }
        }
#endif
        /// <summary>Teams enriched audit logs settings.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public EnrichedAuditLogsSettings? Teams {
            get { return BackingStore?.Get<EnrichedAuditLogsSettings?>("teams"); }
            set { BackingStore?.Set("teams", value); }
        }
#nullable restore
#else
        public EnrichedAuditLogsSettings Teams {
            get { return BackingStore?.Get<EnrichedAuditLogsSettings>("teams"); }
            set { BackingStore?.Set("teams", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new EnrichedAuditLogs CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new EnrichedAuditLogs();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"exchange", n => { Exchange = n.GetObjectValue<EnrichedAuditLogsSettings>(EnrichedAuditLogsSettings.CreateFromDiscriminatorValue); } },
                {"sharepoint", n => { Sharepoint = n.GetObjectValue<EnrichedAuditLogsSettings>(EnrichedAuditLogsSettings.CreateFromDiscriminatorValue); } },
                {"teams", n => { Teams = n.GetObjectValue<EnrichedAuditLogsSettings>(EnrichedAuditLogsSettings.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<EnrichedAuditLogsSettings>("exchange", Exchange);
            writer.WriteObjectValue<EnrichedAuditLogsSettings>("sharepoint", Sharepoint);
            writer.WriteObjectValue<EnrichedAuditLogsSettings>("teams", Teams);
        }
    }
}
