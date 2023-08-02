#include "pch.h"
#include "DllStart.h"


EXPORT int DllStart(struct InitReqest reguest)
{
    MessageBox(NULL, "DllStart", "OK", MB_OK);
    return 0;
}
