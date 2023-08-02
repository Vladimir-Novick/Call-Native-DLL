#pragma once

#include <string>

using namespace std;

#ifdef CppDll_EXPORTS
#define EXPORT extern "C" __declspec(dllexport)
#else
#define EXPORT extern "C" __declspec(dllimport)
#endif

 const int SLText = 255;
 const int SLShortText = 128;



struct InitReqest {
   
     TCHAR  _connectionString[SLText];

     TCHAR  _connectionAlias[SLText];

     TCHAR  _serverName[SLText];

     TCHAR  _databaseName[SLText];

     TCHAR  _applicationUserName[SLShortText];

     TCHAR  _applicationApplicationUserPassword[SLShortText];

     TCHAR  _workingFolder[SLText];

     TCHAR  _schemaName[SLShortText];
     int _isImportGeneralData; // 0-no, 1-yes

    // // response - answer
     int _status; // 0-ok, other value - failure

     TCHAR  _message[SLText]; // Resulting error or warning message. Details in log.

     TCHAR  _logPath[SLText]; // Resulting error or warning message. Details in log.
};

EXPORT int DllStart(struct InitReqest reguest );

