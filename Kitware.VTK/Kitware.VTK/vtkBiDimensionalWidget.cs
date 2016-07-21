using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkBiDimensionalWidget : vtkAbstractWidget
	{
		public enum EndWidgetSelectEvent_WrapperEnum
		{
			EndWidgetSelectEvent = 10050
		}

		public enum Define_WrapperEnum
		{
			Define = 1,
			Manipulate,
			Start = 0
		}

		public new const string MRFullTypeName = "Kitware.VTK.vtkBiDimensionalWidget";

		public new static readonly string MRClassNameKey;

		static vtkBiDimensionalWidget()
		{
			vtkBiDimensionalWidget.MRClassNameKey = "class vtkBiDimensionalWidget";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkBiDimensionalWidget.MRClassNameKey, Type.GetType("Kitware.VTK.vtkBiDimensionalWidget"));
		}

		public vtkBiDimensionalWidget(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkBiDimensionalWidget_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkBiDimensionalWidget New()
		{
			vtkBiDimensionalWidget result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkBiDimensionalWidget.vtkBiDimensionalWidget_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkBiDimensionalWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkBiDimensionalWidget() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkBiDimensionalWidget.vtkBiDimensionalWidget_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBiDimensionalWidget_CreateDefaultRepresentation_01(HandleRef pThis);

		public override void CreateDefaultRepresentation()
		{
			vtkBiDimensionalWidget.vtkBiDimensionalWidget_CreateDefaultRepresentation_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkBiDimensionalWidget_GetBiDimensionalRepresentation_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkBiDimensionalRepresentation GetBiDimensionalRepresentation()
		{
			vtkBiDimensionalRepresentation vtkBiDimensionalRepresentation = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkBiDimensionalWidget.vtkBiDimensionalWidget_GetBiDimensionalRepresentation_02(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkBiDimensionalRepresentation = (vtkBiDimensionalRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkBiDimensionalRepresentation.Register(null);
				}
			}
			return vtkBiDimensionalRepresentation;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkBiDimensionalWidget_GetWidgetState_03(HandleRef pThis);

		public virtual int GetWidgetState()
		{
			return vtkBiDimensionalWidget.vtkBiDimensionalWidget_GetWidgetState_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkBiDimensionalWidget_IsA_04(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkBiDimensionalWidget.vtkBiDimensionalWidget_IsA_04(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkBiDimensionalWidget_IsMeasureValid_05(HandleRef pThis);

		public int IsMeasureValid()
		{
			return vtkBiDimensionalWidget.vtkBiDimensionalWidget_IsMeasureValid_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkBiDimensionalWidget_IsTypeOf_06(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkBiDimensionalWidget.vtkBiDimensionalWidget_IsTypeOf_06(type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkBiDimensionalWidget_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkBiDimensionalWidget NewInstance()
		{
			vtkBiDimensionalWidget result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkBiDimensionalWidget.vtkBiDimensionalWidget_NewInstance_08(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkBiDimensionalWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkBiDimensionalWidget_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkBiDimensionalWidget SafeDownCast(vtkObjectBase o)
		{
			vtkBiDimensionalWidget vtkBiDimensionalWidget = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkBiDimensionalWidget.vtkBiDimensionalWidget_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkBiDimensionalWidget = (vtkBiDimensionalWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkBiDimensionalWidget.Register(null);
				}
			}
			return vtkBiDimensionalWidget;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBiDimensionalWidget_SetEnabled_10(HandleRef pThis, int arg0);

		public override void SetEnabled(int arg0)
		{
			vtkBiDimensionalWidget.vtkBiDimensionalWidget_SetEnabled_10(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBiDimensionalWidget_SetProcessEvents_11(HandleRef pThis, int arg0);

		public override void SetProcessEvents(int arg0)
		{
			vtkBiDimensionalWidget.vtkBiDimensionalWidget_SetProcessEvents_11(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBiDimensionalWidget_SetRepresentation_12(HandleRef pThis, HandleRef r);

		public void SetRepresentation(vtkBiDimensionalRepresentation r)
		{
			vtkBiDimensionalWidget.vtkBiDimensionalWidget_SetRepresentation_12(base.GetCppThis(), (r == null) ? default(HandleRef) : r.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBiDimensionalWidget_SetWidgetStateToManipulate_13(HandleRef pThis);

		public virtual void SetWidgetStateToManipulate()
		{
			vtkBiDimensionalWidget.vtkBiDimensionalWidget_SetWidgetStateToManipulate_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBiDimensionalWidget_SetWidgetStateToStart_14(HandleRef pThis);

		public virtual void SetWidgetStateToStart()
		{
			vtkBiDimensionalWidget.vtkBiDimensionalWidget_SetWidgetStateToStart_14(base.GetCppThis());
		}
	}
}
