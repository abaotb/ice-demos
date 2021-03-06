// **********************************************************************
//
// Copyright (c) 2003-2016 ZeroC, Inc. All rights reserved.
//
// **********************************************************************

using Demo;

public sealed class CallbackSenderI : CallbackSenderDisp_
{
    public override void initiateCallback(CallbackReceiverPrx proxy, Ice.Current current)
    {
        System.Console.Out.WriteLine("initiating callback");
        try
        {
            proxy.callback();
        }
        catch(System.Exception ex)
        {
            System.Console.Error.WriteLine(ex);
        }
    }
    
    public override void shutdown(Ice.Current current)
    {
        System.Console.Out.WriteLine("Shutting down...");
        try
        {
            current.adapter.getCommunicator().shutdown();
        }
        catch(System.Exception ex)
        {
            System.Console.Error.WriteLine(ex);
        }
    }
}
