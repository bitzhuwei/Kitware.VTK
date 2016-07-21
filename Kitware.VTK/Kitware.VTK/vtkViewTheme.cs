using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkViewTheme : vtkObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkViewTheme";

		public new static readonly string MRClassNameKey;

		static vtkViewTheme()
		{
			vtkViewTheme.MRClassNameKey = "class vtkViewTheme";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkViewTheme.MRClassNameKey, Type.GetType("Kitware.VTK.vtkViewTheme"));
		}

		public vtkViewTheme(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkViewTheme_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkViewTheme New()
		{
			vtkViewTheme result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkViewTheme.vtkViewTheme_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkViewTheme)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkViewTheme() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkViewTheme.vtkViewTheme_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkViewTheme_CreateMellowTheme_01(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public static vtkViewTheme CreateMellowTheme()
		{
			vtkViewTheme vtkViewTheme = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkViewTheme.vtkViewTheme_CreateMellowTheme_01(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkViewTheme = (vtkViewTheme)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkViewTheme.Register(null);
				}
			}
			return vtkViewTheme;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkViewTheme_CreateNeonTheme_02(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public static vtkViewTheme CreateNeonTheme()
		{
			vtkViewTheme vtkViewTheme = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkViewTheme.vtkViewTheme_CreateNeonTheme_02(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkViewTheme = (vtkViewTheme)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkViewTheme.Register(null);
				}
			}
			return vtkViewTheme;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkViewTheme_CreateOceanTheme_03(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public static vtkViewTheme CreateOceanTheme()
		{
			vtkViewTheme vtkViewTheme = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkViewTheme.vtkViewTheme_CreateOceanTheme_03(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkViewTheme = (vtkViewTheme)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkViewTheme.Register(null);
				}
			}
			return vtkViewTheme;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkViewTheme_GetBackgroundColor_04(HandleRef pThis);

		public virtual double[] GetBackgroundColor()
		{
			IntPtr intPtr = vtkViewTheme.vtkViewTheme_GetBackgroundColor_04(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkViewTheme_GetBackgroundColor_05(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		public virtual void GetBackgroundColor(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkViewTheme.vtkViewTheme_GetBackgroundColor_05(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkViewTheme_GetBackgroundColor_06(HandleRef pThis, IntPtr _arg);

		public virtual void GetBackgroundColor(IntPtr _arg)
		{
			vtkViewTheme.vtkViewTheme_GetBackgroundColor_06(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkViewTheme_GetBackgroundColor2_07(HandleRef pThis);

		public virtual double[] GetBackgroundColor2()
		{
			IntPtr intPtr = vtkViewTheme.vtkViewTheme_GetBackgroundColor2_07(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkViewTheme_GetBackgroundColor2_08(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		public virtual void GetBackgroundColor2(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkViewTheme.vtkViewTheme_GetBackgroundColor2_08(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkViewTheme_GetBackgroundColor2_09(HandleRef pThis, IntPtr _arg);

		public virtual void GetBackgroundColor2(IntPtr _arg)
		{
			vtkViewTheme.vtkViewTheme_GetBackgroundColor2_09(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkViewTheme_GetCellAlphaRange_10(HandleRef pThis);

		public virtual IntPtr GetCellAlphaRange()
		{
			return vtkViewTheme.vtkViewTheme_GetCellAlphaRange_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkViewTheme_GetCellAlphaRange_11(HandleRef pThis, ref double mn, ref double mx);

		public virtual void GetCellAlphaRange(ref double mn, ref double mx)
		{
			vtkViewTheme.vtkViewTheme_GetCellAlphaRange_11(base.GetCppThis(), ref mn, ref mx);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkViewTheme_GetCellAlphaRange_12(HandleRef pThis, IntPtr rng);

		public virtual void GetCellAlphaRange(IntPtr rng)
		{
			vtkViewTheme.vtkViewTheme_GetCellAlphaRange_12(base.GetCppThis(), rng);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkViewTheme_GetCellColor_13(HandleRef pThis);

		public virtual double[] GetCellColor()
		{
			IntPtr intPtr = vtkViewTheme.vtkViewTheme_GetCellColor_13(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkViewTheme_GetCellColor_14(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		public virtual void GetCellColor(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkViewTheme.vtkViewTheme_GetCellColor_14(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkViewTheme_GetCellColor_15(HandleRef pThis, IntPtr _arg);

		public virtual void GetCellColor(IntPtr _arg)
		{
			vtkViewTheme.vtkViewTheme_GetCellColor_15(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkViewTheme_GetCellHueRange_16(HandleRef pThis);

		public virtual IntPtr GetCellHueRange()
		{
			return vtkViewTheme.vtkViewTheme_GetCellHueRange_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkViewTheme_GetCellHueRange_17(HandleRef pThis, ref double mn, ref double mx);

		public virtual void GetCellHueRange(ref double mn, ref double mx)
		{
			vtkViewTheme.vtkViewTheme_GetCellHueRange_17(base.GetCppThis(), ref mn, ref mx);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkViewTheme_GetCellHueRange_18(HandleRef pThis, IntPtr rng);

		public virtual void GetCellHueRange(IntPtr rng)
		{
			vtkViewTheme.vtkViewTheme_GetCellHueRange_18(base.GetCppThis(), rng);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkViewTheme_GetCellLookupTable_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkScalarsToColors GetCellLookupTable()
		{
			vtkScalarsToColors vtkScalarsToColors = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkViewTheme.vtkViewTheme_GetCellLookupTable_19(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkScalarsToColors = (vtkScalarsToColors)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkScalarsToColors.Register(null);
				}
			}
			return vtkScalarsToColors;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkViewTheme_GetCellOpacity_20(HandleRef pThis);

		public virtual double GetCellOpacity()
		{
			return vtkViewTheme.vtkViewTheme_GetCellOpacity_20(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkViewTheme_GetCellSaturationRange_21(HandleRef pThis);

		public virtual IntPtr GetCellSaturationRange()
		{
			return vtkViewTheme.vtkViewTheme_GetCellSaturationRange_21(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkViewTheme_GetCellSaturationRange_22(HandleRef pThis, ref double mn, ref double mx);

		public virtual void GetCellSaturationRange(ref double mn, ref double mx)
		{
			vtkViewTheme.vtkViewTheme_GetCellSaturationRange_22(base.GetCppThis(), ref mn, ref mx);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkViewTheme_GetCellSaturationRange_23(HandleRef pThis, IntPtr rng);

		public virtual void GetCellSaturationRange(IntPtr rng)
		{
			vtkViewTheme.vtkViewTheme_GetCellSaturationRange_23(base.GetCppThis(), rng);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkViewTheme_GetCellTextProperty_24(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkTextProperty GetCellTextProperty()
		{
			vtkTextProperty vtkTextProperty = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkViewTheme.vtkViewTheme_GetCellTextProperty_24(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkViewTheme_GetCellValueRange_25(HandleRef pThis, IntPtr rng);

		public virtual void GetCellValueRange(IntPtr rng)
		{
			vtkViewTheme.vtkViewTheme_GetCellValueRange_25(base.GetCppThis(), rng);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkViewTheme_GetCellValueRange_26(HandleRef pThis);

		public virtual IntPtr GetCellValueRange()
		{
			return vtkViewTheme.vtkViewTheme_GetCellValueRange_26(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkViewTheme_GetCellValueRange_27(HandleRef pThis, ref double mn, ref double mx);

		public virtual void GetCellValueRange(ref double mn, ref double mx)
		{
			vtkViewTheme.vtkViewTheme_GetCellValueRange_27(base.GetCppThis(), ref mn, ref mx);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkViewTheme_GetEdgeLabelColor_28(HandleRef pThis);

		public virtual IntPtr GetEdgeLabelColor()
		{
			return vtkViewTheme.vtkViewTheme_GetEdgeLabelColor_28(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkViewTheme_GetEdgeLabelColor_29(HandleRef pThis, ref double r, ref double g, ref double b);

		public virtual void GetEdgeLabelColor(ref double r, ref double g, ref double b)
		{
			vtkViewTheme.vtkViewTheme_GetEdgeLabelColor_29(base.GetCppThis(), ref r, ref g, ref b);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkViewTheme_GetEdgeLabelColor_30(HandleRef pThis, IntPtr c);

		public virtual void GetEdgeLabelColor(IntPtr c)
		{
			vtkViewTheme.vtkViewTheme_GetEdgeLabelColor_30(base.GetCppThis(), c);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkViewTheme_GetLineWidth_31(HandleRef pThis);

		public virtual double GetLineWidth()
		{
			return vtkViewTheme.vtkViewTheme_GetLineWidth_31(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkViewTheme_GetOutlineColor_32(HandleRef pThis);

		public virtual double[] GetOutlineColor()
		{
			IntPtr intPtr = vtkViewTheme.vtkViewTheme_GetOutlineColor_32(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkViewTheme_GetOutlineColor_33(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		public virtual void GetOutlineColor(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkViewTheme.vtkViewTheme_GetOutlineColor_33(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkViewTheme_GetOutlineColor_34(HandleRef pThis, IntPtr _arg);

		public virtual void GetOutlineColor(IntPtr _arg)
		{
			vtkViewTheme.vtkViewTheme_GetOutlineColor_34(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkViewTheme_GetPointAlphaRange_35(HandleRef pThis);

		public virtual IntPtr GetPointAlphaRange()
		{
			return vtkViewTheme.vtkViewTheme_GetPointAlphaRange_35(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkViewTheme_GetPointAlphaRange_36(HandleRef pThis, ref double mn, ref double mx);

		public virtual void GetPointAlphaRange(ref double mn, ref double mx)
		{
			vtkViewTheme.vtkViewTheme_GetPointAlphaRange_36(base.GetCppThis(), ref mn, ref mx);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkViewTheme_GetPointAlphaRange_37(HandleRef pThis, IntPtr rng);

		public virtual void GetPointAlphaRange(IntPtr rng)
		{
			vtkViewTheme.vtkViewTheme_GetPointAlphaRange_37(base.GetCppThis(), rng);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkViewTheme_GetPointColor_38(HandleRef pThis);

		public virtual double[] GetPointColor()
		{
			IntPtr intPtr = vtkViewTheme.vtkViewTheme_GetPointColor_38(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkViewTheme_GetPointColor_39(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		public virtual void GetPointColor(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkViewTheme.vtkViewTheme_GetPointColor_39(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkViewTheme_GetPointColor_40(HandleRef pThis, IntPtr _arg);

		public virtual void GetPointColor(IntPtr _arg)
		{
			vtkViewTheme.vtkViewTheme_GetPointColor_40(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkViewTheme_GetPointHueRange_41(HandleRef pThis);

		public virtual IntPtr GetPointHueRange()
		{
			return vtkViewTheme.vtkViewTheme_GetPointHueRange_41(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkViewTheme_GetPointHueRange_42(HandleRef pThis, ref double mn, ref double mx);

		public virtual void GetPointHueRange(ref double mn, ref double mx)
		{
			vtkViewTheme.vtkViewTheme_GetPointHueRange_42(base.GetCppThis(), ref mn, ref mx);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkViewTheme_GetPointHueRange_43(HandleRef pThis, IntPtr rng);

		public virtual void GetPointHueRange(IntPtr rng)
		{
			vtkViewTheme.vtkViewTheme_GetPointHueRange_43(base.GetCppThis(), rng);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkViewTheme_GetPointLookupTable_44(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkScalarsToColors GetPointLookupTable()
		{
			vtkScalarsToColors vtkScalarsToColors = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkViewTheme.vtkViewTheme_GetPointLookupTable_44(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkScalarsToColors = (vtkScalarsToColors)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkScalarsToColors.Register(null);
				}
			}
			return vtkScalarsToColors;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkViewTheme_GetPointOpacity_45(HandleRef pThis);

		public virtual double GetPointOpacity()
		{
			return vtkViewTheme.vtkViewTheme_GetPointOpacity_45(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkViewTheme_GetPointSaturationRange_46(HandleRef pThis);

		public virtual IntPtr GetPointSaturationRange()
		{
			return vtkViewTheme.vtkViewTheme_GetPointSaturationRange_46(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkViewTheme_GetPointSaturationRange_47(HandleRef pThis, ref double mn, ref double mx);

		public virtual void GetPointSaturationRange(ref double mn, ref double mx)
		{
			vtkViewTheme.vtkViewTheme_GetPointSaturationRange_47(base.GetCppThis(), ref mn, ref mx);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkViewTheme_GetPointSaturationRange_48(HandleRef pThis, IntPtr rng);

		public virtual void GetPointSaturationRange(IntPtr rng)
		{
			vtkViewTheme.vtkViewTheme_GetPointSaturationRange_48(base.GetCppThis(), rng);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkViewTheme_GetPointSize_49(HandleRef pThis);

		public virtual double GetPointSize()
		{
			return vtkViewTheme.vtkViewTheme_GetPointSize_49(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkViewTheme_GetPointTextProperty_50(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkTextProperty GetPointTextProperty()
		{
			vtkTextProperty vtkTextProperty = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkViewTheme.vtkViewTheme_GetPointTextProperty_50(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkViewTheme_GetPointValueRange_51(HandleRef pThis);

		public virtual IntPtr GetPointValueRange()
		{
			return vtkViewTheme.vtkViewTheme_GetPointValueRange_51(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkViewTheme_GetPointValueRange_52(HandleRef pThis, ref double mn, ref double mx);

		public virtual void GetPointValueRange(ref double mn, ref double mx)
		{
			vtkViewTheme.vtkViewTheme_GetPointValueRange_52(base.GetCppThis(), ref mn, ref mx);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkViewTheme_GetPointValueRange_53(HandleRef pThis, IntPtr rng);

		public virtual void GetPointValueRange(IntPtr rng)
		{
			vtkViewTheme.vtkViewTheme_GetPointValueRange_53(base.GetCppThis(), rng);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern byte vtkViewTheme_GetScaleCellLookupTable_54(HandleRef pThis);

		public virtual bool GetScaleCellLookupTable()
		{
			return vtkViewTheme.vtkViewTheme_GetScaleCellLookupTable_54(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern byte vtkViewTheme_GetScalePointLookupTable_55(HandleRef pThis);

		public virtual bool GetScalePointLookupTable()
		{
			return vtkViewTheme.vtkViewTheme_GetScalePointLookupTable_55(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkViewTheme_GetSelectedCellColor_56(HandleRef pThis);

		public virtual double[] GetSelectedCellColor()
		{
			IntPtr intPtr = vtkViewTheme.vtkViewTheme_GetSelectedCellColor_56(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkViewTheme_GetSelectedCellColor_57(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		public virtual void GetSelectedCellColor(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkViewTheme.vtkViewTheme_GetSelectedCellColor_57(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkViewTheme_GetSelectedCellColor_58(HandleRef pThis, IntPtr _arg);

		public virtual void GetSelectedCellColor(IntPtr _arg)
		{
			vtkViewTheme.vtkViewTheme_GetSelectedCellColor_58(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkViewTheme_GetSelectedCellOpacity_59(HandleRef pThis);

		public virtual double GetSelectedCellOpacity()
		{
			return vtkViewTheme.vtkViewTheme_GetSelectedCellOpacity_59(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkViewTheme_GetSelectedPointColor_60(HandleRef pThis);

		public virtual double[] GetSelectedPointColor()
		{
			IntPtr intPtr = vtkViewTheme.vtkViewTheme_GetSelectedPointColor_60(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkViewTheme_GetSelectedPointColor_61(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		public virtual void GetSelectedPointColor(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkViewTheme.vtkViewTheme_GetSelectedPointColor_61(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkViewTheme_GetSelectedPointColor_62(HandleRef pThis, IntPtr _arg);

		public virtual void GetSelectedPointColor(IntPtr _arg)
		{
			vtkViewTheme.vtkViewTheme_GetSelectedPointColor_62(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkViewTheme_GetSelectedPointOpacity_63(HandleRef pThis);

		public virtual double GetSelectedPointOpacity()
		{
			return vtkViewTheme.vtkViewTheme_GetSelectedPointOpacity_63(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkViewTheme_GetVertexLabelColor_64(HandleRef pThis);

		public virtual IntPtr GetVertexLabelColor()
		{
			return vtkViewTheme.vtkViewTheme_GetVertexLabelColor_64(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkViewTheme_GetVertexLabelColor_65(HandleRef pThis, ref double r, ref double g, ref double b);

		public virtual void GetVertexLabelColor(ref double r, ref double g, ref double b)
		{
			vtkViewTheme.vtkViewTheme_GetVertexLabelColor_65(base.GetCppThis(), ref r, ref g, ref b);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkViewTheme_GetVertexLabelColor_66(HandleRef pThis, IntPtr c);

		public virtual void GetVertexLabelColor(IntPtr c)
		{
			vtkViewTheme.vtkViewTheme_GetVertexLabelColor_66(base.GetCppThis(), c);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkViewTheme_IsA_67(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkViewTheme.vtkViewTheme_IsA_67(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkViewTheme_IsTypeOf_68(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkViewTheme.vtkViewTheme_IsTypeOf_68(type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern byte vtkViewTheme_LookupMatchesCellTheme_69(HandleRef pThis, HandleRef s2c);

		public bool LookupMatchesCellTheme(vtkScalarsToColors s2c)
		{
			return vtkViewTheme.vtkViewTheme_LookupMatchesCellTheme_69(base.GetCppThis(), (s2c == null) ? default(HandleRef) : s2c.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern byte vtkViewTheme_LookupMatchesPointTheme_70(HandleRef pThis, HandleRef s2c);

		public bool LookupMatchesPointTheme(vtkScalarsToColors s2c)
		{
			return vtkViewTheme.vtkViewTheme_LookupMatchesPointTheme_70(base.GetCppThis(), (s2c == null) ? default(HandleRef) : s2c.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkViewTheme_NewInstance_72(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkViewTheme NewInstance()
		{
			vtkViewTheme result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkViewTheme.vtkViewTheme_NewInstance_72(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkViewTheme)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkViewTheme_SafeDownCast_73(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkViewTheme SafeDownCast(vtkObjectBase o)
		{
			vtkViewTheme vtkViewTheme = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkViewTheme.vtkViewTheme_SafeDownCast_73((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkViewTheme = (vtkViewTheme)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkViewTheme.Register(null);
				}
			}
			return vtkViewTheme;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkViewTheme_ScaleCellLookupTableOff_74(HandleRef pThis);

		public virtual void ScaleCellLookupTableOff()
		{
			vtkViewTheme.vtkViewTheme_ScaleCellLookupTableOff_74(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkViewTheme_ScaleCellLookupTableOn_75(HandleRef pThis);

		public virtual void ScaleCellLookupTableOn()
		{
			vtkViewTheme.vtkViewTheme_ScaleCellLookupTableOn_75(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkViewTheme_ScalePointLookupTableOff_76(HandleRef pThis);

		public virtual void ScalePointLookupTableOff()
		{
			vtkViewTheme.vtkViewTheme_ScalePointLookupTableOff_76(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkViewTheme_ScalePointLookupTableOn_77(HandleRef pThis);

		public virtual void ScalePointLookupTableOn()
		{
			vtkViewTheme.vtkViewTheme_ScalePointLookupTableOn_77(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkViewTheme_SetBackgroundColor_78(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		public virtual void SetBackgroundColor(double _arg1, double _arg2, double _arg3)
		{
			vtkViewTheme.vtkViewTheme_SetBackgroundColor_78(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkViewTheme_SetBackgroundColor_79(HandleRef pThis, IntPtr _arg);

		public virtual void SetBackgroundColor(IntPtr _arg)
		{
			vtkViewTheme.vtkViewTheme_SetBackgroundColor_79(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkViewTheme_SetBackgroundColor2_80(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		public virtual void SetBackgroundColor2(double _arg1, double _arg2, double _arg3)
		{
			vtkViewTheme.vtkViewTheme_SetBackgroundColor2_80(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkViewTheme_SetBackgroundColor2_81(HandleRef pThis, IntPtr _arg);

		public virtual void SetBackgroundColor2(IntPtr _arg)
		{
			vtkViewTheme.vtkViewTheme_SetBackgroundColor2_81(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkViewTheme_SetCellAlphaRange_82(HandleRef pThis, double mn, double mx);

		public virtual void SetCellAlphaRange(double mn, double mx)
		{
			vtkViewTheme.vtkViewTheme_SetCellAlphaRange_82(base.GetCppThis(), mn, mx);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkViewTheme_SetCellAlphaRange_83(HandleRef pThis, IntPtr rng);

		public virtual void SetCellAlphaRange(IntPtr rng)
		{
			vtkViewTheme.vtkViewTheme_SetCellAlphaRange_83(base.GetCppThis(), rng);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkViewTheme_SetCellColor_84(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		public virtual void SetCellColor(double _arg1, double _arg2, double _arg3)
		{
			vtkViewTheme.vtkViewTheme_SetCellColor_84(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkViewTheme_SetCellColor_85(HandleRef pThis, IntPtr _arg);

		public virtual void SetCellColor(IntPtr _arg)
		{
			vtkViewTheme.vtkViewTheme_SetCellColor_85(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkViewTheme_SetCellHueRange_86(HandleRef pThis, double mn, double mx);

		public virtual void SetCellHueRange(double mn, double mx)
		{
			vtkViewTheme.vtkViewTheme_SetCellHueRange_86(base.GetCppThis(), mn, mx);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkViewTheme_SetCellHueRange_87(HandleRef pThis, IntPtr rng);

		public virtual void SetCellHueRange(IntPtr rng)
		{
			vtkViewTheme.vtkViewTheme_SetCellHueRange_87(base.GetCppThis(), rng);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkViewTheme_SetCellLookupTable_88(HandleRef pThis, HandleRef lut);

		public virtual void SetCellLookupTable(vtkScalarsToColors lut)
		{
			vtkViewTheme.vtkViewTheme_SetCellLookupTable_88(base.GetCppThis(), (lut == null) ? default(HandleRef) : lut.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkViewTheme_SetCellOpacity_89(HandleRef pThis, double _arg);

		public virtual void SetCellOpacity(double _arg)
		{
			vtkViewTheme.vtkViewTheme_SetCellOpacity_89(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkViewTheme_SetCellSaturationRange_90(HandleRef pThis, double mn, double mx);

		public virtual void SetCellSaturationRange(double mn, double mx)
		{
			vtkViewTheme.vtkViewTheme_SetCellSaturationRange_90(base.GetCppThis(), mn, mx);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkViewTheme_SetCellSaturationRange_91(HandleRef pThis, IntPtr rng);

		public virtual void SetCellSaturationRange(IntPtr rng)
		{
			vtkViewTheme.vtkViewTheme_SetCellSaturationRange_91(base.GetCppThis(), rng);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkViewTheme_SetCellTextProperty_92(HandleRef pThis, HandleRef tprop);

		public virtual void SetCellTextProperty(vtkTextProperty tprop)
		{
			vtkViewTheme.vtkViewTheme_SetCellTextProperty_92(base.GetCppThis(), (tprop == null) ? default(HandleRef) : tprop.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkViewTheme_SetCellValueRange_93(HandleRef pThis, double mn, double mx);

		public virtual void SetCellValueRange(double mn, double mx)
		{
			vtkViewTheme.vtkViewTheme_SetCellValueRange_93(base.GetCppThis(), mn, mx);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkViewTheme_SetCellValueRange_94(HandleRef pThis, IntPtr rng);

		public virtual void SetCellValueRange(IntPtr rng)
		{
			vtkViewTheme.vtkViewTheme_SetCellValueRange_94(base.GetCppThis(), rng);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkViewTheme_SetEdgeLabelColor_95(HandleRef pThis, double r, double g, double b);

		public virtual void SetEdgeLabelColor(double r, double g, double b)
		{
			vtkViewTheme.vtkViewTheme_SetEdgeLabelColor_95(base.GetCppThis(), r, g, b);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkViewTheme_SetEdgeLabelColor_96(HandleRef pThis, IntPtr c);

		public virtual void SetEdgeLabelColor(IntPtr c)
		{
			vtkViewTheme.vtkViewTheme_SetEdgeLabelColor_96(base.GetCppThis(), c);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkViewTheme_SetLineWidth_97(HandleRef pThis, double _arg);

		public virtual void SetLineWidth(double _arg)
		{
			vtkViewTheme.vtkViewTheme_SetLineWidth_97(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkViewTheme_SetOutlineColor_98(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		public virtual void SetOutlineColor(double _arg1, double _arg2, double _arg3)
		{
			vtkViewTheme.vtkViewTheme_SetOutlineColor_98(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkViewTheme_SetOutlineColor_99(HandleRef pThis, IntPtr _arg);

		public virtual void SetOutlineColor(IntPtr _arg)
		{
			vtkViewTheme.vtkViewTheme_SetOutlineColor_99(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkViewTheme_SetPointAlphaRange_100(HandleRef pThis, double mn, double mx);

		public virtual void SetPointAlphaRange(double mn, double mx)
		{
			vtkViewTheme.vtkViewTheme_SetPointAlphaRange_100(base.GetCppThis(), mn, mx);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkViewTheme_SetPointAlphaRange_101(HandleRef pThis, IntPtr rng);

		public virtual void SetPointAlphaRange(IntPtr rng)
		{
			vtkViewTheme.vtkViewTheme_SetPointAlphaRange_101(base.GetCppThis(), rng);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkViewTheme_SetPointColor_102(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		public virtual void SetPointColor(double _arg1, double _arg2, double _arg3)
		{
			vtkViewTheme.vtkViewTheme_SetPointColor_102(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkViewTheme_SetPointColor_103(HandleRef pThis, IntPtr _arg);

		public virtual void SetPointColor(IntPtr _arg)
		{
			vtkViewTheme.vtkViewTheme_SetPointColor_103(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkViewTheme_SetPointHueRange_104(HandleRef pThis, double mn, double mx);

		public virtual void SetPointHueRange(double mn, double mx)
		{
			vtkViewTheme.vtkViewTheme_SetPointHueRange_104(base.GetCppThis(), mn, mx);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkViewTheme_SetPointHueRange_105(HandleRef pThis, IntPtr rng);

		public virtual void SetPointHueRange(IntPtr rng)
		{
			vtkViewTheme.vtkViewTheme_SetPointHueRange_105(base.GetCppThis(), rng);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkViewTheme_SetPointLookupTable_106(HandleRef pThis, HandleRef lut);

		public virtual void SetPointLookupTable(vtkScalarsToColors lut)
		{
			vtkViewTheme.vtkViewTheme_SetPointLookupTable_106(base.GetCppThis(), (lut == null) ? default(HandleRef) : lut.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkViewTheme_SetPointOpacity_107(HandleRef pThis, double _arg);

		public virtual void SetPointOpacity(double _arg)
		{
			vtkViewTheme.vtkViewTheme_SetPointOpacity_107(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkViewTheme_SetPointSaturationRange_108(HandleRef pThis, double mn, double mx);

		public virtual void SetPointSaturationRange(double mn, double mx)
		{
			vtkViewTheme.vtkViewTheme_SetPointSaturationRange_108(base.GetCppThis(), mn, mx);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkViewTheme_SetPointSaturationRange_109(HandleRef pThis, IntPtr rng);

		public virtual void SetPointSaturationRange(IntPtr rng)
		{
			vtkViewTheme.vtkViewTheme_SetPointSaturationRange_109(base.GetCppThis(), rng);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkViewTheme_SetPointSize_110(HandleRef pThis, double _arg);

		public virtual void SetPointSize(double _arg)
		{
			vtkViewTheme.vtkViewTheme_SetPointSize_110(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkViewTheme_SetPointTextProperty_111(HandleRef pThis, HandleRef tprop);

		public virtual void SetPointTextProperty(vtkTextProperty tprop)
		{
			vtkViewTheme.vtkViewTheme_SetPointTextProperty_111(base.GetCppThis(), (tprop == null) ? default(HandleRef) : tprop.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkViewTheme_SetPointValueRange_112(HandleRef pThis, double mn, double mx);

		public virtual void SetPointValueRange(double mn, double mx)
		{
			vtkViewTheme.vtkViewTheme_SetPointValueRange_112(base.GetCppThis(), mn, mx);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkViewTheme_SetPointValueRange_113(HandleRef pThis, IntPtr rng);

		public virtual void SetPointValueRange(IntPtr rng)
		{
			vtkViewTheme.vtkViewTheme_SetPointValueRange_113(base.GetCppThis(), rng);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkViewTheme_SetScaleCellLookupTable_114(HandleRef pThis, byte _arg);

		public virtual void SetScaleCellLookupTable(bool _arg)
		{
			vtkViewTheme.vtkViewTheme_SetScaleCellLookupTable_114(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkViewTheme_SetScalePointLookupTable_115(HandleRef pThis, byte _arg);

		public virtual void SetScalePointLookupTable(bool _arg)
		{
			vtkViewTheme.vtkViewTheme_SetScalePointLookupTable_115(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkViewTheme_SetSelectedCellColor_116(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		public virtual void SetSelectedCellColor(double _arg1, double _arg2, double _arg3)
		{
			vtkViewTheme.vtkViewTheme_SetSelectedCellColor_116(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkViewTheme_SetSelectedCellColor_117(HandleRef pThis, IntPtr _arg);

		public virtual void SetSelectedCellColor(IntPtr _arg)
		{
			vtkViewTheme.vtkViewTheme_SetSelectedCellColor_117(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkViewTheme_SetSelectedCellOpacity_118(HandleRef pThis, double _arg);

		public virtual void SetSelectedCellOpacity(double _arg)
		{
			vtkViewTheme.vtkViewTheme_SetSelectedCellOpacity_118(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkViewTheme_SetSelectedPointColor_119(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		public virtual void SetSelectedPointColor(double _arg1, double _arg2, double _arg3)
		{
			vtkViewTheme.vtkViewTheme_SetSelectedPointColor_119(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkViewTheme_SetSelectedPointColor_120(HandleRef pThis, IntPtr _arg);

		public virtual void SetSelectedPointColor(IntPtr _arg)
		{
			vtkViewTheme.vtkViewTheme_SetSelectedPointColor_120(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkViewTheme_SetSelectedPointOpacity_121(HandleRef pThis, double _arg);

		public virtual void SetSelectedPointOpacity(double _arg)
		{
			vtkViewTheme.vtkViewTheme_SetSelectedPointOpacity_121(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkViewTheme_SetVertexLabelColor_122(HandleRef pThis, double r, double g, double b);

		public virtual void SetVertexLabelColor(double r, double g, double b)
		{
			vtkViewTheme.vtkViewTheme_SetVertexLabelColor_122(base.GetCppThis(), r, g, b);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkViewTheme_SetVertexLabelColor_123(HandleRef pThis, IntPtr c);

		public virtual void SetVertexLabelColor(IntPtr c)
		{
			vtkViewTheme.vtkViewTheme_SetVertexLabelColor_123(base.GetCppThis(), c);
		}
	}
}
