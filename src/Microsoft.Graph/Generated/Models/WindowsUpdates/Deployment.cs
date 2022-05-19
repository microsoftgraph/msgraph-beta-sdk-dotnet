using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models.WindowsUpdates {
    /// <summary>Provides operations to manage the admin singleton.</summary>
    public class Deployment : Entity, IParsable {
        /// <summary>Specifies the audience to which content is deployed.</summary>
        public DeploymentAudience Audience {
            get { return BackingStore?.Get<DeploymentAudience>(nameof(Audience)); }
            set { BackingStore?.Set(nameof(Audience), value); }
        }
        /// <summary>Specifies what content to deploy. Cannot be changed. Returned by default.</summary>
        public DeployableContent Content {
            get { return BackingStore?.Get<DeployableContent>(nameof(Content)); }
            set { BackingStore?.Set(nameof(Content), value); }
        }
        /// <summary>The date and time the deployment was created. Returned by default. Read-only.</summary>
        public DateTimeOffset? CreatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(CreatedDateTime)); }
            set { BackingStore?.Set(nameof(CreatedDateTime), value); }
        }
        /// <summary>The date and time the deployment was last modified. Returned by default. Read-only.</summary>
        public DateTimeOffset? LastModifiedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(LastModifiedDateTime)); }
            set { BackingStore?.Set(nameof(LastModifiedDateTime), value); }
        }
        /// <summary>Settings specified on the specific deployment governing how to deploy content. Returned by default.</summary>
        public DeploymentSettings Settings {
            get { return BackingStore?.Get<DeploymentSettings>(nameof(Settings)); }
            set { BackingStore?.Set(nameof(Settings), value); }
        }
        /// <summary>Execution status of the deployment. Returned by default.</summary>
        public DeploymentState State {
            get { return BackingStore?.Get<DeploymentState>(nameof(State)); }
            set { BackingStore?.Set(nameof(State), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
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
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
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
