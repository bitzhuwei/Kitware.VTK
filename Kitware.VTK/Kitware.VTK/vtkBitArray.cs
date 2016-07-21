using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkBitArray : vtkDataArray
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkBitArray";

		public new static readonly string MRClassNameKey;

		static vtkBitArray()
		{
			vtkBitArray.MRClassNameKey = "class vtkBitArray";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkBitArray.MRClassNameKey, Type.GetType("Kitware.VTK.vtkBitArray"));
		}

		public vtkBitArray(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkBitArray_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkBitArray New()
		{
			vtkBitArray result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkBitArray.vtkBitArray_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkBitArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkBitArray() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkBitArray.vtkBitArray_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkBitArray_Allocate_01(HandleRef pThis, long sz, long ext);

		public override int Allocate(long sz, long ext)
		{
			return vtkBitArray.vtkBitArray_Allocate_01(base.GetCppThis(), sz, ext);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkBitArray_ClearLookup_02(HandleRef pThis);

		public override void ClearLookup()
		{
			vtkBitArray.vtkBitArray_ClearLookup_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkBitArray_DataChanged_03(HandleRef pThis);

		public override void DataChanged()
		{
			vtkBitArray.vtkBitArray_DataChanged_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkBitArray_DeepCopy_04(HandleRef pThis, HandleRef da);

		public override void DeepCopy(vtkDataArray da)
		{
			vtkBitArray.vtkBitArray_DeepCopy_04(base.GetCppThis(), (da == null) ? default(HandleRef) : da.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkBitArray_DeepCopy_05(HandleRef pThis, HandleRef aa);

		public override void DeepCopy(vtkAbstractArray aa)
		{
			vtkBitArray.vtkBitArray_DeepCopy_05(base.GetCppThis(), (aa == null) ? default(HandleRef) : aa.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkBitArray_GetDataType_06(HandleRef pThis);

		public override int GetDataType()
		{
			return vtkBitArray.vtkBitArray_GetDataType_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkBitArray_GetDataTypeSize_07(HandleRef pThis);

		public override int GetDataTypeSize()
		{
			return vtkBitArray.vtkBitArray_GetDataTypeSize_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkBitArray_GetPointer_08(HandleRef pThis, long id);

		public IntPtr GetPointer(long id)
		{
			return vtkBitArray.vtkBitArray_GetPointer_08(base.GetCppThis(), id);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkBitArray_GetTuple_09(HandleRef pThis, long i);

		public override IntPtr GetTuple(long i)
		{
			return vtkBitArray.vtkBitArray_GetTuple_09(base.GetCppThis(), i);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkBitArray_GetTuple_10(HandleRef pThis, long i, IntPtr tuple);

		public override void GetTuple(long i, IntPtr tuple)
		{
			vtkBitArray.vtkBitArray_GetTuple_10(base.GetCppThis(), i, tuple);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkBitArray_GetValue_11(HandleRef pThis, long id);

		public int GetValue(long id)
		{
			return vtkBitArray.vtkBitArray_GetValue_11(base.GetCppThis(), id);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkBitArray_GetVoidPointer_12(HandleRef pThis, long id);

		public override IntPtr GetVoidPointer(long id)
		{
			return vtkBitArray.vtkBitArray_GetVoidPointer_12(base.GetCppThis(), id);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkBitArray_Initialize_13(HandleRef pThis);

		public override void Initialize()
		{
			vtkBitArray.vtkBitArray_Initialize_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkBitArray_InsertComponent_14(HandleRef pThis, long i, int j, double c);

		public override void InsertComponent(long i, int j, double c)
		{
			vtkBitArray.vtkBitArray_InsertComponent_14(base.GetCppThis(), i, j, c);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern long vtkBitArray_InsertNextTuple_15(HandleRef pThis, long j, HandleRef source);

		public override long InsertNextTuple(long j, vtkAbstractArray source)
		{
			return vtkBitArray.vtkBitArray_InsertNextTuple_15(base.GetCppThis(), j, (source == null) ? default(HandleRef) : source.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern long vtkBitArray_InsertNextTuple_16(HandleRef pThis, IntPtr tuple);

		public override long InsertNextTuple(IntPtr tuple)
		{
			return vtkBitArray.vtkBitArray_InsertNextTuple_16(base.GetCppThis(), tuple);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern long vtkBitArray_InsertNextValue_17(HandleRef pThis, int i);

		public long InsertNextValue(int i)
		{
			return vtkBitArray.vtkBitArray_InsertNextValue_17(base.GetCppThis(), i);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkBitArray_InsertTuple_18(HandleRef pThis, long i, long j, HandleRef source);

		public override void InsertTuple(long i, long j, vtkAbstractArray source)
		{
			vtkBitArray.vtkBitArray_InsertTuple_18(base.GetCppThis(), i, j, (source == null) ? default(HandleRef) : source.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkBitArray_InsertTuple_19(HandleRef pThis, long i, IntPtr tuple);

		public override void InsertTuple(long i, IntPtr tuple)
		{
			vtkBitArray.vtkBitArray_InsertTuple_19(base.GetCppThis(), i, tuple);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkBitArray_InsertValue_20(HandleRef pThis, long id, int i);

		public void InsertValue(long id, int i)
		{
			vtkBitArray.vtkBitArray_InsertValue_20(base.GetCppThis(), id, i);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkBitArray_IsA_21(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkBitArray.vtkBitArray_IsA_21(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkBitArray_IsTypeOf_22(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkBitArray.vtkBitArray_IsTypeOf_22(type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern long vtkBitArray_LookupValue_23(HandleRef pThis, int value);

		public long LookupValue(int value)
		{
			return vtkBitArray.vtkBitArray_LookupValue_23(base.GetCppThis(), value);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkBitArray_LookupValue_24(HandleRef pThis, int value, HandleRef ids);

		public void LookupValue(int value, vtkIdList ids)
		{
			vtkBitArray.vtkBitArray_LookupValue_24(base.GetCppThis(), value, (ids == null) ? default(HandleRef) : ids.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkBitArray_NewInstance_26(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkBitArray NewInstance()
		{
			vtkBitArray result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkBitArray.vtkBitArray_NewInstance_26(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkBitArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkBitArray_NewIterator_27(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public override vtkArrayIterator NewIterator()
		{
			vtkArrayIterator vtkArrayIterator = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkBitArray.vtkBitArray_NewIterator_27(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkArrayIterator = (vtkArrayIterator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkArrayIterator.Register(null);
				}
			}
			return vtkArrayIterator;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkBitArray_RemoveFirstTuple_28(HandleRef pThis);

		public override void RemoveFirstTuple()
		{
			vtkBitArray.vtkBitArray_RemoveFirstTuple_28(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkBitArray_RemoveLastTuple_29(HandleRef pThis);

		public override void RemoveLastTuple()
		{
			vtkBitArray.vtkBitArray_RemoveLastTuple_29(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkBitArray_RemoveTuple_30(HandleRef pThis, long id);

		public override void RemoveTuple(long id)
		{
			vtkBitArray.vtkBitArray_RemoveTuple_30(base.GetCppThis(), id);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkBitArray_Resize_31(HandleRef pThis, long numTuples);

		public override int Resize(long numTuples)
		{
			return vtkBitArray.vtkBitArray_Resize_31(base.GetCppThis(), numTuples);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkBitArray_SafeDownCast_32(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkBitArray SafeDownCast(vtkObjectBase o)
		{
			vtkBitArray vtkBitArray = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkBitArray.vtkBitArray_SafeDownCast_32((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkBitArray = (vtkBitArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkBitArray.Register(null);
				}
			}
			return vtkBitArray;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkBitArray_SetArray_33(HandleRef pThis, IntPtr array, long size, int save);

		public void SetArray(IntPtr array, long size, int save)
		{
			vtkBitArray.vtkBitArray_SetArray_33(base.GetCppThis(), array, size, save);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkBitArray_SetComponent_34(HandleRef pThis, long i, int j, double c);

		public override void SetComponent(long i, int j, double c)
		{
			vtkBitArray.vtkBitArray_SetComponent_34(base.GetCppThis(), i, j, c);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkBitArray_SetNumberOfTuples_35(HandleRef pThis, long number);

		public override void SetNumberOfTuples(long number)
		{
			vtkBitArray.vtkBitArray_SetNumberOfTuples_35(base.GetCppThis(), number);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkBitArray_SetNumberOfValues_36(HandleRef pThis, long number);

		public void SetNumberOfValues(long number)
		{
			vtkBitArray.vtkBitArray_SetNumberOfValues_36(base.GetCppThis(), number);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkBitArray_SetTuple_37(HandleRef pThis, long i, long j, HandleRef source);

		public override void SetTuple(long i, long j, vtkAbstractArray source)
		{
			vtkBitArray.vtkBitArray_SetTuple_37(base.GetCppThis(), i, j, (source == null) ? default(HandleRef) : source.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkBitArray_SetTuple_38(HandleRef pThis, long i, IntPtr tuple);

		public override void SetTuple(long i, IntPtr tuple)
		{
			vtkBitArray.vtkBitArray_SetTuple_38(base.GetCppThis(), i, tuple);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkBitArray_SetValue_39(HandleRef pThis, long id, int value);

		public void SetValue(long id, int value)
		{
			vtkBitArray.vtkBitArray_SetValue_39(base.GetCppThis(), id, value);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkBitArray_SetVoidArray_40(HandleRef pThis, IntPtr array, long size, int save);

		public override void SetVoidArray(IntPtr array, long size, int save)
		{
			vtkBitArray.vtkBitArray_SetVoidArray_40(base.GetCppThis(), array, size, save);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkBitArray_Squeeze_41(HandleRef pThis);

		public override void Squeeze()
		{
			vtkBitArray.vtkBitArray_Squeeze_41(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkBitArray_WritePointer_42(HandleRef pThis, long id, long number);

		public IntPtr WritePointer(long id, long number)
		{
			return vtkBitArray.vtkBitArray_WritePointer_42(base.GetCppThis(), id, number);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkBitArray_WriteVoidPointer_43(HandleRef pThis, long id, long number);

		public override IntPtr WriteVoidPointer(long id, long number)
		{
			return vtkBitArray.vtkBitArray_WriteVoidPointer_43(base.GetCppThis(), id, number);
		}
	}
}
