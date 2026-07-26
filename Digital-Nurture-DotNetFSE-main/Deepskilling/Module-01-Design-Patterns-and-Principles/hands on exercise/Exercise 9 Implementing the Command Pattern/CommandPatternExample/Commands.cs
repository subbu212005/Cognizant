namespace CommandPatternExample;
public class LightOnCommand:ICommand{
 private readonly Light light;
 public LightOnCommand(Light l){light=l;}
 public void Execute()=>light.On();
}
public class LightOffCommand:ICommand{
 private readonly Light light;
 public LightOffCommand(Light l){light=l;}
 public void Execute()=>light.Off();
}