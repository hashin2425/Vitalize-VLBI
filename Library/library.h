#pragma once

#define DllExport   __declspec( dllexport )

extern "C"
{
    DllExport void Test();
}