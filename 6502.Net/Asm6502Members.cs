//-----------------------------------------------------------------------------
// Copyright (c) 2017 informedcitizenry <informedcitizenry@gmail.com>
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to 
// deal in the Software without restriction, including without limitation the 
// rights to use, copy, modify, merge, publish, distribute, sublicense, and/or 
// sell copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in 
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING 
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS 
// IN THE SOFTWARE.
//-----------------------------------------------------------------------------

using DotNetAsm;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Asm6502.Net
{
    /// <summary>
    /// A line assembler that will assemble into 6502 instructions.
    /// </summary>
    public partial class Asm6502 : AssemblerBase, ILineAssembler
    {
        #region Members

        string _cpu;

        FormatBuilder[] _builders;

        List<Opcode> _filteredOpcodes;

        bool _m16, _x16;

        Regex _regWidth;

        Opcode[] _opcodes =
        {
            new Opcode  { CPU = "6502",  DisasmFormat = "brk",              Size = 1, Index = 0x00 },
            new Opcode  { CPU = "6502",  DisasmFormat = "ora (${0:x2},x)",  Size = 2, Index = 0x01 },
            new Opcode  { CPU = "6502i", DisasmFormat = "jam",              Size = 1, Index = 0x02 },
            new Opcode  { CPU = "65816", DisasmFormat = "cop",              Size = 1, Index = 0x02 },
            new Opcode  { CPU = "65816", DisasmFormat = "cop #${0:x2}",     Size = 2, Index = 0x02 },
            new Opcode  { CPU = "6502i", DisasmFormat = "slo (${0:x2},x)",  Size = 2, Index = 0x03 },
            new Opcode  { CPU = "65816", DisasmFormat = "ora ${0:x2},s",    Size = 2, Index = 0x03 },
            new Opcode  { CPU = "6502i", DisasmFormat = "dop ${0:x2}",      Size = 2, Index = 0x04 },
            new Opcode  { CPU = "65C02", DisasmFormat = "tsb ${0:x2}",      Size = 2, Index = 0x04 },
            new Opcode  { CPU = "6502",  DisasmFormat = "ora ${0:x2}",      Size = 2, Index = 0x05 },
            new Opcode  { CPU = "6502",  DisasmFormat = "asl ${0:x2}",      Size = 2, Index = 0x06 },
            new Opcode  { CPU = "6502i", DisasmFormat = "slo ${0:x2}",      Size = 2, Index = 0x07 },
            new Opcode  { CPU = "65816", DisasmFormat = "ora [${0:x2}]",    Size = 2, Index = 0x07 },
            new Opcode  { CPU = "6502",  DisasmFormat = "php",              Size = 1, Index = 0x08 },
            new Opcode  { CPU = "6502",  DisasmFormat = "ora #${0:x2}",     Size = 2, Index = 0x09 },
            new Opcode  { CPU = "6502",  DisasmFormat = "asl",              Size = 1, Index = 0x0a },
            new Opcode  { CPU = "65816", DisasmFormat = "phd",              Size = 1, Index = 0x0b },
            new Opcode  { CPU = "6502i", DisasmFormat = "top",              Size = 1, Index = 0x0c },
            new Opcode  { CPU = "6502i", DisasmFormat = "top ${0:x4}",      Size = 3, Index = 0x0c },
            new Opcode  { CPU = "65C02", DisasmFormat = "tsb ${0:x4}",      Size = 3, Index = 0x0c },
            new Opcode  { CPU = "6502",  DisasmFormat = "ora ${0:x4}",      Size = 3, Index = 0x0d },
            new Opcode  { CPU = "6502",  DisasmFormat = "asl ${0:x4}",      Size = 3, Index = 0x0e },
            new Opcode  { CPU = "6502i", DisasmFormat = "slo ${0:x4}",      Size = 3, Index = 0x0f },
            new Opcode  { CPU = "65816", DisasmFormat = "ora ${0:x6}",      Size = 4, Index = 0x0f },
            new Opcode  { CPU = "6502",  DisasmFormat = "bpl ${0:x4}",      Size = 2, Index = 0x10 },
            new Opcode  { CPU = "6502",  DisasmFormat = "ora (${0:x2}),y",  Size = 2, Index = 0x11 },
            new Opcode  { CPU = "6502i", DisasmFormat = "stp",              Size = 1, Index = 0x12 },
            new Opcode  { CPU = "65C02", DisasmFormat = "ora (${0:x2})",    Size = 2, Index = 0x12 },
            new Opcode  { CPU = "6502i", DisasmFormat = "slo (${0:x2}),y",  Size = 2, Index = 0x13 },
            new Opcode  { CPU = "65816", DisasmFormat = "ora (${0:x2},s),y",Size = 2, Index = 0x13 },
            new Opcode  { CPU = "6502i", DisasmFormat = "dop ${0:x2},x",    Size = 2, Index = 0x14 },
            new Opcode  { CPU = "65C02", DisasmFormat = "trb ${0:x2}",      Size = 2, Index = 0x14 },
            new Opcode  { CPU = "6502",  DisasmFormat = "ora ${0:x2},x",    Size = 2, Index = 0x15 },
            new Opcode  { CPU = "6502",  DisasmFormat = "asl ${0:x2},x",    Size = 2, Index = 0x16 },
            new Opcode  { CPU = "6502i", DisasmFormat = "slo ${0:x2},x",    Size = 2, Index = 0x17 },
            new Opcode  { CPU = "65816", DisasmFormat = "ora [${0:x2}],y",  Size = 2, Index = 0x17 },
            new Opcode  { CPU = "6502",  DisasmFormat = "clc",              Size = 1, Index = 0x18 },
            new Opcode  { CPU = "6502",  DisasmFormat = "ora ${0:x4},y",    Size = 3, Index = 0x19 },
            new Opcode  { CPU = "65C02", DisasmFormat = "inc",              Size = 1, Index = 0x1a },
            new Opcode  { CPU = "6502i", DisasmFormat = "slo ${0:x4},y",    Size = 3, Index = 0x1b },
            new Opcode  { CPU = "65816", DisasmFormat = "tcs",              Size = 1, Index = 0x1b },
            new Opcode  { CPU = "6502",  DisasmFormat = "top ${0:x4},x",    Size = 3, Index = 0x1c },
            new Opcode  { CPU = "65C02", DisasmFormat = "trb ${0:x4}",      Size = 3, Index = 0x1c },
            new Opcode  { CPU = "6502",  DisasmFormat = "ora ${0:x4},x",    Size = 3, Index = 0x1d },
            new Opcode  { CPU = "6502",  DisasmFormat = "asl ${0:x4},x",    Size = 3, Index = 0x1e },
            new Opcode  { CPU = "6502i", DisasmFormat = "slo ${0:x4},x",    Size = 3, Index = 0x1f },
            new Opcode  { CPU = "65816", DisasmFormat = "ora ${0:x6},x",    Size = 4, Index = 0x1f },
            new Opcode  { CPU = "6502",  DisasmFormat = "jsr ${0:x4}",      Size = 3, Index = 0x20 },
            new Opcode  { CPU = "6502",  DisasmFormat = "and (${0:x2},x)",  Size = 2, Index = 0x21 },
            new Opcode  { CPU = "65816", DisasmFormat = "jsl ${0:x6}",      Size = 4, Index = 0x22 },
            new Opcode  { CPU = "65816", DisasmFormat = "jsr ${0:x6}",      Size = 4, Index = 0x22 },
            new Opcode  { CPU = "6502i", DisasmFormat = "rla (${0:x2},x)",  Size = 2, Index = 0x23 },
            new Opcode  { CPU = "65816", DisasmFormat = "and ${0:x2},s",    Size = 2, Index = 0x23 },
            new Opcode  { CPU = "6502",  DisasmFormat = "bit ${0:x2}",      Size = 2, Index = 0x24 },
            new Opcode  { CPU = "6502",  DisasmFormat = "and ${0:x2}",      Size = 2, Index = 0x25 },
            new Opcode  { CPU = "6502",  DisasmFormat = "rol ${0:x2}",      Size = 2, Index = 0x26 },
            new Opcode  { CPU = "6502",  DisasmFormat = "rla ${0:x2}",      Size = 2, Index = 0x27 },
            new Opcode  { CPU = "65816", DisasmFormat = "and [${0:x2}]",    Size = 2, Index = 0x27 },
            new Opcode  { CPU = "6502",  DisasmFormat = "plp",              Size = 1, Index = 0x28 },
            new Opcode  { CPU = "6502",  DisasmFormat = "and #${0:x2}",     Size = 2, Index = 0x29 },
            new Opcode  { CPU = "6502",  DisasmFormat = "rol",              Size = 1, Index = 0x2a },
            new Opcode  { CPU = "6502i", DisasmFormat = "anc #${0:x2}",     Size = 2, Index = 0x2b },
            new Opcode  { CPU = "65816", DisasmFormat = "pld",              Size = 1, Index = 0x2b },
            new Opcode  { CPU = "6502",  DisasmFormat = "bit ${0:x4}",      Size = 3, Index = 0x2c },
            new Opcode  { CPU = "6502",  DisasmFormat = "and ${0:x4}",      Size = 3, Index = 0x2d },
            new Opcode  { CPU = "6502",  DisasmFormat = "rol ${0:x4}",      Size = 3, Index = 0x2e },
            new Opcode  { CPU = "6502i", DisasmFormat = "rla ${0:x4}",      Size = 3, Index = 0x2f },
            new Opcode  { CPU = "65816", DisasmFormat = "and ${0:x6}",      Size = 4, Index = 0x2f },
            new Opcode  { CPU = "6502",  DisasmFormat = "bmi ${0:x4}",      Size = 2, Index = 0x30 },
            new Opcode  { CPU = "6502",  DisasmFormat = "and (${0:x2}),y",  Size = 2, Index = 0x31 },
            new Opcode  { CPU = "65C02", DisasmFormat = "and (${0:x2})",    Size = 2, Index = 0x32 },
            new Opcode  { CPU = "6502i", DisasmFormat = "rla (${0:x2}),y",  Size = 2, Index = 0x33 },
            new Opcode  { CPU = "65816", DisasmFormat = "and (${0:x2},s),y",Size = 2, Index = 0x33 },
            new Opcode  { CPU = "65C02", DisasmFormat = "bit ${0:x2},x",    Size = 2, Index = 0x34 },
            new Opcode  { CPU = "6502",  DisasmFormat = "and ${0:x2},x",    Size = 2, Index = 0x35 },
            new Opcode  { CPU = "6502",  DisasmFormat = "rol ${0:x2},x",    Size = 2, Index = 0x36 },
            new Opcode  { CPU = "6502i", DisasmFormat = "rla ${0:x2},x",    Size = 2, Index = 0x37 },
            new Opcode  { CPU = "65816", DisasmFormat = "and [${0:x2}],y",  Size = 2, Index = 0x37 },
            new Opcode  { CPU = "6502",  DisasmFormat = "sec",              Size = 1, Index = 0x38 },
            new Opcode  { CPU = "6502",  DisasmFormat = "and ${0:x4},y",    Size = 3, Index = 0x39 },
            new Opcode  { CPU = "65C02", DisasmFormat = "dec",              Size = 1, Index = 0x3a },
            new Opcode  { CPU = "6502i", DisasmFormat = "rla ${0:x4},y",    Size = 3, Index = 0x3b },
            new Opcode  { CPU = "65816", DisasmFormat = "tsc",              Size = 1, Index = 0x3b },
            new Opcode  { CPU = "65C02", DisasmFormat = "bit ${0:x4},x",    Size = 3, Index = 0x3c },
            new Opcode  { CPU = "6502",  DisasmFormat = "and ${0:x4},x",    Size = 3, Index = 0x3d },
            new Opcode  { CPU = "6502",  DisasmFormat = "rol ${0:x4},x",    Size = 3, Index = 0x3e },
            new Opcode  { CPU = "6502i", DisasmFormat = "rla ${0:x4},x",    Size = 3, Index = 0x3f },
            new Opcode  { CPU = "65816", DisasmFormat = "and ${0:x6},x",    Size = 4, Index = 0x3f },
            new Opcode  { CPU = "6502",  DisasmFormat = "rti",              Size = 1, Index = 0x40 },
            new Opcode  { CPU = "6502",  DisasmFormat = "eor (${0:x2},x)",  Size = 2, Index = 0x41 },
            new Opcode  { CPU = "65816", DisasmFormat = "wdm",              Size = 1, Index = 0x42 },
            new Opcode  { CPU = "6502i", DisasmFormat = "sre (${0:x2},x)",  Size = 2, Index = 0x43 },
            new Opcode  { CPU = "65816", DisasmFormat = "eor ${0:x2},s",    Size = 2, Index = 0x43 },
            new Opcode  { CPU = "65816", DisasmFormat = "mvp ${0:x2},${1:x2}",Size = 3, Index = 0x44 },
            new Opcode  { CPU = "6502",  DisasmFormat = "eor ${0:x2}",      Size = 2, Index = 0x45 },
            new Opcode  { CPU = "6502",  DisasmFormat = "lsr ${0:x2}",      Size = 2, Index = 0x46 },
            new Opcode  { CPU = "6502i", DisasmFormat = "sre ${0:x2}",      Size = 2, Index = 0x47 },
            new Opcode  { CPU = "65816", DisasmFormat = "eor [${0:x2}]",    Size = 2, Index = 0x47 },
            new Opcode  { CPU = "6502",  DisasmFormat = "pha",              Size = 1, Index = 0x48 },
            new Opcode  { CPU = "6502",  DisasmFormat = "eor #${0:x2}",     Size = 2, Index = 0x49 },
            new Opcode  { CPU = "6502",  DisasmFormat = "lsr",              Size = 1, Index = 0x4a },
            new Opcode  { CPU = "6502i", DisasmFormat = "asr #${0:x2}",     Size = 2, Index = 0x4b },
            new Opcode  { CPU = "65816", DisasmFormat = "phk",              Size = 1, Index = 0x4b },
            new Opcode  { CPU = "6502",  DisasmFormat = "jmp ${0:x4}",      Size = 3, Index = 0x4c },
            new Opcode  { CPU = "6502",  DisasmFormat = "eor ${0:x4}",      Size = 3, Index = 0x4d },
            new Opcode  { CPU = "6502",  DisasmFormat = "lsr ${0:x4}",      Size = 3, Index = 0x4e },
            new Opcode  { CPU = "6502i", DisasmFormat = "sre ${0:x4}",      Size = 3, Index = 0x4f },
            new Opcode  { CPU = "65816", DisasmFormat = "eor ${0:x6}",      Size = 4, Index = 0x4f },
            new Opcode  { CPU = "6502",  DisasmFormat = "bvc ${0:x4}",      Size = 2, Index = 0x50 },
            new Opcode  { CPU = "6502",  DisasmFormat = "eor (${0:x2}),y",  Size = 2, Index = 0x51 },
            new Opcode  { CPU = "65C02", DisasmFormat = "eor (${0:x2})",    Size = 2, Index = 0x52 },
            new Opcode  { CPU = "6502i", DisasmFormat = "sre (${0:x2}),y",  Size = 2, Index = 0x53 },
            new Opcode  { CPU = "65816", DisasmFormat = "eor (${0:x2},s),y",Size = 2, Index = 0x53 },
            new Opcode  { CPU = "65816", DisasmFormat = "mvn ${0:x2},${1:x2}",Size = 3,Index = 0x54 },
            new Opcode  { CPU = "6502",  DisasmFormat = "eor ${0:x2},x",    Size = 2, Index = 0x55 },
            new Opcode  { CPU = "6502",  DisasmFormat = "lsr ${0:x2},x",    Size = 2, Index = 0x56 },
            new Opcode  { CPU = "6502i", DisasmFormat = "sre ${0:x2},x",    Size = 2, Index = 0x57 },
            new Opcode  { CPU = "65816", DisasmFormat = "eor [${0:x2}],y",  Size = 2, Index = 0x57 },
            new Opcode  { CPU = "6502",  DisasmFormat = "cli",              Size = 1, Index = 0x58 },
            new Opcode  { CPU = "6502",  DisasmFormat = "eor ${0:x4},y",    Size = 3, Index = 0x59 },
            new Opcode  { CPU = "65C02", DisasmFormat = "phy",              Size = 1, Index = 0x5a },
            new Opcode  { CPU = "6502i", DisasmFormat = "sre ${0:x4},y",    Size = 3, Index = 0x5b },
            new Opcode  { CPU = "65816", DisasmFormat = "tcd",              Size = 1, Index = 0x5b },
            new Opcode  { CPU = "65816", DisasmFormat = "jml ${0:x6}",      Size = 4, Index = 0x5c },
            new Opcode  { CPU = "65816", DisasmFormat = "jmp ${0:x6}",      Size = 4, Index = 0x5c },            
            new Opcode  { CPU = "6502",  DisasmFormat = "eor ${0:x4},x",    Size = 3, Index = 0x5d },
            new Opcode  { CPU = "6502",  DisasmFormat = "lsr ${0:x4},x",    Size = 3, Index = 0x5e },
            new Opcode  { CPU = "6502i", DisasmFormat = "sre ${0:x4},x",    Size = 3, Index = 0x5f },
            new Opcode  { CPU = "65816", DisasmFormat = "eor ${0:x6},x",    Size = 4, Index = 0x5f },
            new Opcode  { CPU = "6502",  DisasmFormat = "rts",              Size = 1, Index = 0x60 },
            new Opcode  { CPU = "6502",  DisasmFormat = "adc (${0:x2},x)",  Size = 2, Index = 0x61 },
            new Opcode  { CPU = "65816", DisasmFormat = "per ${0:x4}",      Size = 3, Index = 0x62 },
            new Opcode  { CPU = "6502i", DisasmFormat = "rra (${0:x2},x)",  Size = 2, Index = 0x63 },
            new Opcode  { CPU = "65816", DisasmFormat = "adc ${0:x2},s",    Size = 2, Index = 0x63 },
            new Opcode  { CPU = "65C02", DisasmFormat = "stz ${0:x2}",      Size = 2, Index = 0x64 },
            new Opcode  { CPU = "6502",  DisasmFormat = "adc ${0:x2}",      Size = 2, Index = 0x65 },
            new Opcode  { CPU = "6502",  DisasmFormat = "ror ${0:x2}",      Size = 2, Index = 0x66 },
            new Opcode  { CPU = "6502i", DisasmFormat = "rra ${0:x2}",      Size = 2, Index = 0x67 },
            new Opcode  { CPU = "65816", DisasmFormat = "adc [${0:x2}]",    Size = 2, Index = 0x67 },
            new Opcode  { CPU = "6502",  DisasmFormat = "pla",              Size = 1, Index = 0x68 },
            new Opcode  { CPU = "6502",  DisasmFormat = "adc #${0:x2}",     Size = 2, Index = 0x69 },
            new Opcode  { CPU = "6502",  DisasmFormat = "ror",              Size = 1, Index = 0x6a },
            new Opcode  { CPU = "6502i", DisasmFormat = "arr #${0:x2}",     Size = 2, Index = 0x6b },
            new Opcode  { CPU = "65816", DisasmFormat = "rtl",              Size = 1, Index = 0x6b },
            new Opcode  { CPU = "6502",  DisasmFormat = "jmp (${0:x4})",    Size = 3, Index = 0x6c },
            new Opcode  { CPU = "6502",  DisasmFormat = "adc ${0:x4}",      Size = 3, Index = 0x6d },
            new Opcode  { CPU = "6502",  DisasmFormat = "ror ${0:x4}",      Size = 3, Index = 0x6e },
            new Opcode  { CPU = "6502i", DisasmFormat = "rra ${0:x4}",      Size = 3, Index = 0x6f },
            new Opcode  { CPU = "65816", DisasmFormat = "adc ${0:x6}",      Size = 4, Index = 0x6f },
            new Opcode  { CPU = "6502",  DisasmFormat = "bvs ${0:x4}",      Size = 2, Index = 0x70 },
            new Opcode  { CPU = "6502",  DisasmFormat = "adc (${0:x2}),y",  Size = 2, Index = 0x71 },
            new Opcode  { CPU = "65C02", DisasmFormat = "adc (${0:x2})",    Size = 2, Index = 0x72 },
            new Opcode  { CPU = "6502i", DisasmFormat = "rra (${0:x2}),y",  Size = 2, Index = 0x73 },
            new Opcode  { CPU = "65816", DisasmFormat = "adc (${0:x2},s),y",Size = 2, Index = 0x73 },
            new Opcode  { CPU = "65C02", DisasmFormat = "stz ${0:x2},x",    Size = 2, Index = 0x74 },
            new Opcode  { CPU = "6502",  DisasmFormat = "adc ${0:x2},x",    Size = 2, Index = 0x75 },
            new Opcode  { CPU = "6502",  DisasmFormat = "ror ${0:x2},x",    Size = 2, Index = 0x76 },
            new Opcode  { CPU = "6502i", DisasmFormat = "rra ${0:x2},x",    Size = 2, Index = 0x77 },
            new Opcode  { CPU = "65816", DisasmFormat = "adc [${0:x2}],y",  Size = 2, Index = 0x77 },
            new Opcode  { CPU = "6502",  DisasmFormat = "sei",              Size = 1, Index = 0x78 },
            new Opcode  { CPU = "6502",  DisasmFormat = "adc ${0:x4},y",    Size = 3, Index = 0x79 },
            new Opcode  { CPU = "65C02", DisasmFormat = "ply",              Size = 1, Index = 0x7a },
            new Opcode  { CPU = "6502i", DisasmFormat = "rra ${0:x4},y",    Size = 3, Index = 0x7b },
            new Opcode  { CPU = "65816", DisasmFormat = "tdc",              Size = 1, Index = 0x7b },
            new Opcode  { CPU = "65C02", DisasmFormat = "jmp (${0:x4},x)",  Size = 3, Index = 0x7c },
            new Opcode  { CPU = "6502",  DisasmFormat = "adc ${0:x4},x",    Size = 3, Index = 0x7d },
            new Opcode  { CPU = "6502",  DisasmFormat = "ror ${0:x4},x",    Size = 3, Index = 0x7e },
            new Opcode  { CPU = "6502i", DisasmFormat = "rra ${0:x4},x",    Size = 3, Index = 0x7f },
            new Opcode  { CPU = "65816", DisasmFormat = "adc ${0:x6},x",    Size = 4, Index = 0x7f },
            new Opcode  { CPU = "6502i", DisasmFormat = "dop",              Size = 1, Index = 0x80 },
            new Opcode  { CPU = "6502i", DisasmFormat = "dop #${0:x2}",     Size = 2, Index = 0x80 },
            new Opcode  { CPU = "65C02", DisasmFormat = "bra ${0:x4}",      Size = 2, Index = 0x80 },
            new Opcode  { CPU = "6502",  DisasmFormat = "sta (${0:x2},x)",  Size = 2, Index = 0x81 },
            new Opcode  { CPU = "65816", DisasmFormat = "brl ${0:x4}",      Size = 3, Index = 0x82 },
            new Opcode  { CPU = "6502i", DisasmFormat = "sax (${0:x2},x)",  Size = 2, Index = 0x83 },
            new Opcode  { CPU = "65816", DisasmFormat = "sta ${0:x2},s",    Size = 2, Index = 0x83 },
            new Opcode  { CPU = "6502",  DisasmFormat = "sty ${0:x2}",      Size = 2, Index = 0x84 },
            new Opcode  { CPU = "6502",  DisasmFormat = "sta ${0:x2}",      Size = 2, Index = 0x85 },
            new Opcode  { CPU = "6502",  DisasmFormat = "stx ${0:x2}",      Size = 2, Index = 0x86 },
            new Opcode  { CPU = "6502i", DisasmFormat = "sax ${0:x2}",      Size = 2, Index = 0x87 },
            new Opcode  { CPU = "65816", DisasmFormat = "sta [${0:x2}]",    Size = 2, Index = 0x87 },
            new Opcode  { CPU = "6502",  DisasmFormat = "dey",              Size = 1, Index = 0x88 },
            new Opcode  { CPU = "65C02", DisasmFormat = "bit #${0:x2}",     Size = 2, Index = 0x89 },
            new Opcode  { CPU = "6502",  DisasmFormat = "txa",              Size = 1, Index = 0x8a },
            new Opcode  { CPU = "6502i", DisasmFormat = "ane #${0:x2}",     Size = 2, Index = 0x8b },
            new Opcode  { CPU = "65816", DisasmFormat = "phb",              Size = 1, Index = 0x8b },
            new Opcode  { CPU = "6502",  DisasmFormat = "sty ${0:x4}",      Size = 3, Index = 0x8c },
            new Opcode  { CPU = "6502",  DisasmFormat = "sta ${0:x4}",      Size = 3, Index = 0x8d },
            new Opcode  { CPU = "6502",  DisasmFormat = "stx ${0:x4}",      Size = 3, Index = 0x8e },
            new Opcode  { CPU = "6502i", DisasmFormat = "sax ${0:x4}",      Size = 3, Index = 0x8f },
            new Opcode  { CPU = "65816", DisasmFormat = "sta ${0:x6}",      Size = 4, Index = 0x8f },
            new Opcode  { CPU = "6502",  DisasmFormat = "bcc ${0:x4}",      Size = 2, Index = 0x90 },
            new Opcode  { CPU = "6502",  DisasmFormat = "sta (${0:x2}),y",  Size = 2, Index = 0x91 },
            new Opcode  { CPU = "65C02", DisasmFormat = "sta (${0:x2})",    Size = 2, Index = 0x92 },
            new Opcode  { CPU = "6502i", DisasmFormat = "sha (${0:x2}),y",  Size = 2, Index = 0x93 },
            new Opcode  { CPU = "65816", DisasmFormat = "sta (${0:x2},s),y",Size = 2, Index = 0x93 },
            new Opcode  { CPU = "6502",  DisasmFormat = "sty ${0:x2},x",    Size = 2, Index = 0x94 },
            new Opcode  { CPU = "6502",  DisasmFormat = "sta ${0:x2},x",    Size = 2, Index = 0x95 },
            new Opcode  { CPU = "6502",  DisasmFormat = "stx ${0:x2},y",    Size = 2, Index = 0x96 },
            new Opcode  { CPU = "6502i", DisasmFormat = "sax ${0:x2},y",    Size = 2, Index = 0x97 },
            new Opcode  { CPU = "65816", DisasmFormat = "sta [${0:x2}],y",  Size = 2, Index = 0x97 },
            new Opcode  { CPU = "6502",  DisasmFormat = "tya",              Size = 1, Index = 0x98 },
            new Opcode  { CPU = "6502",  DisasmFormat = "sta ${0:x4},y",    Size = 3, Index = 0x99 },
            new Opcode  { CPU = "6502",  DisasmFormat = "txs",              Size = 1, Index = 0x9a },
            new Opcode  { CPU = "6502i", DisasmFormat = "tas ${0:x4},y",    Size = 3, Index = 0x9b },
            new Opcode  { CPU = "65816", DisasmFormat = "txy",              Size = 1, Index = 0x9b },
            new Opcode  { CPU = "6502i", DisasmFormat = "shy ${0:x4},x",    Size = 3, Index = 0x9c },
            new Opcode  { CPU = "65C02", DisasmFormat = "stz ${0:x4}",      Size = 3, Index = 0x9c },
            new Opcode  { CPU = "6502",  DisasmFormat = "sta ${0:x4},x",    Size = 3, Index = 0x9d },
            new Opcode  { CPU = "6502i", DisasmFormat = "shx ${0:x4},y",    Size = 3, Index = 0x9e },
            new Opcode  { CPU = "65C02", DisasmFormat = "stz ${0:x4},x",    Size = 3, Index = 0x9e },
            new Opcode  { CPU = "6502i", DisasmFormat = "sha ${0:x4},y",    Size = 3, Index = 0x9f },
            new Opcode  { CPU = "65816", DisasmFormat = "sta ${0:x6},x",    Size = 4, Index = 0x9f },
            new Opcode  { CPU = "6502",  DisasmFormat = "ldy #${0:x2}",     Size = 2, Index = 0xa0 },
            new Opcode  { CPU = "6502",  DisasmFormat = "lda (${0:x2},x)",  Size = 2, Index = 0xa1 },
            new Opcode  { CPU = "6502",  DisasmFormat = "ldx #${0:x2}",     Size = 2, Index = 0xa2 },
            new Opcode  { CPU = "6502i", DisasmFormat = "lax (${0:x2},x)",  Size = 2, Index = 0xa3 },
            new Opcode  { CPU = "65816", DisasmFormat = "lda ${0:x2},s",    Size = 2, Index = 0xa3 },
            new Opcode  { CPU = "6502",  DisasmFormat = "ldy ${0:x2}",      Size = 2, Index = 0xa4 },
            new Opcode  { CPU = "6502",  DisasmFormat = "lda ${0:x2}",      Size = 2, Index = 0xa5 },
            new Opcode  { CPU = "6502",  DisasmFormat = "ldx ${0:x2}",      Size = 2, Index = 0xa6 },
            new Opcode  { CPU = "6502i", DisasmFormat = "lax ${0:x2}",      Size = 2, Index = 0xa7 },
            new Opcode  { CPU = "65816", DisasmFormat = "lda [${0:x2}]",    Size = 2, Index = 0xa7 },
            new Opcode  { CPU = "6502",  DisasmFormat = "tay",              Size = 1, Index = 0xa8 },
            new Opcode  { CPU = "6502",  DisasmFormat = "lda #${0:x2}",     Size = 2, Index = 0xa9 },
            new Opcode  { CPU = "6502",  DisasmFormat = "tax",              Size = 1, Index = 0xaa },
            new Opcode  { CPU = "65816", DisasmFormat = "plb",              Size = 1, Index = 0xab },
            new Opcode  { CPU = "6502",  DisasmFormat = "ldy ${0:x4}",      Size = 3, Index = 0xac },
            new Opcode  { CPU = "6502",  DisasmFormat = "lda ${0:x4}",      Size = 3, Index = 0xad },
            new Opcode  { CPU = "6502",  DisasmFormat = "ldx ${0:x4}",      Size = 3, Index = 0xae },
            new Opcode  { CPU = "6502i", DisasmFormat = "lax ${0:x4}",      Size = 3, Index = 0xaf },
            new Opcode  { CPU = "65816", DisasmFormat = "lda ${0:x6}",      Size = 4, Index = 0xaf },
            new Opcode  { CPU = "6502",  DisasmFormat = "bcs ${0:x4}",      Size = 2, Index = 0xb0 },
            new Opcode  { CPU = "6502",  DisasmFormat = "lda (${0:x2}),y",  Size = 2, Index = 0xb1 },
            new Opcode  { CPU = "65C02", DisasmFormat = "lda (${0:x2})",    Size = 2, Index = 0xb2 },
            new Opcode  { CPU = "6502i", DisasmFormat = "lax (${0:x2}),y",  Size = 2, Index = 0xb3 },
            new Opcode  { CPU = "65816", DisasmFormat = "lda (${0:x2},s),y",Size = 2, Index = 0xb3 },
            new Opcode  { CPU = "6502",  DisasmFormat = "ldy ${0:x2},x",    Size = 2, Index = 0xb4 },
            new Opcode  { CPU = "6502",  DisasmFormat = "lda ${0:x2},x",    Size = 2, Index = 0xb5 },
            new Opcode  { CPU = "6502",  DisasmFormat = "ldx ${0:x2},y",    Size = 2, Index = 0xb6 },
            new Opcode  { CPU = "6502i", DisasmFormat = "lax ${0:x2},y",    Size = 2, Index = 0xb7 },
            new Opcode  { CPU = "65816", DisasmFormat = "lda [${0:x2}],y",  Size = 2, Index = 0xb7 },
            new Opcode  { CPU = "6502",  DisasmFormat = "clv",              Size = 1, Index = 0xb8 },
            new Opcode  { CPU = "6502",  DisasmFormat = "lda ${0:x4},y",    Size = 3, Index = 0xb9 },
            new Opcode  { CPU = "6502",  DisasmFormat = "tsx",              Size = 1, Index = 0xba },
            new Opcode  { CPU = "6502i", DisasmFormat = "las ${0:x4},y",    Size = 3, Index = 0xbb },
            new Opcode  { CPU = "65816", DisasmFormat = "tyx",              Size = 1, Index = 0xbb },
            new Opcode  { CPU = "6502",  DisasmFormat = "ldy ${0:x4},x",    Size = 3, Index = 0xbc },
            new Opcode  { CPU = "6502",  DisasmFormat = "lda ${0:x4},x",    Size = 3, Index = 0xbd },
            new Opcode  { CPU = "6502",  DisasmFormat = "ldx ${0:x4},y",    Size = 3, Index = 0xbe },
            new Opcode  { CPU = "6502i", DisasmFormat = "lax ${0:x4},y",    Size = 3, Index = 0xbf },
            new Opcode  { CPU = "65816", DisasmFormat = "lda ${0:x6},x",    Size = 4, Index = 0xbf },
            new Opcode  { CPU = "6502",  DisasmFormat = "cpy #${0:x2}",     Size = 2, Index = 0xc0 },
            new Opcode  { CPU = "6502",  DisasmFormat = "cmp (${0:x2},x)",  Size = 2, Index = 0xc1 },
            new Opcode  { CPU = "65816", DisasmFormat = "rep #${0:x2}",     Size = 2, Index = 0xc2 },
            new Opcode  { CPU = "6502i", DisasmFormat = "dcp (${0:x2},x)",  Size = 2, Index = 0xc3 },
            new Opcode  { CPU = "65816", DisasmFormat = "cmp ${0:x2},s",    Size = 2, Index = 0xc3 },
            new Opcode  { CPU = "6502",  DisasmFormat = "cpy ${0:x2}",      Size = 2, Index = 0xc4 },
            new Opcode  { CPU = "6502",  DisasmFormat = "cmp ${0:x2}",      Size = 2, Index = 0xc5 },
            new Opcode  { CPU = "6502",  DisasmFormat = "dec ${0:x2}",      Size = 2, Index = 0xc6 },
            new Opcode  { CPU = "6502i", DisasmFormat = "dcp ${0:x2}",      Size = 2, Index = 0xc7 },
            new Opcode  { CPU = "65816", DisasmFormat = "cmp [${0:x2}]",    Size = 2, Index = 0xc7 },
            new Opcode  { CPU = "6502",  DisasmFormat = "iny",              Size = 1, Index = 0xc8 },
            new Opcode  { CPU = "6502",  DisasmFormat = "cmp #${0:x2}",     Size = 2, Index = 0xc9 },
            new Opcode  { CPU = "6502",  DisasmFormat = "dex",              Size = 1, Index = 0xca },
            new Opcode  { CPU = "6502i", DisasmFormat = "sax #${0:x2}",     Size = 2, Index = 0xcb },
            new Opcode  { CPU = "65816", DisasmFormat = "wai",              Size = 1, Index = 0xcb },
            new Opcode  { CPU = "6502",  DisasmFormat = "cpy ${0:x4}",      Size = 3, Index = 0xcc },
            new Opcode  { CPU = "6502",  DisasmFormat = "cmp ${0:x4}",      Size = 3, Index = 0xcd },
            new Opcode  { CPU = "6502",  DisasmFormat = "dec ${0:x4}",      Size = 3, Index = 0xce },
            new Opcode  { CPU = "6502i", DisasmFormat = "dcp ${0:x4}",      Size = 3, Index = 0xcf },
            new Opcode  { CPU = "65816", DisasmFormat = "cmp ${0:x6}",      Size = 4, Index = 0xcf },
            new Opcode  { CPU = "6502",  DisasmFormat = "bne ${0:x4}",      Size = 2, Index = 0xd0 },
            new Opcode  { CPU = "6502",  DisasmFormat = "cmp (${0:x2}),y",  Size = 2, Index = 0xd1 },
            new Opcode  { CPU = "65C02", DisasmFormat = "cmp (${0:x2})",    Size = 2, Index = 0xd2 },
            new Opcode  { CPU = "6502i", DisasmFormat = "dcp (${0:x2}),y",  Size = 2, Index = 0xd3 },
            new Opcode  { CPU = "65816", DisasmFormat = "cmp (${0:x2},s),y",Size = 2, Index = 0xd3 },
            new Opcode  { CPU = "65816", DisasmFormat = "pei (${0:x2})",    Size = 2, Index = 0xd4 },
            new Opcode  { CPU = "6502",  DisasmFormat = "cmp ${0:x2},x",    Size = 2, Index = 0xd5 },
            new Opcode  { CPU = "6502",  DisasmFormat = "dec ${0:x2},x",    Size = 2, Index = 0xd6 },
            new Opcode  { CPU = "6502i", DisasmFormat = "dcp ${0:x2},x",    Size = 2, Index = 0xd7 },
            new Opcode  { CPU = "65816", DisasmFormat = "cmp [${0:x2}],y",  Size = 2, Index = 0xd7 },
            new Opcode  { CPU = "6502",  DisasmFormat = "cld",              Size = 1, Index = 0xd8 },
            new Opcode  { CPU = "6502",  DisasmFormat = "cmp ${0:x4},y",    Size = 3, Index = 0xd9 },
            new Opcode  { CPU = "65C02", DisasmFormat = "phx",              Size = 1, Index = 0xda },
            new Opcode  { CPU = "6502i", DisasmFormat = "dcp ${0:x4},y",    Size = 3, Index = 0xdb },
            new Opcode  { CPU = "65816", DisasmFormat = "stp",              Size = 1, Index = 0xdb },
            new Opcode  { CPU = "65816", DisasmFormat = "jmp [${0:x4}]",    Size = 3, Index = 0xdc },
            new Opcode  { CPU = "6502",  DisasmFormat = "cmp ${0:x4},x",    Size = 3, Index = 0xdd },
            new Opcode  { CPU = "6502",  DisasmFormat = "dec ${0:x4},x",    Size = 3, Index = 0xde },
            new Opcode  { CPU = "6502i", DisasmFormat = "dcp ${0:x4},x",    Size = 3, Index = 0xdf },
            new Opcode  { CPU = "65816", DisasmFormat = "cmp ${0:x6},x",    Size = 4, Index = 0xdf },
            new Opcode  { CPU = "6502",  DisasmFormat = "cpx #${0:x2}",     Size = 2, Index = 0xe0 },
            new Opcode  { CPU = "6502",  DisasmFormat = "sbc (${0:x2},x)",  Size = 2, Index = 0xe1 },
            new Opcode  { CPU = "65816", DisasmFormat = "sep #${0:x2}",     Size = 2, Index = 0xe2 },
            new Opcode  { CPU = "6502i", DisasmFormat = "isb (${0:x2},x)",  Size = 2, Index = 0xe3 },
            new Opcode  { CPU = "65816", DisasmFormat = "sbc ${0:x2},s",    Size = 2, Index = 0xe3 },
            new Opcode  { CPU = "6502",  DisasmFormat = "cpx ${0:x2}",      Size = 2, Index = 0xe4 },
            new Opcode  { CPU = "6502",  DisasmFormat = "sbc ${0:x2}",      Size = 2, Index = 0xe5 },
            new Opcode  { CPU = "6502",  DisasmFormat = "inc ${0:x2}",      Size = 2, Index = 0xe6 },
            new Opcode  { CPU = "6502i", DisasmFormat = "isb ${0:x2}",      Size = 2, Index = 0xe7 },
            new Opcode  { CPU = "65816", DisasmFormat = "sbc [${0:x2}]",    Size = 2, Index = 0xe7 },
            new Opcode  { CPU = "6502",  DisasmFormat = "inx",              Size = 1, Index = 0xe8 },
            new Opcode  { CPU = "6502",  DisasmFormat = "sbc #${0:x2}",     Size = 2, Index = 0xe9 },
            new Opcode  { CPU = "6502",  DisasmFormat = "nop",              Size = 1, Index = 0xea },
            new Opcode  { CPU = "65816", DisasmFormat = "xba",              Size = 1, Index = 0xeb },
            new Opcode  { CPU = "6502",  DisasmFormat = "cpx ${0:x4}",      Size = 3, Index = 0xec },
            new Opcode  { CPU = "6502",  DisasmFormat = "sbc ${0:x4}",      Size = 3, Index = 0xed },
            new Opcode  { CPU = "6502",  DisasmFormat = "inc ${0:x4}",      Size = 3, Index = 0xee },
            new Opcode  { CPU = "6502i", DisasmFormat = "isb ${0:x4}",      Size = 3, Index = 0xef },
            new Opcode  { CPU = "65816", DisasmFormat = "sbc ${0:x6}",      Size = 4, Index = 0xef },
            new Opcode  { CPU = "6502",  DisasmFormat = "beq ${0:x4}",      Size = 2, Index = 0xf0 },
            new Opcode  { CPU = "6502",  DisasmFormat = "sbc (${0:x2}),y",  Size = 2, Index = 0xf1 },
            new Opcode  { CPU = "65C02", DisasmFormat = "sbc (${0:x2})",    Size = 2, Index = 0xf2 },
            new Opcode  { CPU = "6502i", DisasmFormat = "isb (${0:x2}),y",  Size = 2, Index = 0xf3 },
            new Opcode  { CPU = "65816", DisasmFormat = "sbc (${0:x2},s),y",Size = 2, Index = 0xf3 },
            new Opcode  { CPU = "65816", DisasmFormat = "pea ${0:x4}",      Size = 3, Index = 0xf4 },
            new Opcode  { CPU = "6502",  DisasmFormat = "sbc ${0:x2},x",    Size = 2, Index = 0xf5 },
            new Opcode  { CPU = "6502",  DisasmFormat = "inc ${0:x2},x",    Size = 2, Index = 0xf6 },
            new Opcode  { CPU = "6502i", DisasmFormat = "isb ${0:x2},x",    Size = 2, Index = 0xf7 },
            new Opcode  { CPU = "65816", DisasmFormat = "sbc [${0:x2}],y",  Size = 2, Index = 0xf7 },
            new Opcode  { CPU = "6502",  DisasmFormat = "sed",              Size = 1, Index = 0xf8 },
            new Opcode  { CPU = "6502",  DisasmFormat = "sbc ${0:x4},y",    Size = 3, Index = 0xf9 },
            new Opcode  { CPU = "65C02", DisasmFormat = "plx",              Size = 1, Index = 0xfa },
            new Opcode  { CPU = "6502i", DisasmFormat = "isb ${0:x4},y",    Size = 3, Index = 0xfb },
            new Opcode  { CPU = "65816", DisasmFormat = "xce",              Size = 1, Index = 0xfb },
            new Opcode  { CPU = "6502",  DisasmFormat = "sbc ${0:x4},x",    Size = 3, Index = 0xfd },
            new Opcode  { CPU = "6502",  DisasmFormat = "inc ${0:x4},x",    Size = 3, Index = 0xfe },
            new Opcode  { CPU = "6502i", DisasmFormat = "isb ${0:x4},x",    Size = 3, Index = 0xff },
            new Opcode  { CPU = "65816", DisasmFormat = "sbc ${0:x6},x",    Size = 4, Index = 0xff }
        };

        #endregion
    }
}