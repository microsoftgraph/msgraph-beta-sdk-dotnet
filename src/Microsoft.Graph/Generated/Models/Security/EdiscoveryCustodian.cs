using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models.Security {
    public class EdiscoveryCustodian : DataSourceContainer, IParsable {
        /// <summary>The acknowledgedDateTime property</summary>
        public DateTimeOffset? AcknowledgedDateTime { get; set; }
        /// <summary>The email property</summary>
        public string Email { get; set; }
        /// <summary>The lastIndexOperation property</summary>
        public EdiscoveryIndexOperation LastIndexOperation { get; set; }
        /// <summary>The siteSources property</summary>
        public List<SiteSource> SiteSources { get; set; }
        /// <summary>The unifiedGroupSources property</summary>
        public List<UnifiedGroupSource> UnifiedGroupSources { get; set; }
        /// <summary>The userSources property</summary>
        public List<UserSource> UserSources { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new EdiscoveryCustodian CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new EdiscoveryCustodian();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"acknowledgedDateTime", n => { AcknowledgedDateTime = n.GetDateTimeOffsetValue(); } },
                {"email", n => { Email = n.GetStringValue(); } },
                {"lastIndexOperation", n => { LastIndexOperation = n.GetObjectValue<EdiscoveryIndexOperation>(EdiscoveryIndexOperation.CreateFromDiscriminatorValue); } },
                {"siteSources", n => { SiteSources = n.GetCollectionOfObjectValues<SiteSource>(SiteSource.CreateFromDiscriminatorValue).ToList(); } },
                {"unifiedGroupSources", n => { UnifiedGroupSources = n.GetCollectionOfObjectValues<UnifiedGroupSource>(UnifiedGroupSource.CreateFromDiscriminatorValue).ToList(); } },
                {"userSources", n => { UserSources = n.GetCollectionOfObjectValues<UserSource>(UserSource.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteDateTimeOffsetValue("acknowledgedDateTime", AcknowledgedDateTime);
            writer.WriteStringValue("email", Email);
            writer.WriteObjectValue<EdiscoveryIndexOperation>("lastIndexOperation", LastIndexOperation);
            writer.WriteCollectionOfObjectValues<SiteSource>("siteSources", SiteSources);
            writer.WriteCollectionOfObjectValues<UnifiedGroupSource>("unifiedGroupSources", UnifiedGroupSources);
            writer.WriteCollectionOfObjectValues<UserSource>("userSources", UserSources);
        }
    }
}
