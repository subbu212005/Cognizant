using CommandPatternExample;
var light=new Light();
var remote=new RemoteControl();

remote.SetCommand(new LightOnCommand(light));
remote.PressButton();

remote.SetCommand(new LightOffCommand(light));
remote.PressButton();
