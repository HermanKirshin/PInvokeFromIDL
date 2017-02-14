/*

Hook library was taken from here: http://www.codeproject.com/Articles/44326/MinHook-The-Minimalistic-x86-x64-API-Hooking-Libra

*/

#define DLL_PROCESS_ATTACH   1    
#define DLL_PROCESS_DETACH   0   

#define MEM_RESERVE             0x2000
#define MEM_RELEASE             0x8000
#define MEM_COMMIT              0x1000
#define MEM_FREE                0x10000
#define PAGE_READONLY           0x02
#define PAGE_READWRITE          0x04
#define PAGE_EXECUTE_READ       0x20
#define PAGE_EXECUTE_READWRITE  0x40
#define PAGE_EXECUTE            0x10
#define PAGE_EXECUTE_WRITECOPY  0x80

typedef struct __declspec(align(16)) MEMORY_BASIC_INFORMATION
{
    void* BaseAddress;
    void* AllocationBase;
    unsigned int AllocationProtect;
    unsigned int __alignment1;
    unsigned long long RegionSize;
    unsigned int State;
    unsigned int Protect;
    unsigned int Type;
    unsigned int __alignment2;
} MEMORY_BASIC_INFORMATION;

typedef struct SYSTEM_INFO
{
    union
    {
        unsigned int dwOemId;
        struct
        {
            unsigned short wProcessorArchitecture;
            unsigned short wReserved;
        };
    };
    unsigned int dwPageSize;
    void* lpMinimumApplicationAddress;
    void* lpMaximumApplicationAddress;
    unsigned long long dwActiveProcessorMask;
    unsigned int dwNumberOfProcessors;
    unsigned int dwProcessorType;
    unsigned int dwAllocationGranularity;
    unsigned short wProcessorLevel;
    unsigned short wProcessorRevision;
} SYSTEM_INFO;

typedef struct UNICODE_STRING
{
    unsigned short Length;
    unsigned short MaximumLength;
    short*  Buffer;
} UNICODE_STRING;

typedef struct STRING
{
    unsigned short Length;
    unsigned short MaximumLength;
    char*  Buffer;
} ANSI_STRING;

typedef enum MEMORY_INFORMATION_CLASS
{
    MemoryBasicInformation
} MEMORY_INFORMATION_CLASS;

__declspec(dllimport) void* __cdecl memset(void * _Dst, int _Val, void* _Size);

__declspec(dllimport) int __stdcall LdrLoadDll(short* PathToFile, unsigned int Flags, UNICODE_STRING* ModuleFileName, void* ModuleHandle);
__declspec(dllimport) int __stdcall LdrGetProcedureAddress(void* ModuleHandle, ANSI_STRING* FunctionName, unsigned short Oridinal, void** FunctionAddress);
__declspec(dllimport) int __stdcall LdrUnloadDll(void* ModuleHandle);
__declspec(dllimport) void __stdcall RtlCopyMemory(void *Destination, const void *Source, void* Length);

__declspec(dllimport) int __stdcall NtAllocateVirtualMemory(void* ProcessHandle, void** BaseAddress, void* ZeroBits, void** RegionSize, unsigned int AllocationType, unsigned int Protect);
__declspec(dllimport) int __stdcall NtFreeVirtualMemory(void* ProcessHandle, void** BaseAddress, void** RegionSize, unsigned int FreeType);
__declspec(dllimport) int __stdcall NtProtectVirtualMemory(void* ProcessHandle, void** BaseAddress, void** NumberOfBytesToProtect, unsigned int NewAccessProtection, unsigned int* OldAccessProtection);
__declspec(dllimport) int __stdcall NtQueryVirtualMemory(void* ProcessHandle, void* BaseAddress, MEMORY_INFORMATION_CLASS MemoryInformationClass, void* Buffer, void* Length, void** ResultLength);

#define FIELD_OFFSET(type, field)    ((int)(unsigned long long)&(((type *)0)->field))
#define TYPE_ALIGNMENT( t ) FIELD_OFFSET(struct { char x; t test; }, test)

#define InitUnicodeString(x) { sizeof(x) - 2, sizeof(x) - 2, x }
#define InitAnsiString(x) { sizeof(x) - 1, sizeof(x) - 1, x }

#define ALIGNED_SIZE(x) ((x + TYPE_ALIGNMENT(void*) - 1) & ~(TYPE_ALIGNMENT(void*) - 1))

void* kernel32;
void* getSystemInfo;

#pragma pack(1)

typedef struct JMP_REL_SHORT
{
    unsigned char		opcode;
    unsigned char		operand;
}JMP_REL_SHORT;

typedef struct JMP_REL
{
    unsigned char		opcode;
    unsigned long	operand;
}JMP_REL;

typedef struct JMP_ABS
{
    unsigned short	opcode;
    unsigned long	operand;
}JMP_ABS;

typedef struct JCC_ABS
{
    unsigned char	opcode;
    unsigned char	dummy0;
    unsigned char	dummy1;
    unsigned char	dummy2;
    unsigned short	dummy3;
    unsigned long	operand;
}JCC_ABS;

typedef struct HOOK_ENTRY
{
    void*	pTarget;
    void*	pDetour;
    void*	pTable;
    void*	pRelay;
    void*	pTrampoline;
    void*	pBackup;
    int	    patchAbove;

    char		            trampoline[64];
    unsigned long long      trampolineSize;

    struct
    {
        void*	address;
        unsigned long long		position;
        unsigned long long		pc;
    } tempAddr[16];
    int                     tempAddrSize;
    void*	                table[16];
    int                     tableSize;
} HOOK_ENTRY;

