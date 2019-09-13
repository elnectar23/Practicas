using System;
using System.Collections.Generic;
using System.Text;

namespace Practica4.Api_Service
{
    interface IApiService
    {
        bool IsConnected { get; }
        void CheckNetworkConnection();
    }
}
