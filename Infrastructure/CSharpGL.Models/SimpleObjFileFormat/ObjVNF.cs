﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpGL
{
    /// <summary>
    /// 
    /// </summary>
    public partial class ObjVNF : IBufferSource
    {
        private ObjVNFMesh mesh;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="filename"></param>
        public ObjVNF(string filename)
        {
            var parser = new ObjVNFParser();
            ObjVNFResult result = parser.Parse(filename);
            if (result.Error != null)
            { throw result.Error; }
            else
            {
                this.mesh = result.Mesh;
            }
        }
        #region IBufferSource 成员

        public const string strPosition = "position";
        private VertexBuffer positionBuffer;
        public const string strNormal = "normal";
        private VertexBuffer normalBuffer;

        private IndexBuffer indexBuffer;

        public VertexBuffer GetVertexAttributeBuffer(string bufferName)
        {
            if (bufferName == strPosition)
            {
                if (this.positionBuffer == null)
                {
                    this.positionBuffer = mesh.vertexes.GenVertexBuffer(VBOConfig.Vec3, BufferUsage.StaticDraw);
                }

                return this.positionBuffer;
            }
            else if (bufferName == strNormal)
            {
                if (this.normalBuffer == null)
                {
                    this.normalBuffer = mesh.normals.GenVertexBuffer(VBOConfig.Vec3, BufferUsage.StaticDraw);
                }

                return this.normalBuffer;
            }

            throw new ArgumentException("bufferName");
        }

        public IndexBuffer GetIndexBuffer()
        {
            if (this.indexBuffer == null)
            {
                int polygon = (this.mesh.faces[0] is ObjVNFTriangle) ? 3 : 4;
                DrawMode mode = (this.mesh.faces[0] is ObjVNFTriangle) ? DrawMode.Triangles : DrawMode.Quads;
                OneIndexBuffer indexBuffer = OneIndexBuffer.Create(IndexBufferElementType.UInt, polygon * this.mesh.faces.Length, mode, BufferUsage.StaticDraw);
                unsafe
                {
                    var array = (uint*)indexBuffer.MapBuffer(MapBufferAccess.WriteOnly);
                    int index = 0;
                    foreach (var face in this.mesh.faces)
                    {
                        foreach (var vertexIndex in face.VertexIndexes())
                        {
                            array[index++] = vertexIndex;
                        }
                    }
                    indexBuffer.UnmapBuffer();
                }

                this.indexBuffer = indexBuffer;
            }

            return this.indexBuffer;
        }

        #endregion
    }
}