using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class ManagementConditionStatement : Entity, IParsable {
        /// <summary>The applicable platforms for this management condition statement.</summary>
        public List<DevicePlatformType?> ApplicablePlatforms { get; set; }
        /// <summary>The time the management condition statement was created. Generated service side.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>The admin defined description of the management condition statement.</summary>
        public string Description { get; set; }
        /// <summary>The admin defined name of the management condition statement.</summary>
        public string DisplayName { get; set; }
        /// <summary>ETag of the management condition statement. Updated service side.</summary>
        public string ETag { get; set; }
        /// <summary>The management condition statement expression used to evaluate if a management condition statement was activated/deactivated.</summary>
        public ManagementConditionExpression Expression { get; set; }
        /// <summary>The management conditions associated to the management condition statement.</summary>
        public List<ManagementCondition> ManagementConditions { get; set; }
        /// <summary>The time the management condition statement was last modified. Updated service side.</summary>
        public DateTimeOffset? ModifiedDateTime { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"applicablePlatforms", (o,n) => { (o as ManagementConditionStatement).ApplicablePlatforms = n.GetCollectionOfEnumValues<DevicePlatformType>().ToList(); } },
                {"createdDateTime", (o,n) => { (o as ManagementConditionStatement).CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"description", (o,n) => { (o as ManagementConditionStatement).Description = n.GetStringValue(); } },
                {"displayName", (o,n) => { (o as ManagementConditionStatement).DisplayName = n.GetStringValue(); } },
                {"eTag", (o,n) => { (o as ManagementConditionStatement).ETag = n.GetStringValue(); } },
                {"expression", (o,n) => { (o as ManagementConditionStatement).Expression = n.GetObjectValue<ManagementConditionExpression>(); } },
                {"managementConditions", (o,n) => { (o as ManagementConditionStatement).ManagementConditions = n.GetCollectionOfObjectValues<ManagementCondition>().ToList(); } },
                {"modifiedDateTime", (o,n) => { (o as ManagementConditionStatement).ModifiedDateTime = n.GetDateTimeOffsetValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfEnumValues<DevicePlatformType>("applicablePlatforms", ApplicablePlatforms);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("eTag", ETag);
            writer.WriteObjectValue<ManagementConditionExpression>("expression", Expression);
            writer.WriteCollectionOfObjectValues<ManagementCondition>("managementConditions", ManagementConditions);
            writer.WriteDateTimeOffsetValue("modifiedDateTime", ModifiedDateTime);
        }
    }
}
