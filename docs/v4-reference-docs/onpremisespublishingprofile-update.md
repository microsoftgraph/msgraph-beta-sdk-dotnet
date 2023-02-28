---
title: "Update onPremisesPublishingProfile"
description: "Update the properties of an onPremisesPublishingProfile object."
ms.localizationpriority: medium
author: "japere"
ms.prod: "applications"
doc_type: "apiPageType"
---

# Update onPremisesPublishingProfile

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Update the properties of an [onPremisesPublishingProfile](../resources/onpremisespublishingprofile.md) object.

## Permissions

One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

| Permission type                        | Permissions (from least to most privileged) |
|:--------------------------------------|:---------------------------------------------------------|
| Delegated (work or school account)     | Directory.ReadWrite.All |
| Delegated (personal Microsoft account) | Not supported. |
| Application                            | Not supported. |

## HTTP request

<!-- { "blockType": "ignored" } -->

```http
PATCH ~/onPremisesPublishingProfiles/{publishingType}/hybridAgentUpdaterConfiguration
```

## Request headers

| Name       | Description|
|:-----------|:-----------|
| Authorization | Bearer {token} |

## Request body

In the request body, supply the values for relevant fields to update. Existing properties that are not included in the request body will maintain their previous values or be recalculated based on changes to other property values. For best performance, don't include existing values that haven't changed.

| Property     | Type        | Description |
|:-------------|:------------|:------------|
|hybridAgentUpdaterConfiguration|hybridAgentUpdaterConfiguration|Represents [hybridAgentUpdaterConfiguration](../resources/hybridagentupdaterconfiguration.md).|

## Response

If successful, this method returns a `204 No Content` response code.

## Examples

### Example 1: Update updateWindow in the hybridAgentUpdaterConfiguration

The following example updates the **updateWindow** in the **hybridAgentUpdaterConfiguration**.

#### Request

The following is an example of the request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "update_onpremisespublishingprofile_1"
}-->

```http
PATCH https://graph.microsoft.com/beta/onPremisesPublishingProfiles/provisioning/hybridAgentUpdaterConfiguration
Content-Type: application/json

{
   "updateWindow" :
{
      "updateWindowStartTime" : "0:00:00",
      "updateWindowEndTime" : "23:59:00"
  }
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var hybridAgentUpdaterConfiguration = new HybridAgentUpdaterConfiguration
{
	UpdateWindow = new UpdateWindow
	{
		UpdateWindowStartTime = new TimeOfDay(0, 0, 0),
		UpdateWindowEndTime = new TimeOfDay(23, 59, 0)
	}
};

var onPremisesPublishingProfiles = new OnPremisesPublishingProfile();
onPremisesPublishingProfiles.HybridAgentUpdaterConfiguration = hybridAgentUpdaterConfiguration;

await graphClient.OnPremisesPublishingProfiles["{onPremisesPublishingProfile-id}"]
	.Request()
	.UpdateAsync(onPremisesPublishingProfiles);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

#### Response

<!-- {
  "blockType": "response"
} -->

```http
HTTP/1.1 204 No Content
```

### Example 2: Update deferUpdate in the hybridAgentUpdaterConfiguration 

The following example updates **deferUpdate** in the **hybridAgentUpdaterConfiguration**.

#### Request

The following is an example of the request.


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "update_onpremisespublishingprofile_2"
}-->

```http
PATCH https://graph.microsoft.com/beta/onPremisesPublishingProfiles/provisioning/hybridAgentUpdaterConfiguration
Content-Type: application/json

{
    "deferUpdate" : "2018-08-20T12:00"
}
```

# [C#](#tab/csharp)
```
Snippet not available
```

 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

#### Response

<!-- {
  "blockType": "response"
} -->

```http
HTTP/1.1 204 No Content
```

### Example 3: Update allowUpdateConfigurationOverride in the hybridAgentUpdaterConfiguration

The following example updates **allowUpdateConfigurationOverride** in the **hybridAgentUpdaterConfiguration**.

#### Request

The following is an example of the request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "update_onpremisespublishingprofile_3"
}-->

```http
PATCH https://graph.microsoft.com/beta/onPremisesPublishingProfiles/provisioning/hybridAgentUpdaterConfiguration
Content-Type: application/json

{
    "allowUpdateConfigurationOverride" : false
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var hybridAgentUpdaterConfiguration = new HybridAgentUpdaterConfiguration
{
	AllowUpdateConfigurationOverride = false
};

var onPremisesPublishingProfiles = new OnPremisesPublishingProfile();
onPremisesPublishingProfiles.HybridAgentUpdaterConfiguration = hybridAgentUpdaterConfiguration;

await graphClient.OnPremisesPublishingProfiles["{onPremisesPublishingProfile-id}"]
	.Request()
	.UpdateAsync(onPremisesPublishingProfiles);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

#### Response

<!-- {
  "blockType": "response"
} -->

```http
HTTP/1.1 204 No Content
```

<!-- uuid: 8fcb5dbc-d5aa-4681-8e31-b001d5168d79
2015-10-25 14:57:30 UTC -->
<!-- {
  "type": "#page.annotation",
  "description": "Update onpremisespublishingprofile",
  "keywords": "",
  "section": "documentation",
  "tocPath": ""
}-->



