using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkSphereWidget : vtk3DWidget
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkSphereWidget";

		public new static readonly string MRClassNameKey;

		static vtkSphereWidget()
		{
			vtkSphereWidget.MRClassNameKey = "class vtkSphereWidget";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSphereWidget.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSphereWidget"));
		}

		public vtkSphereWidget(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkSphereWidget_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkSphereWidget New()
		{
			vtkSphereWidget result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSphereWidget.vtkSphereWidget_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSphereWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkSphereWidget() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkSphereWidget.vtkSphereWidget_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkSphereWidget_GetCenter_01(HandleRef pThis);

		public double[] GetCenter()
		{
			IntPtr intPtr = vtkSphereWidget.vtkSphereWidget_GetCenter_01(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSphereWidget_GetCenter_02(HandleRef pThis, IntPtr xyz);

		public void GetCenter(IntPtr xyz)
		{
			vtkSphereWidget.vtkSphereWidget_GetCenter_02(base.GetCppThis(), xyz);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkSphereWidget_GetHandleDirection_03(HandleRef pThis);

		public virtual double[] GetHandleDirection()
		{
			IntPtr intPtr = vtkSphereWidget.vtkSphereWidget_GetHandleDirection_03(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSphereWidget_GetHandleDirection_04(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		public virtual void GetHandleDirection(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkSphereWidget.vtkSphereWidget_GetHandleDirection_04(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSphereWidget_GetHandleDirection_05(HandleRef pThis, IntPtr _arg);

		public virtual void GetHandleDirection(IntPtr _arg)
		{
			vtkSphereWidget.vtkSphereWidget_GetHandleDirection_05(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkSphereWidget_GetHandlePosition_06(HandleRef pThis);

		public virtual double[] GetHandlePosition()
		{
			IntPtr intPtr = vtkSphereWidget.vtkSphereWidget_GetHandlePosition_06(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSphereWidget_GetHandlePosition_07(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		public virtual void GetHandlePosition(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkSphereWidget.vtkSphereWidget_GetHandlePosition_07(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSphereWidget_GetHandlePosition_08(HandleRef pThis, IntPtr _arg);

		public virtual void GetHandlePosition(IntPtr _arg)
		{
			vtkSphereWidget.vtkSphereWidget_GetHandlePosition_08(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkSphereWidget_GetHandleProperty_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkProperty GetHandleProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSphereWidget.vtkSphereWidget_GetHandleProperty_09(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProperty = (vtkProperty)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProperty.Register(null);
				}
			}
			return vtkProperty;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkSphereWidget_GetHandleVisibility_10(HandleRef pThis);

		public virtual int GetHandleVisibility()
		{
			return vtkSphereWidget.vtkSphereWidget_GetHandleVisibility_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkSphereWidget_GetPhiResolution_11(HandleRef pThis);

		public int GetPhiResolution()
		{
			return vtkSphereWidget.vtkSphereWidget_GetPhiResolution_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSphereWidget_GetPolyData_12(HandleRef pThis, HandleRef pd);

		public void GetPolyData(vtkPolyData pd)
		{
			vtkSphereWidget.vtkSphereWidget_GetPolyData_12(base.GetCppThis(), (pd == null) ? default(HandleRef) : pd.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern double vtkSphereWidget_GetRadius_13(HandleRef pThis);

		public double GetRadius()
		{
			return vtkSphereWidget.vtkSphereWidget_GetRadius_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkSphereWidget_GetRepresentation_14(HandleRef pThis);

		public virtual int GetRepresentation()
		{
			return vtkSphereWidget.vtkSphereWidget_GetRepresentation_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkSphereWidget_GetRepresentationMaxValue_15(HandleRef pThis);

		public virtual int GetRepresentationMaxValue()
		{
			return vtkSphereWidget.vtkSphereWidget_GetRepresentationMaxValue_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkSphereWidget_GetRepresentationMinValue_16(HandleRef pThis);

		public virtual int GetRepresentationMinValue()
		{
			return vtkSphereWidget.vtkSphereWidget_GetRepresentationMinValue_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkSphereWidget_GetScale_17(HandleRef pThis);

		public virtual int GetScale()
		{
			return vtkSphereWidget.vtkSphereWidget_GetScale_17(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkSphereWidget_GetSelectedHandleProperty_18(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkProperty GetSelectedHandleProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSphereWidget.vtkSphereWidget_GetSelectedHandleProperty_18(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProperty = (vtkProperty)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProperty.Register(null);
				}
			}
			return vtkProperty;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkSphereWidget_GetSelectedSphereProperty_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkProperty GetSelectedSphereProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSphereWidget.vtkSphereWidget_GetSelectedSphereProperty_19(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProperty = (vtkProperty)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProperty.Register(null);
				}
			}
			return vtkProperty;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSphereWidget_GetSphere_20(HandleRef pThis, HandleRef sphere);

		public void GetSphere(vtkSphere sphere)
		{
			vtkSphereWidget.vtkSphereWidget_GetSphere_20(base.GetCppThis(), (sphere == null) ? default(HandleRef) : sphere.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkSphereWidget_GetSphereProperty_21(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkProperty GetSphereProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSphereWidget.vtkSphereWidget_GetSphereProperty_21(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProperty = (vtkProperty)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProperty.Register(null);
				}
			}
			return vtkProperty;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkSphereWidget_GetThetaResolution_22(HandleRef pThis);

		public int GetThetaResolution()
		{
			return vtkSphereWidget.vtkSphereWidget_GetThetaResolution_22(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkSphereWidget_GetTranslation_23(HandleRef pThis);

		public virtual int GetTranslation()
		{
			return vtkSphereWidget.vtkSphereWidget_GetTranslation_23(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSphereWidget_HandleVisibilityOff_24(HandleRef pThis);

		public virtual void HandleVisibilityOff()
		{
			vtkSphereWidget.vtkSphereWidget_HandleVisibilityOff_24(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSphereWidget_HandleVisibilityOn_25(HandleRef pThis);

		public virtual void HandleVisibilityOn()
		{
			vtkSphereWidget.vtkSphereWidget_HandleVisibilityOn_25(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkSphereWidget_IsA_26(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkSphereWidget.vtkSphereWidget_IsA_26(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkSphereWidget_IsTypeOf_27(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkSphereWidget.vtkSphereWidget_IsTypeOf_27(type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkSphereWidget_NewInstance_29(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkSphereWidget NewInstance()
		{
			vtkSphereWidget result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSphereWidget.vtkSphereWidget_NewInstance_29(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSphereWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSphereWidget_PlaceWidget_30(HandleRef pThis, IntPtr bounds);

		public override void PlaceWidget(IntPtr bounds)
		{
			vtkSphereWidget.vtkSphereWidget_PlaceWidget_30(base.GetCppThis(), bounds);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSphereWidget_PlaceWidget_31(HandleRef pThis);

		public override void PlaceWidget()
		{
			vtkSphereWidget.vtkSphereWidget_PlaceWidget_31(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSphereWidget_PlaceWidget_32(HandleRef pThis, double xmin, double xmax, double ymin, double ymax, double zmin, double zmax);

		public override void PlaceWidget(double xmin, double xmax, double ymin, double ymax, double zmin, double zmax)
		{
			vtkSphereWidget.vtkSphereWidget_PlaceWidget_32(base.GetCppThis(), xmin, xmax, ymin, ymax, zmin, zmax);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkSphereWidget_SafeDownCast_33(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkSphereWidget SafeDownCast(vtkObjectBase o)
		{
			vtkSphereWidget vtkSphereWidget = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSphereWidget.vtkSphereWidget_SafeDownCast_33((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSphereWidget = (vtkSphereWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSphereWidget.Register(null);
				}
			}
			return vtkSphereWidget;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSphereWidget_ScaleOff_34(HandleRef pThis);

		public virtual void ScaleOff()
		{
			vtkSphereWidget.vtkSphereWidget_ScaleOff_34(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSphereWidget_ScaleOn_35(HandleRef pThis);

		public virtual void ScaleOn()
		{
			vtkSphereWidget.vtkSphereWidget_ScaleOn_35(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSphereWidget_SetCenter_36(HandleRef pThis, double x, double y, double z);

		public void SetCenter(double x, double y, double z)
		{
			vtkSphereWidget.vtkSphereWidget_SetCenter_36(base.GetCppThis(), x, y, z);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSphereWidget_SetCenter_37(HandleRef pThis, IntPtr x);

		public void SetCenter(IntPtr x)
		{
			vtkSphereWidget.vtkSphereWidget_SetCenter_37(base.GetCppThis(), x);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSphereWidget_SetEnabled_38(HandleRef pThis, int arg0);

		public override void SetEnabled(int arg0)
		{
			vtkSphereWidget.vtkSphereWidget_SetEnabled_38(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSphereWidget_SetHandleDirection_39(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		public virtual void SetHandleDirection(double _arg1, double _arg2, double _arg3)
		{
			vtkSphereWidget.vtkSphereWidget_SetHandleDirection_39(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSphereWidget_SetHandleDirection_40(HandleRef pThis, IntPtr _arg);

		public virtual void SetHandleDirection(IntPtr _arg)
		{
			vtkSphereWidget.vtkSphereWidget_SetHandleDirection_40(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSphereWidget_SetHandleVisibility_41(HandleRef pThis, int _arg);

		public virtual void SetHandleVisibility(int _arg)
		{
			vtkSphereWidget.vtkSphereWidget_SetHandleVisibility_41(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSphereWidget_SetPhiResolution_42(HandleRef pThis, int r);

		public void SetPhiResolution(int r)
		{
			vtkSphereWidget.vtkSphereWidget_SetPhiResolution_42(base.GetCppThis(), r);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSphereWidget_SetRadius_43(HandleRef pThis, double r);

		public void SetRadius(double r)
		{
			vtkSphereWidget.vtkSphereWidget_SetRadius_43(base.GetCppThis(), r);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSphereWidget_SetRepresentation_44(HandleRef pThis, int _arg);

		public virtual void SetRepresentation(int _arg)
		{
			vtkSphereWidget.vtkSphereWidget_SetRepresentation_44(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSphereWidget_SetRepresentationToOff_45(HandleRef pThis);

		public void SetRepresentationToOff()
		{
			vtkSphereWidget.vtkSphereWidget_SetRepresentationToOff_45(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSphereWidget_SetRepresentationToSurface_46(HandleRef pThis);

		public void SetRepresentationToSurface()
		{
			vtkSphereWidget.vtkSphereWidget_SetRepresentationToSurface_46(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSphereWidget_SetRepresentationToWireframe_47(HandleRef pThis);

		public void SetRepresentationToWireframe()
		{
			vtkSphereWidget.vtkSphereWidget_SetRepresentationToWireframe_47(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSphereWidget_SetScale_48(HandleRef pThis, int _arg);

		public virtual void SetScale(int _arg)
		{
			vtkSphereWidget.vtkSphereWidget_SetScale_48(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSphereWidget_SetThetaResolution_49(HandleRef pThis, int r);

		public void SetThetaResolution(int r)
		{
			vtkSphereWidget.vtkSphereWidget_SetThetaResolution_49(base.GetCppThis(), r);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSphereWidget_SetTranslation_50(HandleRef pThis, int _arg);

		public virtual void SetTranslation(int _arg)
		{
			vtkSphereWidget.vtkSphereWidget_SetTranslation_50(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSphereWidget_TranslationOff_51(HandleRef pThis);

		public virtual void TranslationOff()
		{
			vtkSphereWidget.vtkSphereWidget_TranslationOff_51(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSphereWidget_TranslationOn_52(HandleRef pThis);

		public virtual void TranslationOn()
		{
			vtkSphereWidget.vtkSphereWidget_TranslationOn_52(base.GetCppThis());
		}
	}
}
