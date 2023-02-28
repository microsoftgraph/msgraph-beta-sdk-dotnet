---
title: "Create userSource"
description: "Create a new userSource object."
author: "SeunginLyu"
ms.localizationpriority: medium
ms.prod: "ediscovery"
doc_type: apiPageType
---

# Create userSource
Namespace: microsoft.graph.security

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Create a new userSource object.

## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type|Permissions (from least to most privileged)|
|:---|:---|
|Delegated (work or school account)|eDiscovery.Read.All, eDiscovery.ReadWrite.All|
|Delegated (personal Microsoft account)|Not supported.|
|Application|Not supported.|

## HTTP request

<!-- {
  "blockType": "ignored"
}
-->
``` http
POST /security/cases/ediscoveryCases/{ediscoveryCaseId}/legalHolds/{ediscoveryHoldPolicyId}/userSources
```

## Request headers
|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|
|Content-Type|application/json. Required.|

## Request body
In the request body, supply a JSON representation of the [userSource](../resources/security-usersource.md) object.

You can specify the following properties when you create a **userSource**.

|Property|Type|Description|
|:---|:---|:---|
|email|String|SMTP address of the user.|
|includedSources|microsoft.graph.security.sourceType|Specifies which sources are included in this group. Possible values are: `mailbox`, `site`.|


## Response

If successful, this method returns a `201 Created` response code and a [microsoft.graph.security.userSource](../resources/security-usersource.md) object in the response body.

## Examples

### Request
The following is an example of a request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "create_usersource_and_include_sources"
}
-->
``` http
POST https://graph.microsoft.com/beta/security/cases/ediscoveryCases/{ediscoveryCaseId}/legalHolds/{ediscoveryHoldPolicyId}/userSources
Content-Type: application/json

{
    "email": "admin@M365x809305.onmicrosoft.com",
    "includedSources": "mailbox, site"
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var userSource = new Microsoft.Graph.Security.UserSource
{
	Email = "admin@M365x809305.onmicrosoft.com",
	IncludedSources = Microsoft.Graph.Security.SourceType.Mailbox | Microsoft.Graph.Security.SourceType.Site
};

await graphClient.Security.Cases.EdiscoveryCases["{security.ediscoveryCase-id}"].LegalHolds["{security.ediscoveryHoldPolicy-id}"].UserSources
	.Request()
	.AddAsync(userSource);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response
The following is an example of the response.
>**Note:** The response object shown here might be shortened for readability.
<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "microsoft.graph.security.userSource"
}
-->
``` http
HTTP/1.1 201 Created
Content-Type: application/json

{
    "@odata.context": "https://graph.microsoft.com/beta/$metadata#security/cases/ediscoveryCases('b0073e4e-4184-41c6-9eb7-8c8cc3e2288b')/legalHolds('0053a61a3b6c42738f7606791716a22a')/userSources/$entity",
    "displayName": "MOD Administrator",
    "createdDateTime": "0001-01-01T00:00:00Z",
    "holdStatus": "applied",
    "id": "c25c3914-f9f7-43ee-9cba-a25377e0cec6",
    "email": "admin@M365x809305.onmicrosoft.com",
    "includedSources": "mailbox,site",
    "siteWebUrl": "",
    "createdBy": {
        "user": {
            "id": "c25c3914-f9f7-43ee-9cba-a25377e0cec6",
            "displayName": "MOD Administrator",
            "userPrincipalName": "admin@M365x809305.onmicrosoft.com"
        },
        "application": {
            "id": "de8bc8b5-d9f9-48b1-a8ad-b748da725064",
            "displayName": "Graph Explorer"
        }
    }
}
```

