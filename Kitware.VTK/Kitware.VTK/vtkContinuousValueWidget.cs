using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public abstract class vtkContinuousValueWidget : vtkAbstractWidget
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkContinuousValueWidget";

		public new static readonly string MRClassNameKey;

		static vtkContinuousValueWidget()
		{
			vtkContinuousValueWidget.MRClassNameKey = "class vtkContinuousValueWidget";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkContinuousValueWidget.MRClassNameKey, Type.GetType("Kitware.VTK.vtkContinuousValueWidget"));
		}

		public vtkContinuousValueWidget(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkContinuousValueWidget_GetContinuousValueWidgetRepresentation_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkContinuousValueWidgetRepresentation GetContinuousValueWidgetRepresentation()
		{
			vtkContinuousValueWidgetRepresentation vtkContinuousValueWidgetRepresentation = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkContinuousValueWidget.vtkContinuousValueWidget_GetContinuousValueWidgetRepresentation_01(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkContinuousValueWidgetRepresentation = (vtkContinuousValueWidgetRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkContinuousValueWidgetRepresentation.Register(null);
				}
			}
			return vtkContinuousValueWidgetRepresentation;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern double vtkContinuousValueWidget_GetValue_02(HandleRef pThis);

		public double GetValue()
		{
			return vtkContinuousValueWidget.vtkContinuousValueWidget_GetValue_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkContinuousValueWidget_IsA_03(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkContinuousValueWidget.vtkContinuousValueWidget_IsA_03(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkContinuousValueWidget_IsTypeOf_04(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkContinuousValueWidget.vtkContinuousValueWidget_IsTypeOf_04(type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkContinuousValueWidget_NewInstance_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkContinuousValueWidget NewInstance()
		{
			vtkContinuousValueWidget result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkContinuousValueWidget.vtkContinuousValueWidget_NewInstance_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkContinuousValueWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkContinuousValueWidget_SafeDownCast_06(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkContinuousValueWidget SafeDownCast(vtkObjectBase o)
		{
			vtkContinuousValueWidget vtkContinuousValueWidget = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkContinuousValueWidget.vtkContinuousValueWidget_SafeDownCast_06((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkContinuousValueWidget = (vtkContinuousValueWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkContinuousValueWidget.Register(null);
				}
			}
			return vtkContinuousValueWidget;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkContinuousValueWidget_SetRepresentation_07(HandleRef pThis, HandleRef r);

		public void SetRepresentation(vtkContinuousValueWidgetRepresentation r)
		{
			vtkContinuousValueWidget.vtkContinuousValueWidget_SetRepresentation_07(base.GetCppThis(), (r == null) ? default(HandleRef) : r.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkContinuousValueWidget_SetValue_08(HandleRef pThis, double v);

		public void SetValue(double v)
		{
			vtkContinuousValueWidget.vtkContinuousValueWidget_SetValue_08(base.GetCppThis(), v);
		}
	}
}
