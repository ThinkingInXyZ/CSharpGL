﻿using System;
using System.Collections.Generic;

namespace CSharpGL
{
    internal class PointsRecognizer : PrimitiveRecognizer
    {
        protected override void RecognizeUInt(uint lastVertexId, IntPtr pointer, DrawElementsCmd cmd, List<RecognizedPrimitiveInfo> primitiveInfoList)
        {
            int length = cmd.IndexBufferObject.VertexCount;
            unsafe
            {
                var array = (uint*)pointer.ToPointer();
                for (uint i = 0; i < length; i++)
                {
                    var value = array[i];
                    if (value == lastVertexId)
                    {
                        var item = new RecognizedPrimitiveInfo(i, value);
                        primitiveInfoList.Add(item);
                    }
                }
            }
        }

        protected override void RecognizeUShort(uint lastVertexId, IntPtr pointer, DrawElementsCmd cmd, List<RecognizedPrimitiveInfo> primitiveInfoList)
        {
            int length = cmd.IndexBufferObject.VertexCount;
            unsafe
            {
                var array = (ushort*)pointer.ToPointer();
                for (uint i = 0; i < length; i++)
                {
                    var value = array[i];
                    if (value == lastVertexId)
                    {
                        var item = new RecognizedPrimitiveInfo(i, value);
                        primitiveInfoList.Add(item);
                    }
                }
            }
        }

        protected override void RecognizeByte(uint lastVertexId, IntPtr pointer, DrawElementsCmd cmd, List<RecognizedPrimitiveInfo> primitiveInfoList)
        {
            int length = cmd.IndexBufferObject.VertexCount;
            unsafe
            {
                var array = (byte*)pointer.ToPointer();
                for (uint i = 0; i < length; i++)
                {
                    var value = array[i];
                    if (value == lastVertexId)
                    {
                        var item = new RecognizedPrimitiveInfo(i, value);
                        primitiveInfoList.Add(item);
                    }
                }
            }
        }

        protected override void RecognizeUInt(uint lastVertexId, IntPtr pointer, DrawElementsCmd cmd, List<RecognizedPrimitiveInfo> primitiveInfoList, uint primitiveRestartIndex)
        {
            int length = cmd.IndexBufferObject.VertexCount;
            unsafe
            {
                var array = (uint*)pointer.ToPointer();
                for (uint i = 0; i < length; i++)
                {
                    var value = array[i];
                    if (value == lastVertexId)
                    {
                        var item = new RecognizedPrimitiveInfo(i, value);
                        primitiveInfoList.Add(item);
                    }
                }
            }
        }

        protected override void RecognizeUShort(uint lastVertexId, IntPtr pointer, DrawElementsCmd cmd, List<RecognizedPrimitiveInfo> primitiveInfoList, uint primitiveRestartIndex)
        {
            int length = cmd.IndexBufferObject.VertexCount;
            unsafe
            {
                var array = (ushort*)pointer.ToPointer();
                for (uint i = 0; i < length; i++)
                {
                    var value = array[i];
                    if (value == lastVertexId)
                    {
                        var item = new RecognizedPrimitiveInfo(i, value);
                        primitiveInfoList.Add(item);
                    }
                }
            }
        }

        protected override void RecognizeByte(uint lastVertexId, IntPtr pointer, DrawElementsCmd cmd, List<RecognizedPrimitiveInfo> primitiveInfoList, uint primitiveRestartIndex)
        {
            int length = cmd.IndexBufferObject.VertexCount;
            unsafe
            {
                var array = (byte*)pointer.ToPointer();
                for (uint i = 0; i < length; i++)
                {
                    var value = array[i];
                    if (value == lastVertexId)
                    {
                        var item = new RecognizedPrimitiveInfo(i, value);
                        primitiveInfoList.Add(item);
                    }
                }
            }
        }
    }
}