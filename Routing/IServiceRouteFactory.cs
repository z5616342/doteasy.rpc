﻿using System.Collections.Generic;
using System.Threading.Tasks;

namespace DotEasy.Rpc.Routing
{
    /// <summary>
    /// 抽象的服务路由工厂
    /// </summary>
    public interface IServiceRouteFactory
    {
        /// <summary>
        /// 根据服务路由描述符创建服务路由
        /// </summary>
        /// <param name="descriptors">服务路由描述符</param>
        /// <returns>服务路由集合</returns>
        Task<IEnumerable<ServiceRoute>> CreateServiceRoutesAsync(IEnumerable<ServiceRouteDescriptor> descriptors);
    }
}