# BlazorPutAndSignalR
•	Issue: I cannot fire update from Blazor Client to API I get this error:
    o	Reason: CORS header ‘Access-Control-Allow-Origin’ header is present….
    o	I have used this API from previous Asp.Net Core apps and never received this error. Seems to be somehow associated to Blazor/Webassembly is my guess. I have looked at Microsoft on CORS and I don’t seem to be able to find anything to correct it. I am sure I have something basic setup wrong.
    o	To resolve I have opted to call a method on a server controller that calls the API GET routine and that works. However I have not been able to figure out the syntax to call the controller with a PUT request.
•	Question: How do I send signalr messages only to users viewing the same records? I’ve never done this and am a bit puzzled on how to do this.
