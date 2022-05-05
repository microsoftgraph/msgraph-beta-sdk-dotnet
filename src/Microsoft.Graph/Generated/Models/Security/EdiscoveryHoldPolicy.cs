using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models.Security {
    public class EdiscoveryHoldPolicy : PolicyBase, IParsable {
        /// <summary>The contentQuery property</summary>
        public string ContentQuery { get; set; }
        /// <summary>The errors property</summary>
        public List<string> Errors { get; set; }
        /// <summary>The isEnabled property</summary>
        public bool? IsEnabled { get; set; }
        /// <summary>The siteSources property</summary>
        public List<SiteSource> SiteSources { get; set; }
        /// <summary>The userSources property</summary>
        public List<UserSource> UserSources { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new EdiscoveryHoldPolicy CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new EdiscoveryHoldPolicy();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"contentQuery", n => { ContentQuery = n.GetStringValue(); } },
                {"errors", n => { Errors = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"isEnabled", n => { IsEnabled = n.GetBoolValue(); } },
                {"siteSources", n => { SiteSources = n.GetCollectionOfObjectValues<SiteSource>(SiteSource.CreateFromDiscriminatorValue).ToList(); } },
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
            writer.WriteStringValue("contentQuery", ContentQuery);
            writer.WriteCollectionOfPrimitiveValues<string>("errors", Errors);
            writer.WriteBoolValue("isEnabled", IsEnabled);
            writer.WriteCollectionOfObjectValues<SiteSource>("siteSources", SiteSources);
            writer.WriteCollectionOfObjectValues<UserSource>("userSources", UserSources);
        }
    }
}
