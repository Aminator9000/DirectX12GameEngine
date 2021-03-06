﻿using System;

namespace DirectX12GameEngine.Engine
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    public sealed class DefaultEntitySystemAttribute : Attribute
    {
        public DefaultEntitySystemAttribute(Type type)
        {
            Type = type;
        }

        public Type Type { get; }
    }
}
