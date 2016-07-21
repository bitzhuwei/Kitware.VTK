using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkPixelBufferObject : vtkObject
	{
		public enum DynamicCopy_WrapperEnum
		{
			DynamicCopy = 8,
			DynamicDraw = 6,
			DynamicRead,
			NumberOfUsages = 9,
			StaticCopy = 5,
			StaticDraw = 3,
			StaticRead,
			StreamCopy = 2,
			StreamDraw = 0,
			StreamRead
		}

		public enum BufferType
		{
			PACKED_BUFFER,
			UNPACKED_BUFFER
		}

		public new const string MRFullTypeName = "Kitware.VTK.vtkPixelBufferObject";

		public new static readonly string MRClassNameKey;

		static vtkPixelBufferObject()
		{
			vtkPixelBufferObject.MRClassNameKey = "class vtkPixelBufferObject";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPixelBufferObject.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPixelBufferObject"));
		}

		public vtkPixelBufferObject(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkPixelBufferObject_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPixelBufferObject New()
		{
			vtkPixelBufferObject result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPixelBufferObject.vtkPixelBufferObject_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPixelBufferObject)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkPixelBufferObject() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkPixelBufferObject.vtkPixelBufferObject_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkPixelBufferObject_Allocate_01(HandleRef pThis, uint size, int type);

		public void Allocate(uint size, int type)
		{
			vtkPixelBufferObject.vtkPixelBufferObject_Allocate_01(base.GetCppThis(), size, type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkPixelBufferObject_Bind_02(HandleRef pThis, vtkPixelBufferObject.BufferType buffer);

		public void Bind(vtkPixelBufferObject.BufferType buffer)
		{
			vtkPixelBufferObject.vtkPixelBufferObject_Bind_02(base.GetCppThis(), buffer);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkPixelBufferObject_BindToPackedBuffer_03(HandleRef pThis);

		public void BindToPackedBuffer()
		{
			vtkPixelBufferObject.vtkPixelBufferObject_BindToPackedBuffer_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkPixelBufferObject_BindToUnPackedBuffer_04(HandleRef pThis);

		public void BindToUnPackedBuffer()
		{
			vtkPixelBufferObject.vtkPixelBufferObject_BindToUnPackedBuffer_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern byte vtkPixelBufferObject_Download1D_05(HandleRef pThis, int type, IntPtr data, uint dim, int numcomps, long increment);

		public bool Download1D(int type, IntPtr data, uint dim, int numcomps, long increment)
		{
			return vtkPixelBufferObject.vtkPixelBufferObject_Download1D_05(base.GetCppThis(), type, data, dim, numcomps, increment) != 0;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern byte vtkPixelBufferObject_Download2D_06(HandleRef pThis, int type, IntPtr data, IntPtr dims, int numcomps, IntPtr increments);

		public bool Download2D(int type, IntPtr data, IntPtr dims, int numcomps, IntPtr increments)
		{
			return vtkPixelBufferObject.vtkPixelBufferObject_Download2D_06(base.GetCppThis(), type, data, dims, numcomps, increments) != 0;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern byte vtkPixelBufferObject_Download3D_07(HandleRef pThis, int type, IntPtr data, IntPtr dims, int numcomps, IntPtr increments);

		public bool Download3D(int type, IntPtr data, IntPtr dims, int numcomps, IntPtr increments)
		{
			return vtkPixelBufferObject.vtkPixelBufferObject_Download3D_07(base.GetCppThis(), type, data, dims, numcomps, increments) != 0;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkPixelBufferObject_GetContext_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkRenderWindow GetContext()
		{
			vtkRenderWindow vtkRenderWindow = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPixelBufferObject.vtkPixelBufferObject_GetContext_08(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRenderWindow = (vtkRenderWindow)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRenderWindow.Register(null);
				}
			}
			return vtkRenderWindow;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern uint vtkPixelBufferObject_GetHandle_09(HandleRef pThis);

		public virtual uint GetHandle()
		{
			return vtkPixelBufferObject.vtkPixelBufferObject_GetHandle_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern uint vtkPixelBufferObject_GetSize_10(HandleRef pThis);

		public virtual uint GetSize()
		{
			return vtkPixelBufferObject.vtkPixelBufferObject_GetSize_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkPixelBufferObject_GetType_11(HandleRef pThis);

		public virtual int GetTypeWrapper()
		{
			return vtkPixelBufferObject.vtkPixelBufferObject_GetType_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkPixelBufferObject_GetUsage_12(HandleRef pThis);

		public virtual int GetUsage()
		{
			return vtkPixelBufferObject.vtkPixelBufferObject_GetUsage_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkPixelBufferObject_IsA_13(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkPixelBufferObject.vtkPixelBufferObject_IsA_13(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern byte vtkPixelBufferObject_IsSupported_14(HandleRef renWin);

		public static bool IsSupported(vtkRenderWindow renWin)
		{
			return vtkPixelBufferObject.vtkPixelBufferObject_IsSupported_14((renWin == null) ? default(HandleRef) : renWin.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkPixelBufferObject_IsTypeOf_15(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkPixelBufferObject.vtkPixelBufferObject_IsTypeOf_15(type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkPixelBufferObject_NewInstance_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkPixelBufferObject NewInstance()
		{
			vtkPixelBufferObject result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPixelBufferObject.vtkPixelBufferObject_NewInstance_17(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPixelBufferObject)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkPixelBufferObject_ReleaseMemory_18(HandleRef pThis);

		public void ReleaseMemory()
		{
			vtkPixelBufferObject.vtkPixelBufferObject_ReleaseMemory_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkPixelBufferObject_SafeDownCast_19(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPixelBufferObject SafeDownCast(vtkObjectBase o)
		{
			vtkPixelBufferObject vtkPixelBufferObject = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPixelBufferObject.vtkPixelBufferObject_SafeDownCast_19((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPixelBufferObject = (vtkPixelBufferObject)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPixelBufferObject.Register(null);
				}
			}
			return vtkPixelBufferObject;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkPixelBufferObject_SetContext_20(HandleRef pThis, HandleRef context);

		public void SetContext(vtkRenderWindow context)
		{
			vtkPixelBufferObject.vtkPixelBufferObject_SetContext_20(base.GetCppThis(), (context == null) ? default(HandleRef) : context.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkPixelBufferObject_SetUsage_21(HandleRef pThis, int _arg);

		public virtual void SetUsage(int _arg)
		{
			vtkPixelBufferObject.vtkPixelBufferObject_SetUsage_21(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkPixelBufferObject_UnBind_22(HandleRef pThis);

		public void UnBind()
		{
			vtkPixelBufferObject.vtkPixelBufferObject_UnBind_22(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern byte vtkPixelBufferObject_Upload1D_23(HandleRef pThis, int type, IntPtr data, uint numtuples, int comps, long increment);

		public bool Upload1D(int type, IntPtr data, uint numtuples, int comps, long increment)
		{
			return vtkPixelBufferObject.vtkPixelBufferObject_Upload1D_23(base.GetCppThis(), type, data, numtuples, comps, increment) != 0;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern byte vtkPixelBufferObject_Upload2D_24(HandleRef pThis, int type, IntPtr data, IntPtr dims, int comps, IntPtr increments);

		public bool Upload2D(int type, IntPtr data, IntPtr dims, int comps, IntPtr increments)
		{
			return vtkPixelBufferObject.vtkPixelBufferObject_Upload2D_24(base.GetCppThis(), type, data, dims, comps, increments) != 0;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern byte vtkPixelBufferObject_Upload3D_25(HandleRef pThis, int type, IntPtr data, IntPtr dims, int comps, IntPtr increments, int components, IntPtr componentList);

		public bool Upload3D(int type, IntPtr data, IntPtr dims, int comps, IntPtr increments, int components, IntPtr componentList)
		{
			return vtkPixelBufferObject.vtkPixelBufferObject_Upload3D_25(base.GetCppThis(), type, data, dims, comps, increments, components, componentList) != 0;
		}
	}
}
