using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkHandleWidget : vtkAbstractWidget
	{
		public enum _WidgetState
		{
			Active = 1,
			Start = 0
		}

		public new const string MRFullTypeName = "Kitware.VTK.vtkHandleWidget";

		public new static readonly string MRClassNameKey;

		static vtkHandleWidget()
		{
			vtkHandleWidget.MRClassNameKey = "class vtkHandleWidget";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkHandleWidget.MRClassNameKey, Type.GetType("Kitware.VTK.vtkHandleWidget"));
		}

		public vtkHandleWidget(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkHandleWidget_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkHandleWidget New()
		{
			vtkHandleWidget result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkHandleWidget.vtkHandleWidget_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkHandleWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkHandleWidget() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkHandleWidget.vtkHandleWidget_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkHandleWidget_AllowHandleResizeOff_01(HandleRef pThis);

		public virtual void AllowHandleResizeOff()
		{
			vtkHandleWidget.vtkHandleWidget_AllowHandleResizeOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkHandleWidget_AllowHandleResizeOn_02(HandleRef pThis);

		public virtual void AllowHandleResizeOn()
		{
			vtkHandleWidget.vtkHandleWidget_AllowHandleResizeOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkHandleWidget_CreateDefaultRepresentation_03(HandleRef pThis);

		public override void CreateDefaultRepresentation()
		{
			vtkHandleWidget.vtkHandleWidget_CreateDefaultRepresentation_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkHandleWidget_EnableAxisConstraintOff_04(HandleRef pThis);

		public virtual void EnableAxisConstraintOff()
		{
			vtkHandleWidget.vtkHandleWidget_EnableAxisConstraintOff_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkHandleWidget_EnableAxisConstraintOn_05(HandleRef pThis);

		public virtual void EnableAxisConstraintOn()
		{
			vtkHandleWidget.vtkHandleWidget_EnableAxisConstraintOn_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkHandleWidget_GetAllowHandleResize_06(HandleRef pThis);

		public virtual int GetAllowHandleResize()
		{
			return vtkHandleWidget.vtkHandleWidget_GetAllowHandleResize_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkHandleWidget_GetEnableAxisConstraint_07(HandleRef pThis);

		public virtual int GetEnableAxisConstraint()
		{
			return vtkHandleWidget.vtkHandleWidget_GetEnableAxisConstraint_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkHandleWidget_GetHandleRepresentation_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkHandleRepresentation GetHandleRepresentation()
		{
			vtkHandleRepresentation vtkHandleRepresentation = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkHandleWidget.vtkHandleWidget_GetHandleRepresentation_08(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkHandleRepresentation = (vtkHandleRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkHandleRepresentation.Register(null);
				}
			}
			return vtkHandleRepresentation;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkHandleWidget_GetWidgetState_09(HandleRef pThis);

		public virtual int GetWidgetState()
		{
			return vtkHandleWidget.vtkHandleWidget_GetWidgetState_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkHandleWidget_IsA_10(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkHandleWidget.vtkHandleWidget_IsA_10(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkHandleWidget_IsTypeOf_11(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkHandleWidget.vtkHandleWidget_IsTypeOf_11(type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkHandleWidget_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkHandleWidget NewInstance()
		{
			vtkHandleWidget result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkHandleWidget.vtkHandleWidget_NewInstance_13(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkHandleWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkHandleWidget_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkHandleWidget SafeDownCast(vtkObjectBase o)
		{
			vtkHandleWidget vtkHandleWidget = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkHandleWidget.vtkHandleWidget_SafeDownCast_14((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkHandleWidget = (vtkHandleWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkHandleWidget.Register(null);
				}
			}
			return vtkHandleWidget;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkHandleWidget_SetAllowHandleResize_15(HandleRef pThis, int _arg);

		public virtual void SetAllowHandleResize(int _arg)
		{
			vtkHandleWidget.vtkHandleWidget_SetAllowHandleResize_15(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkHandleWidget_SetEnableAxisConstraint_16(HandleRef pThis, int _arg);

		public virtual void SetEnableAxisConstraint(int _arg)
		{
			vtkHandleWidget.vtkHandleWidget_SetEnableAxisConstraint_16(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkHandleWidget_SetRepresentation_17(HandleRef pThis, HandleRef r);

		public void SetRepresentation(vtkHandleRepresentation r)
		{
			vtkHandleWidget.vtkHandleWidget_SetRepresentation_17(base.GetCppThis(), (r == null) ? default(HandleRef) : r.GetCppThis());
		}
	}
}
