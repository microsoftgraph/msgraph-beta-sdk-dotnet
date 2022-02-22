using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph.Ediscovery {
    public class Custodian : DataSourceContainer, IParsable {
        /// <summary>Date and time the custodian acknowledged a hold notification.</summary>
        public DateTimeOffset? AcknowledgedDateTime { get; set; }
        /// <summary>Identifies whether a custodian's sources were placed on hold during creation.</summary>
        public bool? ApplyHoldToSources { get; set; }
        /// <summary>Email address of the custodian.</summary>
        public string Email { get; set; }
        /// <summary>Data source entity for SharePoint sites associated with the custodian.</summary>
        public List<SiteSource> SiteSources { get; set; }
        /// <summary>Data source entity for groups associated with the custodian.</summary>
        public List<UnifiedGroupSource> UnifiedGroupSources { get; set; }
        /// <summary>Data source entity for a the custodian. This is the container for a custodian's mailbox and OneDrive for Business site.</summary>
        public List<UserSource> UserSources { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"acknowledgedDateTime", (o,n) => { (o as Custodian).AcknowledgedDateTime = n.GetDateTimeOffsetValue(); } },
                {"applyHoldToSources", (o,n) => { (o as Custodian).ApplyHoldToSources = n.GetBoolValue(); } },
                {"email", (o,n) => { (o as Custodian).Email = n.GetStringValue(); } },
                {"siteSources", (o,n) => { (o as Custodian).SiteSources = n.GetCollectionOfObjectValues<SiteSource>().ToList(); } },
                {"unifiedGroupSources", (o,n) => { (o as Custodian).UnifiedGroupSources = n.GetCollectionOfObjectValues<UnifiedGroupSource>().ToList(); } },
                {"userSources", (o,n) => { (o as Custodian).UserSources = n.GetCollectionOfObjectValues<UserSource>().ToList(); } },
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
            writer.WriteBoolValue("applyHoldToSources", ApplyHoldToSources);
            writer.WriteStringValue("email", Email);
            writer.WriteCollectionOfObjectValues<SiteSource>("siteSources", SiteSources);
            writer.WriteCollectionOfObjectValues<UnifiedGroupSource>("unifiedGroupSources", UnifiedGroupSources);
            writer.WriteCollectionOfObjectValues<UserSource>("userSources", UserSources);
        }
    }
}