#define C_NONE    0x00
#define C_MODRM   0x01
#define C_IMM8    0x02
#define C_IMM16   0x04
#define C_IMM_P66 0x10
#define C_REL8    0x20
#define C_REL32   0x40
#define C_GROUP   0x80
#define C_ERROR   0xff

#define PRE_ANY  0x00
#define PRE_NONE 0x01
#define PRE_F2   0x02
#define PRE_F3   0x04
#define PRE_66   0x08
#define PRE_67   0x10
#define PRE_LOCK 0x20
#define PRE_SEG  0x40
#define PRE_ALL  0xff

#define DELTA_OPCODES      0x4a
#define DELTA_FPU_REG      0xfd
#define DELTA_FPU_MODRM    0x104
#define DELTA_PREFIXES     0x13c
#define DELTA_OP_LOCK_OK   0x1ae
#define DELTA_OP2_LOCK_OK  0x1c6
#define DELTA_OP_ONLY_MEM  0x1d8
#define DELTA_OP2_ONLY_MEM 0x1e7

unsigned char hde64_table[] =
{
    0xa5, 0xaa, 0xa5, 0xb8, 0xa5, 0xaa, 0xa5, 0xaa, 0xa5, 0xb8, 0xa5, 0xb8, 0xa5, 0xb8, 0xa5,
    0xb8, 0xc0, 0xc0, 0xc0, 0xc0, 0xc0, 0xc0, 0xc0, 0xc0, 0xac, 0xc0, 0xcc, 0xc0, 0xa1, 0xa1,
    0xa1, 0xa1, 0xb1, 0xa5, 0xa5, 0xa6, 0xc0, 0xc0, 0xd7, 0xda, 0xe0, 0xc0, 0xe4, 0xc0, 0xea,
    0xea, 0xe0, 0xe0, 0x98, 0xc8, 0xee, 0xf1, 0xa5, 0xd3, 0xa5, 0xa5, 0xa1, 0xea, 0x9e, 0xc0,
    0xc0, 0xc2, 0xc0, 0xe6, 0x03, 0x7f, 0x11, 0x7f, 0x01, 0x7f, 0x01, 0x3f, 0x01, 0x01, 0xab,
    0x8b, 0x90, 0x64, 0x5b, 0x5b, 0x5b, 0x5b, 0x5b, 0x92, 0x5b, 0x5b, 0x76, 0x90, 0x92, 0x92,
    0x5b, 0x5b, 0x5b, 0x5b, 0x5b, 0x5b, 0x5b, 0x5b, 0x5b, 0x5b, 0x5b, 0x5b, 0x6a, 0x73, 0x90,
    0x5b, 0x52, 0x52, 0x52, 0x52, 0x5b, 0x5b, 0x5b, 0x5b, 0x77, 0x7c, 0x77, 0x85, 0x5b, 0x5b,
    0x70, 0x5b, 0x7a, 0xaf, 0x76, 0x76, 0x5b, 0x5b, 0x5b, 0x5b, 0x5b, 0x5b, 0x5b, 0x5b, 0x5b,
    0x5b, 0x5b, 0x86, 0x01, 0x03, 0x01, 0x04, 0x03, 0xd5, 0x03, 0xd5, 0x03, 0xcc, 0x01, 0xbc,
    0x03, 0xf0, 0x03, 0x03, 0x04, 0x00, 0x50, 0x50, 0x50, 0x50, 0xff, 0x20, 0x20, 0x20, 0x20,
    0x01, 0x01, 0x01, 0x01, 0xc4, 0x02, 0x10, 0xff, 0xff, 0xff, 0x01, 0x00, 0x03, 0x11, 0xff,
    0x03, 0xc4, 0xc6, 0xc8, 0x02, 0x10, 0x00, 0xff, 0xcc, 0x01, 0x01, 0x01, 0x00, 0x00, 0x00,
    0x00, 0x01, 0x01, 0x03, 0x01, 0xff, 0xff, 0xc0, 0xc2, 0x10, 0x11, 0x02, 0x03, 0x01, 0x01,
    0x01, 0xff, 0xff, 0xff, 0x00, 0x00, 0x00, 0xff, 0x00, 0x00, 0xff, 0xff, 0xff, 0xff, 0x10,
    0x10, 0x10, 0x10, 0x02, 0x10, 0x00, 0x00, 0xc6, 0xc8, 0x02, 0x02, 0x02, 0x02, 0x06, 0x00,
    0x04, 0x00, 0x02, 0xff, 0x00, 0xc0, 0xc2, 0x01, 0x01, 0x03, 0x03, 0x03, 0xca, 0x40, 0x00,
    0x0a, 0x00, 0x04, 0x00, 0x00, 0x00, 0x00, 0x7f, 0x00, 0x33, 0x01, 0x00, 0x00, 0x00, 0x00,
    0x00, 0x00, 0xff, 0xbf, 0xff, 0xff, 0x00, 0x00, 0x00, 0x00, 0x07, 0x00, 0x00, 0xff, 0x00,
    0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xff, 0xff,
    0x00, 0x00, 0x00, 0xbf, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x7f, 0x00, 0x00,
    0xff, 0x40, 0x40, 0x40, 0x40, 0x41, 0x49, 0x40, 0x40, 0x40, 0x40, 0x4c, 0x42, 0x40, 0x40,
    0x40, 0x40, 0x40, 0x40, 0x40, 0x40, 0x4f, 0x44, 0x53, 0x40, 0x40, 0x40, 0x44, 0x57, 0x43,
    0x5c, 0x40, 0x60, 0x40, 0x40, 0x40, 0x40, 0x40, 0x40, 0x40, 0x40, 0x40, 0x40, 0x40, 0x40,
    0x40, 0x40, 0x64, 0x66, 0x6e, 0x6b, 0x40, 0x40, 0x6a, 0x46, 0x40, 0x40, 0x44, 0x46, 0x40,
    0x40, 0x5b, 0x44, 0x40, 0x40, 0x00, 0x00, 0x00, 0x00, 0x06, 0x06, 0x06, 0x06, 0x01, 0x06,
    0x06, 0x02, 0x06, 0x06, 0x00, 0x06, 0x00, 0x0a, 0x0a, 0x00, 0x00, 0x00, 0x02, 0x07, 0x07,
    0x06, 0x02, 0x0d, 0x06, 0x06, 0x06, 0x0e, 0x05, 0x05, 0x02, 0x02, 0x00, 0x00, 0x04, 0x04,
    0x04, 0x04, 0x05, 0x06, 0x06, 0x06, 0x00, 0x00, 0x00, 0x0e, 0x00, 0x00, 0x08, 0x00, 0x10,
    0x00, 0x18, 0x00, 0x20, 0x00, 0x28, 0x00, 0x30, 0x00, 0x80, 0x01, 0x82, 0x01, 0x86, 0x00,
    0xf6, 0xcf, 0xfe, 0x3f, 0xab, 0x00, 0xb0, 0x00, 0xb1, 0x00, 0xb3, 0x00, 0xba, 0xf8, 0xbb,
    0x00, 0xc0, 0x00, 0xc1, 0x00, 0xc7, 0xbf, 0x62, 0xff, 0x00, 0x8d, 0xff, 0x00, 0xc4, 0xff,
    0x00, 0xc5, 0xff, 0x00, 0xff, 0xff, 0xeb, 0x01, 0xff, 0x0e, 0x12, 0x08, 0x00, 0x13, 0x09,
    0x00, 0x16, 0x08, 0x00, 0x17, 0x09, 0x00, 0x2b, 0x09, 0x00, 0xae, 0xff, 0x07, 0xb2, 0xff,
    0x00, 0xb4, 0xff, 0x00, 0xb5, 0xff, 0x00, 0xc3, 0x01, 0x00, 0xc7, 0xff, 0xbf, 0xe7, 0x08,
    0x00, 0xf0, 0x02, 0x00
};

