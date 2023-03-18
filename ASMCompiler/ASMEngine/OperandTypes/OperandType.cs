namespace ASMEngine
{
    public enum OperandType : byte
    {
        RegisterOrMemory = 0, // R/M
        Register = 1,  // R
        Immediate8 = 2, // im8
        Immediate16 = 6, // im16
        SegmentRegister,
        RegisterCL,
        Memory = 3,  // M
        RegisterAX = 4,   // A
        None = 5
    }
}
