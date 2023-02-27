---
title: "Create authenticationContextClassReference"
description: "Create a new authenticationContextClassReference."
ms.localizationpriority: medium
author: "bakerCaleb"
ms.prod: "identity-and-sign-in"
doc_type: apiPageType
---

# Create authenticationContextClassReference

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Create a new [authenticationContextClassReference](../resources/authenticationContextClassReference.md).

## Permissions

One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type                        | Permissions (from least to most privileged)                    |
|:--------------------------------------|:---------------------------------------------------------------|
|Delegated (work or school account)     | Policy.ReadWrite.ConditionalAccess |
|Delegated (personal Microsoft account) | Not supported. |
|Application                            | Policy.ReadWrite.ConditionalAccess |

> [!NOTE]
> This API has a [known issue](/graph/known-issues#permissions) related to permissions.

## HTTP request

<!-- { "blockType": "ignored" } -->

```http
POST /identity/conditionalAccess/authenticationContextClassReferences
```

## Request headers

| Name          | Description      |
|:--------------|:-----------------|
| Authorization | Bearer {token}. Required.   |
| Content-Type  | application/json. Required. |

## Request body

You can specify the following properties when creating an **authenticationContextClassReference**.

|Property|Type|Description|
|:---|:---|:---|
| id | String|Identifier used to reference the authentication context class. The id is used to trigger step-up authentication for the referenced authentication requirements and is the value that will be issued in the `acrs` claim of an access token. This value in the claim is used to verify that the required authentication context has been satisfied. The allowed values are `c1` through `c25`. Required.|
|displayName|String|A friendly name that identifies the authenticationContextClassReference object when building user-facing admin experiences. For example, a selection UX. Optional.|
|description|String|A short explanation of the policies that are enforced by authenticationContextClassReference. This value should be used to provide secondary text to describe the authentication context class reference when building user-facing admin experiences. For example, a selection UX. Optional.|
|isAvailable|Boolean|Indicates whether the authenticationContextClassReference has been published by the security admin and is ready for use by apps. When it is set to `false`, it should not be shown in admin UX experiences because the value is not currently available for selection. Optional.|

## Response

If successful, this method returns a `201 Created` response code and a new [authenticationContextClassReference](../resources/authenticationcontextclassreference.md) object in the response body.

## Examples

### Request
The following example shows creating a new authenticationcontextclassreference that is available for apps to use.




# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "create_authenticationcontextclassreference"
}-->

```http
POST https://graph.microsoft.com/beta/identity/conditionalAccess/authenticationContextClassReferences
Content-type: application/json

{
    "id": "c1",
    "displayName": "Contoso medium",
    "description": "Medium protection level defined for Contoso policy",
    "isAvailable": true
}

```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var authenticationContextClassReference = new AuthenticationContextClassReference
{
	Id = "c1",
	DisplayName = "Contoso medium",
	Description = "Medium protection level defined for Contoso policy",
	IsAvailable = true
};

await graphClient.Identity.ConditionalAccess.AuthenticationContextClassReferences
	.Request()
	.AddAsync(authenticationContextClassReference);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

#### Response

The following is an example of the response.
<!-- {
  "blockType": "response",
  "truncated": false,
  "@odata.type": "microsoft.graph.authenticationContextClassReference"
} -->

```http
HTTP/1.1 201 Created
Content-Type: application/json

{
    "@odata.context": "https://graph.microsoft.com/beta/$metadata#conditionalAccess/authenticationContextClassReference/$entity",
    "id": "c1",
    "displayName": "Contoso medium",
    "description": "Medium protection level defined for Contoso policy",
    "isAvailable": true
}

```

<!-- uuid: 16cd6b66-4b1a-43a1-adaf-3a886856ed98
2019-02-04 14:57:30 UTC -->
<!-- {
  "type": "#page.annotation",
  "description": "Create authenticationContextClassReference",
  "keywords": "",
  "section": "documentation",
  "tocPath": ""
}-->
