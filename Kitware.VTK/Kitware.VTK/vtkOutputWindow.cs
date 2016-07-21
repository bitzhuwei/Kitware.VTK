using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkOutputWindow : vtkObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkOutputWindow";

		public new static readonly string MRClassNameKey;

		static vtkOutputWindow()
		{
			vtkOutputWindow.MRClassNameKey = "class vtkOutputWindow";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkOutputWindow.MRClassNameKey, Type.GetType("Kitware.VTK.vtkOutputWindow"));
		}

		public vtkOutputWindow(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkOutputWindow_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkOutputWindow New()
		{
			vtkOutputWindow result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkOutputWindow.vtkOutputWindow_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOutputWindow)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkOutputWindow() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkOutputWindow.vtkOutputWindow_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkOutputWindow_DisplayDebugText_01(HandleRef pThis, string arg0);

		public virtual void DisplayDebugText(string arg0)
		{
			vtkOutputWindow.vtkOutputWindow_DisplayDebugText_01(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkOutputWindow_DisplayErrorText_02(HandleRef pThis, string arg0);

		public virtual void DisplayErrorText(string arg0)
		{
			vtkOutputWindow.vtkOutputWindow_DisplayErrorText_02(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkOutputWindow_DisplayGenericWarningText_03(HandleRef pThis, string arg0);

		public virtual void DisplayGenericWarningText(string arg0)
		{
			vtkOutputWindow.vtkOutputWindow_DisplayGenericWarningText_03(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkOutputWindow_DisplayText_04(HandleRef pThis, string arg0);

		public virtual void DisplayText(string arg0)
		{
			vtkOutputWindow.vtkOutputWindow_DisplayText_04(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkOutputWindow_DisplayWarningText_05(HandleRef pThis, string arg0);

		public virtual void DisplayWarningText(string arg0)
		{
			vtkOutputWindow.vtkOutputWindow_DisplayWarningText_05(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkOutputWindow_GetInstance_06(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public static vtkOutputWindow GetInstance()
		{
			vtkOutputWindow vtkOutputWindow = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkOutputWindow.vtkOutputWindow_GetInstance_06(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkOutputWindow = (vtkOutputWindow)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkOutputWindow.Register(null);
				}
			}
			return vtkOutputWindow;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkOutputWindow_IsA_07(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkOutputWindow.vtkOutputWindow_IsA_07(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkOutputWindow_IsTypeOf_08(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkOutputWindow.vtkOutputWindow_IsTypeOf_08(type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkOutputWindow_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkOutputWindow NewInstance()
		{
			vtkOutputWindow result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkOutputWindow.vtkOutputWindow_NewInstance_10(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOutputWindow)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkOutputWindow_PromptUserOff_11(HandleRef pThis);

		public virtual void PromptUserOff()
		{
			vtkOutputWindow.vtkOutputWindow_PromptUserOff_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkOutputWindow_PromptUserOn_12(HandleRef pThis);

		public virtual void PromptUserOn()
		{
			vtkOutputWindow.vtkOutputWindow_PromptUserOn_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkOutputWindow_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkOutputWindow SafeDownCast(vtkObjectBase o)
		{
			vtkOutputWindow vtkOutputWindow = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkOutputWindow.vtkOutputWindow_SafeDownCast_13((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkOutputWindow = (vtkOutputWindow)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkOutputWindow.Register(null);
				}
			}
			return vtkOutputWindow;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkOutputWindow_SetInstance_14(HandleRef instance);

		public static void SetInstance(vtkOutputWindow instance)
		{
			vtkOutputWindow.vtkOutputWindow_SetInstance_14((instance == null) ? default(HandleRef) : instance.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkOutputWindow_SetPromptUser_15(HandleRef pThis, int _arg);

		public virtual void SetPromptUser(int _arg)
		{
			vtkOutputWindow.vtkOutputWindow_SetPromptUser_15(base.GetCppThis(), _arg);
		}
	}
}
