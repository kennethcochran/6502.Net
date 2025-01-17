//-----------------------------------------------------------------------------
// Copyright (c) 2017-2023 informedcitizenry <informedcitizenry@gmail.com>
//
// Licensed under the MIT license. See LICENSE for full license information.
// 
//-----------------------------------------------------------------------------

using System;

namespace Sixty502DotNet.Shared;

/// <summary>
/// Enumerates the various modes possible for Z80 operations, including in
/// first and second position of operands.
/// </summary>
public static class Z80Modes
{
    public const int
            Implied            = 0b0000000000000000,
            A0                 = 0b0000000000000001,
            B0                 = 0b0000000000000010,
            C0                 = 0b0000000000000011,
            D0                 = 0b0000000000000100,
            E0                 = 0b0000000000000101,
            H0                 = 0b0000000000000110,
            L0                 = 0b0000000000000111,
            M0                 = 0b0000000000001000,
            I0                 = 0b0000000000001001,
            IXH0               = 0b0000000000001010,
            IXL0               = 0b0000000000001011,
            IYH0               = 0b0000000000001100,
            IYL0               = 0b0000000000001101,
            PSW0               = 0b0000000000001110,
            R0                 = 0b0000000000001111,
            AF0                = 0b0000000000010000,
            ShadowAF0          = 0b0000000000010001,
            BC0                = 0b0000000000010010,
            DE0                = 0b0000000000010011,
            HL0                = 0b0000000000010100,
            IX0                = 0b0000000000010101,
            IY0                = 0b0000000000010110,
            SP0                = 0b0000000000010111,
            N80                = 0b0000000000011000,
            N160               = 0b0000000000011001,
            N                  = 0b0000000000011011,
            NC                 = 0b0000000000011100,
            NZ                 = 0b0000000000011101,
            P                  = 0b0000000000011110,
            PO                 = 0b0000000000011111,
            PE                 = 0b0000000000100000,
            Z                  = 0b0000000000100001,
            Ix0Flag            = 0b0000000001000000,
            Ind0Flag           = 0b0000000010000000,
            IndC0              = Ind0Flag | C0,
            IndBC0             = Ind0Flag | BC0,
            IndDE0             = Ind0Flag | DE0,
            IndHL0             = Ind0Flag | HL0,
            IndIX0             = Ind0Flag | IX0,
            IndIY0             = Ind0Flag | IY0,
            IndSP0             = Ind0Flag | SP0,
            IndIX0Offs         = Ind0Flag | Ix0Flag | IX0,
            IndIY0Offs         = Ind0Flag | Ix0Flag | IY0,
            IndN80             = Ind0Flag | N80,
            IndN160            = Ind0Flag | N160,
            SecondPosShift     = 0b0000000100000000,
            A1                 = 0b0000000100000000,
            B1                 = 0b0000001000000000,
            C1                 = 0b0000001100000000,
            D1                 = 0b0000010000000000,
            E1                 = 0b0000010100000000,
            H1                 = 0b0000011000000000,
            L1                 = 0b0000011100000000,
            M1                 = 0b0000100000000000,
            I1                 = 0b0000100100000000,
            IXH1               = 0b0000101000000000,
            IXL1               = 0b0000101100000000,
            IYH1               = 0b0000110000000000,
            IYL1               = 0b0000110100000000,
            R1                 = 0b0000111100000000,
            ShadowAF1          = 0b0001000100000000,
            BC1                = 0b0001001000000000,
            DE1                = 0b0001001100000000,
            HL1                = 0b0001010000000000,
            IX1                = 0b0001010100000000,
            IY1                = 0b0001011000000000,
            SP1                = 0b0001011100000000,
            N81                = 0b0001100000000000,
            N161               = 0b0001100100000000,
            Ix1Flag            = 0b0100000000000000,
            Ind1Flag           = 0b1000_0000_0000_0000,
            IndC1              = Ind1Flag  | C1,
            IndBC1             = Ind1Flag  | BC1,
            IndDE1             = Ind1Flag  | DE1,
            IndHL1             = Ind1Flag  | HL1,
            IndIX1Offs         = Ind1Flag  | Ix1Flag | IX1,
            IndIY1Offs         = Ind1Flag  | Ix1Flag | IY1,
            IndN81             = Ind1Flag  | N81,
            IndN161            = Ind1Flag  | N161,
            A0A1               = A0        | A1,
            A0B1               = A0        | B1,
            A0C1               = A0        | C1,
            A0D1               = A0        | D1,
            A0E1               = A0        | E1,
            A0H1               = A0        | H1,
            A0L1               = A0        | L1,
            A0M1               = A0        | M1,
            A0IXH1             = A0        | IXH1,
            A0IXL1             = A0        | IXL1,
            A0IYH1             = A0        | IYH1,
            A0IYL1             = A0        | IYL1,
            A0IndC1            = A0        | IndC1,
            A0IndBC1           = A0        | IndBC1,
            A0IndDE1           = A0        | IndDE1,
            A0IndHL1           = A0        | IndHL1,
            A0IndIX1Offs       = A0        | IndIX1Offs,
            A0IndIY1Offs       = A0        | IndIY1Offs,
            A0IndN81           = A0        | IndN81,
            A0IndN161          = A0        | IndN161,
            A0N81              = A0        | N81,
            A0I1               = A0        | I1,
            A0R1               = A0        | R1,
            B0A1               = B0        | A1,
            B0B1               = B0        | B1,
            B0C1               = B0        | C1,
            B0D1               = B0        | D1,
            B0E1               = B0        | E1,
            B0H1               = B0        | H1,
            B0L1               = B0        | L1,
            B0M1               = B0        | M1,
            B0IXH1             = B0        | IXH1,
            B0IXL1             = B0        | IXL1,
            B0IYH1             = B0        | IYH1,
            B0IYL1             = B0        | IYL1,
            B0IndC1            = B0        | IndC1,
            B0IndHL1           = B0        | IndHL1,
            B0IndIX1Offs       = B0        | IndIX1Offs,
            B0IndIY1Offs       = B0        | IndIY1Offs,
            B0N81              = B0        | N81,
            C0A1               = C0        | A1,
            C0B1               = C0        | B1,
            C0C1               = C0        | C1,
            C0D1               = C0        | D1,
            C0E1               = C0        | E1,
            C0H1               = C0        | H1,
            C0L1               = C0        | L1,
            C0M1               = C0        | M1,
            C0IXH1             = C0        | IXH1,
            C0IXL1             = C0        | IXL1,
            C0IYH1             = C0        | IYH1,
            C0IYL1             = C0        | IYL1,
            C0IndC1            = C0        | IndC1,
            C0IndHL1           = C0        | IndHL1,
            C0IndIX1Offs       = C0        | IndIX1Offs,
            C0IndIY1Offs       = C0        | IndIY1Offs,
            C0N81              = C0        | N81,
            D0A1               = D0        | A1,
            D0B1               = D0        | B1,
            D0C1               = D0        | C1,
            D0D1               = D0        | D1,
            D0E1               = D0        | E1,
            D0H1               = D0        | H1,
            D0L1               = D0        | L1,
            D0M1               = D0        | M1,
            D0IXH1             = D0        | IXH1,
            D0IXL1             = D0        | IXL1,
            D0IYH1             = D0        | IYH1,
            D0IYL1             = D0        | IYL1,
            D0IndC1            = D0        | IndC1,
            D0IndHL1           = D0        | IndHL1,
            D0IndIX1Offs       = D0        | IndIX1Offs,
            D0IndIY1Offs       = D0        | IndIY1Offs,
            D0N81              = D0        | N81,
            E0A1               = E0        | A1,
            E0B1               = E0        | B1,
            E0C1               = E0        | C1,
            E0D1               = E0        | D1,
            E0E1               = E0        | E1,
            E0H1               = E0        | H1,
            E0L1               = E0        | L1,
            E0M1               = E0        | M1,
            E0IXH1             = E0        | IXH1,
            E0IXL1             = E0        | IXL1,
            E0IYH1             = E0        | IYH1,
            E0IYL1             = E0        | IYL1,
            E0IndC1            = E0        | IndC1,
            E0IndHL1           = E0        | IndHL1,
            E0IndIX1Offs       = E0        | IndIX1Offs,
            E0IndIY1Offs       = E0        | IndIY1Offs,
            E0N81              = E0        | N81,
            H0A1               = H0        | A1,
            H0B1               = H0        | B1,
            H0C1               = H0        | C1,
            H0D1               = H0        | D1,
            H0E1               = H0        | E1,
            H0H1               = H0        | H1,
            H0L1               = H0        | L1,
            H0M1               = H0        | M1,
            H0IndC1            = H0        | IndC1,
            H0IndHL1           = H0        | IndHL1,
            H0IndIX1Offs       = H0        | IndIX1Offs,
            H0IndIY1Offs       = H0        | IndIY1Offs,
            H0N81              = H0        | N81,
            L0A1               = L0        | A1,
            L0B1               = L0        | B1,
            L0C1               = L0        | C1,
            L0D1               = L0        | D1,
            L0E1               = L0        | E1,
            L0H1               = L0        | H1,
            L0L1               = L0        | L1,
            L0M1               = L0        | M1,
            L0IndC1            = L0        | IndC1,
            L0IndHL1           = L0        | IndHL1,
            L0IndIX1Offs       = L0        | IndIX1Offs,
            L0IndIY1Offs       = L0        | IndIY1Offs,
            L0N81              = L0        | N81,
            M0A1               = M0        | A1,
            M0B1               = M0        | B1,
            M0C1               = M0        | C1,
            M0D1               = M0        | D1,
            M0E1               = M0        | E1,
            M0H1               = M0        | H1,
            M0L1               = M0        | L1,
            M0N81              = M0        | N81,
            IXH0A1             = IXH0      | A1,
            IXH0B1             = IXH0      | B1,
            IXH0C1             = IXH0      | C1,
            IXH0D1             = IXH0      | D1,
            IXH0E1             = IXH0      | E1,
            IXH0IXH1           = IXH0      | IXH1,
            IXH0IXL1           = IXH0      | IXL1,
            IXH0N81            = IXH0      | N81,
            IXL0A1             = IXL0      | A1,
            IXL0B1             = IXL0      | B1,
            IXL0C1             = IXL0      | C1,
            IXL0D1             = IXL0      | D1,
            IXL0E1             = IXL0      | E1,
            IXL0IXH1           = IXL0      | IXH1,
            IXL0IXL1           = IXL0      | IXL1,
            IXL0N81            = IXL0      | N81,
            IYH0A1             = IYH0      | A1,
            IYH0B1             = IYH0      | B1,
            IYH0C1             = IYH0      | C1,
            IYH0D1             = IYH0      | D1,
            IYH0E1             = IYH0      | E1,
            IYH0IYH1           = IYH0      | IYH1,
            IYH0IYL1           = IYH0      | IYL1,
            IYH0N81            = IYH0      | N81,
            IYL0A1             = IYL0      | A1,
            IYL0B1             = IYL0      | B1,
            IYL0C1             = IYL0      | C1,
            IYL0D1             = IYL0      | D1,
            IYL0E1             = IYL0      | E1,
            IYL0IYH1           = IYL0      | IYH1,
            IYL0IYL1           = IYL0      | IYL1,
            IYL0N81            = IYL0      | N81,
            I0A1               = I0        | A1,
            R0A1               = R0        | A1,
            AF0ShadowAF1       = AF0       | ShadowAF1,
            BC0IndN161         = BC0       | IndN161,
            BC0N161            = BC0       | N161,
            DE0HL1             = DE0       | HL1,
            DE0IndN161         = DE0       | IndN161,
            DE0N161            = DE0       | N161,
            HL0BC1             = HL0       | BC1,
            HL0DE1             = HL0       | DE1,
            HL0HL1             = HL0       | HL1,
            HL0SP1             = HL0       | SP1,
            HL0IndN161         = HL0       | IndN161,
            HL0N161            = HL0       | N161,
            IX0BC1             = IX0       | BC1,
            IX0DE1             = IX0       | DE1,
            IX0IX1             = IX0       | IX1,
            IX0SP1             = IX0       | SP1,
            IX0IndN161         = IX0       | IndN161,
            IX0N161            = IX0       | N161,
            IY0BC1             = IY0       | BC1,
            IY0DE1             = IY0       | DE1,
            IY0IY1             = IY0       | IY1,
            IY0SP1             = IY0       | SP1,
            IY0IndN161         = IY0       | IndN161,
            IY0N161            = IY0       | N161,
            SP0HL1             = SP0       | HL1,
            SP0IX1             = SP0       | IX1,
            SP0IY1             = SP0       | IY1,
            SP0IndN161         = SP0       | IndN161,
            SP0N161            = SP0       | N161,
            IndC0A1            = IndC0     | A1,
            IndC0B1            = IndC0     | B1,
            IndC0C1            = IndC0     | C1,
            IndC0D1            = IndC0     | D1,
            IndC0E1            = IndC0     | E1,
            IndC0H1            = IndC0     | H1,
            IndC0L1            = IndC0     | L1,
            IndC0N81           = IndC0     | N81,
            IndBC0A1           = IndBC0    | A1,
            IndDE0A1           = IndDE0    | A1,
            IndHL0A1           = IndHL0    | A1,
            IndHL0B1           = IndHL0    | B1,
            IndHL0C1           = IndHL0    | C1,
            IndHL0D1           = IndHL0    | D1,
            IndHL0E1           = IndHL0    | E1,
            IndHL0H1           = IndHL0    | H1,
            IndHL0L1           = IndHL0    | L1,
            IndHL0N81          = IndHL0    | N81,
            IndIX0OffsA1       = IndIX0Offs| A1,
            IndIX0OffsB1       = IndIX0Offs| B1,
            IndIX0OffsC1       = IndIX0Offs| C1,
            IndIX0OffsD1       = IndIX0Offs| D1,
            IndIX0OffsE1       = IndIX0Offs| E1,
            IndIX0OffsH1       = IndIX0Offs| H1,
            IndIX0OffsL1       = IndIX0Offs| L1,
            IndIX0OffsN81      = IndIX0Offs| N81,
            IndIY0OffsA1       = IndIY0Offs| A1,
            IndIY0OffsB1       = IndIY0Offs| B1,
            IndIY0OffsC1       = IndIY0Offs| C1,
            IndIY0OffsD1       = IndIY0Offs| D1,
            IndIY0OffsE1       = IndIY0Offs| E1,
            IndIY0OffsH1       = IndIY0Offs| H1,
            IndIY0OffsL1       = IndIY0Offs| L1,
            IndIY0OffsN81      = IndIY0Offs| N81,
            IndSP0HL1          = IndSP0    | HL1,
            IndSP0IX1          = IndSP0    | IX1,
            IndSP0IY1          = IndSP0    | IY1,
            IndN80A1           = IndN80    | A1,
            IndN160A1          = IndN160   | A1,
            IndN160BC1         = IndN160   | BC1,
            IndN160DE1         = IndN160   | DE1,
            IndN160HL1         = IndN160   | HL1,
            IndN160IX1         = IndN160   | IX1,
            IndN160IY1         = IndN160   | IY1,
            IndN160SP1         = IndN160   | SP1,
            NC0N81             = NC        | N81,
            NZ0N81             = NZ        | N81,
            P0N81              = P         | N81,
            PE0N81             = PE        | N81,
            PO0N81             = PO        | N81,
            Z0N81              = Z         | N81,
            C0N161             = C0        | N161,
            M0N161             = M0        | N161,
            NC0N161            = NC        | N161,
            NZ0N161            = NZ        | N161,
            P0N161             = P         | N161,
            PE0N161            = PE        | N161,
            PO0N161            = PO        | N161,
            Z0N161             = Z         | N161;
};

public sealed partial class Z80InstructionEncoder
{
    private static readonly Dictionary<int, int> s_firstPositionRegToMode = new()
    {
        { SyntaxParser.A,   Z80Modes.A0 },
        { SyntaxParser.B,   Z80Modes.B0 },
        { SyntaxParser.C,   Z80Modes.C0 },
        { SyntaxParser.D,   Z80Modes.D0 },
        { SyntaxParser.E,   Z80Modes.E0 },
        { SyntaxParser.H,   Z80Modes.H0 },
        { SyntaxParser.I,   Z80Modes.I0 },
        { SyntaxParser.L,   Z80Modes.L0 },
        { SyntaxParser.M,   Z80Modes.M0 },
        { SyntaxParser.IXH, Z80Modes.IXH0 },
        { SyntaxParser.IXL, Z80Modes.IXL0 },
        { SyntaxParser.IYH, Z80Modes.IYH0 },
        { SyntaxParser.IYL, Z80Modes.IYL0 },
        { SyntaxParser.PSW, Z80Modes.PSW0 },
        { SyntaxParser.R,   Z80Modes.R0 },
        { SyntaxParser.AF,  Z80Modes.AF0 },
        { SyntaxParser.ShadowAF, Z80Modes.ShadowAF0 },
        { SyntaxParser.BC,  Z80Modes.BC0 },
        { SyntaxParser.DE,  Z80Modes.DE0 },
        { SyntaxParser.HL,  Z80Modes.HL0 },
        { SyntaxParser.IX,  Z80Modes.IX0 },
        { SyntaxParser.IY,  Z80Modes.IY0 },
        { SyntaxParser.SP,  Z80Modes.SP0 },
        { SyntaxParser.NC,  Z80Modes.NC },
        { SyntaxParser.NZ,  Z80Modes.NZ },
        { SyntaxParser.P,   Z80Modes.P },
        { SyntaxParser.PO,  Z80Modes.PO },
        { SyntaxParser.PE,  Z80Modes.PE },
        { SyntaxParser.Z,   Z80Modes.Z }
    };

    private static readonly HashSet<int> s_R8s = new()
    {
        SyntaxParser.A,
        SyntaxParser.B,
        SyntaxParser.C,
        SyntaxParser.D,
        SyntaxParser.E,
        SyntaxParser.H,
        SyntaxParser.I,
        SyntaxParser.L,
        SyntaxParser.M,
        SyntaxParser.IXH,
        SyntaxParser.IXL,
        SyntaxParser.IYH,
        SyntaxParser.IYL,
        SyntaxParser.R
    };

    private static readonly HashSet<int> s_Z80ConditionalJumps = new()
    {
        SyntaxParser.CALL, SyntaxParser.JP, SyntaxParser.JR, SyntaxParser.RET
    };

