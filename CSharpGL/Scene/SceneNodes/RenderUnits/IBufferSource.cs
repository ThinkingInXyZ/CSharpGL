﻿namespace CSharpGL
{
    /// <summary>
    /// Data for CPU(model) -&gt; Data for GPU(opengl buffer)
    /// <para>从模型的数据格式转换为<see cref="GLBuffer"/></para>，
    /// <see cref="GLBuffer"/>则可用于控制GPU的渲染操作。
    /// </summary>
    public interface IBufferSource
    {
        /// <summary>
        /// 获取顶点某种属性的<see cref="VertexBuffer"/>。
        /// </summary>
        /// <param name="bufferName">CPU代码指定的buffer名字，用以区分各个用途的buffer。</param>
        /// <returns></returns>
        VertexBuffer GetVertexAttributeBuffer(string bufferName);

        /// <summary>
        /// </summary>
        /// <returns></returns>
        IDrawCommand GetDrawCommand();

    }
}