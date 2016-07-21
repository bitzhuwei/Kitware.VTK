using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkPlaneWidget : vtkPolyDataSourceWidget
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkPlaneWidget";

		public new static readonly string MRClassNameKey;

		static vtkPlaneWidget()
		{
			vtkPlaneWidget.MRClassNameKey = "class vtkPlaneWidget";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPlaneWidget.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPlaneWidget"));
		}

		public vtkPlaneWidget(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkPlaneWidget_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPlaneWidget New()
		{
			vtkPlaneWidget result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPlaneWidget.vtkPlaneWidget_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPlaneWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkPlaneWidget() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkPlaneWidget.vtkPlaneWidget_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkPlaneWidget_GetCenter_01(HandleRef pThis);

		public double[] GetCenter()
		{
			IntPtr intPtr = vtkPlaneWidget.vtkPlaneWidget_GetCenter_01(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkPlaneWidget_GetCenter_02(HandleRef pThis, IntPtr xyz);

		public void GetCenter(IntPtr xyz)
		{
			vtkPlaneWidget.vtkPlaneWidget_GetCenter_02(base.GetCppThis(), xyz);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkPlaneWidget_GetHandleProperty_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkProperty GetHandleProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPlaneWidget.vtkPlaneWidget_GetHandleProperty_03(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern IntPtr vtkPlaneWidget_GetNormal_04(HandleRef pThis);

		public double[] GetNormal()
		{
			IntPtr intPtr = vtkPlaneWidget.vtkPlaneWidget_GetNormal_04(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkPlaneWidget_GetNormal_05(HandleRef pThis, IntPtr xyz);

		public void GetNormal(IntPtr xyz)
		{
			vtkPlaneWidget.vtkPlaneWidget_GetNormal_05(base.GetCppThis(), xyz);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkPlaneWidget_GetNormalToXAxis_06(HandleRef pThis);

		public virtual int GetNormalToXAxis()
		{
			return vtkPlaneWidget.vtkPlaneWidget_GetNormalToXAxis_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkPlaneWidget_GetNormalToYAxis_07(HandleRef pThis);

		public virtual int GetNormalToYAxis()
		{
			return vtkPlaneWidget.vtkPlaneWidget_GetNormalToYAxis_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkPlaneWidget_GetNormalToZAxis_08(HandleRef pThis);

		public virtual int GetNormalToZAxis()
		{
			return vtkPlaneWidget.vtkPlaneWidget_GetNormalToZAxis_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkPlaneWidget_GetOrigin_09(HandleRef pThis);

		public double[] GetOrigin()
		{
			IntPtr intPtr = vtkPlaneWidget.vtkPlaneWidget_GetOrigin_09(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkPlaneWidget_GetOrigin_10(HandleRef pThis, IntPtr xyz);

		public void GetOrigin(IntPtr xyz)
		{
			vtkPlaneWidget.vtkPlaneWidget_GetOrigin_10(base.GetCppThis(), xyz);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkPlaneWidget_GetPlane_11(HandleRef pThis, HandleRef plane);

		public void GetPlane(vtkPlane plane)
		{
			vtkPlaneWidget.vtkPlaneWidget_GetPlane_11(base.GetCppThis(), (plane == null) ? default(HandleRef) : plane.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkPlaneWidget_GetPlaneProperty_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkProperty GetPlaneProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPlaneWidget.vtkPlaneWidget_GetPlaneProperty_12(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern IntPtr vtkPlaneWidget_GetPoint1_13(HandleRef pThis);

		public double[] GetPoint1()
		{
			IntPtr intPtr = vtkPlaneWidget.vtkPlaneWidget_GetPoint1_13(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkPlaneWidget_GetPoint1_14(HandleRef pThis, IntPtr xyz);

		public void GetPoint1(IntPtr xyz)
		{
			vtkPlaneWidget.vtkPlaneWidget_GetPoint1_14(base.GetCppThis(), xyz);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkPlaneWidget_GetPoint2_15(HandleRef pThis);

		public double[] GetPoint2()
		{
			IntPtr intPtr = vtkPlaneWidget.vtkPlaneWidget_GetPoint2_15(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkPlaneWidget_GetPoint2_16(HandleRef pThis, IntPtr xyz);

		public void GetPoint2(IntPtr xyz)
		{
			vtkPlaneWidget.vtkPlaneWidget_GetPoint2_16(base.GetCppThis(), xyz);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkPlaneWidget_GetPolyData_17(HandleRef pThis, HandleRef pd);

		public void GetPolyData(vtkPolyData pd)
		{
			vtkPlaneWidget.vtkPlaneWidget_GetPolyData_17(base.GetCppThis(), (pd == null) ? default(HandleRef) : pd.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkPlaneWidget_GetPolyDataAlgorithm_18(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public override vtkPolyDataAlgorithm GetPolyDataAlgorithm()
		{
			vtkPolyDataAlgorithm vtkPolyDataAlgorithm = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPlaneWidget.vtkPlaneWidget_GetPolyDataAlgorithm_18(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPolyDataAlgorithm = (vtkPolyDataAlgorithm)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPolyDataAlgorithm.Register(null);
				}
			}
			return vtkPolyDataAlgorithm;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkPlaneWidget_GetRepresentation_19(HandleRef pThis);

		public virtual int GetRepresentation()
		{
			return vtkPlaneWidget.vtkPlaneWidget_GetRepresentation_19(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkPlaneWidget_GetRepresentationMaxValue_20(HandleRef pThis);

		public virtual int GetRepresentationMaxValue()
		{
			return vtkPlaneWidget.vtkPlaneWidget_GetRepresentationMaxValue_20(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkPlaneWidget_GetRepresentationMinValue_21(HandleRef pThis);

		public virtual int GetRepresentationMinValue()
		{
			return vtkPlaneWidget.vtkPlaneWidget_GetRepresentationMinValue_21(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkPlaneWidget_GetResolution_22(HandleRef pThis);

		public int GetResolution()
		{
			return vtkPlaneWidget.vtkPlaneWidget_GetResolution_22(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkPlaneWidget_GetSelectedHandleProperty_23(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkProperty GetSelectedHandleProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPlaneWidget.vtkPlaneWidget_GetSelectedHandleProperty_23(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern IntPtr vtkPlaneWidget_GetSelectedPlaneProperty_24(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkProperty GetSelectedPlaneProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPlaneWidget.vtkPlaneWidget_GetSelectedPlaneProperty_24(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern int vtkPlaneWidget_IsA_25(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkPlaneWidget.vtkPlaneWidget_IsA_25(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkPlaneWidget_IsTypeOf_26(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkPlaneWidget.vtkPlaneWidget_IsTypeOf_26(type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkPlaneWidget_NewInstance_28(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkPlaneWidget NewInstance()
		{
			vtkPlaneWidget result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPlaneWidget.vtkPlaneWidget_NewInstance_28(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPlaneWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkPlaneWidget_NormalToXAxisOff_29(HandleRef pThis);

		public virtual void NormalToXAxisOff()
		{
			vtkPlaneWidget.vtkPlaneWidget_NormalToXAxisOff_29(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkPlaneWidget_NormalToXAxisOn_30(HandleRef pThis);

		public virtual void NormalToXAxisOn()
		{
			vtkPlaneWidget.vtkPlaneWidget_NormalToXAxisOn_30(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkPlaneWidget_NormalToYAxisOff_31(HandleRef pThis);

		public virtual void NormalToYAxisOff()
		{
			vtkPlaneWidget.vtkPlaneWidget_NormalToYAxisOff_31(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkPlaneWidget_NormalToYAxisOn_32(HandleRef pThis);

		public virtual void NormalToYAxisOn()
		{
			vtkPlaneWidget.vtkPlaneWidget_NormalToYAxisOn_32(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkPlaneWidget_NormalToZAxisOff_33(HandleRef pThis);

		public virtual void NormalToZAxisOff()
		{
			vtkPlaneWidget.vtkPlaneWidget_NormalToZAxisOff_33(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkPlaneWidget_NormalToZAxisOn_34(HandleRef pThis);

		public virtual void NormalToZAxisOn()
		{
			vtkPlaneWidget.vtkPlaneWidget_NormalToZAxisOn_34(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkPlaneWidget_PlaceWidget_35(HandleRef pThis, IntPtr bounds);

		public override void PlaceWidget(IntPtr bounds)
		{
			vtkPlaneWidget.vtkPlaneWidget_PlaceWidget_35(base.GetCppThis(), bounds);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkPlaneWidget_PlaceWidget_36(HandleRef pThis);

		public override void PlaceWidget()
		{
			vtkPlaneWidget.vtkPlaneWidget_PlaceWidget_36(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkPlaneWidget_PlaceWidget_37(HandleRef pThis, double xmin, double xmax, double ymin, double ymax, double zmin, double zmax);

		public override void PlaceWidget(double xmin, double xmax, double ymin, double ymax, double zmin, double zmax)
		{
			vtkPlaneWidget.vtkPlaneWidget_PlaceWidget_37(base.GetCppThis(), xmin, xmax, ymin, ymax, zmin, zmax);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkPlaneWidget_SafeDownCast_38(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPlaneWidget SafeDownCast(vtkObjectBase o)
		{
			vtkPlaneWidget vtkPlaneWidget = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPlaneWidget.vtkPlaneWidget_SafeDownCast_38((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPlaneWidget = (vtkPlaneWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPlaneWidget.Register(null);
				}
			}
			return vtkPlaneWidget;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkPlaneWidget_SetCenter_39(HandleRef pThis, double x, double y, double z);

		public void SetCenter(double x, double y, double z)
		{
			vtkPlaneWidget.vtkPlaneWidget_SetCenter_39(base.GetCppThis(), x, y, z);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkPlaneWidget_SetCenter_40(HandleRef pThis, IntPtr x);

		public void SetCenter(IntPtr x)
		{
			vtkPlaneWidget.vtkPlaneWidget_SetCenter_40(base.GetCppThis(), x);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkPlaneWidget_SetEnabled_41(HandleRef pThis, int arg0);

		public override void SetEnabled(int arg0)
		{
			vtkPlaneWidget.vtkPlaneWidget_SetEnabled_41(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkPlaneWidget_SetNormal_42(HandleRef pThis, double x, double y, double z);

		public void SetNormal(double x, double y, double z)
		{
			vtkPlaneWidget.vtkPlaneWidget_SetNormal_42(base.GetCppThis(), x, y, z);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkPlaneWidget_SetNormal_43(HandleRef pThis, IntPtr x);

		public void SetNormal(IntPtr x)
		{
			vtkPlaneWidget.vtkPlaneWidget_SetNormal_43(base.GetCppThis(), x);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkPlaneWidget_SetNormalToXAxis_44(HandleRef pThis, int _arg);

		public virtual void SetNormalToXAxis(int _arg)
		{
			vtkPlaneWidget.vtkPlaneWidget_SetNormalToXAxis_44(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkPlaneWidget_SetNormalToYAxis_45(HandleRef pThis, int _arg);

		public virtual void SetNormalToYAxis(int _arg)
		{
			vtkPlaneWidget.vtkPlaneWidget_SetNormalToYAxis_45(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkPlaneWidget_SetNormalToZAxis_46(HandleRef pThis, int _arg);

		public virtual void SetNormalToZAxis(int _arg)
		{
			vtkPlaneWidget.vtkPlaneWidget_SetNormalToZAxis_46(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkPlaneWidget_SetOrigin_47(HandleRef pThis, double x, double y, double z);

		public void SetOrigin(double x, double y, double z)
		{
			vtkPlaneWidget.vtkPlaneWidget_SetOrigin_47(base.GetCppThis(), x, y, z);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkPlaneWidget_SetOrigin_48(HandleRef pThis, IntPtr x);

		public void SetOrigin(IntPtr x)
		{
			vtkPlaneWidget.vtkPlaneWidget_SetOrigin_48(base.GetCppThis(), x);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkPlaneWidget_SetPlaneProperty_49(HandleRef pThis, HandleRef arg0);

		public virtual void SetPlaneProperty(vtkProperty arg0)
		{
			vtkPlaneWidget.vtkPlaneWidget_SetPlaneProperty_49(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkPlaneWidget_SetPoint1_50(HandleRef pThis, double x, double y, double z);

		public void SetPoint1(double x, double y, double z)
		{
			vtkPlaneWidget.vtkPlaneWidget_SetPoint1_50(base.GetCppThis(), x, y, z);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkPlaneWidget_SetPoint1_51(HandleRef pThis, IntPtr x);

		public void SetPoint1(IntPtr x)
		{
			vtkPlaneWidget.vtkPlaneWidget_SetPoint1_51(base.GetCppThis(), x);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkPlaneWidget_SetPoint2_52(HandleRef pThis, double x, double y, double z);

		public void SetPoint2(double x, double y, double z)
		{
			vtkPlaneWidget.vtkPlaneWidget_SetPoint2_52(base.GetCppThis(), x, y, z);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkPlaneWidget_SetPoint2_53(HandleRef pThis, IntPtr x);

		public void SetPoint2(IntPtr x)
		{
			vtkPlaneWidget.vtkPlaneWidget_SetPoint2_53(base.GetCppThis(), x);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkPlaneWidget_SetRepresentation_54(HandleRef pThis, int _arg);

		public virtual void SetRepresentation(int _arg)
		{
			vtkPlaneWidget.vtkPlaneWidget_SetRepresentation_54(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkPlaneWidget_SetRepresentationToOff_55(HandleRef pThis);

		public void SetRepresentationToOff()
		{
			vtkPlaneWidget.vtkPlaneWidget_SetRepresentationToOff_55(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkPlaneWidget_SetRepresentationToOutline_56(HandleRef pThis);

		public void SetRepresentationToOutline()
		{
			vtkPlaneWidget.vtkPlaneWidget_SetRepresentationToOutline_56(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkPlaneWidget_SetRepresentationToSurface_57(HandleRef pThis);

		public void SetRepresentationToSurface()
		{
			vtkPlaneWidget.vtkPlaneWidget_SetRepresentationToSurface_57(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkPlaneWidget_SetRepresentationToWireframe_58(HandleRef pThis);

		public void SetRepresentationToWireframe()
		{
			vtkPlaneWidget.vtkPlaneWidget_SetRepresentationToWireframe_58(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkPlaneWidget_SetResolution_59(HandleRef pThis, int r);

		public void SetResolution(int r)
		{
			vtkPlaneWidget.vtkPlaneWidget_SetResolution_59(base.GetCppThis(), r);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkPlaneWidget_UpdatePlacement_60(HandleRef pThis);

		public override void UpdatePlacement()
		{
			vtkPlaneWidget.vtkPlaneWidget_UpdatePlacement_60(base.GetCppThis());
		}
	}
}