#define F_MODRM         0x00000001
#define F_SIB           0x00000002
#define F_IMM8          0x00000004
#define F_IMM16         0x00000008
#define F_IMM32         0x00000010
#define F_IMM64         0x00000020
#define F_DISP8         0x00000040
#define F_DISP16        0x00000080
#define F_DISP32        0x00000100
#define F_RELATIVE      0x00000200
#define F_ERROR         0x00001000
#define F_ERROR_OPCODE  0x00002000
#define F_ERROR_LENGTH  0x00004000
#define F_ERROR_LOCK    0x00008000
#define F_ERROR_OPERAND 0x00010000
#define F_PREFIX_REPNZ  0x01000000
#define F_PREFIX_REPX   0x02000000
#define F_PREFIX_REP    0x03000000
#define F_PREFIX_66     0x04000000
#define F_PREFIX_67     0x08000000
#define F_PREFIX_LOCK   0x10000000
#define F_PREFIX_SEG    0x20000000
#define F_PREFIX_REX    0x40000000
#define F_PREFIX_ANY    0x7f000000

#define PREFIX_SEGMENT_CS   0x2e
#define PREFIX_SEGMENT_SS   0x36
#define PREFIX_SEGMENT_DS   0x3e
#define PREFIX_SEGMENT_ES   0x26
#define PREFIX_SEGMENT_FS   0x64
#define PREFIX_SEGMENT_GS   0x65
#define PREFIX_LOCK         0xf0
#define PREFIX_REPNZ        0xf2
#define PREFIX_REPX         0xf3
#define PREFIX_OPERAND_SIZE 0x66
#define PREFIX_ADDRESS_SIZE 0x67

typedef struct
{
    unsigned char len;
    unsigned char p_rep;
    unsigned char p_lock;
    unsigned char p_seg;
    unsigned char p_66;
    unsigned char p_67;
    unsigned char rex;
    unsigned char rex_w;
    unsigned char rex_r;
    unsigned char rex_x;
    unsigned char rex_b;
    unsigned char opcode;
    unsigned char opcode2;
    unsigned char modrm;
    unsigned char modrm_mod;
    unsigned char modrm_reg;
    unsigned char modrm_rm;
    unsigned char sib;
    unsigned char sib_scale;
    unsigned char sib_index;
    unsigned char sib_base;
    union {
        unsigned char imm8;
        unsigned short imm16;
        unsigned long imm32;
        unsigned __int64 imm64;
    } imm;
    union {
        unsigned char disp8;
        unsigned short disp16;
        unsigned long disp32;
    } disp;
    unsigned long flags;
} hde64s;

