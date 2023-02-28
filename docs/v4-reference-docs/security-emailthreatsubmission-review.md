---
title: "emailThreatSubmission: review"
description: "Review a threat submission."
author: "caigen"
ms.localizationpriority: medium
ms.prod: "security"
doc_type: apiPageType
---

# emailThreatSubmission: review
Namespace: microsoft.graph.security

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Review a threat submission. Only [emailThreatSubmission](../resources/security-emailthreatsubmission.md) objects submitted by end users support the review action.

Review actions for [urlThreatSubmission](../resources/security-urlthreatsubmission.md) and [fileThreatSubmission](../resources/security-filethreatsubmission.md) objects are not supported for end user.

## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type|Permissions (from least to most privileged)|
|:---|:---|
|Delegated (work or school account)|ThreatSubmission.ReadWrite.All|
|Delegated (personal Microsoft account)|Not supported|
|Application|ThreatSubmission.ReadWrite.All|

## HTTP request

<!-- {
  "blockType": "ignored"
}
-->
``` http
POST /emailThreats/{emailThreatsId}/review
```

## Request headers
|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|
|Content-Type|application/json. Required.|

## Request body
In the request body, supply a JSON representation of the parameters.

The following table shows the parameters that can be used with this action.

|Parameter|Type|Description|
|:---|:---|:---|
|category|String|The email is being reported as notSpam, junk, phishing, malware. Case insensitive.|



## Response

If successful, this action returns a `204 No Content` response code.

## Examples

### Request
The following is an example of a request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "emailthreatsubmissionthis.review"
}
-->
``` http
POST https://graph.microsoft.com/beta/security/threatSubmission/emailThreats/49c5ef5b-1f65-444a-e6b9-08d772ea2059/review
Content-type: application/json

{
  "category": "phishing"
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var category = "phishing";

await graphClient.Security.ThreatSubmission.EmailThreats["{security.emailThreatSubmission-id}"]
	.Review(category)
	.Request()
	.PostAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response
The following is an example of the response.

<!-- {
  "blockType": "response",
  "truncated": true
}
-->
``` http
HTTP/1.1 204 No Content
```

