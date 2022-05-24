using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Casts the previous resource to user.</summary>
    public class PlannerUser : PlannerDelta, IParsable {
        /// <summary>The all property</summary>
        public List<PlannerDelta> All {
            get { return BackingStore?.Get<List<PlannerDelta>>(nameof(All)); }
            set { BackingStore?.Set(nameof(All), value); }
        }
        /// <summary>A collection containing the references to the plans that the user has marked as favorites.</summary>
        public PlannerFavoritePlanReferenceCollection FavoritePlanReferences {
            get { return BackingStore?.Get<PlannerFavoritePlanReferenceCollection>(nameof(FavoritePlanReferences)); }
            set { BackingStore?.Set(nameof(FavoritePlanReferences), value); }
        }
        /// <summary>Read-only. Nullable. Returns the plannerPlans that the user marked as favorites.</summary>
        public List<PlannerPlan> FavoritePlans {
            get { return BackingStore?.Get<List<PlannerPlan>>(nameof(FavoritePlans)); }
            set { BackingStore?.Set(nameof(FavoritePlans), value); }
        }
        /// <summary>Read-only. Nullable. Returns the plannerTasks assigned to the user.</summary>
        public List<PlannerPlan> Plans {
            get { return BackingStore?.Get<List<PlannerPlan>>(nameof(Plans)); }
            set { BackingStore?.Set(nameof(Plans), value); }
        }
        /// <summary>A collection containing references to the plans that were viewed recently by the user in apps that support recent plans.</summary>
        public PlannerRecentPlanReferenceCollection RecentPlanReferences {
            get { return BackingStore?.Get<PlannerRecentPlanReferenceCollection>(nameof(RecentPlanReferences)); }
            set { BackingStore?.Set(nameof(RecentPlanReferences), value); }
        }
        /// <summary>Read-only. Nullable. Returns the plannerPlans that have been recently viewed by the user in apps that support recent plans.</summary>
        public List<PlannerPlan> RecentPlans {
            get { return BackingStore?.Get<List<PlannerPlan>>(nameof(RecentPlans)); }
            set { BackingStore?.Set(nameof(RecentPlans), value); }
        }
        /// <summary>Read-only. Nullable. Returns the plannerPlans contained by the plannerRosters the user is a member.</summary>
        public List<PlannerPlan> RosterPlans {
            get { return BackingStore?.Get<List<PlannerPlan>>(nameof(RosterPlans)); }
            set { BackingStore?.Set(nameof(RosterPlans), value); }
        }
        /// <summary>Read-only. Nullable. Returns the plannerTasks assigned to the user.</summary>
        public List<PlannerTask> Tasks {
            get { return BackingStore?.Get<List<PlannerTask>>(nameof(Tasks)); }
            set { BackingStore?.Set(nameof(Tasks), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new PlannerUser CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PlannerUser();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"all", n => { All = n.GetCollectionOfObjectValues<PlannerDelta>(PlannerDelta.CreateFromDiscriminatorValue).ToList(); } },
                {"favoritePlanReferences", n => { FavoritePlanReferences = n.GetObjectValue<PlannerFavoritePlanReferenceCollection>(PlannerFavoritePlanReferenceCollection.CreateFromDiscriminatorValue); } },
                {"favoritePlans", n => { FavoritePlans = n.GetCollectionOfObjectValues<PlannerPlan>(PlannerPlan.CreateFromDiscriminatorValue).ToList(); } },
                {"plans", n => { Plans = n.GetCollectionOfObjectValues<PlannerPlan>(PlannerPlan.CreateFromDiscriminatorValue).ToList(); } },
                {"recentPlanReferences", n => { RecentPlanReferences = n.GetObjectValue<PlannerRecentPlanReferenceCollection>(PlannerRecentPlanReferenceCollection.CreateFromDiscriminatorValue); } },
                {"recentPlans", n => { RecentPlans = n.GetCollectionOfObjectValues<PlannerPlan>(PlannerPlan.CreateFromDiscriminatorValue).ToList(); } },
                {"rosterPlans", n => { RosterPlans = n.GetCollectionOfObjectValues<PlannerPlan>(PlannerPlan.CreateFromDiscriminatorValue).ToList(); } },
                {"tasks", n => { Tasks = n.GetCollectionOfObjectValues<PlannerTask>(PlannerTask.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<PlannerDelta>("all", All);
            writer.WriteObjectValue<PlannerFavoritePlanReferenceCollection>("favoritePlanReferences", FavoritePlanReferences);
            writer.WriteCollectionOfObjectValues<PlannerPlan>("favoritePlans", FavoritePlans);
            writer.WriteCollectionOfObjectValues<PlannerPlan>("plans", Plans);
            writer.WriteObjectValue<PlannerRecentPlanReferenceCollection>("recentPlanReferences", RecentPlanReferences);
            writer.WriteCollectionOfObjectValues<PlannerPlan>("recentPlans", RecentPlans);
            writer.WriteCollectionOfObjectValues<PlannerPlan>("rosterPlans", RosterPlans);
            writer.WriteCollectionOfObjectValues<PlannerTask>("tasks", Tasks);
        }
    }
}
