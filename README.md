# AOSharp DevTools

A collection of helpful resources for developing AOSharp plugins.

### Screenshots

![Main tool window](images/main_window.png)

Main contronl panel.

![Enumerate graphics](images/graphics_enumerator.png)

Enumerate various constants, such as UI graphics.

![Launch functions from various modules](images/modules.png)

Run functions from various DLLs.

![Turn event monitoring on and off](images/events_window.png)

Toggle event handling on and off. In this example, print inbound and outbound packets to chat.

### Known Issues

* It's currently possible to exceed the max value set on enumerator views. This is caused by not being able to dynamically change the max_value attribute of Slider UI elements. Pretty sure I had this figured out at one point, but then made the mistake of sleeping.

