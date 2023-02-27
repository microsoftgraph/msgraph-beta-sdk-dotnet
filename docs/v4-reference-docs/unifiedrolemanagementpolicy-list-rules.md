---
title: "List rules (for a role management policy)"
description: "Get the rules defined for a role management policy."
author: "rkarim-ms"
ms.localizationpriority: medium
ms.prod: "governance"
doc_type: apiPageType
---

# List rules (for a role management policy)
Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Get the rules defined for a role management policy. The rules are a collection of following types that are derived from the [unifiedRoleManagementPolicyRule](../resources/unifiedrolemanagementpolicyrule.md) object:
+ [unifiedRoleManagementPolicyApprovalRule](../resources/unifiedrolemanagementpolicyapprovalrule.md)
+ [unifiedRoleManagementPolicyAuthenticationContextRule](../resources/unifiedrolemanagementpolicyauthenticationcontextrule.md)
+ [unifiedRoleManagementPolicyEnablementRule](../resources/unifiedrolemanagementpolicyenablementrule.md)
+ [unifiedRoleManagementPolicyExpirationRule](../resources/unifiedrolemanagementpolicyexpirationrule.md)
+ [unifiedRoleManagementPolicyNotificationRule](../resources/unifiedrolemanagementpolicynotificationrule.md)

To retrieve rules for a policy that applies to Azure RBAC, use the [Azure REST PIM API for role management policies](/rest/api/authorization/role-management-policies/list-for-scope).

## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type|Permissions (from least to most privileged)|
|:---|:---|
|Delegated (work or school account)|RoleManagementPolicy.Read.Directory, RoleManagement.Read.Directory, RoleManagement.Read.All, RoleManagementPolicy.ReadWrite.Directory, RoleManagement.ReadWrite.Directory|
|Delegated (personal Microsoft account)|Not supported|
|Application|RoleManagement.Read.Directory, RoleManagement.Read.All, RoleManagement.ReadWrite.Directory|

## HTTP request

<!-- {
  "blockType": "ignored"
}
-->
``` http
GET /policies/roleManagementPolicies/{unifiedRoleManagementPolicyId}/rules
```

## Optional query parameters
This method supports the `$select` and `$filter` OData query parameters to help customize the response. For general information, see [OData query parameters](/graph/query-parameters).

## Request headers
|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|

## Request body
Do not supply a request body for this method.

## Response

If successful, this method returns a `200 OK` response code and a collection of [unifiedRoleManagementPolicyRule](../resources/unifiedrolemanagementpolicyrule.md) objects in the response body.

## Examples

### Request

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "list_unifiedrolemanagementpolicyruleforID",
  "sampleKeys": ["DirectoryRole_cab01047-8ad9-4792-8e42-569340767f1b_70c808b5-0d35-4863-a0ba-07888e99d448"]
}
-->
``` http
GET https://graph.microsoft.com/beta/policies/roleManagementPolicies/DirectoryRole_cab01047-8ad9-4792-8e42-569340767f1b_70c808b5-0d35-4863-a0ba-07888e99d448/rules
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var rules = await graphClient.Policies.RoleManagementPolicies["{unifiedRoleManagementPolicy-id}"].Rules
	.Request()
	.GetAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response
**Note:** The response object shown here might be shortened for readability.
<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "Collection(microsoft.graph.unifiedRoleManagementPolicyRule)"
}
-->
``` http
HTTP/1.1 200 OK
Content-Type: application/json

