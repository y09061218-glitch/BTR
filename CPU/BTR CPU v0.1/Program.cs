using BtrCpu;

Cpu cpu = new Cpu();

cpu.MOV(0, 10);

Console.WriteLine($"R0 = {cpu.R0}");