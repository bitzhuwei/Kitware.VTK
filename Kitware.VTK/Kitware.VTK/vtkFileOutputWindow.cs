using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkFileOutputWindow : vtkOutputWindow
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkFileOutputWindow";

		public new static readonly string MRClassNameKey;

		static vtkFileOutputWindow()
		{
			vtkFileOutputWindow.MRClassNameKey = "class vtkFileOutputWindow";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkFileOutputWindow.MRClassNameKey, Type.GetType("Kitware.VTK.vtkFileOutputWindow"));
		}

		public vtkFileOutputWindow(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkFileOutputWindow_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkFileOutputWindow New()
		{
			vtkFileOutputWindow result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkFileOutputWindow.vtkFileOutputWindow_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkFileOutputWindow)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkFileOutputWindow() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkFileOutputWindow.vtkFileOutputWindow_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkFileOutputWindow_AppendOff_01(HandleRef pThis);

		public virtual void AppendOff()
		{
			vtkFileOutputWindow.vtkFileOutputWindow_AppendOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkFileOutputWindow_AppendOn_02(HandleRef pThis);

		public virtual void AppendOn()
		{
			vtkFileOutputWindow.vtkFileOutputWindow_AppendOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkFileOutputWindow_DisplayText_03(HandleRef pThis, string arg0);

		public override void DisplayText(string arg0)
		{
			vtkFileOutputWindow.vtkFileOutputWindow_DisplayText_03(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkFileOutputWindow_FlushOff_04(HandleRef pThis);

		public virtual void FlushOff()
		{
			vtkFileOutputWindow.vtkFileOutputWindow_FlushOff_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkFileOutputWindow_FlushOn_05(HandleRef pThis);

		public virtual void FlushOn()
		{
			vtkFileOutputWindow.vtkFileOutputWindow_FlushOn_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkFileOutputWindow_GetAppend_06(HandleRef pThis);

		public virtual int GetAppend()
		{
			return vtkFileOutputWindow.vtkFileOutputWindow_GetAppend_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkFileOutputWindow_GetFileName_07(HandleRef pThis);

		public virtual string GetFileName()
		{
			return Marshal.PtrToStringAnsi(vtkFileOutputWindow.vtkFileOutputWindow_GetFileName_07(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkFileOutputWindow_GetFlush_08(HandleRef pThis);

		public virtual int GetFlush()
		{
			return vtkFileOutputWindow.vtkFileOutputWindow_GetFlush_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkFileOutputWindow_IsA_09(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkFileOutputWindow.vtkFileOutputWindow_IsA_09(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkFileOutputWindow_IsTypeOf_10(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkFileOutputWindow.vtkFileOutputWindow_IsTypeOf_10(type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkFileOutputWindow_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkFileOutputWindow NewInstance()
		{
			vtkFileOutputWindow result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkFileOutputWindow.vtkFileOutputWindow_NewInstance_12(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkFileOutputWindow)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkFileOutputWindow_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkFileOutputWindow SafeDownCast(vtkObjectBase o)
		{
			vtkFileOutputWindow vtkFileOutputWindow = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkFileOutputWindow.vtkFileOutputWindow_SafeDownCast_13((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkFileOutputWindow = (vtkFileOutputWindow)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkFileOutputWindow.Register(null);
				}
			}
			return vtkFileOutputWindow;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkFileOutputWindow_SetAppend_14(HandleRef pThis, int _arg);

		public virtual void SetAppend(int _arg)
		{
			vtkFileOutputWindow.vtkFileOutputWindow_SetAppend_14(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkFileOutputWindow_SetFileName_15(HandleRef pThis, string _arg);

		public virtual void SetFileName(string _arg)
		{
			vtkFileOutputWindow.vtkFileOutputWindow_SetFileName_15(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkFileOutputWindow_SetFlush_16(HandleRef pThis, int _arg);

		public virtual void SetFlush(int _arg)
		{
			vtkFileOutputWindow.vtkFileOutputWindow_SetFlush_16(base.GetCppThis(), _arg);
		}
	}
}
