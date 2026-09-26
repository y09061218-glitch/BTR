# BTR CPU SPECIFACTON

## 1. Overview
"BTR CPU" is a vertial CPU designed for the BTR assembly language

## 2. Architecture

- Word Size: 8-bit
- Registers: R0-R3
- Memory: 256 bytes

## 3. Registers

Register | Description
R0       | General purpose
R1       | General purpose
R2       | General purpose 
R3       | General purpose
PC       | Program counter


## 4. Instructions

### MOV
Move value into a register
Example:

MOV R0, 10

### ADD
Add two registers
Example:

ADD R0, R1

### SUB
Subtract two registers
Example:

SUB R0, R1

### HTL
Stop the CPU
Example:

HTL