using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkPairwiseExtractHistogram2D : vtkStatisticsAlgorithm
	{
		public new enum OutputIndices
		{
			HISTOGRAM_IMAGE = 3
		}

		public new const string MRFullTypeName = "Kitware.VTK.vtkPairwiseExtractHistogram2D";

		public new static readonly string MRClassNameKey;

		static vtkPairwiseExtractHistogram2D()
		{
			vtkPairwiseExtractHistogram2D.MRClassNameKey = "class vtkPairwiseExtractHistogram2D";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPairwiseExtractHistogram2D.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPairwiseExtractHistogram2D"));
		}

		public vtkPairwiseExtractHistogram2D(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkPairwiseExtractHistogram2D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPairwiseExtractHistogram2D New()
		{
			vtkPairwiseExtractHistogram2D result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPairwiseExtractHistogram2D.vtkPairwiseExtractHistogram2D_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPairwiseExtractHistogram2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkPairwiseExtractHistogram2D() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkPairwiseExtractHistogram2D.vtkPairwiseExtractHistogram2D_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkPairwiseExtractHistogram2D_Aggregate_01(HandleRef pThis, HandleRef arg0, HandleRef arg1);

		public override void Aggregate(vtkDataObjectCollection arg0, vtkMultiBlockDataSet arg1)
		{
			vtkPairwiseExtractHistogram2D.vtkPairwiseExtractHistogram2D_Aggregate_01(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkPairwiseExtractHistogram2D_GetBinRange_02(HandleRef pThis, int idx, long binX, long binY, IntPtr range);

		public int GetBinRange(int idx, long binX, long binY, IntPtr range)
		{
			return vtkPairwiseExtractHistogram2D.vtkPairwiseExtractHistogram2D_GetBinRange_02(base.GetCppThis(), idx, binX, binY, range);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkPairwiseExtractHistogram2D_GetBinRange_03(HandleRef pThis, int idx, long bin, IntPtr range);

		public int GetBinRange(int idx, long bin, IntPtr range)
		{
			return vtkPairwiseExtractHistogram2D.vtkPairwiseExtractHistogram2D_GetBinRange_03(base.GetCppThis(), idx, bin, range);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkPairwiseExtractHistogram2D_GetBinWidth_04(HandleRef pThis, int idx, IntPtr bw);

		public void GetBinWidth(int idx, IntPtr bw)
		{
			vtkPairwiseExtractHistogram2D.vtkPairwiseExtractHistogram2D_GetBinWidth_04(base.GetCppThis(), idx, bw);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkPairwiseExtractHistogram2D_GetHistogramExtents_05(HandleRef pThis, int idx);

		public IntPtr GetHistogramExtents(int idx)
		{
			return vtkPairwiseExtractHistogram2D.vtkPairwiseExtractHistogram2D_GetHistogramExtents_05(base.GetCppThis(), idx);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkPairwiseExtractHistogram2D_GetHistogramFilter_06(HandleRef pThis, int idx, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkExtractHistogram2D GetHistogramFilter(int idx)
		{
			vtkExtractHistogram2D vtkExtractHistogram2D = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPairwiseExtractHistogram2D.vtkPairwiseExtractHistogram2D_GetHistogramFilter_06(base.GetCppThis(), idx, ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern double vtkPairwiseExtractHistogram2D_GetMaximumBinCount_07(HandleRef pThis, int idx);

		public double GetMaximumBinCount(int idx)
		{
			return vtkPairwiseExtractHistogram2D.vtkPairwiseExtractHistogram2D_GetMaximumBinCount_07(base.GetCppThis(), idx);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern double vtkPairwiseExtractHistogram2D_GetMaximumBinCount_08(HandleRef pThis);

		public double GetMaximumBinCount()
		{
			return vtkPairwiseExtractHistogram2D.vtkPairwiseExtractHistogram2D_GetMaximumBinCount_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkPairwiseExtractHistogram2D_GetNumberOfBins_09(HandleRef pThis);

		public virtual int[] GetNumberOfBins()
		{
			IntPtr intPtr = vtkPairwiseExtractHistogram2D.vtkPairwiseExtractHistogram2D_GetNumberOfBins_09(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkPairwiseExtractHistogram2D_GetNumberOfBins_10(HandleRef pThis, ref int _arg1, ref int _arg2);

		public virtual void GetNumberOfBins(ref int _arg1, ref int _arg2)
		{
			vtkPairwiseExtractHistogram2D.vtkPairwiseExtractHistogram2D_GetNumberOfBins_10(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkPairwiseExtractHistogram2D_GetNumberOfBins_11(HandleRef pThis, IntPtr _arg);

		public virtual void GetNumberOfBins(IntPtr _arg)
		{
			vtkPairwiseExtractHistogram2D.vtkPairwiseExtractHistogram2D_GetNumberOfBins_11(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkPairwiseExtractHistogram2D_GetOutputHistogramImage_12(HandleRef pThis, int idx, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkImageData GetOutputHistogramImage(int idx)
		{
			vtkImageData vtkImageData = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPairwiseExtractHistogram2D.vtkPairwiseExtractHistogram2D_GetOutputHistogramImage_12(base.GetCppThis(), idx, ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern int vtkPairwiseExtractHistogram2D_GetScalarType_13(HandleRef pThis);

		public virtual int GetScalarType()
		{
			return vtkPairwiseExtractHistogram2D.vtkPairwiseExtractHistogram2D_GetScalarType_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkPairwiseExtractHistogram2D_IsA_14(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkPairwiseExtractHistogram2D.vtkPairwiseExtractHistogram2D_IsA_14(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkPairwiseExtractHistogram2D_IsTypeOf_15(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkPairwiseExtractHistogram2D.vtkPairwiseExtractHistogram2D_IsTypeOf_15(type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkPairwiseExtractHistogram2D_NewInstance_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkPairwiseExtractHistogram2D NewInstance()
		{
			vtkPairwiseExtractHistogram2D result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPairwiseExtractHistogram2D.vtkPairwiseExtractHistogram2D_NewInstance_17(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPairwiseExtractHistogram2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkPairwiseExtractHistogram2D_SafeDownCast_18(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPairwiseExtractHistogram2D SafeDownCast(vtkObjectBase o)
		{
			vtkPairwiseExtractHistogram2D vtkPairwiseExtractHistogram2D = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPairwiseExtractHistogram2D.vtkPairwiseExtractHistogram2D_SafeDownCast_18((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPairwiseExtractHistogram2D = (vtkPairwiseExtractHistogram2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPairwiseExtractHistogram2D.Register(null);
				}
			}
			return vtkPairwiseExtractHistogram2D;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkPairwiseExtractHistogram2D_SetCustomColumnRange_19(HandleRef pThis, int col, IntPtr range);

		public void SetCustomColumnRange(int col, IntPtr range)
		{
			vtkPairwiseExtractHistogram2D.vtkPairwiseExtractHistogram2D_SetCustomColumnRange_19(base.GetCppThis(), col, range);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkPairwiseExtractHistogram2D_SetCustomColumnRange_20(HandleRef pThis, int col, double rmin, double rmax);

		public void SetCustomColumnRange(int col, double rmin, double rmax)
		{
			vtkPairwiseExtractHistogram2D.vtkPairwiseExtractHistogram2D_SetCustomColumnRange_20(base.GetCppThis(), col, rmin, rmax);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkPairwiseExtractHistogram2D_SetCustomColumnRangeByIndex_21(HandleRef pThis, double arg0, double arg1);

		public void SetCustomColumnRangeByIndex(double arg0, double arg1)
		{
			vtkPairwiseExtractHistogram2D.vtkPairwiseExtractHistogram2D_SetCustomColumnRangeByIndex_21(base.GetCppThis(), arg0, arg1);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkPairwiseExtractHistogram2D_SetCustomColumnRangeIndex_22(HandleRef pThis, int _arg);

		public virtual void SetCustomColumnRangeIndex(int _arg)
		{
			vtkPairwiseExtractHistogram2D.vtkPairwiseExtractHistogram2D_SetCustomColumnRangeIndex_22(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkPairwiseExtractHistogram2D_SetNumberOfBins_23(HandleRef pThis, int _arg1, int _arg2);

		public virtual void SetNumberOfBins(int _arg1, int _arg2)
		{
			vtkPairwiseExtractHistogram2D.vtkPairwiseExtractHistogram2D_SetNumberOfBins_23(base.GetCppThis(), _arg1, _arg2);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkPairwiseExtractHistogram2D_SetNumberOfBins_24(HandleRef pThis, IntPtr _arg);

		public void SetNumberOfBins(IntPtr _arg)
		{
			vtkPairwiseExtractHistogram2D.vtkPairwiseExtractHistogram2D_SetNumberOfBins_24(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkPairwiseExtractHistogram2D_SetScalarType_25(HandleRef pThis, int _arg);

		public virtual void SetScalarType(int _arg)
		{
			vtkPairwiseExtractHistogram2D.vtkPairwiseExtractHistogram2D_SetScalarType_25(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkPairwiseExtractHistogram2D_SetScalarTypeToUnsignedChar_26(HandleRef pThis);

		public void SetScalarTypeToUnsignedChar()
		{
			vtkPairwiseExtractHistogram2D.vtkPairwiseExtractHistogram2D_SetScalarTypeToUnsignedChar_26(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkPairwiseExtractHistogram2D_SetScalarTypeToUnsignedInt_27(HandleRef pThis);

		public void SetScalarTypeToUnsignedInt()
		{
			vtkPairwiseExtractHistogram2D.vtkPairwiseExtractHistogram2D_SetScalarTypeToUnsignedInt_27(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkPairwiseExtractHistogram2D_SetScalarTypeToUnsignedLong_28(HandleRef pThis);

		public void SetScalarTypeToUnsignedLong()
		{
			vtkPairwiseExtractHistogram2D.vtkPairwiseExtractHistogram2D_SetScalarTypeToUnsignedLong_28(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkPairwiseExtractHistogram2D_SetScalarTypeToUnsignedShort_29(HandleRef pThis);

		public void SetScalarTypeToUnsignedShort()
		{
			vtkPairwiseExtractHistogram2D.vtkPairwiseExtractHistogram2D_SetScalarTypeToUnsignedShort_29(base.GetCppThis());
		}
	}
}
