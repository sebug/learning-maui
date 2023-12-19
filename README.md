# Learning MAUI
Now that I have read up on interacting with the Android, iOS APIs, I want
to actually integrate that stuff with MAUI. And to not pollute the work project,
I shall write a few sample projects here.

First, getting the necessary components:

       sudo dotnet workload install maui
       sudo dotnet workload install ios macos wasm-tools

Also I'll be developing on the mac so I need to [set up Visual Studio Code for MAUI development](https://learn.microsoft.com/en-us/dotnet/maui/get-started/installation?view=net-maui-8.0&tabs=visual-studio-code)

On the first project we'll also have to install the Android SDK files - I did it with Android Studio. Note that while you find the SDK tools etc. in the UI of the SDK manager, to get the emulator of version 34 you'll see the options when creating a new virtual device.


   