using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkOpenGLPainterDeviceAdapter : vtkPainterDeviceAdapter
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkOpenGLPainterDeviceAdapter";

		public new static readonly string MRClassNameKey;

		static vtkOpenGLPainterDeviceAdapter()
		{
			vtkOpenGLPainterDeviceAdapter.MRClassNameKey = "class vtkOpenGLPainterDeviceAdapter";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkOpenGLPainterDeviceAdapter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkOpenGLPainterDeviceAdapter"));
		}

		public vtkOpenGLPainterDeviceAdapter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkOpenGLPainterDeviceAdapter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkOpenGLPainterDeviceAdapter New()
		{
			vtkOpenGLPainterDeviceAdapter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkOpenGLPainterDeviceAdapter.vtkOpenGLPainterDeviceAdapter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOpenGLPainterDeviceAdapter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkOpenGLPainterDeviceAdapter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkOpenGLPainterDeviceAdapter.vtkOpenGLPainterDeviceAdapter_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkOpenGLPainterDeviceAdapter_BeginPrimitive_01(HandleRef pThis, int mode);

		public override void BeginPrimitive(int mode)
		{
			vtkOpenGLPainterDeviceAdapter.vtkOpenGLPainterDeviceAdapter_BeginPrimitive_01(base.GetCppThis(), mode);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkOpenGLPainterDeviceAdapter_Compatible_02(HandleRef pThis, HandleRef renderer);

		public override int Compatible(vtkRenderer renderer)
		{
			return vtkOpenGLPainterDeviceAdapter.vtkOpenGLPainterDeviceAdapter_Compatible_02(base.GetCppThis(), (renderer == null) ? default(HandleRef) : renderer.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkOpenGLPainterDeviceAdapter_DisableAttributeArray_03(HandleRef pThis, int index);

		public override void DisableAttributeArray(int index)
		{
			vtkOpenGLPainterDeviceAdapter.vtkOpenGLPainterDeviceAdapter_DisableAttributeArray_03(base.GetCppThis(), index);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkOpenGLPainterDeviceAdapter_DrawArrays_04(HandleRef pThis, int mode, long first, long count);

		public override void DrawArrays(int mode, long first, long count)
		{
			vtkOpenGLPainterDeviceAdapter.vtkOpenGLPainterDeviceAdapter_DrawArrays_04(base.GetCppThis(), mode, first, count);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkOpenGLPainterDeviceAdapter_DrawElements_05(HandleRef pThis, int mode, long count, int type, IntPtr indices);

		public override void DrawElements(int mode, long count, int type, IntPtr indices)
		{
			vtkOpenGLPainterDeviceAdapter.vtkOpenGLPainterDeviceAdapter_DrawElements_05(base.GetCppThis(), mode, count, type, indices);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkOpenGLPainterDeviceAdapter_EnableAttributeArray_06(HandleRef pThis, int index);

		public override void EnableAttributeArray(int index)
		{
			vtkOpenGLPainterDeviceAdapter.vtkOpenGLPainterDeviceAdapter_EnableAttributeArray_06(base.GetCppThis(), index);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkOpenGLPainterDeviceAdapter_EndPrimitive_07(HandleRef pThis);

		public override void EndPrimitive()
		{
			vtkOpenGLPainterDeviceAdapter.vtkOpenGLPainterDeviceAdapter_EndPrimitive_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkOpenGLPainterDeviceAdapter_IsA_08(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkOpenGLPainterDeviceAdapter.vtkOpenGLPainterDeviceAdapter_IsA_08(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkOpenGLPainterDeviceAdapter_IsAttributesSupported_09(HandleRef pThis, int attribute);

		public override int IsAttributesSupported(int attribute)
		{
			return vtkOpenGLPainterDeviceAdapter.vtkOpenGLPainterDeviceAdapter_IsAttributesSupported_09(base.GetCppThis(), attribute);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkOpenGLPainterDeviceAdapter_IsTypeOf_10(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkOpenGLPainterDeviceAdapter.vtkOpenGLPainterDeviceAdapter_IsTypeOf_10(type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkOpenGLPainterDeviceAdapter_MakeBlending_11(HandleRef pThis, int mode);

		public override void MakeBlending(int mode)
		{
			vtkOpenGLPainterDeviceAdapter.vtkOpenGLPainterDeviceAdapter_MakeBlending_11(base.GetCppThis(), mode);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkOpenGLPainterDeviceAdapter_MakeLighting_12(HandleRef pThis, int mode);

		public override void MakeLighting(int mode)
		{
			vtkOpenGLPainterDeviceAdapter.vtkOpenGLPainterDeviceAdapter_MakeLighting_12(base.GetCppThis(), mode);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkOpenGLPainterDeviceAdapter_MakeMultisampling_13(HandleRef pThis, int mode);

		public override void MakeMultisampling(int mode)
		{
			vtkOpenGLPainterDeviceAdapter.vtkOpenGLPainterDeviceAdapter_MakeMultisampling_13(base.GetCppThis(), mode);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkOpenGLPainterDeviceAdapter_MakeVertexEmphasis_14(HandleRef pThis, byte mode);

		public override void MakeVertexEmphasis(bool mode)
		{
			vtkOpenGLPainterDeviceAdapter.vtkOpenGLPainterDeviceAdapter_MakeVertexEmphasis_14(base.GetCppThis(), mode ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkOpenGLPainterDeviceAdapter_NewInstance_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkOpenGLPainterDeviceAdapter NewInstance()
		{
			vtkOpenGLPainterDeviceAdapter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkOpenGLPainterDeviceAdapter.vtkOpenGLPainterDeviceAdapter_NewInstance_16(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOpenGLPainterDeviceAdapter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkOpenGLPainterDeviceAdapter_QueryBlending_17(HandleRef pThis);

		public override int QueryBlending()
		{
			return vtkOpenGLPainterDeviceAdapter.vtkOpenGLPainterDeviceAdapter_QueryBlending_17(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkOpenGLPainterDeviceAdapter_QueryLighting_18(HandleRef pThis);

		public override int QueryLighting()
		{
			return vtkOpenGLPainterDeviceAdapter.vtkOpenGLPainterDeviceAdapter_QueryLighting_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkOpenGLPainterDeviceAdapter_QueryMultisampling_19(HandleRef pThis);

		public override int QueryMultisampling()
		{
			return vtkOpenGLPainterDeviceAdapter.vtkOpenGLPainterDeviceAdapter_QueryMultisampling_19(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkOpenGLPainterDeviceAdapter_SafeDownCast_20(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkOpenGLPainterDeviceAdapter SafeDownCast(vtkObjectBase o)
		{
			vtkOpenGLPainterDeviceAdapter vtkOpenGLPainterDeviceAdapter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkOpenGLPainterDeviceAdapter.vtkOpenGLPainterDeviceAdapter_SafeDownCast_20((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkOpenGLPainterDeviceAdapter = (vtkOpenGLPainterDeviceAdapter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkOpenGLPainterDeviceAdapter.Register(null);
				}
			}
			return vtkOpenGLPainterDeviceAdapter;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkOpenGLPainterDeviceAdapter_SendAttribute_21(HandleRef pThis, int index, int components, int type, IntPtr attribute, long offset);

		public override void SendAttribute(int index, int components, int type, IntPtr attribute, long offset)
		{
			vtkOpenGLPainterDeviceAdapter.vtkOpenGLPainterDeviceAdapter_SendAttribute_21(base.GetCppThis(), index, components, type, attribute, offset);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkOpenGLPainterDeviceAdapter_SendMultiTextureCoords_22(HandleRef pThis, int numcomp, int type, IntPtr attribute, int idx, long offset);

		public override void SendMultiTextureCoords(int numcomp, int type, IntPtr attribute, int idx, long offset)
		{
			vtkOpenGLPainterDeviceAdapter.vtkOpenGLPainterDeviceAdapter_SendMultiTextureCoords_22(base.GetCppThis(), numcomp, type, attribute, idx, offset);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkOpenGLPainterDeviceAdapter_SetAttributePointer_23(HandleRef pThis, int index, int numcomponents, int type, int stride, IntPtr pointer);

		public override void SetAttributePointer(int index, int numcomponents, int type, int stride, IntPtr pointer)
		{
			vtkOpenGLPainterDeviceAdapter.vtkOpenGLPainterDeviceAdapter_SetAttributePointer_23(base.GetCppThis(), index, numcomponents, type, stride, pointer);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkOpenGLPainterDeviceAdapter_Stencil_24(HandleRef pThis, int on);

		public override void Stencil(int on)
		{
			vtkOpenGLPainterDeviceAdapter.vtkOpenGLPainterDeviceAdapter_Stencil_24(base.GetCppThis(), on);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkOpenGLPainterDeviceAdapter_TestStencil_25(HandleRef pThis, long value);

		public override void TestStencil(long value)
		{
			vtkOpenGLPainterDeviceAdapter.vtkOpenGLPainterDeviceAdapter_TestStencil_25(base.GetCppThis(), value);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkOpenGLPainterDeviceAdapter_WriteStencil_26(HandleRef pThis, long value);

		public override void WriteStencil(long value)
		{
			vtkOpenGLPainterDeviceAdapter.vtkOpenGLPainterDeviceAdapter_WriteStencil_26(base.GetCppThis(), value);
		}
	}
}