unsigned int hde64_disasm(const void *code, hde64s *hs)
{
    memset(hs, 0, (void*)sizeof(hde64s));

    unsigned char x, c, *p = (unsigned char *)code, cflags, opcode, pref = 0;
    unsigned char *ht = hde64_table, m_mod, m_reg, m_rm, disp_size = 0;
    unsigned char op64 = 0;

    for (x = 16; x; x--)
        switch (c = *p++) {
        case 0xf3:
            hs->p_rep = c;
            pref |= PRE_F3;
            break;
        case 0xf2:
            hs->p_rep = c;
            pref |= PRE_F2;
            break;
        case 0xf0:
            hs->p_lock = c;
            pref |= PRE_LOCK;
            break;
        case 0x26: case 0x2e: case 0x36:
        case 0x3e: case 0x64: case 0x65:
            hs->p_seg = c;
            pref |= PRE_SEG;
            break;
        case 0x66:
            hs->p_66 = c;
            pref |= PRE_66;
            break;
        case 0x67:
            hs->p_67 = c;
            pref |= PRE_67;
            break;
        default:
            goto pref_done;
    }
pref_done:

    hs->flags = (unsigned long)pref << 23;

    if (!pref)
        pref |= PRE_NONE;

    if ((c & 0xf0) == 0x40) {
        hs->flags |= F_PREFIX_REX;
        if ((hs->rex_w = (c & 0xf) >> 3) && (*p & 0xf8) == 0xb8)
            op64++;
        hs->rex_r = (c & 7) >> 2;
        hs->rex_x = (c & 3) >> 1;
        hs->rex_b = c & 1;
        if (((c = *p++) & 0xf0) == 0x40) {
            opcode = c;
            goto error_opcode;
        }
    }

    if ((hs->opcode = c) == 0x0f) {
        hs->opcode2 = c = *p++;
        ht += DELTA_OPCODES;
    }
    else if (c >= 0xa0 && c <= 0xa3) {
        op64++;
        if (pref & PRE_67)
            pref |= PRE_66;
        else
            pref &= ~PRE_66;
    }

    opcode = c;
    cflags = ht[ht[opcode / 4] + (opcode % 4)];

    if (cflags == C_ERROR) {
    error_opcode:
        hs->flags |= F_ERROR | F_ERROR_OPCODE;
        cflags = 0;
        if ((opcode & -3) == 0x24)
            cflags++;
    }

    x = 0;
    if (cflags & C_GROUP) {
        unsigned short t;
        t = *(unsigned short *)(ht + (cflags & 0x7f));
        cflags = (unsigned char)t;
        x = (unsigned char)(t >> 8);
    }

    if (hs->opcode2) {
        ht = hde64_table + DELTA_PREFIXES;
        if (ht[ht[opcode / 4] + (opcode % 4)] & pref)
            hs->flags |= F_ERROR | F_ERROR_OPCODE;
    }

    if (cflags & C_MODRM) {
        hs->flags |= F_MODRM;
        hs->modrm = c = *p++;
        hs->modrm_mod = m_mod = c >> 6;
        hs->modrm_rm = m_rm = c & 7;
        hs->modrm_reg = m_reg = (c & 0x3f) >> 3;

        if (x && ((x << m_reg) & 0x80))
            hs->flags |= F_ERROR | F_ERROR_OPCODE;

        if (!hs->opcode2 && opcode >= 0xd9 && opcode <= 0xdf) {
            unsigned char t = opcode - 0xd9;
            if (m_mod == 3) {
                ht = hde64_table + DELTA_FPU_MODRM + t * 8;
                t = ht[m_reg] << m_rm;
            }
            else {
                ht = hde64_table + DELTA_FPU_REG;
                t = ht[t] << m_reg;
            }
            if (t & 0x80)
                hs->flags |= F_ERROR | F_ERROR_OPCODE;
        }

        if (pref & PRE_LOCK) {
            if (m_mod == 3) {
                hs->flags |= F_ERROR | F_ERROR_LOCK;
            }
            else {
                unsigned char *table_end, op = opcode;
                if (hs->opcode2) {
                    ht = hde64_table + DELTA_OP2_LOCK_OK;
                    table_end = ht + DELTA_OP_ONLY_MEM - DELTA_OP2_LOCK_OK;
                }
                else {
                    ht = hde64_table + DELTA_OP_LOCK_OK;
                    table_end = ht + DELTA_OP2_LOCK_OK - DELTA_OP_LOCK_OK;
                    op &= -2;
                }
                for (; ht != table_end; ht++)
                if (*ht++ == op) {
                    if (!((*ht << m_reg) & 0x80))
                        goto no_lock_error;
                    else
                        break;
                }
                hs->flags |= F_ERROR | F_ERROR_LOCK;
            no_lock_error:
                ;
            }
        }

        if (hs->opcode2) {
            switch (opcode) {
            case 0x20: case 0x22:
                m_mod = 3;
                if (m_reg > 4 || m_reg == 1)
                    goto error_operand;
                else
                    goto no_error_operand;
            case 0x21: case 0x23:
                m_mod = 3;
                if (m_reg == 4 || m_reg == 5)
                    goto error_operand;
                else
                    goto no_error_operand;
            }
        }
        else {
            switch (opcode) {
            case 0x8c:
                if (m_reg > 5)
                    goto error_operand;
                else
                    goto no_error_operand;
            case 0x8e:
                if (m_reg == 1 || m_reg > 5)
                    goto error_operand;
                else
                    goto no_error_operand;
            }
        }

        if (m_mod == 3) {
            unsigned char *table_end;
            if (hs->opcode2) {
                ht = hde64_table + DELTA_OP2_ONLY_MEM;
                table_end = ht + sizeof(hde64_table)-DELTA_OP2_ONLY_MEM;
            }
            else {
                ht = hde64_table + DELTA_OP_ONLY_MEM;
                table_end = ht + DELTA_OP2_ONLY_MEM - DELTA_OP_ONLY_MEM;
            }
            for (; ht != table_end; ht += 2)
            if (*ht++ == opcode) {
                if (*ht++ & pref && !((*ht << m_reg) & 0x80))
                    goto error_operand;
                else
                    break;
            }
            goto no_error_operand;
        }
        else if (hs->opcode2) {
            switch (opcode) {
            case 0x50: case 0xd7: case 0xf7:
                if (pref & (PRE_NONE | PRE_66))
                    goto error_operand;
                break;
            case 0xd6:
                if (pref & (PRE_F2 | PRE_F3))
                    goto error_operand;
                break;
            case 0xc5:
                goto error_operand;
            }
            goto no_error_operand;
        }
        else
            goto no_error_operand;

    error_operand:
        hs->flags |= F_ERROR | F_ERROR_OPERAND;
    no_error_operand:

        c = *p++;
        if (m_reg <= 1) {
            if (opcode == 0xf6)
                cflags |= C_IMM8;
            else if (opcode == 0xf7)
                cflags |= C_IMM_P66;
        }

        switch (m_mod) {
        case 0:
            if (pref & PRE_67) {
                if (m_rm == 6)
                    disp_size = 2;
            }
            else
            if (m_rm == 5)
                disp_size = 4;
            break;
        case 1:
            disp_size = 1;
            break;
        case 2:
            disp_size = 2;
            if (!(pref & PRE_67))
                disp_size <<= 1;
        }

        if (m_mod != 3 && m_rm == 4) {
            hs->flags |= F_SIB;
            p++;
            hs->sib = c;
            hs->sib_scale = c >> 6;
            hs->sib_index = (c & 0x3f) >> 3;
            if ((hs->sib_base = c & 7) == 5 && !(m_mod & 1))
                disp_size = 4;
        }

        p--;
        switch (disp_size) {
        case 1:
            hs->flags |= F_DISP8;
            hs->disp.disp8 = *p;
            break;
        case 2:
            hs->flags |= F_DISP16;
            hs->disp.disp16 = *(unsigned short *)p;
            break;
        case 4:
            hs->flags |= F_DISP32;
            hs->disp.disp32 = *(unsigned long *)p;
        }
        p += disp_size;
    }
    else if (pref & PRE_LOCK)
        hs->flags |= F_ERROR | F_ERROR_LOCK;

    if (cflags & C_IMM_P66) {
        if (cflags & C_REL32) {
            if (pref & PRE_66) {
                hs->flags |= F_IMM16 | F_RELATIVE;
                hs->imm.imm16 = *(unsigned short *)p;
                p += 2;
                goto disasm_done;
            }
            goto rel32_ok;
        }
        if (op64) {
            hs->flags |= F_IMM64;
            hs->imm.imm64 = *(unsigned __int64 *)p;
            p += 8;
        }
        else if (!(pref & PRE_66)) {
            hs->flags |= F_IMM32;
            hs->imm.imm32 = *(unsigned long *)p;
            p += 4;
        }
        else
            goto imm16_ok;
    }


    if (cflags & C_IMM16) {
    imm16_ok:
        hs->flags |= F_IMM16;
        hs->imm.imm16 = *(unsigned short *)p;
        p += 2;
    }
    if (cflags & C_IMM8) {
        hs->flags |= F_IMM8;
        hs->imm.imm8 = *p++;
    }

    if (cflags & C_REL32) {
    rel32_ok:
        hs->flags |= F_IMM32 | F_RELATIVE;
        hs->imm.imm32 = *(unsigned long *)p;
        p += 4;
    }
    else if (cflags & C_REL8) {
        hs->flags |= F_IMM8 | F_RELATIVE;
        hs->imm.imm8 = *p++;
    }

disasm_done:

    if ((hs->len = (unsigned char)(p - (unsigned char *)code)) > 15) {
        hs->flags |= F_ERROR | F_ERROR_LENGTH;
        hs->len = 15;
    }

    return (unsigned int)hs->len;
}

