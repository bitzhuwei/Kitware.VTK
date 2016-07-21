using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkExtractHistogram2D : vtkBivariateStatisticsAlgorithm
	{
		public new enum OutputIndices
		{
			HISTOGRAM_IMAGE = 3
		}

		public new const string MRFullTypeName = "Kitware.VTK.vtkExtractHistogram2D";

		public new static readonly string MRClassNameKey;

		static vtkExtractHistogram2D()
		{
			vtkExtractHistogram2D.MRClassNameKey = "class vtkExtractHistogram2D";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkExtractHistogram2D.MRClassNameKey, Type.GetType("Kitware.VTK.vtkExtractHistogram2D"));
		}

		public vtkExtractHistogram2D(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkExtractHistogram2D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkExtractHistogram2D New()
		{
			vtkExtractHistogram2D result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkExtractHistogram2D.vtkExtractHistogram2D_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExtractHistogram2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkExtractHistogram2D() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkExtractHistogram2D.vtkExtractHistogram2D_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkExtractHistogram2D_Aggregate_01(HandleRef pThis, HandleRef arg0, HandleRef arg1);

		public override void Aggregate(vtkDataObjectCollection arg0, vtkMultiBlockDataSet arg1)
		{
			vtkExtractHistogram2D.vtkExtractHistogram2D_Aggregate_01(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkExtractHistogram2D_GetBinRange_02(HandleRef pThis, long binX, long binY, IntPtr range);

		public int GetBinRange(long binX, long binY, IntPtr range)
		{
			return vtkExtractHistogram2D.vtkExtractHistogram2D_GetBinRange_02(base.GetCppThis(), binX, binY, range);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkExtractHistogram2D_GetBinRange_03(HandleRef pThis, long bin, IntPtr range);

		public int GetBinRange(long bin, IntPtr range)
		{
			return vtkExtractHistogram2D.vtkExtractHistogram2D_GetBinRange_03(base.GetCppThis(), bin, range);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkExtractHistogram2D_GetBinWidth_04(HandleRef pThis, IntPtr bw);

		public void GetBinWidth(IntPtr bw)
		{
			vtkExtractHistogram2D.vtkExtractHistogram2D_GetBinWidth_04(base.GetCppThis(), bw);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkExtractHistogram2D_GetComponentsToProcess_05(HandleRef pThis);

		public virtual int[] GetComponentsToProcess()
		{
			IntPtr intPtr = vtkExtractHistogram2D.vtkExtractHistogram2D_GetComponentsToProcess_05(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkExtractHistogram2D_GetComponentsToProcess_06(HandleRef pThis, ref int _arg1, ref int _arg2);

		public virtual void GetComponentsToProcess(ref int _arg1, ref int _arg2)
		{
			vtkExtractHistogram2D.vtkExtractHistogram2D_GetComponentsToProcess_06(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkExtractHistogram2D_GetComponentsToProcess_07(HandleRef pThis, IntPtr _arg);

		public virtual void GetComponentsToProcess(IntPtr _arg)
		{
			vtkExtractHistogram2D.vtkExtractHistogram2D_GetComponentsToProcess_07(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkExtractHistogram2D_GetCustomHistogramExtents_08(HandleRef pThis);

		public virtual double[] GetCustomHistogramExtents()
		{
			IntPtr intPtr = vtkExtractHistogram2D.vtkExtractHistogram2D_GetCustomHistogramExtents_08(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[4];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkExtractHistogram2D_GetCustomHistogramExtents_09(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4);

		public virtual void GetCustomHistogramExtents(ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4)
		{
			vtkExtractHistogram2D.vtkExtractHistogram2D_GetCustomHistogramExtents_09(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkExtractHistogram2D_GetCustomHistogramExtents_10(HandleRef pThis, IntPtr _arg);

		public virtual void GetCustomHistogramExtents(IntPtr _arg)
		{
			vtkExtractHistogram2D.vtkExtractHistogram2D_GetCustomHistogramExtents_10(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkExtractHistogram2D_GetHistogramExtents_11(HandleRef pThis);

		public IntPtr GetHistogramExtents()
		{
			return vtkExtractHistogram2D.vtkExtractHistogram2D_GetHistogramExtents_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern double vtkExtractHistogram2D_GetMaximumBinCount_12(HandleRef pThis);

		public virtual double GetMaximumBinCount()
		{
			return vtkExtractHistogram2D.vtkExtractHistogram2D_GetMaximumBinCount_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkExtractHistogram2D_GetNumberOfBins_13(HandleRef pThis);

		public virtual int[] GetNumberOfBins()
		{
			IntPtr intPtr = vtkExtractHistogram2D.vtkExtractHistogram2D_GetNumberOfBins_13(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkExtractHistogram2D_GetNumberOfBins_14(HandleRef pThis, ref int _arg1, ref int _arg2);

		public virtual void GetNumberOfBins(ref int _arg1, ref int _arg2)
		{
			vtkExtractHistogram2D.vtkExtractHistogram2D_GetNumberOfBins_14(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkExtractHistogram2D_GetNumberOfBins_15(HandleRef pThis, IntPtr _arg);

		public virtual void GetNumberOfBins(IntPtr _arg)
		{
			vtkExtractHistogram2D.vtkExtractHistogram2D_GetNumberOfBins_15(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkExtractHistogram2D_GetOutputHistogramImage_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkImageData GetOutputHistogramImage()
		{
			vtkImageData vtkImageData = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkExtractHistogram2D.vtkExtractHistogram2D_GetOutputHistogramImage_16(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageData = (vtkImageData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageData.Register(null);
				}
			}
			return vtkImageData;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkExtractHistogram2D_GetRowMask_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkDataArray GetRowMask()
		{
			vtkDataArray vtkDataArray = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkExtractHistogram2D.vtkExtractHistogram2D_GetRowMask_17(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataArray = (vtkDataArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataArray.Register(null);
				}
			}
			return vtkDataArray;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkExtractHistogram2D_GetScalarType_18(HandleRef pThis);

		public virtual int GetScalarType()
		{
			return vtkExtractHistogram2D.vtkExtractHistogram2D_GetScalarType_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkExtractHistogram2D_GetSwapColumns_19(HandleRef pThis);

		public virtual int GetSwapColumns()
		{
			return vtkExtractHistogram2D.vtkExtractHistogram2D_GetSwapColumns_19(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkExtractHistogram2D_GetUseCustomHistogramExtents_20(HandleRef pThis);

		public virtual int GetUseCustomHistogramExtents()
		{
			return vtkExtractHistogram2D.vtkExtractHistogram2D_GetUseCustomHistogramExtents_20(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkExtractHistogram2D_IsA_21(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkExtractHistogram2D.vtkExtractHistogram2D_IsA_21(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkExtractHistogram2D_IsTypeOf_22(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkExtractHistogram2D.vtkExtractHistogram2D_IsTypeOf_22(type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkExtractHistogram2D_NewInstance_24(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkExtractHistogram2D NewInstance()
		{
			vtkExtractHistogram2D result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkExtractHistogram2D.vtkExtractHistogram2D_NewInstance_24(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExtractHistogram2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkExtractHistogram2D_SafeDownCast_25(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkExtractHistogram2D SafeDownCast(vtkObjectBase o)
		{
			vtkExtractHistogram2D vtkExtractHistogram2D = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkExtractHistogram2D.vtkExtractHistogram2D_SafeDownCast_25((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkExtractHistogram2D = (vtkExtractHistogram2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkExtractHistogram2D.Register(null);
				}
			}
			return vtkExtractHistogram2D;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkExtractHistogram2D_SetComponentsToProcess_26(HandleRef pThis, int _arg1, int _arg2);

		public virtual void SetComponentsToProcess(int _arg1, int _arg2)
		{
			vtkExtractHistogram2D.vtkExtractHistogram2D_SetComponentsToProcess_26(base.GetCppThis(), _arg1, _arg2);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkExtractHistogram2D_SetComponentsToProcess_27(HandleRef pThis, IntPtr _arg);

		public void SetComponentsToProcess(IntPtr _arg)
		{
			vtkExtractHistogram2D.vtkExtractHistogram2D_SetComponentsToProcess_27(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkExtractHistogram2D_SetCustomHistogramExtents_28(HandleRef pThis, double _arg1, double _arg2, double _arg3, double _arg4);

		public virtual void SetCustomHistogramExtents(double _arg1, double _arg2, double _arg3, double _arg4)
		{
			vtkExtractHistogram2D.vtkExtractHistogram2D_SetCustomHistogramExtents_28(base.GetCppThis(), _arg1, _arg2, _arg3, _arg4);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkExtractHistogram2D_SetCustomHistogramExtents_29(HandleRef pThis, IntPtr _arg);

		public virtual void SetCustomHistogramExtents(IntPtr _arg)
		{
			vtkExtractHistogram2D.vtkExtractHistogram2D_SetCustomHistogramExtents_29(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkExtractHistogram2D_SetNumberOfBins_30(HandleRef pThis, int _arg1, int _arg2);

		public virtual void SetNumberOfBins(int _arg1, int _arg2)
		{
			vtkExtractHistogram2D.vtkExtractHistogram2D_SetNumberOfBins_30(base.GetCppThis(), _arg1, _arg2);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkExtractHistogram2D_SetNumberOfBins_31(HandleRef pThis, IntPtr _arg);

		public void SetNumberOfBins(IntPtr _arg)
		{
			vtkExtractHistogram2D.vtkExtractHistogram2D_SetNumberOfBins_31(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkExtractHistogram2D_SetRowMask_32(HandleRef pThis, HandleRef arg0);

		public virtual void SetRowMask(vtkDataArray arg0)
		{
			vtkExtractHistogram2D.vtkExtractHistogram2D_SetRowMask_32(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkExtractHistogram2D_SetScalarType_33(HandleRef pThis, int _arg);

		public virtual void SetScalarType(int _arg)
		{
			vtkExtractHistogram2D.vtkExtractHistogram2D_SetScalarType_33(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkExtractHistogram2D_SetScalarTypeToDouble_34(HandleRef pThis);

		public void SetScalarTypeToDouble()
		{
			vtkExtractHistogram2D.vtkExtractHistogram2D_SetScalarTypeToDouble_34(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkExtractHistogram2D_SetScalarTypeToFloat_35(HandleRef pThis);

		public void SetScalarTypeToFloat()
		{
			vtkExtractHistogram2D.vtkExtractHistogram2D_SetScalarTypeToFloat_35(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkExtractHistogram2D_SetScalarTypeToUnsignedChar_36(HandleRef pThis);

		public void SetScalarTypeToUnsignedChar()
		{
			vtkExtractHistogram2D.vtkExtractHistogram2D_SetScalarTypeToUnsignedChar_36(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkExtractHistogram2D_SetScalarTypeToUnsignedInt_37(HandleRef pThis);

		public void SetScalarTypeToUnsignedInt()
		{
			vtkExtractHistogram2D.vtkExtractHistogram2D_SetScalarTypeToUnsignedInt_37(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkExtractHistogram2D_SetScalarTypeToUnsignedLong_38(HandleRef pThis);

		public void SetScalarTypeToUnsignedLong()
		{
			vtkExtractHistogram2D.vtkExtractHistogram2D_SetScalarTypeToUnsignedLong_38(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkExtractHistogram2D_SetScalarTypeToUnsignedShort_39(HandleRef pThis);

		public void SetScalarTypeToUnsignedShort()
		{
			vtkExtractHistogram2D.vtkExtractHistogram2D_SetScalarTypeToUnsignedShort_39(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkExtractHistogram2D_SetSwapColumns_40(HandleRef pThis, int _arg);

		public virtual void SetSwapColumns(int _arg)
		{
			vtkExtractHistogram2D.vtkExtractHistogram2D_SetSwapColumns_40(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkExtractHistogram2D_SetUseCustomHistogramExtents_41(HandleRef pThis, int _arg);

		public virtual void SetUseCustomHistogramExtents(int _arg)
		{
			vtkExtractHistogram2D.vtkExtractHistogram2D_SetUseCustomHistogramExtents_41(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkExtractHistogram2D_SwapColumnsOff_42(HandleRef pThis);

		public virtual void SwapColumnsOff()
		{
			vtkExtractHistogram2D.vtkExtractHistogram2D_SwapColumnsOff_42(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkExtractHistogram2D_SwapColumnsOn_43(HandleRef pThis);

		public virtual void SwapColumnsOn()
		{
			vtkExtractHistogram2D.vtkExtractHistogram2D_SwapColumnsOn_43(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkExtractHistogram2D_UseCustomHistogramExtentsOff_44(HandleRef pThis);

		public virtual void UseCustomHistogramExtentsOff()
		{
			vtkExtractHistogram2D.vtkExtractHistogram2D_UseCustomHistogramExtentsOff_44(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkExtractHistogram2D_UseCustomHistogramExtentsOn_45(HandleRef pThis);

		public virtual void UseCustomHistogramExtentsOn()
		{
			vtkExtractHistogram2D.vtkExtractHistogram2D_UseCustomHistogramExtentsOn_45(base.GetCppThis());
		}
	}
}
