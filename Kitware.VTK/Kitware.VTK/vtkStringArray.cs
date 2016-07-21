using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkStringArray : vtkAbstractArray
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkStringArray";

		public new static readonly string MRClassNameKey;

		static vtkStringArray()
		{
			vtkStringArray.MRClassNameKey = "class vtkStringArray";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkStringArray.MRClassNameKey, Type.GetType("Kitware.VTK.vtkStringArray"));
		}

		public vtkStringArray(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkStringArray_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkStringArray New()
		{
			vtkStringArray result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkStringArray.vtkStringArray_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkStringArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkStringArray() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkStringArray.vtkStringArray_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkStringArray_Allocate_01(HandleRef pThis, long sz, long ext);

		public override int Allocate(long sz, long ext)
		{
			return vtkStringArray.vtkStringArray_Allocate_01(base.GetCppThis(), sz, ext);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkStringArray_ClearLookup_02(HandleRef pThis);

		public override void ClearLookup()
		{
			vtkStringArray.vtkStringArray_ClearLookup_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkStringArray_DataChanged_03(HandleRef pThis);

		public override void DataChanged()
		{
			vtkStringArray.vtkStringArray_DataChanged_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkStringArray_DataElementChanged_04(HandleRef pThis, long id);

		public virtual void DataElementChanged(long id)
		{
			vtkStringArray.vtkStringArray_DataElementChanged_04(base.GetCppThis(), id);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkStringArray_DeepCopy_05(HandleRef pThis, HandleRef aa);

		public override void DeepCopy(vtkAbstractArray aa)
		{
			vtkStringArray.vtkStringArray_DeepCopy_05(base.GetCppThis(), (aa == null) ? default(HandleRef) : aa.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern uint vtkStringArray_GetActualMemorySize_06(HandleRef pThis);

		public override uint GetActualMemorySize()
		{
			return vtkStringArray.vtkStringArray_GetActualMemorySize_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern long vtkStringArray_GetDataSize_07(HandleRef pThis);

		public override long GetDataSize()
		{
			return vtkStringArray.vtkStringArray_GetDataSize_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkStringArray_GetDataType_08(HandleRef pThis);

		public override int GetDataType()
		{
			return vtkStringArray.vtkStringArray_GetDataType_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkStringArray_GetDataTypeSize_09(HandleRef pThis);

		public override int GetDataTypeSize()
		{
			return vtkStringArray.vtkStringArray_GetDataTypeSize_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkStringArray_GetElementComponentSize_10(HandleRef pThis);

		public override int GetElementComponentSize()
		{
			return vtkStringArray.vtkStringArray_GetElementComponentSize_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkStringArray_GetNumberOfElementComponents_11(HandleRef pThis);

		public int GetNumberOfElementComponents()
		{
			return vtkStringArray.vtkStringArray_GetNumberOfElementComponents_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern long vtkStringArray_GetNumberOfValues_12(HandleRef pThis);

		public long GetNumberOfValues()
		{
			return vtkStringArray.vtkStringArray_GetNumberOfValues_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkStringArray_GetTuples_13(HandleRef pThis, HandleRef ptIds, HandleRef output);

		public override void GetTuples(vtkIdList ptIds, vtkAbstractArray output)
		{
			vtkStringArray.vtkStringArray_GetTuples_13(base.GetCppThis(), (ptIds == null) ? default(HandleRef) : ptIds.GetCppThis(), (output == null) ? default(HandleRef) : output.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkStringArray_GetTuples_14(HandleRef pThis, long p1, long p2, HandleRef output);

		public override void GetTuples(long p1, long p2, vtkAbstractArray output)
		{
			vtkStringArray.vtkStringArray_GetTuples_14(base.GetCppThis(), p1, p2, (output == null) ? default(HandleRef) : output.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkStringArray_GetVoidPointer_15(HandleRef pThis, long id);

		public override IntPtr GetVoidPointer(long id)
		{
			return vtkStringArray.vtkStringArray_GetVoidPointer_15(base.GetCppThis(), id);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkStringArray_Initialize_16(HandleRef pThis);

		public override void Initialize()
		{
			vtkStringArray.vtkStringArray_Initialize_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern long vtkStringArray_InsertNextTuple_17(HandleRef pThis, long j, HandleRef source);

		public override long InsertNextTuple(long j, vtkAbstractArray source)
		{
			return vtkStringArray.vtkStringArray_InsertNextTuple_17(base.GetCppThis(), j, (source == null) ? default(HandleRef) : source.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern long vtkStringArray_InsertNextValue_18(HandleRef pThis, string f);

		public long InsertNextValue(string f)
		{
			return vtkStringArray.vtkStringArray_InsertNextValue_18(base.GetCppThis(), f);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkStringArray_InsertTuple_19(HandleRef pThis, long i, long j, HandleRef source);

		public override void InsertTuple(long i, long j, vtkAbstractArray source)
		{
			vtkStringArray.vtkStringArray_InsertTuple_19(base.GetCppThis(), i, j, (source == null) ? default(HandleRef) : source.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkStringArray_InsertValue_20(HandleRef pThis, long id, string val);

		public void InsertValue(long id, string val)
		{
			vtkStringArray.vtkStringArray_InsertValue_20(base.GetCppThis(), id, val);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkStringArray_InterpolateTuple_21(HandleRef pThis, long i, HandleRef ptIndices, HandleRef source, IntPtr weights);

		public override void InterpolateTuple(long i, vtkIdList ptIndices, vtkAbstractArray source, IntPtr weights)
		{
			vtkStringArray.vtkStringArray_InterpolateTuple_21(base.GetCppThis(), i, (ptIndices == null) ? default(HandleRef) : ptIndices.GetCppThis(), (source == null) ? default(HandleRef) : source.GetCppThis(), weights);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkStringArray_InterpolateTuple_22(HandleRef pThis, long i, long id1, HandleRef source1, long id2, HandleRef source2, double t);

		public override void InterpolateTuple(long i, long id1, vtkAbstractArray source1, long id2, vtkAbstractArray source2, double t)
		{
			vtkStringArray.vtkStringArray_InterpolateTuple_22(base.GetCppThis(), i, id1, (source1 == null) ? default(HandleRef) : source1.GetCppThis(), id2, (source2 == null) ? default(HandleRef) : source2.GetCppThis(), t);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkStringArray_IsA_23(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkStringArray.vtkStringArray_IsA_23(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkStringArray_IsNumeric_24(HandleRef pThis);

		public override int IsNumeric()
		{
			return vtkStringArray.vtkStringArray_IsNumeric_24(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkStringArray_IsTypeOf_25(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkStringArray.vtkStringArray_IsTypeOf_25(type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern long vtkStringArray_LookupValue_26(HandleRef pThis, string value);

		public long LookupValue(string value)
		{
			return vtkStringArray.vtkStringArray_LookupValue_26(base.GetCppThis(), value);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkStringArray_LookupValue_27(HandleRef pThis, string value, HandleRef ids);

		public void LookupValue(string value, vtkIdList ids)
		{
			vtkStringArray.vtkStringArray_LookupValue_27(base.GetCppThis(), value, (ids == null) ? default(HandleRef) : ids.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkStringArray_NewInstance_29(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkStringArray NewInstance()
		{
			vtkStringArray result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkStringArray.vtkStringArray_NewInstance_29(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkStringArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkStringArray_NewIterator_30(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public override vtkArrayIterator NewIterator()
		{
			vtkArrayIterator vtkArrayIterator = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkStringArray.vtkStringArray_NewIterator_30(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern int vtkStringArray_Resize_31(HandleRef pThis, long numTuples);

		public override int Resize(long numTuples)
		{
			return vtkStringArray.vtkStringArray_Resize_31(base.GetCppThis(), numTuples);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkStringArray_SafeDownCast_32(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkStringArray SafeDownCast(vtkObjectBase o)
		{
			vtkStringArray vtkStringArray = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkStringArray.vtkStringArray_SafeDownCast_32((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkStringArray_SetNumberOfTuples_33(HandleRef pThis, long number);

		public override void SetNumberOfTuples(long number)
		{
			vtkStringArray.vtkStringArray_SetNumberOfTuples_33(base.GetCppThis(), number);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkStringArray_SetNumberOfValues_34(HandleRef pThis, long number);

		public void SetNumberOfValues(long number)
		{
			vtkStringArray.vtkStringArray_SetNumberOfValues_34(base.GetCppThis(), number);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkStringArray_SetTuple_35(HandleRef pThis, long i, long j, HandleRef source);

		public override void SetTuple(long i, long j, vtkAbstractArray source)
		{
			vtkStringArray.vtkStringArray_SetTuple_35(base.GetCppThis(), i, j, (source == null) ? default(HandleRef) : source.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkStringArray_SetValue_36(HandleRef pThis, long id, string value);

		public void SetValue(long id, string value)
		{
			vtkStringArray.vtkStringArray_SetValue_36(base.GetCppThis(), id, value);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkStringArray_SetVoidArray_37(HandleRef pThis, IntPtr array, long size, int save);

		public override void SetVoidArray(IntPtr array, long size, int save)
		{
			vtkStringArray.vtkStringArray_SetVoidArray_37(base.GetCppThis(), array, size, save);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkStringArray_Squeeze_38(HandleRef pThis);

		public override void Squeeze()
		{
			vtkStringArray.vtkStringArray_Squeeze_38(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern string vtkStringArray_GetValue(HandleRef pThis, long id);

		public string GetValue(long id)
		{
			return vtkStringArray.vtkStringArray_GetValue(base.GetCppThis(), id);
		}
	}
}