void* GetRelativeBranchDestination(unsigned char* pInst, const hde64s* hs, int isShort)
{
    return pInst + hs->len + (isShort ? (signed char)hs->imm.imm8 : (signed long)hs->imm.imm32);
}

int IsInternalJump(void* pTarget, void* dest)
{
    return ((char*)pTarget <= (char*)dest && (char*)dest <= (char*)pTarget + sizeof(JMP_REL));
}

int IsCodePadding(unsigned char* pInst, unsigned long long size)
{
    unsigned char paddingByte = pInst[0];
    switch (paddingByte)
    {
    case 0x00:
    case 0x90:
    case 0xCC:
        for (unsigned long long i = 1; i < size; ++i)
        {
            if (pInst[i] != paddingByte)
                return 0;
        }
        return 1;
    default:
        return 0;
    }
}

void AppendRipRelativeAddress(unsigned char* pInst, unsigned long long pos, const hde64s* hs, HOOK_ENTRY* ct)
{
    ct->tempAddr[ct->tempAddrSize].address = pInst + hs->len + (signed long)hs->disp.disp32;
    ct->tempAddr[ct->tempAddrSize].position = pos + hs->len - ((hs->flags & 0x3C) >> 2) - 4;
    ct->tempAddr[ct->tempAddrSize].pc = pos + hs->len;

    ct->tempAddrSize++;
}

void AppendTempAddressJMP(void* address, unsigned long long pos, const JMP_ABS* inst, HOOK_ENTRY* ct)
{
    ct->tempAddr[ct->tempAddrSize].address = (void*)ct->tableSize;

    ct->table[ct->tableSize] = address;
    ct->tableSize++;

    ct->tempAddr[ct->tempAddrSize].position = pos + ((int)(void*)&(((JMP_ABS*)0)->operand));
    ct->tempAddr[ct->tempAddrSize].pc = pos + sizeof(JMP_ABS);

    ct->tempAddrSize++;
}

void AppendTempAddressJCC(void* address, unsigned long long pos, const JCC_ABS* inst, HOOK_ENTRY* ct)
{
    ct->tempAddr[ct->tempAddrSize].address = (void*)ct->tableSize;

    ct->table[ct->tableSize] = address;
    ct->tableSize++;

    ct->tempAddr[ct->tempAddrSize].position = pos + ((int)(void*)&(((JMP_ABS*)0)->operand));
    ct->tempAddr[ct->tempAddrSize].pc = pos + sizeof(JCC_ABS);

    ct->tempAddrSize++;
}

