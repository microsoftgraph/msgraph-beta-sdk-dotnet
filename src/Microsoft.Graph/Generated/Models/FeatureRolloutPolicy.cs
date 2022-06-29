using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of activityStatistics entities.</summary>
    public class FeatureRolloutPolicy : Entity, IParsable {
        /// <summary>Nullable. Specifies a list of directoryObjects that feature is enabled for.</summary>
        public List<DirectoryObject> AppliesTo {
            get { return BackingStore?.Get<List<DirectoryObject>>(nameof(AppliesTo)); }
            set { BackingStore?.Set(nameof(AppliesTo), value); }
        }
        /// <summary>A description for this feature rollout policy.</summary>
        public string Description {
            get { return BackingStore?.Get<string>(nameof(Description)); }
            set { BackingStore?.Set(nameof(Description), value); }
        }
        /// <summary>The display name for this  feature rollout policy.</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>(nameof(DisplayName)); }
            set { BackingStore?.Set(nameof(DisplayName), value); }
        }
        /// <summary>Possible values are: passthroughAuthentication, seamlessSso, passwordHashSync, emailAsAlternateId, unknownFutureValue.</summary>
        public StagedFeatureName? Feature {
            get { return BackingStore?.Get<StagedFeatureName?>(nameof(Feature)); }
            set { BackingStore?.Set(nameof(Feature), value); }
        }
        /// <summary>Indicates whether this feature rollout policy should be applied to the entire organization.</summary>
        public bool? IsAppliedToOrganization {
            get { return BackingStore?.Get<bool?>(nameof(IsAppliedToOrganization)); }
            set { BackingStore?.Set(nameof(IsAppliedToOrganization), value); }
        }
        /// <summary>Indicates whether the feature rollout is enabled.</summary>
        public bool? IsEnabled {
            get { return BackingStore?.Get<bool?>(nameof(IsEnabled)); }
            set { BackingStore?.Set(nameof(IsEnabled), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new FeatureRolloutPolicy CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new FeatureRolloutPolicy();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"appliesTo", n => { AppliesTo = n.GetCollectionOfObjectValues<DirectoryObject>(DirectoryObject.CreateFromDiscriminatorValue).ToList(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"feature", n => { Feature = n.GetEnumValue<StagedFeatureName>(); } },
                {"isAppliedToOrganization", n => { IsAppliedToOrganization = n.GetBoolValue(); } },
                {"isEnabled", n => { IsEnabled = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<DirectoryObject>("appliesTo", AppliesTo);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteEnumValue<StagedFeatureName>("feature", Feature);
            writer.WriteBoolValue("isAppliedToOrganization", IsAppliedToOrganization);
            writer.WriteBoolValue("isEnabled", IsEnabled);
        }
    }
}
