using BtrCpu;

Cpu cpu = new Cpu();

// MOV

cpu.MOV(0, 10);

Console.WriteLine($"R0 = {cpu.R0}");

// ADD

cpu.MOV(0, 20);
cpu.MOV(1, 30);
cpu.ADD(0, 1);

Console.WriteLine($"R0 = {cpu.R0}");
Console.WriteLine($"R1 = {cpu.R1}");