int CreateTrampolineFunction(HOOK_ENTRY* ct)
{
    JMP_ABS call = { 0x15FF, 0x00000000 };
    JMP_ABS jmp = { 0x25FF, 0x00000000 };
    JCC_ABS jcc = { 0x70, 0x02, 0xEB, 0x06, 0x25FF, 0x00000000 };

    unsigned long long oldPos = 0;
    unsigned long long newPos = 0;
    void* jmpDest = 0;
    int finished = 0;
    while (!finished)
    {
        unsigned char *pInst = (unsigned char*)ct->pTarget + oldPos;
        hde64s hs = { 0 };
        hde64_disasm(pInst, &hs);
        if ((hs.flags & F_ERROR) == F_ERROR)
            return 0;

        void*  pCopySrc = pInst;
        unsigned long long copySize = hs.len;

        if (pInst - (unsigned char*)ct->pTarget >= sizeof(JMP_REL))
        {
            AppendTempAddressJMP((void*)pInst, newPos, &jmp, ct);

            pCopySrc = &jmp;
            copySize = sizeof(jmp);

            finished = 1;
        }

        else if ((hs.modrm & 0xC7) == 0x05)
        {
            AppendRipRelativeAddress(pInst, newPos, &hs, ct);
            if (hs.opcode == 0xFF && hs.modrm_reg == 4)
                finished = 1;
        }

        else if (hs.opcode == 0xE8)
        {
            AppendTempAddressJMP(GetRelativeBranchDestination(pInst, &hs, 0), newPos, &call, ct);
            pCopySrc = &call;
            copySize = sizeof(call);
        }

        else if ((hs.opcode & 0xFD) == 0xE9)
        {
            void* dest = GetRelativeBranchDestination(pInst, &hs, hs.opcode == 0xEB);

            if (IsInternalJump(ct->pTarget, dest))
                jmpDest = (jmpDest < dest) ? dest : jmpDest;
            else
            {
                AppendTempAddressJMP(dest, newPos, &jmp, ct);
                pCopySrc = &jmp;
                copySize = sizeof(jmp);

                finished = (void*)pInst >= jmpDest;
            }
        }

        else if ((hs.opcode & 0xF0) == 0x70 || (hs.opcode & 0xFC) == 0xE0 || (hs.opcode2 & 0xF0) == 0x80)
        {
            void* dest = GetRelativeBranchDestination(pInst, &hs, (hs.opcode & 0xF0) == 0x70 || (hs.opcode & 0xFC) == 0xE0);

            if (IsInternalJump(ct->pTarget, dest))
                jmpDest = (jmpDest < dest) ? dest : jmpDest;
            else if ((hs.opcode & 0xFC) == 0xE0)
                return 0;
            else
            {
                AppendTempAddressJCC(dest, newPos, &jcc, ct);

                unsigned char n = ((hs.opcode != 0x0F ? hs.opcode : hs.opcode2) & 0x0F);
                jcc.opcode = 0x70 | n;

                pCopySrc = &jcc;
                copySize = sizeof(jcc);
            }
        }
        else if ((hs.opcode & 0xFE) == 0xC2)
            finished = (void*)pInst >= jmpDest;

        if ((void*)pInst < jmpDest && copySize != hs.len)
            return 0;

        ct->trampolineSize = newPos + copySize;
        RtlCopyMemory(&ct->trampoline[newPos], pCopySrc, (void*)copySize);

        oldPos += hs.len;
        newPos += copySize;
    }

    if (oldPos < sizeof(JMP_REL) && !IsCodePadding((unsigned char*)ct->pTarget + oldPos, sizeof(JMP_REL)-oldPos))
    {
        if (oldPos < sizeof(JMP_REL_SHORT) && !IsCodePadding((unsigned char*)ct->pTarget + oldPos, sizeof(JMP_REL_SHORT)-oldPos))
            return 0;

        static const unsigned int PageExecuteMask = (PAGE_EXECUTE | PAGE_EXECUTE_READ | PAGE_EXECUTE_READWRITE | PAGE_EXECUTE_WRITECOPY);

        MEMORY_BASIC_INFORMATION mi = { 0 };

        void* regionAddress = (unsigned char*)ct->pTarget - sizeof(JMP_REL);
        void* returnedLength;
        NtQueryVirtualMemory((void*)-1, regionAddress, MemoryBasicInformation, &mi, (void*)sizeof(mi), &returnedLength);

        if (!((mi.Protect & PageExecuteMask) != 0))
            return 0;

        if (!IsCodePadding((unsigned char*)ct->pTarget - sizeof(JMP_REL), sizeof(JMP_REL)))
            return 0;

        ct->patchAbove = 1;
    }

    return 1;
}

int ResolveTemporaryAddresses(HOOK_ENTRY* ct)
{
    void** pt = ct->pTable;

    for (unsigned long long i = 0, count = ct->tempAddrSize; i < count; ++i)
    {
        if ((&ct->tempAddr[i])->position > ct->trampolineSize - sizeof(unsigned long))
            return 0;

        void* addr;

        if ((char*)(&ct->tempAddr[i])->address < (char*)0x10000)
            addr = (void*)pt++;
        else
            addr = (&ct->tempAddr[i])->address;

        *(unsigned long*)&ct->trampoline[(&ct->tempAddr[i])->position] = (unsigned long)((char*)addr - ((char*)ct->pTrampoline + (&ct->tempAddr[i])->pc));
    }

    return 1;
}

