using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class SharedPCConfiguration : DeviceConfiguration, IParsable {
        /// <summary>Specifies how accounts are managed on a shared PC. Only applies when disableAccountManager is false.</summary>
        public SharedPCAccountManagerPolicy AccountManagerPolicy {
            get { return BackingStore?.Get<SharedPCAccountManagerPolicy>(nameof(AccountManagerPolicy)); }
            set { BackingStore?.Set(nameof(AccountManagerPolicy), value); }
        }
        /// <summary>Indicates which type of accounts are allowed to use on a shared PC. Possible values are: notConfigured, guest, domain.</summary>
        public SharedPCAllowedAccountType? AllowedAccounts {
            get { return BackingStore?.Get<SharedPCAllowedAccountType?>(nameof(AllowedAccounts)); }
            set { BackingStore?.Set(nameof(AllowedAccounts), value); }
        }
        /// <summary>Specifies whether local storage is allowed on a shared PC.</summary>
        public bool? AllowLocalStorage {
            get { return BackingStore?.Get<bool?>(nameof(AllowLocalStorage)); }
            set { BackingStore?.Set(nameof(AllowLocalStorage), value); }
        }
        /// <summary>Disables the account manager for shared PC mode.</summary>
        public bool? DisableAccountManager {
            get { return BackingStore?.Get<bool?>(nameof(DisableAccountManager)); }
            set { BackingStore?.Set(nameof(DisableAccountManager), value); }
        }
        /// <summary>Specifies whether the default shared PC education environment policies should be disabled. For Windows 10 RS2 and later, this policy will be applied without setting Enabled to true.</summary>
        public bool? DisableEduPolicies {
            get { return BackingStore?.Get<bool?>(nameof(DisableEduPolicies)); }
            set { BackingStore?.Set(nameof(DisableEduPolicies), value); }
        }
        /// <summary>Specifies whether the default shared PC power policies should be disabled.</summary>
        public bool? DisablePowerPolicies {
            get { return BackingStore?.Get<bool?>(nameof(DisablePowerPolicies)); }
            set { BackingStore?.Set(nameof(DisablePowerPolicies), value); }
        }
        /// <summary>Disables the requirement to sign in whenever the device wakes up from sleep mode.</summary>
        public bool? DisableSignInOnResume {
            get { return BackingStore?.Get<bool?>(nameof(DisableSignInOnResume)); }
            set { BackingStore?.Set(nameof(DisableSignInOnResume), value); }
        }
        /// <summary>Enables shared PC mode and applies the shared pc policies.</summary>
        public bool? Enabled {
            get { return BackingStore?.Get<bool?>(nameof(Enabled)); }
            set { BackingStore?.Set(nameof(Enabled), value); }
        }
        /// <summary>Specifies whether to auto connect new non-admin Azure AD accounts to pre-configured candidate local accounts. Possible values are: notConfigured, enabled, disabled.</summary>
        public Enablement? FastFirstSignIn {
            get { return BackingStore?.Get<Enablement?>(nameof(FastFirstSignIn)); }
            set { BackingStore?.Set(nameof(FastFirstSignIn), value); }
        }
        /// <summary>Specifies the time in seconds that a device must sit idle before the PC goes to sleep. Setting this value to 0 prevents the sleep timeout from occurring.</summary>
        public int? IdleTimeBeforeSleepInSeconds {
            get { return BackingStore?.Get<int?>(nameof(IdleTimeBeforeSleepInSeconds)); }
            set { BackingStore?.Set(nameof(IdleTimeBeforeSleepInSeconds), value); }
        }
        /// <summary>Specifies the display text for the account shown on the sign-in screen which launches the app specified by SetKioskAppUserModelId. Only applies when KioskAppUserModelId is set.</summary>
        public string KioskAppDisplayName {
            get { return BackingStore?.Get<string>(nameof(KioskAppDisplayName)); }
            set { BackingStore?.Set(nameof(KioskAppDisplayName), value); }
        }
        /// <summary>Specifies the application user model ID of the app to use with assigned access.</summary>
        public string KioskAppUserModelId {
            get { return BackingStore?.Get<string>(nameof(KioskAppUserModelId)); }
            set { BackingStore?.Set(nameof(KioskAppUserModelId), value); }
        }
        /// <summary>Specifies whether local storage is allowed on a shared PC. Possible values are: notConfigured, enabled, disabled.</summary>
        public Enablement? LocalStorage {
            get { return BackingStore?.Get<Enablement?>(nameof(LocalStorage)); }
            set { BackingStore?.Set(nameof(LocalStorage), value); }
        }
        /// <summary>Specifies the daily start time of maintenance hour.</summary>
        public Time? MaintenanceStartTime {
            get { return BackingStore?.Get<Time?>(nameof(MaintenanceStartTime)); }
            set { BackingStore?.Set(nameof(MaintenanceStartTime), value); }
        }
        /// <summary>Disables the account manager for shared PC mode. Possible values are: notConfigured, enabled, disabled.</summary>
        public Enablement? SetAccountManager {
            get { return BackingStore?.Get<Enablement?>(nameof(SetAccountManager)); }
            set { BackingStore?.Set(nameof(SetAccountManager), value); }
        }
        /// <summary>Specifies whether the default shared PC education environment policies should be enabled/disabled/not configured. For Windows 10 RS2 and later, this policy will be applied without setting Enabled to true. Possible values are: notConfigured, enabled, disabled.</summary>
        public Enablement? SetEduPolicies {
            get { return BackingStore?.Get<Enablement?>(nameof(SetEduPolicies)); }
            set { BackingStore?.Set(nameof(SetEduPolicies), value); }
        }
        /// <summary>Specifies whether the default shared PC power policies should be enabled/disabled. Possible values are: notConfigured, enabled, disabled.</summary>
        public Enablement? SetPowerPolicies {
            get { return BackingStore?.Get<Enablement?>(nameof(SetPowerPolicies)); }
            set { BackingStore?.Set(nameof(SetPowerPolicies), value); }
        }
        /// <summary>Specifies the requirement to sign in whenever the device wakes up from sleep mode. Possible values are: notConfigured, enabled, disabled.</summary>
        public Enablement? SignInOnResume {
            get { return BackingStore?.Get<Enablement?>(nameof(SignInOnResume)); }
            set { BackingStore?.Set(nameof(SignInOnResume), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new SharedPCConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SharedPCConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"accountManagerPolicy", n => { AccountManagerPolicy = n.GetObjectValue<SharedPCAccountManagerPolicy>(SharedPCAccountManagerPolicy.CreateFromDiscriminatorValue); } },
                {"allowedAccounts", n => { AllowedAccounts = n.GetEnumValue<SharedPCAllowedAccountType>(); } },
                {"allowLocalStorage", n => { AllowLocalStorage = n.GetBoolValue(); } },
                {"disableAccountManager", n => { DisableAccountManager = n.GetBoolValue(); } },
                {"disableEduPolicies", n => { DisableEduPolicies = n.GetBoolValue(); } },
                {"disablePowerPolicies", n => { DisablePowerPolicies = n.GetBoolValue(); } },
                {"disableSignInOnResume", n => { DisableSignInOnResume = n.GetBoolValue(); } },
                {"enabled", n => { Enabled = n.GetBoolValue(); } },
                {"fastFirstSignIn", n => { FastFirstSignIn = n.GetEnumValue<Enablement>(); } },
                {"idleTimeBeforeSleepInSeconds", n => { IdleTimeBeforeSleepInSeconds = n.GetIntValue(); } },
                {"kioskAppDisplayName", n => { KioskAppDisplayName = n.GetStringValue(); } },
                {"kioskAppUserModelId", n => { KioskAppUserModelId = n.GetStringValue(); } },
                {"localStorage", n => { LocalStorage = n.GetEnumValue<Enablement>(); } },
                {"maintenanceStartTime", n => { MaintenanceStartTime = n.GetTimeValue(); } },
                {"setAccountManager", n => { SetAccountManager = n.GetEnumValue<Enablement>(); } },
                {"setEduPolicies", n => { SetEduPolicies = n.GetEnumValue<Enablement>(); } },
                {"setPowerPolicies", n => { SetPowerPolicies = n.GetEnumValue<Enablement>(); } },
                {"signInOnResume", n => { SignInOnResume = n.GetEnumValue<Enablement>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<SharedPCAccountManagerPolicy>("accountManagerPolicy", AccountManagerPolicy);
            writer.WriteEnumValue<SharedPCAllowedAccountType>("allowedAccounts", AllowedAccounts);
            writer.WriteBoolValue("allowLocalStorage", AllowLocalStorage);
            writer.WriteBoolValue("disableAccountManager", DisableAccountManager);
            writer.WriteBoolValue("disableEduPolicies", DisableEduPolicies);
            writer.WriteBoolValue("disablePowerPolicies", DisablePowerPolicies);
            writer.WriteBoolValue("disableSignInOnResume", DisableSignInOnResume);
            writer.WriteBoolValue("enabled", Enabled);
            writer.WriteEnumValue<Enablement>("fastFirstSignIn", FastFirstSignIn);
            writer.WriteIntValue("idleTimeBeforeSleepInSeconds", IdleTimeBeforeSleepInSeconds);
            writer.WriteStringValue("kioskAppDisplayName", KioskAppDisplayName);
            writer.WriteStringValue("kioskAppUserModelId", KioskAppUserModelId);
            writer.WriteEnumValue<Enablement>("localStorage", LocalStorage);
            writer.WriteTimeValue("maintenanceStartTime", MaintenanceStartTime);
            writer.WriteEnumValue<Enablement>("setAccountManager", SetAccountManager);
            writer.WriteEnumValue<Enablement>("setEduPolicies", SetEduPolicies);
            writer.WriteEnumValue<Enablement>("setPowerPolicies", SetPowerPolicies);
            writer.WriteEnumValue<Enablement>("signInOnResume", SignInOnResume);
        }
    }
}
