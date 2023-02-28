---
title: "Get governanceRoleSetting"
description: "Retrieve the properties and relationships of a governanceRoleSetting."
ms.localizationpriority: medium
doc_type: apiPageType
ms.prod: "governance"
author: "rkarim-ms"
--- 

# Get governanceRoleSetting

Namespace: microsoft.graph


> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

>[!CAUTION]
>This version of the Privileged Identity Management (PIM) API for Azure resources will be deprecated soon. Please use the new [Azure REST PIM API for Azure resource roles](/graph/api/resources/privilegedidentitymanagement-root#migrate-from-pim-v2-to-pim-v3-apis).

Retrieve the properties and relationships of a [governanceRoleSetting](../resources/governancerolesetting.md).

## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference#privileged-access-permissions).

### Azure resources

| Permission type | Permissions |
|:--------------- |:----------- |
| Delegated (work or school account) | PrivilegedAccess.ReadWrite.AzureResources |
| Delegated (personal Microsoft account) | Not supported. |
| Application | PrivilegedAccess.Read.AzureResources |

### Azure AD

| Permission type | Permissions |
|:--------------- |:----------- |
| Delegated (work or school account) | PrivilegedAccess.ReadWrite.AzureAD |
| Delegated (personal Microsoft account) | Not supported. |
| Application | PrivilegedAccess.Read.AzureAD |

### Groups

|Permission type | Permissions |
|:-------------- |:----------- |
| Delegated (work or school account) | PrivilegedAccess.ReadWrite.AzureADGroup |
| Delegated (personal Microsoft account) | Not supported. |
| Application | PrivilegedAccess.Read.AzureADGroup |

Besides the permission scope, this API requires the requestor to have at least one role assignment on the resource, which the [governanceRoleSetting](../resources/governancerolesetting.md) belongs to.
## HTTP request
<!-- { "blockType": "ignored" } -->
```http
GET /privilegedAccess/azureResources/roleSettings/{id}
```
## Optional query parameters
This method supports the [OData Query Parameters](/graph/query-parameters) to help customize the response.

## Request headers
| Name      |Description|
|:----------|:----------|
| Authorization  | Bearer {code}|

## Request body
Do not supply a request body for this method.
## Response
If successful, this method returns a `200 OK` response code and a [governanceRoleSetting](../resources/governancerolesetting.md) object in the response body.
## Example
##### Request

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "get_governancerolesetting"
}-->
```msgraph-interactive
GET https://graph.microsoft.com/beta/privilegedAccess/azureResources/roleSettings/80dc5d6f-8d89-47b3-953f-01dc909ed3f9
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var governanceRoleSetting = await graphClient.PrivilegedAccess["{privilegedAccess-id}"].RoleSettings["{governanceRoleSetting-id}"]
	.Request()
	.GetAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

