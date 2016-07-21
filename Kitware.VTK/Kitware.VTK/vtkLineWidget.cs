using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkLineWidget : vtk3DWidget
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkLineWidget";

		public new static readonly string MRClassNameKey;

		static vtkLineWidget()
		{
			vtkLineWidget.MRClassNameKey = "class vtkLineWidget";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkLineWidget.MRClassNameKey, Type.GetType("Kitware.VTK.vtkLineWidget"));
		}

		public vtkLineWidget(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkLineWidget_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkLineWidget New()
		{
			vtkLineWidget result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkLineWidget.vtkLineWidget_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLineWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkLineWidget() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkLineWidget.vtkLineWidget_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkLineWidget_ClampToBoundsOff_01(HandleRef pThis);

		public virtual void ClampToBoundsOff()
		{
			vtkLineWidget.vtkLineWidget_ClampToBoundsOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkLineWidget_ClampToBoundsOn_02(HandleRef pThis);

		public virtual void ClampToBoundsOn()
		{
			vtkLineWidget.vtkLineWidget_ClampToBoundsOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkLineWidget_GetAlign_03(HandleRef pThis);

		public virtual int GetAlign()
		{
			return vtkLineWidget.vtkLineWidget_GetAlign_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkLineWidget_GetAlignMaxValue_04(HandleRef pThis);

		public virtual int GetAlignMaxValue()
		{
			return vtkLineWidget.vtkLineWidget_GetAlignMaxValue_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkLineWidget_GetAlignMinValue_05(HandleRef pThis);

		public virtual int GetAlignMinValue()
		{
			return vtkLineWidget.vtkLineWidget_GetAlignMinValue_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkLineWidget_GetClampToBounds_06(HandleRef pThis);

		public virtual int GetClampToBounds()
		{
			return vtkLineWidget.vtkLineWidget_GetClampToBounds_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkLineWidget_GetHandleProperty_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkProperty GetHandleProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkLineWidget.vtkLineWidget_GetHandleProperty_07(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern IntPtr vtkLineWidget_GetLineProperty_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkProperty GetLineProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkLineWidget.vtkLineWidget_GetLineProperty_08(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern IntPtr vtkLineWidget_GetPoint1_09(HandleRef pThis);

		public double[] GetPoint1()
		{
			IntPtr intPtr = vtkLineWidget.vtkLineWidget_GetPoint1_09(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkLineWidget_GetPoint1_10(HandleRef pThis, IntPtr xyz);

		public void GetPoint1(IntPtr xyz)
		{
			vtkLineWidget.vtkLineWidget_GetPoint1_10(base.GetCppThis(), xyz);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkLineWidget_GetPoint2_11(HandleRef pThis);

		public double[] GetPoint2()
		{
			IntPtr intPtr = vtkLineWidget.vtkLineWidget_GetPoint2_11(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkLineWidget_GetPoint2_12(HandleRef pThis, IntPtr xyz);

		public void GetPoint2(IntPtr xyz)
		{
			vtkLineWidget.vtkLineWidget_GetPoint2_12(base.GetCppThis(), xyz);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkLineWidget_GetPolyData_13(HandleRef pThis, HandleRef pd);

		public void GetPolyData(vtkPolyData pd)
		{
			vtkLineWidget.vtkLineWidget_GetPolyData_13(base.GetCppThis(), (pd == null) ? default(HandleRef) : pd.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkLineWidget_GetResolution_14(HandleRef pThis);

		public int GetResolution()
		{
			return vtkLineWidget.vtkLineWidget_GetResolution_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkLineWidget_GetSelectedHandleProperty_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkProperty GetSelectedHandleProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkLineWidget.vtkLineWidget_GetSelectedHandleProperty_15(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern IntPtr vtkLineWidget_GetSelectedLineProperty_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkProperty GetSelectedLineProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkLineWidget.vtkLineWidget_GetSelectedLineProperty_16(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern int vtkLineWidget_IsA_17(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkLineWidget.vtkLineWidget_IsA_17(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkLineWidget_IsTypeOf_18(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkLineWidget.vtkLineWidget_IsTypeOf_18(type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkLineWidget_NewInstance_20(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkLineWidget NewInstance()
		{
			vtkLineWidget result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkLineWidget.vtkLineWidget_NewInstance_20(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLineWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkLineWidget_PlaceWidget_21(HandleRef pThis, IntPtr bounds);

		public override void PlaceWidget(IntPtr bounds)
		{
			vtkLineWidget.vtkLineWidget_PlaceWidget_21(base.GetCppThis(), bounds);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkLineWidget_PlaceWidget_22(HandleRef pThis);

		public override void PlaceWidget()
		{
			vtkLineWidget.vtkLineWidget_PlaceWidget_22(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkLineWidget_PlaceWidget_23(HandleRef pThis, double xmin, double xmax, double ymin, double ymax, double zmin, double zmax);

		public override void PlaceWidget(double xmin, double xmax, double ymin, double ymax, double zmin, double zmax)
		{
			vtkLineWidget.vtkLineWidget_PlaceWidget_23(base.GetCppThis(), xmin, xmax, ymin, ymax, zmin, zmax);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkLineWidget_SafeDownCast_24(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkLineWidget SafeDownCast(vtkObjectBase o)
		{
			vtkLineWidget vtkLineWidget = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkLineWidget.vtkLineWidget_SafeDownCast_24((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkLineWidget = (vtkLineWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkLineWidget.Register(null);
				}
			}
			return vtkLineWidget;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkLineWidget_SetAlign_25(HandleRef pThis, int _arg);

		public virtual void SetAlign(int _arg)
		{
			vtkLineWidget.vtkLineWidget_SetAlign_25(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkLineWidget_SetAlignToNone_26(HandleRef pThis);

		public void SetAlignToNone()
		{
			vtkLineWidget.vtkLineWidget_SetAlignToNone_26(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkLineWidget_SetAlignToXAxis_27(HandleRef pThis);

		public void SetAlignToXAxis()
		{
			vtkLineWidget.vtkLineWidget_SetAlignToXAxis_27(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkLineWidget_SetAlignToYAxis_28(HandleRef pThis);

		public void SetAlignToYAxis()
		{
			vtkLineWidget.vtkLineWidget_SetAlignToYAxis_28(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkLineWidget_SetAlignToZAxis_29(HandleRef pThis);

		public void SetAlignToZAxis()
		{
			vtkLineWidget.vtkLineWidget_SetAlignToZAxis_29(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkLineWidget_SetClampToBounds_30(HandleRef pThis, int _arg);

		public virtual void SetClampToBounds(int _arg)
		{
			vtkLineWidget.vtkLineWidget_SetClampToBounds_30(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkLineWidget_SetEnabled_31(HandleRef pThis, int arg0);

		public override void SetEnabled(int arg0)
		{
			vtkLineWidget.vtkLineWidget_SetEnabled_31(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkLineWidget_SetPoint1_32(HandleRef pThis, double x, double y, double z);

		public void SetPoint1(double x, double y, double z)
		{
			vtkLineWidget.vtkLineWidget_SetPoint1_32(base.GetCppThis(), x, y, z);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkLineWidget_SetPoint1_33(HandleRef pThis, IntPtr x);

		public void SetPoint1(IntPtr x)
		{
			vtkLineWidget.vtkLineWidget_SetPoint1_33(base.GetCppThis(), x);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkLineWidget_SetPoint2_34(HandleRef pThis, double x, double y, double z);

		public void SetPoint2(double x, double y, double z)
		{
			vtkLineWidget.vtkLineWidget_SetPoint2_34(base.GetCppThis(), x, y, z);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkLineWidget_SetPoint2_35(HandleRef pThis, IntPtr x);

		public void SetPoint2(IntPtr x)
		{
			vtkLineWidget.vtkLineWidget_SetPoint2_35(base.GetCppThis(), x);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkLineWidget_SetResolution_36(HandleRef pThis, int r);

		public void SetResolution(int r)
		{
			vtkLineWidget.vtkLineWidget_SetResolution_36(base.GetCppThis(), r);
		}
	}
}
