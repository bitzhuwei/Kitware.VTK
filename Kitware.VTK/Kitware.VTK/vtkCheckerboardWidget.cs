using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkCheckerboardWidget : vtkAbstractWidget
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkCheckerboardWidget";

		public new static readonly string MRClassNameKey;

		static vtkCheckerboardWidget()
		{
			vtkCheckerboardWidget.MRClassNameKey = "class vtkCheckerboardWidget";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCheckerboardWidget.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCheckerboardWidget"));
		}

		public vtkCheckerboardWidget(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkCheckerboardWidget_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkCheckerboardWidget New()
		{
			vtkCheckerboardWidget result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCheckerboardWidget.vtkCheckerboardWidget_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCheckerboardWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkCheckerboardWidget() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkCheckerboardWidget.vtkCheckerboardWidget_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkCheckerboardWidget_CreateDefaultRepresentation_01(HandleRef pThis);

		public override void CreateDefaultRepresentation()
		{
			vtkCheckerboardWidget.vtkCheckerboardWidget_CreateDefaultRepresentation_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkCheckerboardWidget_GetCheckerboardRepresentation_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkCheckerboardRepresentation GetCheckerboardRepresentation()
		{
			vtkCheckerboardRepresentation vtkCheckerboardRepresentation = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCheckerboardWidget.vtkCheckerboardWidget_GetCheckerboardRepresentation_02(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCheckerboardRepresentation = (vtkCheckerboardRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCheckerboardRepresentation.Register(null);
				}
			}
			return vtkCheckerboardRepresentation;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkCheckerboardWidget_IsA_03(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkCheckerboardWidget.vtkCheckerboardWidget_IsA_03(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkCheckerboardWidget_IsTypeOf_04(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkCheckerboardWidget.vtkCheckerboardWidget_IsTypeOf_04(type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkCheckerboardWidget_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkCheckerboardWidget NewInstance()
		{
			vtkCheckerboardWidget result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCheckerboardWidget.vtkCheckerboardWidget_NewInstance_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCheckerboardWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkCheckerboardWidget_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkCheckerboardWidget SafeDownCast(vtkObjectBase o)
		{
			vtkCheckerboardWidget vtkCheckerboardWidget = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCheckerboardWidget.vtkCheckerboardWidget_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCheckerboardWidget = (vtkCheckerboardWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCheckerboardWidget.Register(null);
				}
			}
			return vtkCheckerboardWidget;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkCheckerboardWidget_SetEnabled_08(HandleRef pThis, int arg0);

		public override void SetEnabled(int arg0)
		{
			vtkCheckerboardWidget.vtkCheckerboardWidget_SetEnabled_08(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkCheckerboardWidget_SetRepresentation_09(HandleRef pThis, HandleRef r);

		public void SetRepresentation(vtkCheckerboardRepresentation r)
		{
			vtkCheckerboardWidget.vtkCheckerboardWidget_SetRepresentation_09(base.GetCppThis(), (r == null) ? default(HandleRef) : r.GetCppThis());
		}
	}
}
