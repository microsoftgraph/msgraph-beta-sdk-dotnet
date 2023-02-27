---
title: "Update secureScoreControlProfiles"
description: "Update an editable secureScoreControlProfiles property within any integrated solution to change various properties, such as assignedTo or tenantNote."
ms.localizationpriority: medium
doc_type: apiPageType
ms.prod: security
author: "preetikr"
---

# Update secureScoreControlProfiles

Namespace: microsoft.graph

 [!INCLUDE [beta-disclaimer](../../includes/beta-disclaimer.md)]

Update an editable **secureScoreControlProfiles** property within any integrated solution to change various properties, such as **assignedTo** or **tenantNote**.

## Permissions

One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type      | Permissions (from least to most privileged)              |
|:--------------------|:---------------------------------------------------------|
|Delegated (work or school account) |   SecurityEvents.ReadWrite.All  |
|Delegated (personal Microsoft account) |  Not supported.  |
|Application | SecurityEvents.ReadWrite.All |

## HTTP request

<!-- { "blockType": "ignored" } -->

```http
PATCH /security/secureScoreControlProfiles/{id}
```

## Request headers

| Name       | Description|
|:-----------|:-----------|
| Authorization  | Bearer {code}. Required.|
|Prefer | return=representation. |

## Request body

In the request body, supply a JSON representation of the values for relevant fields that should be updated. The following table lists the fields that can be updated for a secureScoreControlProfile. The values for existing properties that are not included in the request body will not change. For best performance, don't include existing values that haven't changed.

| Property   | Type |Description|
|:---------------|:--------|:----------|
|assignedTo|String|Name of the analyst the control is assigned to for triage, implementation, or remediation.|
|tenantNote|String|Analyst comments on the control (for customer control management).|
|controlStateUpdates| String|Analyst driven setting on the control. Possible values are: `ignore`, `thirdParty`, `reviewed`.|


## Response

If successful, this method returns a `204 No Content` response code.

If the optional request header is used, the method returns a `200 OK` response code and the updated [secureScoreControlProfiles](../resources/securescorecontrolprofiles.md) object in the response body.

## Example

### Request

The following is an example of the request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "securescorecontrolprofiles_update",
  "sampleKeys": ["AdminMFA"]
}-->

```http
PATCH https://graph.microsoft.com/beta/security/secureScoreControlProfiles/AdminMFA
Content-type: application/json

{
  "controlStateUpdates": "controlStateUpdates-value"
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var secureScoreControlProfile = new SecureScoreControlProfile
{
	ControlStateUpdates = "controlStateUpdates-value"
};

await graphClient.Security.SecureScoreControlProfiles["{secureScoreControlProfile-id}"]
	.Request()
	.UpdateAsync(secureScoreControlProfile);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response

The following is an example of a successful response.
<!-- {
  "blockType": "response"
} -->

```http
HTTP/1.1 204 No Content
```




<!--
{
  "type": "#page.annotation",
  "description": "Update secureScoreControlProfiles",
  "keywords": "",
  "section": "documentation",
  "tocPath": "",
  "suppressions": [
  ]
}
-->


