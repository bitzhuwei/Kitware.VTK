using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public abstract class vtkOpenGLRenderWindow : vtkRenderWindow
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkOpenGLRenderWindow";

		public new static readonly string MRClassNameKey;

		static vtkOpenGLRenderWindow()
		{
			vtkOpenGLRenderWindow.MRClassNameKey = "class vtkOpenGLRenderWindow";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkOpenGLRenderWindow.MRClassNameKey, Type.GetType("Kitware.VTK.vtkOpenGLRenderWindow"));
		}

		public vtkOpenGLRenderWindow(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkOpenGLRenderWindow_CheckGraphicError_01(HandleRef pThis);

		public override void CheckGraphicError()
		{
			vtkOpenGLRenderWindow.vtkOpenGLRenderWindow_CheckGraphicError_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern uint vtkOpenGLRenderWindow_GetBackBuffer_02(HandleRef pThis);

		public uint GetBackBuffer()
		{
			return vtkOpenGLRenderWindow.vtkOpenGLRenderWindow_GetBackBuffer_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern uint vtkOpenGLRenderWindow_GetBackLeftBuffer_03(HandleRef pThis);

		public uint GetBackLeftBuffer()
		{
			return vtkOpenGLRenderWindow.vtkOpenGLRenderWindow_GetBackLeftBuffer_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern uint vtkOpenGLRenderWindow_GetBackRightBuffer_04(HandleRef pThis);

		public uint GetBackRightBuffer()
		{
			return vtkOpenGLRenderWindow.vtkOpenGLRenderWindow_GetBackRightBuffer_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkOpenGLRenderWindow_GetColorBufferSizes_05(HandleRef pThis, IntPtr rgba);

		public override int GetColorBufferSizes(IntPtr rgba)
		{
			return vtkOpenGLRenderWindow.vtkOpenGLRenderWindow_GetColorBufferSizes_05(base.GetCppThis(), rgba);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkOpenGLRenderWindow_GetDepthBufferSize_06(HandleRef pThis);

		public override int GetDepthBufferSize()
		{
			return vtkOpenGLRenderWindow.vtkOpenGLRenderWindow_GetDepthBufferSize_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkOpenGLRenderWindow_GetExtensionManager_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkOpenGLExtensionManager GetExtensionManager()
		{
			vtkOpenGLExtensionManager vtkOpenGLExtensionManager = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkOpenGLRenderWindow.vtkOpenGLRenderWindow_GetExtensionManager_07(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkOpenGLExtensionManager = (vtkOpenGLExtensionManager)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkOpenGLExtensionManager.Register(null);
				}
			}
			return vtkOpenGLExtensionManager;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern uint vtkOpenGLRenderWindow_GetFrontBuffer_08(HandleRef pThis);

		public uint GetFrontBuffer()
		{
			return vtkOpenGLRenderWindow.vtkOpenGLRenderWindow_GetFrontBuffer_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern uint vtkOpenGLRenderWindow_GetFrontLeftBuffer_09(HandleRef pThis);

		public uint GetFrontLeftBuffer()
		{
			return vtkOpenGLRenderWindow.vtkOpenGLRenderWindow_GetFrontLeftBuffer_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern uint vtkOpenGLRenderWindow_GetFrontRightBuffer_10(HandleRef pThis);

		public uint GetFrontRightBuffer()
		{
			return vtkOpenGLRenderWindow.vtkOpenGLRenderWindow_GetFrontRightBuffer_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkOpenGLRenderWindow_GetGlobalMaximumNumberOfMultiSamples_11();

		public static int GetGlobalMaximumNumberOfMultiSamples()
		{
			return vtkOpenGLRenderWindow.vtkOpenGLRenderWindow_GetGlobalMaximumNumberOfMultiSamples_11();
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkOpenGLRenderWindow_GetHardwareSupport_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkOpenGLHardwareSupport GetHardwareSupport()
		{
			vtkOpenGLHardwareSupport vtkOpenGLHardwareSupport = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkOpenGLRenderWindow.vtkOpenGLRenderWindow_GetHardwareSupport_12(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkOpenGLHardwareSupport = (vtkOpenGLHardwareSupport)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkOpenGLHardwareSupport.Register(null);
				}
			}
			return vtkOpenGLHardwareSupport;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkOpenGLRenderWindow_GetLastGraphicErrorString_13(HandleRef pThis);

		public override string GetLastGraphicErrorString()
		{
			return Marshal.PtrToStringAnsi(vtkOpenGLRenderWindow.vtkOpenGLRenderWindow_GetLastGraphicErrorString_13(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkOpenGLRenderWindow_GetPixelData_14(HandleRef pThis, int x, int y, int x2, int y2, int front);

		public override IntPtr GetPixelData(int x, int y, int x2, int y2, int front)
		{
			return vtkOpenGLRenderWindow.vtkOpenGLRenderWindow_GetPixelData_14(base.GetCppThis(), x, y, x2, y2, front);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkOpenGLRenderWindow_GetPixelData_15(HandleRef pThis, int x, int y, int x2, int y2, int front, HandleRef data);

		public override int GetPixelData(int x, int y, int x2, int y2, int front, vtkUnsignedCharArray data)
		{
			return vtkOpenGLRenderWindow.vtkOpenGLRenderWindow_GetPixelData_15(base.GetCppThis(), x, y, x2, y2, front, (data == null) ? default(HandleRef) : data.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkOpenGLRenderWindow_GetRGBACharPixelData_16(HandleRef pThis, int x, int y, int x2, int y2, int front);

		public override IntPtr GetRGBACharPixelData(int x, int y, int x2, int y2, int front)
		{
			return vtkOpenGLRenderWindow.vtkOpenGLRenderWindow_GetRGBACharPixelData_16(base.GetCppThis(), x, y, x2, y2, front);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkOpenGLRenderWindow_GetRGBACharPixelData_17(HandleRef pThis, int x, int y, int x2, int y2, int front, HandleRef data);

		public override int GetRGBACharPixelData(int x, int y, int x2, int y2, int front, vtkUnsignedCharArray data)
		{
			return vtkOpenGLRenderWindow.vtkOpenGLRenderWindow_GetRGBACharPixelData_17(base.GetCppThis(), x, y, x2, y2, front, (data == null) ? default(HandleRef) : data.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkOpenGLRenderWindow_GetRGBAPixelData_18(HandleRef pThis, int x, int y, int x2, int y2, int front);

		public override IntPtr GetRGBAPixelData(int x, int y, int x2, int y2, int front)
		{
			return vtkOpenGLRenderWindow.vtkOpenGLRenderWindow_GetRGBAPixelData_18(base.GetCppThis(), x, y, x2, y2, front);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkOpenGLRenderWindow_GetRGBAPixelData_19(HandleRef pThis, int x, int y, int x2, int y2, int front, HandleRef data);

		public override int GetRGBAPixelData(int x, int y, int x2, int y2, int front, vtkFloatArray data)
		{
			return vtkOpenGLRenderWindow.vtkOpenGLRenderWindow_GetRGBAPixelData_19(base.GetCppThis(), x, y, x2, y2, front, (data == null) ? default(HandleRef) : data.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkOpenGLRenderWindow_GetZbufferData_20(HandleRef pThis, int x1, int y1, int x2, int y2);

		public override IntPtr GetZbufferData(int x1, int y1, int x2, int y2)
		{
			return vtkOpenGLRenderWindow.vtkOpenGLRenderWindow_GetZbufferData_20(base.GetCppThis(), x1, y1, x2, y2);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkOpenGLRenderWindow_GetZbufferData_21(HandleRef pThis, int x1, int y1, int x2, int y2, IntPtr z);

		public override int GetZbufferData(int x1, int y1, int x2, int y2, IntPtr z)
		{
			return vtkOpenGLRenderWindow.vtkOpenGLRenderWindow_GetZbufferData_21(base.GetCppThis(), x1, y1, x2, y2, z);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkOpenGLRenderWindow_GetZbufferData_22(HandleRef pThis, int x1, int y1, int x2, int y2, HandleRef z);

		public override int GetZbufferData(int x1, int y1, int x2, int y2, vtkFloatArray z)
		{
			return vtkOpenGLRenderWindow.vtkOpenGLRenderWindow_GetZbufferData_22(base.GetCppThis(), x1, y1, x2, y2, (z == null) ? default(HandleRef) : z.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkOpenGLRenderWindow_HasGraphicError_23(HandleRef pThis);

		public override int HasGraphicError()
		{
			return vtkOpenGLRenderWindow.vtkOpenGLRenderWindow_HasGraphicError_23(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkOpenGLRenderWindow_IsA_24(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkOpenGLRenderWindow.vtkOpenGLRenderWindow_IsA_24(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkOpenGLRenderWindow_IsTypeOf_25(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkOpenGLRenderWindow.vtkOpenGLRenderWindow_IsTypeOf_25(type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkOpenGLRenderWindow_NewInstance_26(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkOpenGLRenderWindow NewInstance()
		{
			vtkOpenGLRenderWindow result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkOpenGLRenderWindow.vtkOpenGLRenderWindow_NewInstance_26(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOpenGLRenderWindow)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkOpenGLRenderWindow_OpenGLInit_27(HandleRef pThis);

		public virtual void OpenGLInit()
		{
			vtkOpenGLRenderWindow.vtkOpenGLRenderWindow_OpenGLInit_27(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkOpenGLRenderWindow_RegisterTextureResource_28(HandleRef pThis, uint id);

		public void RegisterTextureResource(uint id)
		{
			vtkOpenGLRenderWindow.vtkOpenGLRenderWindow_RegisterTextureResource_28(base.GetCppThis(), id);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkOpenGLRenderWindow_ReleaseRGBAPixelData_29(HandleRef pThis, IntPtr data);

		public override void ReleaseRGBAPixelData(IntPtr data)
		{
			vtkOpenGLRenderWindow.vtkOpenGLRenderWindow_ReleaseRGBAPixelData_29(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkOpenGLRenderWindow_SafeDownCast_30(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkOpenGLRenderWindow SafeDownCast(vtkObjectBase o)
		{
			vtkOpenGLRenderWindow vtkOpenGLRenderWindow = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkOpenGLRenderWindow.vtkOpenGLRenderWindow_SafeDownCast_30((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkOpenGLRenderWindow = (vtkOpenGLRenderWindow)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkOpenGLRenderWindow.Register(null);
				}
			}
			return vtkOpenGLRenderWindow;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkOpenGLRenderWindow_SetGlobalMaximumNumberOfMultiSamples_31(int val);

		public static void SetGlobalMaximumNumberOfMultiSamples(int val)
		{
			vtkOpenGLRenderWindow.vtkOpenGLRenderWindow_SetGlobalMaximumNumberOfMultiSamples_31(val);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkOpenGLRenderWindow_SetPixelData_32(HandleRef pThis, int x, int y, int x2, int y2, IntPtr data, int front);

		public override int SetPixelData(int x, int y, int x2, int y2, IntPtr data, int front)
		{
			return vtkOpenGLRenderWindow.vtkOpenGLRenderWindow_SetPixelData_32(base.GetCppThis(), x, y, x2, y2, data, front);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkOpenGLRenderWindow_SetPixelData_33(HandleRef pThis, int x, int y, int x2, int y2, HandleRef data, int front);

		public override int SetPixelData(int x, int y, int x2, int y2, vtkUnsignedCharArray data, int front)
		{
			return vtkOpenGLRenderWindow.vtkOpenGLRenderWindow_SetPixelData_33(base.GetCppThis(), x, y, x2, y2, (data == null) ? default(HandleRef) : data.GetCppThis(), front);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkOpenGLRenderWindow_SetRGBACharPixelData_34(HandleRef pThis, int x, int y, int x2, int y2, IntPtr data, int front, int blend);

		public override int SetRGBACharPixelData(int x, int y, int x2, int y2, IntPtr data, int front, int blend)
		{
			return vtkOpenGLRenderWindow.vtkOpenGLRenderWindow_SetRGBACharPixelData_34(base.GetCppThis(), x, y, x2, y2, data, front, blend);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkOpenGLRenderWindow_SetRGBACharPixelData_35(HandleRef pThis, int x, int y, int x2, int y2, HandleRef data, int front, int blend);

		public override int SetRGBACharPixelData(int x, int y, int x2, int y2, vtkUnsignedCharArray data, int front, int blend)
		{
			return vtkOpenGLRenderWindow.vtkOpenGLRenderWindow_SetRGBACharPixelData_35(base.GetCppThis(), x, y, x2, y2, (data == null) ? default(HandleRef) : data.GetCppThis(), front, blend);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkOpenGLRenderWindow_SetRGBAPixelData_36(HandleRef pThis, int x, int y, int x2, int y2, IntPtr data, int front, int blend);

		public override int SetRGBAPixelData(int x, int y, int x2, int y2, IntPtr data, int front, int blend)
		{
			return vtkOpenGLRenderWindow.vtkOpenGLRenderWindow_SetRGBAPixelData_36(base.GetCppThis(), x, y, x2, y2, data, front, blend);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkOpenGLRenderWindow_SetRGBAPixelData_37(HandleRef pThis, int x, int y, int x2, int y2, HandleRef data, int front, int blend);

		public override int SetRGBAPixelData(int x, int y, int x2, int y2, vtkFloatArray data, int front, int blend)
		{
			return vtkOpenGLRenderWindow.vtkOpenGLRenderWindow_SetRGBAPixelData_37(base.GetCppThis(), x, y, x2, y2, (data == null) ? default(HandleRef) : data.GetCppThis(), front, blend);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkOpenGLRenderWindow_SetZbufferData_38(HandleRef pThis, int x1, int y1, int x2, int y2, IntPtr buffer);

		public override int SetZbufferData(int x1, int y1, int x2, int y2, IntPtr buffer)
		{
			return vtkOpenGLRenderWindow.vtkOpenGLRenderWindow_SetZbufferData_38(base.GetCppThis(), x1, y1, x2, y2, buffer);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkOpenGLRenderWindow_SetZbufferData_39(HandleRef pThis, int x1, int y1, int x2, int y2, HandleRef buffer);

		public override int SetZbufferData(int x1, int y1, int x2, int y2, vtkFloatArray buffer)
		{
			return vtkOpenGLRenderWindow.vtkOpenGLRenderWindow_SetZbufferData_39(base.GetCppThis(), x1, y1, x2, y2, (buffer == null) ? default(HandleRef) : buffer.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkOpenGLRenderWindow_StereoUpdate_40(HandleRef pThis);

		public override void StereoUpdate()
		{
			vtkOpenGLRenderWindow.vtkOpenGLRenderWindow_StereoUpdate_40(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkOpenGLRenderWindow_WaitForCompletion_41(HandleRef pThis);

		public override void WaitForCompletion()
		{
			vtkOpenGLRenderWindow.vtkOpenGLRenderWindow_WaitForCompletion_41(base.GetCppThis());
		}
	}
}
