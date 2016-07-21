using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkOrientationMarkerWidget : vtkInteractorObserver
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkOrientationMarkerWidget";

		public new static readonly string MRClassNameKey;

		static vtkOrientationMarkerWidget()
		{
			vtkOrientationMarkerWidget.MRClassNameKey = "class vtkOrientationMarkerWidget";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkOrientationMarkerWidget.MRClassNameKey, Type.GetType("Kitware.VTK.vtkOrientationMarkerWidget"));
		}

		public vtkOrientationMarkerWidget(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkOrientationMarkerWidget_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkOrientationMarkerWidget New()
		{
			vtkOrientationMarkerWidget result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkOrientationMarkerWidget.vtkOrientationMarkerWidget_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOrientationMarkerWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkOrientationMarkerWidget() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkOrientationMarkerWidget.vtkOrientationMarkerWidget_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkOrientationMarkerWidget_ExecuteCameraUpdateEvent_01(HandleRef pThis, HandleRef o, uint arg1, IntPtr calldata);

		public void ExecuteCameraUpdateEvent(vtkObject o, uint arg1, IntPtr calldata)
		{
			vtkOrientationMarkerWidget.vtkOrientationMarkerWidget_ExecuteCameraUpdateEvent_01(base.GetCppThis(), (o == null) ? default(HandleRef) : o.GetCppThis(), arg1, calldata);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkOrientationMarkerWidget_GetInteractive_02(HandleRef pThis);

		public virtual int GetInteractive()
		{
			return vtkOrientationMarkerWidget.vtkOrientationMarkerWidget_GetInteractive_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkOrientationMarkerWidget_GetOrientationMarker_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkProp GetOrientationMarker()
		{
			vtkProp vtkProp = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkOrientationMarkerWidget.vtkOrientationMarkerWidget_GetOrientationMarker_03(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProp = (vtkProp)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProp.Register(null);
				}
			}
			return vtkProp;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkOrientationMarkerWidget_GetOutlineColor_04(HandleRef pThis);

		public IntPtr GetOutlineColor()
		{
			return vtkOrientationMarkerWidget.vtkOrientationMarkerWidget_GetOutlineColor_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkOrientationMarkerWidget_GetTolerance_05(HandleRef pThis);

		public virtual int GetTolerance()
		{
			return vtkOrientationMarkerWidget.vtkOrientationMarkerWidget_GetTolerance_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkOrientationMarkerWidget_GetToleranceMaxValue_06(HandleRef pThis);

		public virtual int GetToleranceMaxValue()
		{
			return vtkOrientationMarkerWidget.vtkOrientationMarkerWidget_GetToleranceMaxValue_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkOrientationMarkerWidget_GetToleranceMinValue_07(HandleRef pThis);

		public virtual int GetToleranceMinValue()
		{
			return vtkOrientationMarkerWidget.vtkOrientationMarkerWidget_GetToleranceMinValue_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkOrientationMarkerWidget_GetViewport_08(HandleRef pThis);

		public IntPtr GetViewport()
		{
			return vtkOrientationMarkerWidget.vtkOrientationMarkerWidget_GetViewport_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkOrientationMarkerWidget_InteractiveOff_09(HandleRef pThis);

		public virtual void InteractiveOff()
		{
			vtkOrientationMarkerWidget.vtkOrientationMarkerWidget_InteractiveOff_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkOrientationMarkerWidget_InteractiveOn_10(HandleRef pThis);

		public virtual void InteractiveOn()
		{
			vtkOrientationMarkerWidget.vtkOrientationMarkerWidget_InteractiveOn_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkOrientationMarkerWidget_IsA_11(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkOrientationMarkerWidget.vtkOrientationMarkerWidget_IsA_11(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkOrientationMarkerWidget_IsTypeOf_12(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkOrientationMarkerWidget.vtkOrientationMarkerWidget_IsTypeOf_12(type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkOrientationMarkerWidget_NewInstance_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkOrientationMarkerWidget NewInstance()
		{
			vtkOrientationMarkerWidget result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkOrientationMarkerWidget.vtkOrientationMarkerWidget_NewInstance_14(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOrientationMarkerWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkOrientationMarkerWidget_SafeDownCast_15(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkOrientationMarkerWidget SafeDownCast(vtkObjectBase o)
		{
			vtkOrientationMarkerWidget vtkOrientationMarkerWidget = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkOrientationMarkerWidget.vtkOrientationMarkerWidget_SafeDownCast_15((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkOrientationMarkerWidget = (vtkOrientationMarkerWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkOrientationMarkerWidget.Register(null);
				}
			}
			return vtkOrientationMarkerWidget;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkOrientationMarkerWidget_SetEnabled_16(HandleRef pThis, int arg0);

		public override void SetEnabled(int arg0)
		{
			vtkOrientationMarkerWidget.vtkOrientationMarkerWidget_SetEnabled_16(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkOrientationMarkerWidget_SetInteractive_17(HandleRef pThis, int state);

		public void SetInteractive(int state)
		{
			vtkOrientationMarkerWidget.vtkOrientationMarkerWidget_SetInteractive_17(base.GetCppThis(), state);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkOrientationMarkerWidget_SetOrientationMarker_18(HandleRef pThis, HandleRef prop);

		public virtual void SetOrientationMarker(vtkProp prop)
		{
			vtkOrientationMarkerWidget.vtkOrientationMarkerWidget_SetOrientationMarker_18(base.GetCppThis(), (prop == null) ? default(HandleRef) : prop.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkOrientationMarkerWidget_SetOutlineColor_19(HandleRef pThis, double r, double g, double b);

		public void SetOutlineColor(double r, double g, double b)
		{
			vtkOrientationMarkerWidget.vtkOrientationMarkerWidget_SetOutlineColor_19(base.GetCppThis(), r, g, b);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkOrientationMarkerWidget_SetTolerance_20(HandleRef pThis, int _arg);

		public virtual void SetTolerance(int _arg)
		{
			vtkOrientationMarkerWidget.vtkOrientationMarkerWidget_SetTolerance_20(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkOrientationMarkerWidget_SetViewport_21(HandleRef pThis, double minX, double minY, double maxX, double maxY);

		public void SetViewport(double minX, double minY, double maxX, double maxY)
		{
			vtkOrientationMarkerWidget.vtkOrientationMarkerWidget_SetViewport_21(base.GetCppThis(), minX, minY, maxX, maxY);
		}
	}
}
