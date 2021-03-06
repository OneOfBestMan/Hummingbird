﻿using Hummingbird.Extersions.EventBus;
using System.Threading.Tasks;

namespace Hummingbird.Extersions.EventBus.Abstractions
{
    /// <summary>
    /// 事件处理程序
    /// 作者：郭明
    /// 日期：2017年11月15日
    /// </summary>
    /// <typeparam name="TEvent"></typeparam>
    public interface IEventHandler<in TEvent> 
        where TEvent: class
    {
        Task<bool> Handle(TEvent @event);
    }
}
