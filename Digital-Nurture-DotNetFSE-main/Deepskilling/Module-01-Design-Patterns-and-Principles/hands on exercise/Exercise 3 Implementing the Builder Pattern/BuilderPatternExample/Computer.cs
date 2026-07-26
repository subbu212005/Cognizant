namespace BuilderPatternExample;
public class Computer
{
    public string CPU {get;}
    public int RAM {get;}
    public int Storage {get;}
    public string GPU {get;}
    private Computer(Builder b){CPU=b.CPU;RAM=b.RAM;Storage=b.Storage;GPU=b.GPU;}
    public override string ToString()=>$"CPU: {CPU}, RAM: {RAM}GB, Storage: {Storage}GB, GPU: {GPU}";
    public class Builder{
        public string CPU=""; public int RAM; public int Storage; public string GPU="Integrated";
        public Builder SetCPU(string cpu){CPU=cpu;return this;}
        public Builder SetRAM(int ram){RAM=ram;return this;}
        public Builder SetStorage(int s){Storage=s;return this;}
        public Builder SetGPU(string g){GPU=g;return this;}
        public Computer Build()=>new Computer(this);
    }
}