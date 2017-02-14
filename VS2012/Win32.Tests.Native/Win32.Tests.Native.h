// Win32.Tests.Native.h

#pragma once

#pragma warning(disable: 4561)
#define DIRECTINPUT_VERSION         DIRECTINPUT_HEADER_VERSION

typedef struct STRUCT_SIZE
{
    wchar_t* name;
    int size;
} STRUCT_SIZE;

typedef struct STRUCT_OFFSET
{
    wchar_t* path;
    int offset;
} STRUCT_OFFSET;

typedef struct ENUM_SIZE
{
    wchar_t* name;
    int size;
} ENUM_SIZE;

#include "Generated.h"
#include <WinSock2.h>
#include <d2d1_1.h>
#include <d3d11_1.h>
#include <D2d1effectauthor.h>
#include <dwrite_1.h>
#include <dxgi1_2.h>
#include <DXGIMessages.h>
#include <dcompanimation.h>
#include <D3D11Shader.h>
#include <D3D11ShaderTracing.h>
#include <dinput.h>
#include <D3dcsx.h>
#include <Dinputd.h>
#include <x3daudio.h>
#include <Wincodec.h>
#include <xaudio2.h>
#include <xaudio2fx.h>
#include <xapo.h>
#include <xapofx.h>
#include <dxgidebug.h>
#include <Wincodecsdk.h>
#include <D3Dcompiler.h>
#include <DcompTypes.h>

BOOL SkipCheck(wchar_t* string)
{
    return FALSE;
}

using namespace System;

namespace Internal
{
    STRUCT_SIZE structSizes[] = STRUCT_SIZES;
    STRUCT_OFFSET structOffsets[] = STRUCT_OFFSETS;
    ENUM_SIZE enumSizes[] = ENUM_SIZES;
    
    private ref class TestClass
    {
    internal:
        static System::Collections::Generic::Dictionary<String^, Int32>^ GetEnumerationSizes()
        {
            System::Collections::Generic::Dictionary<String^, Int32>^ result = gcnew System::Collections::Generic::Dictionary<String^, Int32>();

            size_t index = 0;
            while (enumSizes[index].name != NULL)
            {
                result->Add(gcnew String(enumSizes[index].name), enumSizes[index].size);
                index++;
            }

            return result;
        }

        static System::Collections::Generic::Dictionary<String^, Int32>^ GetStructureSizes()
        {
            System::Collections::Generic::Dictionary<String^, Int32>^ result = gcnew System::Collections::Generic::Dictionary<String^, Int32>();
            
            size_t index = 0;
            while (structSizes[index].name != NULL)
            {
                if (!SkipCheck(structSizes[index].name))
                    result->Add(gcnew String(structSizes[index].name), structSizes[index].size);
                index++;
            }                

            return result;
        }

        static System::Collections::Generic::Dictionary<String^, Int32>^ GetStructureOffsets()
        {
            System::Collections::Generic::Dictionary<String^, Int32>^ result = gcnew System::Collections::Generic::Dictionary<String^, Int32>();

            size_t index = 0;
            while (structOffsets[index].path != NULL)
            {
                if (!SkipCheck(structOffsets[index].path))
                    result->Add(gcnew String(structOffsets[index].path), structOffsets[index].offset);
                index++;
            }

            return result;
        }
    };
}

namespace Win32 {
namespace Tests {
namespace Native
{
    public ref class NativeTests : public Win32::Tests::Common::INativeTests
	{
    public:
        virtual System::Collections::Generic::Dictionary<String^, Int32>^ GetEnumerationSizes()
        {
            return Internal::TestClass::GetEnumerationSizes();
        }

        virtual System::Collections::Generic::Dictionary<String^, Int32>^ GetStructureSizes()
        {
            return Internal::TestClass::GetStructureSizes();
        }

        virtual System::Collections::Generic::Dictionary<String^, Int32>^ GetStructureOffsets()
        {
            return Internal::TestClass::GetStructureOffsets();
        }
	};
}}}