    // s_z80
    private static readonly Dictionary<int, Dictionary<int, Instruction>> s_z80 = new()
    {
        {
            Z80Modes.A0, new Dictionary<int, Instruction>()
            {
                { SyntaxParser.DAA, new Instruction("daa", 0x27, 1) },
                { SyntaxParser.CPL, new Instruction("cpl", 0x2f, 1) },
                { SyntaxParser.INC, new Instruction("inc a", 0x3c, 1) },
                { SyntaxParser.DEC, new Instruction("dec a", 0x3d, 1) },
                { SyntaxParser.ADD, new Instruction("add a", 0x87, 1) },
                { SyntaxParser.ADC, new Instruction("adc a", 0x8f, 1) },
                { SyntaxParser.SUB, new Instruction("sub a", 0x97, 1) },
                { SyntaxParser.AND, new Instruction("and a", 0xa7, 1) },
                { SyntaxParser.XOR, new Instruction("xor a", 0xaf, 1) },
                { SyntaxParser.OR,  new Instruction("or a", 0xb7, 1) },
                { SyntaxParser.CP,  new Instruction("cp a", 0xbf, 1) },
                { SyntaxParser.RLC, new Instruction("rlc a", 0x07cb, 2) },
                { SyntaxParser.RRC, new Instruction("rrc a", 0x0fcb, 2) },
                { SyntaxParser.RL,  new Instruction("rl a", 0x17cb, 2) },
                { SyntaxParser.RR,  new Instruction("rr a", 0x1fcb, 2) },
                { SyntaxParser.SLA, new Instruction("sla a", 0x27cb, 2) },
                { SyntaxParser.SRA, new Instruction("sra a", 0x2fcb, 2) },
                { SyntaxParser.SLL, new Instruction("sll a", 0x37cb, 2) },
                { SyntaxParser.SRL, new Instruction("srl a", 0x3fcb, 2) }
            }
        },
        {
            Z80Modes.A0A1, new Dictionary<int, Instruction>()
            {
                { SyntaxParser.LD,  new Instruction("ld a,a", 0x7f, 1) },
                { SyntaxParser.ADD, new Instruction("add a,a", 0x87, 1) },
                { SyntaxParser.ADC, new Instruction("adc a,a", 0x8f, 1) },
                { SyntaxParser.SUB, new Instruction("sub a,a", 0x97, 1) },
                { SyntaxParser.SBC, new Instruction("sbc a,a", 0x9f, 1) },
                { SyntaxParser.AND, new Instruction("and a,a", 0xa7, 1) },
                { SyntaxParser.XOR, new Instruction("xor a,a", 0xaf, 1) },
                { SyntaxParser.OR,  new Instruction("or a,a", 0xb7, 1) },
                { SyntaxParser.CP,  new Instruction("cp a,a", 0xbf, 1) }
            }
        },
        {
            Z80Modes.A0B1, new Dictionary<int, Instruction>()
            {
                { SyntaxParser.LD,  new Instruction("ld a,b", 0x78, 1) },
                { SyntaxParser.ADD, new Instruction("add a,b", 0x80, 1) },
                { SyntaxParser.ADC, new Instruction("adc a,b", 0x88, 1) },
                { SyntaxParser.SUB, new Instruction("sub a,b", 0x90, 1) },
                { SyntaxParser.SBC, new Instruction("sbc a,b", 0x98, 1) },
                { SyntaxParser.AND, new Instruction("and a,b", 0xa0, 1) },
                { SyntaxParser.XOR, new Instruction("xor a,b", 0xa8, 1) },
                { SyntaxParser.OR,  new Instruction("or a,b", 0xb0, 1) },
                { SyntaxParser.CP,  new Instruction("cp a,b", 0xb8, 1) }
            }
        },
        {
            Z80Modes.A0C1, new Dictionary<int, Instruction>()
            {
                { SyntaxParser.LD,  new Instruction("ld a,c", 0x79, 1) },
                { SyntaxParser.ADD, new Instruction("add a,c", 0x81, 1) },
                { SyntaxParser.ADC, new Instruction("adc a,c", 0x89, 1) },
                { SyntaxParser.SUB, new Instruction("sub a,c", 0x91, 1) },
                { SyntaxParser.SBC, new Instruction("sbc a,c", 0x99, 1) },
                { SyntaxParser.AND, new Instruction("and a,c", 0xa1, 1) },
                { SyntaxParser.XOR, new Instruction("xor a,c", 0xa9, 1) },
                { SyntaxParser.OR,  new Instruction("or a,c", 0xb1, 1) },
                { SyntaxParser.CP,  new Instruction("cp a,c", 0xb9, 1) }
            }
        },
        {
            Z80Modes.A0D1, new Dictionary<int, Instruction>()
            {
                { SyntaxParser.LD,  new Instruction("ld a,d", 0x7a, 1) },
                { SyntaxParser.ADD, new Instruction("add a,d", 0x82, 1) },
                { SyntaxParser.ADC, new Instruction("adc a,d", 0x8a, 1) },
                { SyntaxParser.SUB, new Instruction("sub a,d", 0x92, 1) },
                { SyntaxParser.SBC, new Instruction("sbc a,d", 0x9a, 1) },
                { SyntaxParser.AND, new Instruction("and a,d", 0xa2, 1) },
                { SyntaxParser.XOR, new Instruction("xor a,d", 0xaa, 1) },
                { SyntaxParser.OR,  new Instruction("or a,d", 0xb2, 1) },
                { SyntaxParser.CP,  new Instruction("cp a,d", 0xba, 1) }
            }
        },
        {
            Z80Modes.A0E1, new Dictionary<int, Instruction>()
            {
                { SyntaxParser.LD,  new Instruction("ld a,e", 0x7b, 1) },
                { SyntaxParser.ADD, new Instruction("add a,e", 0x83, 1) },
                { SyntaxParser.ADC, new Instruction("adc a,e", 0x8b, 1) },
                { SyntaxParser.SUB, new Instruction("sub a,e", 0x93, 1) },
                { SyntaxParser.SBC, new Instruction("sbc a,e", 0x9b, 1) },
                { SyntaxParser.AND, new Instruction("and a,e", 0xa3, 1) },
                { SyntaxParser.XOR, new Instruction("xor a,e", 0xab, 1) },
                { SyntaxParser.OR,  new Instruction("or a,e", 0xb3, 1) },
                { SyntaxParser.CP,  new Instruction("cp a,e", 0xbb, 1) }
            }
        },
        {
            Z80Modes.A0H1, new Dictionary<int, Instruction>()
            {
                { SyntaxParser.LD,  new Instruction("ld a,h", 0x7c, 1) },
                { SyntaxParser.ADD, new Instruction("add a,h", 0x84, 1) },
                { SyntaxParser.ADC, new Instruction("adc a,h", 0x8c, 1) },
                { SyntaxParser.SUB, new Instruction("sub a,h", 0x94, 1) },
                { SyntaxParser.SBC, new Instruction("sbc a,h", 0x9c, 1) },
                { SyntaxParser.AND, new Instruction("and a,h", 0xa4, 1) },
                { SyntaxParser.XOR, new Instruction("xor a,h", 0xac, 1) },
                { SyntaxParser.OR,  new Instruction("or a,h", 0xb4, 1) },
                { SyntaxParser.CP,  new Instruction("cp a,h", 0xbc, 1) }
            }
        },
        {
            Z80Modes.A0I1, new Dictionary<int, Instruction>() { { SyntaxParser.LD, new Instruction("ld a,i", 0x57ed, 2) } }
        },
        {
            Z80Modes.A0IXH1, new Dictionary<int, Instruction>()
            {
                { SyntaxParser.LD,  new Instruction("ld a,ixh", 0x7cdd, 2) },
                { SyntaxParser.ADD, new Instruction("add a,ixh", 0x84dd, 2) },
                { SyntaxParser.ADC, new Instruction("adc a,ixh", 0x8cdd, 2) },
                { SyntaxParser.SBC, new Instruction("sbc a,ixh", 0x9cdd, 2) }
            }
        },
        {
            Z80Modes.A0IXL1, new Dictionary<int, Instruction>()
            {
                { SyntaxParser.LD,  new Instruction("ld a,ixl", 0x7ddd, 2) },
                { SyntaxParser.ADD, new Instruction("add a,ixl", 0x85dd, 2) },
                { SyntaxParser.ADC, new Instruction("adc a,ixl", 0x8ddd, 2) },
                { SyntaxParser.SBC, new Instruction("sbc a,ixl", 0x9ddd, 2) }
            }
        },
        {
            Z80Modes.A0IYH1, new Dictionary<int, Instruction>()
            {
                { SyntaxParser.LD,  new Instruction("ld a,iyh", 0x7cfd, 2) },
                { SyntaxParser.ADD, new Instruction("add a,iyh", 0x84fd, 2) },
                { SyntaxParser.ADC, new Instruction("adc a,iyh", 0x8cfd, 2) },
                { SyntaxParser.SBC, new Instruction("sbc a,iyh", 0x9cfd, 2) }
            }
        },
        {
            Z80Modes.A0IYL1, new Dictionary<int, Instruction>()
            {
                { SyntaxParser.LD,  new Instruction("ld a,iyl", 0x7dfd, 2) },
                { SyntaxParser.ADD, new Instruction("add a,iyl", 0x85fd, 2) },
                { SyntaxParser.ADC, new Instruction("adc a,iyl", 0x8dfd, 2) },
                { SyntaxParser.SBC, new Instruction("sbc a,iyl", 0x9dfd, 2) }
            }
        },
        {
            Z80Modes.A0IndBC1, new Dictionary<int, Instruction>() { { SyntaxParser.LD, new Instruction("ld a,(bc)", 0x0a, 1) } }
        },
        {
            Z80Modes.A0IndC1, new Dictionary<int, Instruction>() { { SyntaxParser.IN, new Instruction("in a,(c)", 0x78ed, 2) } }
        },
        {
            Z80Modes.A0IndDE1, new Dictionary<int, Instruction>() { { SyntaxParser.LD, new Instruction("ld a,(de)", 0x1a, 1) } }
        },
        {
            Z80Modes.A0IndHL1, new Dictionary<int, Instruction>()
            {
                { SyntaxParser.LD,  new Instruction("ld a,(hl)", 0x7e, 1) },
                { SyntaxParser.ADD, new Instruction("add a,(hl)", 0x86, 1) },
                { SyntaxParser.ADC, new Instruction("adc a,(hl)", 0x8e, 1) },
                { SyntaxParser.SUB, new Instruction("sub a,(hl)", 0x96, 1) },
                { SyntaxParser.SBC, new Instruction("sbc a,(hl)", 0x9e, 1) },
                { SyntaxParser.AND, new Instruction("and a,(hl)", 0xa6, 1) },
                { SyntaxParser.XOR, new Instruction("xor a,(hl)", 0xae, 1) },
                { SyntaxParser.OR,  new Instruction("or a,(hl)", 0xb6, 1) },
                { SyntaxParser.CP,  new Instruction("cp a,(hl)", 0xbe, 1) }
            }
        },
        {
            Z80Modes.A0IndIX1Offs, new Dictionary<int, Instruction>()
            {
                { SyntaxParser.LD,  new Instruction("ld a,(ix+${0:x2})", 0x7edd, 3) },
                { SyntaxParser.ADD, new Instruction("add a,(ix+${0:x2})", 0x86dd, 3) },
                { SyntaxParser.ADC, new Instruction("adc a,(ix+${0:x2})", 0x8edd, 3) },
                { SyntaxParser.SBC, new Instruction("sbc a,(ix+${0:x2})", 0x9edd, 3) }
            }
        },
        {
            Z80Modes.A0IndIY1Offs, new Dictionary<int, Instruction>()
            {
                { SyntaxParser.LD,  new Instruction("ld a,(iy+${0:x2})", 0x7efd, 3) },
                { SyntaxParser.ADD, new Instruction("add a,(iy+${0:x2})", 0x86fd, 3) },
                { SyntaxParser.ADC, new Instruction("adc a,(iy+${0:x2})", 0x8efd, 3) },
                { SyntaxParser.SBC, new Instruction("sbc a,(iy+${0:x2})", 0x9efd, 3) }
            }
        },
        {
            Z80Modes.A0IndN161, new Dictionary<int, Instruction>() { { SyntaxParser.LD, new Instruction("ld a,(${0:x4})", 0x3a, 3) } }
        },
        {
            Z80Modes.A0IndN81, new Dictionary<int, Instruction>() { { SyntaxParser.IN, new Instruction("in a,(${0:x2})", 0xdb, 2) } }
        },
        {
            Z80Modes.A0L1, new Dictionary<int, Instruction>()
            {
                { SyntaxParser.LD,  new Instruction("ld a,l", 0x7d, 1) },
                { SyntaxParser.ADD, new Instruction("add a,l", 0x85, 1) },
                { SyntaxParser.ADC, new Instruction("adc a,l", 0x8d, 1) },
                { SyntaxParser.SUB, new Instruction("sub a,l", 0x95, 1) },
                { SyntaxParser.SBC, new Instruction("sbc a,l", 0x9d, 1) },
                { SyntaxParser.AND, new Instruction("and a,l", 0xa5, 1) },
                { SyntaxParser.XOR, new Instruction("xor a,l", 0xad, 1) },
                { SyntaxParser.OR,  new Instruction("or a,l", 0xb5, 1) },
                { SyntaxParser.CP,  new Instruction("cp a,l", 0xbd, 1) }
            }
        },
        {
            Z80Modes.A0N81, new Dictionary<int, Instruction>()
            {
                { SyntaxParser.LD,  new Instruction("ld a,${0:x2}", 0x3e, 2) },
                { SyntaxParser.ADD, new Instruction("add a,${0:x2}", 0xc6, 2) },
                { SyntaxParser.ADC, new Instruction("adc a,${0:x2}", 0xce, 2) },
                { SyntaxParser.SBC, new Instruction("sbc a,${0:x2}", 0xde, 2) }
            }
        },
        {
            Z80Modes.A0R1, new Dictionary<int, Instruction>() { { SyntaxParser.LD, new Instruction("ld a,r", 0x5fed, 2) } }
        },
        {
            Z80Modes.AF0, new Dictionary<int, Instruction>()
            {
                { SyntaxParser.POP,  new Instruction("pop af", 0xf1, 1) },
                { SyntaxParser.PUSH, new Instruction("push af", 0xf5, 1) }
            }
        },
        {
            Z80Modes.AF0ShadowAF1, new Dictionary<int, Instruction>() { { SyntaxParser.EX, new Instruction("ex af,af'", 0x08, 1) } }
        },
        {
            Z80Modes.B0, new Dictionary<int, Instruction>()
            {
                { SyntaxParser.INC, new Instruction("inc b", 0x04, 1) },
                { SyntaxParser.DEC, new Instruction("dec b", 0x05, 1) },
                { SyntaxParser.ADD, new Instruction("add b", 0x80, 1) },
                { SyntaxParser.ADC, new Instruction("adc b", 0x88, 1) },
                { SyntaxParser.SUB, new Instruction("sub b", 0x90, 1) },
                { SyntaxParser.AND, new Instruction("and b", 0xa0, 1) },
                { SyntaxParser.XOR, new Instruction("xor b", 0xa8, 1) },
                { SyntaxParser.OR,  new Instruction("or b", 0xb0, 1) },
                { SyntaxParser.CP,  new Instruction("cp b", 0xb8, 1) },
                { SyntaxParser.RLC, new Instruction("rlc b", 0x00cb, 2) },
                { SyntaxParser.RRC, new Instruction("rrc b", 0x08cb, 2) },
                { SyntaxParser.RL,  new Instruction("rl b", 0x10cb, 2) },
                { SyntaxParser.RR,  new Instruction("rr b", 0x18cb, 2) },
                { SyntaxParser.SLA, new Instruction("sla b", 0x20cb, 2) },
                { SyntaxParser.SRA, new Instruction("sra b", 0x28cb, 2) },
                { SyntaxParser.SLL, new Instruction("sll b", 0x30cb, 2) },
                { SyntaxParser.SRL, new Instruction("srl b", 0x38cb, 2) }
            }
        },
        {
            Z80Modes.B0A1, new Dictionary<int, Instruction>() { { SyntaxParser.LD, new Instruction("ld b,a", 0x47, 1) } }
        },
        {
            Z80Modes.B0B1, new Dictionary<int, Instruction>() { { SyntaxParser.LD, new Instruction("ld b,b", 0x40, 1) } }
        },
        {
            Z80Modes.B0C1, new Dictionary<int, Instruction>() { { SyntaxParser.LD, new Instruction("ld b,c", 0x41, 1) } }
        },
        {
            Z80Modes.B0D1, new Dictionary<int, Instruction>() { { SyntaxParser.LD, new Instruction("ld b,d", 0x42, 1) } }
        },
        {
            Z80Modes.B0E1, new Dictionary<int, Instruction>() { { SyntaxParser.LD, new Instruction("ld b,e", 0x43, 1) } }
        },
        {
            Z80Modes.B0H1, new Dictionary<int, Instruction>() { { SyntaxParser.LD, new Instruction("ld b,h", 0x44, 1) } }
        },
        {
            Z80Modes.B0IXH1, new Dictionary<int, Instruction>() { { SyntaxParser.LD, new Instruction("ld b,ixh", 0x44dd, 2) } }
        },
        {
            Z80Modes.B0IXL1, new Dictionary<int, Instruction>() { { SyntaxParser.LD, new Instruction("ld b,ixl", 0x45dd, 2) } }
        },
        {
            Z80Modes.B0IYH1, new Dictionary<int, Instruction>() { { SyntaxParser.LD, new Instruction("ld b,iyh", 0x44fd, 2) } }
        },
        {
            Z80Modes.B0IYL1, new Dictionary<int, Instruction>() { { SyntaxParser.LD, new Instruction("ld b,iyl", 0x45fd, 2) } }
        },
        {
            Z80Modes.B0IndC1, new Dictionary<int, Instruction>() { { SyntaxParser.IN, new Instruction("in b,(c)", 0x40ed, 2) } }
        },
        {
            Z80Modes.B0IndHL1, new Dictionary<int, Instruction>() { { SyntaxParser.LD, new Instruction("ld b,(hl)", 0x46, 1) } }
        },
        {
            Z80Modes.B0IndIX1Offs, new Dictionary<int, Instruction>() { { SyntaxParser.LD, new Instruction("ld b,(ix+${0:x2})", 0x46dd, 3) } }
        },
        {
            Z80Modes.B0IndIY1Offs, new Dictionary<int, Instruction>() { { SyntaxParser.LD, new Instruction("ld b,(iy+${0:x2})", 0x46fd, 3) } }
        },
        {
            Z80Modes.B0L1, new Dictionary<int, Instruction>() { { SyntaxParser.LD, new Instruction("ld b,l", 0x45, 1) } }
        },
        {
            Z80Modes.B0N81, new Dictionary<int, Instruction>() { { SyntaxParser.LD, new Instruction("ld b,${0:x2}", 0x06, 2) } }
        },
        {
            Z80Modes.BC0, new Dictionary<int, Instruction>()
            {
                { SyntaxParser.INC,  new Instruction("inc bc", 0x03, 1) },
                { SyntaxParser.DEC,  new Instruction("dec bc", 0x0b, 1) },
                { SyntaxParser.POP,  new Instruction("pop bc", 0xc1, 1) },
                { SyntaxParser.PUSH, new Instruction("push bc", 0xc5, 1) }
            }
        },
        {
            Z80Modes.BC0IndN161, new Dictionary<int, Instruction>() { { SyntaxParser.LD, new Instruction("ld bc,(${0:x4})", 0x4bed, 4) } }
        },
        {
            Z80Modes.BC0N161, new Dictionary<int, Instruction>() { { SyntaxParser.LD, new Instruction("ld bc,${0:x4}", 0x01, 3) } }
        },
        {
            Z80Modes.C0, new Dictionary<int, Instruction>()
            {
                { SyntaxParser.INC, new Instruction("inc c", 0x0c, 1) },
                { SyntaxParser.DEC, new Instruction("dec c", 0x0d, 1) },
                { SyntaxParser.ADD, new Instruction("add c", 0x81, 1) },
                { SyntaxParser.ADC, new Instruction("adc c", 0x89, 1) },
                { SyntaxParser.SUB, new Instruction("sub c", 0x91, 1) },
                { SyntaxParser.AND, new Instruction("and c", 0xa1, 1) },
                { SyntaxParser.XOR, new Instruction("xor c", 0xa9, 1) },
                { SyntaxParser.OR,  new Instruction("or c", 0xb1, 1) },
                { SyntaxParser.CP,  new Instruction("cp c", 0xb9, 1) },
                { SyntaxParser.RET, new Instruction("ret c", 0xd8, 1) },
                { SyntaxParser.RLC, new Instruction("rlc c", 0x01cb, 2) },
                { SyntaxParser.RRC, new Instruction("rrc c", 0x09cb, 2) },
                { SyntaxParser.RL,  new Instruction("rl c", 0x11cb, 2) },
                { SyntaxParser.RR,  new Instruction("rr c", 0x19cb, 2) },
                { SyntaxParser.SLA, new Instruction("sla c", 0x21cb, 2) },
                { SyntaxParser.SRA, new Instruction("sra c", 0x29cb, 2) },
                { SyntaxParser.SLL, new Instruction("sll c", 0x31cb, 2) },
                { SyntaxParser.SRL, new Instruction("srl c", 0x39cb, 2) }
            }
        },
        {
            Z80Modes.C0A1, new Dictionary<int, Instruction>() { { SyntaxParser.LD, new Instruction("ld c,a", 0x4f, 1) } }
        },
        {
            Z80Modes.C0B1, new Dictionary<int, Instruction>() { { SyntaxParser.LD, new Instruction("ld c,b", 0x48, 1) } }
        },
        {
            Z80Modes.C0C1, new Dictionary<int, Instruction>() { { SyntaxParser.LD, new Instruction("ld c,c", 0x49, 1) } }
        },
        {
            Z80Modes.C0D1, new Dictionary<int, Instruction>() { { SyntaxParser.LD, new Instruction("ld c,d", 0x4a, 1) } }
        },
        {
            Z80Modes.C0E1, new Dictionary<int, Instruction>() { { SyntaxParser.LD, new Instruction("ld c,e", 0x4b, 1) } }
        },
        {
            Z80Modes.C0H1, new Dictionary<int, Instruction>() { { SyntaxParser.LD, new Instruction("ld c,h", 0x4c, 1) } }
        },
        {
            Z80Modes.C0IXH1, new Dictionary<int, Instruction>() { { SyntaxParser.LD, new Instruction("ld c,ixh", 0x4cdd, 2) } }
        },
        {
            Z80Modes.C0IXL1, new Dictionary<int, Instruction>() { { SyntaxParser.LD, new Instruction("ld c,ixl", 0x4ddd, 2) } }
        },
        {
            Z80Modes.C0IYH1, new Dictionary<int, Instruction>() { { SyntaxParser.LD, new Instruction("ld c,iyh", 0x4cfd, 2) } }
        },
        {
            Z80Modes.C0IYL1, new Dictionary<int, Instruction>() { { SyntaxParser.LD, new Instruction("ld c,iyl", 0x4dfd, 2) } }
        },
        {
            Z80Modes.C0IndC1, new Dictionary<int, Instruction>() { { SyntaxParser.IN, new Instruction("in c,(c)", 0x48ed, 2) } }
        },
        {
            Z80Modes.C0IndHL1, new Dictionary<int, Instruction>() { { SyntaxParser.LD, new Instruction("ld c,(hl)", 0x4e, 1) } }
        },
        {
            Z80Modes.C0IndIX1Offs, new Dictionary<int, Instruction>() { { SyntaxParser.LD, new Instruction("ld c,(ix+${0:x2})", 0x4edd, 3) } }
        },
        {
            Z80Modes.C0IndIY1Offs, new Dictionary<int, Instruction>() { { SyntaxParser.LD, new Instruction("ld c,(iy+${0:x2})", 0x4efd, 3) } }
        },
        {
            Z80Modes.C0L1, new Dictionary<int, Instruction>() { { SyntaxParser.LD, new Instruction("ld c,l", 0x4d, 1) } }
        },
        {
            Z80Modes.C0N161, new Dictionary<int, Instruction>()
            {
                { SyntaxParser.JR, new Instruction("jr c,${0:x4}", 0x38, 2, true) },
                { SyntaxParser.JP, new Instruction("jp c,${0:x4}", 0xda, 3) },
                { SyntaxParser.CALL, new Instruction("call c,${0:x4}", 0xdc, 3) }
            }
        },
        {
            Z80Modes.C0N81, new Dictionary<int, Instruction>()
            {
                { SyntaxParser.LD,   new Instruction("ld c,${0:x2}", 0x0e, 2) },
                { SyntaxParser.JR,   new Instruction("jr c,${0:x4}", 0x38, 2, true) },
                { SyntaxParser.JP,   new Instruction("jp c,${0:x4}", 0xda, 3) },
                { SyntaxParser.CALL, new Instruction("call c,${0:x4}", 0xdc, 3) }
            }
        },
        {
            Z80Modes.D0, new Dictionary<int, Instruction>()
            {
                { SyntaxParser.INC, new Instruction("inc d", 0x14, 1) },
                { SyntaxParser.DEC, new Instruction("dec d", 0x15, 1) },
                { SyntaxParser.ADD, new Instruction("add d", 0x82, 1) },
                { SyntaxParser.ADC, new Instruction("adc d", 0x8a, 1) },
                { SyntaxParser.SUB, new Instruction("sub d", 0x92, 1) },
                { SyntaxParser.AND, new Instruction("and d", 0xa2, 1) },
                { SyntaxParser.XOR, new Instruction("xor d", 0xaa, 1) },
                { SyntaxParser.OR,  new Instruction("or d", 0xb2, 1) },
                { SyntaxParser.CP,  new Instruction("cp d", 0xba, 1) },
                { SyntaxParser.RLC, new Instruction("rlc d", 0x02cb, 2) },
                { SyntaxParser.RRC, new Instruction("rrc d", 0x0acb, 2) },
                { SyntaxParser.RL,  new Instruction("rl d", 0x12cb, 2) },
                { SyntaxParser.RR,  new Instruction("rr d", 0x1acb, 2) },
                { SyntaxParser.SLA, new Instruction("sla d", 0x22cb, 2) },
                { SyntaxParser.SRA, new Instruction("sra d", 0x2acb, 2) },
                { SyntaxParser.SLL, new Instruction("sll d", 0x32cb, 2) },
                { SyntaxParser.SRL, new Instruction("srl d", 0x3acb, 2) }
            }
        },
        {
            Z80Modes.D0A1, new Dictionary<int, Instruction>() { { SyntaxParser.LD, new Instruction("ld d,a", 0x57, 1) } }
        },
        {
            Z80Modes.D0B1, new Dictionary<int, Instruction>() { { SyntaxParser.LD, new Instruction("ld d,b", 0x50, 1) } }
        },
        {
            Z80Modes.D0C1, new Dictionary<int, Instruction>() { { SyntaxParser.LD, new Instruction("ld d,c", 0x51, 1) } }
        },
        {
            Z80Modes.D0D1, new Dictionary<int, Instruction>() { { SyntaxParser.LD, new Instruction("ld d,d", 0x52, 1) } }
        },
        {
            Z80Modes.D0E1, new Dictionary<int, Instruction>() { { SyntaxParser.LD, new Instruction("ld d,e", 0x53, 1) } }
        },
        {
            Z80Modes.D0H1, new Dictionary<int, Instruction>() { { SyntaxParser.LD, new Instruction("ld d,h", 0x54, 1) } }
        },
        {
            Z80Modes.D0IXH1, new Dictionary<int, Instruction>() { { SyntaxParser.LD, new Instruction("ld d,ixh", 0x54dd, 2) } }
        },
        {
            Z80Modes.D0IXL1, new Dictionary<int, Instruction>() { { SyntaxParser.LD, new Instruction("ld d,ixl", 0x55dd, 2) } }
        },
        {
            Z80Modes.D0IYH1, new Dictionary<int, Instruction>() { { SyntaxParser.LD, new Instruction("ld d,iyh", 0x54fd, 2) } }
        },
        {
            Z80Modes.D0IYL1, new Dictionary<int, Instruction>() { { SyntaxParser.LD, new Instruction("ld d,iyl", 0x55fd, 2) } }
        },
        {
            Z80Modes.D0IndC1, new Dictionary<int, Instruction>() { { SyntaxParser.IN, new Instruction("in d,(c)", 0x50ed, 2) } }
        },
        {
            Z80Modes.D0IndHL1, new Dictionary<int, Instruction>() { { SyntaxParser.LD, new Instruction("ld d,(hl)", 0x56, 1) } }
        },
        {
            Z80Modes.D0IndIX1Offs, new Dictionary<int, Instruction>() { { SyntaxParser.LD, new Instruction("ld d,(ix+${0:x2})", 0x56dd, 3) } }
        },
        {
            Z80Modes.D0IndIY1Offs, new Dictionary<int, Instruction>() { { SyntaxParser.LD, new Instruction("ld d,(iy+${0:x2})", 0x56fd, 3) } }
        },
        {
            Z80Modes.D0L1, new Dictionary<int, Instruction>() { { SyntaxParser.LD, new Instruction("ld d,l", 0x55, 1) } }
        },
        {
            Z80Modes.D0N81, new Dictionary<int, Instruction>() { { SyntaxParser.LD, new Instruction("ld d,${0:x2}", 0x16, 2) } }
        },
        {
            Z80Modes.DE0, new Dictionary<int, Instruction>()
            {
                { SyntaxParser.INC,  new Instruction("inc de", 0x13, 1) },
                { SyntaxParser.DEC,  new Instruction("dec de", 0x1b, 1) },
                { SyntaxParser.POP,  new Instruction("pop de", 0xd1, 1) },
                { SyntaxParser.PUSH, new Instruction("push de", 0xd5, 1) }
            }
        },
        {
            Z80Modes.DE0HL1, new Dictionary<int, Instruction>() { { SyntaxParser.EX, new Instruction("ex de,hl", 0xeb, 1) } }
        },
        {
            Z80Modes.DE0IndN161, new Dictionary<int, Instruction>() { { SyntaxParser.LD, new Instruction("ld de,(${0:x4})", 0x5bed, 4) } }
        },
        {
            Z80Modes.DE0N161, new Dictionary<int, Instruction>() { { SyntaxParser.LD, new Instruction("ld de,${0:x4}", 0x11, 3) } }
        },
        {
            Z80Modes.E0, new Dictionary<int, Instruction>()
            {
                { SyntaxParser.INC, new Instruction("inc e", 0x1c, 1) },
                { SyntaxParser.DEC, new Instruction("dec e", 0x1d, 1) },
                { SyntaxParser.ADD, new Instruction("add e", 0x83, 1) },
                { SyntaxParser.ADC, new Instruction("adc e", 0x8b, 1) },
                { SyntaxParser.SUB, new Instruction("sub e", 0x93, 1) },
                { SyntaxParser.AND, new Instruction("and e", 0xa3, 1) },
                { SyntaxParser.XOR, new Instruction("xor e", 0xab, 1) },
                { SyntaxParser.OR,  new Instruction("or e", 0xb3, 1) },
                { SyntaxParser.CP,  new Instruction("cp e", 0xbb, 1) },
                { SyntaxParser.RLC, new Instruction("rlc e", 0x03cb, 2) },
                { SyntaxParser.RRC, new Instruction("rrc e", 0x0bcb, 2) },
                { SyntaxParser.RL,  new Instruction("rl e", 0x13cb, 2) },
                { SyntaxParser.RR,  new Instruction("rr e", 0x1bcb, 2) },
                { SyntaxParser.SLA, new Instruction("sla e", 0x23cb, 2) },
                { SyntaxParser.SRA, new Instruction("sra e", 0x2bcb, 2) },
                { SyntaxParser.SLL, new Instruction("sll e", 0x33cb, 2) },
                { SyntaxParser.SRL, new Instruction("srl e", 0x3bcb, 2) }
            }
        },
        {
            Z80Modes.E0A1, new Dictionary<int, Instruction>() { { SyntaxParser.LD, new Instruction("ld e,a", 0x5f, 1) } }
        },
        {
            Z80Modes.E0B1, new Dictionary<int, Instruction>() { { SyntaxParser.LD, new Instruction("ld e,b", 0x58, 1) } }
        },
        {
            Z80Modes.E0C1, new Dictionary<int, Instruction>() { { SyntaxParser.LD, new Instruction("ld e,c", 0x59, 1) } }
        },
        {
            Z80Modes.E0D1, new Dictionary<int, Instruction>() { { SyntaxParser.LD, new Instruction("ld e,d", 0x5a, 1) } }
        },
        {
            Z80Modes.E0E1, new Dictionary<int, Instruction>() { { SyntaxParser.LD, new Instruction("ld e,e", 0x5b, 1) } }
        },
        {
            Z80Modes.E0H1, new Dictionary<int, Instruction>() { { SyntaxParser.LD, new Instruction("ld e,h", 0x5c, 1) } }
        },
        {
            Z80Modes.E0IXH1, new Dictionary<int, Instruction>() { { SyntaxParser.LD, new Instruction("ld e,ixh", 0x5cdd, 2) } }
        },
        {
            Z80Modes.E0IXL1, new Dictionary<int, Instruction>() { { SyntaxParser.LD, new Instruction("ld e,ixl", 0x5ddd, 2) } }
        },
        {
            Z80Modes.E0IYH1, new Dictionary<int, Instruction>() { { SyntaxParser.LD, new Instruction("ld e,iyh", 0x5cfd, 2) } }
        },
        {
            Z80Modes.E0IYL1, new Dictionary<int, Instruction>() { { SyntaxParser.LD, new Instruction("ld e,iyl", 0x5dfd, 2) } }
        },
        {
            Z80Modes.E0IndC1, new Dictionary<int, Instruction>() { { SyntaxParser.IN, new Instruction("in e,(c)", 0x58ed, 2) } }
        },
        {
            Z80Modes.E0IndHL1, new Dictionary<int, Instruction>() { { SyntaxParser.LD, new Instruction("ld e,(hl)", 0x5e, 1) } }
        },
        {
            Z80Modes.E0IndIX1Offs, new Dictionary<int, Instruction>() { { SyntaxParser.LD, new Instruction("ld e,(ix+${0:x2})", 0x5edd, 3) } }
        },
        {
            Z80Modes.E0IndIY1Offs, new Dictionary<int, Instruction>() { { SyntaxParser.LD, new Instruction("ld e,(iy+${0:x2})", 0x5efd, 3) } }
        },
        {
            Z80Modes.E0L1, new Dictionary<int, Instruction>() { { SyntaxParser.LD, new Instruction("ld e,l", 0x5d, 1) } }
        },
        {
            Z80Modes.E0N81, new Dictionary<int, Instruction>() { { SyntaxParser.LD, new Instruction("ld e,${0:x2}", 0x1e, 2) } }
        },
        {
            Z80Modes.H0, new Dictionary<int, Instruction>()
            {
                { SyntaxParser.INC, new Instruction("inc h", 0x24, 1) },
                { SyntaxParser.DEC, new Instruction("dec h", 0x25, 1) },
                { SyntaxParser.ADD, new Instruction("add h", 0x84, 1) },
                { SyntaxParser.ADC, new Instruction("adc h", 0x8c, 1) },
                { SyntaxParser.SUB, new Instruction("sub h", 0x94, 1) },
                { SyntaxParser.AND, new Instruction("and h", 0xa4, 1) },
                { SyntaxParser.XOR, new Instruction("xor h", 0xac, 1) },
                { SyntaxParser.OR,  new Instruction("or h", 0xb4, 1) },
                { SyntaxParser.CP,  new Instruction("cp h", 0xbc, 1) },
                { SyntaxParser.RLC, new Instruction("rlc h", 0x04cb, 2) },
                { SyntaxParser.RRC, new Instruction("rrc h", 0x0ccb, 2) },
                { SyntaxParser.RL,  new Instruction("rl h", 0x14cb, 2) },
                { SyntaxParser.RR,  new Instruction("rr h", 0x1ccb, 2) },
                { SyntaxParser.SLA, new Instruction("sla h", 0x24cb, 2) },
                { SyntaxParser.SRA, new Instruction("sra h", 0x2ccb, 2) },
                { SyntaxParser.SLL, new Instruction("sll h", 0x34cb, 2) },
                { SyntaxParser.SRL, new Instruction("srl h", 0x3ccb, 2) }
            }
        },
        {
            Z80Modes.H0A1, new Dictionary<int, Instruction>() { { SyntaxParser.LD, new Instruction("ld h,a", 0x67, 1) } }
        },
        {
            Z80Modes.H0B1, new Dictionary<int, Instruction>() { { SyntaxParser.LD, new Instruction("ld h,b", 0x60, 1) } }
        },
        {
            Z80Modes.H0C1, new Dictionary<int, Instruction>() { { SyntaxParser.LD, new Instruction("ld h,c", 0x61, 1) } }
        },
        {
            Z80Modes.H0D1, new Dictionary<int, Instruction>() { { SyntaxParser.LD, new Instruction("ld h,d", 0x62, 1) } }
        },
        {
            Z80Modes.H0E1, new Dictionary<int, Instruction>() { { SyntaxParser.LD, new Instruction("ld h,e", 0x63, 1) } }
        },
        {
            Z80Modes.H0H1, new Dictionary<int, Instruction>() { { SyntaxParser.LD, new Instruction("ld h,h", 0x64, 1) } }
        },
        {
            Z80Modes.H0IndC1, new Dictionary<int, Instruction>() { { SyntaxParser.IN, new Instruction("in h,(c)", 0x60ed, 2) } }
        },
        {
            Z80Modes.H0IndHL1, new Dictionary<int, Instruction>() { { SyntaxParser.LD, new Instruction("ld h,(hl)", 0x66, 1) } }
        },
        {
            Z80Modes.H0IndIX1Offs, new Dictionary<int, Instruction>() { { SyntaxParser.LD, new Instruction("ld h,(ix+${0:x2})", 0x66dd, 3) } }
        },
        {
            Z80Modes.H0IndIY1Offs, new Dictionary<int, Instruction>() { { SyntaxParser.LD, new Instruction("ld h,(iy+${0:x2})", 0x66fd, 3) } }
        },
        {
            Z80Modes.H0L1, new Dictionary<int, Instruction>() { { SyntaxParser.LD, new Instruction("ld h,l", 0x65, 1) } }
        },
        {
            Z80Modes.H0N81, new Dictionary<int, Instruction>() { { SyntaxParser.LD, new Instruction("ld h,${0:x2}", 0x26, 2) } }
        },
        {
            Z80Modes.HL0, new Dictionary<int, Instruction>()
            {
                { SyntaxParser.INC,  new Instruction("inc hl", 0x23, 1) },
                { SyntaxParser.DEC,  new Instruction("dec hl", 0x2b, 1) },
                { SyntaxParser.POP,  new Instruction("pop hl", 0xe1, 1) },
                { SyntaxParser.PUSH, new Instruction("push hl", 0xe5, 1) }
            }
        },
        {
            Z80Modes.HL0BC1, new Dictionary<int, Instruction>()
            {
                { SyntaxParser.ADD, new Instruction("add hl,bc", 0x09, 1) },
                { SyntaxParser.SBC, new Instruction("sbc hl,bc", 0x42ed, 2) },
                { SyntaxParser.ADC, new Instruction("adc hl,bc", 0x4aed, 2) }
            }
        },
        {
            Z80Modes.HL0DE1, new Dictionary<int, Instruction>()
            {
                { SyntaxParser.ADD, new Instruction("add hl,de", 0x19, 1) },
                { SyntaxParser.SBC, new Instruction("sbc hl,de", 0x52ed, 2) },
                { SyntaxParser.ADC, new Instruction("adc hl,de", 0x5aed, 2) }
            }
        },
        {
            Z80Modes.HL0HL1, new Dictionary<int, Instruction>()
            {
                { SyntaxParser.ADD, new Instruction("add hl,hl", 0x29, 1) },
                { SyntaxParser.SBC, new Instruction("sbc hl,hl", 0x62ed, 2) },
                { SyntaxParser.ADC, new Instruction("adc hl,hl", 0x6aed, 2) }
            }
        },
        {
            Z80Modes.HL0IndN161, new Dictionary<int, Instruction>() { { SyntaxParser.LD, new Instruction("ld hl,(${0:x4})", 0x2a, 3) } }
        },
        {
            Z80Modes.HL0N161, new Dictionary<int, Instruction>() { { SyntaxParser.LD, new Instruction("ld hl,${0:x4}", 0x21, 3) } }
        },
        {
            Z80Modes.HL0SP1, new Dictionary<int, Instruction>()
            {
                { SyntaxParser.ADD, new Instruction("add hl,sp", 0x39, 1) },
                { SyntaxParser.SBC, new Instruction("sbc hl,sp", 0x72ed, 2) },
                { SyntaxParser.ADC, new Instruction("adc hl,sp", 0x7aed, 2) }
            }
        },
        {
            Z80Modes.I0A1, new Dictionary<int, Instruction>() { { SyntaxParser.LD, new Instruction("ld i,a", 0x47ed, 2) } }
        },
        {
            Z80Modes.IX0, new Dictionary<int, Instruction>()
            {
                { SyntaxParser.INC,  new Instruction("inc ix", 0x23dd, 2) },
                { SyntaxParser.DEC,  new Instruction("dec ix", 0x2bdd, 2) },
                { SyntaxParser.POP,  new Instruction("pop ix", 0xe1dd, 2) },
                { SyntaxParser.PUSH, new Instruction("push ix", 0xe5dd, 2) }
            }
        },
        {
            Z80Modes.IX0BC1, new Dictionary<int, Instruction>() { { SyntaxParser.ADD, new Instruction("add ix,bc", 0x09dd, 2) } }
        },
        {
            Z80Modes.IX0DE1, new Dictionary<int, Instruction>() { { SyntaxParser.ADD, new Instruction("add ix,de", 0x19dd, 2) } }
        },
        {
            Z80Modes.IX0IX1, new Dictionary<int, Instruction>() { { SyntaxParser.ADD, new Instruction("add ix,ix", 0x29dd, 2) } }
        },
        {
            Z80Modes.IX0IndN161, new Dictionary<int, Instruction>() { { SyntaxParser.LD, new Instruction("ld ix,(${0:x4})", 0x2add, 4) } }
        },
        {
            Z80Modes.IX0N161, new Dictionary<int, Instruction>() { { SyntaxParser.LD, new Instruction("ld ix,${0:x4}", 0x21dd, 4) } }
        },
        {
            Z80Modes.IX0SP1, new Dictionary<int, Instruction>() { { SyntaxParser.ADD, new Instruction("add ix,sp", 0x39dd, 2) } }
        },
        {
            Z80Modes.IXH0, new Dictionary<int, Instruction>()
            {
                { SyntaxParser.INC, new Instruction("inc ixh", 0x24dd, 2) },
                { SyntaxParser.DEC, new Instruction("dec ixh", 0x25dd, 2) },
                { SyntaxParser.SUB, new Instruction("sub ixh", 0x94dd, 2) },
                { SyntaxParser.AND, new Instruction("and ixh", 0xa4dd, 2) },
                { SyntaxParser.XOR, new Instruction("xor ixh", 0xacdd, 2) },
                { SyntaxParser.OR,  new Instruction("or ixh", 0xb4dd, 2) },
                { SyntaxParser.CP,  new Instruction("cp ixh", 0xbcdd, 2) }
            }
        },
        {
            Z80Modes.IXH0A1, new Dictionary<int, Instruction>() { { SyntaxParser.LD, new Instruction("ld ixh,a", 0x67dd, 2) } }
        },
        {
            Z80Modes.IXH0B1, new Dictionary<int, Instruction>() { { SyntaxParser.LD, new Instruction("ld ixh,b", 0x60dd, 2) } }
        },
        {
            Z80Modes.IXH0C1, new Dictionary<int, Instruction>() { { SyntaxParser.LD, new Instruction("ld ixh,c", 0x61dd, 2) } }
        },
        {
            Z80Modes.IXH0D1, new Dictionary<int, Instruction>() { { SyntaxParser.LD, new Instruction("ld ixh,d", 0x62dd, 2) } }
        },
        {
            Z80Modes.IXH0E1, new Dictionary<int, Instruction>() { { SyntaxParser.LD, new Instruction("ld ixh,e", 0x63dd, 2) } }
        },
        {
            Z80Modes.IXH0IXH1, new Dictionary<int, Instruction>() { { SyntaxParser.LD, new Instruction("ld ixh,ixh", 0x64dd, 2) } }
        },
        {
            Z80Modes.IXH0IXL1, new Dictionary<int, Instruction>() { { SyntaxParser.LD, new Instruction("ld ixh,ixl", 0x65dd, 2) } }
        },
        {
            Z80Modes.IXH0N81, new Dictionary<int, Instruction>() { { SyntaxParser.LD, new Instruction("ld ixh,${0:x2}", 0x26dd, 3) } }
        },
        {
            Z80Modes.IXL0, new Dictionary<int, Instruction>()
            {
                { SyntaxParser.INC, new Instruction("inc ixl", 0x2cdd, 2) },
                { SyntaxParser.DEC, new Instruction("dec ixl", 0x2ddd, 2) },
                { SyntaxParser.SUB, new Instruction("sub ixl", 0x95dd, 2) },
                { SyntaxParser.AND, new Instruction("and ixl", 0xa5dd, 2) },
                { SyntaxParser.XOR, new Instruction("xor ixl", 0xaddd, 2) },
                { SyntaxParser.OR,  new Instruction("or ixl", 0xb5dd, 2) },
                { SyntaxParser.CP,  new Instruction("cp ixl", 0xbddd, 2) }
            }
        },
        {
            Z80Modes.IXL0A1, new Dictionary<int, Instruction>() { { SyntaxParser.LD, new Instruction("ld ixl,a", 0x6fdd, 2) } }
        },
        {
            Z80Modes.IXL0B1, new Dictionary<int, Instruction>() { { SyntaxParser.LD, new Instruction("ld ixl,b", 0x68dd, 2) } }
        },
        {
            Z80Modes.IXL0C1, new Dictionary<int, Instruction>() { { SyntaxParser.LD, new Instruction("ld ixl,c", 0x69dd, 2) } }
        },
        {
            Z80Modes.IXL0D1, new Dictionary<int, Instruction>() { { SyntaxParser.LD, new Instruction("ld ixl,d", 0x6add, 2) } }
        },
        {
            Z80Modes.IXL0E1, new Dictionary<int, Instruction>() { { SyntaxParser.LD, new Instruction("ld ixl,e", 0x6bdd, 2) } }
        },
        {
            Z80Modes.IXL0IXH1, new Dictionary<int, Instruction>() { { SyntaxParser.LD, new Instruction("ld ixl,ixh", 0x6cdd, 2) } }
        },
        {
            Z80Modes.IXL0IXL1, new Dictionary<int, Instruction>() { { SyntaxParser.LD, new Instruction("ld ixl,ixl", 0x6ddd, 2) } }
        },
        {
            Z80Modes.IXL0N81, new Dictionary<int, Instruction>() { { SyntaxParser.LD, new Instruction("ld ixl,${0:x2}", 0x2edd, 3) } }
        },
        {
            Z80Modes.IY0, new Dictionary<int, Instruction>()
            {
                { SyntaxParser.INC,  new Instruction("inc iy", 0x23fd, 2) },
                { SyntaxParser.DEC,  new Instruction("dec iy", 0x2bfd, 2) },
                { SyntaxParser.POP,  new Instruction("pop iy", 0xe1fd, 2) },
                { SyntaxParser.PUSH, new Instruction("push iy", 0xe5fd, 2) }
            }
        },
        {
            Z80Modes.IY0BC1, new Dictionary<int, Instruction>() { { SyntaxParser.ADD, new Instruction("add iy,bc", 0x09fd, 2) } }
        },
        {
            Z80Modes.IY0DE1, new Dictionary<int, Instruction>() { { SyntaxParser.ADD, new Instruction("add iy,de", 0x19fd, 2) } }
        },
        {
            Z80Modes.IY0IY1, new Dictionary<int, Instruction>() { { SyntaxParser.ADD, new Instruction("add iy,iy", 0x29fd, 2) } }
        },
        {
            Z80Modes.IY0IndN161, new Dictionary<int, Instruction>() { { SyntaxParser.LD, new Instruction("ld iy,(${0:x4})", 0x2afd, 4) } }
        },
        {
            Z80Modes.IY0N161, new Dictionary<int, Instruction>() { { SyntaxParser.LD, new Instruction("ld iy,${0:x4}", 0x21fd, 4) } }
        },
        {
            Z80Modes.IY0SP1, new Dictionary<int, Instruction>() { { SyntaxParser.ADD, new Instruction("add iy,sp", 0x39fd, 2) } }
        },
        {
            Z80Modes.IYH0, new Dictionary<int, Instruction>()
            {
                { SyntaxParser.INC, new Instruction("inc iyh", 0x24fd, 2) },
                { SyntaxParser.DEC, new Instruction("dec iyh", 0x25fd, 2) },
                { SyntaxParser.SUB, new Instruction("sub iyh", 0x94fd, 2) },
                { SyntaxParser.AND, new Instruction("and iyh", 0xa4fd, 2) },
                { SyntaxParser.XOR, new Instruction("xor iyh", 0xacfd, 2) },
                { SyntaxParser.OR,  new Instruction("or iyh", 0xb4fd, 2) },
                { SyntaxParser.CP,  new Instruction("cp iyh", 0xbcfd, 2) }
            }
        },
        {
            Z80Modes.IYH0A1, new Dictionary<int, Instruction>() { { SyntaxParser.LD, new Instruction("ld iyh,a", 0x67fd, 2) } }
        },
        {
            Z80Modes.IYH0B1, new Dictionary<int, Instruction>() { { SyntaxParser.LD, new Instruction("ld iyh,b", 0x60fd, 2) } }
        },
        {
            Z80Modes.IYH0C1, new Dictionary<int, Instruction>() { { SyntaxParser.LD, new Instruction("ld iyh,c", 0x61fd, 2) } }
        },
        {
            Z80Modes.IYH0D1, new Dictionary<int, Instruction>() { { SyntaxParser.LD, new Instruction("ld iyh,d", 0x62fd, 2) } }
        },
        {
            Z80Modes.IYH0E1, new Dictionary<int, Instruction>() { { SyntaxParser.LD, new Instruction("ld iyh,e", 0x63fd, 2) } }
        },
        {
            Z80Modes.IYH0IYH1, new Dictionary<int, Instruction>() { { SyntaxParser.LD, new Instruction("ld iyh,iyh", 0x64fd, 2) } }
        },
        {
            Z80Modes.IYH0IYL1, new Dictionary<int, Instruction>() { { SyntaxParser.LD, new Instruction("ld iyh,iyl", 0x65fd, 2) } }
        },
        {
            Z80Modes.IYH0N81, new Dictionary<int, Instruction>() { { SyntaxParser.LD, new Instruction("ld iyh,${0:x2}", 0x26fd, 3) } }
        },
        {
            Z80Modes.IYL0, new Dictionary<int, Instruction>()
            {
                { SyntaxParser.INC, new Instruction("inc iyl", 0x2cfd, 2) },
                { SyntaxParser.DEC, new Instruction("dec iyl", 0x2dfd, 2) },
                { SyntaxParser.SUB, new Instruction("sub iyl", 0x95fd, 2) },
                { SyntaxParser.AND, new Instruction("and iyl", 0xa5fd, 2) },
                { SyntaxParser.XOR, new Instruction("xor iyl", 0xadfd, 2) },
                { SyntaxParser.OR,  new Instruction("or iyl", 0xb5fd, 2) },
                { SyntaxParser.CP,  new Instruction("cp iyl", 0xbdfd, 2) }
            }
        },
        {
            Z80Modes.IYL0A1, new Dictionary<int, Instruction>() { { SyntaxParser.LD, new Instruction("ld iyl,a", 0x6ffd, 2) } }
        },
        {
            Z80Modes.IYL0B1, new Dictionary<int, Instruction>() { { SyntaxParser.LD, new Instruction("ld iyl,b", 0x68fd, 2) } }
        },
        {
            Z80Modes.IYL0C1, new Dictionary<int, Instruction>() { { SyntaxParser.LD, new Instruction("ld iyl,c", 0x69fd, 2) } }
        },
        {
            Z80Modes.IYL0D1, new Dictionary<int, Instruction>() { { SyntaxParser.LD, new Instruction("ld iyl,d", 0x6afd, 2) } }
        },
        {
            Z80Modes.IYL0E1, new Dictionary<int, Instruction>() { { SyntaxParser.LD, new Instruction("ld iyl,e", 0x6bfd, 2) } }
        },
        {
            Z80Modes.IYL0IYH1, new Dictionary<int, Instruction>() { { SyntaxParser.LD, new Instruction("ld iyl,iyh", 0x6cfd, 2) } }
        },
        {
            Z80Modes.IYL0IYL1, new Dictionary<int, Instruction>() { { SyntaxParser.LD, new Instruction("ld iyl,iyl", 0x6dfd, 2) } }
        },
        {
            Z80Modes.IYL0N81, new Dictionary<int, Instruction>() { { SyntaxParser.LD, new Instruction("ld iyl,${0:x2}", 0x2efd, 3) } }
        },
        {
            Z80Modes.Implied, new Dictionary<int, Instruction>()
            {
                { SyntaxParser.NOP,  new Instruction("nop", 0x00, 1) },
                { SyntaxParser.RLCA, new Instruction("rlca", 0x07, 1) },
                { SyntaxParser.RRCA, new Instruction("rrca", 0x0f, 1) },
                { SyntaxParser.RLA,  new Instruction("rla", 0x17, 1) },
                { SyntaxParser.RRA,  new Instruction("rra", 0x1f, 1) },
                { SyntaxParser.DAA,  new Instruction("daa", 0x27, 1) },
                { SyntaxParser.CPL,  new Instruction("cpl", 0x2f, 1) },
                { SyntaxParser.SCF,  new Instruction("scf", 0x37, 1) },
                { SyntaxParser.CCF,  new Instruction("ccf", 0x3f, 1) },
                { SyntaxParser.HALT, new Instruction("halt", 0x76, 1) },
                { SyntaxParser.RET,  new Instruction("ret", 0xc9, 1) },
                { SyntaxParser.EXX,  new Instruction("exx", 0xd9, 1) },
                { SyntaxParser.DI,   new Instruction("di", 0xf3, 1) },
                { SyntaxParser.EI,   new Instruction("ei", 0xfb, 1) },
                { SyntaxParser.NEG,  new Instruction("neg", 0x44ed, 2) },
                { SyntaxParser.RETN, new Instruction("retn", 0x45ed, 2) },
                { SyntaxParser.RETI, new Instruction("reti", 0x4ded, 2) },
                { SyntaxParser.RRD,  new Instruction("rrd", 0x67ed, 2) },
                { SyntaxParser.RLD,  new Instruction("rld", 0x6fed, 2) },
                { SyntaxParser.LDI,  new Instruction("ldi", 0xa0ed, 2) },
                { SyntaxParser.CPI,  new Instruction("cpi", 0xa1ed, 2) },
                { SyntaxParser.INI,  new Instruction("ini", 0xa2ed, 2) },
                { SyntaxParser.OUTI, new Instruction("outi", 0xa3ed, 2) },
                { SyntaxParser.LDD,  new Instruction("ldd", 0xa8ed, 2) },
                { SyntaxParser.CPD,  new Instruction("cpd", 0xa9ed, 2) },
                { SyntaxParser.IND,  new Instruction("ind", 0xaaed, 2) },
                { SyntaxParser.OUTD, new Instruction("outd", 0xabed, 2) },
                { SyntaxParser.LDIR, new Instruction("ldir", 0xb0ed, 2) },
                { SyntaxParser.CPIR, new Instruction("cpir", 0xb1ed, 2) },
                { SyntaxParser.INIR, new Instruction("inir", 0xb2ed, 2) },
                { SyntaxParser.OTIR, new Instruction("otir", 0xb3ed, 2) },
                { SyntaxParser.LDDR, new Instruction("lddr", 0xb8ed, 2) },
                { SyntaxParser.CPDR, new Instruction("cpdr", 0xb9ed, 2) },
                { SyntaxParser.INDR, new Instruction("indr", 0xbaed, 2) },
                { SyntaxParser.OTDR, new Instruction("otdr", 0xbbed, 2) }
            }
        },
        {
            Z80Modes.IndBC0A1, new Dictionary<int, Instruction>() { { SyntaxParser.LD, new Instruction("ld (bc),a", 0x02, 1) } }
        },
        {
            Z80Modes.IndC0, new Dictionary<int, Instruction>() { { SyntaxParser.IN, new Instruction("in (c)", 0x70ed, 2) } }
        },
        {
            Z80Modes.IndC0A1, new Dictionary<int, Instruction>() { { SyntaxParser.OUT, new Instruction("out (c),a", 0x79ed, 2) } }
        },
        {
            Z80Modes.IndC0B1, new Dictionary<int, Instruction>() { { SyntaxParser.OUT, new Instruction("out (c),b", 0x41ed, 2) } }
        },
        {
            Z80Modes.IndC0C1, new Dictionary<int, Instruction>() { { SyntaxParser.OUT, new Instruction("out (c),c", 0x49ed, 2) } }
        },
        {
            Z80Modes.IndC0D1, new Dictionary<int, Instruction>() { { SyntaxParser.OUT, new Instruction("out (c),d", 0x51ed, 2) } }
        },
        {
            Z80Modes.IndC0E1, new Dictionary<int, Instruction>() { { SyntaxParser.OUT, new Instruction("out (c),e", 0x59ed, 2) } }
        },
        {
            Z80Modes.IndC0H1, new Dictionary<int, Instruction>() { { SyntaxParser.OUT, new Instruction("out (c),h", 0x61ed, 2) } }
        },
        {
            Z80Modes.IndC0L1, new Dictionary<int, Instruction>() { { SyntaxParser.OUT, new Instruction("out (c),l", 0x69ed, 2) } }
        },
        {
            Z80Modes.IndC0N81, new Dictionary<int, Instruction>() { { SyntaxParser.OUT, new Instruction("out (c),0", 0x71ed, 2) } }
        },
        {
            Z80Modes.IndDE0A1, new Dictionary<int, Instruction>() { { SyntaxParser.LD, new Instruction("ld (de),a", 0x12, 1) } }
        },
        {
            Z80Modes.IndHL0, new Dictionary<int, Instruction>()
            {
                { SyntaxParser.INC, new Instruction("inc (hl)", 0x34, 1) },
                { SyntaxParser.DEC, new Instruction("dec (hl)", 0x35, 1) },
                { SyntaxParser.ADD, new Instruction("add (hl)", 0x86, 1) },
                { SyntaxParser.ADC, new Instruction("adc (hl)", 0x8e, 1) },
                { SyntaxParser.SUB, new Instruction("sub (hl)", 0x96, 1) },
                { SyntaxParser.AND, new Instruction("and (hl)", 0xa6, 1) },
                { SyntaxParser.XOR, new Instruction("xor (hl)", 0xae, 1) },
                { SyntaxParser.OR,  new Instruction("or (hl)", 0xb6, 1) },
                { SyntaxParser.CP,  new Instruction("cp (hl)", 0xbe, 1) },
                { SyntaxParser.JP,  new Instruction("jp (hl)", 0xe9, 1) },
                { SyntaxParser.RLC, new Instruction("rlc (hl)", 0x06cb, 2) },
                { SyntaxParser.RRC, new Instruction("rrc (hl)", 0x0ecb, 2) },
                { SyntaxParser.RL,  new Instruction("rl (hl)", 0x16cb, 2) },
                { SyntaxParser.RR,  new Instruction("rr (hl)", 0x1ecb, 2) },
                { SyntaxParser.SLA, new Instruction("sla (hl)", 0x26cb, 2) },
                { SyntaxParser.SRA, new Instruction("sra (hl)", 0x2ecb, 2) },
                { SyntaxParser.SLL, new Instruction("sll (hl)", 0x36cb, 2) },
                { SyntaxParser.SRL, new Instruction("srl (hl)", 0x3ecb, 2) }
            }
        },
        {
            Z80Modes.IndHL0A1, new Dictionary<int, Instruction>() { { SyntaxParser.LD, new Instruction("ld (hl),a", 0x77, 1) } }
        },
        {
            Z80Modes.IndHL0B1, new Dictionary<int, Instruction>() { { SyntaxParser.LD, new Instruction("ld (hl),b", 0x70, 1) } }
        },
        {
            Z80Modes.IndHL0C1, new Dictionary<int, Instruction>() { { SyntaxParser.LD, new Instruction("ld (hl),c", 0x71, 1) } }
        },
        {
            Z80Modes.IndHL0D1, new Dictionary<int, Instruction>() { { SyntaxParser.LD, new Instruction("ld (hl),d", 0x72, 1) } }
        },
        {
            Z80Modes.IndHL0E1, new Dictionary<int, Instruction>() { { SyntaxParser.LD, new Instruction("ld (hl),e", 0x73, 1) } }
        },
        {
            Z80Modes.IndHL0H1, new Dictionary<int, Instruction>() { { SyntaxParser.LD, new Instruction("ld (hl),h", 0x74, 1) } }
        },
        {
            Z80Modes.IndHL0L1, new Dictionary<int, Instruction>() { { SyntaxParser.LD, new Instruction("ld (hl),l", 0x75, 1) } }
        },
        {
            Z80Modes.IndHL0N81, new Dictionary<int, Instruction>() { { SyntaxParser.LD, new Instruction("ld (hl),${0:x2}", 0x36, 2) } }
        },
        {
            Z80Modes.IndIX0, new Dictionary<int, Instruction>() { { SyntaxParser.JP, new Instruction("jp (ix+${0:x2})", 0xe9dd, 2) } }
        },
        {
            Z80Modes.IndIX0Offs, new Dictionary<int, Instruction>()
            {
                { SyntaxParser.RLC, new Instruction("rlc (ix+${0:x2})", 0x06cbdd, 4) },
                { SyntaxParser.RRC, new Instruction("rrc (ix+${0:x2})", 0x0ecbdd, 4) },
                { SyntaxParser.RL,  new Instruction("rl (ix+${0:x2})", 0x16cbdd, 4) },
                { SyntaxParser.RR,  new Instruction("rr (ix+${0:x2})", 0x1ecbdd, 4) },
                { SyntaxParser.SLA, new Instruction("sla (ix+${0:x2})", 0x26cbdd, 4) },
                { SyntaxParser.SRA, new Instruction("sra (ix+${0:x2})", 0x2ecbdd, 4) },
                { SyntaxParser.SLL, new Instruction("sll (ix+${0:x2})", 0x36cbdd, 4) },
                { SyntaxParser.SRL, new Instruction("srl (ix+${0:x2})", 0x3ecbdd, 4) },
                { SyntaxParser.INC, new Instruction("inc (ix+${0:x2})", 0x34dd, 3) },
                { SyntaxParser.DEC, new Instruction("dec (ix+${0:x2})", 0x35dd, 3) },
                { SyntaxParser.SUB, new Instruction("sub (ix+${0:x2})", 0x96dd, 3) },
                { SyntaxParser.AND, new Instruction("and (ix+${0:x2})", 0xa6dd, 3) },
                { SyntaxParser.XOR, new Instruction("xor (ix+${0:x2})", 0xaedd, 3) },
                { SyntaxParser.OR,  new Instruction("or (ix+${0:x2})", 0xb6dd, 3) },
                { SyntaxParser.CP,  new Instruction("cp (ix+${0:x2})", 0xbedd, 3) }
            }
        },
        {
            Z80Modes.IndIX0OffsA1, new Dictionary<int, Instruction>()
            {
                { SyntaxParser.RLC, new Instruction("rlc (ix+${0:x2}),a", 0x07cbdd, 4) },
                { SyntaxParser.RRC, new Instruction("rrc (ix+${0:x2}),a", 0x0fcbdd, 4) },
                { SyntaxParser.RL,  new Instruction("rl (ix+${0:x2}),a", 0x17cbdd, 4) },
                { SyntaxParser.RR,  new Instruction("rr (ix+${0:x2}),a", 0x1fcbdd, 4) },
                { SyntaxParser.SLA, new Instruction("sla (ix+${0:x2}),a", 0x27cbdd, 4) },
                { SyntaxParser.SRA, new Instruction("sra (ix+${0:x2}),a", 0x2fcbdd, 4) },
                { SyntaxParser.SLL, new Instruction("sll (ix+${0:x2}),a", 0x37cbdd, 4) },
                { SyntaxParser.SRL, new Instruction("srl (ix+${0:x2}),a", 0x3fcbdd, 4) },
                { SyntaxParser.LD,  new Instruction("ld (ix+${0:x2}),a", 0x77dd, 3) }
            }
        },
        {
            Z80Modes.IndIX0OffsB1, new Dictionary<int, Instruction>()
            {
                { SyntaxParser.RLC, new Instruction("rlc (ix+${0:x2}),b", 0x00cbdd, 4) },
                { SyntaxParser.RRC, new Instruction("rrc (ix+${0:x2}),b", 0x08cbdd, 4) },
                { SyntaxParser.RL,  new Instruction("rl (ix+${0:x2}),b", 0x10cbdd, 4) },
                { SyntaxParser.RR,  new Instruction("rr (ix+${0:x2}),b", 0x18cbdd, 4) },
                { SyntaxParser.SLA, new Instruction("sla (ix+${0:x2}),b", 0x20cbdd, 4) },
                { SyntaxParser.SRA, new Instruction("sra (ix+${0:x2}),b", 0x28cbdd, 4) },
                { SyntaxParser.SLL, new Instruction("sll (ix+${0:x2}),b", 0x30cbdd, 4) },
                { SyntaxParser.SRL, new Instruction("srl (ix+${0:x2}),b", 0x38cbdd, 4) },
                { SyntaxParser.LD,  new Instruction("ld (ix+${0:x2}),b", 0x70dd, 3) }
            }
        },
        {
            Z80Modes.IndIX0OffsC1, new Dictionary<int, Instruction>()
            {
                { SyntaxParser.RLC, new Instruction("rlc (ix+${0:x2}),c", 0x01cbdd, 4) },
                { SyntaxParser.RRC, new Instruction("rrc (ix+${0:x2}),c", 0x09cbdd, 4) },
                { SyntaxParser.RL,  new Instruction("rl (ix+${0:x2}),c", 0x11cbdd, 4) },
                { SyntaxParser.RR,  new Instruction("rr (ix+${0:x2}),c", 0x19cbdd, 4) },
                { SyntaxParser.SLA, new Instruction("sla (ix+${0:x2}),c", 0x21cbdd, 4) },
                { SyntaxParser.SRA, new Instruction("sra (ix+${0:x2}),c", 0x29cbdd, 4) },
                { SyntaxParser.SLL, new Instruction("sll (ix+${0:x2}),c", 0x31cbdd, 4) },
                { SyntaxParser.SRL, new Instruction("srl (ix+${0:x2}),c", 0x39cbdd, 4) },
                { SyntaxParser.LD,  new Instruction("ld (ix+${0:x2}),c", 0x71dd, 3) }
            }
        },
        {
            Z80Modes.IndIX0OffsD1, new Dictionary<int, Instruction>()
            {
                { SyntaxParser.RLC, new Instruction("rlc (ix+${0:x2}),d", 0x02cbdd, 4) },
                { SyntaxParser.RRC, new Instruction("rrc (ix+${0:x2}),d", 0x0acbdd, 4) },
                { SyntaxParser.RL,  new Instruction("rl (ix+${0:x2}),d", 0x12cbdd, 4) },
                { SyntaxParser.RR,  new Instruction("rr (ix+${0:x2}),d", 0x1acbdd, 4) },
                { SyntaxParser.SLA, new Instruction("sla (ix+${0:x2}),d", 0x22cbdd, 4) },
                { SyntaxParser.SRA, new Instruction("sra (ix+${0:x2}),d", 0x2acbdd, 4) },
                { SyntaxParser.SLL, new Instruction("sll (ix+${0:x2}),d", 0x32cbdd, 4) },
                { SyntaxParser.SRL, new Instruction("srl (ix+${0:x2}),d", 0x3acbdd, 4) },
                { SyntaxParser.LD,  new Instruction("ld (ix+${0:x2}),d", 0x72dd, 3) }
            }
        },
        {
            Z80Modes.IndIX0OffsE1, new Dictionary<int, Instruction>()
            {
                { SyntaxParser.RLC, new Instruction("rlc (ix+${0:x2}),e", 0x03cbdd, 4) },
                { SyntaxParser.RRC, new Instruction("rrc (ix+${0:x2}),e", 0x0bcbdd, 4) },
                { SyntaxParser.RL,  new Instruction("rl (ix+${0:x2}),e", 0x13cbdd, 4) },
                { SyntaxParser.RR,  new Instruction("rr (ix+${0:x2}),e", 0x1bcbdd, 4) },
                { SyntaxParser.SLA, new Instruction("sla (ix+${0:x2}),e", 0x23cbdd, 4) },
                { SyntaxParser.SRA, new Instruction("sra (ix+${0:x2}),e", 0x2bcbdd, 4) },
                { SyntaxParser.SLL, new Instruction("sll (ix+${0:x2}),e", 0x33cbdd, 4) },
                { SyntaxParser.SRL, new Instruction("srl (ix+${0:x2}),e", 0x3bcbdd, 4) },
                { SyntaxParser.LD,  new Instruction("ld (ix+${0:x2}),e", 0x73dd, 3) }
            }
        },
        {
            Z80Modes.IndIX0OffsH1, new Dictionary<int, Instruction>()
            {
                { SyntaxParser.RLC, new Instruction("rlc (ix+${0:x2}),h", 0x04cbdd, 4) },
                { SyntaxParser.RRC, new Instruction("rrc (ix+${0:x2}),h", 0x0ccbdd, 4) },
                { SyntaxParser.RL,  new Instruction("rl (ix+${0:x2}),h", 0x14cbdd, 4) },
                { SyntaxParser.RR,  new Instruction("rr (ix+${0:x2}),h", 0x1ccbdd, 4) },
                { SyntaxParser.SLA, new Instruction("sla (ix+${0:x2}),h", 0x24cbdd, 4) },
                { SyntaxParser.SRA, new Instruction("sra (ix+${0:x2}),h", 0x2ccbdd, 4) },
                { SyntaxParser.SLL, new Instruction("sll (ix+${0:x2}),h", 0x34cbdd, 4) },
                { SyntaxParser.SRL, new Instruction("srl (ix+${0:x2}),h", 0x3ccbdd, 4) },
                { SyntaxParser.LD,  new Instruction("ld (ix+${0:x2}),h", 0x74dd, 3) }
            }
        },
        {
            Z80Modes.IndIX0OffsL1, new Dictionary<int, Instruction>()
            {
                { SyntaxParser.RLC, new Instruction("rlc (ix+${0:x2}),l", 0x05cbdd, 4) },
                { SyntaxParser.RRC, new Instruction("rrc (ix+${0:x2}),l", 0x0dcbdd, 4) },
                { SyntaxParser.RL,  new Instruction("rl (ix+${0:x2}),l", 0x15cbdd, 4) },
                { SyntaxParser.RR,  new Instruction("rr (ix+${0:x2}),l", 0x1dcbdd, 4) },
                { SyntaxParser.SLA, new Instruction("sla (ix+${0:x2}),l", 0x25cbdd, 4) },
                { SyntaxParser.SRA, new Instruction("sra (ix+${0:x2}),l", 0x2dcbdd, 4) },
                { SyntaxParser.SLL, new Instruction("sll (ix+${0:x2}),l", 0x35cbdd, 4) },
                { SyntaxParser.SRL, new Instruction("srl (ix+${0:x2}),l", 0x3dcbdd, 4) },
                { SyntaxParser.LD,  new Instruction("ld (ix+${0:x2}),l", 0x75dd, 3) }
            }
        },
        {
            Z80Modes.IndIX0OffsN81, new Dictionary<int, Instruction>() { { SyntaxParser.LD, new Instruction("ld (ix+${0:x2}),${1:x2}", 0x36dd, 4) } }
        },
        {
            Z80Modes.IndIY0, new Dictionary<int, Instruction>() { { SyntaxParser.JP, new Instruction("jp (iy)", 0xe9fd, 2) } }
        },
        {
            Z80Modes.IndIY0Offs, new Dictionary<int, Instruction>()
            {
                { SyntaxParser.RLC, new Instruction("rlc (iy+${0:x2})", 0x06cbfd, 4) },
                { SyntaxParser.RRC, new Instruction("rrc (iy+${0:x2})", 0x0ecbfd, 4) },
                { SyntaxParser.RL,  new Instruction("rl (iy+${0:x2})", 0x16cbfd, 4) },
                { SyntaxParser.RR,  new Instruction("rr (iy+${0:x2})", 0x1ecbfd, 4) },
                { SyntaxParser.SLA, new Instruction("sla (iy+${0:x2})", 0x26cbfd, 4) },
                { SyntaxParser.SRA, new Instruction("sra (iy+${0:x2})", 0x2ecbfd, 4) },
                { SyntaxParser.SLL, new Instruction("sll (iy+${0:x2})", 0x36cbfd, 4) },
                { SyntaxParser.SRL, new Instruction("srl (iy+${0:x2})", 0x3ecbfd, 4) },
                { SyntaxParser.INC, new Instruction("inc (iy+${0:x2})", 0x34fd, 3) },
                { SyntaxParser.DEC, new Instruction("dec (iy+${0:x2})", 0x35fd, 3) },
                { SyntaxParser.SUB, new Instruction("sub (iy+${0:x2})", 0x96fd, 3) },
                { SyntaxParser.AND, new Instruction("and (iy+${0:x2})", 0xa6fd, 3) },
                { SyntaxParser.XOR, new Instruction("xor (iy+${0:x2})", 0xaefd, 3) },
                { SyntaxParser.OR,  new Instruction("or (iy+${0:x2})", 0xb6fd, 3) },
                { SyntaxParser.CP,  new Instruction("cp (iy+${0:x2})", 0xbefd, 3) }
            }
        },
        {
            Z80Modes.IndIY0OffsA1, new Dictionary<int, Instruction>()
            {
                { SyntaxParser.RLC, new Instruction("rlc (iy+${0:x2}),a", 0x07cbfd, 4) },
                { SyntaxParser.RRC, new Instruction("rrc (iy+${0:x2}),a", 0x0fcbfd, 4) },
                { SyntaxParser.RL,  new Instruction("rl (iy+${0:x2}),a", 0x17cbfd, 4) },
                { SyntaxParser.RR,  new Instruction("rr (iy+${0:x2}),a", 0x1fcbfd, 4) },
                { SyntaxParser.SLA, new Instruction("sla (iy+${0:x2}),a", 0x27cbfd, 4) },
                { SyntaxParser.SRA, new Instruction("sra (iy+${0:x2}),a", 0x2fcbfd, 4) },
                { SyntaxParser.SLL, new Instruction("sll (iy+${0:x2}),a", 0x37cbfd, 4) },
                { SyntaxParser.SRL, new Instruction("srl (iy+${0:x2}),a", 0x3fcbfd, 4) },
                { SyntaxParser.LD,  new Instruction("ld (iy+${0:x2}),a", 0x77fd, 3) }
            }
        },
        {
            Z80Modes.IndIY0OffsB1, new Dictionary<int, Instruction>()
            {
                { SyntaxParser.RLC, new Instruction("rlc (iy+${0:x2}),b", 0x00cbfd, 4) },
                { SyntaxParser.RRC, new Instruction("rrc (iy+${0:x2}),b", 0x08cbfd, 4) },
                { SyntaxParser.RL,  new Instruction("rl (iy+${0:x2}),b", 0x10cbfd, 4) },
                { SyntaxParser.RR,  new Instruction("rr (iy+${0:x2}),b", 0x18cbfd, 4) },
                { SyntaxParser.SLA, new Instruction("sla (iy+${0:x2}),b", 0x20cbfd, 4) },
                { SyntaxParser.SRA, new Instruction("sra (iy+${0:x2}),b", 0x28cbfd, 4) },
                { SyntaxParser.SLL, new Instruction("sll (iy+${0:x2}),b", 0x30cbfd, 4) },
                { SyntaxParser.SRL, new Instruction("srl (iy+${0:x2}),b", 0x38cbfd, 4) },
                { SyntaxParser.LD,  new Instruction("ld (iy+${0:x2}),b", 0x70fd, 3) }
            }
        },
        {
            Z80Modes.IndIY0OffsC1, new Dictionary<int, Instruction>()
            {
                { SyntaxParser.RLC, new Instruction("rlc (iy+${0:x2}),c", 0x01cbfd, 4) },
                { SyntaxParser.RRC, new Instruction("rrc (iy+${0:x2}),c", 0x09cbfd, 4) },
                { SyntaxParser.RL,  new Instruction("rl (iy+${0:x2}),c", 0x11cbfd, 4) },
                { SyntaxParser.RR,  new Instruction("rr (iy+${0:x2}),c", 0x19cbfd, 4) },
                { SyntaxParser.SLA, new Instruction("sla (iy+${0:x2}),c", 0x21cbfd, 4) },
                { SyntaxParser.SRA, new Instruction("sra (iy+${0:x2}),c", 0x29cbfd, 4) },
                { SyntaxParser.SLL, new Instruction("sll (iy+${0:x2}),c", 0x31cbfd, 4) },
                { SyntaxParser.SRL, new Instruction("srl (iy+${0:x2}),c", 0x39cbfd, 4) },
                { SyntaxParser.LD,  new Instruction("ld (iy+${0:x2}),c", 0x71fd, 3) }
            } 
        },
        {
            Z80Modes.IndIY0OffsD1, new Dictionary<int, Instruction>()
            {
                { SyntaxParser.RLC, new Instruction("rlc (iy+${0:x2}),d", 0x02cbfd, 4) },
                { SyntaxParser.RRC, new Instruction("rrc (iy+${0:x2}),d", 0x0acbfd, 4) },
                { SyntaxParser.RL,  new Instruction("rl (iy+${0:x2}),d", 0x12cbfd, 4) },
                { SyntaxParser.RR,  new Instruction("rr (iy+${0:x2}),d", 0x1acbfd, 4) },
                { SyntaxParser.SLA, new Instruction("sla (iy+${0:x2}),d", 0x22cbfd, 4) },
                { SyntaxParser.SRA, new Instruction("sra (iy+${0:x2}),d", 0x2acbfd, 4) },
                { SyntaxParser.SLL, new Instruction("sll (iy+${0:x2}),d", 0x32cbfd, 4) },
                { SyntaxParser.SRL, new Instruction("srl (iy+${0:x2}),d", 0x3acbfd, 4) },
                { SyntaxParser.LD,  new Instruction("ld (iy+${0:x2}),d", 0x72fd, 3) }
            }
        },
        {
            Z80Modes.IndIY0OffsE1, new Dictionary<int, Instruction>()
            {
                { SyntaxParser.RLC, new Instruction("rlc (iy+${0:x2}),e", 0x03cbfd, 4) },
                { SyntaxParser.RRC, new Instruction("rrc (iy+${0:x2}),e", 0x0bcbfd, 4) },
                { SyntaxParser.RL,  new Instruction("rl (iy+${0:x2}),e", 0x13cbfd, 4) },
                { SyntaxParser.RR,  new Instruction("rr (iy+${0:x2}),e", 0x1bcbfd, 4) },
                { SyntaxParser.SLA, new Instruction("sla (iy+${0:x2}),e", 0x23cbfd, 4) },
                { SyntaxParser.SRA, new Instruction("sra (iy+${0:x2}),e", 0x2bcbfd, 4) },
                { SyntaxParser.SLL, new Instruction("sll (iy+${0:x2}),e", 0x33cbfd, 4) },
                { SyntaxParser.SRL, new Instruction("srl (iy+${0:x2}),e", 0x3bcbfd, 4) },
                { SyntaxParser.LD,  new Instruction("ld (iy+${0:x2}),e", 0x73fd, 3) }
            }
        },
        {
            Z80Modes.IndIY0OffsH1, new Dictionary<int, Instruction>()
            {
                { SyntaxParser.RLC, new Instruction("rlc (iy+${0:x2}),h", 0x04cbfd, 4) },
                { SyntaxParser.RRC, new Instruction("rrc (iy+${0:x2}),h", 0x0ccbfd, 4) },
                { SyntaxParser.RL,  new Instruction("rl (iy+${0:x2}),h", 0x14cbfd, 4) },
                { SyntaxParser.RR,  new Instruction("rr (iy+${0:x2}),h", 0x1ccbfd, 4) },
                { SyntaxParser.SLA, new Instruction("sla (iy+${0:x2}),h", 0x24cbfd, 4) },
                { SyntaxParser.SRA, new Instruction("sra (iy+${0:x2}),h", 0x2ccbfd, 4) },
                { SyntaxParser.SLL, new Instruction("sll (iy+${0:x2}),h", 0x34cbfd, 4) },
                { SyntaxParser.SRL, new Instruction("srl (iy+${0:x2}),h", 0x3ccbfd, 4) },
                { SyntaxParser.LD,  new Instruction("ld (iy+${0:x2}),h", 0x74fd, 3) }
            }
        },
        {
            Z80Modes.IndIY0OffsL1, new Dictionary<int, Instruction>()
            {
                { SyntaxParser.RLC, new Instruction("rlc (iy+${0:x2}),l", 0x05cbfd, 4) },
                { SyntaxParser.RRC, new Instruction("rrc (iy+${0:x2}),l", 0x0dcbfd, 4) },
                { SyntaxParser.RL,  new Instruction("rl (iy+${0:x2}),l", 0x15cbfd, 4) },
                { SyntaxParser.RR,  new Instruction("rr (iy+${0:x2}),l", 0x1dcbfd, 4) },
                { SyntaxParser.SLA, new Instruction("sla (iy+${0:x2}),l", 0x25cbfd, 4) },
                { SyntaxParser.SRA, new Instruction("sra (iy+${0:x2}),l", 0x2dcbfd, 4) },
                { SyntaxParser.SLL, new Instruction("sll (iy+${0:x2}),l", 0x35cbfd, 4) },
                { SyntaxParser.SRL, new Instruction("srl (iy+${0:x2}),l", 0x3dcbfd, 4) },
                { SyntaxParser.LD,  new Instruction("ld (iy+${0:x2}),l", 0x75fd, 3) }
            }
        },
        {
            Z80Modes.IndIY0OffsN81, new Dictionary<int, Instruction>() { { SyntaxParser.LD, new Instruction("ld (iy+${0:x2}),${1:x2}", 0x36fd, 4) } }
        },
        {
            Z80Modes.IndN160A1, new Dictionary<int, Instruction>() { { SyntaxParser.LD, new Instruction("ld (${0:x4}),a", 0x32, 3) } }
        },
        {
            Z80Modes.IndN160BC1, new Dictionary<int, Instruction>() { { SyntaxParser.LD, new Instruction("ld (${0:x4}),bc", 0x43ed, 4) } }
        },
        {
            Z80Modes.IndN160DE1, new Dictionary<int, Instruction>() { { SyntaxParser.LD, new Instruction("ld (${0:x4}),de", 0x53ed, 4) } }
        },
        {
            Z80Modes.IndN160HL1, new Dictionary<int, Instruction>() { { SyntaxParser.LD, new Instruction("ld (${0:x4}),hl", 0x22, 3) } }
        },
        {
            Z80Modes.IndN160IX1, new Dictionary<int, Instruction>() { { SyntaxParser.LD, new Instruction("ld (${0:x4}),ix", 0x22dd, 4) } }
        },
        {
            Z80Modes.IndN160IY1, new Dictionary<int, Instruction>() { { SyntaxParser.LD, new Instruction("ld (${0:x4}),iy", 0x22fd, 4) } }
        },
        {
            Z80Modes.IndN160SP1, new Dictionary<int, Instruction>() { { SyntaxParser.LD, new Instruction("ld (${0:x4}),sp", 0x73ed, 4) } }
        },
        {
            Z80Modes.IndN80A1, new Dictionary<int, Instruction>() { { SyntaxParser.OUT, new Instruction("out (${0:x2}),a", 0xd3, 2) } }
        },
        {
            Z80Modes.IndSP0HL1, new Dictionary<int, Instruction>() { { SyntaxParser.EX, new Instruction("ex (sp),hl", 0xe3, 1) } }
        },
        {
            Z80Modes.IndSP0IX1, new Dictionary<int, Instruction>() { { SyntaxParser.EX, new Instruction("ex (sp),ix", 0xe3dd, 2) } }
        },
        {
            Z80Modes.IndSP0IY1, new Dictionary<int, Instruction>() { { SyntaxParser.EX, new Instruction("ex (sp),iy", 0xe3fd, 2) } }
        },
        {
            Z80Modes.L0, new Dictionary<int, Instruction>()
            {
                { SyntaxParser.INC, new Instruction("inc l", 0x2c, 1) },
                { SyntaxParser.DEC, new Instruction("dec l", 0x2d, 1) },
                { SyntaxParser.ADD, new Instruction("add l", 0x85, 1) },
                { SyntaxParser.ADC, new Instruction("adc l", 0x8d, 1) },
                { SyntaxParser.SUB, new Instruction("sub l", 0x95, 1) },
                { SyntaxParser.AND, new Instruction("and l", 0xa5, 1) },
                { SyntaxParser.XOR, new Instruction("xor l", 0xad, 1) },
                { SyntaxParser.OR,  new Instruction("or l", 0xb5, 1) },
                { SyntaxParser.CP,  new Instruction("cp l", 0xbd, 1) },
                { SyntaxParser.RLC, new Instruction("rlc l", 0x05cb, 2) },
                { SyntaxParser.RRC, new Instruction("rrc l", 0x0dcb, 2) },
                { SyntaxParser.RL,  new Instruction("rl l", 0x15cb, 2) },
                { SyntaxParser.RR,  new Instruction("rr l", 0x1dcb, 2) },
                { SyntaxParser.SLA, new Instruction("sla l", 0x25cb, 2) },
                { SyntaxParser.SRA, new Instruction("sra l", 0x2dcb, 2) },
                { SyntaxParser.SLL, new Instruction("sll l", 0x35cb, 2) },
                { SyntaxParser.SRL, new Instruction("srl l", 0x3dcb, 2) }
            }
        },
        {
            Z80Modes.L0A1, new Dictionary<int, Instruction>() { { SyntaxParser.LD, new Instruction("ld l,a", 0x6f, 1) } }
        },
        {
            Z80Modes.L0B1, new Dictionary<int, Instruction>() { { SyntaxParser.LD, new Instruction("ld l,b", 0x68, 1) } }
        },
        {
            Z80Modes.L0C1, new Dictionary<int, Instruction>() { { SyntaxParser.LD, new Instruction("ld l,c", 0x69, 1) } }
        },
        {
            Z80Modes.L0D1, new Dictionary<int, Instruction>() { { SyntaxParser.LD, new Instruction("ld l,d", 0x6a, 1) } }
        },
        {
            Z80Modes.L0E1, new Dictionary<int, Instruction>() { { SyntaxParser.LD, new Instruction("ld l,e", 0x6b, 1) } }
        },
        {
            Z80Modes.L0H1, new Dictionary<int, Instruction>() { { SyntaxParser.LD, new Instruction("ld l,h", 0x6c, 1) } }
        },
        {
            Z80Modes.L0IndC1, new Dictionary<int, Instruction>() { { SyntaxParser.IN, new Instruction("in l,(c)", 0x68ed, 2) } }
        },
        {
            Z80Modes.L0IndHL1, new Dictionary<int, Instruction>() { { SyntaxParser.LD, new Instruction("ld l,(hl)", 0x6e, 1) } }
        },
        {
            Z80Modes.L0IndIX1Offs, new Dictionary<int, Instruction>() { { SyntaxParser.LD, new Instruction("ld l,(ix+${0:x2})", 0x6edd, 3) } }
        },
        {
            Z80Modes.L0IndIY1Offs, new Dictionary<int, Instruction>() { { SyntaxParser.LD, new Instruction("ld l,(iy+${0:x2})", 0x6efd, 3) } }
        },
        {
            Z80Modes.L0L1, new Dictionary<int, Instruction>() { { SyntaxParser.LD, new Instruction("ld l,l", 0x6d, 1) } }
        },
        {
            Z80Modes.L0N81, new Dictionary<int, Instruction>() { { SyntaxParser.LD, new Instruction("ld l,${0:x2}", 0x2e, 2) } }
        },
        {
            Z80Modes.M0, new Dictionary<int, Instruction>() { { SyntaxParser.RET, new Instruction("ret m", 0xf8, 1) } }
        },
        {
            Z80Modes.M0N81, new Dictionary<int, Instruction>()
            {
                { SyntaxParser.JP,   new Instruction("jp m,${0:x4}", 0xfa, 3) },
                { SyntaxParser.CALL, new Instruction("call m,${0:x4}", 0xfc, 3) }
            }
        },
        {
            Z80Modes.M0N161, new Dictionary<int, Instruction>()
            {
                { SyntaxParser.JP,   new Instruction("jp m,${0:x4}", 0xfa, 3) },
                { SyntaxParser.CALL, new Instruction("call m,${0:x4}", 0xfc, 3) }
            }
        },
        {
            Z80Modes.N160, new Dictionary<int, Instruction>()
            {
                { SyntaxParser.DJNZ, new Instruction("djnz ${0:x4}", 0x10, 2, true) },
                { SyntaxParser.JR,   new Instruction("jr ${0:x4}", 0x18, 2, true) },
                { SyntaxParser.JP,   new Instruction("jp ${0:x4}", 0xc3, 3) },
                { SyntaxParser.CALL, new Instruction("call ${0:x4}", 0xcd, 3) }
            }
        },
        {
            Z80Modes.N80, new Dictionary<int, Instruction>()
            {
                { SyntaxParser.SUB,  new Instruction("sub ${0:x2}", 0xd6, 2) },
                { SyntaxParser.RST,  new Instruction("rst ${0:x2}", 0xdf, 1) },
                { SyntaxParser.AND,  new Instruction("and ${0:x2}", 0xe6, 2) },
                { SyntaxParser.XOR,  new Instruction("xor ${0:x2}", 0xee, 2) },
                { SyntaxParser.OR,   new Instruction("or ${0:x2}", 0xf6, 2) },
                { SyntaxParser.CP,   new Instruction("cp ${0:x2}", 0xfe, 2) },
                { SyntaxParser.DJNZ, new Instruction("djnz ${0:x4}", 0x10, 2, true) },
                { SyntaxParser.JR,   new Instruction("jr ${0:x4}", 0x18, 2, true) },
                { SyntaxParser.JP,   new Instruction("jp ${0:x4}", 0xc3, 3) },
                { SyntaxParser.CALL, new Instruction("call ${0:x4}", 0xcd, 3) }
            }
        },
        {
            Z80Modes.NC, new Dictionary<int, Instruction>() { { SyntaxParser.RET, new Instruction("ret nc", 0xd0, 1) } }
        },
        {
            Z80Modes.NC0N161, new Dictionary<int, Instruction>()
            {
                { SyntaxParser.JR,   new Instruction("jr nc,${0:x4}", 0x30, 2, true) },
                { SyntaxParser.JP,   new Instruction("jp nc,${0:x4}", 0xd2, 3) },
                { SyntaxParser.CALL, new Instruction("call nc,${0:x4}", 0xd4, 3) }
            }
        },
        {
            Z80Modes.NZ, new Dictionary<int, Instruction>() { { SyntaxParser.RET, new Instruction("ret nz", 0xc0, 1) } }
        },
        {
            Z80Modes.NZ0N161, new Dictionary<int, Instruction>()
            {
                { SyntaxParser.JR,   new Instruction("jr nz,${0:x4}", 0x20, 2, true) },
                { SyntaxParser.JP,   new Instruction("jp nz,${0:x4}", 0xc2, 3) },
                { SyntaxParser.CALL, new Instruction("call nz,${0:x4}", 0xc4, 3) }
            }
        },
        {
            Z80Modes.P, new Dictionary<int, Instruction>() { { SyntaxParser.RET, new Instruction("ret p", 0xf0, 1) } }
        },
        {
            Z80Modes.P0N81, new Dictionary<int, Instruction>()
            {
                { SyntaxParser.JP,   new Instruction("jp p,${0:x4}", 0xf2, 3) },
                { SyntaxParser.CALL, new Instruction("call p,${0:x4}", 0xf4, 3) }
            }
        },
        {
            Z80Modes.P0N161, new Dictionary<int, Instruction>()
            {
                { SyntaxParser.JP,   new Instruction("jp p,${0:x4}", 0xf2, 3) },
                { SyntaxParser.CALL, new Instruction("call p,${0:x4}", 0xf4, 3) }
            }
        },
        {
            Z80Modes.PE, new Dictionary<int, Instruction>() { { SyntaxParser.RET, new Instruction("ret pe", 0xe8, 1) } }
        },
        {
            Z80Modes.PE0N81, new Dictionary<int, Instruction>()
            {
                { SyntaxParser.JP,   new Instruction("jp pe,${0:x4}", 0xea, 3) },
                { SyntaxParser.CALL, new Instruction("call pe,${0:x4}", 0xec, 3) }
            }
        },
        {
            Z80Modes.PE0N161, new Dictionary<int, Instruction>()
            {
                { SyntaxParser.JP,   new Instruction("jp pe,${0:x4}", 0xea, 3) },
                { SyntaxParser.CALL, new Instruction("call pe,${0:x4}", 0xec, 3) }
            }
        },
        {
            Z80Modes.PO, new Dictionary<int, Instruction>() { { SyntaxParser.RET, new Instruction("ret po", 0xe0, 1) } }
        },
         {
            Z80Modes.PO0N81, new Dictionary<int, Instruction>()
            {
                { SyntaxParser.JP,   new Instruction("jp po,${0:x4}", 0xe2, 3) },
                { SyntaxParser.CALL, new Instruction("call po,${0:x4}", 0xe4, 3) }
            }
        },
        {
            Z80Modes.PO0N161, new Dictionary<int, Instruction>()
            {
                { SyntaxParser.JP,   new Instruction("jp po,${0:x4}", 0xe2, 3) },
                { SyntaxParser.CALL, new Instruction("call po,${0:x4}", 0xe4, 3) }
            }
        },
        {
            Z80Modes.R0A1, new Dictionary<int, Instruction>() { { SyntaxParser.LD, new Instruction("ld r,a", 0x4fed, 2) } }
        },
        {
            Z80Modes.SP0, new Dictionary<int, Instruction>()
            {
                { SyntaxParser.INC, new Instruction("inc sp", 0x33, 1) },
                { SyntaxParser.DEC, new Instruction("dec sp", 0x3b, 1) }
            }
        },
        {
            Z80Modes.SP0HL1, new Dictionary<int, Instruction>() { { SyntaxParser.LD, new Instruction("ld sp,hl", 0xf9, 1) } }
        },
        {
            Z80Modes.SP0IX1, new Dictionary<int, Instruction>() { { SyntaxParser.LD, new Instruction("ld sp,ix", 0xf9dd, 2) } }
        },
        {
            Z80Modes.SP0IY1, new Dictionary<int, Instruction>() { { SyntaxParser.LD, new Instruction("ld sp,iy", 0xf9fd, 2) } }
        },
        {
            Z80Modes.SP0IndN161, new Dictionary<int, Instruction>() { { SyntaxParser.LD, new Instruction("ld sp,(${0:x4})", 0x7bed, 4) } }
        },
        {
            Z80Modes.SP0N161, new Dictionary<int, Instruction>() { { SyntaxParser.LD, new Instruction("ld sp,${0:x4}", 0x31, 3) } }
        },
        {
            Z80Modes.Z, new Dictionary<int, Instruction>() { { SyntaxParser.RET, new Instruction("ret z", 0xc8, 1) } }
        },
        {
            Z80Modes.Z0N161, new Dictionary<int, Instruction>()
            {
                { SyntaxParser.JR, new Instruction("jr z,${0:x4}", 0x28, 2, true) },
                { SyntaxParser.JP, new Instruction("jp z,${0:x4}", 0xca, 3) },
                { SyntaxParser.CALL, new Instruction("call z,${0:x4}", 0xcc, 3) }
            }
        },
    };

