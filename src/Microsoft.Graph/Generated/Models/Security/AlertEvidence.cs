using Microsoft.Graph.Beta.Models.Security;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models.Security {
    public class AlertEvidence : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The createdDateTime property</summary>
        public DateTimeOffset? CreatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(CreatedDateTime)); }
            set { BackingStore?.Set(nameof(CreatedDateTime), value); }
        }
        /// <summary>The remediationStatus property</summary>
        public EvidenceRemediationStatus? RemediationStatus {
            get { return BackingStore?.Get<EvidenceRemediationStatus?>(nameof(RemediationStatus)); }
            set { BackingStore?.Set(nameof(RemediationStatus), value); }
        }
        /// <summary>The remediationStatusDetails property</summary>
        public string RemediationStatusDetails {
            get { return BackingStore?.Get<string>(nameof(RemediationStatusDetails)); }
            set { BackingStore?.Set(nameof(RemediationStatusDetails), value); }
        }
        /// <summary>The roles property</summary>
        public List<string> Roles {
            get { return BackingStore?.Get<List<string>>(nameof(Roles)); }
            set { BackingStore?.Set(nameof(Roles), value); }
        }
        /// <summary>The tags property</summary>
        public List<string> Tags {
            get { return BackingStore?.Get<List<string>>(nameof(Tags)); }
            set { BackingStore?.Set(nameof(Tags), value); }
        }
        /// <summary>The verdict property</summary>
        public EvidenceVerdict? Verdict {
            get { return BackingStore?.Get<EvidenceVerdict?>(nameof(Verdict)); }
            set { BackingStore?.Set(nameof(Verdict), value); }
        }
        /// <summary>
        /// Instantiates a new alertEvidence and sets the default values.
        /// </summary>
        public AlertEvidence() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static AlertEvidence CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValueNode = parseNode.GetChildNode("@odata.type");
            var mappingValue = mappingValueNode?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.security.analyzedMessageEvidence" => new AnalyzedMessageEvidence(),
                "#microsoft.graph.security.cloudApplicationEvidence" => new CloudApplicationEvidence(),
                "#microsoft.graph.security.deviceEvidence" => new DeviceEvidence(),
                "#microsoft.graph.security.fileEvidence" => new FileEvidence(),
                "#microsoft.graph.security.ipEvidence" => new IpEvidence(),
                "#microsoft.graph.security.mailboxEvidence" => new MailboxEvidence(),
                "#microsoft.graph.security.mailClusterEvidence" => new MailClusterEvidence(),
                "#microsoft.graph.security.oauthApplicationEvidence" => new OauthApplicationEvidence(),
                "#microsoft.graph.security.processEvidence" => new ProcessEvidence(),
                "#microsoft.graph.security.registryKeyEvidence" => new RegistryKeyEvidence(),
                "#microsoft.graph.security.registryValueEvidence" => new RegistryValueEvidence(),
                "#microsoft.graph.security.securityGroupEvidence" => new SecurityGroupEvidence(),
                "#microsoft.graph.security.urlEvidence" => new UrlEvidence(),
                "#microsoft.graph.security.userEvidence" => new UserEvidence(),
                _ => new AlertEvidence(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"remediationStatus", n => { RemediationStatus = n.GetEnumValue<EvidenceRemediationStatus>(); } },
                {"remediationStatusDetails", n => { RemediationStatusDetails = n.GetStringValue(); } },
                {"roles", n => { Roles = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"tags", n => { Tags = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"verdict", n => { Verdict = n.GetEnumValue<EvidenceVerdict>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteEnumValue<EvidenceRemediationStatus>("remediationStatus", RemediationStatus);
            writer.WriteStringValue("remediationStatusDetails", RemediationStatusDetails);
            writer.WriteCollectionOfPrimitiveValues<string>("roles", Roles);
            writer.WriteCollectionOfPrimitiveValues<string>("tags", Tags);
            writer.WriteEnumValue<EvidenceVerdict>("verdict", Verdict);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
