using System.Runtime.CompilerServices;

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

    public void MOV(int register, byte value)
    {
        switch (register)
        {
            case 0:
                R0 = value;
                break;
            
            case 1:
                R1 = value;
                break;
            
            case 2:
                R2 = value;
                break;
            
            case 3:
                R3 = value;
                break;
            
            default:
                throw new ArgumentException("Invalid register.");
        }
    }
}