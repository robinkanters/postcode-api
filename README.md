Postcode API for Windows
========================

Contents
--------
- License
- Purpose
- Usage
- Notes

License
-------
Postcode API for Windows
Copyright (C) 2015  Robin Kanters

This program is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation, either version 3 of the License, or
(at your option) any later version.

This program is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with this program.  If not, see <http://www.gnu.org/licenses/>.

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

The query results come back as a ```Postcode``` object, which has public Properties from which you can get the data. The structure is:
- Result (```Postcode```)
  - Street (```string```)
  - Town (```string```)
  - Municipality (```string```)
  - Postcode (```string```) (your query)
  - Longitude (```float```)
  - Latitude (```float```)
  - BAG Info (```BagInfo```)
    - Id (```string```)
    - Type (```string```)
    - Purpose (```string```)

Please note that all home numbers are in ```string``` format, becuase they can contain numbers and other characters.

It may seem tempting to cast the BAG ID to an ```int```. This is a bad idea, because [Kadaster](https://bagviewer.kadaster.nl/lvbag/bag-viewer/index.html)'s own API won't return results when there are leading zeroes missing.

Notes
-----
This API client uses the PostcodeAPI so generously provided for free by [Freshheads](http://www.freshheads.com/), a web design firm from Tilburg, NL. To apply for an API key, please visit the [Postcode API website](http://www.postcodeapi.nu/) and fill in the [request form](http://www.postcodeapi.nu/#request) at the bottom of the page.

This project is in no way affiliated with Freshheads or Postcode API, and is a standalone project.
