﻿namespace EU.Core.Hubs;

public interface IChatClient
{
    /// <summary>
    /// SignalR接收信息
    /// </summary>
    /// <param name="message">信息内容</param>
    /// <returns></returns>
    Task ReceiveMessage(object message);

    /// <summary>
    /// SignalR接收信息
    /// </summary>
    /// <param name="user">指定接收客户端</param>
    /// <param name="message">信息内容</param>
    /// <returns></returns>
    Task ReceiveMessage(string user, string message);

    Task ReceiveUpdate(object message);
}
