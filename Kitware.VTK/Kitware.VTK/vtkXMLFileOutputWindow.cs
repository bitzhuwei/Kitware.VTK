using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkXMLFileOutputWindow : vtkFileOutputWindow
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkXMLFileOutputWindow";

		public new static readonly string MRClassNameKey;

		static vtkXMLFileOutputWindow()
		{
			vtkXMLFileOutputWindow.MRClassNameKey = "class vtkXMLFileOutputWindow";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkXMLFileOutputWindow.MRClassNameKey, Type.GetType("Kitware.VTK.vtkXMLFileOutputWindow"));
		}

		public vtkXMLFileOutputWindow(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkXMLFileOutputWindow_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkXMLFileOutputWindow New()
		{
			vtkXMLFileOutputWindow result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkXMLFileOutputWindow.vtkXMLFileOutputWindow_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXMLFileOutputWindow)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkXMLFileOutputWindow() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkXMLFileOutputWindow.vtkXMLFileOutputWindow_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkXMLFileOutputWindow_DisplayDebugText_01(HandleRef pThis, string arg0);

		public override void DisplayDebugText(string arg0)
		{
			vtkXMLFileOutputWindow.vtkXMLFileOutputWindow_DisplayDebugText_01(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkXMLFileOutputWindow_DisplayErrorText_02(HandleRef pThis, string arg0);

		public override void DisplayErrorText(string arg0)
		{
			vtkXMLFileOutputWindow.vtkXMLFileOutputWindow_DisplayErrorText_02(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkXMLFileOutputWindow_DisplayGenericWarningText_03(HandleRef pThis, string arg0);

		public override void DisplayGenericWarningText(string arg0)
		{
			vtkXMLFileOutputWindow.vtkXMLFileOutputWindow_DisplayGenericWarningText_03(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkXMLFileOutputWindow_DisplayTag_04(HandleRef pThis, string arg0);

		public virtual void DisplayTag(string arg0)
		{
			vtkXMLFileOutputWindow.vtkXMLFileOutputWindow_DisplayTag_04(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkXMLFileOutputWindow_DisplayText_05(HandleRef pThis, string arg0);

		public override void DisplayText(string arg0)
		{
			vtkXMLFileOutputWindow.vtkXMLFileOutputWindow_DisplayText_05(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkXMLFileOutputWindow_DisplayWarningText_06(HandleRef pThis, string arg0);

		public override void DisplayWarningText(string arg0)
		{
			vtkXMLFileOutputWindow.vtkXMLFileOutputWindow_DisplayWarningText_06(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkXMLFileOutputWindow_IsA_07(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkXMLFileOutputWindow.vtkXMLFileOutputWindow_IsA_07(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkXMLFileOutputWindow_IsTypeOf_08(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkXMLFileOutputWindow.vtkXMLFileOutputWindow_IsTypeOf_08(type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkXMLFileOutputWindow_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkXMLFileOutputWindow NewInstance()
		{
			vtkXMLFileOutputWindow result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkXMLFileOutputWindow.vtkXMLFileOutputWindow_NewInstance_10(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXMLFileOutputWindow)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkXMLFileOutputWindow_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkXMLFileOutputWindow SafeDownCast(vtkObjectBase o)
		{
			vtkXMLFileOutputWindow vtkXMLFileOutputWindow = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkXMLFileOutputWindow.vtkXMLFileOutputWindow_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkXMLFileOutputWindow = (vtkXMLFileOutputWindow)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkXMLFileOutputWindow.Register(null);
				}
			}
			return vtkXMLFileOutputWindow;
		}
	}
}
