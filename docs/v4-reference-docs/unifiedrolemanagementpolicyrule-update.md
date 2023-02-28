---
title: "Update unifiedRoleManagementPolicyRule"
description: "Update a rule defined for a role management policy."
author: "rkarim-ms"
ms.localizationpriority: medium
ms.prod: "governance"
doc_type: apiPageType
---

# Update unifiedRoleManagementPolicyRule
Namespace: microsoft.graph

Update a rule defined for a role management policy. The rule can be one of the following types that are derived from the [unifiedRoleManagementPolicyRule](../resources/unifiedrolemanagementpolicyrule.md) object:
+ [unifiedRoleManagementPolicyApprovalRule](../resources/unifiedrolemanagementpolicyapprovalrule.md)
+ [unifiedRoleManagementPolicyAuthenticationContextRule](../resources/unifiedrolemanagementpolicyauthenticationcontextrule.md)
+ [unifiedRoleManagementPolicyEnablementRule](../resources/unifiedrolemanagementpolicyenablementrule.md)
+ [unifiedRoleManagementPolicyExpirationRule](../resources/unifiedrolemanagementpolicyexpirationrule.md)
+ [unifiedRoleManagementPolicyNotificationRule](../resources/unifiedrolemanagementpolicynotificationrule.md)

For more information about rules for Azure AD roles and examples of updating rules, see the following articles:
+ [Overview of rules for Azure AD roles in PIM APIs in Microsoft Graph](/graph/identity-governance-pim-rules-overview)
+ [Use PIM APIs in Microsoft Graph to update Azure AD rules](/graph/how-to-pim-update-rules)

## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type|Permissions (from least to most privileged)|
|:---|:---|
|Delegated (work or school account)|RoleManagementPolicy.ReadWrite.Directory, RoleManagement.ReadWrite.Directory|
|Delegated (personal Microsoft account)|Not supported.|
|Application|Not supported.|

## HTTP request

<!-- {
  "blockType": "ignored"
}
-->
``` http
PATCH /policies/roleManagementPolicies/{unifiedRoleManagementPolicyId}/rules/{unifiedRoleManagementPolicyRuleId}
```

## Request headers
|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|
|Content-Type|application/json. Required.|

## Request body
In the request body, supply *only* the values for properties that should be updated. Existing properties that are not included in the request body will maintain their previous values or be recalculated based on changes to other property values.

The following table specifies the properties that can be updated.


|Property|Type|Description|
|:---|:---|:---|
|claimValue|String|The value of the authentication context claim. <br/><br/>Can be updated for the **unifiedRoleManagementPolicyAuthenticationContextRule** rule type.|
|enabledRules|String collection|The collection of rules that are enabled for this policy rule. For example, `MultiFactorAuthentication`, `Ticketing`, and `Justification`.<br/><br/>Can be updated for the **unifiedRoleManagementPolicyEnablementRule** rule type.|
|isDefaultRecipientsEnabled|Boolean|Indicates whether a default recipient will receive the notification email.<br/><br/>Can be updated for the **unifiedRoleManagementPolicyNotificationRule** rule type.|
|isEnabled|Boolean| Whether this rule is enabled. <br/><br/>Can be updated for the **unifiedRoleManagementPolicyAuthenticationContextRule** rule type.|
|isExpirationRequired|Boolean|Indicates whether expiration is required or if it's a permanently active assignment or eligibility. <br/><br/>Can be updated for the **unifiedRoleManagementPolicyExpirationRule** rule type.|
|maximumDuration|Duration| The maximum duration allowed for eligibility or assignment which is not permanent. Required when **isExpirationRequired** is `true`. <br/><br/>Can be updated for the **unifiedRoleManagementPolicyExpirationRule** rule type. |
|notificationLevel|String|The level of notification. The possible values are `None`, `Critical`, `All`.<br/><br/>Can be updated for the **unifiedRoleManagementPolicyNotificationRule** rule type.|
|notificationRecipients|String collection|The list of recipients of the email notifications.<br/><br/>Can be updated for the **unifiedRoleManagementPolicyNotificationRule** rule type.|
|notificationType|String|The type of notification. Only `Email` is supported.<br/><br/>Can be updated for the **unifiedRoleManagementPolicyNotificationRule** rule type.|
|recipientType|String|The type of recipient of the notification. The possible values are `Requestor`, `Approver`, `Admin`.<br/>Can be updated for the **unifiedRoleManagementPolicyNotificationRule** rule type.|
|setting|[approvalSettings](../resources/approvalsettings.md)|The settings for approval of the role assignment. <br/><br/>Can be updated for the **unifiedRoleManagementPolicyApprovalRule** rule type.|
|target|[unifiedRoleManagementPolicyRuleTarget](../resources/unifiedrolemanagementpolicyruletarget.md)|Defines details of the scope that's targeted by role management policy rule. The details can include the principal type, the role assignment type, and actions affecting a role. <br/><br/> Can be updated for all rule types.|

>**Note:** The `@odata.type` property with a value of the specific rule type must be included in the body. For example, `"@odata.type": "#microsoft.graph.unifiedRoleManagementPolicyApprovalRule"`.

## Response

If successful, this method returns a `204 No Content` response code.

## Examples

### Request

The following example updates a role management policy rule with ID `Expiration_EndUser_Assignment`.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "update_unifiedrolemanagementpolicyrule",
  "sampleKeys": ["DirectoryRole_84841066-274d-4ec0-a5c1-276be684bdd3_200ec19a-09e7-4e7a-9515-cf1ee64b96f9", "Expiration_EndUser_Assignment"]
}
-->
``` http
PATCH https://graph.microsoft.com/beta/policies/roleManagementPolicies/DirectoryRole_84841066-274d-4ec0-a5c1-276be684bdd3_200ec19a-09e7-4e7a-9515-cf1ee64b96f9/rules/Expiration_EndUser_Assignment
Content-Type: application/json

{
    "@odata.type": "#microsoft.graph.unifiedRoleManagementPolicyExpirationRule",
    "id": "Expiration_EndUser_Assignment",
    "isExpirationRequired": true,
    "maximumDuration": "PT1H45M",
    "target": {
        "@odata.type": "microsoft.graph.unifiedRoleManagementPolicyRuleTarget",
        "caller": "EndUser",
        "operations": [
            "All"
        ],
        "level": "Assignment",
        "inheritableSettings": [],
        "enforcedSettings": []
    }
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var unifiedRoleManagementPolicyRule = new UnifiedRoleManagementPolicyExpirationRule
{
	Id = "Expiration_EndUser_Assignment",
	IsExpirationRequired = true,
	MaximumDuration = new Duration("PT1H45M"),
	Target = new UnifiedRoleManagementPolicyRuleTarget
	{
		Caller = "EndUser",
		Operations = new List<String>()
		{
			"All"
		},
		Level = "Assignment",
		InheritableSettings = new List<String>()
		{
		},
		EnforcedSettings = new List<String>()
		{
		}
	}
};

await graphClient.Policies.RoleManagementPolicies["{unifiedRoleManagementPolicy-id}"].Rules["{unifiedRoleManagementPolicyRule-id}"]
	.Request()
	.UpdateAsync(unifiedRoleManagementPolicyRule);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response
<!-- {
  "blockType": "response",
  "truncated": true
}
-->
```http
HTTP/1.1 204 No Content
```

## See also

+ [Overview of rules for Azure AD roles in PIM APIs in Microsoft Graph](/graph/identity-governance-pim-rules-overview)
+ [Use PIM APIs in Microsoft Graph to update Azure AD rules](/graph/how-to-pim-update-rules)