    private static readonly Dictionary<int, Instruction> s_z80AllOpcodes = new()
    {
        { 0x00, new Instruction("nop", 0x00,    1) },
        { 0x01, new Instruction("ld bc,${0:x4}", 0x01,    3) },
        { 0x02, new Instruction("ld (bc),a", 0x02,    1) },
        { 0x03, new Instruction("inc bc", 0x03,    1) },
        { 0x04, new Instruction("inc b", 0x04,    1) },
        { 0x05, new Instruction("dec b", 0x05,    1) },
        { 0x06, new Instruction("ld b,${0:x2}", 0x06,    2) },
        { 0x07, new Instruction("rlca", 0x07,    1) },
        { 0x08, new Instruction("ex af,af'", 0x08,    1) },
        { 0x09, new Instruction("add hl,bc", 0x09,    1) },
        { 0x0a, new Instruction("ld a,(bc)", 0x0a,    1) },
        { 0x0b, new Instruction("dec bc", 0x0b,    1) },
        { 0x0c, new Instruction("inc c", 0x0c,    1) },
        { 0x0d, new Instruction("dec c", 0x0d,    1) },
        { 0x0e, new Instruction("ld c,${0:x2}", 0x0e,    2) },
        { 0x0f, new Instruction("rrca", 0x0f,    1) },
        { 0x10, new Instruction("djnz ${0:x4}", 0x10,    2, true) },
        { 0x11, new Instruction("ld de,${0:x4}", 0x11,    3) },
        { 0x12, new Instruction("ld (de),a", 0x12,    1) },
        { 0x13, new Instruction("inc de", 0x13,    1) },
        { 0x14, new Instruction("inc d", 0x14,    1) },
        { 0x15, new Instruction("dec d", 0x15,    1) },
        { 0x16, new Instruction("ld d,${0:x2}", 0x16,    2) },
        { 0x17, new Instruction("rla", 0x17,    1) },
        { 0x18, new Instruction("jr ${0:x4}", 0x18,    2, true) },
        { 0x19, new Instruction("add hl,de", 0x19,    1) },
        { 0x1a, new Instruction("ld a,(de)", 0x1a,    1) },
        { 0x1b, new Instruction("dec de", 0x1b,    1) },
        { 0x1c, new Instruction("inc e", 0x1c,    1) },
        { 0x1d, new Instruction("dec e", 0x1d,    1) },
        { 0x1e, new Instruction("ld e,${0:x2}", 0x1e,    2) },
        { 0x1f, new Instruction("rra", 0x1f,    1) },
        { 0x20, new Instruction("jr nz,${0:x4}", 0x20,    2, true) },
        { 0x21, new Instruction("ld hl,${0:x4}", 0x21,    3) },
        { 0x22, new Instruction("ld (${0:x4}),hl", 0x22,    3) },
        { 0x23, new Instruction("inc hl", 0x23,    1) },
        { 0x24, new Instruction("inc h", 0x24,    1) },
        { 0x25, new Instruction("dec h", 0x25,    1) },
        { 0x26, new Instruction("ld h,${0:x2}", 0x26,    2) },
        { 0x27, new Instruction("daa", 0x27,    1) },
        { 0x28, new Instruction("jr z,${0:x4}", 0x28,    2, true) },
        { 0x29, new Instruction("add hl,hl", 0x29,    1) },
        { 0x2a, new Instruction("ld hl,(${0:x4})", 0x2a,    3) },
        { 0x2b, new Instruction("dec hl", 0x2b,    1) },
        { 0x2c, new Instruction("inc l", 0x2c,    1) },
        { 0x2d, new Instruction("dec l", 0x2d,    1) },
        { 0x2e, new Instruction("ld l,${0:x2}", 0x2e,    2) },
        { 0x2f, new Instruction("cpl", 0x2f,    1) },
        { 0x30, new Instruction("jr nc,${0:x4}", 0x30,    2, true) },
        { 0x31, new Instruction("ld sp,${0:x4}", 0x31,    3) },
        { 0x32, new Instruction("ld (${0:x4}),a", 0x32,    3) },
        { 0x33, new Instruction("inc sp", 0x33,    1) },
        { 0x34, new Instruction("inc (hl)", 0x34,    1) },
        { 0x35, new Instruction("dec (hl)", 0x35,    1) },
        { 0x36, new Instruction("ld (hl),${0:x2}", 0x36,    2) },
        { 0x37, new Instruction("scf", 0x37,    1) },
        { 0x38, new Instruction("jr c,${0:x4}", 0x38,    2, true) },
        { 0x39, new Instruction("add hl,sp", 0x39,    1) },
        { 0x3a, new Instruction("ld a,(${0:x4})", 0x3a,    3) },
        { 0x3b, new Instruction("dec sp", 0x3b,    1) },
        { 0x3c, new Instruction("inc a", 0x3c,    1) },
        { 0x3d, new Instruction("dec a", 0x3d,    1) },
        { 0x3e, new Instruction("ld a,${0:x2}", 0x3e,    2) },
        { 0x3f, new Instruction("ccf", 0x3f,    1) },
        { 0x40, new Instruction("ld b,b", 0x40,    1) },
        { 0x41, new Instruction("ld b,c", 0x41,    1) },
        { 0x42, new Instruction("ld b,d", 0x42,    1) },
        { 0x43, new Instruction("ld b,e", 0x43,    1) },
        { 0x44, new Instruction("ld b,h", 0x44,    1) },
        { 0x45, new Instruction("ld b,l", 0x45,    1) },
        { 0x46, new Instruction("ld b,(hl)", 0x46,    1) },
        { 0x47, new Instruction("ld b,a", 0x47,    1) },
        { 0x48, new Instruction("ld c,b", 0x48,    1) },
        { 0x49, new Instruction("ld c,c", 0x49,    1) },
        { 0x4a, new Instruction("ld c,d", 0x4a,    1) },
        { 0x4b, new Instruction("ld c,e", 0x4b,    1) },
        { 0x4c, new Instruction("ld c,h", 0x4c,    1) },
        { 0x4d, new Instruction("ld c,l", 0x4d,    1) },
        { 0x4e, new Instruction("ld c,(hl)", 0x4e,    1) },
        { 0x4f, new Instruction("ld c,a", 0x4f,    1) },
        { 0x50, new Instruction("ld d,b", 0x50,    1) },
        { 0x51, new Instruction("ld d,c", 0x51,    1) },
        { 0x52, new Instruction("ld d,d", 0x52,    1) },
        { 0x53, new Instruction("ld d,e", 0x53,    1) },
        { 0x54, new Instruction("ld d,h", 0x54,    1) },
        { 0x55, new Instruction("ld d,l", 0x55,    1) },
        { 0x56, new Instruction("ld d,(hl)", 0x56,    1) },
        { 0x57, new Instruction("ld d,a", 0x57,    1) },
        { 0x58, new Instruction("ld e,b", 0x58,    1) },
        { 0x59, new Instruction("ld e,c", 0x59,    1) },
        { 0x5a, new Instruction("ld e,d", 0x5a,    1) },
        { 0x5b, new Instruction("ld e,e", 0x5b,    1) },
        { 0x5c, new Instruction("ld e,h", 0x5c,    1) },
        { 0x5d, new Instruction("ld e,l", 0x5d,    1) },
        { 0x5e, new Instruction("ld e,(hl)", 0x5e,    1) },
        { 0x5f, new Instruction("ld e,a", 0x5f,    1) },
        { 0x60, new Instruction("ld h,b", 0x60,    1) },
        { 0x61, new Instruction("ld h,c", 0x61,    1) },
        { 0x62, new Instruction("ld h,d", 0x62,    1) },
        { 0x63, new Instruction("ld h,e", 0x63,    1) },
        { 0x64, new Instruction("ld h,h", 0x64,    1) },
        { 0x65, new Instruction("ld h,l", 0x65,    1) },
        { 0x66, new Instruction("ld h,(hl)", 0x66,    1) },
        { 0x67, new Instruction("ld h,a", 0x67,    1) },
        { 0x68, new Instruction("ld l,b", 0x68,    1) },
        { 0x69, new Instruction("ld l,c", 0x69,    1) },
        { 0x6a, new Instruction("ld l,d", 0x6a,    1) },
        { 0x6b, new Instruction("ld l,e", 0x6b,    1) },
        { 0x6c, new Instruction("ld l,h", 0x6c,    1) },
        { 0x6d, new Instruction("ld l,l", 0x6d,    1) },
        { 0x6e, new Instruction("ld l,(hl)", 0x6e,    1) },
        { 0x6f, new Instruction("ld l,a", 0x6f,    1) },
        { 0x70, new Instruction("ld (hl),b", 0x70,    1) },
        { 0x71, new Instruction("ld (hl),c", 0x71,    1) },
        { 0x72, new Instruction("ld (hl),d", 0x72,    1) },
        { 0x73, new Instruction("ld (hl),e", 0x73,    1) },
        { 0x74, new Instruction("ld (hl),h", 0x74,    1) },
        { 0x75, new Instruction("ld (hl),l", 0x75,    1) },
        { 0x76, new Instruction("halt", 0x76,    1) },
        { 0x77, new Instruction("ld (hl),a", 0x77,    1) },
        { 0x78, new Instruction("ld a,b", 0x78,    1) },
        { 0x79, new Instruction("ld a,c", 0x79,    1) },
        { 0x7a, new Instruction("ld a,d", 0x7a,    1) },
        { 0x7b, new Instruction("ld a,e", 0x7b,    1) },
        { 0x7c, new Instruction("ld a,h", 0x7c,    1) },
        { 0x7d, new Instruction("ld a,l", 0x7d,    1) },
        { 0x7e, new Instruction("ld a,(hl)", 0x7e,    1) },
        { 0x7f, new Instruction("ld a,a", 0x7f,    1) },
        { 0x80, new Instruction("add b", 0x80,    1) },
        { 0x81, new Instruction("add c", 0x81,    1) },
        { 0x82, new Instruction("add d", 0x82,    1) },
        { 0x83, new Instruction("add e", 0x83,    1) },
        { 0x84, new Instruction("add h", 0x84,    1) },
        { 0x85, new Instruction("add l", 0x85,    1) },
        { 0x86, new Instruction("add (hl)", 0x86,    1) },
        { 0x87, new Instruction("add a", 0x87,    1) },
        { 0x88, new Instruction("adc b", 0x88,    1) },
        { 0x89, new Instruction("adc c", 0x89,    1) },
        { 0x8a, new Instruction("adc d", 0x8a,    1) },
        { 0x8b, new Instruction("adc e", 0x8b,    1) },
        { 0x8c, new Instruction("adc h", 0x8c,    1) },
        { 0x8d, new Instruction("adc l", 0x8d,    1) },
        { 0x8e, new Instruction("adc (hl)", 0x8e,    1) },
        { 0x8f, new Instruction("adc a", 0x8f,    1) },
        { 0x90, new Instruction("sub b", 0x90,    1) },
        { 0x91, new Instruction("sub c", 0x91,    1) },
        { 0x92, new Instruction("sub d", 0x92,    1) },
        { 0x93, new Instruction("sub e", 0x93,    1) },
        { 0x94, new Instruction("sub h", 0x94,    1) },
        { 0x95, new Instruction("sub l", 0x95,    1) },
        { 0x96, new Instruction("sub (hl)", 0x96,    1) },
        { 0x97, new Instruction("sub a", 0x97,    1) },
        { 0x98, new Instruction("sbc a,b", 0x98,    1) },
        { 0x99, new Instruction("sbc a,c", 0x99,    1) },
        { 0x9a, new Instruction("sbc a,d", 0x9a,    1) },
        { 0x9b, new Instruction("sbc a,e", 0x9b,    1) },
        { 0x9c, new Instruction("sbc a,h", 0x9c,    1) },
        { 0x9d, new Instruction("sbc a,l", 0x9d,    1) },
        { 0x9e, new Instruction("sbc a,(hl)", 0x9e,    1) },
        { 0x9f, new Instruction("sbc a,a", 0x9f,    1) },
        { 0xa0, new Instruction("and a,b", 0xa0,    1) },
        { 0xa1, new Instruction("and a,c", 0xa1,    1) },
        { 0xa2, new Instruction("and a,d", 0xa2,    1) },
        { 0xa3, new Instruction("and a,e", 0xa3,    1) },
        { 0xa4, new Instruction("and a,h", 0xa4,    1) },
        { 0xa5, new Instruction("and a,l", 0xa5,    1) },
        { 0xa6, new Instruction("and a,(hl)", 0xa6,    1) },
        { 0xa7, new Instruction("and a,a", 0xa7,    1) },
        { 0xa8, new Instruction("xor a,b", 0xa8,    1) },
        { 0xa9, new Instruction("xor a,c", 0xa9,    1) },
        { 0xaa, new Instruction("xor a,d", 0xaa,    1) },
        { 0xab, new Instruction("xor a,e", 0xab,    1) },
        { 0xac, new Instruction("xor a,h", 0xac,    1) },
        { 0xad, new Instruction("xor a,l", 0xad,    1) },
        { 0xae, new Instruction("xor a,(hl)", 0xae,    1) },
        { 0xaf, new Instruction("xor a,a", 0xaf,    1) },
        { 0xb0, new Instruction("or a,b", 0xb0,    1) },
        { 0xb1, new Instruction("or a,c", 0xb1,    1) },
        { 0xb2, new Instruction("or a,d", 0xb2,    1) },
        { 0xb3, new Instruction("or a,e", 0xb3,    1) },
        { 0xb4, new Instruction("or a,h", 0xb4,    1) },
        { 0xb5, new Instruction("or a,l", 0xb5,    1) },
        { 0xb6, new Instruction("or a,(hl)", 0xb6,    1) },
        { 0xb7, new Instruction("or a,a", 0xb7,    1) },
        { 0xb8, new Instruction("cp a,b", 0xb8,    1) },
        { 0xb9, new Instruction("cp a,c", 0xb9,    1) },
        { 0xba, new Instruction("cp a,d", 0xba,    1) },
        { 0xbb, new Instruction("cp a,e", 0xbb,    1) },
        { 0xbc, new Instruction("cp a,h", 0xbc,    1) },
        { 0xbd, new Instruction("cp a,l", 0xbd,    1) },
        { 0xbe, new Instruction("cp a,(hl)", 0xbe,    1) },
        { 0xbf, new Instruction("cp a,a", 0xbf,    1) },
        { 0xc0, new Instruction("ret nz", 0xc0,    1) },
        { 0xc1, new Instruction("pop bc", 0xc1,    1) },
        { 0xc2, new Instruction("jp nz,${0:x4}", 0xc2,    3) },
        { 0xc3, new Instruction("jp ${0:x4}", 0xc3,    3) },
        { 0xc4, new Instruction("call nz,${0:x4}", 0xc4,    3) },
        { 0xc5, new Instruction("push bc", 0xc5,    1) },
        { 0xc6, new Instruction("add a,${0:x2}", 0xc6,    2) },
        { 0xc7, new Instruction("rst $00", 0xc7, 1) },
        { 0xc8, new Instruction("ret z", 0xc8,    1) },
        { 0xc9, new Instruction("ret", 0xc9,    1) },
        { 0xca, new Instruction("jp z,${0:x4}", 0xca,    3) },
        { 0xcc, new Instruction("call z,${0:x4}", 0xcc,    3) },
        { 0xcd, new Instruction("call ${0:x4}", 0xcd,    3) },
        { 0xce, new Instruction("adc a,${0:x2}", 0xce,    2) },
        { 0xcf, new Instruction("rst $08", 0xcf, 1) },
        { 0xd0, new Instruction("ret nc", 0xd0,    1) },
        { 0xd1, new Instruction("pop de", 0xd1,    1) },
        { 0xd2, new Instruction("jp nc,${0:x4}", 0xd2,    3) },
        { 0xd3, new Instruction("out (${0:x2}),a", 0xd3,    2) },
        { 0xd4, new Instruction("call nc,${0:x4}", 0xd4,    3) },
        { 0xd5, new Instruction("push de", 0xd5,    1) },
        { 0xd6, new Instruction("sub ${0:x2}", 0xd6,    2) },
        { 0xd7, new Instruction("rst $10", 0xd7, 1) },
        { 0xd8, new Instruction("ret c", 0xd8,    1) },
        { 0xd9, new Instruction("exx", 0xd9,    1) },
        { 0xda, new Instruction("jp c,${0:x4}", 0xda,    3) },
        { 0xdb, new Instruction("in a,(${0:x2})", 0xdb,    2) },
        { 0xdc, new Instruction("call c,${0:x4}", 0xdc,    3) },
        { 0xde, new Instruction("sbc a,${0:x2}", 0xde,    2) },
        { 0xdf, new Instruction("rst $18", 0xdf,    1) },
        { 0xe0, new Instruction("ret po", 0xe0,    1) },
        { 0xe1, new Instruction("pop hl", 0xe1,    1) },
        { 0xe2, new Instruction("jp po,${0:x4}", 0xe2,    3) },
        { 0xe3, new Instruction("ex (sp),hl", 0xe3,    1) },
        { 0xe4, new Instruction("call p,${0:x4}", 0xe4,    3) },
        { 0xe5, new Instruction("push hl", 0xe5,    1) },
        { 0xe6, new Instruction("and ${0:x2}", 0xe6,    2) },
        { 0xe7, new Instruction("rst $20", 0xe7, 1) },
        { 0xe8, new Instruction("ret pe", 0xe8,    1) },
        { 0xe9, new Instruction("jp (hl)", 0xe9,    1) },
        { 0xea, new Instruction("jp pe,${0:x4}", 0xea,    3) },
        { 0xeb, new Instruction("ex de,hl", 0xeb,    1) },
        { 0xec, new Instruction("call p,${0:x4}", 0xec,    3) },
        { 0xee, new Instruction("xor ${0:x2}", 0xee,    2) },
        { 0xef, new Instruction("rst $28", 0xef, 1) },
        { 0xf0, new Instruction("ret p", 0xf0,    1) },
        { 0xf1, new Instruction("pop af", 0xf1,    1) },
        { 0xf2, new Instruction("jp p,${0:x4}", 0xf2,    3) },
        { 0xf3, new Instruction("di", 0xf3,    1) },
        { 0xf4, new Instruction("call p,${0:x4}", 0xf4,    3) },
        { 0xf5, new Instruction("push af", 0xf5,    1) },
        { 0xf6, new Instruction("or ${0:x2}", 0xf6,    2) },
        { 0xf7, new Instruction("rst $30", 0xf7, 1) },
        { 0xf8, new Instruction("ret m", 0xf8,    1) },
        { 0xf9, new Instruction("ld sp,hl", 0xf9,    1) },
        { 0xfa, new Instruction("jp m,${0:x4}", 0xfa,    3) },
        { 0xfb, new Instruction("ei", 0xfb,    1) },
        { 0xfc, new Instruction("call m,${0:x4}", 0xfc,    3) },
        { 0xfe, new Instruction("cp ${0:x2}", 0xfe,    2) },
        { 0xff, new Instruction("rst $38", 0xff, 1) },
        { 0x00cb, new Instruction("rlc b", 0x00cb,   2) },
        { 0x01cb, new Instruction("rlc c", 0x01cb,   2) },
        { 0x02cb, new Instruction("rlc d", 0x02cb,   2) },
        { 0x03cb, new Instruction("rlc e", 0x03cb,   2) },
        { 0x04cb, new Instruction("rlc h", 0x04cb,   2) },
        { 0x05cb, new Instruction("rlc l", 0x05cb,   2) },
        { 0x06cb, new Instruction("rlc (hl)", 0x06cb,   2) },
        { 0x07cb, new Instruction("rlc a", 0x07cb,   2) },
        { 0x08cb, new Instruction("rrc b", 0x08cb,   2) },
        { 0x09cb, new Instruction("rrc c", 0x09cb,   2) },
        { 0x0acb, new Instruction("rrc d", 0x0acb,   2) },
        { 0x0bcb, new Instruction("rrc e", 0x0bcb,   2) },
        { 0x0ccb, new Instruction("rrc h", 0x0ccb,   2) },
        { 0x0dcb, new Instruction("rrc l", 0x0dcb,   2) },
        { 0x0ecb, new Instruction("rrc (hl)", 0x0ecb,   2) },
        { 0x0fcb, new Instruction("rrc a", 0x0fcb,   2) },
        { 0x10cb, new Instruction("rl b", 0x10cb,   2) },
        { 0x11cb, new Instruction("rl c", 0x11cb,   2) },
        { 0x12cb, new Instruction("rl d", 0x12cb,   2) },
        { 0x13cb, new Instruction("rl e", 0x13cb,   2) },
        { 0x14cb, new Instruction("rl h", 0x14cb,   2) },
        { 0x15cb, new Instruction("rl l", 0x15cb,   2) },
        { 0x16cb, new Instruction("rl (hl)", 0x16cb,   2) },
        { 0x17cb, new Instruction("rl a", 0x17cb,   2) },
        { 0x18cb, new Instruction("rr b", 0x18cb,   2) },
        { 0x19cb, new Instruction("rr c", 0x19cb,   2) },
        { 0x1acb, new Instruction("rr d", 0x1acb,   2) },
        { 0x1bcb, new Instruction("rr e", 0x1bcb,   2) },
        { 0x1ccb, new Instruction("rr h", 0x1ccb,   2) },
        { 0x1dcb, new Instruction("rr l", 0x1dcb,   2) },
        { 0x1ecb, new Instruction("rr (hl)", 0x1ecb,   2) },
        { 0x1fcb, new Instruction("rr a", 0x1fcb,   2) },
        { 0x20cb, new Instruction("sla b", 0x20cb,   2) },
        { 0x21cb, new Instruction("sla c", 0x21cb,   2) },
        { 0x22cb, new Instruction("sla d", 0x22cb,   2) },
        { 0x23cb, new Instruction("sla e", 0x23cb,   2) },
        { 0x24cb, new Instruction("sla h", 0x24cb,   2) },
        { 0x25cb, new Instruction("sla l", 0x25cb,   2) },
        { 0x26cb, new Instruction("sla (hl)", 0x26cb,   2) },
        { 0x27cb, new Instruction("sla a", 0x27cb,   2) },
        { 0x28cb, new Instruction("sra b", 0x28cb,   2) },
        { 0x29cb, new Instruction("sra c", 0x29cb,   2) },
        { 0x2acb, new Instruction("sra d", 0x2acb,   2) },
        { 0x2bcb, new Instruction("sra e", 0x2bcb,   2) },
        { 0x2ccb, new Instruction("sra h", 0x2ccb,   2) },
        { 0x2dcb, new Instruction("sra l", 0x2dcb,   2) },
        { 0x2ecb, new Instruction("sra (hl)", 0x2ecb,   2) },
        { 0x2fcb, new Instruction("sra a", 0x2fcb,   2) },
        { 0x30cb, new Instruction("sll b", 0x30cb,   2) },
        { 0x31cb, new Instruction("sll c", 0x31cb,   2) },
        { 0x32cb, new Instruction("sll d", 0x32cb,   2) },
        { 0x33cb, new Instruction("sll e", 0x33cb,   2) },
        { 0x34cb, new Instruction("sll h", 0x34cb,   2) },
        { 0x35cb, new Instruction("sll l", 0x35cb,   2) },
        { 0x36cb, new Instruction("sll (hl)", 0x36cb,   2) },
        { 0x37cb, new Instruction("sll a", 0x37cb,   2) },
        { 0x38cb, new Instruction("srl b", 0x38cb,   2) },
        { 0x39cb, new Instruction("srl c", 0x39cb,   2) },
        { 0x3acb, new Instruction("srl d", 0x3acb,   2) },
        { 0x3bcb, new Instruction("srl e", 0x3bcb,   2) },
        { 0x3ccb, new Instruction("srl h", 0x3ccb,   2) },
        { 0x3dcb, new Instruction("srl l", 0x3dcb,   2) },
        { 0x3ecb, new Instruction("srl (hl)", 0x3ecb,   2) },
        { 0x3fcb, new Instruction("srl a", 0x3fcb,   2) },
        { 0x40ed, new Instruction("in b,(c)", 0x40ed,   2) },
        { 0x41ed, new Instruction("out (c),b", 0x41ed,   2) },
        { 0x42ed, new Instruction("sbc hl,bc", 0x42ed,   2) },
        { 0x43ed, new Instruction("ld (${0:x4}),bc", 0x43ed,   4) },
        { 0x44ed, new Instruction("neg", 0x44ed,   2) },
        { 0x45ed, new Instruction("retn", 0x45ed,   2) },
        { 0x46ed, new Instruction("im 0", 0x46ed, 2) },
        { 0x47ed, new Instruction("ld i,a", 0x47ed,   2) },
        { 0x48ed, new Instruction("in c,(c)", 0x48ed,   2) },
        { 0x49ed, new Instruction("out (c),c", 0x49ed,   2) },
        { 0x4aed, new Instruction("adc hl,bc", 0x4aed,   2) },
        { 0x4bed, new Instruction("ld bc,(${0:x4})", 0x4bed,   4) },
        { 0x4ded, new Instruction("reti", 0x4ded,   2) },
        { 0x4fed, new Instruction("ld r,a", 0x4fed,   2) },
        { 0x50ed, new Instruction("in d,(c)", 0x50ed,   2) },
        { 0x51ed, new Instruction("out (c),d", 0x51ed,   2) },
        { 0x52ed, new Instruction("sbc hl,de", 0x52ed,   2) },
        { 0x53ed, new Instruction("ld (${0:x4}),de", 0x53ed,   4) },
        { 0x56ed, new Instruction("im 1", 0x56ed, 2) },
        { 0x57ed, new Instruction("ld a,i", 0x57ed,   2) },
        { 0x58ed, new Instruction("in e,(c)", 0x58ed,   2) },
        { 0x59ed, new Instruction("out (c),e", 0x59ed,   2) },
        { 0x5aed, new Instruction("adc hl,de", 0x5aed,   2) },
        { 0x5bed, new Instruction("ld de,(${0:x4})", 0x5bed,   4) },
        { 0x5eed, new Instruction("im 2", 0x5eed, 2) },
        { 0x5fed, new Instruction("ld a,r", 0x5fed,   2) },
        { 0x60ed, new Instruction("in h,(c)", 0x60ed,   2) },
        { 0x61ed, new Instruction("out (c),h", 0x61ed,   2) },
        { 0x62ed, new Instruction("sbc hl,hl", 0x62ed,   2) },
        { 0x67ed, new Instruction("rrd", 0x67ed,   2) },
        { 0x68ed, new Instruction("in l,(c)", 0x68ed,   2) },
        { 0x69ed, new Instruction("out (c),l", 0x69ed,   2) },
        { 0x6aed, new Instruction("adc hl,hl", 0x6aed,   2) },
        { 0x6fed, new Instruction("rld", 0x6fed,   2) },
        { 0x70ed, new Instruction("in (c)", 0x70ed,   2) },
        { 0x71ed, new Instruction("out (c),0", 0x71ed,   2) },
        { 0x72ed, new Instruction("sbc hl,sp", 0x72ed,   2) },
        { 0x73ed, new Instruction("ld (${0:x4}),sp", 0x73ed,   4) },
        { 0x78ed, new Instruction("in a,(c)", 0x78ed,   2) },
        { 0x79ed, new Instruction("out (c),a", 0x79ed,   2) },
        { 0x7aed, new Instruction("adc hl,sp", 0x7aed,   2) },
        { 0x7bed, new Instruction("ld sp,(${0:x4})", 0x7bed,   4) },
        { 0xa0ed, new Instruction("ldi", 0xa0ed,   2) },
        { 0xa1ed, new Instruction("cpi", 0xa1ed,   2) },
        { 0xa2ed, new Instruction("ini", 0xa2ed,   2) },
        { 0xa3ed, new Instruction("outi", 0xa3ed,   2) },
        { 0xa8ed, new Instruction("ldd", 0xa8ed,   2) },
        { 0xa9ed, new Instruction("cpd", 0xa9ed,   2) },
        { 0xaaed, new Instruction("ind", 0xaaed,   2) },
        { 0xabed, new Instruction("outd", 0xabed,   2) },
        { 0xb0ed, new Instruction("ldir", 0xb0ed,   2) },
        { 0xb1ed, new Instruction("cpir", 0xb1ed,   2) },
        { 0xb2ed, new Instruction("inir", 0xb2ed,   2) },
        { 0xb3ed, new Instruction("otir", 0xb3ed,   2) },
        { 0xb8ed, new Instruction("lddr", 0xb8ed,   2) },
        { 0xb9ed, new Instruction("cpdr", 0xb9ed,   2) },
        { 0xbaed, new Instruction("indr", 0xbaed,   2) },
        { 0xbbed, new Instruction("otdr", 0xbbed,   2) },
        { 0x00cbdd, new Instruction("rlc (ix+${0:x2}),b", 0x00cbdd, 4) },
        { 0x01cbdd, new Instruction("rlc (ix+${0:x2}),c", 0x01cbdd, 4) },
        { 0x02cbdd, new Instruction("rlc (ix+${0:x2}),d", 0x02cbdd, 4) },
        { 0x03cbdd, new Instruction("rlc (ix+${0:x2}),e", 0x03cbdd, 4) },
        { 0x04cbdd, new Instruction("rlc (ix+${0:x2}),h", 0x04cbdd, 4) },
        { 0x05cbdd, new Instruction("rlc (ix+${0:x2}),l", 0x05cbdd, 4) },
        { 0x06cbdd, new Instruction("rlc (ix+${0:x2})", 0x06cbdd, 4) },
        { 0x07cbdd, new Instruction("rlc (ix+${0:x2}),a", 0x07cbdd, 4) },
        { 0x08cbdd, new Instruction("rrc (ix+${0:x2}),b", 0x08cbdd, 4) },
        { 0x09cbdd, new Instruction("rrc (ix+${0:x2}),c", 0x09cbdd, 4) },
        { 0x0acbdd, new Instruction("rrc (ix+${0:x2}),d", 0x0acbdd, 4) },
        { 0x0bcbdd, new Instruction("rrc (ix+${0:x2}),e", 0x0bcbdd, 4) },
        { 0x0ccbdd, new Instruction("rrc (ix+${0:x2}),h", 0x0ccbdd, 4) },
        { 0x0dcbdd, new Instruction("rrc (ix+${0:x2}),l", 0x0dcbdd, 4) },
        { 0x0ecbdd, new Instruction("rrc (ix+${0:x2})", 0x0ecbdd, 4) },
        { 0x0fcbdd, new Instruction("rrc (ix+${0:x2}),a", 0x0fcbdd, 4) },
        { 0x10cbdd, new Instruction("rl (ix+${0:x2}),b", 0x10cbdd, 4) },
        { 0x11cbdd, new Instruction("rl (ix+${0:x2}),c", 0x11cbdd, 4) },
        { 0x12cbdd, new Instruction("rl (ix+${0:x2}),d", 0x12cbdd, 4) },
        { 0x13cbdd, new Instruction("rl (ix+${0:x2}),e", 0x13cbdd, 4) },
        { 0x14cbdd, new Instruction("rl (ix+${0:x2}),h", 0x14cbdd, 4) },
        { 0x15cbdd, new Instruction("rl (ix+${0:x2}),l", 0x15cbdd, 4) },
        { 0x16cbdd, new Instruction("rl (ix+${0:x2})", 0x16cbdd, 4) },
        { 0x17cbdd, new Instruction("rl (ix+${0:x2}),a", 0x17cbdd, 4) },
        { 0x18cbdd, new Instruction("rr (ix+${0:x2}),b", 0x18cbdd, 4) },
        { 0x19cbdd, new Instruction("rr (ix+${0:x2}),c", 0x19cbdd, 4) },
        { 0x1acbdd, new Instruction("rr (ix+${0:x2}),d", 0x1acbdd, 4) },
        { 0x1bcbdd, new Instruction("rr (ix+${0:x2}),e", 0x1bcbdd, 4) },
        { 0x1ccbdd, new Instruction("rr (ix+${0:x2}),h", 0x1ccbdd, 4) },
        { 0x1dcbdd, new Instruction("rr (ix+${0:x2}),l", 0x1dcbdd, 4) },
        { 0x1ecbdd, new Instruction("rr (ix+${0:x2})", 0x1ecbdd, 4) },
        { 0x1fcbdd, new Instruction("rr (ix+${0:x2}),a", 0x1fcbdd, 4) },
        { 0x20cbdd, new Instruction("sla (ix+${0:x2}),b", 0x20cbdd, 4) },
        { 0x21cbdd, new Instruction("sla (ix+${0:x2}),c", 0x21cbdd, 4) },
        { 0x22cbdd, new Instruction("sla (ix+${0:x2}),d", 0x22cbdd, 4) },
        { 0x23cbdd, new Instruction("sla (ix+${0:x2}),e", 0x23cbdd, 4) },
        { 0x24cbdd, new Instruction("sla (ix+${0:x2}),h", 0x24cbdd, 4) },
        { 0x25cbdd, new Instruction("sla (ix+${0:x2}),l", 0x25cbdd, 4) },
        { 0x26cbdd, new Instruction("sla (ix+${0:x2})", 0x26cbdd, 4) },
        { 0x27cbdd, new Instruction("sla (ix+${0:x2}),a", 0x27cbdd, 4) },
        { 0x28cbdd, new Instruction("sra (ix+${0:x2}),b", 0x28cbdd, 4) },
        { 0x29cbdd, new Instruction("sra (ix+${0:x2}),c", 0x29cbdd, 4) },
        { 0x2acbdd, new Instruction("sra (ix+${0:x2}),d", 0x2acbdd, 4) },
        { 0x2bcbdd, new Instruction("sra (ix+${0:x2}),e", 0x2bcbdd, 4) },
        { 0x2ccbdd, new Instruction("sra (ix+${0:x2}),h", 0x2ccbdd, 4) },
        { 0x2dcbdd, new Instruction("sra (ix+${0:x2}),l", 0x2dcbdd, 4) },
        { 0x2ecbdd, new Instruction("sra (ix+${0:x2})", 0x2ecbdd, 4) },
        { 0x2fcbdd, new Instruction("sra (ix+${0:x2}),a", 0x2fcbdd, 4) },
        { 0x30cbdd, new Instruction("sll (ix+${0:x2}),b", 0x30cbdd, 4) },
        { 0x31cbdd, new Instruction("sll (ix+${0:x2}),c", 0x31cbdd, 4) },
        { 0x32cbdd, new Instruction("sll (ix+${0:x2}),d", 0x32cbdd, 4) },
        { 0x33cbdd, new Instruction("sll (ix+${0:x2}),e", 0x33cbdd, 4) },
        { 0x34cbdd, new Instruction("sll (ix+${0:x2}),h", 0x34cbdd, 4) },
        { 0x35cbdd, new Instruction("sll (ix+${0:x2}),l", 0x35cbdd, 4) },
        { 0x36cbdd, new Instruction("sll (ix+${0:x2})", 0x36cbdd, 4) },
        { 0x37cbdd, new Instruction("sll (ix+${0:x2}),a", 0x37cbdd, 4) },
        { 0x38cbdd, new Instruction("srl (ix+${0:x2}),b", 0x38cbdd, 4) },
        { 0x39cbdd, new Instruction("srl (ix+${0:x2}),c", 0x39cbdd, 4) },
        { 0x3acbdd, new Instruction("srl (ix+${0:x2}),d", 0x3acbdd, 4) },
        { 0x3bcbdd, new Instruction("srl (ix+${0:x2}),e", 0x3bcbdd, 4) },
        { 0x3ccbdd, new Instruction("srl (ix+${0:x2}),h", 0x3ccbdd, 4) },
        { 0x3dcbdd, new Instruction("srl (ix+${0:x2}),l", 0x3dcbdd, 4) },
        { 0x3ecbdd, new Instruction("srl (ix+${0:x2})", 0x3ecbdd, 4) },
        { 0x3fcbdd, new Instruction("srl (ix+${0:x2}),a", 0x3fcbdd, 4) },
        { 0x00cbfd, new Instruction("rlc (iy+${0:x2}),b", 0x00cbfd, 4) },
        { 0x01cbfd, new Instruction("rlc (iy+${0:x2}),c", 0x01cbfd, 4) },
        { 0x02cbfd, new Instruction("rlc (iy+${0:x2}),d", 0x02cbfd, 4) },
        { 0x03cbfd, new Instruction("rlc (iy+${0:x2}),e", 0x03cbfd, 4) },
        { 0x04cbfd, new Instruction("rlc (iy+${0:x2}),h", 0x04cbfd, 4) },
        { 0x05cbfd, new Instruction("rlc (iy+${0:x2}),l", 0x05cbfd, 4) },
        { 0x06cbfd, new Instruction("rlc (iy+${0:x2})", 0x06cbfd, 4) },
        { 0x07cbfd, new Instruction("rlc (iy+${0:x2}),a", 0x07cbfd, 4) },
        { 0x08cbfd, new Instruction("rrc (iy+${0:x2}),b", 0x08cbfd, 4) },
        { 0x09cbfd, new Instruction("rrc (iy+${0:x2}),c", 0x09cbfd, 4) },
        { 0x0acbfd, new Instruction("rrc (iy+${0:x2}),d", 0x0acbfd, 4) },
        { 0x0bcbfd, new Instruction("rrc (iy+${0:x2}),e", 0x0bcbfd, 4) },
        { 0x0ccbfd, new Instruction("rrc (iy+${0:x2}),h", 0x0ccbfd, 4) },
        { 0x0dcbfd, new Instruction("rrc (iy+${0:x2}),l", 0x0dcbfd, 4) },
        { 0x0ecbfd, new Instruction("rrc (iy+${0:x2})", 0x0ecbfd, 4) },
        { 0x0fcbfd, new Instruction("rrc (iy+${0:x2}),a", 0x0fcbfd, 4) },
        { 0x10cbfd, new Instruction("rl (iy+${0:x2}),b", 0x10cbfd, 4) },
        { 0x11cbfd, new Instruction("rl (iy+${0:x2}),c", 0x11cbfd, 4) },
        { 0x12cbfd, new Instruction("rl (iy+${0:x2}),d", 0x12cbfd, 4) },
        { 0x13cbfd, new Instruction("rl (iy+${0:x2}),e", 0x13cbfd, 4) },
        { 0x14cbfd, new Instruction("rl (iy+${0:x2}),h", 0x14cbfd, 4) },
        { 0x15cbfd, new Instruction("rl (iy+${0:x2}),l", 0x15cbfd, 4) },
        { 0x16cbfd, new Instruction("rl (iy+${0:x2})", 0x16cbfd, 4) },
        { 0x17cbfd, new Instruction("rl (iy+${0:x2}),a", 0x17cbfd, 4) },
        { 0x18cbfd, new Instruction("rr (iy+${0:x2}),b", 0x18cbfd, 4) },
        { 0x19cbfd, new Instruction("rr (iy+${0:x2}),c", 0x19cbfd, 4) },
        { 0x1acbfd, new Instruction("rr (iy+${0:x2}),d", 0x1acbfd, 4) },
        { 0x1bcbfd, new Instruction("rr (iy+${0:x2}),e", 0x1bcbfd, 4) },
        { 0x1ccbfd, new Instruction("rr (iy+${0:x2}),h", 0x1ccbfd, 4) },
        { 0x1dcbfd, new Instruction("rr (iy+${0:x2}),l", 0x1dcbfd, 4) },
        { 0x1ecbfd, new Instruction("rr (iy+${0:x2})", 0x1ecbfd, 4) },
        { 0x1fcbfd, new Instruction("rr (iy+${0:x2}),a", 0x1fcbfd, 4) },
        { 0x20cbfd, new Instruction("sla (iy+${0:x2}),b", 0x20cbfd, 4) },
        { 0x21cbfd, new Instruction("sla (iy+${0:x2}),c", 0x21cbfd, 4) },
        { 0x22cbfd, new Instruction("sla (iy+${0:x2}),d", 0x22cbfd, 4) },
        { 0x23cbfd, new Instruction("sla (iy+${0:x2}),e", 0x23cbfd, 4) },
        { 0x24cbfd, new Instruction("sla (iy+${0:x2}),h", 0x24cbfd, 4) },
        { 0x25cbfd, new Instruction("sla (iy+${0:x2}),l", 0x25cbfd, 4) },
        { 0x26cbfd, new Instruction("sla (iy+${0:x2})", 0x26cbfd, 4) },
        { 0x27cbfd, new Instruction("sla (iy+${0:x2}),a", 0x27cbfd, 4) },
        { 0x28cbfd, new Instruction("sra (iy+${0:x2}),b", 0x28cbfd, 4) },
        { 0x29cbfd, new Instruction("sra (iy+${0:x2}),c", 0x29cbfd, 4) },
        { 0x2acbfd, new Instruction("sra (iy+${0:x2}),d", 0x2acbfd, 4) },
        { 0x2bcbfd, new Instruction("sra (iy+${0:x2}),e", 0x2bcbfd, 4) },
        { 0x2ccbfd, new Instruction("sra (iy+${0:x2}),h", 0x2ccbfd, 4) },
        { 0x2dcbfd, new Instruction("sra (iy+${0:x2}),l", 0x2dcbfd, 4) },
        { 0x2ecbfd, new Instruction("sra (iy+${0:x2})", 0x2ecbfd, 4) },
        { 0x2fcbfd, new Instruction("sra (iy+${0:x2}),a", 0x2fcbfd, 4) },
        { 0x30cbfd, new Instruction("sll (iy+${0:x2}),b", 0x30cbfd, 4) },
        { 0x31cbfd, new Instruction("sll (iy+${0:x2}),c", 0x31cbfd, 4) },
        { 0x32cbfd, new Instruction("sll (iy+${0:x2}),d", 0x32cbfd, 4) },
        { 0x33cbfd, new Instruction("sll (iy+${0:x2}),e", 0x33cbfd, 4) },
        { 0x34cbfd, new Instruction("sll (iy+${0:x2}),h", 0x34cbfd, 4) },
        { 0x35cbfd, new Instruction("sll (iy+${0:x2}),l", 0x35cbfd, 4) },
        { 0x36cbfd, new Instruction("sll (iy+${0:x2})", 0x36cbfd, 4) },
        { 0x37cbfd, new Instruction("sll (iy+${0:x2}),a", 0x37cbfd, 4) },
        { 0x38cbfd, new Instruction("srl (iy+${0:x2}),b", 0x38cbfd, 4) },
        { 0x39cbfd, new Instruction("srl (iy+${0:x2}),c", 0x39cbfd, 4) },
        { 0x3acbfd, new Instruction("srl (iy+${0:x2}),d", 0x3acbfd, 4) },
        { 0x3bcbfd, new Instruction("srl (iy+${0:x2}),e", 0x3bcbfd, 4) },
        { 0x3ccbfd, new Instruction("srl (iy+${0:x2}),h", 0x3ccbfd, 4) },
        { 0x3dcbfd, new Instruction("srl (iy+${0:x2}),l", 0x3dcbfd, 4) },
        { 0x3ecbfd, new Instruction("srl (iy+${0:x2})", 0x3ecbfd, 4) },
        { 0x3fcbfd, new Instruction("srl (iy+${0:x2}),a", 0x3fcbfd, 4) },
        { 0x40cb, new Instruction("bit 0,b", 0x40cb, 2) },
        { 0x41cb, new Instruction("bit 0,c", 0x41cb, 2) },
        { 0x42cb, new Instruction("bit 0,d", 0x42cb, 2) },
        { 0x43cb, new Instruction("bit 0,e", 0x43cb, 2) },
        { 0x44cb, new Instruction("bit 0,h", 0x44cb, 2) },
        { 0x45cb, new Instruction("bit 0,l", 0x45cb, 2) },
        { 0x46cb, new Instruction("bit 0,(hl)", 0x46cb, 2) },
        { 0x47cb, new Instruction("bit 0,a", 0x47cb, 2) },
        { 0x48cb, new Instruction("bit 1,b", 0x48cb, 2) },
        { 0x49cb, new Instruction("bit 1,c", 0x49cb, 2) },
        { 0x4acb, new Instruction("bit 1,d", 0x4acb, 2) },
        { 0x4bcb, new Instruction("bit 1,e", 0x4bcb, 2) },
        { 0x4ccb, new Instruction("bit 1,h", 0x4ccb, 2) },
        { 0x4dcb, new Instruction("bit 1,l", 0x4dcb, 2) },
        { 0x4ecb, new Instruction("bit 1,(hl)", 0x4ecb, 2) },
        { 0x4fcb, new Instruction("bit 1,a", 0x4fcb, 2) },
        { 0x50cb, new Instruction("bit 2,b", 0x50cb, 2) },
        { 0x51cb, new Instruction("bit 2,c", 0x51cb, 2) },
        { 0x52cb, new Instruction("bit 2,d", 0x52cb, 2) },
        { 0x53cb, new Instruction("bit 2,e", 0x53cb, 2) },
        { 0x54cb, new Instruction("bit 2,h", 0x54cb, 2) },
        { 0x55cb, new Instruction("bit 2,l", 0x55cb, 2) },
        { 0x56cb, new Instruction("bit 2,(hl)", 0x56cb, 2) },
        { 0x57cb, new Instruction("bit 2,a", 0x57cb, 2) },
        { 0x58cb, new Instruction("bit 3,b", 0x58cb, 2) },
        { 0x59cb, new Instruction("bit 3,c", 0x59cb, 2) },
        { 0x5acb, new Instruction("bit 3,d", 0x5acb, 2) },
        { 0x5bcb, new Instruction("bit 3,e", 0x5bcb, 2) },
        { 0x5ccb, new Instruction("bit 3,h", 0x5ccb, 2) },
        { 0x5dcb, new Instruction("bit 3,l", 0x5dcb, 2) },
        { 0x5ecb, new Instruction("bit 3,(hl)", 0x5ecb, 2) },
        { 0x5fcb, new Instruction("bit 3,a", 0x5fcb, 2) },
        { 0x60cb, new Instruction("bit 4,b", 0x60cb, 2) },
        { 0x61cb, new Instruction("bit 4,c", 0x61cb, 2) },
        { 0x62cb, new Instruction("bit 4,d", 0x62cb, 2) },
        { 0x63cb, new Instruction("bit 4,e", 0x63cb, 2) },
        { 0x64cb, new Instruction("bit 4,h", 0x64cb, 2) },
        { 0x65cb, new Instruction("bit 4,l", 0x65cb, 2) },
        { 0x66cb, new Instruction("bit 4,(hl)", 0x66cb, 2) },
        { 0x67cb, new Instruction("bit 4,a", 0x67cb, 2) },
        { 0x68cb, new Instruction("bit 5,b", 0x68cb, 2) },
        { 0x69cb, new Instruction("bit 5,c", 0x69cb, 2) },
        { 0x6acb, new Instruction("bit 5,d", 0x6acb, 2) },
        { 0x6bcb, new Instruction("bit 5,e", 0x6bcb, 2) },
        { 0x6ccb, new Instruction("bit 5,h", 0x6ccb, 2) },
        { 0x6dcb, new Instruction("bit 5,l", 0x6dcb, 2) },
        { 0x6ecb, new Instruction("bit 5,(hl)", 0x6ecb, 2) },
        { 0x6fcb, new Instruction("bit 5,a", 0x6fcb, 2) },
        { 0x70cb, new Instruction("bit 6,b", 0x70cb, 2) },
        { 0x71cb, new Instruction("bit 6,c", 0x71cb, 2) },
        { 0x72cb, new Instruction("bit 6,d", 0x72cb, 2) },
        { 0x73cb, new Instruction("bit 6,e", 0x73cb, 2) },
        { 0x74cb, new Instruction("bit 6,h", 0x74cb, 2) },
        { 0x75cb, new Instruction("bit 6,l", 0x75cb, 2) },
        { 0x76cb, new Instruction("bit 6,(hl)", 0x76cb, 2) },
        { 0x77cb, new Instruction("bit 6,a", 0x77cb, 2) },
        { 0x78cb, new Instruction("bit 7,b", 0x78cb, 2) },
        { 0x79cb, new Instruction("bit 7,c", 0x79cb, 2) },
        { 0x7acb, new Instruction("bit 7,d", 0x7acb, 2) },
        { 0x7bcb, new Instruction("bit 7,e", 0x7bcb, 2) },
        { 0x7ccb, new Instruction("bit 7,h", 0x7ccb, 2) },
        { 0x7dcb, new Instruction("bit 7,l", 0x7dcb, 2) },
        { 0x7ecb, new Instruction("bit 7,(hl)", 0x7ecb, 2) },
        { 0x7fcb, new Instruction("bit 7,a", 0x7fcb, 2) },
        { 0x80cb, new Instruction("res 0,b", 0x80cb, 2) },
        { 0x81cb, new Instruction("res 0,c", 0x81cb, 2) },
        { 0x82cb, new Instruction("res 0,d", 0x82cb, 2) },
        { 0x83cb, new Instruction("res 0,e", 0x83cb, 2) },
        { 0x84cb, new Instruction("res 0,h", 0x84cb, 2) },
        { 0x85cb, new Instruction("res 0,l", 0x85cb, 2) },
        { 0x86cb, new Instruction("res 0,(hl)", 0x86cb, 2) },
        { 0x87cb, new Instruction("res 0,a", 0x87cb, 2) },
        { 0x88cb, new Instruction("res 1,b", 0x88cb, 2) },
        { 0x89cb, new Instruction("res 1,c", 0x89cb, 2) },
        { 0x8acb, new Instruction("res 1,d", 0x8acb, 2) },
        { 0x8bcb, new Instruction("res 1,e", 0x8bcb, 2) },
        { 0x8ccb, new Instruction("res 1,h", 0x8ccb, 2) },
        { 0x8dcb, new Instruction("res 1,l", 0x8dcb, 2) },
        { 0x8ecb, new Instruction("res 1,(hl)", 0x8ecb, 2) },
        { 0x8fcb, new Instruction("res 1,a", 0x8fcb, 2) },
        { 0x90cb, new Instruction("res 2,b", 0x90cb, 2) },
        { 0x91cb, new Instruction("res 2,c", 0x91cb, 2) },
        { 0x92cb, new Instruction("res 2,d", 0x92cb, 2) },
        { 0x93cb, new Instruction("res 2,e", 0x93cb, 2) },
        { 0x94cb, new Instruction("res 2,h", 0x94cb, 2) },
        { 0x95cb, new Instruction("res 2,l", 0x95cb, 2) },
        { 0x96cb, new Instruction("res 2,(hl)", 0x96cb, 2) },
        { 0x97cb, new Instruction("res 2,a", 0x97cb, 2) },
        { 0x98cb, new Instruction("res 3,b", 0x98cb, 2) },
        { 0x99cb, new Instruction("res 3,c", 0x99cb, 2) },
        { 0x9acb, new Instruction("res 3,d", 0x9acb, 2) },
        { 0x9bcb, new Instruction("res 3,e", 0x9bcb, 2) },
        { 0x9ccb, new Instruction("res 3,h", 0x9ccb, 2) },
        { 0x9dcb, new Instruction("res 3,l", 0x9dcb, 2) },
        { 0x9ecb, new Instruction("res 3,(hl)", 0x9ecb, 2) },
        { 0x9fcb, new Instruction("res 3,a", 0x9fcb, 2) },
        { 0xa0cb, new Instruction("res 4,b", 0xa0cb, 2) },
        { 0xa1cb, new Instruction("res 4,c", 0xa1cb, 2) },
        { 0xa2cb, new Instruction("res 4,d", 0xa2cb, 2) },
        { 0xa3cb, new Instruction("res 4,e", 0xa3cb, 2) },
        { 0xa4cb, new Instruction("res 4,h", 0xa4cb, 2) },
        { 0xa5cb, new Instruction("res 4,l", 0xa5cb, 2) },
        { 0xa6cb, new Instruction("res 4,(hl)", 0xa6cb, 2) },
        { 0xa7cb, new Instruction("res 4,a", 0xa7cb, 2) },
        { 0xa8cb, new Instruction("res 5,b", 0xa8cb, 2) },
        { 0xa9cb, new Instruction("res 5,c", 0xa9cb, 2) },
        { 0xaacb, new Instruction("res 5,d", 0xaacb, 2) },
        { 0xabcb, new Instruction("res 5,e", 0xabcb, 2) },
        { 0xaccb, new Instruction("res 5,h", 0xaccb, 2) },
        { 0xadcb, new Instruction("res 5,l", 0xadcb, 2) },
        { 0xaecb, new Instruction("res 5,(hl)", 0xaecb, 2) },
        { 0xafcb, new Instruction("res 5,a", 0xafcb, 2) },
        { 0xb0cb, new Instruction("res 6,b", 0xb0cb, 2) },
        { 0xb1cb, new Instruction("res 6,c", 0xb1cb, 2) },
        { 0xb2cb, new Instruction("res 6,d", 0xb2cb, 2) },
        { 0xb3cb, new Instruction("res 6,e", 0xb3cb, 2) },
        { 0xb4cb, new Instruction("res 6,h", 0xb4cb, 2) },
        { 0xb5cb, new Instruction("res 6,l", 0xb5cb, 2) },
        { 0xb6cb, new Instruction("res 6,(hl)", 0xb6cb, 2) },
        { 0xb7cb, new Instruction("res 6,a", 0xb7cb, 2) },
        { 0xb8cb, new Instruction("res 7,b", 0xb8cb, 2) },
        { 0xb9cb, new Instruction("res 7,c", 0xb9cb, 2) },
        { 0xbacb, new Instruction("res 7,d", 0xbacb, 2) },
        { 0xbbcb, new Instruction("res 7,e", 0xbbcb, 2) },
        { 0xbccb, new Instruction("res 7,h", 0xbccb, 2) },
        { 0xbdcb, new Instruction("res 7,l", 0xbdcb, 2) },
        { 0xbecb, new Instruction("res 7,(hl)", 0xbecb, 2) },
        { 0xbfcb, new Instruction("res 7,a", 0xbfcb, 2) },
        { 0xc0cb, new Instruction("set 0,b", 0xc0cb, 2) },
        { 0xc1cb, new Instruction("set 0,c", 0xc1cb, 2) },
        { 0xc2cb, new Instruction("set 0,d", 0xc2cb, 2) },
        { 0xc3cb, new Instruction("set 0,e", 0xc3cb, 2) },
        { 0xc4cb, new Instruction("set 0,h", 0xc4cb, 2) },
        { 0xc5cb, new Instruction("set 0,l", 0xc5cb, 2) },
        { 0xc6cb, new Instruction("set 0,(hl)", 0xc6cb, 2) },
        { 0xc7cb, new Instruction("set 0,a", 0xc7cb, 2) },
        { 0xc8cb, new Instruction("set 1,b", 0xc8cb, 2) },
        { 0xc9cb, new Instruction("set 1,c", 0xc9cb, 2) },
        { 0xcacb, new Instruction("set 1,d", 0xcacb, 2) },
        { 0xcbcb, new Instruction("set 1,e", 0xcbcb, 2) },
        { 0xcccb, new Instruction("set 1,h", 0xcccb, 2) },
        { 0xcdcb, new Instruction("set 1,l", 0xcdcb, 2) },
        { 0xcecb, new Instruction("set 1,(hl)", 0xcecb, 2) },
        { 0xcfcb, new Instruction("set 1,a", 0xcfcb, 2) },
        { 0xd0cb, new Instruction("set 2,b", 0xd0cb, 2) },
        { 0xd1cb, new Instruction("set 2,c", 0xd1cb, 2) },
        { 0xd2cb, new Instruction("set 2,d", 0xd2cb, 2) },
        { 0xd3cb, new Instruction("set 2,e", 0xd3cb, 2) },
        { 0xd4cb, new Instruction("set 2,h", 0xd4cb, 2) },
        { 0xd5cb, new Instruction("set 2,l", 0xd5cb, 2) },
        { 0xd6cb, new Instruction("set 2,(hl)", 0xd6cb, 2) },
        { 0xd7cb, new Instruction("set 2,a", 0xd7cb, 2) },
        { 0xd8cb, new Instruction("set 3,b", 0xd8cb, 2) },
        { 0xd9cb, new Instruction("set 3,c", 0xd9cb, 2) },
        { 0xdacb, new Instruction("set 3,d", 0xdacb, 2) },
        { 0xdbcb, new Instruction("set 3,e", 0xdbcb, 2) },
        { 0xdccb, new Instruction("set 3,h", 0xdccb, 2) },
        { 0xddcb, new Instruction("set 3,l", 0xddcb, 2) },
        { 0xdecb, new Instruction("set 3,(hl)", 0xdecb, 2) },
        { 0xdfcb, new Instruction("set 3,a", 0xdfcb, 2) },
        { 0xe0cb, new Instruction("set 4,b", 0xe0cb, 2) },
        { 0xe1cb, new Instruction("set 4,c", 0xe1cb, 2) },
        { 0xe2cb, new Instruction("set 4,d", 0xe2cb, 2) },
        { 0xe3cb, new Instruction("set 4,e", 0xe3cb, 2) },
        { 0xe4cb, new Instruction("set 4,h", 0xe4cb, 2) },
        { 0xe5cb, new Instruction("set 4,l", 0xe5cb, 2) },
        { 0xe6cb, new Instruction("set 4,(hl)", 0xe6cb, 2) },
        { 0xe7cb, new Instruction("set 4,a", 0xe7cb, 2) },
        { 0xe8cb, new Instruction("set 5,b", 0xe8cb, 2) },
        { 0xe9cb, new Instruction("set 5,c", 0xe9cb, 2) },
        { 0xeacb, new Instruction("set 5,d", 0xeacb, 2) },
        { 0xebcb, new Instruction("set 5,e", 0xebcb, 2) },
        { 0xeccb, new Instruction("set 5,h", 0xeccb, 2) },
        { 0xedcb, new Instruction("set 5,l", 0xedcb, 2) },
        { 0xeecb, new Instruction("set 5,(hl)", 0xeecb, 2) },
        { 0xefcb, new Instruction("set 5,a", 0xefcb, 2) },
        { 0xf0cb, new Instruction("set 6,b", 0xf0cb, 2) },
        { 0xf1cb, new Instruction("set 6,c", 0xf1cb, 2) },
        { 0xf2cb, new Instruction("set 6,d", 0xf2cb, 2) },
        { 0xf3cb, new Instruction("set 6,e", 0xf3cb, 2) },
        { 0xf4cb, new Instruction("set 6,h", 0xf4cb, 2) },
        { 0xf5cb, new Instruction("set 6,l", 0xf5cb, 2) },
        { 0xf6cb, new Instruction("set 6,(hl)", 0xf6cb, 2) },
        { 0xf7cb, new Instruction("set 6,a", 0xf7cb, 2) },
        { 0xf8cb, new Instruction("set 7,b", 0xf8cb, 2) },
        { 0xf9cb, new Instruction("set 7,c", 0xf9cb, 2) },
        { 0xfacb, new Instruction("set 7,d", 0xfacb, 2) },
        { 0xfbcb, new Instruction("set 7,e", 0xfbcb, 2) },
        { 0xfccb, new Instruction("set 7,h", 0xfccb, 2) },
        { 0xfdcb, new Instruction("set 7,l", 0xfdcb, 2) },
        { 0xfecb, new Instruction("set 7,(hl)", 0xfecb, 2) },
        { 0xffcb, new Instruction("set 7,a", 0xffcb, 2) },
        { 0x09dd, new Instruction("add ix,bc", 0x09dd,   2) },
        { 0x19dd, new Instruction("add ix,de", 0x19dd,   2) },
        { 0x21dd, new Instruction("ld ix,${0:x4}", 0x21dd,   4) },
        { 0x22dd, new Instruction("ld (${0:x4}),ix", 0x22dd,   4) },
        { 0x23dd, new Instruction("inc ix", 0x23dd,   2) },
        { 0x24dd, new Instruction("inc ixh", 0x24dd,   2) },
        { 0x25dd, new Instruction("dec ixh", 0x25dd,   2) },
        { 0x26dd, new Instruction("ld ixh,${0:x2}", 0x26dd,   3) },
        { 0x29dd, new Instruction("add ix,ix", 0x29dd,   2) },
        { 0x2add, new Instruction("ld ix,(${0:x4})", 0x2add,   4) },
        { 0x2bdd, new Instruction("dec ix", 0x2bdd,   2) },
        { 0x2cdd, new Instruction("inc ixl", 0x2cdd,   2) },
        { 0x2ddd, new Instruction("dec ixl", 0x2ddd,   2) },
        { 0x2edd, new Instruction("ld ixl,${0:x2}", 0x2edd,   3) },
        { 0x34dd, new Instruction("inc (ix+${0:x2})", 0x34dd,   3) },
        { 0x35dd, new Instruction("dec (ix+${0:x2})", 0x35dd,   3) },
        { 0x36dd, new Instruction("ld (ix+${0:x2}),${1:x2}", 0x36dd,   4) },
        { 0x39dd, new Instruction("add ix,sp", 0x39dd,   2) },
        { 0x44dd, new Instruction("ld b,ixh", 0x44dd,   2) },
        { 0x45dd, new Instruction("ld b,ixl", 0x45dd,   2) },
        { 0x46dd, new Instruction("ld b,(ix+${0:x2})", 0x46dd,   3) },
        { 0x4cdd, new Instruction("ld c,ixh", 0x4cdd,   2) },
        { 0x4ddd, new Instruction("ld c,ixl", 0x4ddd,   2) },
        { 0x4edd, new Instruction("ld c,(ix+${0:x2})", 0x4edd,   3) },
        { 0x54dd, new Instruction("ld d,ixh", 0x54dd,   2) },
        { 0x55dd, new Instruction("ld d,ixl", 0x55dd,   2) },
        { 0x56dd, new Instruction("ld d,(ix+${0:x2})", 0x56dd,   3) },
        { 0x5cdd, new Instruction("ld e,ixh", 0x5cdd,   2) },
        { 0x5ddd, new Instruction("ld e,ixl", 0x5ddd,   2) },
        { 0x5edd, new Instruction("ld e,(ix+${0:x2})", 0x5edd,   3) },
        { 0x60dd, new Instruction("ld ixh,b", 0x60dd,   2) },
        { 0x61dd, new Instruction("ld ixh,c", 0x61dd,   2) },
        { 0x62dd, new Instruction("ld ixh,d", 0x62dd,   2) },
        { 0x63dd, new Instruction("ld ixh,e", 0x63dd,   2) },
        { 0x64dd, new Instruction("ld ixh,ixh", 0x64dd,   2) },
        { 0x65dd, new Instruction("ld ixh,ixl", 0x65dd,   2) },
        { 0x66dd, new Instruction("ld h,(ix+${0:x2})", 0x66dd,   3) },
        { 0x67dd, new Instruction("ld ixh,a", 0x67dd,   2) },
        { 0x68dd, new Instruction("ld ixl,b", 0x68dd,   2) },
        { 0x69dd, new Instruction("ld ixl,c", 0x69dd,   2) },
        { 0x6add, new Instruction("ld ixl,d", 0x6add,   2) },
        { 0x6bdd, new Instruction("ld ixl,e", 0x6bdd,   2) },
        { 0x6cdd, new Instruction("ld ixl,ixh", 0x6cdd,   2) },
        { 0x6ddd, new Instruction("ld ixl,ixl", 0x6ddd,   2) },
        { 0x6edd, new Instruction("ld l,(ix+${0:x2})", 0x6edd,   3) },
        { 0x6fdd, new Instruction("ld ixl,a", 0x6fdd,   2) },
        { 0x70dd, new Instruction("ld (ix+${0:x2}),b", 0x70dd,   3) },
        { 0x71dd, new Instruction("ld (ix+${0:x2}),c", 0x71dd,   3) },
        { 0x72dd, new Instruction("ld (ix+${0:x2}),d", 0x72dd,   3) },
        { 0x73dd, new Instruction("ld (ix+${0:x2}),e", 0x73dd,   3) },
        { 0x74dd, new Instruction("ld (ix+${0:x2}),h", 0x74dd,   3) },
        { 0x75dd, new Instruction("ld (ix+${0:x2}),l", 0x75dd,   3) },
        { 0x77dd, new Instruction("ld (ix+${0:x2}),a", 0x77dd,   3) },
        { 0x7cdd, new Instruction("ld a,ixh", 0x7cdd,   2) },
        { 0x7ddd, new Instruction("ld a,ixl", 0x7ddd,   2) },
        { 0x7edd, new Instruction("ld a,(ix+${0:x2})", 0x7edd,   3) },
        { 0x84dd, new Instruction("add a,ixh", 0x84dd,   2) },
        { 0x85dd, new Instruction("add a,ixl", 0x85dd,   2) },
        { 0x86dd, new Instruction("add a,(ix+${0:x2})", 0x86dd,   3) },
        { 0x8cdd, new Instruction("adc a,ixh", 0x8cdd,   2) },
        { 0x8ddd, new Instruction("adc a,ixl", 0x8ddd,   2) },
        { 0x8edd, new Instruction("adc a,(ix+${0:x2})", 0x8edd,   3) },
        { 0x94dd, new Instruction("sub ixh", 0x94dd,   2) },
        { 0x95dd, new Instruction("sub ixl", 0x95dd,   2) },
        { 0x96dd, new Instruction("sub (ix+${0:x2})", 0x96dd,   3) },
        { 0x9cdd, new Instruction("sbc a,ixh", 0x9cdd,   2) },
        { 0x9ddd, new Instruction("sbc a,ixl", 0x9ddd,   2) },
        { 0x9edd, new Instruction("sbc a,(ix+${0:x2})", 0x9edd,   3) },
        { 0xa4dd, new Instruction("and ixh", 0xa4dd,   2) },
        { 0xa5dd, new Instruction("and ixl", 0xa5dd,   2) },
        { 0xa6dd, new Instruction("and (ix+${0:x2})", 0xa6dd,   3) },
        { 0xacdd, new Instruction("xor ixh", 0xacdd,   2) },
        { 0xaddd, new Instruction("xor ixl", 0xaddd,   2) },
        { 0xaedd, new Instruction("xor (ix+${0:x2})", 0xaedd,   3) },
        { 0xb4dd, new Instruction("or ixh", 0xb4dd,   2) },
        { 0xb5dd, new Instruction("or ixl", 0xb5dd,   2) },
        { 0xb6dd, new Instruction("or (ix+${0:x2})", 0xb6dd,   3) },
        { 0xbcdd, new Instruction("cp ixh", 0xbcdd,   2) },
        { 0xbddd, new Instruction("cp ixl", 0xbddd,   2) },
        { 0xbedd, new Instruction("cp (ix+${0:x2})", 0xbedd,   3) },
        { 0xe1dd, new Instruction("pop ix", 0xe1dd,   2) },
        { 0xe3dd, new Instruction("ex (sp),ix", 0xe3dd,   2) },
        { 0xe5dd, new Instruction("push ix", 0xe5dd,   2) },
        { 0xe9dd, new Instruction("jp (ix)", 0xe9dd,   2) },
        { 0xf9dd, new Instruction("ld sp,ix", 0xf9dd,   2) },
        { 0x09fd, new Instruction("add iy,bc", 0x09fd,   2) },
        { 0x19fd, new Instruction("add iy,de", 0x19fd,   2) },
        { 0x21fd, new Instruction("ld iy,${0:x4}", 0x21fd,   4) },
        { 0x22fd, new Instruction("ld (${0:x4}),iy", 0x22fd,   4) },
        { 0x23fd, new Instruction("inc iy", 0x23fd,   2) },
        { 0x24fd, new Instruction("inc iyh", 0x24fd,   2) },
        { 0x25fd, new Instruction("dec iyh", 0x25fd,   2) },
        { 0x26fd, new Instruction("ld iyh,${0:x2}", 0x26fd,   3) },
        { 0x29fd, new Instruction("add iy,iy", 0x29fd,   2) },
        { 0x2afd, new Instruction("ld iy,(${0:x4})", 0x2afd,   4) },
        { 0x2bfd, new Instruction("dec iy", 0x2bfd,   2) },
        { 0x2cfd, new Instruction("inc iyl", 0x2cfd,   2) },
        { 0x2dfd, new Instruction("dec iyl", 0x2dfd,   2) },
        { 0x2efd, new Instruction("ld iyl,${0:x2}", 0x2efd,   3) },
        { 0x34fd, new Instruction("inc (iy+${0:x2})", 0x34fd,   3) },
        { 0x35fd, new Instruction("dec (iy+${0:x2})", 0x35fd,   3) },
        { 0x36fd, new Instruction("ld (iy+${0:x2}),${1:x2}", 0x36fd,   4) },
        { 0x39fd, new Instruction("add iy,sp", 0x39fd,   2) },
        { 0x44fd, new Instruction("ld b,iyh", 0x44fd,   2) },
        { 0x45fd, new Instruction("ld b,iyl", 0x45fd,   2) },
        { 0x46fd, new Instruction("ld b,(iy+${0:x2})", 0x46fd,   3) },
        { 0x4cfd, new Instruction("ld c,iyh", 0x4cfd,   2) },
        { 0x4dfd, new Instruction("ld c,iyl", 0x4dfd,   2) },
        { 0x4efd, new Instruction("ld c,(iy+${0:x2})", 0x4efd,   3) },
        { 0x54fd, new Instruction("ld d,iyh", 0x54fd,   2) },
        { 0x55fd, new Instruction("ld d,iyl", 0x55fd,   2) },
        { 0x56fd, new Instruction("ld d,(iy+${0:x2})", 0x56fd,   3) },
        { 0x5cfd, new Instruction("ld e,iyh", 0x5cfd,   2) },
        { 0x5dfd, new Instruction("ld e,iyl", 0x5dfd,   2) },
        { 0x5efd, new Instruction("ld e,(iy+${0:x2})", 0x5efd,   3) },
        { 0x60fd, new Instruction("ld iyh,b", 0x60fd,   2) },
        { 0x61fd, new Instruction("ld iyh,c", 0x61fd,   2) },
        { 0x62fd, new Instruction("ld iyh,d", 0x62fd,   2) },
        { 0x63fd, new Instruction("ld iyh,e", 0x63fd,   2) },
        { 0x64fd, new Instruction("ld iyh,iyh", 0x64fd,   2) },
        { 0x65fd, new Instruction("ld iyh,iyl", 0x65fd,   2) },
        { 0x66fd, new Instruction("ld h,(iy+${0:x2})", 0x66fd,   3) },
        { 0x67fd, new Instruction("ld iyh,a", 0x67fd,   2) },
        { 0x68fd, new Instruction("ld iyl,b", 0x68fd,   2) },
        { 0x69fd, new Instruction("ld iyl,c", 0x69fd,   2) },
        { 0x6afd, new Instruction("ld iyl,d", 0x6afd,   2) },
        { 0x6bfd, new Instruction("ld iyl,e", 0x6bfd,   2) },
        { 0x6cfd, new Instruction("ld iyl,iyh", 0x6cfd,   2) },
        { 0x6dfd, new Instruction("ld iyl,iyl", 0x6dfd,   2) },
        { 0x6efd, new Instruction("ld l,(iy+${0:x2})", 0x6efd,   3) },
        { 0x6ffd, new Instruction("ld iyl,a", 0x6ffd,   2) },
        { 0x70fd, new Instruction("ld (iy+${0:x2}),b", 0x70fd,   3) },
        { 0x71fd, new Instruction("ld (iy+${0:x2}),c", 0x71fd,   3) },
        { 0x72fd, new Instruction("ld (iy+${0:x2}),d", 0x72fd,   3) },
        { 0x73fd, new Instruction("ld (iy+${0:x2}),e", 0x73fd,   3) },
        { 0x74fd, new Instruction("ld (iy+${0:x2}),h", 0x74fd,   3) },
        { 0x75fd, new Instruction("ld (iy+${0:x2}),l", 0x75fd,   3) },
        { 0x77fd, new Instruction("ld (iy+${0:x2}),a", 0x77fd,   3) },
        { 0x7cfd, new Instruction("ld a,iyh", 0x7cfd,   2) },
        { 0x7dfd, new Instruction("ld a,iyl", 0x7dfd,   2) },
        { 0x7efd, new Instruction("ld a", 0x7efd,   3) },
        { 0x84fd, new Instruction("add a,iyh", 0x84fd,   2) },
        { 0x85fd, new Instruction("add a,iyl", 0x85fd,   2) },
        { 0x86fd, new Instruction("add a,(iy+${0:x2})", 0x86fd,   3) },
        { 0x8cfd, new Instruction("adc a,iyh", 0x8cfd,   2) },
        { 0x8dfd, new Instruction("adc a,iyl", 0x8dfd,   2) },
        { 0x8efd, new Instruction("adc a,(iy+${0:x2})", 0x8efd,   3) },
        { 0x94fd, new Instruction("sub iyh", 0x94fd,   2) },
        { 0x95fd, new Instruction("sub iyl", 0x95fd,   2) },
        { 0x96fd, new Instruction("sub (iy+${0:x2})", 0x96fd,   3) },
        { 0x9cfd, new Instruction("sbc a,iyh", 0x9cfd,   2) },
        { 0x9dfd, new Instruction("sbc a,iyl", 0x9dfd,   2) },
        { 0x9efd, new Instruction("sbc a,(iy+${0:x2})", 0x9efd,   3) },
        { 0xa4fd, new Instruction("and iyh", 0xa4fd,   2) },
        { 0xa5fd, new Instruction("and iyl", 0xa5fd,   2) },
        { 0xa6fd, new Instruction("and (iy+${0:x2})", 0xa6fd,   3) },
        { 0xacfd, new Instruction("xor iyh", 0xacfd,   2) },
        { 0xadfd, new Instruction("xor iyl", 0xadfd,   2) },
        { 0xaefd, new Instruction("xor (iy+${0:x2})", 0xaefd,   3) },
        { 0xb4fd, new Instruction("or iyh", 0xb4fd,   2) },
        { 0xb5fd, new Instruction("or iyl", 0xb5fd,   2) },
        { 0xb6fd, new Instruction("or (iy+${0:x2})", 0xb6fd,   3) },
        { 0xbcfd, new Instruction("cp iyh", 0xbcfd,   2) },
        { 0xbdfd, new Instruction("cp iyl", 0xbdfd,   2) },
        { 0xbefd, new Instruction("cp (iy+${0:x2})", 0xbefd,   3) },
        { 0xe1fd, new Instruction("pop iy", 0xe1fd,   2) },
        { 0xe3fd, new Instruction("ex (sp),iy", 0xe3fd,   2) },
        { 0xe5fd, new Instruction("push iy", 0xe5fd,   2) },
        { 0xe9fd, new Instruction("jp (iy)", 0xe9fd,   2) },
        { 0xf9fd, new Instruction("ld sp,iy", 0xf9fd,   2) },
        { 0x40cbdd, new Instruction("bit 0,(ix+${0:x2}),b", 0x40cbdd, 4) },
        { 0x41cbdd, new Instruction("bit 0,(ix+${0:x2}),c", 0x41cbdd, 4) },
        { 0x42cbdd, new Instruction("bit 0,(ix+${0:x2}),d", 0x42cbdd, 4) },
        { 0x43cbdd, new Instruction("bit 0,(ix+${0:x2}),e", 0x43cbdd, 4) },
        { 0x44cbdd, new Instruction("bit 0,(ix+${0:x2}),h", 0x44cbdd, 4) },
        { 0x45cbdd, new Instruction("bit 0,(ix+${0:x2}),l", 0x45cbdd, 4) },
        { 0x46cbdd, new Instruction("bit 0,(ix+${0:x2})", 0x46cbdd, 4) },
        { 0x47cbdd, new Instruction("bit 0,(ix+${0:x2}),a", 0x47cbdd, 4) },
        { 0x48cbdd, new Instruction("bit 1,(ix+${0:x2}),b", 0x48cbdd, 4) },
        { 0x49cbdd, new Instruction("bit 1,(ix+${0:x2}),c", 0x49cbdd, 4) },
        { 0x4acbdd, new Instruction("bit 1,(ix+${0:x2}),d", 0x4acbdd, 4) },
        { 0x4bcbdd, new Instruction("bit 1,(ix+${0:x2}),e", 0x4bcbdd, 4) },
        { 0x4ccbdd, new Instruction("bit 1,(ix+${0:x2}),h", 0x4ccbdd, 4) },
        { 0x4dcbdd, new Instruction("bit 1,(ix+${0:x2}),l", 0x4dcbdd, 4) },
        { 0x4ecbdd, new Instruction("bit 1,(ix+${0:x2})", 0x4ecbdd, 4) },
        { 0x4fcbdd, new Instruction("bit 1,(ix+${0:x2}),a", 0x4fcbdd, 4) },
        { 0x50cbdd, new Instruction("bit 2,(ix+${0:x2}),b", 0x50cbdd, 4) },
        { 0x51cbdd, new Instruction("bit 2,(ix+${0:x2}),c", 0x51cbdd, 4) },
        { 0x52cbdd, new Instruction("bit 2,(ix+${0:x2}),d", 0x52cbdd, 4) },
        { 0x53cbdd, new Instruction("bit 2,(ix+${0:x2}),e", 0x53cbdd, 4) },
        { 0x54cbdd, new Instruction("bit 2,(ix+${0:x2}),h", 0x54cbdd, 4) },
        { 0x55cbdd, new Instruction("bit 2,(ix+${0:x2}),l", 0x55cbdd, 4) },
        { 0x56cbdd, new Instruction("bit 2,(ix+${0:x2})", 0x56cbdd, 4) },
        { 0x57cbdd, new Instruction("bit 2,(ix+${0:x2}),a", 0x57cbdd, 4) },
        { 0x58cbdd, new Instruction("bit 3,(ix+${0:x2}),b", 0x58cbdd, 4) },
        { 0x59cbdd, new Instruction("bit 3,(ix+${0:x2}),c", 0x59cbdd, 4) },
        { 0x5acbdd, new Instruction("bit 3,(ix+${0:x2}),d", 0x5acbdd, 4) },
        { 0x5bcbdd, new Instruction("bit 3,(ix+${0:x2}),e", 0x5bcbdd, 4) },
        { 0x5ccbdd, new Instruction("bit 3,(ix+${0:x2}),h", 0x5ccbdd, 4) },
        { 0x5dcbdd, new Instruction("bit 3,(ix+${0:x2}),l", 0x5dcbdd, 4) },
        { 0x5ecbdd, new Instruction("bit 3,(ix+${0:x2})", 0x5ecbdd, 4) },
        { 0x5fcbdd, new Instruction("bit 3,(ix+${0:x2}),a", 0x5fcbdd, 4) },
        { 0x60cbdd, new Instruction("bit 4,(ix+${0:x2}),b", 0x60cbdd, 4) },
        { 0x61cbdd, new Instruction("bit 4,(ix+${0:x2}),c", 0x61cbdd, 4) },
        { 0x62cbdd, new Instruction("bit 4,(ix+${0:x2}),d", 0x62cbdd, 4) },
        { 0x63cbdd, new Instruction("bit 4,(ix+${0:x2}),e", 0x63cbdd, 4) },
        { 0x64cbdd, new Instruction("bit 4,(ix+${0:x2}),h", 0x64cbdd, 4) },
        { 0x65cbdd, new Instruction("bit 4,(ix+${0:x2}),l", 0x65cbdd, 4) },
        { 0x66cbdd, new Instruction("bit 4,(ix+${0:x2})", 0x66cbdd, 4) },
        { 0x67cbdd, new Instruction("bit 4,(ix+${0:x2}),a", 0x67cbdd, 4) },
        { 0x68cbdd, new Instruction("bit 5,(ix+${0:x2}),b", 0x68cbdd, 4) },
        { 0x69cbdd, new Instruction("bit 5,(ix+${0:x2}),c", 0x69cbdd, 4) },
        { 0x6acbdd, new Instruction("bit 5,(ix+${0:x2}),d", 0x6acbdd, 4) },
        { 0x6bcbdd, new Instruction("bit 5,(ix+${0:x2}),e", 0x6bcbdd, 4) },
        { 0x6ccbdd, new Instruction("bit 5,(ix+${0:x2}),h", 0x6ccbdd, 4) },
        { 0x6dcbdd, new Instruction("bit 5,(ix+${0:x2}),l", 0x6dcbdd, 4) },
        { 0x6ecbdd, new Instruction("bit 5,(ix+${0:x2})", 0x6ecbdd, 4) },
        { 0x6fcbdd, new Instruction("bit 5,(ix+${0:x2}),a", 0x6fcbdd, 4) },
        { 0x70cbdd, new Instruction("bit 6,(ix+${0:x2}),b", 0x70cbdd, 4) },
        { 0x71cbdd, new Instruction("bit 6,(ix+${0:x2}),c", 0x71cbdd, 4) },
        { 0x72cbdd, new Instruction("bit 6,(ix+${0:x2}),d", 0x72cbdd, 4) },
        { 0x73cbdd, new Instruction("bit 6,(ix+${0:x2}),e", 0x73cbdd, 4) },
        { 0x74cbdd, new Instruction("bit 6,(ix+${0:x2}),h", 0x74cbdd, 4) },
        { 0x75cbdd, new Instruction("bit 6,(ix+${0:x2}),l", 0x75cbdd, 4) },
        { 0x76cbdd, new Instruction("bit 6,(ix+${0:x2})", 0x76cbdd, 4) },
        { 0x77cbdd, new Instruction("bit 6,(ix+${0:x2}),a", 0x77cbdd, 4) },
        { 0x78cbdd, new Instruction("bit 7,(ix+${0:x2}),b", 0x78cbdd, 4) },
        { 0x79cbdd, new Instruction("bit 7,(ix+${0:x2}),c", 0x79cbdd, 4) },
        { 0x7acbdd, new Instruction("bit 7,(ix+${0:x2}),d", 0x7acbdd, 4) },
        { 0x7bcbdd, new Instruction("bit 7,(ix+${0:x2}),e", 0x7bcbdd, 4) },
        { 0x7ccbdd, new Instruction("bit 7,(ix+${0:x2}),h", 0x7ccbdd, 4) },
        { 0x7dcbdd, new Instruction("bit 7,(ix+${0:x2}),l", 0x7dcbdd, 4) },
        { 0x7ecbdd, new Instruction("bit 7,(ix+${0:x2})", 0x7ecbdd, 4) },
        { 0x7fcbdd, new Instruction("bit 7,(ix+${0:x2}),a", 0x7fcbdd, 4) },
        { 0x80cbdd, new Instruction("res 0,(ix+${0:x2}),b", 0x80cbdd, 4) },
        { 0x81cbdd, new Instruction("res 0,(ix+${0:x2}),c", 0x81cbdd, 4) },
        { 0x82cbdd, new Instruction("res 0,(ix+${0:x2}),d", 0x82cbdd, 4) },
        { 0x83cbdd, new Instruction("res 0,(ix+${0:x2}),e", 0x83cbdd, 4) },
        { 0x84cbdd, new Instruction("res 0,(ix+${0:x2}),h", 0x84cbdd, 4) },
        { 0x85cbdd, new Instruction("res 0,(ix+${0:x2}),l", 0x85cbdd, 4) },
        { 0x86cbdd, new Instruction("res 0,(ix+${0:x2})", 0x86cbdd, 4) },
        { 0x87cbdd, new Instruction("res 0,(ix+${0:x2}),a", 0x87cbdd, 4) },
        { 0x88cbdd, new Instruction("res 1,(ix+${0:x2}),b", 0x88cbdd, 4) },
        { 0x89cbdd, new Instruction("res 1,(ix+${0:x2}),c", 0x89cbdd, 4) },
        { 0x8acbdd, new Instruction("res 1,(ix+${0:x2}),d", 0x8acbdd, 4) },
        { 0x8bcbdd, new Instruction("res 1,(ix+${0:x2}),e", 0x8bcbdd, 4) },
        { 0x8ccbdd, new Instruction("res 1,(ix+${0:x2}),h", 0x8ccbdd, 4) },
        { 0x8dcbdd, new Instruction("res 1,(ix+${0:x2}),l", 0x8dcbdd, 4) },
        { 0x8ecbdd, new Instruction("res 1,(ix+${0:x2})", 0x8ecbdd, 4) },
        { 0x8fcbdd, new Instruction("res 1,(ix+${0:x2}),a", 0x8fcbdd, 4) },
        { 0x90cbdd, new Instruction("res 2,(ix+${0:x2}),b", 0x90cbdd, 4) },
        { 0x91cbdd, new Instruction("res 2,(ix+${0:x2}),c", 0x91cbdd, 4) },
        { 0x92cbdd, new Instruction("res 2,(ix+${0:x2}),d", 0x92cbdd, 4) },
        { 0x93cbdd, new Instruction("res 2,(ix+${0:x2}),e", 0x93cbdd, 4) },
        { 0x94cbdd, new Instruction("res 2,(ix+${0:x2}),h", 0x94cbdd, 4) },
        { 0x95cbdd, new Instruction("res 2,(ix+${0:x2}),l", 0x95cbdd, 4) },
        { 0x96cbdd, new Instruction("res 2,(ix+${0:x2})", 0x96cbdd, 4) },
        { 0x97cbdd, new Instruction("res 2,(ix+${0:x2}),a", 0x97cbdd, 4) },
        { 0x98cbdd, new Instruction("res 3,(ix+${0:x2}),b", 0x98cbdd, 4) },
        { 0x99cbdd, new Instruction("res 3,(ix+${0:x2}),c", 0x99cbdd, 4) },
        { 0x9acbdd, new Instruction("res 3,(ix+${0:x2}),d", 0x9acbdd, 4) },
        { 0x9bcbdd, new Instruction("res 3,(ix+${0:x2}),e", 0x9bcbdd, 4) },
        { 0x9ccbdd, new Instruction("res 3,(ix+${0:x2}),h", 0x9ccbdd, 4) },
        { 0x9dcbdd, new Instruction("res 3,(ix+${0:x2}),l", 0x9dcbdd, 4) },
        { 0x9ecbdd, new Instruction("res 3,(ix+${0:x2})", 0x9ecbdd, 4) },
        { 0x9fcbdd, new Instruction("res 3,(ix+${0:x2}),a", 0x9fcbdd, 4) },
        { 0xa0cbdd, new Instruction("res 4,(ix+${0:x2}),b", 0xa0cbdd, 4) },
        { 0xa1cbdd, new Instruction("res 4,(ix+${0:x2}),c", 0xa1cbdd, 4) },
        { 0xa2cbdd, new Instruction("res 4,(ix+${0:x2}),d", 0xa2cbdd, 4) },
        { 0xa3cbdd, new Instruction("res 4,(ix+${0:x2}),e", 0xa3cbdd, 4) },
        { 0xa4cbdd, new Instruction("res 4,(ix+${0:x2}),h", 0xa4cbdd, 4) },
        { 0xa5cbdd, new Instruction("res 4,(ix+${0:x2}),l", 0xa5cbdd, 4) },
        { 0xa6cbdd, new Instruction("res 4,(ix+${0:x2})", 0xa6cbdd, 4) },
        { 0xa7cbdd, new Instruction("res 4,(ix+${0:x2}),a", 0xa7cbdd, 4) },
        { 0xa8cbdd, new Instruction("res 5,(ix+${0:x2}),b", 0xa8cbdd, 4) },
        { 0xa9cbdd, new Instruction("res 5,(ix+${0:x2}),c", 0xa9cbdd, 4) },
        { 0xaacbdd, new Instruction("res 5,(ix+${0:x2}),d", 0xaacbdd, 4) },
        { 0xabcbdd, new Instruction("res 5,(ix+${0:x2}),e", 0xabcbdd, 4) },
        { 0xaccbdd, new Instruction("res 5,(ix+${0:x2}),h", 0xaccbdd, 4) },
        { 0xadcbdd, new Instruction("res 5,(ix+${0:x2}),l", 0xadcbdd, 4) },
        { 0xaecbdd, new Instruction("res 5,(ix+${0:x2})", 0xaecbdd, 4) },
        { 0xafcbdd, new Instruction("res 5,(ix+${0:x2}),a", 0xafcbdd, 4) },
        { 0xb0cbdd, new Instruction("res 6,(ix+${0:x2}),b", 0xb0cbdd, 4) },
        { 0xb1cbdd, new Instruction("res 6,(ix+${0:x2}),c", 0xb1cbdd, 4) },
        { 0xb2cbdd, new Instruction("res 6,(ix+${0:x2}),d", 0xb2cbdd, 4) },
        { 0xb3cbdd, new Instruction("res 6,(ix+${0:x2}),e", 0xb3cbdd, 4) },
        { 0xb4cbdd, new Instruction("res 6,(ix+${0:x2}),h", 0xb4cbdd, 4) },
        { 0xb5cbdd, new Instruction("res 6,(ix+${0:x2}),l", 0xb5cbdd, 4) },
        { 0xb6cbdd, new Instruction("res 6,(ix+${0:x2})", 0xb6cbdd, 4) },
        { 0xb7cbdd, new Instruction("res 6,(ix+${0:x2}),a", 0xb7cbdd, 4) },
        { 0xb8cbdd, new Instruction("res 7,(ix+${0:x2}),b", 0xb8cbdd, 4) },
        { 0xb9cbdd, new Instruction("res 7,(ix+${0:x2}),c", 0xb9cbdd, 4) },
        { 0xbacbdd, new Instruction("res 7,(ix+${0:x2}),d", 0xbacbdd, 4) },
        { 0xbbcbdd, new Instruction("res 7,(ix+${0:x2}),e", 0xbbcbdd, 4) },
        { 0xbccbdd, new Instruction("res 7,(ix+${0:x2}),h", 0xbccbdd, 4) },
        { 0xbdcbdd, new Instruction("res 7,(ix+${0:x2}),l", 0xbdcbdd, 4) },
        { 0xbecbdd, new Instruction("res 7,(ix+${0:x2})", 0xbecbdd, 4) },
        { 0xbfcbdd, new Instruction("res 7,(ix+${0:x2}),a", 0xbfcbdd, 4) },
        { 0xc0cbdd, new Instruction("set 0,(ix+${0:x2}),b", 0xc0cbdd, 4) },
        { 0xc1cbdd, new Instruction("set 0,(ix+${0:x2}),c", 0xc1cbdd, 4) },
        { 0xc2cbdd, new Instruction("set 0,(ix+${0:x2}),d", 0xc2cbdd, 4) },
        { 0xc3cbdd, new Instruction("set 0,(ix+${0:x2}),e", 0xc3cbdd, 4) },
        { 0xc4cbdd, new Instruction("set 0,(ix+${0:x2}),h", 0xc4cbdd, 4) },
        { 0xc5cbdd, new Instruction("set 0,(ix+${0:x2}),l", 0xc5cbdd, 4) },
        { 0xc6cbdd, new Instruction("set 0,(ix+${0:x2})", 0xc6cbdd, 4) },
        { 0xc7cbdd, new Instruction("set 0,(ix+${0:x2}),a", 0xc7cbdd, 4) },
        { 0xc8cbdd, new Instruction("set 1,(ix+${0:x2}),b", 0xc8cbdd, 4) },
        { 0xc9cbdd, new Instruction("set 1,(ix+${0:x2}),c", 0xc9cbdd, 4) },
        { 0xcacbdd, new Instruction("set 1,(ix+${0:x2}),d", 0xcacbdd, 4) },
        { 0xcbcbdd, new Instruction("set 1,(ix+${0:x2}),e", 0xcbcbdd, 4) },
        { 0xcccbdd, new Instruction("set 1,(ix+${0:x2}),h", 0xcccbdd, 4) },
        { 0xcdcbdd, new Instruction("set 1,(ix+${0:x2}),l", 0xcdcbdd, 4) },
        { 0xcecbdd, new Instruction("set 1,(ix+${0:x2})", 0xcecbdd, 4) },
        { 0xcfcbdd, new Instruction("set 1,(ix+${0:x2}),a", 0xcfcbdd, 4) },
        { 0xd0cbdd, new Instruction("set 2,(ix+${0:x2}),b", 0xd0cbdd, 4) },
        { 0xd1cbdd, new Instruction("set 2,(ix+${0:x2}),c", 0xd1cbdd, 4) },
        { 0xd2cbdd, new Instruction("set 2,(ix+${0:x2}),d", 0xd2cbdd, 4) },
        { 0xd3cbdd, new Instruction("set 2,(ix+${0:x2}),e", 0xd3cbdd, 4) },
        { 0xd4cbdd, new Instruction("set 2,(ix+${0:x2}),h", 0xd4cbdd, 4) },
        { 0xd5cbdd, new Instruction("set 2,(ix+${0:x2}),l", 0xd5cbdd, 4) },
        { 0xd6cbdd, new Instruction("set 2,(ix+${0:x2})", 0xd6cbdd, 4) },
        { 0xd7cbdd, new Instruction("set 2,(ix+${0:x2}),a", 0xd7cbdd, 4) },
        { 0xd8cbdd, new Instruction("set 3,(ix+${0:x2}),b", 0xd8cbdd, 4) },
        { 0xd9cbdd, new Instruction("set 3,(ix+${0:x2}),c", 0xd9cbdd, 4) },
        { 0xdacbdd, new Instruction("set 3,(ix+${0:x2}),d", 0xdacbdd, 4) },
        { 0xdbcbdd, new Instruction("set 3,(ix+${0:x2}),e", 0xdbcbdd, 4) },
        { 0xdccbdd, new Instruction("set 3,(ix+${0:x2}),h", 0xdccbdd, 4) },
        { 0xddcbdd, new Instruction("set 3,(ix+${0:x2}),l", 0xddcbdd, 4) },
        { 0xdecbdd, new Instruction("set 3,(ix+${0:x2})", 0xdecbdd, 4) },
        { 0xdfcbdd, new Instruction("set 3,(ix+${0:x2}),a", 0xdfcbdd, 4) },
        { 0xe0cbdd, new Instruction("set 4,(ix+${0:x2}),b", 0xe0cbdd, 4) },
        { 0xe1cbdd, new Instruction("set 4,(ix+${0:x2}),c", 0xe1cbdd, 4) },
        { 0xe2cbdd, new Instruction("set 4,(ix+${0:x2}),d", 0xe2cbdd, 4) },
        { 0xe3cbdd, new Instruction("set 4,(ix+${0:x2}),e", 0xe3cbdd, 4) },
        { 0xe4cbdd, new Instruction("set 4,(ix+${0:x2}),h", 0xe4cbdd, 4) },
        { 0xe5cbdd, new Instruction("set 4,(ix+${0:x2}),l", 0xe5cbdd, 4) },
        { 0xe6cbdd, new Instruction("set 4,(ix+${0:x2})", 0xe6cbdd, 4) },
        { 0xe7cbdd, new Instruction("set 4,(ix+${0:x2}),a", 0xe7cbdd, 4) },
        { 0xe8cbdd, new Instruction("set 5,(ix+${0:x2}),b", 0xe8cbdd, 4) },
        { 0xe9cbdd, new Instruction("set 5,(ix+${0:x2}),c", 0xe9cbdd, 4) },
        { 0xeacbdd, new Instruction("set 5,(ix+${0:x2}),d", 0xeacbdd, 4) },
        { 0xebcbdd, new Instruction("set 5,(ix+${0:x2}),e", 0xebcbdd, 4) },
        { 0xeccbdd, new Instruction("set 5,(ix+${0:x2}),h", 0xeccbdd, 4) },
        { 0xedcbdd, new Instruction("set 5,(ix+${0:x2}),l", 0xedcbdd, 4) },
        { 0xeecbdd, new Instruction("set 5,(ix+${0:x2})", 0xeecbdd, 4) },
        { 0xefcbdd, new Instruction("set 5,(ix+${0:x2}),a", 0xefcbdd, 4) },
        { 0xf0cbdd, new Instruction("set 6,(ix+${0:x2}),b", 0xf0cbdd, 4) },
        { 0xf1cbdd, new Instruction("set 6,(ix+${0:x2}),c", 0xf1cbdd, 4) },
        { 0xf2cbdd, new Instruction("set 6,(ix+${0:x2}),d", 0xf2cbdd, 4) },
        { 0xf3cbdd, new Instruction("set 6,(ix+${0:x2}),e", 0xf3cbdd, 4) },
        { 0xf4cbdd, new Instruction("set 6,(ix+${0:x2}),h", 0xf4cbdd, 4) },
        { 0xf5cbdd, new Instruction("set 6,(ix+${0:x2}),l", 0xf5cbdd, 4) },
        { 0xf6cbdd, new Instruction("set 6,(ix+${0:x2})", 0xf6cbdd, 4) },
        { 0xf7cbdd, new Instruction("set 6,(ix+${0:x2}),a", 0xf7cbdd, 4) },
        { 0xf8cbdd, new Instruction("set 7,(ix+${0:x2}),b", 0xf8cbdd, 4) },
        { 0xf9cbdd, new Instruction("set 7,(ix+${0:x2}),c", 0xf9cbdd, 4) },
        { 0xfacbdd, new Instruction("set 7,(ix+${0:x2}),d", 0xfacbdd, 4) },
        { 0xfbcbdd, new Instruction("set 7,(ix+${0:x2}),e", 0xfbcbdd, 4) },
        { 0xfccbdd, new Instruction("set 7,(ix+${0:x2}),h", 0xfccbdd, 4) },
        { 0xfdcbdd, new Instruction("set 7,(ix+${0:x2}),l", 0xfdcbdd, 4) },
        { 0xfecbdd, new Instruction("set 7,(ix+${0:x2})", 0xfecbdd, 4) },
        { 0xffcbdd, new Instruction("set 7,(ix+${0:x2}),a", 0xffcbdd, 4) },
        { 0x40cbfd, new Instruction("bit 0,(iy+${0:x2}),b", 0x40cbfd, 4) },
        { 0x41cbfd, new Instruction("bit 0,(iy+${0:x2}),c", 0x41cbfd, 4) },
        { 0x42cbfd, new Instruction("bit 0,(iy+${0:x2}),d", 0x42cbfd, 4) },
        { 0x43cbfd, new Instruction("bit 0,(iy+${0:x2}),e", 0x43cbfd, 4) },
        { 0x44cbfd, new Instruction("bit 0,(iy+${0:x2}),h", 0x44cbfd, 4) },
        { 0x45cbfd, new Instruction("bit 0,(iy+${0:x2}),l", 0x45cbfd, 4) },
        { 0x46cbfd, new Instruction("bit 0,(iy+${0:x2})", 0x46cbfd, 4) },
        { 0x47cbfd, new Instruction("bit 0,(iy+${0:x2}),a", 0x47cbfd, 4) },
        { 0x48cbfd, new Instruction("bit 1,(iy+${0:x2}),b", 0x48cbfd, 4) },
        { 0x49cbfd, new Instruction("bit 1,(iy+${0:x2}),c", 0x49cbfd, 4) },
        { 0x4acbfd, new Instruction("bit 1,(iy+${0:x2}),d", 0x4acbfd, 4) },
        { 0x4bcbfd, new Instruction("bit 1,(iy+${0:x2}),e", 0x4bcbfd, 4) },
        { 0x4ccbfd, new Instruction("bit 1,(iy+${0:x2}),h", 0x4ccbfd, 4) },
        { 0x4dcbfd, new Instruction("bit 1,(iy+${0:x2}),l", 0x4dcbfd, 4) },
        { 0x4ecbfd, new Instruction("bit 1,(iy+${0:x2})", 0x4ecbfd, 4) },
        { 0x4fcbfd, new Instruction("bit 1,(iy+${0:x2}),a", 0x4fcbfd, 4) },
        { 0x50cbfd, new Instruction("bit 2,(iy+${0:x2}),b", 0x50cbfd, 4) },
        { 0x51cbfd, new Instruction("bit 2,(iy+${0:x2}),c", 0x51cbfd, 4) },
        { 0x52cbfd, new Instruction("bit 2,(iy+${0:x2}),d", 0x52cbfd, 4) },
        { 0x53cbfd, new Instruction("bit 2,(iy+${0:x2}),e", 0x53cbfd, 4) },
        { 0x54cbfd, new Instruction("bit 2,(iy+${0:x2}),h", 0x54cbfd, 4) },
        { 0x55cbfd, new Instruction("bit 2,(iy+${0:x2}),l", 0x55cbfd, 4) },
        { 0x56cbfd, new Instruction("bit 2,(iy+${0:x2})", 0x56cbfd, 4) },
        { 0x57cbfd, new Instruction("bit 2,(iy+${0:x2}),a", 0x57cbfd, 4) },
        { 0x58cbfd, new Instruction("bit 3,(iy+${0:x2}),b", 0x58cbfd, 4) },
        { 0x59cbfd, new Instruction("bit 3,(iy+${0:x2}),c", 0x59cbfd, 4) },
        { 0x5acbfd, new Instruction("bit 3,(iy+${0:x2}),d", 0x5acbfd, 4) },
        { 0x5bcbfd, new Instruction("bit 3,(iy+${0:x2}),e", 0x5bcbfd, 4) },
        { 0x5ccbfd, new Instruction("bit 3,(iy+${0:x2}),h", 0x5ccbfd, 4) },
        { 0x5dcbfd, new Instruction("bit 3,(iy+${0:x2}),l", 0x5dcbfd, 4) },
        { 0x5ecbfd, new Instruction("bit 3,(iy+${0:x2})", 0x5ecbfd, 4) },
        { 0x5fcbfd, new Instruction("bit 3,(iy+${0:x2}),a", 0x5fcbfd, 4) },
        { 0x60cbfd, new Instruction("bit 4,(iy+${0:x2}),b", 0x60cbfd, 4) },
        { 0x61cbfd, new Instruction("bit 4,(iy+${0:x2}),c", 0x61cbfd, 4) },
        { 0x62cbfd, new Instruction("bit 4,(iy+${0:x2}),d", 0x62cbfd, 4) },
        { 0x63cbfd, new Instruction("bit 4,(iy+${0:x2}),e", 0x63cbfd, 4) },
        { 0x64cbfd, new Instruction("bit 4,(iy+${0:x2}),h", 0x64cbfd, 4) },
        { 0x65cbfd, new Instruction("bit 4,(iy+${0:x2}),l", 0x65cbfd, 4) },
        { 0x66cbfd, new Instruction("bit 4,(iy+${0:x2})", 0x66cbfd, 4) },
        { 0x67cbfd, new Instruction("bit 4,(iy+${0:x2}),a", 0x67cbfd, 4) },
        { 0x68cbfd, new Instruction("bit 5,(iy+${0:x2}),b", 0x68cbfd, 4) },
        { 0x69cbfd, new Instruction("bit 5,(iy+${0:x2}),c", 0x69cbfd, 4) },
        { 0x6acbfd, new Instruction("bit 5,(iy+${0:x2}),d", 0x6acbfd, 4) },
        { 0x6bcbfd, new Instruction("bit 5,(iy+${0:x2}),e", 0x6bcbfd, 4) },
        { 0x6ccbfd, new Instruction("bit 5,(iy+${0:x2}),h", 0x6ccbfd, 4) },
        { 0x6dcbfd, new Instruction("bit 5,(iy+${0:x2}),l", 0x6dcbfd, 4) },
        { 0x6ecbfd, new Instruction("bit 5,(iy+${0:x2})", 0x6ecbfd, 4) },
        { 0x6fcbfd, new Instruction("bit 5,(iy+${0:x2}),a", 0x6fcbfd, 4) },
        { 0x70cbfd, new Instruction("bit 6,(iy+${0:x2}),b", 0x70cbfd, 4) },
        { 0x71cbfd, new Instruction("bit 6,(iy+${0:x2}),c", 0x71cbfd, 4) },
        { 0x72cbfd, new Instruction("bit 6,(iy+${0:x2}),d", 0x72cbfd, 4) },
        { 0x73cbfd, new Instruction("bit 6,(iy+${0:x2}),e", 0x73cbfd, 4) },
        { 0x74cbfd, new Instruction("bit 6,(iy+${0:x2}),h", 0x74cbfd, 4) },
        { 0x75cbfd, new Instruction("bit 6,(iy+${0:x2}),l", 0x75cbfd, 4) },
        { 0x76cbfd, new Instruction("bit 6,(iy+${0:x2})", 0x76cbfd, 4) },
        { 0x77cbfd, new Instruction("bit 6,(iy+${0:x2}),a", 0x77cbfd, 4) },
        { 0x78cbfd, new Instruction("bit 7,(iy+${0:x2}),b", 0x78cbfd, 4) },
        { 0x79cbfd, new Instruction("bit 7,(iy+${0:x2}),c", 0x79cbfd, 4) },
        { 0x7acbfd, new Instruction("bit 7,(iy+${0:x2}),d", 0x7acbfd, 4) },
        { 0x7bcbfd, new Instruction("bit 7,(iy+${0:x2}),e", 0x7bcbfd, 4) },
        { 0x7ccbfd, new Instruction("bit 7,(iy+${0:x2}),h", 0x7ccbfd, 4) },
        { 0x7dcbfd, new Instruction("bit 7,(iy+${0:x2}),l", 0x7dcbfd, 4) },
        { 0x7ecbfd, new Instruction("bit 7,(iy+${0:x2})", 0x7ecbfd, 4) },
        { 0x7fcbfd, new Instruction("bit 7,(iy+${0:x2}),a", 0x7fcbfd, 4) },
        { 0x80cbfd, new Instruction("res 0,(iy+${0:x2}),b", 0x80cbfd, 4) },
        { 0x81cbfd, new Instruction("res 0,(iy+${0:x2}),c", 0x81cbfd, 4) },
        { 0x82cbfd, new Instruction("res 0,(iy+${0:x2}),d", 0x82cbfd, 4) },
        { 0x83cbfd, new Instruction("res 0,(iy+${0:x2}),e", 0x83cbfd, 4) },
        { 0x84cbfd, new Instruction("res 0,(iy+${0:x2}),h", 0x84cbfd, 4) },
        { 0x85cbfd, new Instruction("res 0,(iy+${0:x2}),l", 0x85cbfd, 4) },
        { 0x86cbfd, new Instruction("res 0,(iy+${0:x2})", 0x86cbfd, 4) },
        { 0x87cbfd, new Instruction("res 0,(iy+${0:x2}),a", 0x87cbfd, 4) },
        { 0x88cbfd, new Instruction("res 1,(iy+${0:x2}),b", 0x88cbfd, 4) },
        { 0x89cbfd, new Instruction("res 1,(iy+${0:x2}),c", 0x89cbfd, 4) },
        { 0x8acbfd, new Instruction("res 1,(iy+${0:x2}),d", 0x8acbfd, 4) },
        { 0x8bcbfd, new Instruction("res 1,(iy+${0:x2}),e", 0x8bcbfd, 4) },
        { 0x8ccbfd, new Instruction("res 1,(iy+${0:x2}),h", 0x8ccbfd, 4) },
        { 0x8dcbfd, new Instruction("res 1,(iy+${0:x2}),l", 0x8dcbfd, 4) },
        { 0x8ecbfd, new Instruction("res 1,(iy+${0:x2})", 0x8ecbfd, 4) },
        { 0x8fcbfd, new Instruction("res 1,(iy+${0:x2}),a", 0x8fcbfd, 4) },
        { 0x90cbfd, new Instruction("res 2,(iy+${0:x2}),b", 0x90cbfd, 4) },
        { 0x91cbfd, new Instruction("res 2,(iy+${0:x2}),c", 0x91cbfd, 4) },
        { 0x92cbfd, new Instruction("res 2,(iy+${0:x2}),d", 0x92cbfd, 4) },
        { 0x93cbfd, new Instruction("res 2,(iy+${0:x2}),e", 0x93cbfd, 4) },
        { 0x94cbfd, new Instruction("res 2,(iy+${0:x2}),h", 0x94cbfd, 4) },
        { 0x95cbfd, new Instruction("res 2,(iy+${0:x2}),l", 0x95cbfd, 4) },
        { 0x96cbfd, new Instruction("res 2,(iy+${0:x2})", 0x96cbfd, 4) },
        { 0x97cbfd, new Instruction("res 2,(iy+${0:x2}),a", 0x97cbfd, 4) },
        { 0x98cbfd, new Instruction("res 3,(iy+${0:x2}),b", 0x98cbfd, 4) },
        { 0x99cbfd, new Instruction("res 3,(iy+${0:x2}),c", 0x99cbfd, 4) },
        { 0x9acbfd, new Instruction("res 3,(iy+${0:x2}),d", 0x9acbfd, 4) },
        { 0x9bcbfd, new Instruction("res 3,(iy+${0:x2}),e", 0x9bcbfd, 4) },
        { 0x9ccbfd, new Instruction("res 3,(iy+${0:x2}),h", 0x9ccbfd, 4) },
        { 0x9dcbfd, new Instruction("res 3,(iy+${0:x2}),l", 0x9dcbfd, 4) },
        { 0x9ecbfd, new Instruction("res 3,(iy+${0:x2})", 0x9ecbfd, 4) },
        { 0x9fcbfd, new Instruction("res 3,(iy+${0:x2}),a", 0x9fcbfd, 4) },
        { 0xa0cbfd, new Instruction("res 4,(iy+${0:x2}),b", 0xa0cbfd, 4) },
        { 0xa1cbfd, new Instruction("res 4,(iy+${0:x2}),c", 0xa1cbfd, 4) },
        { 0xa2cbfd, new Instruction("res 4,(iy+${0:x2}),d", 0xa2cbfd, 4) },
        { 0xa3cbfd, new Instruction("res 4,(iy+${0:x2}),e", 0xa3cbfd, 4) },
        { 0xa4cbfd, new Instruction("res 4,(iy+${0:x2}),h", 0xa4cbfd, 4) },
        { 0xa5cbfd, new Instruction("res 4,(iy+${0:x2}),l", 0xa5cbfd, 4) },
        { 0xa6cbfd, new Instruction("res 4,(iy+${0:x2})", 0xa6cbfd, 4) },
        { 0xa7cbfd, new Instruction("res 4,(iy+${0:x2}),a", 0xa7cbfd, 4) },
        { 0xa8cbfd, new Instruction("res 5,(iy+${0:x2}),b", 0xa8cbfd, 4) },
        { 0xa9cbfd, new Instruction("res 5,(iy+${0:x2}),c", 0xa9cbfd, 4) },
        { 0xaacbfd, new Instruction("res 5,(iy+${0:x2}),d", 0xaacbfd, 4) },
        { 0xabcbfd, new Instruction("res 5,(iy+${0:x2}),e", 0xabcbfd, 4) },
        { 0xaccbfd, new Instruction("res 5,(iy+${0:x2}),h", 0xaccbfd, 4) },
        { 0xadcbfd, new Instruction("res 5,(iy+${0:x2}),l", 0xadcbfd, 4) },
        { 0xaecbfd, new Instruction("res 5,(iy+${0:x2})", 0xaecbfd, 4) },
        { 0xafcbfd, new Instruction("res 5,(iy+${0:x2}),a", 0xafcbfd, 4) },
        { 0xb0cbfd, new Instruction("res 6,(iy+${0:x2}),b", 0xb0cbfd, 4) },
        { 0xb1cbfd, new Instruction("res 6,(iy+${0:x2}),c", 0xb1cbfd, 4) },
        { 0xb2cbfd, new Instruction("res 6,(iy+${0:x2}),d", 0xb2cbfd, 4) },
        { 0xb3cbfd, new Instruction("res 6,(iy+${0:x2}),e", 0xb3cbfd, 4) },
        { 0xb4cbfd, new Instruction("res 6,(iy+${0:x2}),h", 0xb4cbfd, 4) },
        { 0xb5cbfd, new Instruction("res 6,(iy+${0:x2}),l", 0xb5cbfd, 4) },
        { 0xb6cbfd, new Instruction("res 6,(iy+${0:x2})", 0xb6cbfd, 4) },
        { 0xb7cbfd, new Instruction("res 6,(iy+${0:x2}),a", 0xb7cbfd, 4) },
        { 0xb8cbfd, new Instruction("res 7,(iy+${0:x2}),b", 0xb8cbfd, 4) },
        { 0xb9cbfd, new Instruction("res 7,(iy+${0:x2}),c", 0xb9cbfd, 4) },
        { 0xbacbfd, new Instruction("res 7,(iy+${0:x2}),d", 0xbacbfd, 4) },
        { 0xbbcbfd, new Instruction("res 7,(iy+${0:x2}),e", 0xbbcbfd, 4) },
        { 0xbccbfd, new Instruction("res 7,(iy+${0:x2}),h", 0xbccbfd, 4) },
        { 0xbdcbfd, new Instruction("res 7,(iy+${0:x2}),l", 0xbdcbfd, 4) },
        { 0xbecbfd, new Instruction("res 7,(iy+${0:x2})", 0xbecbfd, 4) },
        { 0xbfcbfd, new Instruction("res 7,(iy+${0:x2}),a", 0xbfcbfd, 4) },
        { 0xc0cbfd, new Instruction("set 0,(iy+${0:x2}),b", 0xc0cbfd, 4) },
        { 0xc1cbfd, new Instruction("set 0,(iy+${0:x2}),c", 0xc1cbfd, 4) },
        { 0xc2cbfd, new Instruction("set 0,(iy+${0:x2}),d", 0xc2cbfd, 4) },
        { 0xc3cbfd, new Instruction("set 0,(iy+${0:x2}),e", 0xc3cbfd, 4) },
        { 0xc4cbfd, new Instruction("set 0,(iy+${0:x2}),h", 0xc4cbfd, 4) },
        { 0xc5cbfd, new Instruction("set 0,(iy+${0:x2}),l", 0xc5cbfd, 4) },
        { 0xc6cbfd, new Instruction("set 0,(iy+${0:x2})", 0xc6cbfd, 4) },
        { 0xc7cbfd, new Instruction("set 0,(iy+${0:x2}),a", 0xc7cbfd, 4) },
        { 0xc8cbfd, new Instruction("set 1,(iy+${0:x2}),b", 0xc8cbfd, 4) },
        { 0xc9cbfd, new Instruction("set 1,(iy+${0:x2}),c", 0xc9cbfd, 4) },
        { 0xcacbfd, new Instruction("set 1,(iy+${0:x2}),d", 0xcacbfd, 4) },
        { 0xcbcbfd, new Instruction("set 1,(iy+${0:x2}),e", 0xcbcbfd, 4) },
        { 0xcccbfd, new Instruction("set 1,(iy+${0:x2}),h", 0xcccbfd, 4) },
        { 0xcdcbfd, new Instruction("set 1,(iy+${0:x2}),l", 0xcdcbfd, 4) },
        { 0xcecbfd, new Instruction("set 1,(iy+${0:x2})", 0xcecbfd, 4) },
        { 0xcfcbfd, new Instruction("set 1,(iy+${0:x2}),a", 0xcfcbfd, 4) },
        { 0xd0cbfd, new Instruction("set 2,(iy+${0:x2}),b", 0xd0cbfd, 4) },
        { 0xd1cbfd, new Instruction("set 2,(iy+${0:x2}),c", 0xd1cbfd, 4) },
        { 0xd2cbfd, new Instruction("set 2,(iy+${0:x2}),d", 0xd2cbfd, 4) },
        { 0xd3cbfd, new Instruction("set 2,(iy+${0:x2}),e", 0xd3cbfd, 4) },
        { 0xd4cbfd, new Instruction("set 2,(iy+${0:x2}),h", 0xd4cbfd, 4) },
        { 0xd5cbfd, new Instruction("set 2,(iy+${0:x2}),l", 0xd5cbfd, 4) },
        { 0xd6cbfd, new Instruction("set 2,(iy+${0:x2})", 0xd6cbfd, 4) },
        { 0xd7cbfd, new Instruction("set 2,(iy+${0:x2}),a", 0xd7cbfd, 4) },
        { 0xd8cbfd, new Instruction("set 3,(iy+${0:x2}),b", 0xd8cbfd, 4) },
        { 0xd9cbfd, new Instruction("set 3,(iy+${0:x2}),c", 0xd9cbfd, 4) },
        { 0xdacbfd, new Instruction("set 3,(iy+${0:x2}),d", 0xdacbfd, 4) },
        { 0xdbcbfd, new Instruction("set 3,(iy+${0:x2}),e", 0xdbcbfd, 4) },
        { 0xdccbfd, new Instruction("set 3,(iy+${0:x2}),h", 0xdccbfd, 4) },
        { 0xddcbfd, new Instruction("set 3,(iy+${0:x2}),l", 0xddcbfd, 4) },
        { 0xdecbfd, new Instruction("set 3,(iy+${0:x2})", 0xdecbfd, 4) },
        { 0xdfcbfd, new Instruction("set 3,(iy+${0:x2}),a", 0xdfcbfd, 4) },
        { 0xe0cbfd, new Instruction("set 4,(iy+${0:x2}),b", 0xe0cbfd, 4) },
        { 0xe1cbfd, new Instruction("set 4,(iy+${0:x2}),c", 0xe1cbfd, 4) },
        { 0xe2cbfd, new Instruction("set 4,(iy+${0:x2}),d", 0xe2cbfd, 4) },
        { 0xe3cbfd, new Instruction("set 4,(iy+${0:x2}),e", 0xe3cbfd, 4) },
        { 0xe4cbfd, new Instruction("set 4,(iy+${0:x2}),h", 0xe4cbfd, 4) },
        { 0xe5cbfd, new Instruction("set 4,(iy+${0:x2}),l", 0xe5cbfd, 4) },
        { 0xe6cbfd, new Instruction("set 4,(iy+${0:x2})", 0xe6cbfd, 4) },
        { 0xe7cbfd, new Instruction("set 4,(iy+${0:x2}),a", 0xe7cbfd, 4) },
        { 0xe8cbfd, new Instruction("set 5,(iy+${0:x2}),b", 0xe8cbfd, 4) },
        { 0xe9cbfd, new Instruction("set 5,(iy+${0:x2}),c", 0xe9cbfd, 4) },
        { 0xeacbfd, new Instruction("set 5,(iy+${0:x2}),d", 0xeacbfd, 4) },
        { 0xebcbfd, new Instruction("set 5,(iy+${0:x2}),e", 0xebcbfd, 4) },
        { 0xeccbfd, new Instruction("set 5,(iy+${0:x2}),h", 0xeccbfd, 4) },
        { 0xedcbfd, new Instruction("set 5,(iy+${0:x2}),l", 0xedcbfd, 4) },
        { 0xeecbfd, new Instruction("set 5,(iy+${0:x2})", 0xeecbfd, 4) },
        { 0xefcbfd, new Instruction("set 5,(iy+${0:x2}),a", 0xefcbfd, 4) },
        { 0xf0cbfd, new Instruction("set 6,(iy+${0:x2}),b", 0xf0cbfd, 4) },
        { 0xf1cbfd, new Instruction("set 6,(iy+${0:x2}),c", 0xf1cbfd, 4) },
        { 0xf2cbfd, new Instruction("set 6,(iy+${0:x2}),d", 0xf2cbfd, 4) },
        { 0xf3cbfd, new Instruction("set 6,(iy+${0:x2}),e", 0xf3cbfd, 4) },
        { 0xf4cbfd, new Instruction("set 6,(iy+${0:x2}),h", 0xf4cbfd, 4) },
        { 0xf5cbfd, new Instruction("set 6,(iy+${0:x2}),l", 0xf5cbfd, 4) },
        { 0xf6cbfd, new Instruction("set 6,(iy+${0:x2})", 0xf6cbfd, 4) },
        { 0xf7cbfd, new Instruction("set 6,(iy+${0:x2}),a", 0xf7cbfd, 4) },
        { 0xf8cbfd, new Instruction("set 7,(iy+${0:x2}),b", 0xf8cbfd, 4) },
        { 0xf9cbfd, new Instruction("set 7,(iy+${0:x2}),c", 0xf9cbfd, 4) },
        { 0xfacbfd, new Instruction("set 7,(iy+${0:x2}),d", 0xfacbfd, 4) },
        { 0xfbcbfd, new Instruction("set 7,(iy+${0:x2}),e", 0xfbcbfd, 4) },
        { 0xfccbfd, new Instruction("set 7,(iy+${0:x2}),h", 0xfccbfd, 4) },
        { 0xfdcbfd, new Instruction("set 7,(iy+${0:x2}),l", 0xfdcbfd, 4) },
        { 0xfecbfd, new Instruction("set 7,(iy+${0:x2})", 0xfecbfd, 4) },
        { 0xffcbfd, new Instruction("set 7,(iy+${0:x2}),a", 0xffcbfd, 4) }
    };

