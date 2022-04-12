using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class ManagementCondition : Entity, IParsable {
        /// <summary>The applicable platforms for this management condition.</summary>
        public List<DevicePlatformType?> ApplicablePlatforms { get; set; }
        /// <summary>The time the management condition was created. Generated service side.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>The admin defined description of the management condition.</summary>
        public string Description { get; set; }
        /// <summary>The admin defined name of the management condition.</summary>
        public string DisplayName { get; set; }
        /// <summary>ETag of the management condition. Updated service side.</summary>
        public string ETag { get; set; }
        /// <summary>The management condition statements associated to the management condition.</summary>
        public List<ManagementConditionStatement> ManagementConditionStatements { get; set; }
        /// <summary>The time the management condition was last modified. Updated service side.</summary>
        public DateTimeOffset? ModifiedDateTime { get; set; }
        /// <summary>Unique name for the management condition. Used in management condition expressions.</summary>
        public string UniqueName { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ManagementCondition CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ManagementCondition();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"applicablePlatforms", n => { ApplicablePlatforms = n.GetCollectionOfEnumValues<DevicePlatformType>().ToList(); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"eTag", n => { ETag = n.GetStringValue(); } },
                {"managementConditionStatements", n => { ManagementConditionStatements = n.GetCollectionOfObjectValues<ManagementConditionStatement>(ManagementConditionStatement.CreateFromDiscriminatorValue).ToList(); } },
                {"modifiedDateTime", n => { ModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"uniqueName", n => { UniqueName = n.GetStringValue(); } },
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
            writer.WriteCollectionOfObjectValues<ManagementConditionStatement>("managementConditionStatements", ManagementConditionStatements);
            writer.WriteDateTimeOffsetValue("modifiedDateTime", ModifiedDateTime);
            writer.WriteStringValue("uniqueName", UniqueName);
        }
    }
}
