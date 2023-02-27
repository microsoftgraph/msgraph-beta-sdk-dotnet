---
title: "Update entitlementManagementSettings"
description: "Update a entitlementManagementSettings object to change one or more of its properties."
ms.localizationpriority: medium
author: "markwahl-msft"
ms.prod: "governance"
doc_type: apiPageType
---

# Update entitlementManagementSettings

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Update an existing [entitlementManagementSettings](../resources/entitlementmanagementsettings.md) object to change one or more of its properties.


## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type                        | Permissions (from least to most privileged)              |
|:--------------------------------------|:---------------------------------------------------------|
|Delegated (work or school account)     | EntitlementManagement.ReadWrite.All |
|Delegated (personal Microsoft account) | Not supported. |
|Application                            | EntitlementManagement.ReadWrite.All |

## HTTP request
<!-- { "blockType": "ignored" } -->
```http
PATCH /identityGovernance/entitlementManagement/settings
```
## Request headers
| Name         | Description |
|:-------------|:------------|
| Authorization | Bearer \{token\}. Required. |
| Content-Type  | application/json. Required. |

## Request body
In the request body, supply a JSON representation of the parameters of an [entitlementManagementSettings](../resources/entitlementmanagementsettings.md) object.

## Response
If successful, this method returns a `204 No Content` response code.

## Example

### Request


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "update_entitlementManagementSettings"
}-->
```http
PATCH https://graph.microsoft.com/beta/identityGovernance/entitlementManagement/settings
Content-type: application/json

{
  "externalUserLifecycleAction": "None"
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var entitlementManagementSettings = new EntitlementManagementSettings
{
	ExternalUserLifecycleAction = "None"
};

await graphClient.IdentityGovernance.EntitlementManagement.Settings
	.Request()
	.UpdateAsync(entitlementManagementSettings);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response

<!-- {
  "blockType": "response"
} -->
```http
HTTP/1.1 204 No Content
```

<!--
{
  "type": "#page.annotation",
  "description": "Update entitlementManagementSettings",
  "keywords": "",
  "section": "documentation",
  "tocPath": "",
  "suppressions": [
  ]
}
-->