    // s_i8080
    private static readonly Dictionary<int, Dictionary<int, Instruction>> s_i8080 = new()
    {
        {
            Z80Modes.A0, new Dictionary<int, Instruction>()
            {
                { SyntaxParser.INR, new Instruction("inr a", 0x3c, 1) },
                { SyntaxParser.DCR, new Instruction("dcr a", 0x3d, 1) },
                { SyntaxParser.ADD, new Instruction("add a", 0x87, 1) },
                { SyntaxParser.ADC, new Instruction("adc a", 0x8f, 1) },
                { SyntaxParser.SUB, new Instruction("sub a", 0x97, 1) },
                { SyntaxParser.SBB, new Instruction("sbb a", 0x9f, 1) },
                { SyntaxParser.ANA, new Instruction("ana a", 0xa7, 1) },
                { SyntaxParser.XRA, new Instruction("xra a", 0xaf, 1) },
                { SyntaxParser.ORA, new Instruction("ora a", 0xb7, 1) },
                { SyntaxParser.CMP, new Instruction("cmp a", 0xbf, 1) }
            }
        },
        {
            Z80Modes.A0A1, new Dictionary<int, Instruction>() { { SyntaxParser.MOV, new Instruction("mov a,a", 0x7f, 1) } }
        },
        {
            Z80Modes.A0B1, new Dictionary<int, Instruction>() { { SyntaxParser.MOV, new Instruction("mov a,b", 0x78, 1) } }
        },
        {
            Z80Modes.A0C1, new Dictionary<int, Instruction>() { { SyntaxParser.MOV, new Instruction("mov a,c", 0x79, 1) } }
        },
        {
            Z80Modes.A0D1, new Dictionary<int, Instruction>() { { SyntaxParser.MOV, new Instruction("mov a,d", 0x7a, 1) } }
        },
        {
            Z80Modes.A0E1, new Dictionary<int, Instruction>() { { SyntaxParser.MOV, new Instruction("mov a,e", 0x7b, 1) } }
        },
        {
            Z80Modes.A0H1, new Dictionary<int, Instruction>() { { SyntaxParser.MOV, new Instruction("mov a,h", 0x7c, 1) } }
        },
        {
            Z80Modes.A0L1, new Dictionary<int, Instruction>() { { SyntaxParser.MOV, new Instruction("mov a,l", 0x7d, 1) } }
        },
        {
            Z80Modes.A0M1, new Dictionary<int, Instruction>() { { SyntaxParser.MOV, new Instruction("mov a,m", 0x7e, 1) } }
        },
        {
            Z80Modes.A0N81, new Dictionary<int, Instruction>()
            {
                { SyntaxParser.MVI, new Instruction("mvi a,${0:x2}", 0x3e, 2) },
                { SyntaxParser.ADI, new Instruction("adi a,${0:x2}", 0xc6, 2) }
            }
        },
        {
            Z80Modes.B0, new Dictionary<int, Instruction>()
            {
                { SyntaxParser.STAX, new Instruction("stax b", 0x02, 1) },
                { SyntaxParser.INX,  new Instruction("inx b", 0x03, 1) },
                { SyntaxParser.INR,  new Instruction("inr b", 0x04, 1) },
                { SyntaxParser.DCR,  new Instruction("dcr b", 0x05, 1) },
                { SyntaxParser.DAD,  new Instruction("dad b", 0x09, 1) },
                { SyntaxParser.LDAX, new Instruction("ldax b", 0x0a, 1) },
                { SyntaxParser.DCX,  new Instruction("dcx b", 0x0b, 1) },
                { SyntaxParser.ADD,  new Instruction("add b", 0x80, 1) },
                { SyntaxParser.ADC,  new Instruction("adc b", 0x88, 1) },
                { SyntaxParser.SUB,  new Instruction("sub b", 0x90, 1) },
                { SyntaxParser.SBB,  new Instruction("sbb b", 0x98, 1) },
                { SyntaxParser.ANA,  new Instruction("ana b", 0xa0, 1) },
                { SyntaxParser.XRA,  new Instruction("xra b", 0xa8, 1) },
                { SyntaxParser.ORA,  new Instruction("ora b", 0xb0, 1) },
                { SyntaxParser.CMP,  new Instruction("cmp b", 0xb8, 1) },
                { SyntaxParser.POP,  new Instruction("pop b", 0xc1, 1) },
                { SyntaxParser.PUSH, new Instruction("push b", 0xc5, 1) }
            }
        },
        {
            Z80Modes.B0A1, new Dictionary<int, Instruction>() { { SyntaxParser.MOV, new Instruction("mov b,a", 0x47, 1) } }
        },
        {
            Z80Modes.B0B1, new Dictionary<int, Instruction>() { { SyntaxParser.MOV, new Instruction("mov b,b", 0x40, 1) } }
        },
        {
            Z80Modes.B0C1, new Dictionary<int, Instruction>() { { SyntaxParser.MOV, new Instruction("mov b,c", 0x41, 1) } }
        },
        {
            Z80Modes.B0D1, new Dictionary<int, Instruction>() { { SyntaxParser.MOV, new Instruction("mov b,d", 0x42, 1) } }
        },
        {
            Z80Modes.B0E1, new Dictionary<int, Instruction>() { { SyntaxParser.MOV, new Instruction("mov b,e", 0x43, 1) } }
        },
        {
            Z80Modes.B0H1, new Dictionary<int, Instruction>() { { SyntaxParser.MOV, new Instruction("mov b,h", 0x44, 1) } }
        },
        {
            Z80Modes.B0L1, new Dictionary<int, Instruction>() { { SyntaxParser.MOV, new Instruction("mov b,l", 0x45, 1) } }
        },
        {
            Z80Modes.B0M1, new Dictionary<int, Instruction>() { { SyntaxParser.MOV, new Instruction("mov b,m", 0x46, 1) } }
        },
        {
            Z80Modes.B0N81, new Dictionary<int, Instruction>()
            {
                { SyntaxParser.LXI, new Instruction("lxi b,${0:x4}", 0x01, 3) },
                { SyntaxParser.MVI, new Instruction("mvi b,${0:x2}", 0x06, 2) }
            }
        },
        {
            Z80Modes.C0, new Dictionary<int, Instruction>()
            {
                { SyntaxParser.INR, new Instruction("inr c", 0x0c, 1) },
                { SyntaxParser.DCR, new Instruction("dcr c", 0x0d, 1) },
                { SyntaxParser.ADD, new Instruction("add c", 0x81, 1) },
                { SyntaxParser.ADC, new Instruction("adc c", 0x89, 1) },
                { SyntaxParser.SUB, new Instruction("sub c", 0x91, 1) },
                { SyntaxParser.SBB, new Instruction("sbb c", 0x99, 1) },
                { SyntaxParser.ANA, new Instruction("ana c", 0xa1, 1) },
                { SyntaxParser.XRA, new Instruction("xra c", 0xa9, 1) },
                { SyntaxParser.ORA, new Instruction("ora c", 0xb1, 1) },
                { SyntaxParser.CMP, new Instruction("cmp c", 0xb9, 1) }
            }
        },
        {
            Z80Modes.C0A1, new Dictionary<int, Instruction>() { { SyntaxParser.MOV, new Instruction("mov c,a", 0x4f, 1) } }
        },
        {
            Z80Modes.C0B1, new Dictionary<int, Instruction>() { { SyntaxParser.MOV, new Instruction("mov c,b", 0x48, 1) } }
        },
        {
            Z80Modes.C0C1, new Dictionary<int, Instruction>() { { SyntaxParser.MOV, new Instruction("mov c,c", 0x49, 1) } }
        },
        {
            Z80Modes.C0D1, new Dictionary<int, Instruction>() { { SyntaxParser.MOV, new Instruction("mov c,d", 0x4a, 1) } }
        },
        {
            Z80Modes.C0E1, new Dictionary<int, Instruction>() { { SyntaxParser.MOV, new Instruction("mov c,e", 0x4b, 1) } }
        },
        {
            Z80Modes.C0H1, new Dictionary<int, Instruction>() { { SyntaxParser.MOV, new Instruction("mov c,h", 0x4c, 1) } }
        },
        {
            Z80Modes.C0L1, new Dictionary<int, Instruction>() { { SyntaxParser.MOV, new Instruction("mov c,l", 0x4d, 1) } }
        },
        {
            Z80Modes.C0M1, new Dictionary<int, Instruction>() { { SyntaxParser.MOV, new Instruction("mov c,m", 0x4e, 1) } }
        },
        {
            Z80Modes.C0N81, new Dictionary<int, Instruction>() { { SyntaxParser.MVI, new Instruction("mvi c,${0:x2}", 0x0e, 2) } }
        },
        {
            Z80Modes.D0, new Dictionary<int, Instruction>()
            {
                { SyntaxParser.STAX, new Instruction("stax d", 0x12, 1) },
                { SyntaxParser.INX,  new Instruction("inx d", 0x13, 1) },
                { SyntaxParser.INR,  new Instruction("inr d", 0x14, 1) },
                { SyntaxParser.DCR,  new Instruction("dcr d", 0x15, 1) },
                { SyntaxParser.DAD,  new Instruction("dad d", 0x19, 1) },
                { SyntaxParser.LDAX, new Instruction("ldax d", 0x1a, 1) },
                { SyntaxParser.DCX,  new Instruction("dcx d", 0x1b, 1) },
                { SyntaxParser.ADD,  new Instruction("add d", 0x82, 1) },
                { SyntaxParser.ADC,  new Instruction("adc d", 0x8a, 1) },
                { SyntaxParser.SUB,  new Instruction("sub d", 0x92, 1) },
                { SyntaxParser.SBB,  new Instruction("sbb d", 0x9a, 1) },
                { SyntaxParser.ANA,  new Instruction("ana d", 0xa2, 1) },
                { SyntaxParser.XRA,  new Instruction("xra d", 0xaa, 1) },
                { SyntaxParser.ORA,  new Instruction("ora d", 0xb2, 1) },
                { SyntaxParser.CMP,  new Instruction("cmp d", 0xba, 1) },
                { SyntaxParser.POP,  new Instruction("pop d", 0xd1, 1) },
                { SyntaxParser.PUSH, new Instruction("push d", 0xd5, 1) }
            }
        },
        {
            Z80Modes.D0A1, new Dictionary<int, Instruction>() { { SyntaxParser.MOV, new Instruction("mov d,a", 0x57, 1) } }
        },
        {
            Z80Modes.D0B1, new Dictionary<int, Instruction>() { { SyntaxParser.MOV, new Instruction("mov d,b", 0x50, 1) } }
        },
        {
            Z80Modes.D0C1, new Dictionary<int, Instruction>() { { SyntaxParser.MOV, new Instruction("mov d,c", 0x51, 1) } }
        },
        {
            Z80Modes.D0D1, new Dictionary<int, Instruction>() { { SyntaxParser.MOV, new Instruction("mov d,d", 0x52, 1) } }
        },
        {
            Z80Modes.D0E1, new Dictionary<int, Instruction>() { { SyntaxParser.MOV, new Instruction("mov d,e", 0x53, 1) } }
        },
        {
            Z80Modes.D0H1, new Dictionary<int, Instruction>() { { SyntaxParser.MOV, new Instruction("mov d,h", 0x54, 1) } }
        },
        {
            Z80Modes.D0L1, new Dictionary<int, Instruction>() { { SyntaxParser.MOV, new Instruction("mov d,l", 0x55, 1) } }
        },
        {
            Z80Modes.D0M1, new Dictionary<int, Instruction>() { { SyntaxParser.MOV, new Instruction("mov d,m", 0x56, 1) } }
        },
        {
            Z80Modes.D0N81, new Dictionary<int, Instruction>()
            {
                { SyntaxParser.LXI, new Instruction("lxi d,${0:x4}", 0x11, 3) },
                { SyntaxParser.MVI, new Instruction("mvi d,${0:x2}", 0x16, 2) }
            }
        },
        {
            Z80Modes.E0, new Dictionary<int, Instruction>()
            {
                { SyntaxParser.INR, new Instruction("inr e", 0x1c, 1) },
                { SyntaxParser.DCR, new Instruction("dcr e", 0x1d, 1) },
                { SyntaxParser.ADD, new Instruction("add e", 0x83, 1) },
                { SyntaxParser.ADC, new Instruction("adc e", 0x8b, 1) },
                { SyntaxParser.SUB, new Instruction("sub e", 0x93, 1) },
                { SyntaxParser.SBB, new Instruction("sbb e", 0x9b, 1) },
                { SyntaxParser.ANA, new Instruction("ana e", 0xa3, 1) },
                { SyntaxParser.XRA, new Instruction("xra e", 0xab, 1) },
                { SyntaxParser.ORA, new Instruction("ora e", 0xb3, 1) },
                { SyntaxParser.CMP, new Instruction("cmp e", 0xbb, 1) }
            }
        },
        {
            Z80Modes.E0A1, new Dictionary<int, Instruction>() { { SyntaxParser.MOV, new Instruction("mov e,a", 0x5f, 1) } }
        },
        {
            Z80Modes.E0B1, new Dictionary<int, Instruction>() { { SyntaxParser.MOV, new Instruction("mov e,b", 0x58, 1) } }
        },
        {
            Z80Modes.E0C1, new Dictionary<int, Instruction>() { { SyntaxParser.MOV, new Instruction("mov e,c", 0x59, 1) } }
        },
        {
            Z80Modes.E0D1, new Dictionary<int, Instruction>() { { SyntaxParser.MOV, new Instruction("mov e,d", 0x5a, 1) } }
        },
        {
            Z80Modes.E0E1, new Dictionary<int, Instruction>() { { SyntaxParser.MOV, new Instruction("mov e,e", 0x5b, 1) } }
        },
        {
            Z80Modes.E0H1, new Dictionary<int, Instruction>() { { SyntaxParser.MOV, new Instruction("mov e,h", 0x5c, 1) } }
        },
        {
            Z80Modes.E0L1, new Dictionary<int, Instruction>() { { SyntaxParser.MOV, new Instruction("mov e,l", 0x5d, 1) } }
        },
        {
            Z80Modes.E0M1, new Dictionary<int, Instruction>() { { SyntaxParser.MOV, new Instruction("mov e,m", 0x5e, 1) } }
        },
        {
            Z80Modes.E0N81, new Dictionary<int, Instruction>() { { SyntaxParser.MVI, new Instruction("mvi e,${0:x2}", 0x1e, 2) } }
        },
        {
            Z80Modes.H0, new Dictionary<int, Instruction>()
            {
                { SyntaxParser.INX,  new Instruction("inx h", 0x23, 1) },
                { SyntaxParser.INR,  new Instruction("inr h", 0x24, 1) },
                { SyntaxParser.DCR,  new Instruction("dcr h", 0x25, 1) },
                { SyntaxParser.DAD,  new Instruction("dad h", 0x29, 1) },
                { SyntaxParser.DCX,  new Instruction("dcx h", 0x2b, 1) },
                { SyntaxParser.ADD,  new Instruction("add h", 0x84, 1) },
                { SyntaxParser.ADC,  new Instruction("adc h", 0x8c, 1) },
                { SyntaxParser.SUB,  new Instruction("sub h", 0x94, 1) },
                { SyntaxParser.SBB,  new Instruction("sbb h", 0x9c, 1) },
                { SyntaxParser.ANA,  new Instruction("ana h", 0xa4, 1) },
                { SyntaxParser.XRA,  new Instruction("xra h", 0xac, 1) },
                { SyntaxParser.ORA,  new Instruction("ora h", 0xb4, 1) },
                { SyntaxParser.CMP,  new Instruction("cmp h", 0xbc, 1) },
                { SyntaxParser.POP,  new Instruction("pop h", 0xe1, 1) },
                { SyntaxParser.PUSH, new Instruction("push h", 0xe5, 1) }
            }
        },
        {
            Z80Modes.H0A1, new Dictionary<int, Instruction>() { { SyntaxParser.MOV, new Instruction("mov h,a", 0x67, 1) } }
        },
        {
            Z80Modes.H0B1, new Dictionary<int, Instruction>() { { SyntaxParser.MOV, new Instruction("mov h,b", 0x60, 1) } }
        },
        {
            Z80Modes.H0C1, new Dictionary<int, Instruction>() { { SyntaxParser.MOV, new Instruction("mov h,c", 0x61, 1) } }
        },
        {
            Z80Modes.H0D1, new Dictionary<int, Instruction>() { { SyntaxParser.MOV, new Instruction("mov h,d", 0x62, 1) } }
        },
        {
            Z80Modes.H0E1, new Dictionary<int, Instruction>() { { SyntaxParser.MOV, new Instruction("mov h,e", 0x63, 1) } }
        },
        {
            Z80Modes.H0H1, new Dictionary<int, Instruction>() { { SyntaxParser.MOV, new Instruction("mov h,h", 0x64, 1) } }
        },
        {
            Z80Modes.H0L1, new Dictionary<int, Instruction>() { { SyntaxParser.MOV, new Instruction("mov h,l", 0x65, 1) } }
        },
        {
            Z80Modes.H0M1, new Dictionary<int, Instruction>() { { SyntaxParser.MOV, new Instruction("mov h,m", 0x66, 1) } }
        },
        {
            Z80Modes.H0N81, new Dictionary<int, Instruction>()
            {
                { SyntaxParser.LXI, new Instruction("lxi h,${0:x4}", 0x21, 3) },
                { SyntaxParser.MVI, new Instruction("mvi h,${0:x2}", 0x26, 2) }
            }
        },
        {
            Z80Modes.Implied, new Dictionary<int, Instruction>()
            {
                { SyntaxParser.NOP,  new Instruction("nop", 0x00, 1) },
                { SyntaxParser.RLC,  new Instruction("rlc", 0x07, 1) },
                { SyntaxParser.RRC,  new Instruction("rrc", 0x0f, 1) },
                { SyntaxParser.RAL,  new Instruction("ral", 0x17, 1) },
                { SyntaxParser.RAR,  new Instruction("rar", 0x1f, 1) },
                { SyntaxParser.DAA,  new Instruction("daa", 0x27, 1) },
                { SyntaxParser.CMA,  new Instruction("cma", 0x2f, 1) },
                { SyntaxParser.STC,  new Instruction("stc", 0x37, 1) },
                { SyntaxParser.CMC,  new Instruction("cmc", 0x3f, 1) },
                { SyntaxParser.HLT,  new Instruction("hlt", 0x76, 1) },
                { SyntaxParser.RNZ,  new Instruction("rnz", 0xc0, 1) },
                { SyntaxParser.RZ,   new Instruction("rz", 0xc8, 1) },
                { SyntaxParser.RET,  new Instruction("ret", 0xc9, 1) },
                { SyntaxParser.RNC,  new Instruction("rnc", 0xd0, 1) },
                { SyntaxParser.RC,   new Instruction("rc", 0xd8, 1) },
                { SyntaxParser.RPO,  new Instruction("rpo", 0xe0, 1) },
                { SyntaxParser.XTHL, new Instruction("xthl", 0xe3, 1) },
                { SyntaxParser.RPE,  new Instruction("rpe", 0xe8, 1) },
                { SyntaxParser.PCHL, new Instruction("pchl", 0xe9, 1) },
                { SyntaxParser.XCHG, new Instruction("xchg", 0xeb, 1) },
                { SyntaxParser.RP,   new Instruction("rp", 0xf0, 1) },
                { SyntaxParser.DI,   new Instruction("di", 0xf3, 1) },
                { SyntaxParser.RM,   new Instruction("rm", 0xf8, 1) },
                { SyntaxParser.SPHL, new Instruction("sphl", 0xf9, 1) },
                { SyntaxParser.EI,   new Instruction("ei", 0xfb, 1) }
            }
        },
        {
            Z80Modes.L0, new Dictionary<int, Instruction>()
            {
                { SyntaxParser.INR, new Instruction("inr l", 0x2c, 1) },
                { SyntaxParser.DCR, new Instruction("dcr l", 0x2d, 1) },
                { SyntaxParser.ADD, new Instruction("add l", 0x85, 1) },
                { SyntaxParser.ADC, new Instruction("adc l", 0x8d, 1) },
                { SyntaxParser.SUB, new Instruction("sub l", 0x95, 1) },
                { SyntaxParser.SBB, new Instruction("sbb l", 0x9d, 1) },
                { SyntaxParser.ANA, new Instruction("ana l", 0xa5, 1) },
                { SyntaxParser.XRA, new Instruction("xra l", 0xad, 1) },
                { SyntaxParser.ORA, new Instruction("ora l", 0xb5, 1) },
                { SyntaxParser.CMP, new Instruction("cmp l", 0xbd, 1) }
            }
        },
        {
            Z80Modes.L0A1, new Dictionary<int, Instruction>() { { SyntaxParser.MOV, new Instruction("mov l,a", 0x6f, 1) } }
        },
        {
            Z80Modes.L0B1, new Dictionary<int, Instruction>() { { SyntaxParser.MOV, new Instruction("mov l,b", 0x68, 1) } }
        },
        {
            Z80Modes.L0C1, new Dictionary<int, Instruction>() { { SyntaxParser.MOV, new Instruction("mov l,c", 0x69, 1) } }
        },
        {
            Z80Modes.L0D1, new Dictionary<int, Instruction>() { { SyntaxParser.MOV, new Instruction("mov l,d", 0x6a, 1) } }
        },
        {
            Z80Modes.L0E1, new Dictionary<int, Instruction>() { { SyntaxParser.MOV, new Instruction("mov l,e", 0x6b, 1) } }
        },
        {
            Z80Modes.L0H1, new Dictionary<int, Instruction>() { { SyntaxParser.MOV, new Instruction("mov l,h", 0x6c, 1) } }
        },
        {
            Z80Modes.L0L1, new Dictionary<int, Instruction>() { { SyntaxParser.MOV, new Instruction("mov l,l", 0x6d, 1) } }
        },
        {
            Z80Modes.L0M1, new Dictionary<int, Instruction>() { { SyntaxParser.MOV, new Instruction("mov l,m", 0x6e, 1) } }
        },
        {
            Z80Modes.L0N81, new Dictionary<int, Instruction>() { { SyntaxParser.MVI, new Instruction("mvi l,${0:x2}", 0x2e, 2) } }
        },
        {
            Z80Modes.M0, new Dictionary<int, Instruction>()
            {
                { SyntaxParser.INR, new Instruction("inr m", 0x34, 1) },
                { SyntaxParser.DCR, new Instruction("dcr m", 0x35, 1) },
                { SyntaxParser.ADD, new Instruction("add m", 0x86, 1) },
                { SyntaxParser.ADC, new Instruction("adc m", 0x8e, 1) },
                { SyntaxParser.SUB, new Instruction("sub m", 0x96, 1) },
                { SyntaxParser.SBB, new Instruction("sbb m", 0x9e, 1) },
                { SyntaxParser.ANA, new Instruction("ana m", 0xa6, 1) },
                { SyntaxParser.XRA, new Instruction("xra m", 0xae, 1) },
                { SyntaxParser.ORA, new Instruction("ora m", 0xb6, 1) },
                { SyntaxParser.CMP, new Instruction("cmp m", 0xbe, 1) }
            }
        },
        {
            Z80Modes.M0A1, new Dictionary<int, Instruction>() { { SyntaxParser.MOV, new Instruction("mov m,a", 0x77, 1) } }
        },
        {
            Z80Modes.M0B1, new Dictionary<int, Instruction>() { { SyntaxParser.MOV, new Instruction("mov m,b", 0x70, 1) } }
        },
        {
            Z80Modes.M0C1, new Dictionary<int, Instruction>() { { SyntaxParser.MOV, new Instruction("mov m,c", 0x71, 1) } }
        },
        {
            Z80Modes.M0D1, new Dictionary<int, Instruction>() { { SyntaxParser.MOV, new Instruction("mov m,d", 0x72, 1) } }
        },
        {
            Z80Modes.M0E1, new Dictionary<int, Instruction>() { { SyntaxParser.MOV, new Instruction("mov m,e", 0x73, 1) } }
        },
        {
            Z80Modes.M0H1, new Dictionary<int, Instruction>() { { SyntaxParser.MOV, new Instruction("mov m,h", 0x74, 1) } }
        },
        {
            Z80Modes.M0L1, new Dictionary<int, Instruction>() { { SyntaxParser.MOV, new Instruction("mov m,l", 0x75, 1) } }
        },
        {
            Z80Modes.M0N81, new Dictionary<int, Instruction>() { { SyntaxParser.MVI, new Instruction("mvi m,${0:x2}", 0x36, 2) } }
        },
        {
            Z80Modes.N160, new Dictionary<int, Instruction>()
            {
                { SyntaxParser.SHLD, new Instruction("shld ${0:x4}", 0x22, 3) },
                { SyntaxParser.LHLD, new Instruction("lhld ${0:x4}", 0x2a, 3) },
                { SyntaxParser.STA,  new Instruction("sta ${0:x4}", 0x32, 3) },
                { SyntaxParser.LDA,  new Instruction("lda ${0:x4}", 0x3a, 3) },
                { SyntaxParser.JNZ,  new Instruction("jnz ${0:x4}", 0xc2, 3) },
                { SyntaxParser.JMP,  new Instruction("jmp ${0:x4}", 0xc3, 3) },
                { SyntaxParser.CNZ,  new Instruction("cnz ${0:x4}", 0xc4, 3) },
                { SyntaxParser.JZ,   new Instruction("jz ${0:x4}", 0xca, 3) },
                { SyntaxParser.CZ,   new Instruction("cz ${0:x4}", 0xcc, 3) },
                { SyntaxParser.CALL, new Instruction("call ${0:x4}", 0xcd, 3) },
                { SyntaxParser.JNC,  new Instruction("jnc ${0:x4}", 0xd2, 3) },
                { SyntaxParser.CNC,  new Instruction("cnc ${0:x4}", 0xd4, 3) },
                { SyntaxParser.JC,   new Instruction("jc ${0:x4}", 0xda, 3) },
                { SyntaxParser.CC,   new Instruction("cc ${0:x4}", 0xdc, 3) },
                { SyntaxParser.JPO,  new Instruction("jpo ${0:x4}", 0xe2, 3) },
                { SyntaxParser.CPO,  new Instruction("cpo ${0:x4}", 0xe4, 3) },
                { SyntaxParser.JPE,  new Instruction("jpe ${0:x4}", 0xea, 3) },
                { SyntaxParser.CPE,  new Instruction("cpe ${0:x4}", 0xec, 3) },
                { SyntaxParser.JP,   new Instruction("jp ${0:x4}", 0xf2, 3) },
                { SyntaxParser.CP,   new Instruction("cp ${0:x4}", 0xf4, 3) },
                { SyntaxParser.JM,   new Instruction("jm ${0:x4}", 0xfa, 3) },
                { SyntaxParser.CM,   new Instruction("cm ${0:x4}", 0xfc, 3) }
            }
        },
        {
            Z80Modes.N80, new Dictionary<int, Instruction>()
            {
                { SyntaxParser.ACI,  new Instruction("aci ${0:x2}", 0xce, 2) },
                { SyntaxParser.OUT,  new Instruction("out ${0:x2}", 0xd3, 2) },
                { SyntaxParser.SUI,  new Instruction("sui ${0:x2}", 0xd6, 2) },
                { SyntaxParser.IN,   new Instruction("in ${0:x2}", 0xdb, 2) },
                { SyntaxParser.SBI,  new Instruction("sbi ${0:x2}", 0xde, 2) },
                { SyntaxParser.ANI,  new Instruction("ani ${0:x2}", 0xe6, 2) },
                { SyntaxParser.XRI,  new Instruction("xri ${0:x2}", 0xee, 2) },
                { SyntaxParser.ORI,  new Instruction("ori ${0:x2}", 0xf6, 2) },
                { SyntaxParser.CPI,  new Instruction("cpi ${0:x2}", 0xfe, 2) },
                { SyntaxParser.SHLD, new Instruction("shld ${0:x4}", 0x22, 3) },
                { SyntaxParser.LHLD, new Instruction("lhld ${0:x4}", 0x2a, 3) },
                { SyntaxParser.STA,  new Instruction("sta ${0:x4}", 0x32, 3) },
                { SyntaxParser.LDA,  new Instruction("lda ${0:x4}", 0x3a, 3) },
                { SyntaxParser.JNZ,  new Instruction("jnz ${0:x4}", 0xc2, 3) },
                { SyntaxParser.JMP,  new Instruction("jmp ${0:x4}", 0xc3, 3) },
                { SyntaxParser.CNZ,  new Instruction("cnz ${0:x4}", 0xc4, 3) },
                { SyntaxParser.JZ,   new Instruction("jz ${0:x4}", 0xca, 3) },
                { SyntaxParser.CZ,   new Instruction("cz ${0:x4}", 0xcc, 3) },
                { SyntaxParser.CALL, new Instruction("call ${0:x4}", 0xcd, 3) },
                { SyntaxParser.JNC,  new Instruction("jnc ${0:x4}", 0xd2, 3) },
                { SyntaxParser.CNC,  new Instruction("cnc ${0:x4}", 0xd4, 3) },
                { SyntaxParser.JC,   new Instruction("jc ${0:x4}", 0xda, 3) },
                { SyntaxParser.CC,   new Instruction("cc ${0:x4}", 0xdc, 3) },
                { SyntaxParser.JPO,  new Instruction("jpo ${0:x4}", 0xe2, 3) },
                { SyntaxParser.CPO,  new Instruction("cpo ${0:x4}", 0xe4, 3) },
                { SyntaxParser.JPE,  new Instruction("jpe ${0:x4}", 0xea, 3) },
                { SyntaxParser.CPE,  new Instruction("cpe ${0:x4}", 0xec, 3) },
                { SyntaxParser.JP,   new Instruction("jp ${0:x4}", 0xf2, 3) },
                { SyntaxParser.CP,   new Instruction("cp ${0:x4}", 0xf4, 3) },
                { SyntaxParser.JM,   new Instruction("jm ${0:x4}", 0xfa, 3) },
                { SyntaxParser.CM,   new Instruction("cm ${0:x4}", 0xfc, 3) }
            }
        },
        {
            Z80Modes.PSW0, new Dictionary<int, Instruction>()
            {
                { SyntaxParser.POP,  new Instruction("pop psw", 0xf1, 1) },
                { SyntaxParser.PUSH, new Instruction("push psw", 0xf5, 1) }
            }
        },
        {
            Z80Modes.SP0, new Dictionary<int, Instruction>()
            {
                { SyntaxParser.INX, new Instruction("inx sp", 0x33, 1) },
                { SyntaxParser.DAD, new Instruction("dad sp", 0x39, 1) },
                { SyntaxParser.DCX, new Instruction("dcx sp", 0x3b, 1) }
            }
        },
        {
            Z80Modes.SP0N161, new Dictionary<int, Instruction>() { { SyntaxParser.LXI, new Instruction("lxi sp,${0:x4}", 0x31, 3) } }
        }
    };

