using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public abstract class vtkContinuousValueWidgetRepresentation : vtkWidgetRepresentation
	{
		public enum _InteractionState
		{
			Adjusting = 2,
			Inside = 1,
			Outside = 0
		}

		public new const string MRFullTypeName = "Kitware.VTK.vtkContinuousValueWidgetRepresentation";

		public new static readonly string MRClassNameKey;

		static vtkContinuousValueWidgetRepresentation()
		{
			vtkContinuousValueWidgetRepresentation.MRClassNameKey = "class vtkContinuousValueWidgetRepresentation";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkContinuousValueWidgetRepresentation.MRClassNameKey, Type.GetType("Kitware.VTK.vtkContinuousValueWidgetRepresentation"));
		}

		public vtkContinuousValueWidgetRepresentation(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkContinuousValueWidgetRepresentation_BuildRepresentation_01(HandleRef pThis);

		public override void BuildRepresentation()
		{
			vtkContinuousValueWidgetRepresentation.vtkContinuousValueWidgetRepresentation_BuildRepresentation_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern double vtkContinuousValueWidgetRepresentation_GetValue_02(HandleRef pThis);

		public virtual double GetValue()
		{
			return vtkContinuousValueWidgetRepresentation.vtkContinuousValueWidgetRepresentation_GetValue_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkContinuousValueWidgetRepresentation_IsA_03(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkContinuousValueWidgetRepresentation.vtkContinuousValueWidgetRepresentation_IsA_03(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkContinuousValueWidgetRepresentation_IsTypeOf_04(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkContinuousValueWidgetRepresentation.vtkContinuousValueWidgetRepresentation_IsTypeOf_04(type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkContinuousValueWidgetRepresentation_NewInstance_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkContinuousValueWidgetRepresentation NewInstance()
		{
			vtkContinuousValueWidgetRepresentation result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkContinuousValueWidgetRepresentation.vtkContinuousValueWidgetRepresentation_NewInstance_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkContinuousValueWidgetRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkContinuousValueWidgetRepresentation_PlaceWidget_06(HandleRef pThis, IntPtr bounds);

		public override void PlaceWidget(IntPtr bounds)
		{
			vtkContinuousValueWidgetRepresentation.vtkContinuousValueWidgetRepresentation_PlaceWidget_06(base.GetCppThis(), bounds);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkContinuousValueWidgetRepresentation_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkContinuousValueWidgetRepresentation SafeDownCast(vtkObjectBase o)
		{
			vtkContinuousValueWidgetRepresentation vtkContinuousValueWidgetRepresentation = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkContinuousValueWidgetRepresentation.vtkContinuousValueWidgetRepresentation_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern void vtkContinuousValueWidgetRepresentation_SetValue_08(HandleRef pThis, double value);

		public virtual void SetValue(double value)
		{
			vtkContinuousValueWidgetRepresentation.vtkContinuousValueWidgetRepresentation_SetValue_08(base.GetCppThis(), value);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkContinuousValueWidgetRepresentation_StartWidgetInteraction_09(HandleRef pThis, IntPtr eventPos);

		public override void StartWidgetInteraction(IntPtr eventPos)
		{
			vtkContinuousValueWidgetRepresentation.vtkContinuousValueWidgetRepresentation_StartWidgetInteraction_09(base.GetCppThis(), eventPos);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkContinuousValueWidgetRepresentation_WidgetInteraction_10(HandleRef pThis, IntPtr eventPos);

		public override void WidgetInteraction(IntPtr eventPos)
		{
			vtkContinuousValueWidgetRepresentation.vtkContinuousValueWidgetRepresentation_WidgetInteraction_10(base.GetCppThis(), eventPos);
		}
	}
}
