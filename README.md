# UnifiProtect-ClipSaver
Recently I found a need to save clips from time to time captured by my Ubiquiti UniFi Protect cameras, and going into the web interface or manually selecting the time & bounds of the clip worked, but was too time consuming and required a little too much precision to get things right.

After some traffic sniffing I came up with this basic service which demonstrates what it takes to specify a point to record from, how long, and from what cameras and automatically save a file of the video locally.

There is little error handling here, as this is intended to be mostly a demonstration.

Note: You will not be able to use a UniFi cloud account to access the Protect device, instead you’ll need a local account which does not require 2-factor authentication.

Other note: This has only been tested against a CloudKey Gen2 Plus. In theory this should also work against a Network Video Recorder or Network Video Recorder Pro. If you wanna send me one, I’d be happy to confirm 😉