    private static readonly Dictionary<int, Instruction> s_i8080allOpcodes = new()
    {
        { 0x00, new Instruction("nop", 0x00,  1) },
        { 0x01, new Instruction("lxi b,${0:x4}", 0x01,  3) },
        { 0x02, new Instruction("stax b", 0x02,  1) },
        { 0x03, new Instruction("inx b", 0x03,  1) },
        { 0x04, new Instruction("inr b", 0x04,  1) },
        { 0x05, new Instruction("dcr b", 0x05,  1) },
        { 0x06, new Instruction("mvi b,${0:x2}", 0x06,  2) },
        { 0x07, new Instruction("rlc", 0x07,  1) },
        { 0x09, new Instruction("dad b", 0x09,  1) },
        { 0x0a, new Instruction("ldax b", 0x0a,  1) },
        { 0x0b, new Instruction("dcx b", 0x0b,  1) },
        { 0x0c, new Instruction("inr c", 0x0c,  1) },
        { 0x0d, new Instruction("dcr c", 0x0d,  1) },
        { 0x0e, new Instruction("mvi c,${0:x2}", 0x0e,  2) },
        { 0x0f, new Instruction("rrc", 0x0f,  1) },
        { 0x11, new Instruction("lxi d,${0:x4}", 0x11,  3) },
        { 0x12, new Instruction("stax d", 0x12,  1) },
        { 0x13, new Instruction("inx d", 0x13,  1) },
        { 0x14, new Instruction("inr d", 0x14,  1) },
        { 0x15, new Instruction("dcr d", 0x15,  1) },
        { 0x16, new Instruction("mvi d,${0:x2}", 0x16,  2) },
        { 0x17, new Instruction("ral", 0x17,  1) },
        { 0x19, new Instruction("dad d", 0x19,  1) },
        { 0x1a, new Instruction("ldax d", 0x1a,  1) },
        { 0x1b, new Instruction("dcx d", 0x1b,  1) },
        { 0x1c, new Instruction("inr e", 0x1c,  1) },
        { 0x1d, new Instruction("dcr e", 0x1d,  1) },
        { 0x1e, new Instruction("mvi e,${0:x2}", 0x1e,  2) },
        { 0x1f, new Instruction("rar", 0x1f,  1) },
        { 0x21, new Instruction("lxi h,${0:x4}", 0x21,  3) },
        { 0x22, new Instruction("shld ${0:x4}", 0x22,  3) },
        { 0x23, new Instruction("inx h", 0x23,  1) },
        { 0x24, new Instruction("inr h", 0x24,  1) },
        { 0x25, new Instruction("dcr h", 0x25,  1) },
        { 0x26, new Instruction("mvi h,${0:x2}", 0x26,  2) },
        { 0x27, new Instruction("daa", 0x27,  1) },
        { 0x29, new Instruction("dad h", 0x29,  1) },
        { 0x2a, new Instruction("lhld ${0:x4}", 0x2a,  3) },
        { 0x2b, new Instruction("dcx h", 0x2b,  1) },
        { 0x2c, new Instruction("inr l", 0x2c,  1) },
        { 0x2d, new Instruction("dcr l", 0x2d,  1) },
        { 0x2e, new Instruction("mvi l,${0:x2}", 0x2e,  2) },
        { 0x2f, new Instruction("cma", 0x2f,  1) },
        { 0x31, new Instruction("lxi sp,${0:x4}", 0x31,  3) },
        { 0x32, new Instruction("sta ${0:x4}", 0x32,  3) },
        { 0x33, new Instruction("inx sp", 0x33,  1) },
        { 0x34, new Instruction("inr m", 0x34,  1) },
        { 0x35, new Instruction("dcr m", 0x35,  1) },
        { 0x36, new Instruction("mvi m,${0:x2}", 0x36,  2) },
        { 0x37, new Instruction("stc", 0x37,  1) },
        { 0x39, new Instruction("dad sp", 0x39,  1) },
        { 0x3a, new Instruction("lda ${0:x4}", 0x3a,  3) },
        { 0x3b, new Instruction("dcx sp", 0x3b,  1) },
        { 0x3c, new Instruction("inr a", 0x3c,  1) },
        { 0x3d, new Instruction("dcr a", 0x3d,  1) },
        { 0x3e, new Instruction("mvi a,${0:x2}", 0x3e,  2) },
        { 0x3f, new Instruction("cmc", 0x3f,  1) },
        { 0x40, new Instruction("mov b,b", 0x40,  1) },
        { 0x41, new Instruction("mov b,c", 0x41,  1) },
        { 0x42, new Instruction("mov b,d", 0x42,  1) },
        { 0x43, new Instruction("mov b,e", 0x43,  1) },
        { 0x44, new Instruction("mov b,h", 0x44,  1) },
        { 0x45, new Instruction("mov b,l", 0x45,  1) },
        { 0x46, new Instruction("mov b,m", 0x46,  1) },
        { 0x47, new Instruction("mov b,a", 0x47,  1) },
        { 0x48, new Instruction("mov c,b", 0x48,  1) },
        { 0x49, new Instruction("mov c,c", 0x49,  1) },
        { 0x4a, new Instruction("mov c,d", 0x4a,  1) },
        { 0x4b, new Instruction("mov c,e", 0x4b,  1) },
        { 0x4c, new Instruction("mov c,h", 0x4c,  1) },
        { 0x4d, new Instruction("mov c,l", 0x4d,  1) },
        { 0x4e, new Instruction("mov c,m", 0x4e,  1) },
        { 0x4f, new Instruction("mov c,a", 0x4f,  1) },
        { 0x50, new Instruction("mov d,b", 0x50,  1) },
        { 0x51, new Instruction("mov d,c", 0x51,  1) },
        { 0x52, new Instruction("mov d,d", 0x52,  1) },
        { 0x53, new Instruction("mov d,e", 0x53,  1) },
        { 0x54, new Instruction("mov d,h", 0x54,  1) },
        { 0x55, new Instruction("mov d,l", 0x55,  1) },
        { 0x56, new Instruction("mov d,m", 0x56,  1) },
        { 0x57, new Instruction("mov d,a", 0x57,  1) },
        { 0x58, new Instruction("mov e,b", 0x58,  1) },
        { 0x59, new Instruction("mov e,c", 0x59,  1) },
        { 0x5a, new Instruction("mov e,d", 0x5a,  1) },
        { 0x5b, new Instruction("mov e,e", 0x5b,  1) },
        { 0x5c, new Instruction("mov e,h", 0x5c,  1) },
        { 0x5d, new Instruction("mov e,l", 0x5d,  1) },
        { 0x5e, new Instruction("mov e,m", 0x5e,  1) },
        { 0x5f, new Instruction("mov e,a", 0x5f,  1) },
        { 0x60, new Instruction("mov h,b", 0x60,  1) },
        { 0x61, new Instruction("mov h,c", 0x61,  1) },
        { 0x62, new Instruction("mov h,d", 0x62,  1) },
        { 0x63, new Instruction("mov h,e", 0x63,  1) },
        { 0x64, new Instruction("mov h,h", 0x64,  1) },
        { 0x65, new Instruction("mov h,l", 0x65,  1) },
        { 0x66, new Instruction("mov h,m", 0x66,  1) },
        { 0x67, new Instruction("mov h,a", 0x67,  1) },
        { 0x68, new Instruction("mov l,b", 0x68,  1) },
        { 0x69, new Instruction("mov l,c", 0x69,  1) },
        { 0x6a, new Instruction("mov l,d", 0x6a,  1) },
        { 0x6b, new Instruction("mov l,e", 0x6b,  1) },
        { 0x6c, new Instruction("mov l,h", 0x6c,  1) },
        { 0x6d, new Instruction("mov l,l", 0x6d,  1) },
        { 0x6e, new Instruction("mov l,m", 0x6e,  1) },
        { 0x6f, new Instruction("mov l,a", 0x6f,  1) },
        { 0x70, new Instruction("mov m,b", 0x70,  1) },
        { 0x71, new Instruction("mov m,c", 0x71,  1) },
        { 0x72, new Instruction("mov m,d", 0x72,  1) },
        { 0x73, new Instruction("mov m,e", 0x73,  1) },
        { 0x74, new Instruction("mov m,h", 0x74,  1) },
        { 0x75, new Instruction("mov m,l", 0x75,  1) },
        { 0x76, new Instruction("hlt", 0x76,  1) },
        { 0x77, new Instruction("mov m,a", 0x77,  1) },
        { 0x78, new Instruction("mov a,b", 0x78,  1) },
        { 0x79, new Instruction("mov a,c", 0x79,  1) },
        { 0x7a, new Instruction("mov a,d", 0x7a,  1) },
        { 0x7b, new Instruction("mov a,e", 0x7b,  1) },
        { 0x7c, new Instruction("mov a,h", 0x7c,  1) },
        { 0x7d, new Instruction("mov a,l", 0x7d,  1) },
        { 0x7e, new Instruction("mov a,m", 0x7e,  1) },
        { 0x7f, new Instruction("mov a,a", 0x7f,  1) },
        { 0x80, new Instruction("add b", 0x80,  1) },
        { 0x81, new Instruction("add c", 0x81,  1) },
        { 0x82, new Instruction("add d", 0x82,  1) },
        { 0x83, new Instruction("add e", 0x83,  1) },
        { 0x84, new Instruction("add h", 0x84,  1) },
        { 0x85, new Instruction("add l", 0x85,  1) },
        { 0x86, new Instruction("add m", 0x86,  1) },
        { 0x87, new Instruction("add a", 0x87,  1) },
        { 0x88, new Instruction("adc b", 0x88,  1) },
        { 0x89, new Instruction("adc c", 0x89,  1) },
        { 0x8a, new Instruction("adc d", 0x8a,  1) },
        { 0x8b, new Instruction("adc e", 0x8b,  1) },
        { 0x8c, new Instruction("adc h", 0x8c,  1) },
        { 0x8d, new Instruction("adc l", 0x8d,  1) },
        { 0x8e, new Instruction("adc m", 0x8e,  1) },
        { 0x8f, new Instruction("adc a", 0x8f,  1) },
        { 0x90, new Instruction("sub b", 0x90,  1) },
        { 0x91, new Instruction("sub c", 0x91,  1) },
        { 0x92, new Instruction("sub d", 0x92,  1) },
        { 0x93, new Instruction("sub e", 0x93,  1) },
        { 0x94, new Instruction("sub h", 0x94,  1) },
        { 0x95, new Instruction("sub l", 0x95,  1) },
        { 0x96, new Instruction("sub m", 0x96,  1) },
        { 0x97, new Instruction("sub a", 0x97,  1) },
        { 0x98, new Instruction("sbb b", 0x98,  1) },
        { 0x99, new Instruction("sbb c", 0x99,  1) },
        { 0x9a, new Instruction("sbb d", 0x9a,  1) },
        { 0x9b, new Instruction("sbb e", 0x9b,  1) },
        { 0x9c, new Instruction("sbb h", 0x9c,  1) },
        { 0x9d, new Instruction("sbb l", 0x9d,  1) },
        { 0x9e, new Instruction("sbb m", 0x9e,  1) },
        { 0x9f, new Instruction("sbb a", 0x9f,  1) },
        { 0xa0, new Instruction("ana b", 0xa0,  1) },
        { 0xa1, new Instruction("ana c", 0xa1,  1) },
        { 0xa2, new Instruction("ana d", 0xa2,  1) },
        { 0xa3, new Instruction("ana e", 0xa3,  1) },
        { 0xa4, new Instruction("ana h", 0xa4,  1) },
        { 0xa5, new Instruction("ana l", 0xa5,  1) },
        { 0xa6, new Instruction("ana m", 0xa6,  1) },
        { 0xa7, new Instruction("ana a", 0xa7,  1) },
        { 0xa8, new Instruction("xra b", 0xa8,  1) },
        { 0xa9, new Instruction("xra c", 0xa9,  1) },
        { 0xaa, new Instruction("xra d", 0xaa,  1) },
        { 0xab, new Instruction("xra e", 0xab,  1) },
        { 0xac, new Instruction("xra h", 0xac,  1) },
        { 0xad, new Instruction("xra l", 0xad,  1) },
        { 0xae, new Instruction("xra m", 0xae,  1) },
        { 0xaf, new Instruction("xra a", 0xaf,  1) },
        { 0xb0, new Instruction("ora b", 0xb0,  1) },
        { 0xb1, new Instruction("ora c", 0xb1,  1) },
        { 0xb2, new Instruction("ora d", 0xb2,  1) },
        { 0xb3, new Instruction("ora e", 0xb3,  1) },
        { 0xb4, new Instruction("ora h", 0xb4,  1) },
        { 0xb5, new Instruction("ora l", 0xb5,  1) },
        { 0xb6, new Instruction("ora m", 0xb6,  1) },
        { 0xb7, new Instruction("ora a", 0xb7,  1) },
        { 0xb8, new Instruction("cmp b", 0xb8,  1) },
        { 0xb9, new Instruction("cmp c", 0xb9,  1) },
        { 0xba, new Instruction("cmp d", 0xba,  1) },
        { 0xbb, new Instruction("cmp e", 0xbb,  1) },
        { 0xbc, new Instruction("cmp h", 0xbc,  1) },
        { 0xbd, new Instruction("cmp l", 0xbd,  1) },
        { 0xbe, new Instruction("cmp m", 0xbe,  1) },
        { 0xbf, new Instruction("cmp a", 0xbf,  1) },
        { 0xc0, new Instruction("rnz", 0xc0,  1) },
        { 0xc1, new Instruction("pop b", 0xc1,  1) },
        { 0xc2, new Instruction("jnz ${0:x4}", 0xc2,  3) },
        { 0xc3, new Instruction("jmp ${0:x4}", 0xc3,  3) },
        { 0xc4, new Instruction("cnz ${0:x4}", 0xc4,  3) },
        { 0xc5, new Instruction("push b", 0xc5,  1) },
        { 0xc6, new Instruction("adi a,${0:x2}", 0xc6,  2) },
        { 0xc8, new Instruction("rz", 0xc8,  1) },
        { 0xc9, new Instruction("ret", 0xc9,  1) },
        { 0xca, new Instruction("jz ${0:x4}", 0xca,  3) },
        { 0xcc, new Instruction("cz ${0:x4}", 0xcc,  3) },
        { 0xcd, new Instruction("call ${0:x4}", 0xcd,  3) },
        { 0xce, new Instruction("aci ${0:x2}", 0xce,  2) },
        { 0xd0, new Instruction("rnc", 0xd0,  1) },
        { 0xd1, new Instruction("pop d", 0xd1,  1) },
        { 0xd2, new Instruction("jnc ${0:x4}", 0xd2,  3) },
        { 0xd3, new Instruction("out ${0:x2}", 0xd3,  2) },
        { 0xd4, new Instruction("cnc ${0:x4}", 0xd4,  3) },
        { 0xd5, new Instruction("push d", 0xd5,  1) },
        { 0xd6, new Instruction("sui ${0:x2}", 0xd6,  2) },
        { 0xd8, new Instruction("rc", 0xd8,  1) },
        { 0xda, new Instruction("jc ${0:x4}", 0xda,  3) },
        { 0xdb, new Instruction("in ${0:x2}", 0xdb,  2) },
        { 0xdc, new Instruction("cc ${0:x4}", 0xdc,  3) },
        { 0xde, new Instruction("sbi ${0:x2}", 0xde,  2) },
        { 0xe0, new Instruction("rpo", 0xe0,  1) },
        { 0xe1, new Instruction("pop h", 0xe1,  1) },
        { 0xe2, new Instruction("jpo ${0:x4}", 0xe2,  3) },
        { 0xe3, new Instruction("xthl", 0xe3,  1) },
        { 0xe4, new Instruction("cpo ${0:x4}", 0xe4,  3) },
        { 0xe5, new Instruction("push h", 0xe5,  1) },
        { 0xe6, new Instruction("ani ${0:x2}", 0xe6,  2) },
        { 0xe8, new Instruction("rpe", 0xe8,  1) },
        { 0xe9, new Instruction("pchl", 0xe9,  1) },
        { 0xea, new Instruction("jpe ${0:x4}", 0xea,  3) },
        { 0xeb, new Instruction("xchg", 0xeb,  1) },
        { 0xec, new Instruction("cpe ${0:x4}", 0xec,  3) },
        { 0xee, new Instruction("xri ${0:x2}", 0xee,  2) },
        { 0xf0, new Instruction("rp", 0xf0,  1) },
        { 0xf1, new Instruction("pop psw", 0xf1,  1) },
        { 0xf2, new Instruction("jp ${0:x4}", 0xf2,  3) },
        { 0xf3, new Instruction("di", 0xf3,  1) },
        { 0xf4, new Instruction("cp ${0:x4}", 0xf4,  3) },
        { 0xf5, new Instruction("push psw", 0xf5,  1) },
        { 0xf6, new Instruction("ori ${0:x2}", 0xf6,  2) },
        { 0xf8, new Instruction("rm", 0xf8,  1) },
        { 0xf9, new Instruction("sphl", 0xf9,  1) },
        { 0xfa, new Instruction("jm ${0:x4}", 0xfa,  3) },
        { 0xfb, new Instruction("ei", 0xfb,  1) },
        { 0xfc, new Instruction("cm ${0:x4}", 0xfc,  3) },
        { 0xfe, new Instruction("cpi ${0:x2}", 0xfe,  2) },
    };

}
