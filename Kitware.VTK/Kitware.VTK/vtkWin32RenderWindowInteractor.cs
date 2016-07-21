using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkWin32RenderWindowInteractor : vtkRenderWindowInteractor
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkWin32RenderWindowInteractor";

		public new static readonly string MRClassNameKey;

		static vtkWin32RenderWindowInteractor()
		{
			vtkWin32RenderWindowInteractor.MRClassNameKey = "class vtkWin32RenderWindowInteractor";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkWin32RenderWindowInteractor.MRClassNameKey, Type.GetType("Kitware.VTK.vtkWin32RenderWindowInteractor"));
		}

		public vtkWin32RenderWindowInteractor(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkWin32RenderWindowInteractor_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkWin32RenderWindowInteractor New()
		{
			vtkWin32RenderWindowInteractor result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkWin32RenderWindowInteractor.vtkWin32RenderWindowInteractor_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkWin32RenderWindowInteractor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkWin32RenderWindowInteractor() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkWin32RenderWindowInteractor.vtkWin32RenderWindowInteractor_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkWin32RenderWindowInteractor_Disable_01(HandleRef pThis);

		public override void Disable()
		{
			vtkWin32RenderWindowInteractor.vtkWin32RenderWindowInteractor_Disable_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkWin32RenderWindowInteractor_Enable_02(HandleRef pThis);

		public override void Enable()
		{
			vtkWin32RenderWindowInteractor.vtkWin32RenderWindowInteractor_Enable_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkWin32RenderWindowInteractor_ExitCallback_03(HandleRef pThis);

		public override void ExitCallback()
		{
			vtkWin32RenderWindowInteractor.vtkWin32RenderWindowInteractor_ExitCallback_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkWin32RenderWindowInteractor_GetInstallMessageProc_04(HandleRef pThis);

		public virtual int GetInstallMessageProc()
		{
			return vtkWin32RenderWindowInteractor.vtkWin32RenderWindowInteractor_GetInstallMessageProc_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkWin32RenderWindowInteractor_Initialize_05(HandleRef pThis);

		public override void Initialize()
		{
			vtkWin32RenderWindowInteractor.vtkWin32RenderWindowInteractor_Initialize_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkWin32RenderWindowInteractor_InstallMessageProcOff_06(HandleRef pThis);

		public virtual void InstallMessageProcOff()
		{
			vtkWin32RenderWindowInteractor.vtkWin32RenderWindowInteractor_InstallMessageProcOff_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkWin32RenderWindowInteractor_InstallMessageProcOn_07(HandleRef pThis);

		public virtual void InstallMessageProcOn()
		{
			vtkWin32RenderWindowInteractor.vtkWin32RenderWindowInteractor_InstallMessageProcOn_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkWin32RenderWindowInteractor_IsA_08(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkWin32RenderWindowInteractor.vtkWin32RenderWindowInteractor_IsA_08(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkWin32RenderWindowInteractor_IsTypeOf_09(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkWin32RenderWindowInteractor.vtkWin32RenderWindowInteractor_IsTypeOf_09(type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkWin32RenderWindowInteractor_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkWin32RenderWindowInteractor NewInstance()
		{
			vtkWin32RenderWindowInteractor result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkWin32RenderWindowInteractor.vtkWin32RenderWindowInteractor_NewInstance_11(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkWin32RenderWindowInteractor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkWin32RenderWindowInteractor_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkWin32RenderWindowInteractor SafeDownCast(vtkObjectBase o)
		{
			vtkWin32RenderWindowInteractor vtkWin32RenderWindowInteractor = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkWin32RenderWindowInteractor.vtkWin32RenderWindowInteractor_SafeDownCast_12((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkWin32RenderWindowInteractor = (vtkWin32RenderWindowInteractor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkWin32RenderWindowInteractor.Register(null);
				}
			}
			return vtkWin32RenderWindowInteractor;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkWin32RenderWindowInteractor_SetInstallMessageProc_13(HandleRef pThis, int _arg);

		public virtual void SetInstallMessageProc(int _arg)
		{
			vtkWin32RenderWindowInteractor.vtkWin32RenderWindowInteractor_SetInstallMessageProc_13(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkWin32RenderWindowInteractor_Start_14(HandleRef pThis);

		public override void Start()
		{
			vtkWin32RenderWindowInteractor.vtkWin32RenderWindowInteractor_Start_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkWin32RenderWindowInteractor_TerminateApp_15(HandleRef pThis);

		public override void TerminateApp()
		{
			vtkWin32RenderWindowInteractor.vtkWin32RenderWindowInteractor_TerminateApp_15(base.GetCppThis());
		}
	}
}
