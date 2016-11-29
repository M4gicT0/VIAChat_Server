using System;

namespace VIAChatClient
{
    interface View
    {
        void Alert(String message);
        void AddMessage(String message);
    }
}
