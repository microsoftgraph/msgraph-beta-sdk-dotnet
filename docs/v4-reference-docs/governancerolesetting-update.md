---
title: "Update governanceRoleSetting"
description: "Update the properties of governanceRoleSetting."
ms.localizationpriority: medium
doc_type: apiPageType
ms.prod: "governance"
author: "rkarim-ms"
---

# Update governanceRoleSetting

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

>[!CAUTION]
>This version of the Privileged Identity Management (PIM) API for Azure resources will be deprecated soon. Please use the new [Azure REST PIM API for Azure resource roles](/graph/api/resources/privilegedidentitymanagement-root#migrate-from-pim-v2-to-pim-v3-apis).

Update the properties of [governanceRoleSetting](../resources/governancerolesetting.md).

## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference#privileged-access-permissions).

>**Note:** This API also requires that the requester have at least one `Active` administrator role assignment (`owner` or `user access administrator`) on the resource.

|Permission type      | Permissions              |
|:--------------------|:---------------------------------------------------------|
|Delegated (work or school account) | PrivilegedAccess.ReadWrite.AzureResources  |
|Delegated (personal Microsoft account) | Not supported.    |
|Application | Not supported. |
### Azure resources

| Permission type | Permissions |
|:--------------- |:----------- |
| Delegated (work or school account) | PrivilegedAccess.ReadWrite.AzureResources |
| Delegated (personal Microsoft account) | Not supported. |
| Application | Not supported. |

### Azure AD

| Permission type | Permissions |
|:--------------- |:----------- |
| Delegated (work or school account) | PrivilegedAccess.ReadWrite.AzureAD |
| Delegated (personal Microsoft account) | Not supported. |
| Application | Not supported. |

### Groups

|Permission type | Permissions |
|:-------------- |:----------- |
| Delegated (work or school account) | PrivilegedAccess.ReadWrite.AzureADGroup |
| Delegated (personal Microsoft account) | Not supported. |
| Application | Not supported. |

## HTTP request
<!-- { "blockType": "ignored" } -->
```http
PATCH /privilegedAccess/azureResources/roleSettings/{id}
```
## Request headers
| Name       | Description|
|:-----------|:-----------|
| Authorization  | Bearer {token}|
| Content-type  | application/json|


## Request body
In the request body, supply the values for [governanceRuleSettings](../resources/governancerulesetting.md) that need to be updated. 

| Property	   | Type	|Description|
|:---------------|:--------|:----------|
|adminEligibleSettings|[governanceRuleSetting](../resources/governancerulesetting.md) collection|The rule settings that are evaluated when an administrator tries to add an eligible role assignment.|
|adminMemberSettings|[governanceRuleSetting](../resources/governancerulesetting.md) collection|The rule settings that are evaluated when an administrator tries to add a direct member role assignment.|
|userEligibleSettings|[governanceRuleSetting](../resources/governancerulesetting.md) collection|The rule settings that are evaluated when a user tries to add an eligible role assignment. |
|userMemberSettings|[governanceRuleSetting](../resources/governancerulesetting.md) collection|The rule settings that are evaluated when a user tries to activate his role assignment.|

## Response
If successful, this method returns a `204 NoContent` response code. It does not return anything in the response body. 

### Error codes
This API returns the standard HTTP error codes. In addition, it returns the following custom error codes.

|Error code     | Error message         | Details             |
|:--------------| :---------------------|:--------------------|
| 400 BadRequest| RoleSettingNotFound   | The [governanceRoleSetting](../resources/governancerolesetting.md) does not exist in system.
| 400 BadRequest| InvalidRoleSetting    | The [governanceRuleSettings](../resources/governancerulesetting.md) values provided in the request body are not valid.

## Example 
This example updates the role setting for Custom Role 3 in the subscription Wingtip Toys - Prod.
##### Request

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "update_governancerolesetting"
}-->
```http
PATCH https://graph.microsoft.com/beta/privilegedAccess/azureResources/roleSettings/5fb5aef8-1081-4b8e-bb16-9d5d0385bab5
Content-type: application/json

{
   "adminEligibleSettings":[
      {
         "ruleIdentifier":"ExpirationRule",
         "setting":"{\"permanentAssignment\":false,\"maximumGrantPeriodInMinutes\":129600}"
      }
   ]
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var governanceRoleSetting = new GovernanceRoleSetting
{
	AdminEligibleSettings = new List<GovernanceRuleSetting>()
	{
		new GovernanceRuleSetting
		{
			RuleIdentifier = "ExpirationRule",
			Setting = "{\"permanentAssignment\":false,\"maximumGrantPeriodInMinutes\":129600}"
		}
	}
};

await graphClient.PrivilegedAccess["{privilegedAccess-id}"].RoleSettings["{governanceRoleSetting-id}"]
	.Request()
	.UpdateAsync(governanceRoleSetting);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

