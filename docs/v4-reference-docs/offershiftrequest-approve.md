---
title: "offerShiftRequest: approve"
description: "Approve an offershiftrequest object."
ms.localizationpriority: medium
author: "akumar39"
ms.prod: "microsoft-teams"
doc_type: "apiPageType"
---

# offerShiftRequest: approve

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Approve an [offershiftrequest](../resources/offershiftrequest.md) object.

## Permissions

One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

| Permission type                        | Permissions (from least to most privileged) |
|:---------------------------------------|:--------------------------------------------|
| Delegated (work or school account)     | Schedule.ReadWrite.All, Group.ReadWrite.All |
| Delegated (personal Microsoft account) | Not supported. |
| Application                            | Schedule.ReadWrite.All |

## HTTP request

<!-- { "blockType": "ignored" } -->

```http
POST /teams/{teamId}/schedule/offerShiftRequests/{offerShiftRequestId}/approve
```

## Request headers

| Name          | Description   |
|:--------------|:--------------|
| Authorization | Bearer {token}. Required. |
| Content-type | application/json. Required. |

## Request body

In the request body, provide a JSON object with the following parameters.

| Parameter    | Type        | Description |
|:-------------|:------------|:------------|
|message|String|Custom message sent on approval.|

## Response

If successful, this method returns a `200 OK` response code. It does not return anything in the response body.

## Examples

### Request

The following example shows a request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "offershiftrequest_approve"
}-->

```http
POST https://graph.microsoft.com/beta/teams/{teamId}/schedule/offerShiftRequests/{offerShiftRequestId}/approve
Content-type: application/json

{
  "message": "Approved!"
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var message = "Approved!";

await graphClient.Teams["{team-id}"].Schedule.OfferShiftRequests["{offerShiftRequest-id}"]
	.Approve(message)
	.Request()
	.PostAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response

The following example shows the response.
<!-- {
  "blockType": "response"
} -->

```http
HTTP/1.1 200 OK
```

<!-- uuid: 16cd6b66-4b1a-43a1-adaf-3a886856ed98
2019-02-04 14:57:30 UTC -->
<!-- {
  "type": "#page.annotation",
  "description": "offerShiftRequest: approve",
  "keywords": "",
  "section": "documentation",
  "tocPath": ""
}-->


