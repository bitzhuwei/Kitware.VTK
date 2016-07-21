using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkVariantArray : vtkAbstractArray
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkVariantArray";

		public new static readonly string MRClassNameKey;

		static vtkVariantArray()
		{
			vtkVariantArray.MRClassNameKey = "class vtkVariantArray";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkVariantArray.MRClassNameKey, Type.GetType("Kitware.VTK.vtkVariantArray"));
		}

		public vtkVariantArray(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkVariantArray_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkVariantArray New()
		{
			vtkVariantArray result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkVariantArray.vtkVariantArray_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVariantArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkVariantArray() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkVariantArray.vtkVariantArray_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkVariantArray_Allocate_01(HandleRef pThis, long sz, long ext);

		public override int Allocate(long sz, long ext)
		{
			return vtkVariantArray.vtkVariantArray_Allocate_01(base.GetCppThis(), sz, ext);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkVariantArray_ClearLookup_02(HandleRef pThis);

		public override void ClearLookup()
		{
			vtkVariantArray.vtkVariantArray_ClearLookup_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkVariantArray_DataChanged_03(HandleRef pThis);

		public override void DataChanged()
		{
			vtkVariantArray.vtkVariantArray_DataChanged_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkVariantArray_DataElementChanged_04(HandleRef pThis, long id);

		public virtual void DataElementChanged(long id)
		{
			vtkVariantArray.vtkVariantArray_DataElementChanged_04(base.GetCppThis(), id);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkVariantArray_DeepCopy_05(HandleRef pThis, HandleRef da);

		public override void DeepCopy(vtkAbstractArray da)
		{
			vtkVariantArray.vtkVariantArray_DeepCopy_05(base.GetCppThis(), (da == null) ? default(HandleRef) : da.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern uint vtkVariantArray_GetActualMemorySize_06(HandleRef pThis);

		public override uint GetActualMemorySize()
		{
			return vtkVariantArray.vtkVariantArray_GetActualMemorySize_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkVariantArray_GetDataType_07(HandleRef pThis);

		public override int GetDataType()
		{
			return vtkVariantArray.vtkVariantArray_GetDataType_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkVariantArray_GetDataTypeSize_08(HandleRef pThis);

		public override int GetDataTypeSize()
		{
			return vtkVariantArray.vtkVariantArray_GetDataTypeSize_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkVariantArray_GetElementComponentSize_09(HandleRef pThis);

		public override int GetElementComponentSize()
		{
			return vtkVariantArray.vtkVariantArray_GetElementComponentSize_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern long vtkVariantArray_GetNumberOfValues_10(HandleRef pThis);

		public long GetNumberOfValues()
		{
			return vtkVariantArray.vtkVariantArray_GetNumberOfValues_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkVariantArray_GetVoidPointer_11(HandleRef pThis, long id);

		public override IntPtr GetVoidPointer(long id)
		{
			return vtkVariantArray.vtkVariantArray_GetVoidPointer_11(base.GetCppThis(), id);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkVariantArray_Initialize_12(HandleRef pThis);

		public override void Initialize()
		{
			vtkVariantArray.vtkVariantArray_Initialize_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern long vtkVariantArray_InsertNextTuple_13(HandleRef pThis, long j, HandleRef source);

		public override long InsertNextTuple(long j, vtkAbstractArray source)
		{
			return vtkVariantArray.vtkVariantArray_InsertNextTuple_13(base.GetCppThis(), j, (source == null) ? default(HandleRef) : source.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkVariantArray_InsertTuple_14(HandleRef pThis, long i, long j, HandleRef source);

		public override void InsertTuple(long i, long j, vtkAbstractArray source)
		{
			vtkVariantArray.vtkVariantArray_InsertTuple_14(base.GetCppThis(), i, j, (source == null) ? default(HandleRef) : source.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkVariantArray_InterpolateTuple_15(HandleRef pThis, long i, HandleRef ptIndices, HandleRef source, IntPtr weights);

		public override void InterpolateTuple(long i, vtkIdList ptIndices, vtkAbstractArray source, IntPtr weights)
		{
			vtkVariantArray.vtkVariantArray_InterpolateTuple_15(base.GetCppThis(), i, (ptIndices == null) ? default(HandleRef) : ptIndices.GetCppThis(), (source == null) ? default(HandleRef) : source.GetCppThis(), weights);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkVariantArray_InterpolateTuple_16(HandleRef pThis, long i, long id1, HandleRef source1, long id2, HandleRef source2, double t);

		public override void InterpolateTuple(long i, long id1, vtkAbstractArray source1, long id2, vtkAbstractArray source2, double t)
		{
			vtkVariantArray.vtkVariantArray_InterpolateTuple_16(base.GetCppThis(), i, id1, (source1 == null) ? default(HandleRef) : source1.GetCppThis(), id2, (source2 == null) ? default(HandleRef) : source2.GetCppThis(), t);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkVariantArray_IsA_17(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkVariantArray.vtkVariantArray_IsA_17(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkVariantArray_IsNumeric_18(HandleRef pThis);

		public override int IsNumeric()
		{
			return vtkVariantArray.vtkVariantArray_IsNumeric_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkVariantArray_IsTypeOf_19(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkVariantArray.vtkVariantArray_IsTypeOf_19(type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkVariantArray_NewInstance_21(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkVariantArray NewInstance()
		{
			vtkVariantArray result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkVariantArray.vtkVariantArray_NewInstance_21(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVariantArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkVariantArray_NewIterator_22(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public override vtkArrayIterator NewIterator()
		{
			vtkArrayIterator vtkArrayIterator = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkVariantArray.vtkVariantArray_NewIterator_22(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern int vtkVariantArray_Resize_23(HandleRef pThis, long numTuples);

		public override int Resize(long numTuples)
		{
			return vtkVariantArray.vtkVariantArray_Resize_23(base.GetCppThis(), numTuples);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkVariantArray_SafeDownCast_24(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkVariantArray SafeDownCast(vtkObjectBase o)
		{
			vtkVariantArray vtkVariantArray = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkVariantArray.vtkVariantArray_SafeDownCast_24((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkVariantArray = (vtkVariantArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkVariantArray.Register(null);
				}
			}
			return vtkVariantArray;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkVariantArray_SetNumberOfTuples_25(HandleRef pThis, long number);

		public override void SetNumberOfTuples(long number)
		{
			vtkVariantArray.vtkVariantArray_SetNumberOfTuples_25(base.GetCppThis(), number);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkVariantArray_SetNumberOfValues_26(HandleRef pThis, long number);

		public void SetNumberOfValues(long number)
		{
			vtkVariantArray.vtkVariantArray_SetNumberOfValues_26(base.GetCppThis(), number);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkVariantArray_SetTuple_27(HandleRef pThis, long i, long j, HandleRef source);

		public override void SetTuple(long i, long j, vtkAbstractArray source)
		{
			vtkVariantArray.vtkVariantArray_SetTuple_27(base.GetCppThis(), i, j, (source == null) ? default(HandleRef) : source.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkVariantArray_SetVoidArray_28(HandleRef pThis, IntPtr arr, long size, int save);

		public override void SetVoidArray(IntPtr arr, long size, int save)
		{
			vtkVariantArray.vtkVariantArray_SetVoidArray_28(base.GetCppThis(), arr, size, save);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkVariantArray_Squeeze_29(HandleRef pThis);

		public override void Squeeze()
		{
			vtkVariantArray.vtkVariantArray_Squeeze_29(base.GetCppThis());
		}
	}
}
