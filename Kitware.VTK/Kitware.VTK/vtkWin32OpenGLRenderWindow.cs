using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkWin32OpenGLRenderWindow : vtkOpenGLRenderWindow
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkWin32OpenGLRenderWindow";

		public new static readonly string MRClassNameKey;

		static vtkWin32OpenGLRenderWindow()
		{
			vtkWin32OpenGLRenderWindow.MRClassNameKey = "class vtkWin32OpenGLRenderWindow";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkWin32OpenGLRenderWindow.MRClassNameKey, Type.GetType("Kitware.VTK.vtkWin32OpenGLRenderWindow"));
		}

		public vtkWin32OpenGLRenderWindow(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkWin32OpenGLRenderWindow_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkWin32OpenGLRenderWindow New()
		{
			vtkWin32OpenGLRenderWindow result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkWin32OpenGLRenderWindow.vtkWin32OpenGLRenderWindow_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkWin32OpenGLRenderWindow)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkWin32OpenGLRenderWindow() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkWin32OpenGLRenderWindow.vtkWin32OpenGLRenderWindow_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkWin32OpenGLRenderWindow_Clean_01(HandleRef pThis);

		public void Clean()
		{
			vtkWin32OpenGLRenderWindow.vtkWin32OpenGLRenderWindow_Clean_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkWin32OpenGLRenderWindow_Finalize_02(HandleRef pThis);

		public override void FinalizeWrapper()
		{
			vtkWin32OpenGLRenderWindow.vtkWin32OpenGLRenderWindow_Finalize_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkWin32OpenGLRenderWindow_Frame_03(HandleRef pThis);

		public override void Frame()
		{
			vtkWin32OpenGLRenderWindow.vtkWin32OpenGLRenderWindow_Frame_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkWin32OpenGLRenderWindow_GetEventPending_04(HandleRef pThis);

		public override int GetEventPending()
		{
			return vtkWin32OpenGLRenderWindow.vtkWin32OpenGLRenderWindow_GetEventPending_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkWin32OpenGLRenderWindow_GetGenericContext_05(HandleRef pThis);

		public override IntPtr GetGenericContext()
		{
			return vtkWin32OpenGLRenderWindow.vtkWin32OpenGLRenderWindow_GetGenericContext_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkWin32OpenGLRenderWindow_GetGenericDisplayId_06(HandleRef pThis);

		public override IntPtr GetGenericDisplayId()
		{
			return vtkWin32OpenGLRenderWindow.vtkWin32OpenGLRenderWindow_GetGenericDisplayId_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkWin32OpenGLRenderWindow_GetGenericDrawable_07(HandleRef pThis);

		public override IntPtr GetGenericDrawable()
		{
			return vtkWin32OpenGLRenderWindow.vtkWin32OpenGLRenderWindow_GetGenericDrawable_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkWin32OpenGLRenderWindow_GetGenericParentId_08(HandleRef pThis);

		public override IntPtr GetGenericParentId()
		{
			return vtkWin32OpenGLRenderWindow.vtkWin32OpenGLRenderWindow_GetGenericParentId_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkWin32OpenGLRenderWindow_GetGenericWindowId_09(HandleRef pThis);

		public override IntPtr GetGenericWindowId()
		{
			return vtkWin32OpenGLRenderWindow.vtkWin32OpenGLRenderWindow_GetGenericWindowId_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkWin32OpenGLRenderWindow_GetMemoryData_10(HandleRef pThis);

		public IntPtr GetMemoryData()
		{
			return vtkWin32OpenGLRenderWindow.vtkWin32OpenGLRenderWindow_GetMemoryData_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkWin32OpenGLRenderWindow_GetPosition_11(HandleRef pThis);

		public override int[] GetPosition()
		{
			IntPtr intPtr = vtkWin32OpenGLRenderWindow.vtkWin32OpenGLRenderWindow_GetPosition_11(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkWin32OpenGLRenderWindow_GetScreenSize_12(HandleRef pThis);

		public override IntPtr GetScreenSize()
		{
			return vtkWin32OpenGLRenderWindow.vtkWin32OpenGLRenderWindow_GetScreenSize_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkWin32OpenGLRenderWindow_GetSize_13(HandleRef pThis);

		public override int[] GetSize()
		{
			IntPtr intPtr = vtkWin32OpenGLRenderWindow.vtkWin32OpenGLRenderWindow_GetSize_13(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkWin32OpenGLRenderWindow_HideCursor_14(HandleRef pThis);

		public override void HideCursor()
		{
			vtkWin32OpenGLRenderWindow.vtkWin32OpenGLRenderWindow_HideCursor_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkWin32OpenGLRenderWindow_Initialize_15(HandleRef pThis);

		public virtual void Initialize()
		{
			vtkWin32OpenGLRenderWindow.vtkWin32OpenGLRenderWindow_Initialize_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkWin32OpenGLRenderWindow_IsA_16(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkWin32OpenGLRenderWindow.vtkWin32OpenGLRenderWindow_IsA_16(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern byte vtkWin32OpenGLRenderWindow_IsCurrent_17(HandleRef pThis);

		public override bool IsCurrent()
		{
			return vtkWin32OpenGLRenderWindow.vtkWin32OpenGLRenderWindow_IsCurrent_17(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkWin32OpenGLRenderWindow_IsDirect_18(HandleRef pThis);

		public override int IsDirect()
		{
			return vtkWin32OpenGLRenderWindow.vtkWin32OpenGLRenderWindow_IsDirect_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkWin32OpenGLRenderWindow_IsTypeOf_19(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkWin32OpenGLRenderWindow.vtkWin32OpenGLRenderWindow_IsTypeOf_19(type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkWin32OpenGLRenderWindow_MakeCurrent_20(HandleRef pThis);

		public override void MakeCurrent()
		{
			vtkWin32OpenGLRenderWindow.vtkWin32OpenGLRenderWindow_MakeCurrent_20(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkWin32OpenGLRenderWindow_NewInstance_22(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkWin32OpenGLRenderWindow NewInstance()
		{
			vtkWin32OpenGLRenderWindow result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkWin32OpenGLRenderWindow.vtkWin32OpenGLRenderWindow_NewInstance_22(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkWin32OpenGLRenderWindow)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkWin32OpenGLRenderWindow_PrefFullScreen_23(HandleRef pThis);

		public virtual void PrefFullScreen()
		{
			vtkWin32OpenGLRenderWindow.vtkWin32OpenGLRenderWindow_PrefFullScreen_23(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkWin32OpenGLRenderWindow_ReportCapabilities_24(HandleRef pThis);

		public override string ReportCapabilities()
		{
			return Marshal.PtrToStringAnsi(vtkWin32OpenGLRenderWindow.vtkWin32OpenGLRenderWindow_ReportCapabilities_24(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkWin32OpenGLRenderWindow_ResumeScreenRendering_25(HandleRef pThis);

		public void ResumeScreenRendering()
		{
			vtkWin32OpenGLRenderWindow.vtkWin32OpenGLRenderWindow_ResumeScreenRendering_25(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkWin32OpenGLRenderWindow_SafeDownCast_26(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkWin32OpenGLRenderWindow SafeDownCast(vtkObjectBase o)
		{
			vtkWin32OpenGLRenderWindow vtkWin32OpenGLRenderWindow = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkWin32OpenGLRenderWindow.vtkWin32OpenGLRenderWindow_SafeDownCast_26((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkWin32OpenGLRenderWindow = (vtkWin32OpenGLRenderWindow)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkWin32OpenGLRenderWindow.Register(null);
				}
			}
			return vtkWin32OpenGLRenderWindow;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkWin32OpenGLRenderWindow_SetCurrentCursor_27(HandleRef pThis, int arg0);

		public override void SetCurrentCursor(int arg0)
		{
			vtkWin32OpenGLRenderWindow.vtkWin32OpenGLRenderWindow_SetCurrentCursor_27(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkWin32OpenGLRenderWindow_SetCursorPosition_28(HandleRef pThis, int x, int y);

		public override void SetCursorPosition(int x, int y)
		{
			vtkWin32OpenGLRenderWindow.vtkWin32OpenGLRenderWindow_SetCursorPosition_28(base.GetCppThis(), x, y);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkWin32OpenGLRenderWindow_SetDisplayId_29(HandleRef pThis, IntPtr arg0);

		public override void SetDisplayId(IntPtr arg0)
		{
			vtkWin32OpenGLRenderWindow.vtkWin32OpenGLRenderWindow_SetDisplayId_29(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkWin32OpenGLRenderWindow_SetFullScreen_30(HandleRef pThis, int arg0);

		public override void SetFullScreen(int arg0)
		{
			vtkWin32OpenGLRenderWindow.vtkWin32OpenGLRenderWindow_SetFullScreen_30(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkWin32OpenGLRenderWindow_SetNextWindowId_31(HandleRef pThis, IntPtr arg);

		public override void SetNextWindowId(IntPtr arg)
		{
			vtkWin32OpenGLRenderWindow.vtkWin32OpenGLRenderWindow_SetNextWindowId_31(base.GetCppThis(), arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkWin32OpenGLRenderWindow_SetNextWindowInfo_32(HandleRef pThis, string arg0);

		public override void SetNextWindowInfo(string arg0)
		{
			vtkWin32OpenGLRenderWindow.vtkWin32OpenGLRenderWindow_SetNextWindowInfo_32(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkWin32OpenGLRenderWindow_SetOffScreenRendering_33(HandleRef pThis, int offscreen);

		public override void SetOffScreenRendering(int offscreen)
		{
			vtkWin32OpenGLRenderWindow.vtkWin32OpenGLRenderWindow_SetOffScreenRendering_33(base.GetCppThis(), offscreen);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkWin32OpenGLRenderWindow_SetParentId_34(HandleRef pThis, IntPtr foo);

		public override void SetParentId(IntPtr foo)
		{
			vtkWin32OpenGLRenderWindow.vtkWin32OpenGLRenderWindow_SetParentId_34(base.GetCppThis(), foo);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkWin32OpenGLRenderWindow_SetParentInfo_35(HandleRef pThis, string arg0);

		public override void SetParentInfo(string arg0)
		{
			vtkWin32OpenGLRenderWindow.vtkWin32OpenGLRenderWindow_SetParentInfo_35(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkWin32OpenGLRenderWindow_SetPosition_36(HandleRef pThis, int arg0, int arg1);

		public override void SetPosition(int arg0, int arg1)
		{
			vtkWin32OpenGLRenderWindow.vtkWin32OpenGLRenderWindow_SetPosition_36(base.GetCppThis(), arg0, arg1);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkWin32OpenGLRenderWindow_SetPosition_37(HandleRef pThis, IntPtr a);

		public override void SetPosition(IntPtr a)
		{
			vtkWin32OpenGLRenderWindow.vtkWin32OpenGLRenderWindow_SetPosition_37(base.GetCppThis(), a);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkWin32OpenGLRenderWindow_SetSize_38(HandleRef pThis, int arg0, int arg1);

		public override void SetSize(int arg0, int arg1)
		{
			vtkWin32OpenGLRenderWindow.vtkWin32OpenGLRenderWindow_SetSize_38(base.GetCppThis(), arg0, arg1);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkWin32OpenGLRenderWindow_SetSize_39(HandleRef pThis, IntPtr a);

		public override void SetSize(IntPtr a)
		{
			vtkWin32OpenGLRenderWindow.vtkWin32OpenGLRenderWindow_SetSize_39(base.GetCppThis(), a);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkWin32OpenGLRenderWindow_SetStereoCapableWindow_40(HandleRef pThis, int capable);

		public override void SetStereoCapableWindow(int capable)
		{
			vtkWin32OpenGLRenderWindow.vtkWin32OpenGLRenderWindow_SetStereoCapableWindow_40(base.GetCppThis(), capable);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkWin32OpenGLRenderWindow_SetWindowId_41(HandleRef pThis, IntPtr foo);

		public override void SetWindowId(IntPtr foo)
		{
			vtkWin32OpenGLRenderWindow.vtkWin32OpenGLRenderWindow_SetWindowId_41(base.GetCppThis(), foo);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkWin32OpenGLRenderWindow_SetWindowInfo_42(HandleRef pThis, string arg0);

		public override void SetWindowInfo(string arg0)
		{
			vtkWin32OpenGLRenderWindow.vtkWin32OpenGLRenderWindow_SetWindowInfo_42(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkWin32OpenGLRenderWindow_SetWindowName_43(HandleRef pThis, string arg0);

		public override void SetWindowName(string arg0)
		{
			vtkWin32OpenGLRenderWindow.vtkWin32OpenGLRenderWindow_SetWindowName_43(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkWin32OpenGLRenderWindow_ShowCursor_44(HandleRef pThis);

		public override void ShowCursor()
		{
			vtkWin32OpenGLRenderWindow.vtkWin32OpenGLRenderWindow_ShowCursor_44(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkWin32OpenGLRenderWindow_Start_45(HandleRef pThis);

		public override void Start()
		{
			vtkWin32OpenGLRenderWindow.vtkWin32OpenGLRenderWindow_Start_45(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkWin32OpenGLRenderWindow_SupportsOpenGL_46(HandleRef pThis);

		public override int SupportsOpenGL()
		{
			return vtkWin32OpenGLRenderWindow.vtkWin32OpenGLRenderWindow_SupportsOpenGL_46(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkWin32OpenGLRenderWindow_WindowInitialize_47(HandleRef pThis);

		public virtual void WindowInitialize()
		{
			vtkWin32OpenGLRenderWindow.vtkWin32OpenGLRenderWindow_WindowInitialize_47(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkWin32OpenGLRenderWindow_WindowRemap_48(HandleRef pThis);

		public override void WindowRemap()
		{
			vtkWin32OpenGLRenderWindow.vtkWin32OpenGLRenderWindow_WindowRemap_48(base.GetCppThis());
		}
	}
}
