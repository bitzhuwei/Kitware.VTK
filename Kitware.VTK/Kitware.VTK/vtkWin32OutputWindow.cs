using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkWin32OutputWindow : vtkOutputWindow
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkWin32OutputWindow";

		public new static readonly string MRClassNameKey;

		static vtkWin32OutputWindow()
		{
			vtkWin32OutputWindow.MRClassNameKey = "class vtkWin32OutputWindow";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkWin32OutputWindow.MRClassNameKey, Type.GetType("Kitware.VTK.vtkWin32OutputWindow"));
		}

		public vtkWin32OutputWindow(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkWin32OutputWindow_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkWin32OutputWindow New()
		{
			vtkWin32OutputWindow result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkWin32OutputWindow.vtkWin32OutputWindow_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkWin32OutputWindow)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkWin32OutputWindow() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkWin32OutputWindow.vtkWin32OutputWindow_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkWin32OutputWindow_DisplayText_01(HandleRef pThis, string arg0);

		public override void DisplayText(string arg0)
		{
			vtkWin32OutputWindow.vtkWin32OutputWindow_DisplayText_01(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern byte vtkWin32OutputWindow_GetSendToStdErr_02(HandleRef pThis);

		public virtual bool GetSendToStdErr()
		{
			return vtkWin32OutputWindow.vtkWin32OutputWindow_GetSendToStdErr_02(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkWin32OutputWindow_IsA_03(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkWin32OutputWindow.vtkWin32OutputWindow_IsA_03(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkWin32OutputWindow_IsTypeOf_04(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkWin32OutputWindow.vtkWin32OutputWindow_IsTypeOf_04(type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkWin32OutputWindow_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkWin32OutputWindow NewInstance()
		{
			vtkWin32OutputWindow result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkWin32OutputWindow.vtkWin32OutputWindow_NewInstance_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkWin32OutputWindow)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkWin32OutputWindow_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkWin32OutputWindow SafeDownCast(vtkObjectBase o)
		{
			vtkWin32OutputWindow vtkWin32OutputWindow = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkWin32OutputWindow.vtkWin32OutputWindow_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkWin32OutputWindow = (vtkWin32OutputWindow)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkWin32OutputWindow.Register(null);
				}
			}
			return vtkWin32OutputWindow;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkWin32OutputWindow_SendToStdErrOff_08(HandleRef pThis);

		public virtual void SendToStdErrOff()
		{
			vtkWin32OutputWindow.vtkWin32OutputWindow_SendToStdErrOff_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkWin32OutputWindow_SendToStdErrOn_09(HandleRef pThis);

		public virtual void SendToStdErrOn()
		{
			vtkWin32OutputWindow.vtkWin32OutputWindow_SendToStdErrOn_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkWin32OutputWindow_SetSendToStdErr_10(HandleRef pThis, byte _arg);

		public virtual void SetSendToStdErr(bool _arg)
		{
			vtkWin32OutputWindow.vtkWin32OutputWindow_SetSendToStdErr_10(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}
	}
}
