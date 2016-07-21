using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkXYPlotActor : vtkActor2D
	{
		public enum Alignment
		{
			AlignAxisBottom = 8192,
			AlignAxisHCenter = 1024,
			AlignAxisLeft = 256,
			AlignAxisRight = 512,
			AlignAxisTop = 4096,
			AlignAxisVCenter = 16384,
			AlignBottom = 32,
			AlignHCenter = 4,
			AlignLeft = 1,
			AlignRight,
			AlignTop = 16,
			AlignVCenter = 64
		}

		public new const string MRFullTypeName = "Kitware.VTK.vtkXYPlotActor";

		public new static readonly string MRClassNameKey;

		static vtkXYPlotActor()
		{
			vtkXYPlotActor.MRClassNameKey = "class vtkXYPlotActor";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkXYPlotActor.MRClassNameKey, Type.GetType("Kitware.VTK.vtkXYPlotActor"));
		}

		public vtkXYPlotActor(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkXYPlotActor_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkXYPlotActor New()
		{
			vtkXYPlotActor result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkXYPlotActor.vtkXYPlotActor_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXYPlotActor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkXYPlotActor() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkXYPlotActor.vtkXYPlotActor_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkXYPlotActor_AddDataObjectInput_01(HandleRef pThis, HandleRef arg0);

		public void AddDataObjectInput(vtkDataObject arg0)
		{
			vtkXYPlotActor.vtkXYPlotActor_AddDataObjectInput_01(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkXYPlotActor_AddInput_02(HandleRef pThis, HandleRef arg0, string arrayName, int component);

		public void AddInput(vtkDataSet arg0, string arrayName, int component)
		{
			vtkXYPlotActor.vtkXYPlotActor_AddInput_02(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), arrayName, component);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkXYPlotActor_AddInput_03(HandleRef pThis, HandleRef arg0);

		public void AddInput(vtkDataSet arg0)
		{
			vtkXYPlotActor.vtkXYPlotActor_AddInput_03(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkXYPlotActor_AdjustTitlePositionOff_04(HandleRef pThis);

		public virtual void AdjustTitlePositionOff()
		{
			vtkXYPlotActor.vtkXYPlotActor_AdjustTitlePositionOff_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkXYPlotActor_AdjustTitlePositionOn_05(HandleRef pThis);

		public virtual void AdjustTitlePositionOn()
		{
			vtkXYPlotActor.vtkXYPlotActor_AdjustTitlePositionOn_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkXYPlotActor_ChartBorderOff_06(HandleRef pThis);

		public virtual void ChartBorderOff()
		{
			vtkXYPlotActor.vtkXYPlotActor_ChartBorderOff_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkXYPlotActor_ChartBorderOn_07(HandleRef pThis);

		public virtual void ChartBorderOn()
		{
			vtkXYPlotActor.vtkXYPlotActor_ChartBorderOn_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkXYPlotActor_ChartBoxOff_08(HandleRef pThis);

		public virtual void ChartBoxOff()
		{
			vtkXYPlotActor.vtkXYPlotActor_ChartBoxOff_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkXYPlotActor_ChartBoxOn_09(HandleRef pThis);

		public virtual void ChartBoxOn()
		{
			vtkXYPlotActor.vtkXYPlotActor_ChartBoxOn_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkXYPlotActor_ExchangeAxesOff_10(HandleRef pThis);

		public virtual void ExchangeAxesOff()
		{
			vtkXYPlotActor.vtkXYPlotActor_ExchangeAxesOff_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkXYPlotActor_ExchangeAxesOn_11(HandleRef pThis);

		public virtual void ExchangeAxesOn()
		{
			vtkXYPlotActor.vtkXYPlotActor_ExchangeAxesOn_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkXYPlotActor_GetAdjustTitlePosition_12(HandleRef pThis);

		public virtual int GetAdjustTitlePosition()
		{
			return vtkXYPlotActor.vtkXYPlotActor_GetAdjustTitlePosition_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkXYPlotActor_GetAdjustTitlePositionMode_13(HandleRef pThis);

		public virtual int GetAdjustTitlePositionMode()
		{
			return vtkXYPlotActor.vtkXYPlotActor_GetAdjustTitlePositionMode_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkXYPlotActor_GetAdjustXLabels_14(HandleRef pThis);

		public virtual int GetAdjustXLabels()
		{
			return vtkXYPlotActor.vtkXYPlotActor_GetAdjustXLabels_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkXYPlotActor_GetAdjustYLabels_15(HandleRef pThis);

		public virtual int GetAdjustYLabels()
		{
			return vtkXYPlotActor.vtkXYPlotActor_GetAdjustYLabels_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkXYPlotActor_GetAxisLabelTextProperty_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkTextProperty GetAxisLabelTextProperty()
		{
			vtkTextProperty vtkTextProperty = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkXYPlotActor.vtkXYPlotActor_GetAxisLabelTextProperty_16(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkXYPlotActor_GetAxisTitleTextProperty_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkTextProperty GetAxisTitleTextProperty()
		{
			vtkTextProperty vtkTextProperty = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkXYPlotActor.vtkXYPlotActor_GetAxisTitleTextProperty_17(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkXYPlotActor_GetBorder_18(HandleRef pThis);

		public virtual int GetBorder()
		{
			return vtkXYPlotActor.vtkXYPlotActor_GetBorder_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkXYPlotActor_GetBorderMaxValue_19(HandleRef pThis);

		public virtual int GetBorderMaxValue()
		{
			return vtkXYPlotActor.vtkXYPlotActor_GetBorderMaxValue_19(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkXYPlotActor_GetBorderMinValue_20(HandleRef pThis);

		public virtual int GetBorderMinValue()
		{
			return vtkXYPlotActor.vtkXYPlotActor_GetBorderMinValue_20(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkXYPlotActor_GetChartBorder_21(HandleRef pThis);

		public virtual int GetChartBorder()
		{
			return vtkXYPlotActor.vtkXYPlotActor_GetChartBorder_21(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkXYPlotActor_GetChartBox_22(HandleRef pThis);

		public virtual int GetChartBox()
		{
			return vtkXYPlotActor.vtkXYPlotActor_GetChartBox_22(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkXYPlotActor_GetChartBoxProperty_23(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkProperty2D GetChartBoxProperty()
		{
			vtkProperty2D vtkProperty2D = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkXYPlotActor.vtkXYPlotActor_GetChartBoxProperty_23(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProperty2D = (vtkProperty2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProperty2D.Register(null);
				}
			}
			return vtkProperty2D;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkXYPlotActor_GetDataObjectInputList_24(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkDataObjectCollection GetDataObjectInputList()
		{
			vtkDataObjectCollection vtkDataObjectCollection = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkXYPlotActor.vtkXYPlotActor_GetDataObjectInputList_24(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataObjectCollection = (vtkDataObjectCollection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataObjectCollection.Register(null);
				}
			}
			return vtkDataObjectCollection;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkXYPlotActor_GetDataObjectPlotMode_25(HandleRef pThis);

		public virtual int GetDataObjectPlotMode()
		{
			return vtkXYPlotActor.vtkXYPlotActor_GetDataObjectPlotMode_25(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkXYPlotActor_GetDataObjectPlotModeAsString_26(HandleRef pThis);

		public string GetDataObjectPlotModeAsString()
		{
			return Marshal.PtrToStringAnsi(vtkXYPlotActor.vtkXYPlotActor_GetDataObjectPlotModeAsString_26(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkXYPlotActor_GetDataObjectPlotModeMaxValue_27(HandleRef pThis);

		public virtual int GetDataObjectPlotModeMaxValue()
		{
			return vtkXYPlotActor.vtkXYPlotActor_GetDataObjectPlotModeMaxValue_27(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkXYPlotActor_GetDataObjectPlotModeMinValue_28(HandleRef pThis);

		public virtual int GetDataObjectPlotModeMinValue()
		{
			return vtkXYPlotActor.vtkXYPlotActor_GetDataObjectPlotModeMinValue_28(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkXYPlotActor_GetDataObjectXComponent_29(HandleRef pThis, int i);

		public int GetDataObjectXComponent(int i)
		{
			return vtkXYPlotActor.vtkXYPlotActor_GetDataObjectXComponent_29(base.GetCppThis(), i);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkXYPlotActor_GetDataObjectYComponent_30(HandleRef pThis, int i);

		public int GetDataObjectYComponent(int i)
		{
			return vtkXYPlotActor.vtkXYPlotActor_GetDataObjectYComponent_30(base.GetCppThis(), i);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkXYPlotActor_GetExchangeAxes_31(HandleRef pThis);

		public virtual int GetExchangeAxes()
		{
			return vtkXYPlotActor.vtkXYPlotActor_GetExchangeAxes_31(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern double vtkXYPlotActor_GetGlyphSize_32(HandleRef pThis);

		public virtual double GetGlyphSize()
		{
			return vtkXYPlotActor.vtkXYPlotActor_GetGlyphSize_32(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern double vtkXYPlotActor_GetGlyphSizeMaxValue_33(HandleRef pThis);

		public virtual double GetGlyphSizeMaxValue()
		{
			return vtkXYPlotActor.vtkXYPlotActor_GetGlyphSizeMaxValue_33(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern double vtkXYPlotActor_GetGlyphSizeMinValue_34(HandleRef pThis);

		public virtual double GetGlyphSizeMinValue()
		{
			return vtkXYPlotActor.vtkXYPlotActor_GetGlyphSizeMinValue_34(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkXYPlotActor_GetGlyphSource_35(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkGlyphSource2D GetGlyphSource()
		{
			vtkGlyphSource2D vtkGlyphSource2D = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkXYPlotActor.vtkXYPlotActor_GetGlyphSource_35(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGlyphSource2D = (vtkGlyphSource2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGlyphSource2D.Register(null);
				}
			}
			return vtkGlyphSource2D;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkXYPlotActor_GetInputList_36(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkDataSetCollection GetInputList()
		{
			vtkDataSetCollection vtkDataSetCollection = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkXYPlotActor.vtkXYPlotActor_GetInputList_36(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataSetCollection = (vtkDataSetCollection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataSetCollection.Register(null);
				}
			}
			return vtkDataSetCollection;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkXYPlotActor_GetLabelFormat_37(HandleRef pThis);

		public string GetLabelFormat()
		{
			return Marshal.PtrToStringAnsi(vtkXYPlotActor.vtkXYPlotActor_GetLabelFormat_37(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkXYPlotActor_GetLegend_38(HandleRef pThis);

		public virtual int GetLegend()
		{
			return vtkXYPlotActor.vtkXYPlotActor_GetLegend_38(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkXYPlotActor_GetLegendActor_39(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkLegendBoxActor GetLegendActor()
		{
			vtkLegendBoxActor vtkLegendBoxActor = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkXYPlotActor.vtkXYPlotActor_GetLegendActor_39(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkLegendBoxActor = (vtkLegendBoxActor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkLegendBoxActor.Register(null);
				}
			}
			return vtkLegendBoxActor;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkXYPlotActor_GetLegendPosition_40(HandleRef pThis);

		public virtual double[] GetLegendPosition()
		{
			IntPtr intPtr = vtkXYPlotActor.vtkXYPlotActor_GetLegendPosition_40(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkXYPlotActor_GetLegendPosition_41(HandleRef pThis, ref double _arg1, ref double _arg2);

		public virtual void GetLegendPosition(ref double _arg1, ref double _arg2)
		{
			vtkXYPlotActor.vtkXYPlotActor_GetLegendPosition_41(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkXYPlotActor_GetLegendPosition_42(HandleRef pThis, IntPtr _arg);

		public virtual void GetLegendPosition(IntPtr _arg)
		{
			vtkXYPlotActor.vtkXYPlotActor_GetLegendPosition_42(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkXYPlotActor_GetLegendPosition2_43(HandleRef pThis);

		public virtual double[] GetLegendPosition2()
		{
			IntPtr intPtr = vtkXYPlotActor.vtkXYPlotActor_GetLegendPosition2_43(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkXYPlotActor_GetLegendPosition2_44(HandleRef pThis, ref double _arg1, ref double _arg2);

		public virtual void GetLegendPosition2(ref double _arg1, ref double _arg2)
		{
			vtkXYPlotActor.vtkXYPlotActor_GetLegendPosition2_44(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkXYPlotActor_GetLegendPosition2_45(HandleRef pThis, IntPtr _arg);

		public virtual void GetLegendPosition2(IntPtr _arg)
		{
			vtkXYPlotActor.vtkXYPlotActor_GetLegendPosition2_45(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkXYPlotActor_GetLogx_46(HandleRef pThis);

		public virtual int GetLogx()
		{
			return vtkXYPlotActor.vtkXYPlotActor_GetLogx_46(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern uint vtkXYPlotActor_GetMTime_47(HandleRef pThis);

		public override uint GetMTime()
		{
			return vtkXYPlotActor.vtkXYPlotActor_GetMTime_47(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkXYPlotActor_GetNumberOfXLabels_48(HandleRef pThis);

		public virtual int GetNumberOfXLabels()
		{
			return vtkXYPlotActor.vtkXYPlotActor_GetNumberOfXLabels_48(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkXYPlotActor_GetNumberOfXLabelsMaxValue_49(HandleRef pThis);

		public virtual int GetNumberOfXLabelsMaxValue()
		{
			return vtkXYPlotActor.vtkXYPlotActor_GetNumberOfXLabelsMaxValue_49(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkXYPlotActor_GetNumberOfXLabelsMinValue_50(HandleRef pThis);

		public virtual int GetNumberOfXLabelsMinValue()
		{
			return vtkXYPlotActor.vtkXYPlotActor_GetNumberOfXLabelsMinValue_50(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkXYPlotActor_GetNumberOfXMinorTicks_51(HandleRef pThis);

		public int GetNumberOfXMinorTicks()
		{
			return vtkXYPlotActor.vtkXYPlotActor_GetNumberOfXMinorTicks_51(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkXYPlotActor_GetNumberOfYLabels_52(HandleRef pThis);

		public virtual int GetNumberOfYLabels()
		{
			return vtkXYPlotActor.vtkXYPlotActor_GetNumberOfYLabels_52(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkXYPlotActor_GetNumberOfYLabelsMaxValue_53(HandleRef pThis);

		public virtual int GetNumberOfYLabelsMaxValue()
		{
			return vtkXYPlotActor.vtkXYPlotActor_GetNumberOfYLabelsMaxValue_53(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkXYPlotActor_GetNumberOfYLabelsMinValue_54(HandleRef pThis);

		public virtual int GetNumberOfYLabelsMinValue()
		{
			return vtkXYPlotActor.vtkXYPlotActor_GetNumberOfYLabelsMinValue_54(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkXYPlotActor_GetNumberOfYMinorTicks_55(HandleRef pThis);

		public int GetNumberOfYMinorTicks()
		{
			return vtkXYPlotActor.vtkXYPlotActor_GetNumberOfYMinorTicks_55(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkXYPlotActor_GetPlotColor_56(HandleRef pThis, int i);

		public double[] GetPlotColor(int i)
		{
			IntPtr intPtr = vtkXYPlotActor.vtkXYPlotActor_GetPlotColor_56(base.GetCppThis(), i);
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkXYPlotActor_GetPlotCoordinate_57(HandleRef pThis);

		public virtual double[] GetPlotCoordinate()
		{
			IntPtr intPtr = vtkXYPlotActor.vtkXYPlotActor_GetPlotCoordinate_57(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkXYPlotActor_GetPlotCoordinate_58(HandleRef pThis, ref double _arg1, ref double _arg2);

		public virtual void GetPlotCoordinate(ref double _arg1, ref double _arg2)
		{
			vtkXYPlotActor.vtkXYPlotActor_GetPlotCoordinate_58(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkXYPlotActor_GetPlotCoordinate_59(HandleRef pThis, IntPtr _arg);

		public virtual void GetPlotCoordinate(IntPtr _arg)
		{
			vtkXYPlotActor.vtkXYPlotActor_GetPlotCoordinate_59(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkXYPlotActor_GetPlotCurveLines_60(HandleRef pThis);

		public virtual int GetPlotCurveLines()
		{
			return vtkXYPlotActor.vtkXYPlotActor_GetPlotCurveLines_60(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkXYPlotActor_GetPlotCurvePoints_61(HandleRef pThis);

		public virtual int GetPlotCurvePoints()
		{
			return vtkXYPlotActor.vtkXYPlotActor_GetPlotCurvePoints_61(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkXYPlotActor_GetPlotLabel_62(HandleRef pThis, int i);

		public string GetPlotLabel(int i)
		{
			return Marshal.PtrToStringAnsi(vtkXYPlotActor.vtkXYPlotActor_GetPlotLabel_62(base.GetCppThis(), i));
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkXYPlotActor_GetPlotLines_63(HandleRef pThis, int i);

		public int GetPlotLines(int i)
		{
			return vtkXYPlotActor.vtkXYPlotActor_GetPlotLines_63(base.GetCppThis(), i);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkXYPlotActor_GetPlotLines_64(HandleRef pThis);

		public virtual int GetPlotLines()
		{
			return vtkXYPlotActor.vtkXYPlotActor_GetPlotLines_64(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkXYPlotActor_GetPlotPoints_65(HandleRef pThis, int i);

		public int GetPlotPoints(int i)
		{
			return vtkXYPlotActor.vtkXYPlotActor_GetPlotPoints_65(base.GetCppThis(), i);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkXYPlotActor_GetPlotPoints_66(HandleRef pThis);

		public virtual int GetPlotPoints()
		{
			return vtkXYPlotActor.vtkXYPlotActor_GetPlotPoints_66(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkXYPlotActor_GetPlotSymbol_67(HandleRef pThis, int i, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkPolyData GetPlotSymbol(int i)
		{
			vtkPolyData vtkPolyData = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkXYPlotActor.vtkXYPlotActor_GetPlotSymbol_67(base.GetCppThis(), i, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPolyData = (vtkPolyData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPolyData.Register(null);
				}
			}
			return vtkPolyData;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkXYPlotActor_GetPointComponent_68(HandleRef pThis, int i);

		public int GetPointComponent(int i)
		{
			return vtkXYPlotActor.vtkXYPlotActor_GetPointComponent_68(base.GetCppThis(), i);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern double vtkXYPlotActor_GetReferenceXValue_69(HandleRef pThis);

		public virtual double GetReferenceXValue()
		{
			return vtkXYPlotActor.vtkXYPlotActor_GetReferenceXValue_69(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern double vtkXYPlotActor_GetReferenceYValue_70(HandleRef pThis);

		public virtual double GetReferenceYValue()
		{
			return vtkXYPlotActor.vtkXYPlotActor_GetReferenceYValue_70(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkXYPlotActor_GetReverseXAxis_71(HandleRef pThis);

		public virtual int GetReverseXAxis()
		{
			return vtkXYPlotActor.vtkXYPlotActor_GetReverseXAxis_71(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkXYPlotActor_GetReverseYAxis_72(HandleRef pThis);

		public virtual int GetReverseYAxis()
		{
			return vtkXYPlotActor.vtkXYPlotActor_GetReverseYAxis_72(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkXYPlotActor_GetShowReferenceXLine_73(HandleRef pThis);

		public virtual int GetShowReferenceXLine()
		{
			return vtkXYPlotActor.vtkXYPlotActor_GetShowReferenceXLine_73(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkXYPlotActor_GetShowReferenceYLine_74(HandleRef pThis);

		public virtual int GetShowReferenceYLine()
		{
			return vtkXYPlotActor.vtkXYPlotActor_GetShowReferenceYLine_74(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkXYPlotActor_GetTitle_75(HandleRef pThis);

		public virtual string GetTitle()
		{
			return Marshal.PtrToStringAnsi(vtkXYPlotActor.vtkXYPlotActor_GetTitle_75(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkXYPlotActor_GetTitlePosition_76(HandleRef pThis);

		public virtual double[] GetTitlePosition()
		{
			IntPtr intPtr = vtkXYPlotActor.vtkXYPlotActor_GetTitlePosition_76(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkXYPlotActor_GetTitlePosition_77(HandleRef pThis, ref double _arg1, ref double _arg2);

		public virtual void GetTitlePosition(ref double _arg1, ref double _arg2)
		{
			vtkXYPlotActor.vtkXYPlotActor_GetTitlePosition_77(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkXYPlotActor_GetTitlePosition_78(HandleRef pThis, IntPtr _arg);

		public virtual void GetTitlePosition(IntPtr _arg)
		{
			vtkXYPlotActor.vtkXYPlotActor_GetTitlePosition_78(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkXYPlotActor_GetTitleTextProperty_79(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkTextProperty GetTitleTextProperty()
		{
			vtkTextProperty vtkTextProperty = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkXYPlotActor.vtkXYPlotActor_GetTitleTextProperty_79(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkXYPlotActor_GetViewportCoordinate_80(HandleRef pThis);

		public virtual double[] GetViewportCoordinate()
		{
			IntPtr intPtr = vtkXYPlotActor.vtkXYPlotActor_GetViewportCoordinate_80(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkXYPlotActor_GetViewportCoordinate_81(HandleRef pThis, ref double _arg1, ref double _arg2);

		public virtual void GetViewportCoordinate(ref double _arg1, ref double _arg2)
		{
			vtkXYPlotActor.vtkXYPlotActor_GetViewportCoordinate_81(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkXYPlotActor_GetViewportCoordinate_82(HandleRef pThis, IntPtr _arg);

		public virtual void GetViewportCoordinate(IntPtr _arg)
		{
			vtkXYPlotActor.vtkXYPlotActor_GetViewportCoordinate_82(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkXYPlotActor_GetXAxisActor2D_83(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkAxisActor2D GetXAxisActor2D()
		{
			vtkAxisActor2D vtkAxisActor2D = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkXYPlotActor.vtkXYPlotActor_GetXAxisActor2D_83(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAxisActor2D = (vtkAxisActor2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAxisActor2D.Register(null);
				}
			}
			return vtkAxisActor2D;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkXYPlotActor_GetXLabelFormat_84(HandleRef pThis);

		public virtual string GetXLabelFormat()
		{
			return Marshal.PtrToStringAnsi(vtkXYPlotActor.vtkXYPlotActor_GetXLabelFormat_84(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkXYPlotActor_GetXRange_85(HandleRef pThis);

		public virtual double[] GetXRange()
		{
			IntPtr intPtr = vtkXYPlotActor.vtkXYPlotActor_GetXRange_85(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkXYPlotActor_GetXRange_86(HandleRef pThis, IntPtr data);

		public virtual void GetXRange(IntPtr data)
		{
			vtkXYPlotActor.vtkXYPlotActor_GetXRange_86(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkXYPlotActor_GetXTitle_87(HandleRef pThis);

		public virtual string GetXTitle()
		{
			return Marshal.PtrToStringAnsi(vtkXYPlotActor.vtkXYPlotActor_GetXTitle_87(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern double vtkXYPlotActor_GetXTitlePosition_88(HandleRef pThis);

		public double GetXTitlePosition()
		{
			return vtkXYPlotActor.vtkXYPlotActor_GetXTitlePosition_88(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkXYPlotActor_GetXValues_89(HandleRef pThis);

		public virtual int GetXValues()
		{
			return vtkXYPlotActor.vtkXYPlotActor_GetXValues_89(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkXYPlotActor_GetXValuesAsString_90(HandleRef pThis);

		public string GetXValuesAsString()
		{
			return Marshal.PtrToStringAnsi(vtkXYPlotActor.vtkXYPlotActor_GetXValuesAsString_90(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkXYPlotActor_GetXValuesMaxValue_91(HandleRef pThis);

		public virtual int GetXValuesMaxValue()
		{
			return vtkXYPlotActor.vtkXYPlotActor_GetXValuesMaxValue_91(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkXYPlotActor_GetXValuesMinValue_92(HandleRef pThis);

		public virtual int GetXValuesMinValue()
		{
			return vtkXYPlotActor.vtkXYPlotActor_GetXValuesMinValue_92(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkXYPlotActor_GetYAxisActor2D_93(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkAxisActor2D GetYAxisActor2D()
		{
			vtkAxisActor2D vtkAxisActor2D = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkXYPlotActor.vtkXYPlotActor_GetYAxisActor2D_93(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAxisActor2D = (vtkAxisActor2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAxisActor2D.Register(null);
				}
			}
			return vtkAxisActor2D;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkXYPlotActor_GetYLabelFormat_94(HandleRef pThis);

		public virtual string GetYLabelFormat()
		{
			return Marshal.PtrToStringAnsi(vtkXYPlotActor.vtkXYPlotActor_GetYLabelFormat_94(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkXYPlotActor_GetYRange_95(HandleRef pThis);

		public virtual double[] GetYRange()
		{
			IntPtr intPtr = vtkXYPlotActor.vtkXYPlotActor_GetYRange_95(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkXYPlotActor_GetYRange_96(HandleRef pThis, IntPtr data);

		public virtual void GetYRange(IntPtr data)
		{
			vtkXYPlotActor.vtkXYPlotActor_GetYRange_96(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkXYPlotActor_GetYTitle_97(HandleRef pThis);

		public virtual string GetYTitle()
		{
			return Marshal.PtrToStringAnsi(vtkXYPlotActor.vtkXYPlotActor_GetYTitle_97(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern double vtkXYPlotActor_GetYTitlePosition_98(HandleRef pThis);

		public double GetYTitlePosition()
		{
			return vtkXYPlotActor.vtkXYPlotActor_GetYTitlePosition_98(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkXYPlotActor_HasTranslucentPolygonalGeometry_99(HandleRef pThis);

		public override int HasTranslucentPolygonalGeometry()
		{
			return vtkXYPlotActor.vtkXYPlotActor_HasTranslucentPolygonalGeometry_99(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkXYPlotActor_IsA_100(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkXYPlotActor.vtkXYPlotActor_IsA_100(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkXYPlotActor_IsInPlot_101(HandleRef pThis, HandleRef viewport, double u, double v);

		public int IsInPlot(vtkViewport viewport, double u, double v)
		{
			return vtkXYPlotActor.vtkXYPlotActor_IsInPlot_101(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis(), u, v);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkXYPlotActor_IsTypeOf_102(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkXYPlotActor.vtkXYPlotActor_IsTypeOf_102(type);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkXYPlotActor_LegendOff_103(HandleRef pThis);

		public virtual void LegendOff()
		{
			vtkXYPlotActor.vtkXYPlotActor_LegendOff_103(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkXYPlotActor_LegendOn_104(HandleRef pThis);

		public virtual void LegendOn()
		{
			vtkXYPlotActor.vtkXYPlotActor_LegendOn_104(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkXYPlotActor_LogxOff_105(HandleRef pThis);

		public virtual void LogxOff()
		{
			vtkXYPlotActor.vtkXYPlotActor_LogxOff_105(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkXYPlotActor_LogxOn_106(HandleRef pThis);

		public virtual void LogxOn()
		{
			vtkXYPlotActor.vtkXYPlotActor_LogxOn_106(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkXYPlotActor_NewInstance_108(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkXYPlotActor NewInstance()
		{
			vtkXYPlotActor result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkXYPlotActor.vtkXYPlotActor_NewInstance_108(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXYPlotActor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkXYPlotActor_PlotCurveLinesOff_109(HandleRef pThis);

		public virtual void PlotCurveLinesOff()
		{
			vtkXYPlotActor.vtkXYPlotActor_PlotCurveLinesOff_109(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkXYPlotActor_PlotCurveLinesOn_110(HandleRef pThis);

		public virtual void PlotCurveLinesOn()
		{
			vtkXYPlotActor.vtkXYPlotActor_PlotCurveLinesOn_110(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkXYPlotActor_PlotCurvePointsOff_111(HandleRef pThis);

		public virtual void PlotCurvePointsOff()
		{
			vtkXYPlotActor.vtkXYPlotActor_PlotCurvePointsOff_111(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkXYPlotActor_PlotCurvePointsOn_112(HandleRef pThis);

		public virtual void PlotCurvePointsOn()
		{
			vtkXYPlotActor.vtkXYPlotActor_PlotCurvePointsOn_112(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkXYPlotActor_PlotLinesOff_113(HandleRef pThis);

		public virtual void PlotLinesOff()
		{
			vtkXYPlotActor.vtkXYPlotActor_PlotLinesOff_113(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkXYPlotActor_PlotLinesOn_114(HandleRef pThis);

		public virtual void PlotLinesOn()
		{
			vtkXYPlotActor.vtkXYPlotActor_PlotLinesOn_114(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkXYPlotActor_PlotPointsOff_115(HandleRef pThis);

		public virtual void PlotPointsOff()
		{
			vtkXYPlotActor.vtkXYPlotActor_PlotPointsOff_115(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkXYPlotActor_PlotPointsOn_116(HandleRef pThis);

		public virtual void PlotPointsOn()
		{
			vtkXYPlotActor.vtkXYPlotActor_PlotPointsOn_116(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkXYPlotActor_PlotToViewportCoordinate_117(HandleRef pThis, HandleRef viewport, ref double u, ref double v);

		public void PlotToViewportCoordinate(vtkViewport viewport, ref double u, ref double v)
		{
			vtkXYPlotActor.vtkXYPlotActor_PlotToViewportCoordinate_117(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis(), ref u, ref v);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkXYPlotActor_PlotToViewportCoordinate_118(HandleRef pThis, HandleRef viewport);

		public void PlotToViewportCoordinate(vtkViewport viewport)
		{
			vtkXYPlotActor.vtkXYPlotActor_PlotToViewportCoordinate_118(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkXYPlotActor_ReleaseGraphicsResources_119(HandleRef pThis, HandleRef arg0);

		public override void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkXYPlotActor.vtkXYPlotActor_ReleaseGraphicsResources_119(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkXYPlotActor_RemoveAllInputs_120(HandleRef pThis);

		public void RemoveAllInputs()
		{
			vtkXYPlotActor.vtkXYPlotActor_RemoveAllInputs_120(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkXYPlotActor_RemoveDataObjectInput_121(HandleRef pThis, HandleRef arg0);

		public void RemoveDataObjectInput(vtkDataObject arg0)
		{
			vtkXYPlotActor.vtkXYPlotActor_RemoveDataObjectInput_121(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkXYPlotActor_RemoveInput_122(HandleRef pThis, HandleRef arg0, string arrayName, int component);

		public void RemoveInput(vtkDataSet arg0, string arrayName, int component)
		{
			vtkXYPlotActor.vtkXYPlotActor_RemoveInput_122(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), arrayName, component);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkXYPlotActor_RemoveInput_123(HandleRef pThis, HandleRef arg0);

		public void RemoveInput(vtkDataSet arg0)
		{
			vtkXYPlotActor.vtkXYPlotActor_RemoveInput_123(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkXYPlotActor_RenderOpaqueGeometry_124(HandleRef pThis, HandleRef arg0);

		public override int RenderOpaqueGeometry(vtkViewport arg0)
		{
			return vtkXYPlotActor.vtkXYPlotActor_RenderOpaqueGeometry_124(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkXYPlotActor_RenderOverlay_125(HandleRef pThis, HandleRef arg0);

		public override int RenderOverlay(vtkViewport arg0)
		{
			return vtkXYPlotActor.vtkXYPlotActor_RenderOverlay_125(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkXYPlotActor_RenderTranslucentPolygonalGeometry_126(HandleRef pThis, HandleRef arg0);

		public override int RenderTranslucentPolygonalGeometry(vtkViewport arg0)
		{
			return vtkXYPlotActor.vtkXYPlotActor_RenderTranslucentPolygonalGeometry_126(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkXYPlotActor_ReverseXAxisOff_127(HandleRef pThis);

		public virtual void ReverseXAxisOff()
		{
			vtkXYPlotActor.vtkXYPlotActor_ReverseXAxisOff_127(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkXYPlotActor_ReverseXAxisOn_128(HandleRef pThis);

		public virtual void ReverseXAxisOn()
		{
			vtkXYPlotActor.vtkXYPlotActor_ReverseXAxisOn_128(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkXYPlotActor_ReverseYAxisOff_129(HandleRef pThis);

		public virtual void ReverseYAxisOff()
		{
			vtkXYPlotActor.vtkXYPlotActor_ReverseYAxisOff_129(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkXYPlotActor_ReverseYAxisOn_130(HandleRef pThis);

		public virtual void ReverseYAxisOn()
		{
			vtkXYPlotActor.vtkXYPlotActor_ReverseYAxisOn_130(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkXYPlotActor_SafeDownCast_131(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkXYPlotActor SafeDownCast(vtkObjectBase o)
		{
			vtkXYPlotActor vtkXYPlotActor = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkXYPlotActor.vtkXYPlotActor_SafeDownCast_131((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkXYPlotActor = (vtkXYPlotActor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkXYPlotActor.Register(null);
				}
			}
			return vtkXYPlotActor;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkXYPlotActor_SetAdjustTitlePosition_132(HandleRef pThis, int _arg);

		public virtual void SetAdjustTitlePosition(int _arg)
		{
			vtkXYPlotActor.vtkXYPlotActor_SetAdjustTitlePosition_132(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkXYPlotActor_SetAdjustTitlePositionMode_133(HandleRef pThis, int _arg);

		public virtual void SetAdjustTitlePositionMode(int _arg)
		{
			vtkXYPlotActor.vtkXYPlotActor_SetAdjustTitlePositionMode_133(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkXYPlotActor_SetAdjustXLabels_134(HandleRef pThis, int adjust);

		public void SetAdjustXLabels(int adjust)
		{
			vtkXYPlotActor.vtkXYPlotActor_SetAdjustXLabels_134(base.GetCppThis(), adjust);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkXYPlotActor_SetAdjustYLabels_135(HandleRef pThis, int adjust);

		public void SetAdjustYLabels(int adjust)
		{
			vtkXYPlotActor.vtkXYPlotActor_SetAdjustYLabels_135(base.GetCppThis(), adjust);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkXYPlotActor_SetAxisLabelTextProperty_136(HandleRef pThis, HandleRef p);

		public virtual void SetAxisLabelTextProperty(vtkTextProperty p)
		{
			vtkXYPlotActor.vtkXYPlotActor_SetAxisLabelTextProperty_136(base.GetCppThis(), (p == null) ? default(HandleRef) : p.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkXYPlotActor_SetAxisTitleTextProperty_137(HandleRef pThis, HandleRef p);

		public virtual void SetAxisTitleTextProperty(vtkTextProperty p)
		{
			vtkXYPlotActor.vtkXYPlotActor_SetAxisTitleTextProperty_137(base.GetCppThis(), (p == null) ? default(HandleRef) : p.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkXYPlotActor_SetBorder_138(HandleRef pThis, int _arg);

		public virtual void SetBorder(int _arg)
		{
			vtkXYPlotActor.vtkXYPlotActor_SetBorder_138(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkXYPlotActor_SetChartBorder_139(HandleRef pThis, int _arg);

		public virtual void SetChartBorder(int _arg)
		{
			vtkXYPlotActor.vtkXYPlotActor_SetChartBorder_139(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkXYPlotActor_SetChartBox_140(HandleRef pThis, int _arg);

		public virtual void SetChartBox(int _arg)
		{
			vtkXYPlotActor.vtkXYPlotActor_SetChartBox_140(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkXYPlotActor_SetDataObjectPlotMode_141(HandleRef pThis, int _arg);

		public virtual void SetDataObjectPlotMode(int _arg)
		{
			vtkXYPlotActor.vtkXYPlotActor_SetDataObjectPlotMode_141(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkXYPlotActor_SetDataObjectPlotModeToColumns_142(HandleRef pThis);

		public void SetDataObjectPlotModeToColumns()
		{
			vtkXYPlotActor.vtkXYPlotActor_SetDataObjectPlotModeToColumns_142(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkXYPlotActor_SetDataObjectPlotModeToRows_143(HandleRef pThis);

		public void SetDataObjectPlotModeToRows()
		{
			vtkXYPlotActor.vtkXYPlotActor_SetDataObjectPlotModeToRows_143(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkXYPlotActor_SetDataObjectXComponent_144(HandleRef pThis, int i, int comp);

		public void SetDataObjectXComponent(int i, int comp)
		{
			vtkXYPlotActor.vtkXYPlotActor_SetDataObjectXComponent_144(base.GetCppThis(), i, comp);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkXYPlotActor_SetDataObjectYComponent_145(HandleRef pThis, int i, int comp);

		public void SetDataObjectYComponent(int i, int comp)
		{
			vtkXYPlotActor.vtkXYPlotActor_SetDataObjectYComponent_145(base.GetCppThis(), i, comp);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkXYPlotActor_SetExchangeAxes_146(HandleRef pThis, int _arg);

		public virtual void SetExchangeAxes(int _arg)
		{
			vtkXYPlotActor.vtkXYPlotActor_SetExchangeAxes_146(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkXYPlotActor_SetGlyphSize_147(HandleRef pThis, double _arg);

		public virtual void SetGlyphSize(double _arg)
		{
			vtkXYPlotActor.vtkXYPlotActor_SetGlyphSize_147(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkXYPlotActor_SetLabelFormat_148(HandleRef pThis, string _arg);

		public virtual void SetLabelFormat(string _arg)
		{
			vtkXYPlotActor.vtkXYPlotActor_SetLabelFormat_148(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkXYPlotActor_SetLegend_149(HandleRef pThis, int _arg);

		public virtual void SetLegend(int _arg)
		{
			vtkXYPlotActor.vtkXYPlotActor_SetLegend_149(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkXYPlotActor_SetLegendPosition_150(HandleRef pThis, double _arg1, double _arg2);

		public virtual void SetLegendPosition(double _arg1, double _arg2)
		{
			vtkXYPlotActor.vtkXYPlotActor_SetLegendPosition_150(base.GetCppThis(), _arg1, _arg2);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkXYPlotActor_SetLegendPosition_151(HandleRef pThis, IntPtr _arg);

		public void SetLegendPosition(IntPtr _arg)
		{
			vtkXYPlotActor.vtkXYPlotActor_SetLegendPosition_151(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkXYPlotActor_SetLegendPosition2_152(HandleRef pThis, double _arg1, double _arg2);

		public virtual void SetLegendPosition2(double _arg1, double _arg2)
		{
			vtkXYPlotActor.vtkXYPlotActor_SetLegendPosition2_152(base.GetCppThis(), _arg1, _arg2);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkXYPlotActor_SetLegendPosition2_153(HandleRef pThis, IntPtr _arg);

		public void SetLegendPosition2(IntPtr _arg)
		{
			vtkXYPlotActor.vtkXYPlotActor_SetLegendPosition2_153(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkXYPlotActor_SetLogx_154(HandleRef pThis, int _arg);

		public virtual void SetLogx(int _arg)
		{
			vtkXYPlotActor.vtkXYPlotActor_SetLogx_154(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkXYPlotActor_SetNumberOfLabels_155(HandleRef pThis, int num);

		public void SetNumberOfLabels(int num)
		{
			vtkXYPlotActor.vtkXYPlotActor_SetNumberOfLabels_155(base.GetCppThis(), num);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkXYPlotActor_SetNumberOfXLabels_156(HandleRef pThis, int _arg);

		public virtual void SetNumberOfXLabels(int _arg)
		{
			vtkXYPlotActor.vtkXYPlotActor_SetNumberOfXLabels_156(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkXYPlotActor_SetNumberOfXMinorTicks_157(HandleRef pThis, int num);

		public void SetNumberOfXMinorTicks(int num)
		{
			vtkXYPlotActor.vtkXYPlotActor_SetNumberOfXMinorTicks_157(base.GetCppThis(), num);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkXYPlotActor_SetNumberOfYLabels_158(HandleRef pThis, int _arg);

		public virtual void SetNumberOfYLabels(int _arg)
		{
			vtkXYPlotActor.vtkXYPlotActor_SetNumberOfYLabels_158(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkXYPlotActor_SetNumberOfYMinorTicks_159(HandleRef pThis, int num);

		public void SetNumberOfYMinorTicks(int num)
		{
			vtkXYPlotActor.vtkXYPlotActor_SetNumberOfYMinorTicks_159(base.GetCppThis(), num);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkXYPlotActor_SetPlotColor_160(HandleRef pThis, int i, double r, double g, double b);

		public void SetPlotColor(int i, double r, double g, double b)
		{
			vtkXYPlotActor.vtkXYPlotActor_SetPlotColor_160(base.GetCppThis(), i, r, g, b);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkXYPlotActor_SetPlotColor_161(HandleRef pThis, int i, IntPtr color);

		public void SetPlotColor(int i, IntPtr color)
		{
			vtkXYPlotActor.vtkXYPlotActor_SetPlotColor_161(base.GetCppThis(), i, color);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkXYPlotActor_SetPlotCoordinate_162(HandleRef pThis, double _arg1, double _arg2);

		public virtual void SetPlotCoordinate(double _arg1, double _arg2)
		{
			vtkXYPlotActor.vtkXYPlotActor_SetPlotCoordinate_162(base.GetCppThis(), _arg1, _arg2);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkXYPlotActor_SetPlotCoordinate_163(HandleRef pThis, IntPtr _arg);

		public void SetPlotCoordinate(IntPtr _arg)
		{
			vtkXYPlotActor.vtkXYPlotActor_SetPlotCoordinate_163(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkXYPlotActor_SetPlotCurveLines_164(HandleRef pThis, int _arg);

		public virtual void SetPlotCurveLines(int _arg)
		{
			vtkXYPlotActor.vtkXYPlotActor_SetPlotCurveLines_164(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkXYPlotActor_SetPlotCurvePoints_165(HandleRef pThis, int _arg);

		public virtual void SetPlotCurvePoints(int _arg)
		{
			vtkXYPlotActor.vtkXYPlotActor_SetPlotCurvePoints_165(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkXYPlotActor_SetPlotLabel_166(HandleRef pThis, int i, string label);

		public void SetPlotLabel(int i, string label)
		{
			vtkXYPlotActor.vtkXYPlotActor_SetPlotLabel_166(base.GetCppThis(), i, label);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkXYPlotActor_SetPlotLines_167(HandleRef pThis, int i, int arg1);

		public void SetPlotLines(int i, int arg1)
		{
			vtkXYPlotActor.vtkXYPlotActor_SetPlotLines_167(base.GetCppThis(), i, arg1);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkXYPlotActor_SetPlotLines_168(HandleRef pThis, int _arg);

		public virtual void SetPlotLines(int _arg)
		{
			vtkXYPlotActor.vtkXYPlotActor_SetPlotLines_168(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkXYPlotActor_SetPlotPoints_169(HandleRef pThis, int i, int arg1);

		public void SetPlotPoints(int i, int arg1)
		{
			vtkXYPlotActor.vtkXYPlotActor_SetPlotPoints_169(base.GetCppThis(), i, arg1);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkXYPlotActor_SetPlotPoints_170(HandleRef pThis, int _arg);

		public virtual void SetPlotPoints(int _arg)
		{
			vtkXYPlotActor.vtkXYPlotActor_SetPlotPoints_170(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkXYPlotActor_SetPlotRange_171(HandleRef pThis, double xmin, double ymin, double xmax, double ymax);

		public void SetPlotRange(double xmin, double ymin, double xmax, double ymax)
		{
			vtkXYPlotActor.vtkXYPlotActor_SetPlotRange_171(base.GetCppThis(), xmin, ymin, xmax, ymax);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkXYPlotActor_SetPlotSymbol_172(HandleRef pThis, int i, HandleRef input);

		public void SetPlotSymbol(int i, vtkPolyData input)
		{
			vtkXYPlotActor.vtkXYPlotActor_SetPlotSymbol_172(base.GetCppThis(), i, (input == null) ? default(HandleRef) : input.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkXYPlotActor_SetPointComponent_173(HandleRef pThis, int i, int comp);

		public void SetPointComponent(int i, int comp)
		{
			vtkXYPlotActor.vtkXYPlotActor_SetPointComponent_173(base.GetCppThis(), i, comp);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkXYPlotActor_SetReferenceXValue_174(HandleRef pThis, double _arg);

		public virtual void SetReferenceXValue(double _arg)
		{
			vtkXYPlotActor.vtkXYPlotActor_SetReferenceXValue_174(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkXYPlotActor_SetReferenceYValue_175(HandleRef pThis, double _arg);

		public virtual void SetReferenceYValue(double _arg)
		{
			vtkXYPlotActor.vtkXYPlotActor_SetReferenceYValue_175(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkXYPlotActor_SetReverseXAxis_176(HandleRef pThis, int _arg);

		public virtual void SetReverseXAxis(int _arg)
		{
			vtkXYPlotActor.vtkXYPlotActor_SetReverseXAxis_176(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkXYPlotActor_SetReverseYAxis_177(HandleRef pThis, int _arg);

		public virtual void SetReverseYAxis(int _arg)
		{
			vtkXYPlotActor.vtkXYPlotActor_SetReverseYAxis_177(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkXYPlotActor_SetShowReferenceXLine_178(HandleRef pThis, int _arg);

		public virtual void SetShowReferenceXLine(int _arg)
		{
			vtkXYPlotActor.vtkXYPlotActor_SetShowReferenceXLine_178(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkXYPlotActor_SetShowReferenceYLine_179(HandleRef pThis, int _arg);

		public virtual void SetShowReferenceYLine(int _arg)
		{
			vtkXYPlotActor.vtkXYPlotActor_SetShowReferenceYLine_179(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkXYPlotActor_SetTitle_180(HandleRef pThis, string _arg);

		public virtual void SetTitle(string _arg)
		{
			vtkXYPlotActor.vtkXYPlotActor_SetTitle_180(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkXYPlotActor_SetTitlePosition_181(HandleRef pThis, double _arg1, double _arg2);

		public virtual void SetTitlePosition(double _arg1, double _arg2)
		{
			vtkXYPlotActor.vtkXYPlotActor_SetTitlePosition_181(base.GetCppThis(), _arg1, _arg2);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkXYPlotActor_SetTitlePosition_182(HandleRef pThis, IntPtr _arg);

		public void SetTitlePosition(IntPtr _arg)
		{
			vtkXYPlotActor.vtkXYPlotActor_SetTitlePosition_182(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkXYPlotActor_SetTitleTextProperty_183(HandleRef pThis, HandleRef p);

		public virtual void SetTitleTextProperty(vtkTextProperty p)
		{
			vtkXYPlotActor.vtkXYPlotActor_SetTitleTextProperty_183(base.GetCppThis(), (p == null) ? default(HandleRef) : p.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkXYPlotActor_SetViewportCoordinate_184(HandleRef pThis, double _arg1, double _arg2);

		public virtual void SetViewportCoordinate(double _arg1, double _arg2)
		{
			vtkXYPlotActor.vtkXYPlotActor_SetViewportCoordinate_184(base.GetCppThis(), _arg1, _arg2);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkXYPlotActor_SetViewportCoordinate_185(HandleRef pThis, IntPtr _arg);

		public void SetViewportCoordinate(IntPtr _arg)
		{
			vtkXYPlotActor.vtkXYPlotActor_SetViewportCoordinate_185(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkXYPlotActor_SetXLabelFormat_186(HandleRef pThis, string _arg);

		public virtual void SetXLabelFormat(string _arg)
		{
			vtkXYPlotActor.vtkXYPlotActor_SetXLabelFormat_186(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkXYPlotActor_SetXRange_187(HandleRef pThis, double _arg1, double _arg2);

		public virtual void SetXRange(double _arg1, double _arg2)
		{
			vtkXYPlotActor.vtkXYPlotActor_SetXRange_187(base.GetCppThis(), _arg1, _arg2);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkXYPlotActor_SetXRange_188(HandleRef pThis, IntPtr _arg);

		public void SetXRange(IntPtr _arg)
		{
			vtkXYPlotActor.vtkXYPlotActor_SetXRange_188(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkXYPlotActor_SetXTitle_189(HandleRef pThis, string _arg);

		public virtual void SetXTitle(string _arg)
		{
			vtkXYPlotActor.vtkXYPlotActor_SetXTitle_189(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkXYPlotActor_SetXTitlePosition_190(HandleRef pThis, double position);

		public void SetXTitlePosition(double position)
		{
			vtkXYPlotActor.vtkXYPlotActor_SetXTitlePosition_190(base.GetCppThis(), position);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkXYPlotActor_SetXValues_191(HandleRef pThis, int _arg);

		public virtual void SetXValues(int _arg)
		{
			vtkXYPlotActor.vtkXYPlotActor_SetXValues_191(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkXYPlotActor_SetXValuesToArcLength_192(HandleRef pThis);

		public void SetXValuesToArcLength()
		{
			vtkXYPlotActor.vtkXYPlotActor_SetXValuesToArcLength_192(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkXYPlotActor_SetXValuesToIndex_193(HandleRef pThis);

		public void SetXValuesToIndex()
		{
			vtkXYPlotActor.vtkXYPlotActor_SetXValuesToIndex_193(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkXYPlotActor_SetXValuesToNormalizedArcLength_194(HandleRef pThis);

		public void SetXValuesToNormalizedArcLength()
		{
			vtkXYPlotActor.vtkXYPlotActor_SetXValuesToNormalizedArcLength_194(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkXYPlotActor_SetXValuesToValue_195(HandleRef pThis);

		public void SetXValuesToValue()
		{
			vtkXYPlotActor.vtkXYPlotActor_SetXValuesToValue_195(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkXYPlotActor_SetYLabelFormat_196(HandleRef pThis, string _arg);

		public virtual void SetYLabelFormat(string _arg)
		{
			vtkXYPlotActor.vtkXYPlotActor_SetYLabelFormat_196(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkXYPlotActor_SetYRange_197(HandleRef pThis, double _arg1, double _arg2);

		public virtual void SetYRange(double _arg1, double _arg2)
		{
			vtkXYPlotActor.vtkXYPlotActor_SetYRange_197(base.GetCppThis(), _arg1, _arg2);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkXYPlotActor_SetYRange_198(HandleRef pThis, IntPtr _arg);

		public void SetYRange(IntPtr _arg)
		{
			vtkXYPlotActor.vtkXYPlotActor_SetYRange_198(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkXYPlotActor_SetYTitle_199(HandleRef pThis, string _arg);

		public virtual void SetYTitle(string _arg)
		{
			vtkXYPlotActor.vtkXYPlotActor_SetYTitle_199(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkXYPlotActor_SetYTitlePosition_200(HandleRef pThis, double position);

		public void SetYTitlePosition(double position)
		{
			vtkXYPlotActor.vtkXYPlotActor_SetYTitlePosition_200(base.GetCppThis(), position);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkXYPlotActor_ShowReferenceXLineOff_201(HandleRef pThis);

		public virtual void ShowReferenceXLineOff()
		{
			vtkXYPlotActor.vtkXYPlotActor_ShowReferenceXLineOff_201(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkXYPlotActor_ShowReferenceXLineOn_202(HandleRef pThis);

		public virtual void ShowReferenceXLineOn()
		{
			vtkXYPlotActor.vtkXYPlotActor_ShowReferenceXLineOn_202(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkXYPlotActor_ShowReferenceYLineOff_203(HandleRef pThis);

		public virtual void ShowReferenceYLineOff()
		{
			vtkXYPlotActor.vtkXYPlotActor_ShowReferenceYLineOff_203(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkXYPlotActor_ShowReferenceYLineOn_204(HandleRef pThis);

		public virtual void ShowReferenceYLineOn()
		{
			vtkXYPlotActor.vtkXYPlotActor_ShowReferenceYLineOn_204(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkXYPlotActor_ViewportToPlotCoordinate_205(HandleRef pThis, HandleRef viewport, ref double u, ref double v);

		public void ViewportToPlotCoordinate(vtkViewport viewport, ref double u, ref double v)
		{
			vtkXYPlotActor.vtkXYPlotActor_ViewportToPlotCoordinate_205(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis(), ref u, ref v);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkXYPlotActor_ViewportToPlotCoordinate_206(HandleRef pThis, HandleRef viewport);

		public void ViewportToPlotCoordinate(vtkViewport viewport)
		{
			vtkXYPlotActor.vtkXYPlotActor_ViewportToPlotCoordinate_206(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}
	}
}
