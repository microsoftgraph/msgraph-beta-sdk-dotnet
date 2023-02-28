---
title: "Update externalIdentitiesPolicy"
description: "Update the settings of the tenant-wide externalIdentitiesPolicy object that controls whether external users can leave an Azure AD tenant via self-service controls."
author: "KuiGithui"
ms.localizationpriority: medium
ms.prod: "identity-and-sign-in"
doc_type: apiPageType
---

# Update externalIdentitiesPolicy
Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Update the settings of the tenant-wide [externalIdentitiesPolicy](../resources/externalidentitiespolicy.md) object that controls whether external users can leave an Azure AD tenant via self-service controls.

## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type|Permissions (from least to most privileged)|
|:---|:---|
|Delegated (work or school account)|Policy.ReadWrite.ExternalIdentities|
|Delegated (personal Microsoft account)|Not supported.|
|Application|Policy.ReadWrite.ExternalIdentities|

## HTTP request

<!-- {
  "blockType": "ignored"
}
-->
``` http
PATCH /policies/externalIdentitiesPolicy
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
|allowDeletedIdentitiesDataRemoval|Boolean|<!--Notifies Azure AD whether to clean up the user information about the external identity, from the guest tenant, when the user is deleted in their home tenant. Required.-->**Reserved for future use.**|
|allowExternalIdentitiesToLeave|Boolean|Defines whether external users can leave the guest tenant. If set to `false`, self-service controls are disabled, and the admin of the guest tenant must manually remove the external user from the guest tenant. When the external user leaves the tenant, their data in the guest tenant is first soft-deleted then permanently deleted in 30 days. Required.|

## Response

If successful, this method returns a `204 No Content` response code. It does not return anything in the response body.

## Examples

### Request

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "update_externalidentitiespolicy"
}
-->
``` http
PATCH https://graph.microsoft.com/beta/policies/externalIdentitiesPolicy

{
  "allowExternalIdentitiesToLeave":false
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var externalIdentitiesPolicy = new ExternalIdentitiesPolicy
{
	AllowExternalIdentitiesToLeave = false
};

await graphClient.Policies.ExternalIdentitiesPolicy
	.Request()
	.UpdateAsync(externalIdentitiesPolicy);

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
``` http
HTTP/1.1 204 No Content
```

