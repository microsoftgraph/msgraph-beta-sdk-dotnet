---
title: "Delete trustFrameworkPolicy"
description: "This operation deletes an existing trustFrameworkPolicy object from an Azure AD B2C tenant."  
ms.localizationpriority: medium
author: "Nickgmicrosoft"
ms.prod: "identity-and-sign-in"
doc_type: apiPageType
---
# Delete trustFrameworkPolicy

Namespace: microsoft.graph

> **Important:** APIs under the /beta version in Microsoft Graph are in preview and are subject to change. Use of these APIs in production applications is not supported.

Delete an existing [trustFrameworkPolicy](../resources/trustframeworkpolicy.md).

## Permissions

One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type      | Permissions (from least to most privileged)              |
|:--------------------|:---------------------------------------------------------|
|Delegated (work or school account)|Policy.ReadWrite.TrustFramework|
|Delegated (personal Microsoft account)| Not supported.|
|Application|Policy.ReadWrite.TrustFramework|

The work or school account must be a global administrator of the tenant.

## HTTP request

<!-- { "blockType": "ignored" } -->
```http
DELETE /trustFramework/policies/{id}
```

## Request headers

|Name|Description|
|:---------------|:----------|
|Authorization|Bearer {token}. Required.|

## Request body

Do not supply a request body for this method.

## Response

If successful, this method returns a `204 No Content` response code.

## Example

The following example deletes a **trustFrameworkPolicy**.

##### Request


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "delete_trustFrameworkPolicy",
  "sampleKeys": ["B2C_1A_SocialAndLocalAccounts_Base"]
}-->
```http
DELETE https://graph.microsoft.com/beta/trustFramework/policies/B2C_1A_SocialAndLocalAccounts_Base
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

await graphClient.TrustFramework.Policies["{trustFrameworkPolicy-id}"]
	.Request()
	.DeleteAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

