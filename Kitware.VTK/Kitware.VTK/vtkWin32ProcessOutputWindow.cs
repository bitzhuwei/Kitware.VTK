using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkWin32ProcessOutputWindow : vtkOutputWindow
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkWin32ProcessOutputWindow";

		public new static readonly string MRClassNameKey;

		static vtkWin32ProcessOutputWindow()
		{
			vtkWin32ProcessOutputWindow.MRClassNameKey = "class vtkWin32ProcessOutputWindow";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkWin32ProcessOutputWindow.MRClassNameKey, Type.GetType("Kitware.VTK.vtkWin32ProcessOutputWindow"));
		}

		public vtkWin32ProcessOutputWindow(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkWin32ProcessOutputWindow_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkWin32ProcessOutputWindow New()
		{
			vtkWin32ProcessOutputWindow result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkWin32ProcessOutputWindow.vtkWin32ProcessOutputWindow_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkWin32ProcessOutputWindow)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkWin32ProcessOutputWindow() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkWin32ProcessOutputWindow.vtkWin32ProcessOutputWindow_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkWin32ProcessOutputWindow_DisplayText_01(HandleRef pThis, string arg0);

		public override void DisplayText(string arg0)
		{
			vtkWin32ProcessOutputWindow.vtkWin32ProcessOutputWindow_DisplayText_01(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkWin32ProcessOutputWindow_IsA_02(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkWin32ProcessOutputWindow.vtkWin32ProcessOutputWindow_IsA_02(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkWin32ProcessOutputWindow_IsTypeOf_03(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkWin32ProcessOutputWindow.vtkWin32ProcessOutputWindow_IsTypeOf_03(type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkWin32ProcessOutputWindow_NewInstance_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkWin32ProcessOutputWindow NewInstance()
		{
			vtkWin32ProcessOutputWindow result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkWin32ProcessOutputWindow.vtkWin32ProcessOutputWindow_NewInstance_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkWin32ProcessOutputWindow)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkWin32ProcessOutputWindow_SafeDownCast_06(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkWin32ProcessOutputWindow SafeDownCast(vtkObjectBase o)
		{
			vtkWin32ProcessOutputWindow vtkWin32ProcessOutputWindow = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkWin32ProcessOutputWindow.vtkWin32ProcessOutputWindow_SafeDownCast_06((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkWin32ProcessOutputWindow = (vtkWin32ProcessOutputWindow)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkWin32ProcessOutputWindow.Register(null);
				}
			}
			return vtkWin32ProcessOutputWindow;
		}
	}
}
