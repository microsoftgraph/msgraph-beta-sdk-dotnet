using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of activityStatistics entities.</summary>
    public class Calendar : Entity, IParsable {
        /// <summary>Represent the online meeting service providers that can be used to create online meetings in this calendar. Possible values are: unknown, skypeForBusiness, skypeForConsumer, teamsForBusiness.</summary>
        public List<string> AllowedOnlineMeetingProviders {
            get { return BackingStore?.Get<List<string>>(nameof(AllowedOnlineMeetingProviders)); }
            set { BackingStore?.Set(nameof(AllowedOnlineMeetingProviders), value); }
        }
        /// <summary>The calendarGroup in which to create the calendar. If the user has never explicitly set a group for the calendar, this property is  null.</summary>
        public string CalendarGroupId {
            get { return BackingStore?.Get<string>(nameof(CalendarGroupId)); }
            set { BackingStore?.Set(nameof(CalendarGroupId), value); }
        }
        /// <summary>The permissions of the users with whom the calendar is shared.</summary>
        public List<CalendarPermission> CalendarPermissions {
            get { return BackingStore?.Get<List<CalendarPermission>>(nameof(CalendarPermissions)); }
            set { BackingStore?.Set(nameof(CalendarPermissions), value); }
        }
        /// <summary>The calendar view for the calendar. Navigation property. Read-only.</summary>
        public List<Event> CalendarView {
            get { return BackingStore?.Get<List<Event>>(nameof(CalendarView)); }
            set { BackingStore?.Set(nameof(CalendarView), value); }
        }
        /// <summary>true if the user can write to the calendar, false otherwise. This property is true for the user who created the calendar. This property is also true for a user who has been shared a calendar and granted write access, through an Outlook client or the corresponding calendarPermission resource. Read-only.</summary>
        public bool? CanEdit {
            get { return BackingStore?.Get<bool?>(nameof(CanEdit)); }
            set { BackingStore?.Set(nameof(CanEdit), value); }
        }
        /// <summary>true if the user has the permission to share the calendar, false otherwise. Only the user who created the calendar can share it. Read-only.</summary>
        public bool? CanShare {
            get { return BackingStore?.Get<bool?>(nameof(CanShare)); }
            set { BackingStore?.Set(nameof(CanShare), value); }
        }
        /// <summary>true if the user can read calendar items that have been marked private, false otherwise. This property is set through an Outlook client or the corresponding calendarPermission resource. Read-only.</summary>
        public bool? CanViewPrivateItems {
            get { return BackingStore?.Get<bool?>(nameof(CanViewPrivateItems)); }
            set { BackingStore?.Set(nameof(CanViewPrivateItems), value); }
        }
        /// <summary>Identifies the version of the calendar object. Every time the calendar is changed, changeKey changes as well. This allows Exchange to apply changes to the correct version of the object. Read-only.</summary>
        public string ChangeKey {
            get { return BackingStore?.Get<string>(nameof(ChangeKey)); }
            set { BackingStore?.Set(nameof(ChangeKey), value); }
        }
        /// <summary>Specifies the color theme to distinguish the calendar from other calendars in a UI. The property values are: auto, lightBlue, lightGreen, lightOrange, lightGray, lightYellow, lightTeal, lightPink, lightBrown, lightRed, maxColor.</summary>
        public CalendarColor? Color {
            get { return BackingStore?.Get<CalendarColor?>(nameof(Color)); }
            set { BackingStore?.Set(nameof(Color), value); }
        }
        /// <summary>The default online meeting provider for meetings sent from this calendar. Possible values are: unknown, skypeForBusiness, skypeForConsumer, teamsForBusiness.</summary>
        public OnlineMeetingProviderType? DefaultOnlineMeetingProvider {
            get { return BackingStore?.Get<OnlineMeetingProviderType?>(nameof(DefaultOnlineMeetingProvider)); }
            set { BackingStore?.Set(nameof(DefaultOnlineMeetingProvider), value); }
        }
        /// <summary>The events in the calendar. Navigation property. Read-only.</summary>
        public List<Event> Events {
            get { return BackingStore?.Get<List<Event>>(nameof(Events)); }
            set { BackingStore?.Set(nameof(Events), value); }
        }
        /// <summary>The calendar color, expressed in a hex color code of three hexadecimal values, each ranging from 00 to FF and representing the red, green, or blue components of the color in the RGB color space. If the user has never explicitly set a color for the calendar, this property is  empty.</summary>
        public string HexColor {
            get { return BackingStore?.Get<string>(nameof(HexColor)); }
            set { BackingStore?.Set(nameof(HexColor), value); }
        }
        /// <summary>true if this is the default calendar where new events are created by default, false otherwise.</summary>
        public bool? IsDefaultCalendar {
            get { return BackingStore?.Get<bool?>(nameof(IsDefaultCalendar)); }
            set { BackingStore?.Set(nameof(IsDefaultCalendar), value); }
        }
        /// <summary>Indicates whether this user calendar can be deleted from the user mailbox.</summary>
        public bool? IsRemovable {
            get { return BackingStore?.Get<bool?>(nameof(IsRemovable)); }
            set { BackingStore?.Set(nameof(IsRemovable), value); }
        }
        /// <summary>true if the user has shared the calendar with other users, false otherwise. Since only the user who created the calendar can share it, isShared and isSharedWithMe cannot be true for the same user. This property is set when sharing is initiated in an Outlook client, and can be reset when the sharing is cancelled through the client or the corresponding calendarPermission resource. Read-only.</summary>
        public bool? IsShared {
            get { return BackingStore?.Get<bool?>(nameof(IsShared)); }
            set { BackingStore?.Set(nameof(IsShared), value); }
        }
        /// <summary>true if the user has been shared this calendar, false otherwise. This property is always false for a calendar owner. This property is set when sharing is initiated in an Outlook client, and can be reset when the sharing is cancelled through the client or the corresponding calendarPermission resource. Read-only.</summary>
        public bool? IsSharedWithMe {
            get { return BackingStore?.Get<bool?>(nameof(IsSharedWithMe)); }
            set { BackingStore?.Set(nameof(IsSharedWithMe), value); }
        }
        /// <summary>Indicates whether this user calendar supports tracking of meeting responses. Only meeting invites sent from users&apos; primary calendars support tracking of meeting responses.</summary>
        public bool? IsTallyingResponses {
            get { return BackingStore?.Get<bool?>(nameof(IsTallyingResponses)); }
            set { BackingStore?.Set(nameof(IsTallyingResponses), value); }
        }
        /// <summary>The collection of multi-value extended properties defined for the calendar. Read-only. Nullable.</summary>
        public List<MultiValueLegacyExtendedProperty> MultiValueExtendedProperties {
            get { return BackingStore?.Get<List<MultiValueLegacyExtendedProperty>>(nameof(MultiValueExtendedProperties)); }
            set { BackingStore?.Set(nameof(MultiValueExtendedProperties), value); }
        }
        /// <summary>The calendar name.</summary>
        public string Name {
            get { return BackingStore?.Get<string>(nameof(Name)); }
            set { BackingStore?.Set(nameof(Name), value); }
        }
        /// <summary>If set, this represents the user who created or added the calendar. For a calendar that the user created or added, the owner property is set to the user. For a calendar shared with the user, the owner property is set to the person who shared that calendar with the user. Read-only.</summary>
        public EmailAddress Owner {
            get { return BackingStore?.Get<EmailAddress>(nameof(Owner)); }
            set { BackingStore?.Set(nameof(Owner), value); }
        }
        /// <summary>The collection of single-value extended properties defined for the calendar. Read-only. Nullable.</summary>
        public List<SingleValueLegacyExtendedProperty> SingleValueExtendedProperties {
            get { return BackingStore?.Get<List<SingleValueLegacyExtendedProperty>>(nameof(SingleValueExtendedProperties)); }
            set { BackingStore?.Set(nameof(SingleValueExtendedProperties), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new Calendar CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Calendar();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"allowedOnlineMeetingProviders", n => { AllowedOnlineMeetingProviders = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"calendarGroupId", n => { CalendarGroupId = n.GetStringValue(); } },
                {"calendarPermissions", n => { CalendarPermissions = n.GetCollectionOfObjectValues<CalendarPermission>(CalendarPermission.CreateFromDiscriminatorValue).ToList(); } },
                {"calendarView", n => { CalendarView = n.GetCollectionOfObjectValues<Event>(Event.CreateFromDiscriminatorValue).ToList(); } },
                {"canEdit", n => { CanEdit = n.GetBoolValue(); } },
                {"canShare", n => { CanShare = n.GetBoolValue(); } },
                {"canViewPrivateItems", n => { CanViewPrivateItems = n.GetBoolValue(); } },
                {"changeKey", n => { ChangeKey = n.GetStringValue(); } },
                {"color", n => { Color = n.GetEnumValue<CalendarColor>(); } },
                {"defaultOnlineMeetingProvider", n => { DefaultOnlineMeetingProvider = n.GetEnumValue<OnlineMeetingProviderType>(); } },
                {"events", n => { Events = n.GetCollectionOfObjectValues<Event>(Event.CreateFromDiscriminatorValue).ToList(); } },
                {"hexColor", n => { HexColor = n.GetStringValue(); } },
                {"isDefaultCalendar", n => { IsDefaultCalendar = n.GetBoolValue(); } },
                {"isRemovable", n => { IsRemovable = n.GetBoolValue(); } },
                {"isShared", n => { IsShared = n.GetBoolValue(); } },
                {"isSharedWithMe", n => { IsSharedWithMe = n.GetBoolValue(); } },
                {"isTallyingResponses", n => { IsTallyingResponses = n.GetBoolValue(); } },
                {"multiValueExtendedProperties", n => { MultiValueExtendedProperties = n.GetCollectionOfObjectValues<MultiValueLegacyExtendedProperty>(MultiValueLegacyExtendedProperty.CreateFromDiscriminatorValue).ToList(); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"owner", n => { Owner = n.GetObjectValue<EmailAddress>(EmailAddress.CreateFromDiscriminatorValue); } },
                {"singleValueExtendedProperties", n => { SingleValueExtendedProperties = n.GetCollectionOfObjectValues<SingleValueLegacyExtendedProperty>(SingleValueLegacyExtendedProperty.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfPrimitiveValues<string>("allowedOnlineMeetingProviders", AllowedOnlineMeetingProviders);
            writer.WriteStringValue("calendarGroupId", CalendarGroupId);
            writer.WriteCollectionOfObjectValues<CalendarPermission>("calendarPermissions", CalendarPermissions);
            writer.WriteCollectionOfObjectValues<Event>("calendarView", CalendarView);
            writer.WriteBoolValue("canEdit", CanEdit);
            writer.WriteBoolValue("canShare", CanShare);
            writer.WriteBoolValue("canViewPrivateItems", CanViewPrivateItems);
            writer.WriteStringValue("changeKey", ChangeKey);
            writer.WriteEnumValue<CalendarColor>("color", Color);
            writer.WriteEnumValue<OnlineMeetingProviderType>("defaultOnlineMeetingProvider", DefaultOnlineMeetingProvider);
            writer.WriteCollectionOfObjectValues<Event>("events", Events);
            writer.WriteStringValue("hexColor", HexColor);
            writer.WriteBoolValue("isDefaultCalendar", IsDefaultCalendar);
            writer.WriteBoolValue("isRemovable", IsRemovable);
            writer.WriteBoolValue("isShared", IsShared);
            writer.WriteBoolValue("isSharedWithMe", IsSharedWithMe);
            writer.WriteBoolValue("isTallyingResponses", IsTallyingResponses);
            writer.WriteCollectionOfObjectValues<MultiValueLegacyExtendedProperty>("multiValueExtendedProperties", MultiValueExtendedProperties);
            writer.WriteStringValue("name", Name);
            writer.WriteObjectValue<EmailAddress>("owner", Owner);
            writer.WriteCollectionOfObjectValues<SingleValueLegacyExtendedProperty>("singleValueExtendedProperties", SingleValueExtendedProperties);
        }
    }
}