{
    "@odata.context": "https://graph.microsoft.com/beta/$metadata#policies/roleManagementPolicies('DirectoryRole_cab01047-8ad9-4792-8e42-569340767f1b_70c808b5-0d35-4863-a0ba-07888e99d448')/rules",
    "value": [
        {
            "@odata.type": "#microsoft.graph.unifiedRoleManagementPolicyEnablementRule",
            "id": "Enablement_Admin_Eligibility",
            "enabledRules": [],
            "target": {
                "caller": "Admin",
                "operations": [
                    "All"
                ],
                "level": "Eligibility",
                "inheritableSettings": [],
                "enforcedSettings": []
            }
        },
        {
            "@odata.type": "#microsoft.graph.unifiedRoleManagementPolicyExpirationRule",
            "id": "Expiration_Admin_Eligibility",
            "isExpirationRequired": false,
            "maximumDuration": "P365D",
            "target": {
                "caller": "Admin",
                "operations": [
                    "All"
                ],
                "level": "Eligibility",
                "inheritableSettings": [],
                "enforcedSettings": []
            }
        },
        {
            "@odata.type": "#microsoft.graph.unifiedRoleManagementPolicyNotificationRule",
            "id": "Notification_Admin_Admin_Eligibility",
            "notificationType": "Email",
            "recipientType": "Admin",
            "notificationLevel": "All",
            "isDefaultRecipientsEnabled": true,
            "notificationRecipients": [],
            "target": {
                "caller": "Admin",
                "operations": [
                    "All"
                ],
                "level": "Eligibility",
                "inheritableSettings": [],
                "enforcedSettings": []
            }
        },
        {
            "@odata.type": "#microsoft.graph.unifiedRoleManagementPolicyNotificationRule",
            "id": "Notification_Requestor_Admin_Eligibility",
            "notificationType": "Email",
            "recipientType": "Requestor",
            "notificationLevel": "All",
            "isDefaultRecipientsEnabled": true,
            "notificationRecipients": [],
            "target": {
                "caller": "Admin",
                "operations": [
                    "All"
                ],
                "level": "Eligibility",
                "inheritableSettings": [],
                "enforcedSettings": []
            }
        },
        {
            "@odata.type": "#microsoft.graph.unifiedRoleManagementPolicyNotificationRule",
            "id": "Notification_Approver_Admin_Eligibility",
            "notificationType": "Email",
            "recipientType": "Approver",
            "notificationLevel": "All",
            "isDefaultRecipientsEnabled": true,
            "notificationRecipients": [],
            "target": {
                "caller": "Admin",
                "operations": [
                    "All"
                ],
                "level": "Eligibility",
                "inheritableSettings": [],
                "enforcedSettings": []
            }
        },
        {
            "@odata.type": "#microsoft.graph.unifiedRoleManagementPolicyEnablementRule",
            "id": "Enablement_Admin_Assignment",
            "enabledRules": [
                "Justification"
            ],
            "target": {
                "caller": "Admin",
                "operations": [
                    "All"
                ],
                "level": "Assignment",
                "inheritableSettings": [],
                "enforcedSettings": []
            }
        },
        {
            "@odata.type": "#microsoft.graph.unifiedRoleManagementPolicyExpirationRule",
            "id": "Expiration_Admin_Assignment",
            "isExpirationRequired": false,
            "maximumDuration": "P180D",
            "target": {
                "caller": "Admin",
                "operations": [
                    "All"
                ],
                "level": "Assignment",
                "inheritableSettings": [],
                "enforcedSettings": []
            }
        },
        {
            "@odata.type": "#microsoft.graph.unifiedRoleManagementPolicyNotificationRule",
            "id": "Notification_Admin_Admin_Assignment",
            "notificationType": "Email",
            "recipientType": "Admin",
            "notificationLevel": "All",
            "isDefaultRecipientsEnabled": true,
            "notificationRecipients": [],
            "target": {
                "caller": "Admin",
                "operations": [
                    "All"
                ],
                "level": "Assignment",
                "inheritableSettings": [],
                "enforcedSettings": []
            }
        },
        {
            "@odata.type": "#microsoft.graph.unifiedRoleManagementPolicyNotificationRule",
            "id": "Notification_Requestor_Admin_Assignment",
            "notificationType": "Email",
            "recipientType": "Requestor",
            "notificationLevel": "All",
            "isDefaultRecipientsEnabled": true,
            "notificationRecipients": [],
            "target": {
                "caller": "Admin",
                "operations": [
                    "All"
                ],
                "level": "Assignment",
                "inheritableSettings": [],
                "enforcedSettings": []
            }
        },
        {
            "@odata.type": "#microsoft.graph.unifiedRoleManagementPolicyNotificationRule",
            "id": "Notification_Approver_Admin_Assignment",
            "notificationType": "Email",
            "recipientType": "Approver",
            "notificationLevel": "All",
            "isDefaultRecipientsEnabled": true,
            "notificationRecipients": [],
            "target": {
                "caller": "Admin",
                "operations": [
                    "All"
                ],
                "level": "Assignment",
                "inheritableSettings": [],
                "enforcedSettings": []
            }
        },
        {
            "@odata.type": "#microsoft.graph.unifiedRoleManagementPolicyApprovalRule",
            "id": "Approval_EndUser_Assignment",
            "target": {
                "caller": "EndUser",
                "operations": [
                    "All"
                ],
                "level": "Assignment",
                "inheritableSettings": [],
                "enforcedSettings": []
            },
            "setting": {
                "isApprovalRequired": false,
                "isApprovalRequiredForExtension": false,
                "isRequestorJustificationRequired": true,
                "approvalMode": "SingleStage",
                "approvalStages": [
                    {
                        "approvalStageTimeOutInDays": 1,
                        "isApproverJustificationRequired": true,
                        "escalationTimeInMinutes": 0,
                        "isEscalationEnabled": false,
                        "primaryApprovers": [],
                        "escalationApprovers": []
                    }
                ]
            }
        },
        {
            "@odata.type": "#microsoft.graph.unifiedRoleManagementPolicyAuthenticationContextRule",
            "id": "AuthenticationContext_EndUser_Assignment",
            "isEnabled": false,
            "claimValue": null,
            "target": {
                "caller": "EndUser",
                "operations": [
                    "All"
                ],
                "level": "Assignment",
                "inheritableSettings": [],
                "enforcedSettings": []
            }
        },
        {
            "@odata.type": "#microsoft.graph.unifiedRoleManagementPolicyEnablementRule",
            "id": "Enablement_EndUser_Assignment",
            "enabledRules": [],
            "target": {
                "caller": "EndUser",
                "operations": [
                    "All"
                ],
                "level": "Assignment",
                "inheritableSettings": [],
                "enforcedSettings": []
            }
        },
        {
            "@odata.type": "#microsoft.graph.unifiedRoleManagementPolicyExpirationRule",
            "id": "Expiration_EndUser_Assignment",
            "isExpirationRequired": true,
            "maximumDuration": "PT1H45M",
            "target": {
                "caller": "EndUser",
                "operations": [
                    "All"
                ],
                "level": "Assignment",
                "inheritableSettings": [],
                "enforcedSettings": []
            }
        },
        {
            "@odata.type": "#microsoft.graph.unifiedRoleManagementPolicyNotificationRule",
            "id": "Notification_Admin_EndUser_Assignment",
            "notificationType": "Email",
            "recipientType": "Admin",
            "notificationLevel": "All",
            "isDefaultRecipientsEnabled": true,
            "notificationRecipients": [],
            "target": {
                "caller": "EndUser",
                "operations": [
                    "All"
                ],
                "level": "Assignment",
                "inheritableSettings": [],
                "enforcedSettings": []
            }
        },
        {
            "@odata.type": "#microsoft.graph.unifiedRoleManagementPolicyNotificationRule",
            "id": "Notification_Requestor_EndUser_Assignment",
            "notificationType": "Email",
            "recipientType": "Requestor",
            "notificationLevel": "All",
            "isDefaultRecipientsEnabled": true,
            "notificationRecipients": [],
            "target": {
                "caller": "EndUser",
                "operations": [
                    "All"
                ],
                "level": "Assignment",
                "inheritableSettings": [],
                "enforcedSettings": []
            }
        },
        {
            "@odata.type": "#microsoft.graph.unifiedRoleManagementPolicyNotificationRule",
            "id": "Notification_Approver_EndUser_Assignment",
            "notificationType": "Email",
            "recipientType": "Approver",
            "notificationLevel": "All",
            "isDefaultRecipientsEnabled": true,
            "notificationRecipients": [],
            "target": {
                "caller": "EndUser",
                "operations": [
                    "All"
                ],
                "level": "Assignment",
                "inheritableSettings": [],
                "enforcedSettings": []
            }
        }
    ]
}
```

