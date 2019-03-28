﻿using System.Numerics;
using DirectX12GameEngine.Shaders;

namespace DirectX12GameEngine.Rendering.Core
{
    public static class PositionStream
    {
        [ShaderResource] [PositionSemantic] public static Vector4 Position;

        [ShaderResource] [PositionSemantic] public static Vector4 PositionWS;
    }
}