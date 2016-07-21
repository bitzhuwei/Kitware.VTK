using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkGenericOpenGLRenderWindow : vtkOpenGLRenderWindow
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkGenericOpenGLRenderWindow";

		public new static readonly string MRClassNameKey;

		static vtkGenericOpenGLRenderWindow()
		{
			vtkGenericOpenGLRenderWindow.MRClassNameKey = "class vtkGenericOpenGLRenderWindow";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkGenericOpenGLRenderWindow.MRClassNameKey, Type.GetType("Kitware.VTK.vtkGenericOpenGLRenderWindow"));
		}

		public vtkGenericOpenGLRenderWindow(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkGenericOpenGLRenderWindow_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkGenericOpenGLRenderWindow New()
		{
			vtkGenericOpenGLRenderWindow result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGenericOpenGLRenderWindow.vtkGenericOpenGLRenderWindow_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGenericOpenGLRenderWindow)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkGenericOpenGLRenderWindow() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkGenericOpenGLRenderWindow.vtkGenericOpenGLRenderWindow_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkGenericOpenGLRenderWindow_CreateAWindow_01(HandleRef pThis);

		public virtual void CreateAWindow()
		{
			vtkGenericOpenGLRenderWindow.vtkGenericOpenGLRenderWindow_CreateAWindow_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkGenericOpenGLRenderWindow_DestroyWindow_02(HandleRef pThis);

		public virtual void DestroyWindow()
		{
			vtkGenericOpenGLRenderWindow.vtkGenericOpenGLRenderWindow_DestroyWindow_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkGenericOpenGLRenderWindow_Finalize_03(HandleRef pThis);

		public override void FinalizeWrapper()
		{
			vtkGenericOpenGLRenderWindow.vtkGenericOpenGLRenderWindow_Finalize_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkGenericOpenGLRenderWindow_Frame_04(HandleRef pThis);

		public override void Frame()
		{
			vtkGenericOpenGLRenderWindow.vtkGenericOpenGLRenderWindow_Frame_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkGenericOpenGLRenderWindow_GetEventPending_05(HandleRef pThis);

		public override int GetEventPending()
		{
			return vtkGenericOpenGLRenderWindow.vtkGenericOpenGLRenderWindow_GetEventPending_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkGenericOpenGLRenderWindow_GetGenericContext_06(HandleRef pThis);

		public override IntPtr GetGenericContext()
		{
			return vtkGenericOpenGLRenderWindow.vtkGenericOpenGLRenderWindow_GetGenericContext_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkGenericOpenGLRenderWindow_GetGenericDisplayId_07(HandleRef pThis);

		public override IntPtr GetGenericDisplayId()
		{
			return vtkGenericOpenGLRenderWindow.vtkGenericOpenGLRenderWindow_GetGenericDisplayId_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkGenericOpenGLRenderWindow_GetGenericDrawable_08(HandleRef pThis);

		public override IntPtr GetGenericDrawable()
		{
			return vtkGenericOpenGLRenderWindow.vtkGenericOpenGLRenderWindow_GetGenericDrawable_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkGenericOpenGLRenderWindow_GetGenericParentId_09(HandleRef pThis);

		public override IntPtr GetGenericParentId()
		{
			return vtkGenericOpenGLRenderWindow.vtkGenericOpenGLRenderWindow_GetGenericParentId_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkGenericOpenGLRenderWindow_GetGenericWindowId_10(HandleRef pThis);

		public override IntPtr GetGenericWindowId()
		{
			return vtkGenericOpenGLRenderWindow.vtkGenericOpenGLRenderWindow_GetGenericWindowId_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkGenericOpenGLRenderWindow_GetScreenSize_11(HandleRef pThis);

		public override IntPtr GetScreenSize()
		{
			return vtkGenericOpenGLRenderWindow.vtkGenericOpenGLRenderWindow_GetScreenSize_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkGenericOpenGLRenderWindow_HideCursor_12(HandleRef pThis);

		public override void HideCursor()
		{
			vtkGenericOpenGLRenderWindow.vtkGenericOpenGLRenderWindow_HideCursor_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkGenericOpenGLRenderWindow_IsA_13(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkGenericOpenGLRenderWindow.vtkGenericOpenGLRenderWindow_IsA_13(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern byte vtkGenericOpenGLRenderWindow_IsCurrent_14(HandleRef pThis);

		public override bool IsCurrent()
		{
			return vtkGenericOpenGLRenderWindow.vtkGenericOpenGLRenderWindow_IsCurrent_14(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkGenericOpenGLRenderWindow_IsDirect_15(HandleRef pThis);

		public override int IsDirect()
		{
			return vtkGenericOpenGLRenderWindow.vtkGenericOpenGLRenderWindow_IsDirect_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkGenericOpenGLRenderWindow_IsTypeOf_16(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkGenericOpenGLRenderWindow.vtkGenericOpenGLRenderWindow_IsTypeOf_16(type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkGenericOpenGLRenderWindow_MakeCurrent_17(HandleRef pThis);

		public override void MakeCurrent()
		{
			vtkGenericOpenGLRenderWindow.vtkGenericOpenGLRenderWindow_MakeCurrent_17(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkGenericOpenGLRenderWindow_NewInstance_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkGenericOpenGLRenderWindow NewInstance()
		{
			vtkGenericOpenGLRenderWindow result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGenericOpenGLRenderWindow.vtkGenericOpenGLRenderWindow_NewInstance_19(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGenericOpenGLRenderWindow)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkGenericOpenGLRenderWindow_PopState_20(HandleRef pThis);

		public void PopState()
		{
			vtkGenericOpenGLRenderWindow.vtkGenericOpenGLRenderWindow_PopState_20(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkGenericOpenGLRenderWindow_PushState_21(HandleRef pThis);

		public void PushState()
		{
			vtkGenericOpenGLRenderWindow.vtkGenericOpenGLRenderWindow_PushState_21(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkGenericOpenGLRenderWindow_SafeDownCast_22(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkGenericOpenGLRenderWindow SafeDownCast(vtkObjectBase o)
		{
			vtkGenericOpenGLRenderWindow vtkGenericOpenGLRenderWindow = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGenericOpenGLRenderWindow.vtkGenericOpenGLRenderWindow_SafeDownCast_22((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGenericOpenGLRenderWindow = (vtkGenericOpenGLRenderWindow)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGenericOpenGLRenderWindow.Register(null);
				}
			}
			return vtkGenericOpenGLRenderWindow;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkGenericOpenGLRenderWindow_SetBackBuffer_23(HandleRef pThis, uint arg0);

		public void SetBackBuffer(uint arg0)
		{
			vtkGenericOpenGLRenderWindow.vtkGenericOpenGLRenderWindow_SetBackBuffer_23(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkGenericOpenGLRenderWindow_SetBackLeftBuffer_24(HandleRef pThis, uint arg0);

		public void SetBackLeftBuffer(uint arg0)
		{
			vtkGenericOpenGLRenderWindow.vtkGenericOpenGLRenderWindow_SetBackLeftBuffer_24(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkGenericOpenGLRenderWindow_SetBackRightBuffer_25(HandleRef pThis, uint arg0);

		public void SetBackRightBuffer(uint arg0)
		{
			vtkGenericOpenGLRenderWindow.vtkGenericOpenGLRenderWindow_SetBackRightBuffer_25(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkGenericOpenGLRenderWindow_SetDisplayId_26(HandleRef pThis, IntPtr arg0);

		public override void SetDisplayId(IntPtr arg0)
		{
			vtkGenericOpenGLRenderWindow.vtkGenericOpenGLRenderWindow_SetDisplayId_26(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkGenericOpenGLRenderWindow_SetFrontBuffer_27(HandleRef pThis, uint arg0);

		public void SetFrontBuffer(uint arg0)
		{
			vtkGenericOpenGLRenderWindow.vtkGenericOpenGLRenderWindow_SetFrontBuffer_27(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkGenericOpenGLRenderWindow_SetFrontLeftBuffer_28(HandleRef pThis, uint arg0);

		public void SetFrontLeftBuffer(uint arg0)
		{
			vtkGenericOpenGLRenderWindow.vtkGenericOpenGLRenderWindow_SetFrontLeftBuffer_28(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkGenericOpenGLRenderWindow_SetFrontRightBuffer_29(HandleRef pThis, uint arg0);

		public void SetFrontRightBuffer(uint arg0)
		{
			vtkGenericOpenGLRenderWindow.vtkGenericOpenGLRenderWindow_SetFrontRightBuffer_29(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkGenericOpenGLRenderWindow_SetFullScreen_30(HandleRef pThis, int arg0);

		public override void SetFullScreen(int arg0)
		{
			vtkGenericOpenGLRenderWindow.vtkGenericOpenGLRenderWindow_SetFullScreen_30(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkGenericOpenGLRenderWindow_SetNextWindowId_31(HandleRef pThis, IntPtr arg0);

		public override void SetNextWindowId(IntPtr arg0)
		{
			vtkGenericOpenGLRenderWindow.vtkGenericOpenGLRenderWindow_SetNextWindowId_31(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkGenericOpenGLRenderWindow_SetNextWindowInfo_32(HandleRef pThis, string arg0);

		public override void SetNextWindowInfo(string arg0)
		{
			vtkGenericOpenGLRenderWindow.vtkGenericOpenGLRenderWindow_SetNextWindowInfo_32(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkGenericOpenGLRenderWindow_SetParentId_33(HandleRef pThis, IntPtr arg0);

		public override void SetParentId(IntPtr arg0)
		{
			vtkGenericOpenGLRenderWindow.vtkGenericOpenGLRenderWindow_SetParentId_33(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkGenericOpenGLRenderWindow_SetParentInfo_34(HandleRef pThis, string arg0);

		public override void SetParentInfo(string arg0)
		{
			vtkGenericOpenGLRenderWindow.vtkGenericOpenGLRenderWindow_SetParentInfo_34(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkGenericOpenGLRenderWindow_SetWindowId_35(HandleRef pThis, IntPtr arg0);

		public override void SetWindowId(IntPtr arg0)
		{
			vtkGenericOpenGLRenderWindow.vtkGenericOpenGLRenderWindow_SetWindowId_35(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkGenericOpenGLRenderWindow_SetWindowInfo_36(HandleRef pThis, string arg0);

		public override void SetWindowInfo(string arg0)
		{
			vtkGenericOpenGLRenderWindow.vtkGenericOpenGLRenderWindow_SetWindowInfo_36(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkGenericOpenGLRenderWindow_ShowCursor_37(HandleRef pThis);

		public override void ShowCursor()
		{
			vtkGenericOpenGLRenderWindow.vtkGenericOpenGLRenderWindow_ShowCursor_37(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkGenericOpenGLRenderWindow_Start_38(HandleRef pThis);

		public override void Start()
		{
			vtkGenericOpenGLRenderWindow.vtkGenericOpenGLRenderWindow_Start_38(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkGenericOpenGLRenderWindow_SupportsOpenGL_39(HandleRef pThis);

		public override int SupportsOpenGL()
		{
			return vtkGenericOpenGLRenderWindow.vtkGenericOpenGLRenderWindow_SupportsOpenGL_39(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkGenericOpenGLRenderWindow_WindowRemap_40(HandleRef pThis);

		public override void WindowRemap()
		{
			vtkGenericOpenGLRenderWindow.vtkGenericOpenGLRenderWindow_WindowRemap_40(base.GetCppThis());
		}
	}
}
