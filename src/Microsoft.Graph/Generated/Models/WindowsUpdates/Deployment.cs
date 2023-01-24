using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models.WindowsUpdates {
    public class Deployment : Entity, IParsable {
        /// <summary>Specifies the audience to which content is deployed.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public DeploymentAudience? Audience {
            get { return BackingStore?.Get<DeploymentAudience?>("audience"); }
            set { BackingStore?.Set("audience", value); }
        }
#nullable restore
#else
        public DeploymentAudience Audience {
            get { return BackingStore?.Get<DeploymentAudience>("audience"); }
            set { BackingStore?.Set("audience", value); }
        }
#endif
        /// <summary>Specifies what content to deploy. Cannot be changed. Returned by default.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public DeployableContent? Content {
            get { return BackingStore?.Get<DeployableContent?>("content"); }
            set { BackingStore?.Set("content", value); }
        }
#nullable restore
#else
        public DeployableContent Content {
            get { return BackingStore?.Get<DeployableContent>("content"); }
            set { BackingStore?.Set("content", value); }
        }
#endif
        /// <summary>The date and time the deployment was created. Returned by default. Read-only.</summary>
        public DateTimeOffset? CreatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("createdDateTime"); }
            set { BackingStore?.Set("createdDateTime", value); }
        }
        /// <summary>The date and time the deployment was last modified. Returned by default. Read-only.</summary>
        public DateTimeOffset? LastModifiedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastModifiedDateTime"); }
            set { BackingStore?.Set("lastModifiedDateTime", value); }
        }
        /// <summary>Settings specified on the specific deployment governing how to deploy content. Returned by default.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public DeploymentSettings? Settings {
            get { return BackingStore?.Get<DeploymentSettings?>("settings"); }
            set { BackingStore?.Set("settings", value); }
        }
#nullable restore
#else
        public DeploymentSettings Settings {
            get { return BackingStore?.Get<DeploymentSettings>("settings"); }
            set { BackingStore?.Set("settings", value); }
        }
#endif
        /// <summary>Execution status of the deployment. Returned by default.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public DeploymentState? State {
            get { return BackingStore?.Get<DeploymentState?>("state"); }
            set { BackingStore?.Set("state", value); }
        }
#nullable restore
#else
        public DeploymentState State {
            get { return BackingStore?.Get<DeploymentState>("state"); }
            set { BackingStore?.Set("state", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Deployment CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Deployment();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"audience", n => { Audience = n.GetObjectValue<DeploymentAudience>(DeploymentAudience.CreateFromDiscriminatorValue); } },
                {"content", n => { Content = n.GetObjectValue<DeployableContent>(DeployableContent.CreateFromDiscriminatorValue); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"settings", n => { Settings = n.GetObjectValue<DeploymentSettings>(DeploymentSettings.CreateFromDiscriminatorValue); } },
                {"state", n => { State = n.GetObjectValue<DeploymentState>(DeploymentState.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<DeploymentAudience>("audience", Audience);
            writer.WriteObjectValue<DeployableContent>("content", Content);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteObjectValue<DeploymentSettings>("settings", Settings);
            writer.WriteObjectValue<DeploymentState>("state", State);
        }
    }
}
