using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of accessReview entities.</summary>
    public class Schedule : Entity, IParsable {
        /// <summary>Indicates whether the schedule is enabled for the team. Required.</summary>
        public bool? Enabled {
            get { return BackingStore?.Get<bool?>(nameof(Enabled)); }
            set { BackingStore?.Set(nameof(Enabled), value); }
        }
        /// <summary>The offerShiftRequests property</summary>
        public List<OfferShiftRequest> OfferShiftRequests {
            get { return BackingStore?.Get<List<OfferShiftRequest>>(nameof(OfferShiftRequests)); }
            set { BackingStore?.Set(nameof(OfferShiftRequests), value); }
        }
        /// <summary>Indicates whether offer shift requests are enabled for the schedule.</summary>
        public bool? OfferShiftRequestsEnabled {
            get { return BackingStore?.Get<bool?>(nameof(OfferShiftRequestsEnabled)); }
            set { BackingStore?.Set(nameof(OfferShiftRequestsEnabled), value); }
        }
        /// <summary>The openShiftChangeRequests property</summary>
        public List<OpenShiftChangeRequest> OpenShiftChangeRequests {
            get { return BackingStore?.Get<List<OpenShiftChangeRequest>>(nameof(OpenShiftChangeRequests)); }
            set { BackingStore?.Set(nameof(OpenShiftChangeRequests), value); }
        }
        /// <summary>The openShifts property</summary>
        public List<OpenShift> OpenShifts {
            get { return BackingStore?.Get<List<OpenShift>>(nameof(OpenShifts)); }
            set { BackingStore?.Set(nameof(OpenShifts), value); }
        }
        /// <summary>Indicates whether open shifts are enabled for the schedule.</summary>
        public bool? OpenShiftsEnabled {
            get { return BackingStore?.Get<bool?>(nameof(OpenShiftsEnabled)); }
            set { BackingStore?.Set(nameof(OpenShiftsEnabled), value); }
        }
        /// <summary>The status of the schedule provisioning. The possible values are notStarted, running, completed, failed.</summary>
        public OperationStatus? ProvisionStatus {
            get { return BackingStore?.Get<OperationStatus?>(nameof(ProvisionStatus)); }
            set { BackingStore?.Set(nameof(ProvisionStatus), value); }
        }
        /// <summary>Additional information about why schedule provisioning failed.</summary>
        public string ProvisionStatusCode {
            get { return BackingStore?.Get<string>(nameof(ProvisionStatusCode)); }
            set { BackingStore?.Set(nameof(ProvisionStatusCode), value); }
        }
        /// <summary>The logical grouping of users in the schedule (usually by role).</summary>
        public List<SchedulingGroup> SchedulingGroups {
            get { return BackingStore?.Get<List<SchedulingGroup>>(nameof(SchedulingGroups)); }
            set { BackingStore?.Set(nameof(SchedulingGroups), value); }
        }
        /// <summary>The shifts in the schedule.</summary>
        public List<Shift> Shifts {
            get { return BackingStore?.Get<List<Shift>>(nameof(Shifts)); }
            set { BackingStore?.Set(nameof(Shifts), value); }
        }
        /// <summary>The swapShiftsChangeRequests property</summary>
        public List<SwapShiftsChangeRequest> SwapShiftsChangeRequests {
            get { return BackingStore?.Get<List<SwapShiftsChangeRequest>>(nameof(SwapShiftsChangeRequests)); }
            set { BackingStore?.Set(nameof(SwapShiftsChangeRequests), value); }
        }
        /// <summary>Indicates whether swap shifts requests are enabled for the schedule.</summary>
        public bool? SwapShiftsRequestsEnabled {
            get { return BackingStore?.Get<bool?>(nameof(SwapShiftsRequestsEnabled)); }
            set { BackingStore?.Set(nameof(SwapShiftsRequestsEnabled), value); }
        }
        /// <summary>The timeCards property</summary>
        public List<TimeCard> TimeCards {
            get { return BackingStore?.Get<List<TimeCard>>(nameof(TimeCards)); }
            set { BackingStore?.Set(nameof(TimeCards), value); }
        }
        /// <summary>Indicates whether time clock is enabled for the schedule.</summary>
        public bool? TimeClockEnabled {
            get { return BackingStore?.Get<bool?>(nameof(TimeClockEnabled)); }
            set { BackingStore?.Set(nameof(TimeClockEnabled), value); }
        }
        /// <summary>The timeClockSettings property</summary>
        public Microsoft.Graph.Beta.Models.TimeClockSettings TimeClockSettings {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.TimeClockSettings>(nameof(TimeClockSettings)); }
            set { BackingStore?.Set(nameof(TimeClockSettings), value); }
        }
        /// <summary>The set of reasons for a time off in the schedule.</summary>
        public List<TimeOffReason> TimeOffReasons {
            get { return BackingStore?.Get<List<TimeOffReason>>(nameof(TimeOffReasons)); }
            set { BackingStore?.Set(nameof(TimeOffReasons), value); }
        }
        /// <summary>The timeOffRequests property</summary>
        public List<TimeOffRequest> TimeOffRequests {
            get { return BackingStore?.Get<List<TimeOffRequest>>(nameof(TimeOffRequests)); }
            set { BackingStore?.Set(nameof(TimeOffRequests), value); }
        }
        /// <summary>Indicates whether time off requests are enabled for the schedule.</summary>
        public bool? TimeOffRequestsEnabled {
            get { return BackingStore?.Get<bool?>(nameof(TimeOffRequestsEnabled)); }
            set { BackingStore?.Set(nameof(TimeOffRequestsEnabled), value); }
        }
        /// <summary>The instances of times off in the schedule.</summary>
        public List<TimeOff> TimesOff {
            get { return BackingStore?.Get<List<TimeOff>>(nameof(TimesOff)); }
            set { BackingStore?.Set(nameof(TimesOff), value); }
        }
        /// <summary>Indicates the time zone of the schedule team using tz database format. Required.</summary>
        public string TimeZone {
            get { return BackingStore?.Get<string>(nameof(TimeZone)); }
            set { BackingStore?.Set(nameof(TimeZone), value); }
        }
        /// <summary>The workforceIntegrationIds property</summary>
        public List<string> WorkforceIntegrationIds {
            get { return BackingStore?.Get<List<string>>(nameof(WorkforceIntegrationIds)); }
            set { BackingStore?.Set(nameof(WorkforceIntegrationIds), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new Schedule CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Schedule();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"enabled", n => { Enabled = n.GetBoolValue(); } },
                {"offerShiftRequests", n => { OfferShiftRequests = n.GetCollectionOfObjectValues<OfferShiftRequest>(OfferShiftRequest.CreateFromDiscriminatorValue).ToList(); } },
                {"offerShiftRequestsEnabled", n => { OfferShiftRequestsEnabled = n.GetBoolValue(); } },
                {"openShiftChangeRequests", n => { OpenShiftChangeRequests = n.GetCollectionOfObjectValues<OpenShiftChangeRequest>(OpenShiftChangeRequest.CreateFromDiscriminatorValue).ToList(); } },
                {"openShifts", n => { OpenShifts = n.GetCollectionOfObjectValues<OpenShift>(OpenShift.CreateFromDiscriminatorValue).ToList(); } },
                {"openShiftsEnabled", n => { OpenShiftsEnabled = n.GetBoolValue(); } },
                {"provisionStatus", n => { ProvisionStatus = n.GetEnumValue<OperationStatus>(); } },
                {"provisionStatusCode", n => { ProvisionStatusCode = n.GetStringValue(); } },
                {"schedulingGroups", n => { SchedulingGroups = n.GetCollectionOfObjectValues<SchedulingGroup>(SchedulingGroup.CreateFromDiscriminatorValue).ToList(); } },
                {"shifts", n => { Shifts = n.GetCollectionOfObjectValues<Shift>(Shift.CreateFromDiscriminatorValue).ToList(); } },
                {"swapShiftsChangeRequests", n => { SwapShiftsChangeRequests = n.GetCollectionOfObjectValues<SwapShiftsChangeRequest>(SwapShiftsChangeRequest.CreateFromDiscriminatorValue).ToList(); } },
                {"swapShiftsRequestsEnabled", n => { SwapShiftsRequestsEnabled = n.GetBoolValue(); } },
                {"timeCards", n => { TimeCards = n.GetCollectionOfObjectValues<TimeCard>(TimeCard.CreateFromDiscriminatorValue).ToList(); } },
                {"timeClockEnabled", n => { TimeClockEnabled = n.GetBoolValue(); } },
                {"timeClockSettings", n => { TimeClockSettings = n.GetObjectValue<Microsoft.Graph.Beta.Models.TimeClockSettings>(Microsoft.Graph.Beta.Models.TimeClockSettings.CreateFromDiscriminatorValue); } },
                {"timeOffReasons", n => { TimeOffReasons = n.GetCollectionOfObjectValues<TimeOffReason>(TimeOffReason.CreateFromDiscriminatorValue).ToList(); } },
                {"timeOffRequests", n => { TimeOffRequests = n.GetCollectionOfObjectValues<TimeOffRequest>(TimeOffRequest.CreateFromDiscriminatorValue).ToList(); } },
                {"timeOffRequestsEnabled", n => { TimeOffRequestsEnabled = n.GetBoolValue(); } },
                {"timesOff", n => { TimesOff = n.GetCollectionOfObjectValues<TimeOff>(TimeOff.CreateFromDiscriminatorValue).ToList(); } },
                {"timeZone", n => { TimeZone = n.GetStringValue(); } },
                {"workforceIntegrationIds", n => { WorkforceIntegrationIds = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteBoolValue("enabled", Enabled);
            writer.WriteCollectionOfObjectValues<OfferShiftRequest>("offerShiftRequests", OfferShiftRequests);
            writer.WriteBoolValue("offerShiftRequestsEnabled", OfferShiftRequestsEnabled);
            writer.WriteCollectionOfObjectValues<OpenShiftChangeRequest>("openShiftChangeRequests", OpenShiftChangeRequests);
            writer.WriteCollectionOfObjectValues<OpenShift>("openShifts", OpenShifts);
            writer.WriteBoolValue("openShiftsEnabled", OpenShiftsEnabled);
            writer.WriteEnumValue<OperationStatus>("provisionStatus", ProvisionStatus);
            writer.WriteStringValue("provisionStatusCode", ProvisionStatusCode);
            writer.WriteCollectionOfObjectValues<SchedulingGroup>("schedulingGroups", SchedulingGroups);
            writer.WriteCollectionOfObjectValues<Shift>("shifts", Shifts);
            writer.WriteCollectionOfObjectValues<SwapShiftsChangeRequest>("swapShiftsChangeRequests", SwapShiftsChangeRequests);
            writer.WriteBoolValue("swapShiftsRequestsEnabled", SwapShiftsRequestsEnabled);
            writer.WriteCollectionOfObjectValues<TimeCard>("timeCards", TimeCards);
            writer.WriteBoolValue("timeClockEnabled", TimeClockEnabled);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.TimeClockSettings>("timeClockSettings", TimeClockSettings);
            writer.WriteCollectionOfObjectValues<TimeOffReason>("timeOffReasons", TimeOffReasons);
            writer.WriteCollectionOfObjectValues<TimeOffRequest>("timeOffRequests", TimeOffRequests);
            writer.WriteBoolValue("timeOffRequestsEnabled", TimeOffRequestsEnabled);
            writer.WriteCollectionOfObjectValues<TimeOff>("timesOff", TimesOff);
            writer.WriteStringValue("timeZone", TimeZone);
            writer.WriteCollectionOfPrimitiveValues<string>("workforceIntegrationIds", WorkforceIntegrationIds);
        }
    }
}
