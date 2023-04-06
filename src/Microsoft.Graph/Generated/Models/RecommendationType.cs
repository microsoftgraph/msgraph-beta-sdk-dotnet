using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum RecommendationType {
        [EnumMember(Value = "adfsAppsMigration")]
        AdfsAppsMigration,
        [EnumMember(Value = "enableDesktopSSO")]
        EnableDesktopSSO,
        [EnumMember(Value = "enablePHS")]
        EnablePHS,
        [EnumMember(Value = "enableProvisioning")]
        EnableProvisioning,
        [EnumMember(Value = "switchFromPerUserMFA")]
        SwitchFromPerUserMFA,
        [EnumMember(Value = "tenantMFA")]
        TenantMFA,
        [EnumMember(Value = "thirdPartyApps")]
        ThirdPartyApps,
        [EnumMember(Value = "turnOffPerUserMFA")]
        TurnOffPerUserMFA,
        [EnumMember(Value = "useAuthenticatorApp")]
        UseAuthenticatorApp,
        [EnumMember(Value = "useMyApps")]
        UseMyApps,
        [EnumMember(Value = "staleApps")]
        StaleApps,
        [EnumMember(Value = "staleAppCreds")]
        StaleAppCreds,
        [EnumMember(Value = "applicationCredentialExpiry")]
        ApplicationCredentialExpiry,
        [EnumMember(Value = "servicePrincipalKeyExpiry")]
        ServicePrincipalKeyExpiry,
        [EnumMember(Value = "adminMFAV2")]
        AdminMFAV2,
        [EnumMember(Value = "blockLegacyAuthentication")]
        BlockLegacyAuthentication,
        [EnumMember(Value = "integratedApps")]
        IntegratedApps,
        [EnumMember(Value = "mfaRegistrationV2")]
        MfaRegistrationV2,
        [EnumMember(Value = "pwagePolicyNew")]
        PwagePolicyNew,
        [EnumMember(Value = "passwordHashSync")]
        PasswordHashSync,
        [EnumMember(Value = "oneAdmin")]
        OneAdmin,
        [EnumMember(Value = "roleOverlap")]
        RoleOverlap,
        [EnumMember(Value = "selfServicePasswordReset")]
        SelfServicePasswordReset,
        [EnumMember(Value = "signinRiskPolicy")]
        SigninRiskPolicy,
        [EnumMember(Value = "userRiskPolicy")]
        UserRiskPolicy,
        [EnumMember(Value = "verifyAppPublisher")]
        VerifyAppPublisher,
        [EnumMember(Value = "privateLinkForAAD")]
        PrivateLinkForAAD,
        [EnumMember(Value = "appRoleAssignmentsGroups")]
        AppRoleAssignmentsGroups,
        [EnumMember(Value = "appRoleAssignmentsUsers")]
        AppRoleAssignmentsUsers,
        [EnumMember(Value = "managedIdentity")]
        ManagedIdentity,
        [EnumMember(Value = "overprivilegedApps")]
        OverprivilegedApps,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
