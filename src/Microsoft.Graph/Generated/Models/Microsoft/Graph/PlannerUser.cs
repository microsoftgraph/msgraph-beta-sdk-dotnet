using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class PlannerUser : PlannerDelta, IParsable {
        public List<PlannerDelta> All { get; set; }
        /// <summary>A collection containing the references to the plans that the user has marked as favorites.</summary>
        public PlannerFavoritePlanReferenceCollection FavoritePlanReferences { get; set; }
        /// <summary>Read-only. Nullable. Returns the plannerPlans that the user marked as favorites.</summary>
        public List<PlannerPlan> FavoritePlans { get; set; }
        /// <summary>Read-only. Nullable. Returns the plannerTasks assigned to the user.</summary>
        public List<PlannerPlan> Plans { get; set; }
        /// <summary>A collection containing references to the plans that were viewed recently by the user in apps that support recent plans.</summary>
        public PlannerRecentPlanReferenceCollection RecentPlanReferences { get; set; }
        /// <summary>Read-only. Nullable. Returns the plannerPlans that have been recently viewed by the user in apps that support recent plans.</summary>
        public List<PlannerPlan> RecentPlans { get; set; }
        /// <summary>Read-only. Nullable. Returns the plannerPlans contained by the plannerRosters the user is a member.</summary>
        public List<PlannerPlan> RosterPlans { get; set; }
        /// <summary>Read-only. Nullable. Returns the plannerPlans shared with the user.</summary>
        public List<PlannerTask> Tasks { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"all", (o,n) => { (o as PlannerUser).All = n.GetCollectionOfObjectValues<PlannerDelta>().ToList(); } },
                {"favoritePlanReferences", (o,n) => { (o as PlannerUser).FavoritePlanReferences = n.GetObjectValue<PlannerFavoritePlanReferenceCollection>(); } },
                {"favoritePlans", (o,n) => { (o as PlannerUser).FavoritePlans = n.GetCollectionOfObjectValues<PlannerPlan>().ToList(); } },
                {"plans", (o,n) => { (o as PlannerUser).Plans = n.GetCollectionOfObjectValues<PlannerPlan>().ToList(); } },
                {"recentPlanReferences", (o,n) => { (o as PlannerUser).RecentPlanReferences = n.GetObjectValue<PlannerRecentPlanReferenceCollection>(); } },
                {"recentPlans", (o,n) => { (o as PlannerUser).RecentPlans = n.GetCollectionOfObjectValues<PlannerPlan>().ToList(); } },
                {"rosterPlans", (o,n) => { (o as PlannerUser).RosterPlans = n.GetCollectionOfObjectValues<PlannerPlan>().ToList(); } },
                {"tasks", (o,n) => { (o as PlannerUser).Tasks = n.GetCollectionOfObjectValues<PlannerTask>().ToList(); } },
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
