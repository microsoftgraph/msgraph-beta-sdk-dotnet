---
title: "Delete federatedIdentityCredential"
description: "Deletes a federatedIdentityCredential object."
author: "shahzad-khalid"
ms.localizationpriority: medium
ms.prod: "applications"
doc_type: apiPageType
---

# Delete federatedIdentityCredential
Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Deletes a [federatedIdentityCredential](../resources/federatedidentitycredential.md) object from an application.

## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type      | Permissions (from least to most privileged)              |
|:--------------------|:---------------------------------------------------------|
|Delegated (work or school account) | Application.ReadWrite.All    |
|Delegated (personal Microsoft account) |  Application.ReadWrite.All |
|Application | Application.ReadWrite.OwnedBy, Application.ReadWrite.All |

## HTTP request

You can address the application using either its **id** or **appId**. **id** and **appId** are referred to as the **Object ID** and **Application (Client) ID**, respectively, in the Azure portal.

You can also address the federated identity credential with either its **id** or **name**.
<!-- { "blockType": "ignored" } -->
```http
DELETE /applications/{id}/federatedIdentityCredentials/{federatedIdentityCredentialId}

DELETE /applications/{id}/federatedIdentityCredentials/{federatedIdentityCredentialName}

DELETE /applications(appId='{appId}')/federatedIdentityCredentials/{federatedIdentityCredentialId}

DELETE /applications(appId='{appId}')/federatedIdentityCredentials/{federatedIdentityCredentialName}
```

## Request headers
|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|

## Request body
Do not supply a request body for this method.

## Response

If successful, this method returns a `204 No Content` response code.

## Examples

### Request

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "delete_federatedidentitycredential"
}
-->
``` http
DELETE https://graph.microsoft.com/beta/applications/bcd7c908-1c4d-4d48-93ee-ff38349a75c8/federatedIdentityCredentials/d9b7bf1e-429e-4678-8132-9b00c9846cc4
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

await graphClient.Applications["{application-id}"].FederatedIdentityCredentials["{federatedIdentityCredential-id}"]
	.Request()
	.DeleteAsync();

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

