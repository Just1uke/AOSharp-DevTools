# AOSharp DevTools

A collection of helpful resources for developing AOSharp plugins.

### Note

Plugins and development should only take place on [TestLive](https://forums.funcom.com/t/welcome-to-testlive/6433). Use at your own risk.

### Screenshots

Main contronl panel.

![Main tool window](images/main_window.png)

Enumerate various constants, such as UI graphics.

![Enumerate graphics](images/graphics_enumerator.png)


Run functions from various DLLs.

![Launch functions from various modules](images/modules.png)


Toggle event handling on and off. In this example, print inbound and outbound packets to chat.

![Turn event monitoring on and off](images/events_window.png)

### Known Issues

* It's currently possible to exceed the max value set on enumerator views. This is caused by not being able to dynamically change the max_value attribute of Slider UI elements. Pretty sure I had this figured out at one point, but then made the mistake of sleeping.

