---
title: "List trustFrameworkPolicies"
description: "This operation lists all trustFrameworkPolicy objects in an Azure AD B2C tenant."
ms.localizationpriority: medium
author: "Nickgmicrosoft"
ms.prod: "identity-and-sign-in"
doc_type: apiPageType
---
# List trustFrameworkPolicies

Namespace: microsoft.graph

> **Important:** APIs under the /beta version in Microsoft Graph are in preview and are subject to change. Use of these APIs in production applications is not supported.

Retrieve a list of [trustFrameworkPolicies](../resources/trustframeworkpolicy.md) in the tenant/directory.

## Permissions

One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type      | Permissions (from least to most privileged)              |
|:--------------------|:---------------------------------------------------------|
|Delegated (work or school account)|Policy.Read.All, Policy.ReadWrite.TrustFramework|
|Delegated (personal Microsoft account)| Not supported.|
|Application|Policy.Read.All, Policy.ReadWrite.TrustFramework|

The work or school account must be a global administrator of the tenant.

## HTTP request

<!-- { "blockType": "ignored" } -->
```http
GET /trustFramework/policies/
```
## Optional query parameters

This method supports the `$select` and `$expand` [OData query parameters](/graph/query-parameters) to help customize the response.

## Request headers

|Name|Description|
|:---------------|:----------|
|Authorization|Bearer {token}. Required.|

## Request body

Do not supply a request body for this method.

## Response

If successful, this method returns a `200 OK` response code and a collection of [trustFrameworkPolicy](../resources/trustframeworkpolicy.md) objects in a JSON representation in the response body.

## Example

The following example retrieves all **trustFrameworkPolicies**.

##### Request


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "get_trustFrameworks"
}-->
```msgraph-interactive
GET https://graph.microsoft.com/beta/trustFramework/policies
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var policies = await graphClient.TrustFramework.Policies
	.Request()
	.GetAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

