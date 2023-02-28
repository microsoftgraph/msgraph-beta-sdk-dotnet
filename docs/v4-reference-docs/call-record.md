---
title: "call: recordResponse"
description: "Record a short audio response from the caller. This is useful if the bot wants to capture a voice response from the caller following a prompt."
author: "mkhribech"
ms.localizationpriority: medium
ms.prod: "cloud-communications"
doc_type: apiPageType
---

# call: recordResponse

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Record a short audio response from the caller.

A bot can use this to capture a voice response from a caller after they are prompted for a response.

For more information about how to handle operations, see [commsOperation](../resources/commsOperation.md)

>**Note:** This API is only supported for [calls](../resources/call.md) that are initiated with [serviceHostedMediaConfig](../resources/servicehostedmediaconfig.md).

This action is not intended to record the entire call. The maximum length of recording is 2 minutes. The recording is not saved permanently by the by the Cloud Communications Platform and is discarded shortly after the call ends. The bot must download the recording promptly after the recording operation finishes by using the recordingLocation value that's given in the completed notification.

>**Note:** You may not record or otherwise persist media content from calls or meetings that your application accesses, or data derived from that media content. Make sure you are compliant with the laws and regulations of your area regarding data protection and confidentiality of communications. Please see the [Terms of Use](/legal/microsoft-apis/terms-of-use) and consult with your legal counsel for more information.

## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

| Permission type | Permissions (from least to most privileged) |
| :-------------- | :------------------------------------------ |
| Delegated (work or school account)     | Not Supported        |
| Delegated (personal Microsoft account) | Not Supported        |
| Application     | Calls.AccessMedia.All                       |

## HTTP request
<!-- { "blockType": "ignored" } -->
```http
POST /app/calls/{id}/recordResponse
POST /communications/calls/{id}/recordResponse
```
> **Note:** The `/app` path is deprecated. Going forward, use the `/communications` path.

## Request headers
| Name          | Description               |
|:--------------|:--------------------------|
| Authorization | Bearer {token}. Required. |
| Content-type| application/json. Required. |

## Request body
In the request body, provide a JSON object with the following parameters.

| Parameter      | Type    |Description|
|:---------------|:--------|:----------|
|prompts|[MediaPrompt](../resources/mediaprompt.md) collection | The prompts to be played. The maximum supported mediaPrompt collection size is 1.|
|bargeInAllowed|Boolean| If true, the recordResponse request will barge into other existing queued-up/currently-processing record/playprompt requests. Default = false. |
|initialSilenceTimeoutInSeconds | Int32| Maximum initial silence (user silence) allowed from the time we start the record response operation before we timeout and fail the operation. If we are playing a prompt, then this timer starts after prompt finishes. Default = 5 seconds, Min = 1 second, Max = 120 seconds |
|maxSilenceTimeoutInSeconds|Int32| Maximum silence (pause) time allowed after a user has started speaking. Default = 5 seconds, Min = 1 second, Max = 120 seconds.|
|maxRecordDurationInSeconds|Int32| Max duration for the recordResponse operation before stopping recording. Default = 5 seconds, Min = 1 second, Max = 120 seconds.|
|playBeep|Boolean| If true, plays a beep to indicate to the user that they can start recording their message. Default = true.|
|stopTones|String collection|Stop tones specified to end recording.|
|clientContext|String|Unique Client Context string. Max limit is 256 chars.|

> **Note:** The maximum recording time has been reduced from 5 minutes to 2 minutes.

## Response
This method returns a `200 OK` HTTP response code and a Location header with a URI to the [recordOperation](../resources/recordoperation.md) created for this request.

## Example
The following example shows how to call this API.

### Example 1: Records a short audio response from the caller

##### Request
The following example shows the request.


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "call-recordResponse"
}-->
```http
POST https://graph.microsoft.com/beta/communications/calls/{id}/recordResponse
Content-Type: application/json
Content-Length: 394

{
  "bargeInAllowed": true,
  "clientContext": "d45324c1-fcb5-430a-902c-f20af696537c",
  "prompts": [
    {
      "@odata.type": "#microsoft.graph.mediaPrompt",
      "mediaInfo": {
        "uri": "https://cdn.contoso.com/beep.wav",
        "resourceId": "1D6DE2D4-CD51-4309-8DAA-70768651088E"
      }
    }
  ],
  "maxRecordDurationInSeconds": 10,
  "initialSilenceTimeoutInSeconds": 5,
  "maxSilenceTimeoutInSeconds": 2,
  "playBeep": true,
  "stopTones": [ "#", "1", "*" ]
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var bargeInAllowed = true;

var clientContext = "d45324c1-fcb5-430a-902c-f20af696537c";

var prompts = new List<Prompt>()
{
	new MediaPrompt
	{
		MediaInfo = new MediaInfo
		{
			Uri = "https://cdn.contoso.com/beep.wav",
			ResourceId = "1D6DE2D4-CD51-4309-8DAA-70768651088E"
		}
	}
};

var maxRecordDurationInSeconds = 10;

var initialSilenceTimeoutInSeconds = 5;

var maxSilenceTimeoutInSeconds = 2;

var playBeep = true;

var stopTones = new List<String>()
{
	"#",
	"1",
	"*"
};

await graphClient.Communications.Calls["{call-id}"]
	.RecordResponse(prompts,bargeInAllowed,initialSilenceTimeoutInSeconds,maxSilenceTimeoutInSeconds,maxRecordDurationInSeconds,playBeep,null,stopTones,clientContext)
	.Request()
	.PostAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