void* AllocateBuffer(void* const pOrigin, unsigned int protect, unsigned long long size)
{
    const unsigned long long blockSize = (size / 64 + 1) * 64;

    SYSTEM_INFO si;
    ((void*(__stdcall *)(SYSTEM_INFO*))getSystemInfo)(&si);

    void* minAddr = si.lpMinimumApplicationAddress;
    void* maxAddr = si.lpMaximumApplicationAddress;
    if (pOrigin != 0)
    {
        unsigned long long ptr1 = (unsigned long long)pOrigin - 0x20000000;
        minAddr = (void*)((ptr1 < (unsigned long long)minAddr) ? (unsigned long long)minAddr : ptr1);
        ptr1 = (unsigned long long)pOrigin + 0x20000000;
        maxAddr = (void*)((ptr1 >(unsigned long long)maxAddr) ? (unsigned long long)maxAddr : ptr1);
    }

    void* pAlloc = 0;

    if (pOrigin != 0)
    {
        unsigned long long min = (unsigned long long)minAddr / blockSize;
        unsigned long long max = (unsigned long long)maxAddr / blockSize;
        int rel = 0;
        MEMORY_BASIC_INFORMATION mi = { 0 };
        for (int i = 0; i < (max - min + 1); ++i)
        {
            rel = -rel + (i & 1);
            void* pQuery = (void*)(((min + max) / 2 + rel) * blockSize);

            void*returnedLength;
            NtQueryVirtualMemory((void*)-1, pQuery, MemoryBasicInformation, &mi, (void*)sizeof(mi), &returnedLength);

            if (mi.State == MEM_FREE)
            {
                pAlloc = pQuery;
                void* regionSize = (void*)size;
                if (NtAllocateVirtualMemory((void*)-1, &pAlloc, 0, &regionSize, MEM_RESERVE | MEM_COMMIT, protect) != 0)
                    return 0;
                break;
            }
        }
    }
    else
    {
        void* regionSize = (void*)size;
        if (NtAllocateVirtualMemory((void*)-1, &pAlloc, 0, &regionSize, MEM_RESERVE | MEM_COMMIT, protect) != 0)
            return 0;
    }

    return pAlloc;
}

int CreateHook(HOOK_ENTRY* pHook, void* pTarget, void* const pDetour, void** ppOriginal)
{
    memset(pHook, 0, (void*)sizeof(HOOK_ENTRY));

    static const unsigned int PageExecuteMask = (PAGE_EXECUTE | PAGE_EXECUTE_READ | PAGE_EXECUTE_READWRITE | PAGE_EXECUTE_WRITECOPY);

    MEMORY_BASIC_INFORMATION mi1 = { 0 };
    MEMORY_BASIC_INFORMATION mi2 = { 0 };

    void* returnedLength;
    NtQueryVirtualMemory((void*)-1, pTarget, MemoryBasicInformation, &mi1, (void*)sizeof(mi1), &returnedLength);
    NtQueryVirtualMemory((void*)-1, pDetour, MemoryBasicInformation, &mi2, (void*)sizeof(mi2), &returnedLength);

    int result = 0;
    do
    {
        if (((mi1.Protect & PageExecuteMask) == 0) || ((mi2.Protect & PageExecuteMask) == 0))
        {
            result = -1;
            break;
        }

        pHook->pTarget = pTarget;
        if (!CreateTrampolineFunction(pHook))
        {
            result = -2;
            break;
        }

        void* pJmpPtr = pTarget;
        if (pHook->patchAbove)
            pJmpPtr = (char*)pJmpPtr - sizeof(JMP_REL);

        int trampolineSize = ALIGNED_SIZE(pHook->trampolineSize);
        pHook->pTrampoline = AllocateBuffer(pJmpPtr, PAGE_EXECUTE_READWRITE, trampolineSize);
        if (pHook->pTrampoline == 0)
        {
            result = -3;
            break;
        }

        int tableSize = ALIGNED_SIZE((pHook->tableSize + 1) * sizeof(void*));
        pHook->pTable = AllocateBuffer(pHook->pTrampoline, PAGE_READWRITE, tableSize);
        if (pHook->pTable == 0)
        {
            result = -4;
            break;
        }

        if (!ResolveTemporaryAddresses(pHook))
        {
            result = -5;
            break;
        }

        RtlCopyMemory(pHook->pTrampoline, pHook->trampoline, (void*)pHook->trampolineSize);

        if (pHook->tableSize != 0)
            RtlCopyMemory(pHook->pTable, &pHook->table[0], (void*)(pHook->tableSize * sizeof(void*)));

        unsigned long long backupSize = sizeof(JMP_REL);
        if (pHook->patchAbove)
        {
            backupSize += sizeof(JMP_REL_SHORT);
        }

        int backupAlignedSize = ALIGNED_SIZE(backupSize);
        pHook->pBackup = AllocateBuffer(0, PAGE_READWRITE, backupAlignedSize);
        if (pHook->pBackup == 0)
        {
            result = -6;
            break;
        }

        RtlCopyMemory(pHook->pBackup, pJmpPtr, (void*)backupSize);

        int pRelayAlignedSize = ALIGNED_SIZE(sizeof(JMP_ABS));
        pHook->pRelay = AllocateBuffer(pJmpPtr, PAGE_EXECUTE_READWRITE, pRelayAlignedSize);
        if (pHook->pRelay == 0)
        {
            result = -7;
            break;
        }

        ((JMP_ABS*)pHook->pRelay)->opcode = 0x25FF;
        ((JMP_ABS*)pHook->pRelay)->operand = (unsigned long)((char*)((void**)pHook->pTable + pHook->tableSize) - ((char*)pHook->pRelay + sizeof(JMP_ABS)));

        *((void**)pHook->pTable + pHook->tableSize) = pDetour;

        unsigned int op;

        void* regionSize = (void*)tableSize;
        void* regionAddress = pHook->pTable;
        NtProtectVirtualMemory((void*)-1, &regionAddress, &regionSize, PAGE_READONLY, &op);
        regionSize = (void*)trampolineSize;
        regionAddress = pHook->pTrampoline;
        NtProtectVirtualMemory((void*)-1, &regionAddress, &regionSize, PAGE_EXECUTE_READ, &op);
        regionSize = (void*)backupAlignedSize;
        regionAddress = pHook->pBackup;
        NtProtectVirtualMemory((void*)-1, &regionAddress, &regionSize, PAGE_READONLY, &op);
        regionSize = (void*)pRelayAlignedSize;
        regionAddress = pHook->pRelay;
        NtProtectVirtualMemory((void*)-1, &regionAddress, &regionSize, PAGE_EXECUTE_READ, &op);

        pHook->pTarget = pTarget;
        pHook->pDetour = pDetour;

        *ppOriginal = pHook->pTrampoline;

        void* pPatchTarget = pHook->pTarget;
        unsigned long long patchSize = sizeof(JMP_REL);
        if (pHook->patchAbove)
        {
            pPatchTarget = (char*)pPatchTarget - sizeof(JMP_REL);
            patchSize += sizeof(JMP_REL_SHORT);
        }

        unsigned int oldProtect;

        regionSize = (void*)patchSize;
        regionAddress = pPatchTarget;
        if (NtProtectVirtualMemory((void*)-1, &regionAddress, &regionSize, PAGE_EXECUTE_READWRITE, &oldProtect) != 0)
        {
            result = -8;
            break;
        }

        ((JMP_REL*)pPatchTarget)->opcode = 0xE9;
        ((JMP_REL*)pPatchTarget)->operand = (unsigned long)((char*)pHook->pRelay - ((char*)pPatchTarget + sizeof(JMP_REL)));

        if (pHook->patchAbove)
        {
            ((JMP_REL_SHORT*)pHook->pTarget)->opcode = 0xEB;
            ((JMP_REL_SHORT*)pHook->pTarget)->operand = 0 - (unsigned char)(sizeof(JMP_REL_SHORT)+sizeof(JMP_REL));
        }

        regionSize = (void*)patchSize;
        regionAddress = pPatchTarget;
        NtProtectVirtualMemory((void*)-1, &regionAddress, &regionSize, oldProtect, &oldProtect);
    } while (0);

    if (result != 0)
    {
        void* regionSize = 0;
        NtFreeVirtualMemory((void*)-1, &pHook->pTrampoline, &regionSize, MEM_RELEASE);
        regionSize = 0;
        NtFreeVirtualMemory((void*)-1, &pHook->pTable, &regionSize, MEM_RELEASE);
        regionSize = 0;
        NtFreeVirtualMemory((void*)-1, &pHook->pBackup, &regionSize, MEM_RELEASE);
        regionSize = 0;
        NtFreeVirtualMemory((void*)-1, &pHook->pRelay, &regionSize, MEM_RELEASE);
    }

    return result;
}

