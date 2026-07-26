namespace ProxyPatternExample;
public class ProxyImage:IImage{
    private readonly string fileName;
    private RealImage? realImage;
    public ProxyImage(string fileName){this.fileName=fileName;}
    public void Display(){
        if(realImage==null) realImage=new RealImage(fileName);
        realImage.Display();
    }
}