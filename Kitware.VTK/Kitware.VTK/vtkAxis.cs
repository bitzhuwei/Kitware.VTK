using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkAxis : vtkContextItem
	{
		public enum BOTTOM_WrapperEnum
		{
			BOTTOM = 1,
			LEFT = 0,
			PARALLEL = 4,
			RIGHT = 2,
			TOP
		}

		public enum MIXED_WrapperEnum
		{
			MIXED = 2,
			SCIENTIFIC = 1,
			STANDARD = 0
		}

		public enum AUTO_WrapperEnum
		{
			AUTO,
			CUSTOM = 2,
			FIXED = 1
		}

		public new const string MRFullTypeName = "Kitware.VTK.vtkAxis";

		public new static readonly string MRClassNameKey;

		static vtkAxis()
		{
			vtkAxis.MRClassNameKey = "class vtkAxis";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkAxis.MRClassNameKey, Type.GetType("Kitware.VTK.vtkAxis"));
		}

		public vtkAxis(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern IntPtr vtkAxis_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkAxis New()
		{
			vtkAxis result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAxis.vtkAxis_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAxis)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkAxis() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkAxis.vtkAxis_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkAxis_AutoScale_01(HandleRef pThis);

		public virtual void AutoScale()
		{
			vtkAxis.vtkAxis_AutoScale_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern int vtkAxis_GetBehavior_02(HandleRef pThis);

		public virtual int GetBehavior()
		{
			return vtkAxis.vtkAxis_GetBehavior_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern IntPtr vtkAxis_GetGridPen_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkPen GetGridPen()
		{
			vtkPen vtkPen = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAxis.vtkAxis_GetGridPen_03(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPen = (vtkPen)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPen.Register(null);
				}
			}
			return vtkPen;
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern byte vtkAxis_GetGridVisible_04(HandleRef pThis);

		public virtual bool GetGridVisible()
		{
			return vtkAxis.vtkAxis_GetGridVisible_04(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern IntPtr vtkAxis_GetLabelProperties_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkTextProperty GetLabelProperties()
		{
			vtkTextProperty vtkTextProperty = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAxis.vtkAxis_GetLabelProperties_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTextProperty = (vtkTextProperty)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTextProperty.Register(null);
				}
			}
			return vtkTextProperty;
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern byte vtkAxis_GetLabelsVisible_06(HandleRef pThis);

		public virtual bool GetLabelsVisible()
		{
			return vtkAxis.vtkAxis_GetLabelsVisible_06(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern byte vtkAxis_GetLogScale_07(HandleRef pThis);

		public virtual bool GetLogScale()
		{
			return vtkAxis.vtkAxis_GetLogScale_07(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern double vtkAxis_GetMaximum_08(HandleRef pThis);

		public virtual double GetMaximum()
		{
			return vtkAxis.vtkAxis_GetMaximum_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern double vtkAxis_GetMaximumLimit_09(HandleRef pThis);

		public virtual double GetMaximumLimit()
		{
			return vtkAxis.vtkAxis_GetMaximumLimit_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern double vtkAxis_GetMinimum_10(HandleRef pThis);

		public virtual double GetMinimum()
		{
			return vtkAxis.vtkAxis_GetMinimum_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern double vtkAxis_GetMinimumLimit_11(HandleRef pThis);

		public virtual double GetMinimumLimit()
		{
			return vtkAxis.vtkAxis_GetMinimumLimit_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern int vtkAxis_GetNotation_12(HandleRef pThis);

		public virtual int GetNotation()
		{
			return vtkAxis.vtkAxis_GetNotation_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern int vtkAxis_GetNumberOfTicks_13(HandleRef pThis);

		public virtual int GetNumberOfTicks()
		{
			return vtkAxis.vtkAxis_GetNumberOfTicks_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern IntPtr vtkAxis_GetPen_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkPen GetPen()
		{
			vtkPen vtkPen = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAxis.vtkAxis_GetPen_14(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPen = (vtkPen)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPen.Register(null);
				}
			}
			return vtkPen;
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern IntPtr vtkAxis_GetPoint1_15(HandleRef pThis);

		public virtual float[] GetPoint1()
		{
			IntPtr intPtr = vtkAxis.vtkAxis_GetPoint1_15(base.GetCppThis());
			float[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new float[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkAxis_GetPoint1_16(HandleRef pThis, ref float _arg1, ref float _arg2);

		public virtual void GetPoint1(ref float _arg1, ref float _arg2)
		{
			vtkAxis.vtkAxis_GetPoint1_16(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkAxis_GetPoint1_17(HandleRef pThis, IntPtr _arg);

		public virtual void GetPoint1(IntPtr _arg)
		{
			vtkAxis.vtkAxis_GetPoint1_17(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern IntPtr vtkAxis_GetPoint2_18(HandleRef pThis);

		public virtual float[] GetPoint2()
		{
			IntPtr intPtr = vtkAxis.vtkAxis_GetPoint2_18(base.GetCppThis());
			float[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new float[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkAxis_GetPoint2_19(HandleRef pThis, ref float _arg1, ref float _arg2);

		public virtual void GetPoint2(ref float _arg1, ref float _arg2)
		{
			vtkAxis.vtkAxis_GetPoint2_19(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkAxis_GetPoint2_20(HandleRef pThis, IntPtr _arg);

		public virtual void GetPoint2(IntPtr _arg)
		{
			vtkAxis.vtkAxis_GetPoint2_20(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern int vtkAxis_GetPosition_21(HandleRef pThis);

		public virtual int GetPosition()
		{
			return vtkAxis.vtkAxis_GetPosition_21(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern int vtkAxis_GetPrecision_22(HandleRef pThis);

		public virtual int GetPrecision()
		{
			return vtkAxis.vtkAxis_GetPrecision_22(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern IntPtr vtkAxis_GetTickLabels_23(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkStringArray GetTickLabels()
		{
			vtkStringArray vtkStringArray = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAxis.vtkAxis_GetTickLabels_23(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkStringArray = (vtkStringArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkStringArray.Register(null);
				}
			}
			return vtkStringArray;
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern IntPtr vtkAxis_GetTickPositions_24(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkDoubleArray GetTickPositions()
		{
			vtkDoubleArray vtkDoubleArray = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAxis.vtkAxis_GetTickPositions_24(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDoubleArray = (vtkDoubleArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDoubleArray.Register(null);
				}
			}
			return vtkDoubleArray;
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern IntPtr vtkAxis_GetTickScenePositions_25(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkFloatArray GetTickScenePositions()
		{
			vtkFloatArray vtkFloatArray = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAxis.vtkAxis_GetTickScenePositions_25(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkFloatArray = (vtkFloatArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkFloatArray.Register(null);
				}
			}
			return vtkFloatArray;
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern IntPtr vtkAxis_GetTitleProperties_26(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkTextProperty GetTitleProperties()
		{
			vtkTextProperty vtkTextProperty = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAxis.vtkAxis_GetTitleProperties_26(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTextProperty = (vtkTextProperty)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTextProperty.Register(null);
				}
			}
			return vtkTextProperty;
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern int vtkAxis_IsA_27(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkAxis.vtkAxis_IsA_27(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern int vtkAxis_IsTypeOf_28(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkAxis.vtkAxis_IsTypeOf_28(type);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern IntPtr vtkAxis_NewInstance_30(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkAxis NewInstance()
		{
			vtkAxis result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAxis.vtkAxis_NewInstance_30(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAxis)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern byte vtkAxis_Paint_31(HandleRef pThis, HandleRef painter);

		public override bool Paint(vtkContext2D painter)
		{
			return vtkAxis.vtkAxis_Paint_31(base.GetCppThis(), (painter == null) ? default(HandleRef) : painter.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkAxis_RecalculateTickSpacing_32(HandleRef pThis);

		public virtual void RecalculateTickSpacing()
		{
			vtkAxis.vtkAxis_RecalculateTickSpacing_32(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern IntPtr vtkAxis_SafeDownCast_33(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkAxis SafeDownCast(vtkObjectBase o)
		{
			vtkAxis vtkAxis = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAxis.vtkAxis_SafeDownCast_33((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAxis = (vtkAxis)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAxis.Register(null);
				}
			}
			return vtkAxis;
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkAxis_SetBehavior_34(HandleRef pThis, int _arg);

		public virtual void SetBehavior(int _arg)
		{
			vtkAxis.vtkAxis_SetBehavior_34(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkAxis_SetGridVisible_35(HandleRef pThis, byte _arg);

		public virtual void SetGridVisible(bool _arg)
		{
			vtkAxis.vtkAxis_SetGridVisible_35(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkAxis_SetLabelsVisible_36(HandleRef pThis, byte _arg);

		public virtual void SetLabelsVisible(bool _arg)
		{
			vtkAxis.vtkAxis_SetLabelsVisible_36(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkAxis_SetLogScale_37(HandleRef pThis, byte _arg);

		public virtual void SetLogScale(bool _arg)
		{
			vtkAxis.vtkAxis_SetLogScale_37(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkAxis_SetMaximum_38(HandleRef pThis, double maximum);

		public virtual void SetMaximum(double maximum)
		{
			vtkAxis.vtkAxis_SetMaximum_38(base.GetCppThis(), maximum);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkAxis_SetMaximumLimit_39(HandleRef pThis, double highest);

		public virtual void SetMaximumLimit(double highest)
		{
			vtkAxis.vtkAxis_SetMaximumLimit_39(base.GetCppThis(), highest);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkAxis_SetMinimum_40(HandleRef pThis, double minimum);

		public virtual void SetMinimum(double minimum)
		{
			vtkAxis.vtkAxis_SetMinimum_40(base.GetCppThis(), minimum);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkAxis_SetMinimumLimit_41(HandleRef pThis, double lowest);

		public virtual void SetMinimumLimit(double lowest)
		{
			vtkAxis.vtkAxis_SetMinimumLimit_41(base.GetCppThis(), lowest);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkAxis_SetNotation_42(HandleRef pThis, int notation);

		public virtual void SetNotation(int notation)
		{
			vtkAxis.vtkAxis_SetNotation_42(base.GetCppThis(), notation);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkAxis_SetNumberOfTicks_43(HandleRef pThis, int _arg);

		public virtual void SetNumberOfTicks(int _arg)
		{
			vtkAxis.vtkAxis_SetNumberOfTicks_43(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkAxis_SetPoint1_44(HandleRef pThis, float x, float y);

		public void SetPoint1(float x, float y)
		{
			vtkAxis.vtkAxis_SetPoint1_44(base.GetCppThis(), x, y);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkAxis_SetPoint2_45(HandleRef pThis, float x, float y);

		public void SetPoint2(float x, float y)
		{
			vtkAxis.vtkAxis_SetPoint2_45(base.GetCppThis(), x, y);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkAxis_SetPosition_46(HandleRef pThis, int position);

		public virtual void SetPosition(int position)
		{
			vtkAxis.vtkAxis_SetPosition_46(base.GetCppThis(), position);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkAxis_SetPrecision_47(HandleRef pThis, int precision);

		public virtual void SetPrecision(int precision)
		{
			vtkAxis.vtkAxis_SetPrecision_47(base.GetCppThis(), precision);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkAxis_SetRange_48(HandleRef pThis, double minimum, double maximum);

		public virtual void SetRange(double minimum, double maximum)
		{
			vtkAxis.vtkAxis_SetRange_48(base.GetCppThis(), minimum, maximum);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkAxis_SetTickLabels_49(HandleRef pThis, HandleRef labels);

		public virtual void SetTickLabels(vtkStringArray labels)
		{
			vtkAxis.vtkAxis_SetTickLabels_49(base.GetCppThis(), (labels == null) ? default(HandleRef) : labels.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkAxis_SetTickPositions_50(HandleRef pThis, HandleRef positions);

		public virtual void SetTickPositions(vtkDoubleArray positions)
		{
			vtkAxis.vtkAxis_SetTickPositions_50(base.GetCppThis(), (positions == null) ? default(HandleRef) : positions.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkAxis_Update_51(HandleRef pThis);

		public override void Update()
		{
			vtkAxis.vtkAxis_Update_51(base.GetCppThis());
		}
	}
}
