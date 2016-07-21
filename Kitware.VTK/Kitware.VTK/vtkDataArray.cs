using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public abstract class vtkDataArray : vtkAbstractArray
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkDataArray";

		public new static readonly string MRClassNameKey;

		static vtkDataArray()
		{
			vtkDataArray.MRClassNameKey = "class vtkDataArray";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDataArray.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDataArray"));
		}

		public vtkDataArray(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkDataArray_COMPONENT_RANGE_01(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public static vtkInformationDoubleVectorKey COMPONENT_RANGE()
		{
			vtkInformationDoubleVectorKey vtkInformationDoubleVectorKey = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDataArray.vtkDataArray_COMPONENT_RANGE_01(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationDoubleVectorKey = (vtkInformationDoubleVectorKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationDoubleVectorKey.Register(null);
				}
			}
			return vtkInformationDoubleVectorKey;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkDataArray_CopyComponent_02(HandleRef pThis, int j, HandleRef from, int fromComponent);

		public virtual void CopyComponent(int j, vtkDataArray from, int fromComponent)
		{
			vtkDataArray.vtkDataArray_CopyComponent_02(base.GetCppThis(), j, (from == null) ? default(HandleRef) : from.GetCppThis(), fromComponent);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkDataArray_CopyInformation_03(HandleRef pThis, HandleRef infoFrom, int deep);

		public override int CopyInformation(vtkInformation infoFrom, int deep)
		{
			return vtkDataArray.vtkDataArray_CopyInformation_03(base.GetCppThis(), (infoFrom == null) ? default(HandleRef) : infoFrom.GetCppThis(), deep);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkDataArray_CreateDataArray_04(int dataType, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public static vtkDataArray CreateDataArray(int dataType)
		{
			vtkDataArray vtkDataArray = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDataArray.vtkDataArray_CreateDataArray_04(dataType, ref mteStatus, ref mteIndex, ref rawRefCount);
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

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkDataArray_CreateDefaultLookupTable_05(HandleRef pThis);

		public void CreateDefaultLookupTable()
		{
			vtkDataArray.vtkDataArray_CreateDefaultLookupTable_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkDataArray_DeepCopy_06(HandleRef pThis, HandleRef aa);

		public override void DeepCopy(vtkAbstractArray aa)
		{
			vtkDataArray.vtkDataArray_DeepCopy_06(base.GetCppThis(), (aa == null) ? default(HandleRef) : aa.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkDataArray_DeepCopy_07(HandleRef pThis, HandleRef da);

		public virtual void DeepCopy(vtkDataArray da)
		{
			vtkDataArray.vtkDataArray_DeepCopy_07(base.GetCppThis(), (da == null) ? default(HandleRef) : da.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkDataArray_FillComponent_08(HandleRef pThis, int j, double c);

		public virtual void FillComponent(int j, double c)
		{
			vtkDataArray.vtkDataArray_FillComponent_08(base.GetCppThis(), j, c);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern uint vtkDataArray_GetActualMemorySize_09(HandleRef pThis);

		public override uint GetActualMemorySize()
		{
			return vtkDataArray.vtkDataArray_GetActualMemorySize_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern double vtkDataArray_GetComponent_10(HandleRef pThis, long i, int j);

		public virtual double GetComponent(long i, int j)
		{
			return vtkDataArray.vtkDataArray_GetComponent_10(base.GetCppThis(), i, j);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkDataArray_GetData_11(HandleRef pThis, long tupleMin, long tupleMax, int compMin, int compMax, HandleRef data);

		public virtual void GetData(long tupleMin, long tupleMax, int compMin, int compMax, vtkDoubleArray data)
		{
			vtkDataArray.vtkDataArray_GetData_11(base.GetCppThis(), tupleMin, tupleMax, compMin, compMax, (data == null) ? default(HandleRef) : data.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern double vtkDataArray_GetDataTypeMax_12(HandleRef pThis);

		public double GetDataTypeMax()
		{
			return vtkDataArray.vtkDataArray_GetDataTypeMax_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern double vtkDataArray_GetDataTypeMax_13(int type);

		public static double GetDataTypeMax(int type)
		{
			return vtkDataArray.vtkDataArray_GetDataTypeMax_13(type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern double vtkDataArray_GetDataTypeMin_14(HandleRef pThis);

		public double GetDataTypeMin()
		{
			return vtkDataArray.vtkDataArray_GetDataTypeMin_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern double vtkDataArray_GetDataTypeMin_15(int type);

		public static double GetDataTypeMin(int type)
		{
			return vtkDataArray.vtkDataArray_GetDataTypeMin_15(type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkDataArray_GetDataTypeRange_16(HandleRef pThis, IntPtr range);

		public void GetDataTypeRange(IntPtr range)
		{
			vtkDataArray.vtkDataArray_GetDataTypeRange_16(base.GetCppThis(), range);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkDataArray_GetDataTypeRange_17(int type, IntPtr range);

		public static void GetDataTypeRange(int type, IntPtr range)
		{
			vtkDataArray.vtkDataArray_GetDataTypeRange_17(type, range);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkDataArray_GetElementComponentSize_18(HandleRef pThis);

		public override int GetElementComponentSize()
		{
			return vtkDataArray.vtkDataArray_GetElementComponentSize_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkDataArray_GetLookupTable_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkLookupTable GetLookupTable()
		{
			vtkLookupTable vtkLookupTable = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDataArray.vtkDataArray_GetLookupTable_19(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkLookupTable = (vtkLookupTable)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkLookupTable.Register(null);
				}
			}
			return vtkLookupTable;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern double vtkDataArray_GetMaxNorm_20(HandleRef pThis);

		public virtual double GetMaxNorm()
		{
			return vtkDataArray.vtkDataArray_GetMaxNorm_20(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkDataArray_GetRange_21(HandleRef pThis, IntPtr range, int comp);

		public void GetRange(IntPtr range, int comp)
		{
			vtkDataArray.vtkDataArray_GetRange_21(base.GetCppThis(), range, comp);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkDataArray_GetRange_22(HandleRef pThis, int comp);

		public double[] GetRange(int comp)
		{
			IntPtr intPtr = vtkDataArray.vtkDataArray_GetRange_22(base.GetCppThis(), comp);
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkDataArray_GetRange_23(HandleRef pThis);

		public double[] GetRange()
		{
			IntPtr intPtr = vtkDataArray.vtkDataArray_GetRange_23(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkDataArray_GetRange_24(HandleRef pThis, IntPtr range);

		public void GetRange(IntPtr range)
		{
			vtkDataArray.vtkDataArray_GetRange_24(base.GetCppThis(), range);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkDataArray_GetTuple_25(HandleRef pThis, long i);

		public virtual IntPtr GetTuple(long i)
		{
			return vtkDataArray.vtkDataArray_GetTuple_25(base.GetCppThis(), i);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkDataArray_GetTuple_26(HandleRef pThis, long i, IntPtr tuple);

		public virtual void GetTuple(long i, IntPtr tuple)
		{
			vtkDataArray.vtkDataArray_GetTuple_26(base.GetCppThis(), i, tuple);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern double vtkDataArray_GetTuple1_27(HandleRef pThis, long i);

		public double GetTuple1(long i)
		{
			return vtkDataArray.vtkDataArray_GetTuple1_27(base.GetCppThis(), i);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkDataArray_GetTuple2_28(HandleRef pThis, long i);

		public double[] GetTuple2(long i)
		{
			IntPtr intPtr = vtkDataArray.vtkDataArray_GetTuple2_28(base.GetCppThis(), i);
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkDataArray_GetTuple3_29(HandleRef pThis, long i);

		public double[] GetTuple3(long i)
		{
			IntPtr intPtr = vtkDataArray.vtkDataArray_GetTuple3_29(base.GetCppThis(), i);
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkDataArray_GetTuple4_30(HandleRef pThis, long i);

		public double[] GetTuple4(long i)
		{
			IntPtr intPtr = vtkDataArray.vtkDataArray_GetTuple4_30(base.GetCppThis(), i);
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[4];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkDataArray_GetTuple9_31(HandleRef pThis, long i);

		public double[] GetTuple9(long i)
		{
			IntPtr intPtr = vtkDataArray.vtkDataArray_GetTuple9_31(base.GetCppThis(), i);
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[9];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkDataArray_GetTuples_32(HandleRef pThis, HandleRef ptIds, HandleRef output);

		public override void GetTuples(vtkIdList ptIds, vtkAbstractArray output)
		{
			vtkDataArray.vtkDataArray_GetTuples_32(base.GetCppThis(), (ptIds == null) ? default(HandleRef) : ptIds.GetCppThis(), (output == null) ? default(HandleRef) : output.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkDataArray_GetTuples_33(HandleRef pThis, long p1, long p2, HandleRef output);

		public override void GetTuples(long p1, long p2, vtkAbstractArray output)
		{
			vtkDataArray.vtkDataArray_GetTuples_33(base.GetCppThis(), p1, p2, (output == null) ? default(HandleRef) : output.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkDataArray_InsertComponent_34(HandleRef pThis, long i, int j, double c);

		public virtual void InsertComponent(long i, int j, double c)
		{
			vtkDataArray.vtkDataArray_InsertComponent_34(base.GetCppThis(), i, j, c);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern long vtkDataArray_InsertNextTuple_35(HandleRef pThis, long j, HandleRef source);

		public override long InsertNextTuple(long j, vtkAbstractArray source)
		{
			return vtkDataArray.vtkDataArray_InsertNextTuple_35(base.GetCppThis(), j, (source == null) ? default(HandleRef) : source.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern long vtkDataArray_InsertNextTuple_36(HandleRef pThis, IntPtr tuple);

		public virtual long InsertNextTuple(IntPtr tuple)
		{
			return vtkDataArray.vtkDataArray_InsertNextTuple_36(base.GetCppThis(), tuple);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkDataArray_InsertNextTuple1_37(HandleRef pThis, double value);

		public void InsertNextTuple1(double value)
		{
			vtkDataArray.vtkDataArray_InsertNextTuple1_37(base.GetCppThis(), value);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkDataArray_InsertNextTuple2_38(HandleRef pThis, double val0, double val1);

		public void InsertNextTuple2(double val0, double val1)
		{
			vtkDataArray.vtkDataArray_InsertNextTuple2_38(base.GetCppThis(), val0, val1);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkDataArray_InsertNextTuple3_39(HandleRef pThis, double val0, double val1, double val2);

		public void InsertNextTuple3(double val0, double val1, double val2)
		{
			vtkDataArray.vtkDataArray_InsertNextTuple3_39(base.GetCppThis(), val0, val1, val2);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkDataArray_InsertNextTuple4_40(HandleRef pThis, double val0, double val1, double val2, double val3);

		public void InsertNextTuple4(double val0, double val1, double val2, double val3)
		{
			vtkDataArray.vtkDataArray_InsertNextTuple4_40(base.GetCppThis(), val0, val1, val2, val3);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkDataArray_InsertNextTuple9_41(HandleRef pThis, double val0, double val1, double val2, double val3, double val4, double val5, double val6, double val7, double val8);

		public void InsertNextTuple9(double val0, double val1, double val2, double val3, double val4, double val5, double val6, double val7, double val8)
		{
			vtkDataArray.vtkDataArray_InsertNextTuple9_41(base.GetCppThis(), val0, val1, val2, val3, val4, val5, val6, val7, val8);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkDataArray_InsertTuple_42(HandleRef pThis, long i, long j, HandleRef source);

		public override void InsertTuple(long i, long j, vtkAbstractArray source)
		{
			vtkDataArray.vtkDataArray_InsertTuple_42(base.GetCppThis(), i, j, (source == null) ? default(HandleRef) : source.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkDataArray_InsertTuple_43(HandleRef pThis, long i, IntPtr tuple);

		public virtual void InsertTuple(long i, IntPtr tuple)
		{
			vtkDataArray.vtkDataArray_InsertTuple_43(base.GetCppThis(), i, tuple);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkDataArray_InsertTuple1_44(HandleRef pThis, long i, double value);

		public void InsertTuple1(long i, double value)
		{
			vtkDataArray.vtkDataArray_InsertTuple1_44(base.GetCppThis(), i, value);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkDataArray_InsertTuple2_45(HandleRef pThis, long i, double val0, double val1);

		public void InsertTuple2(long i, double val0, double val1)
		{
			vtkDataArray.vtkDataArray_InsertTuple2_45(base.GetCppThis(), i, val0, val1);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkDataArray_InsertTuple3_46(HandleRef pThis, long i, double val0, double val1, double val2);

		public void InsertTuple3(long i, double val0, double val1, double val2)
		{
			vtkDataArray.vtkDataArray_InsertTuple3_46(base.GetCppThis(), i, val0, val1, val2);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkDataArray_InsertTuple4_47(HandleRef pThis, long i, double val0, double val1, double val2, double val3);

		public void InsertTuple4(long i, double val0, double val1, double val2, double val3)
		{
			vtkDataArray.vtkDataArray_InsertTuple4_47(base.GetCppThis(), i, val0, val1, val2, val3);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkDataArray_InsertTuple9_48(HandleRef pThis, long i, double val0, double val1, double val2, double val3, double val4, double val5, double val6, double val7, double val8);

		public void InsertTuple9(long i, double val0, double val1, double val2, double val3, double val4, double val5, double val6, double val7, double val8)
		{
			vtkDataArray.vtkDataArray_InsertTuple9_48(base.GetCppThis(), i, val0, val1, val2, val3, val4, val5, val6, val7, val8);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkDataArray_InterpolateTuple_49(HandleRef pThis, long i, HandleRef ptIndices, HandleRef source, IntPtr weights);

		public override void InterpolateTuple(long i, vtkIdList ptIndices, vtkAbstractArray source, IntPtr weights)
		{
			vtkDataArray.vtkDataArray_InterpolateTuple_49(base.GetCppThis(), i, (ptIndices == null) ? default(HandleRef) : ptIndices.GetCppThis(), (source == null) ? default(HandleRef) : source.GetCppThis(), weights);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkDataArray_InterpolateTuple_50(HandleRef pThis, long i, long id1, HandleRef source1, long id2, HandleRef source2, double t);

		public override void InterpolateTuple(long i, long id1, vtkAbstractArray source1, long id2, vtkAbstractArray source2, double t)
		{
			vtkDataArray.vtkDataArray_InterpolateTuple_50(base.GetCppThis(), i, id1, (source1 == null) ? default(HandleRef) : source1.GetCppThis(), id2, (source2 == null) ? default(HandleRef) : source2.GetCppThis(), t);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkDataArray_IsA_51(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkDataArray.vtkDataArray_IsA_51(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkDataArray_IsNumeric_52(HandleRef pThis);

		public override int IsNumeric()
		{
			return vtkDataArray.vtkDataArray_IsNumeric_52(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkDataArray_IsTypeOf_53(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkDataArray.vtkDataArray_IsTypeOf_53(type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkDataArray_L2_NORM_RANGE_54(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public static vtkInformationDoubleVectorKey L2_NORM_RANGE()
		{
			vtkInformationDoubleVectorKey vtkInformationDoubleVectorKey = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDataArray.vtkDataArray_L2_NORM_RANGE_54(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationDoubleVectorKey = (vtkInformationDoubleVectorKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationDoubleVectorKey.Register(null);
				}
			}
			return vtkInformationDoubleVectorKey;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkDataArray_NewInstance_55(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkDataArray NewInstance()
		{
			vtkDataArray result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDataArray.vtkDataArray_NewInstance_55(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDataArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkDataArray_PER_COMPONENT_56(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public static vtkInformationInformationVectorKey PER_COMPONENT()
		{
			vtkInformationInformationVectorKey vtkInformationInformationVectorKey = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDataArray.vtkDataArray_PER_COMPONENT_56(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationInformationVectorKey = (vtkInformationInformationVectorKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationInformationVectorKey.Register(null);
				}
			}
			return vtkInformationInformationVectorKey;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkDataArray_RemoveFirstTuple_57(HandleRef pThis);

		public virtual void RemoveFirstTuple()
		{
			vtkDataArray.vtkDataArray_RemoveFirstTuple_57(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkDataArray_RemoveLastTuple_58(HandleRef pThis);

		public virtual void RemoveLastTuple()
		{
			vtkDataArray.vtkDataArray_RemoveLastTuple_58(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkDataArray_RemoveTuple_59(HandleRef pThis, long id);

		public virtual void RemoveTuple(long id)
		{
			vtkDataArray.vtkDataArray_RemoveTuple_59(base.GetCppThis(), id);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkDataArray_SafeDownCast_60(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkDataArray SafeDownCast(vtkObjectBase o)
		{
			vtkDataArray vtkDataArray = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDataArray.vtkDataArray_SafeDownCast_60((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkDataArray_SetComponent_61(HandleRef pThis, long i, int j, double c);

		public virtual void SetComponent(long i, int j, double c)
		{
			vtkDataArray.vtkDataArray_SetComponent_61(base.GetCppThis(), i, j, c);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkDataArray_SetLookupTable_62(HandleRef pThis, HandleRef lut);

		public void SetLookupTable(vtkLookupTable lut)
		{
			vtkDataArray.vtkDataArray_SetLookupTable_62(base.GetCppThis(), (lut == null) ? default(HandleRef) : lut.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkDataArray_SetTuple_63(HandleRef pThis, long i, long j, HandleRef source);

		public override void SetTuple(long i, long j, vtkAbstractArray source)
		{
			vtkDataArray.vtkDataArray_SetTuple_63(base.GetCppThis(), i, j, (source == null) ? default(HandleRef) : source.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkDataArray_SetTuple_64(HandleRef pThis, long i, IntPtr tuple);

		public virtual void SetTuple(long i, IntPtr tuple)
		{
			vtkDataArray.vtkDataArray_SetTuple_64(base.GetCppThis(), i, tuple);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkDataArray_SetTuple1_65(HandleRef pThis, long i, double value);

		public void SetTuple1(long i, double value)
		{
			vtkDataArray.vtkDataArray_SetTuple1_65(base.GetCppThis(), i, value);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkDataArray_SetTuple2_66(HandleRef pThis, long i, double val0, double val1);

		public void SetTuple2(long i, double val0, double val1)
		{
			vtkDataArray.vtkDataArray_SetTuple2_66(base.GetCppThis(), i, val0, val1);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkDataArray_SetTuple3_67(HandleRef pThis, long i, double val0, double val1, double val2);

		public void SetTuple3(long i, double val0, double val1, double val2)
		{
			vtkDataArray.vtkDataArray_SetTuple3_67(base.GetCppThis(), i, val0, val1, val2);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkDataArray_SetTuple4_68(HandleRef pThis, long i, double val0, double val1, double val2, double val3);

		public void SetTuple4(long i, double val0, double val1, double val2, double val3)
		{
			vtkDataArray.vtkDataArray_SetTuple4_68(base.GetCppThis(), i, val0, val1, val2, val3);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkDataArray_SetTuple9_69(HandleRef pThis, long i, double val0, double val1, double val2, double val3, double val4, double val5, double val6, double val7, double val8);

		public void SetTuple9(long i, double val0, double val1, double val2, double val3, double val4, double val5, double val6, double val7, double val8)
		{
			vtkDataArray.vtkDataArray_SetTuple9_69(base.GetCppThis(), i, val0, val1, val2, val3, val4, val5, val6, val7, val8);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkDataArray_WriteVoidPointer_70(HandleRef pThis, long id, long number);

		public virtual IntPtr WriteVoidPointer(long id, long number)
		{
			return vtkDataArray.vtkDataArray_WriteVoidPointer_70(base.GetCppThis(), id, number);
		}
	}
}
