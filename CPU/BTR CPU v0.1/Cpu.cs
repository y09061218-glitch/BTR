namespace BtrCpu;

public class Cpu
{
    // General purpose registers
    public byte R0 { get; private set; }
    public byte R1 { get; private set; }
    public byte R2 { get; private set; }
    public byte R3 { get; private set; }

    // Program counter
    public byte PC { get; private set; }

    // 256 bytes of memory
    public byte[] Memory {get; } = new byte[256];
}