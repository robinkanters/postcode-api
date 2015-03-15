Postcode API for C#
===================

Contents
--------
- Purpose
- Usage
- Notes

Purpose
-------
The purpose of the project is to create an easy interface for postal code (postcode in Dutch) information retrieval. It does so by supplying a Windows library (dll) that you can reference in your own Windows desktop applications.

Usage
-----
The usage of this library is fairly simple. Start by instantiating a PostcodeApiClient object.
```C#
string apiKey = "YOUR_API_KEY_HERE";
PostcodeApiClient client = new PostcodeApiClient(apiKey);
```

Then, you can ask it information about a postcode or postcode/home number combination:
```C#
Postcode result = client.GetPostcodeInformation("5041EB");
// Or:
Postcode result = client.GetAddressInformation("5041EB", "21");
```

Please note that all home numbers are in ```string``` format, becuase they can contain numbers and other characters.

Notes
-----
This API client uses the PostcodeAPI so generously provided for free by [Freshheads](http://www.freshheads.com/), a web design firm from Tilburg, NL. To apply for an API key, please visit the [Postcode API website](http://www.postcodeapi.nu/) and fill in the [request form](http://www.postcodeapi.nu/#request) at the bottom of the page.

This project is in no way affiliated with Freshheads or Postcode API, and is a standalone project.
