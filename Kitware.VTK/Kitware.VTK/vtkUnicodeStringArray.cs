using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkUnicodeStringArray : vtkAbstractArray
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkUnicodeStringArray";

		public new static readonly string MRClassNameKey;

		static vtkUnicodeStringArray()
		{
			vtkUnicodeStringArray.MRClassNameKey = "class vtkUnicodeStringArray";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkUnicodeStringArray.MRClassNameKey, Type.GetType("Kitware.VTK.vtkUnicodeStringArray"));
		}

		public vtkUnicodeStringArray(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkUnicodeStringArray_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkUnicodeStringArray New()
		{
			vtkUnicodeStringArray result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkUnicodeStringArray.vtkUnicodeStringArray_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkUnicodeStringArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkUnicodeStringArray() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkUnicodeStringArray.vtkUnicodeStringArray_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkUnicodeStringArray_Allocate_01(HandleRef pThis, long sz, long ext);

		public override int Allocate(long sz, long ext)
		{
			return vtkUnicodeStringArray.vtkUnicodeStringArray_Allocate_01(base.GetCppThis(), sz, ext);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkUnicodeStringArray_ClearLookup_02(HandleRef pThis);

		public override void ClearLookup()
		{
			vtkUnicodeStringArray.vtkUnicodeStringArray_ClearLookup_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkUnicodeStringArray_DataChanged_03(HandleRef pThis);

		public override void DataChanged()
		{
			vtkUnicodeStringArray.vtkUnicodeStringArray_DataChanged_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkUnicodeStringArray_DeepCopy_04(HandleRef pThis, HandleRef da);

		public override void DeepCopy(vtkAbstractArray da)
		{
			vtkUnicodeStringArray.vtkUnicodeStringArray_DeepCopy_04(base.GetCppThis(), (da == null) ? default(HandleRef) : da.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern uint vtkUnicodeStringArray_GetActualMemorySize_05(HandleRef pThis);

		public override uint GetActualMemorySize()
		{
			return vtkUnicodeStringArray.vtkUnicodeStringArray_GetActualMemorySize_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkUnicodeStringArray_GetDataType_06(HandleRef pThis);

		public override int GetDataType()
		{
			return vtkUnicodeStringArray.vtkUnicodeStringArray_GetDataType_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkUnicodeStringArray_GetDataTypeSize_07(HandleRef pThis);

		public override int GetDataTypeSize()
		{
			return vtkUnicodeStringArray.vtkUnicodeStringArray_GetDataTypeSize_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkUnicodeStringArray_GetElementComponentSize_08(HandleRef pThis);

		public override int GetElementComponentSize()
		{
			return vtkUnicodeStringArray.vtkUnicodeStringArray_GetElementComponentSize_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkUnicodeStringArray_GetUTF8Value_09(HandleRef pThis, long i);

		public string GetUTF8Value(long i)
		{
			return Marshal.PtrToStringAnsi(vtkUnicodeStringArray.vtkUnicodeStringArray_GetUTF8Value_09(base.GetCppThis(), i));
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkUnicodeStringArray_GetVoidPointer_10(HandleRef pThis, long id);

		public override IntPtr GetVoidPointer(long id)
		{
			return vtkUnicodeStringArray.vtkUnicodeStringArray_GetVoidPointer_10(base.GetCppThis(), id);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkUnicodeStringArray_Initialize_11(HandleRef pThis);

		public override void Initialize()
		{
			vtkUnicodeStringArray.vtkUnicodeStringArray_Initialize_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern long vtkUnicodeStringArray_InsertNextTuple_12(HandleRef pThis, long j, HandleRef source);

		public override long InsertNextTuple(long j, vtkAbstractArray source)
		{
			return vtkUnicodeStringArray.vtkUnicodeStringArray_InsertNextTuple_12(base.GetCppThis(), j, (source == null) ? default(HandleRef) : source.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkUnicodeStringArray_InsertNextUTF8Value_13(HandleRef pThis, string arg0);

		public void InsertNextUTF8Value(string arg0)
		{
			vtkUnicodeStringArray.vtkUnicodeStringArray_InsertNextUTF8Value_13(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkUnicodeStringArray_InsertTuple_14(HandleRef pThis, long i, long j, HandleRef source);

		public override void InsertTuple(long i, long j, vtkAbstractArray source)
		{
			vtkUnicodeStringArray.vtkUnicodeStringArray_InsertTuple_14(base.GetCppThis(), i, j, (source == null) ? default(HandleRef) : source.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkUnicodeStringArray_InterpolateTuple_15(HandleRef pThis, long i, HandleRef ptIndices, HandleRef source, IntPtr weights);

		public override void InterpolateTuple(long i, vtkIdList ptIndices, vtkAbstractArray source, IntPtr weights)
		{
			vtkUnicodeStringArray.vtkUnicodeStringArray_InterpolateTuple_15(base.GetCppThis(), i, (ptIndices == null) ? default(HandleRef) : ptIndices.GetCppThis(), (source == null) ? default(HandleRef) : source.GetCppThis(), weights);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkUnicodeStringArray_InterpolateTuple_16(HandleRef pThis, long i, long id1, HandleRef source1, long id2, HandleRef source2, double t);

		public override void InterpolateTuple(long i, long id1, vtkAbstractArray source1, long id2, vtkAbstractArray source2, double t)
		{
			vtkUnicodeStringArray.vtkUnicodeStringArray_InterpolateTuple_16(base.GetCppThis(), i, id1, (source1 == null) ? default(HandleRef) : source1.GetCppThis(), id2, (source2 == null) ? default(HandleRef) : source2.GetCppThis(), t);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkUnicodeStringArray_IsA_17(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkUnicodeStringArray.vtkUnicodeStringArray_IsA_17(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkUnicodeStringArray_IsNumeric_18(HandleRef pThis);

		public override int IsNumeric()
		{
			return vtkUnicodeStringArray.vtkUnicodeStringArray_IsNumeric_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkUnicodeStringArray_IsTypeOf_19(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkUnicodeStringArray.vtkUnicodeStringArray_IsTypeOf_19(type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkUnicodeStringArray_NewInstance_21(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkUnicodeStringArray NewInstance()
		{
			vtkUnicodeStringArray result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkUnicodeStringArray.vtkUnicodeStringArray_NewInstance_21(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkUnicodeStringArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkUnicodeStringArray_NewIterator_22(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public override vtkArrayIterator NewIterator()
		{
			vtkArrayIterator vtkArrayIterator = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkUnicodeStringArray.vtkUnicodeStringArray_NewIterator_22(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern int vtkUnicodeStringArray_Resize_23(HandleRef pThis, long numTuples);

		public override int Resize(long numTuples)
		{
			return vtkUnicodeStringArray.vtkUnicodeStringArray_Resize_23(base.GetCppThis(), numTuples);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkUnicodeStringArray_SafeDownCast_24(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkUnicodeStringArray SafeDownCast(vtkObjectBase o)
		{
			vtkUnicodeStringArray vtkUnicodeStringArray = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkUnicodeStringArray.vtkUnicodeStringArray_SafeDownCast_24((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkUnicodeStringArray = (vtkUnicodeStringArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkUnicodeStringArray.Register(null);
				}
			}
			return vtkUnicodeStringArray;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkUnicodeStringArray_SetNumberOfTuples_25(HandleRef pThis, long number);

		public override void SetNumberOfTuples(long number)
		{
			vtkUnicodeStringArray.vtkUnicodeStringArray_SetNumberOfTuples_25(base.GetCppThis(), number);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkUnicodeStringArray_SetTuple_26(HandleRef pThis, long i, long j, HandleRef source);

		public override void SetTuple(long i, long j, vtkAbstractArray source)
		{
			vtkUnicodeStringArray.vtkUnicodeStringArray_SetTuple_26(base.GetCppThis(), i, j, (source == null) ? default(HandleRef) : source.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkUnicodeStringArray_SetUTF8Value_27(HandleRef pThis, long i, string arg1);

		public void SetUTF8Value(long i, string arg1)
		{
			vtkUnicodeStringArray.vtkUnicodeStringArray_SetUTF8Value_27(base.GetCppThis(), i, arg1);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkUnicodeStringArray_SetVoidArray_28(HandleRef pThis, IntPtr array, long size, int save);

		public override void SetVoidArray(IntPtr array, long size, int save)
		{
			vtkUnicodeStringArray.vtkUnicodeStringArray_SetVoidArray_28(base.GetCppThis(), array, size, save);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkUnicodeStringArray_Squeeze_29(HandleRef pThis);

		public override void Squeeze()
		{
			vtkUnicodeStringArray.vtkUnicodeStringArray_Squeeze_29(base.GetCppThis());
		}
	}
}
