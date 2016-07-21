using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public abstract class vtkPainterDeviceAdapter : vtkObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkPainterDeviceAdapter";

		public new static readonly string MRClassNameKey;

		static vtkPainterDeviceAdapter()
		{
			vtkPainterDeviceAdapter.MRClassNameKey = "class vtkPainterDeviceAdapter";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPainterDeviceAdapter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPainterDeviceAdapter"));
		}

		public vtkPainterDeviceAdapter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkPainterDeviceAdapter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPainterDeviceAdapter New()
		{
			vtkPainterDeviceAdapter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPainterDeviceAdapter.vtkPainterDeviceAdapter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPainterDeviceAdapter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkPainterDeviceAdapter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkPainterDeviceAdapter.vtkPainterDeviceAdapter_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkPainterDeviceAdapter_BeginPrimitive_01(HandleRef pThis, int mode);

		public virtual void BeginPrimitive(int mode)
		{
			vtkPainterDeviceAdapter.vtkPainterDeviceAdapter_BeginPrimitive_01(base.GetCppThis(), mode);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkPainterDeviceAdapter_Compatible_02(HandleRef pThis, HandleRef renderer);

		public virtual int Compatible(vtkRenderer renderer)
		{
			return vtkPainterDeviceAdapter.vtkPainterDeviceAdapter_Compatible_02(base.GetCppThis(), (renderer == null) ? default(HandleRef) : renderer.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkPainterDeviceAdapter_DisableAttributeArray_03(HandleRef pThis, int index);

		public virtual void DisableAttributeArray(int index)
		{
			vtkPainterDeviceAdapter.vtkPainterDeviceAdapter_DisableAttributeArray_03(base.GetCppThis(), index);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkPainterDeviceAdapter_DrawArrays_04(HandleRef pThis, int mode, long first, long count);

		public virtual void DrawArrays(int mode, long first, long count)
		{
			vtkPainterDeviceAdapter.vtkPainterDeviceAdapter_DrawArrays_04(base.GetCppThis(), mode, first, count);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkPainterDeviceAdapter_DrawElements_05(HandleRef pThis, int mode, long count, int type, IntPtr indices);

		public virtual void DrawElements(int mode, long count, int type, IntPtr indices)
		{
			vtkPainterDeviceAdapter.vtkPainterDeviceAdapter_DrawElements_05(base.GetCppThis(), mode, count, type, indices);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkPainterDeviceAdapter_EnableAttributeArray_06(HandleRef pThis, int index);

		public virtual void EnableAttributeArray(int index)
		{
			vtkPainterDeviceAdapter.vtkPainterDeviceAdapter_EnableAttributeArray_06(base.GetCppThis(), index);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkPainterDeviceAdapter_EndPrimitive_07(HandleRef pThis);

		public virtual void EndPrimitive()
		{
			vtkPainterDeviceAdapter.vtkPainterDeviceAdapter_EndPrimitive_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkPainterDeviceAdapter_IsA_08(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkPainterDeviceAdapter.vtkPainterDeviceAdapter_IsA_08(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkPainterDeviceAdapter_IsAttributesSupported_09(HandleRef pThis, int attribute);

		public virtual int IsAttributesSupported(int attribute)
		{
			return vtkPainterDeviceAdapter.vtkPainterDeviceAdapter_IsAttributesSupported_09(base.GetCppThis(), attribute);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkPainterDeviceAdapter_IsTypeOf_10(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkPainterDeviceAdapter.vtkPainterDeviceAdapter_IsTypeOf_10(type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkPainterDeviceAdapter_MakeBlending_11(HandleRef pThis, int mode);

		public virtual void MakeBlending(int mode)
		{
			vtkPainterDeviceAdapter.vtkPainterDeviceAdapter_MakeBlending_11(base.GetCppThis(), mode);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkPainterDeviceAdapter_MakeLighting_12(HandleRef pThis, int mode);

		public virtual void MakeLighting(int mode)
		{
			vtkPainterDeviceAdapter.vtkPainterDeviceAdapter_MakeLighting_12(base.GetCppThis(), mode);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkPainterDeviceAdapter_MakeMultisampling_13(HandleRef pThis, int mode);

		public virtual void MakeMultisampling(int mode)
		{
			vtkPainterDeviceAdapter.vtkPainterDeviceAdapter_MakeMultisampling_13(base.GetCppThis(), mode);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkPainterDeviceAdapter_MakeVertexEmphasis_14(HandleRef pThis, byte mode);

		public virtual void MakeVertexEmphasis(bool mode)
		{
			vtkPainterDeviceAdapter.vtkPainterDeviceAdapter_MakeVertexEmphasis_14(base.GetCppThis(), mode ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkPainterDeviceAdapter_NewInstance_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkPainterDeviceAdapter NewInstance()
		{
			vtkPainterDeviceAdapter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPainterDeviceAdapter.vtkPainterDeviceAdapter_NewInstance_16(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPainterDeviceAdapter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkPainterDeviceAdapter_QueryBlending_17(HandleRef pThis);

		public virtual int QueryBlending()
		{
			return vtkPainterDeviceAdapter.vtkPainterDeviceAdapter_QueryBlending_17(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkPainterDeviceAdapter_QueryLighting_18(HandleRef pThis);

		public virtual int QueryLighting()
		{
			return vtkPainterDeviceAdapter.vtkPainterDeviceAdapter_QueryLighting_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkPainterDeviceAdapter_QueryMultisampling_19(HandleRef pThis);

		public virtual int QueryMultisampling()
		{
			return vtkPainterDeviceAdapter.vtkPainterDeviceAdapter_QueryMultisampling_19(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkPainterDeviceAdapter_SafeDownCast_20(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPainterDeviceAdapter SafeDownCast(vtkObjectBase o)
		{
			vtkPainterDeviceAdapter vtkPainterDeviceAdapter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPainterDeviceAdapter.vtkPainterDeviceAdapter_SafeDownCast_20((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPainterDeviceAdapter = (vtkPainterDeviceAdapter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPainterDeviceAdapter.Register(null);
				}
			}
			return vtkPainterDeviceAdapter;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkPainterDeviceAdapter_SendAttribute_21(HandleRef pThis, int index, int components, int type, IntPtr attribute, long offset);

		public virtual void SendAttribute(int index, int components, int type, IntPtr attribute, long offset)
		{
			vtkPainterDeviceAdapter.vtkPainterDeviceAdapter_SendAttribute_21(base.GetCppThis(), index, components, type, attribute, offset);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkPainterDeviceAdapter_SendMultiTextureCoords_22(HandleRef pThis, int numcomp, int type, IntPtr attribute, int idx, long offset);

		public virtual void SendMultiTextureCoords(int numcomp, int type, IntPtr attribute, int idx, long offset)
		{
			vtkPainterDeviceAdapter.vtkPainterDeviceAdapter_SendMultiTextureCoords_22(base.GetCppThis(), numcomp, type, attribute, idx, offset);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkPainterDeviceAdapter_SetAttributePointer_23(HandleRef pThis, int index, HandleRef attributeArray);

		public void SetAttributePointer(int index, vtkDataArray attributeArray)
		{
			vtkPainterDeviceAdapter.vtkPainterDeviceAdapter_SetAttributePointer_23(base.GetCppThis(), index, (attributeArray == null) ? default(HandleRef) : attributeArray.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkPainterDeviceAdapter_SetAttributePointer_24(HandleRef pThis, int index, int numcomponents, int type, int stride, IntPtr pointer);

		public virtual void SetAttributePointer(int index, int numcomponents, int type, int stride, IntPtr pointer)
		{
			vtkPainterDeviceAdapter.vtkPainterDeviceAdapter_SetAttributePointer_24(base.GetCppThis(), index, numcomponents, type, stride, pointer);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkPainterDeviceAdapter_Stencil_25(HandleRef pThis, int on);

		public virtual void Stencil(int on)
		{
			vtkPainterDeviceAdapter.vtkPainterDeviceAdapter_Stencil_25(base.GetCppThis(), on);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkPainterDeviceAdapter_TestStencil_26(HandleRef pThis, long value);

		public virtual void TestStencil(long value)
		{
			vtkPainterDeviceAdapter.vtkPainterDeviceAdapter_TestStencil_26(base.GetCppThis(), value);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkPainterDeviceAdapter_WriteStencil_27(HandleRef pThis, long value);

		public virtual void WriteStencil(long value)
		{
			vtkPainterDeviceAdapter.vtkPainterDeviceAdapter_WriteStencil_27(base.GetCppThis(), value);
		}
	}
}