void RemoveHook(HOOK_ENTRY* pHook)
{
    void* pPatchTarget = pHook->pTarget;
    unsigned long long patchSize = sizeof(JMP_REL);
    if (pHook->patchAbove)
    {
        pPatchTarget = (char*)pPatchTarget - sizeof(JMP_REL);
        patchSize += sizeof(JMP_REL_SHORT);
    }

    unsigned int oldProtect;

    void* regionSize = (void*)patchSize;
    void* regionAddress = pPatchTarget;
    if (NtProtectVirtualMemory((void*)-1, &regionAddress, &regionSize, PAGE_EXECUTE_READWRITE, &oldProtect) == 0)
    {
        RtlCopyMemory(pPatchTarget, pHook->pBackup, (void*)patchSize);
        regionSize = (void*)patchSize;
        regionAddress = pPatchTarget;
        NtProtectVirtualMemory((void*)-1, &regionAddress, &regionSize, oldProtect, &oldProtect);
    }

    regionSize = 0;
    NtFreeVirtualMemory((void*)-1, &pHook->pTrampoline, &regionSize, MEM_RELEASE);
    regionSize = 0;
    NtFreeVirtualMemory((void*)-1, &pHook->pTable, &regionSize, MEM_RELEASE);
    regionSize = 0;
    NtFreeVirtualMemory((void*)-1, &pHook->pBackup, &regionSize, MEM_RELEASE);
    regionSize = 0;
    NtFreeVirtualMemory((void*)-1, &pHook->pRelay, &regionSize, MEM_RELEASE);
}

void* pOriginalCompareStringA;

HOOK_ENTRY hook;

int __CompareStringA(unsigned int Locale, unsigned int dwCmpFlags, const char* lpString1, int cchCount1, const char* lpString2, int cchCount2)
{
    return ((int(__stdcall *)(unsigned int, unsigned int, const char*, int, const char*, unsigned int))pOriginalCompareStringA)(Locale, dwCmpFlags & ~1, lpString1, cchCount1, lpString2, cchCount2);
}

int __stdcall DllMain(void* hDllHandle, unsigned int nReason, void* Reserved)
{
    UNICODE_STRING kernelBasePath = InitUnicodeString(L"KernelBase.dll");
    ANSI_STRING hookedName = InitAnsiString("CompareStringA");
    ANSI_STRING getSystemInfoName = InitAnsiString("GetSystemInfo");

    void* kernelBase = 0;
    void* pCompareStringA = 0;

    switch (nReason)
    {
    case DLL_PROCESS_ATTACH:
        LdrLoadDll(0, 0, &kernelBasePath, &kernelBase);
        LdrGetProcedureAddress(kernelBase, &hookedName, 0, &pCompareStringA);
        LdrGetProcedureAddress(kernelBase, &getSystemInfoName, 0, &getSystemInfo);
        CreateHook(&hook, pCompareStringA, &__CompareStringA, &pOriginalCompareStringA);
        break;
    case DLL_PROCESS_DETACH:
        RemoveHook(&hook);
        LdrUnloadDll(kernel32);
        break;
    }
    return 1;
}

__declspec(dllexport) Stub()
{
}