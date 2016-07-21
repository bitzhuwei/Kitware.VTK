using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public abstract class vtkAbstractArray : vtkObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkAbstractArray";

		public new static readonly string MRClassNameKey;

		static vtkAbstractArray()
		{
			vtkAbstractArray.MRClassNameKey = "class vtkAbstractArray";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkAbstractArray.MRClassNameKey, Type.GetType("Kitware.VTK.vtkAbstractArray"));
		}

		public vtkAbstractArray(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkAbstractArray_Allocate_01(HandleRef pThis, long sz, long ext);

		public virtual int Allocate(long sz, long ext)
		{
			return vtkAbstractArray.vtkAbstractArray_Allocate_01(base.GetCppThis(), sz, ext);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkAbstractArray_ClearLookup_02(HandleRef pThis);

		public virtual void ClearLookup()
		{
			vtkAbstractArray.vtkAbstractArray_ClearLookup_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkAbstractArray_CopyComponentNames_03(HandleRef pThis, HandleRef da);

		public int CopyComponentNames(vtkAbstractArray da)
		{
			return vtkAbstractArray.vtkAbstractArray_CopyComponentNames_03(base.GetCppThis(), (da == null) ? default(HandleRef) : da.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkAbstractArray_CopyInformation_04(HandleRef pThis, HandleRef infoFrom, int deep);

		public virtual int CopyInformation(vtkInformation infoFrom, int deep)
		{
			return vtkAbstractArray.vtkAbstractArray_CopyInformation_04(base.GetCppThis(), (infoFrom == null) ? default(HandleRef) : infoFrom.GetCppThis(), deep);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkAbstractArray_CreateArray_05(int dataType, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public static vtkAbstractArray CreateArray(int dataType)
		{
			vtkAbstractArray vtkAbstractArray = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAbstractArray.vtkAbstractArray_CreateArray_05(dataType, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAbstractArray = (vtkAbstractArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAbstractArray.Register(null);
				}
			}
			return vtkAbstractArray;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkAbstractArray_DataChanged_06(HandleRef pThis);

		public virtual void DataChanged()
		{
			vtkAbstractArray.vtkAbstractArray_DataChanged_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkAbstractArray_DeepCopy_07(HandleRef pThis, HandleRef da);

		public virtual void DeepCopy(vtkAbstractArray da)
		{
			vtkAbstractArray.vtkAbstractArray_DeepCopy_07(base.GetCppThis(), (da == null) ? default(HandleRef) : da.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkAbstractArray_ExportToVoidPointer_08(HandleRef pThis, IntPtr arg0);

		public virtual void ExportToVoidPointer(IntPtr arg0)
		{
			vtkAbstractArray.vtkAbstractArray_ExportToVoidPointer_08(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkAbstractArray_GUI_HIDE_09(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public static vtkInformationIntegerKey GUI_HIDE()
		{
			vtkInformationIntegerKey vtkInformationIntegerKey = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAbstractArray.vtkAbstractArray_GUI_HIDE_09(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationIntegerKey = (vtkInformationIntegerKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationIntegerKey.Register(null);
				}
			}
			return vtkInformationIntegerKey;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern uint vtkAbstractArray_GetActualMemorySize_10(HandleRef pThis);

		public virtual uint GetActualMemorySize()
		{
			return vtkAbstractArray.vtkAbstractArray_GetActualMemorySize_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkAbstractArray_GetComponentName_11(HandleRef pThis, long component);

		public string GetComponentName(long component)
		{
			return Marshal.PtrToStringAnsi(vtkAbstractArray.vtkAbstractArray_GetComponentName_11(base.GetCppThis(), component));
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern long vtkAbstractArray_GetDataSize_12(HandleRef pThis);

		public virtual long GetDataSize()
		{
			return vtkAbstractArray.vtkAbstractArray_GetDataSize_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkAbstractArray_GetDataType_13(HandleRef pThis);

		public virtual int GetDataType()
		{
			return vtkAbstractArray.vtkAbstractArray_GetDataType_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkAbstractArray_GetDataTypeAsString_14(HandleRef pThis);

		public virtual string GetDataTypeAsString()
		{
			return Marshal.PtrToStringAnsi(vtkAbstractArray.vtkAbstractArray_GetDataTypeAsString_14(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkAbstractArray_GetDataTypeSize_15(HandleRef pThis);

		public virtual int GetDataTypeSize()
		{
			return vtkAbstractArray.vtkAbstractArray_GetDataTypeSize_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkAbstractArray_GetDataTypeSize_16(int type);

		public static int GetDataTypeSize(int type)
		{
			return vtkAbstractArray.vtkAbstractArray_GetDataTypeSize_16(type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkAbstractArray_GetElementComponentSize_17(HandleRef pThis);

		public virtual int GetElementComponentSize()
		{
			return vtkAbstractArray.vtkAbstractArray_GetElementComponentSize_17(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkAbstractArray_GetInformation_18(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkInformation GetInformation()
		{
			vtkInformation vtkInformation = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAbstractArray.vtkAbstractArray_GetInformation_18(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformation = (vtkInformation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformation.Register(null);
				}
			}
			return vtkInformation;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern long vtkAbstractArray_GetMaxId_19(HandleRef pThis);

		public long GetMaxId()
		{
			return vtkAbstractArray.vtkAbstractArray_GetMaxId_19(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkAbstractArray_GetName_20(HandleRef pThis);

		public virtual string GetName()
		{
			return Marshal.PtrToStringAnsi(vtkAbstractArray.vtkAbstractArray_GetName_20(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkAbstractArray_GetNumberOfComponents_21(HandleRef pThis);

		public int GetNumberOfComponents()
		{
			return vtkAbstractArray.vtkAbstractArray_GetNumberOfComponents_21(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkAbstractArray_GetNumberOfComponentsMaxValue_22(HandleRef pThis);

		public virtual int GetNumberOfComponentsMaxValue()
		{
			return vtkAbstractArray.vtkAbstractArray_GetNumberOfComponentsMaxValue_22(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkAbstractArray_GetNumberOfComponentsMinValue_23(HandleRef pThis);

		public virtual int GetNumberOfComponentsMinValue()
		{
			return vtkAbstractArray.vtkAbstractArray_GetNumberOfComponentsMinValue_23(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern long vtkAbstractArray_GetNumberOfTuples_24(HandleRef pThis);

		public long GetNumberOfTuples()
		{
			return vtkAbstractArray.vtkAbstractArray_GetNumberOfTuples_24(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern long vtkAbstractArray_GetSize_25(HandleRef pThis);

		public long GetSize()
		{
			return vtkAbstractArray.vtkAbstractArray_GetSize_25(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkAbstractArray_GetTuples_26(HandleRef pThis, HandleRef ptIds, HandleRef output);

		public virtual void GetTuples(vtkIdList ptIds, vtkAbstractArray output)
		{
			vtkAbstractArray.vtkAbstractArray_GetTuples_26(base.GetCppThis(), (ptIds == null) ? default(HandleRef) : ptIds.GetCppThis(), (output == null) ? default(HandleRef) : output.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkAbstractArray_GetTuples_27(HandleRef pThis, long p1, long p2, HandleRef output);

		public virtual void GetTuples(long p1, long p2, vtkAbstractArray output)
		{
			vtkAbstractArray.vtkAbstractArray_GetTuples_27(base.GetCppThis(), p1, p2, (output == null) ? default(HandleRef) : output.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkAbstractArray_GetVoidPointer_28(HandleRef pThis, long id);

		public virtual IntPtr GetVoidPointer(long id)
		{
			return vtkAbstractArray.vtkAbstractArray_GetVoidPointer_28(base.GetCppThis(), id);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern byte vtkAbstractArray_HasAComponentName_29(HandleRef pThis);

		public bool HasAComponentName()
		{
			return vtkAbstractArray.vtkAbstractArray_HasAComponentName_29(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern byte vtkAbstractArray_HasInformation_30(HandleRef pThis);

		public bool HasInformation()
		{
			return vtkAbstractArray.vtkAbstractArray_HasInformation_30(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkAbstractArray_Initialize_31(HandleRef pThis);

		public virtual void Initialize()
		{
			vtkAbstractArray.vtkAbstractArray_Initialize_31(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern long vtkAbstractArray_InsertNextTuple_32(HandleRef pThis, long j, HandleRef source);

		public virtual long InsertNextTuple(long j, vtkAbstractArray source)
		{
			return vtkAbstractArray.vtkAbstractArray_InsertNextTuple_32(base.GetCppThis(), j, (source == null) ? default(HandleRef) : source.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkAbstractArray_InsertTuple_33(HandleRef pThis, long i, long j, HandleRef source);

		public virtual void InsertTuple(long i, long j, vtkAbstractArray source)
		{
			vtkAbstractArray.vtkAbstractArray_InsertTuple_33(base.GetCppThis(), i, j, (source == null) ? default(HandleRef) : source.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkAbstractArray_InterpolateTuple_34(HandleRef pThis, long i, HandleRef ptIndices, HandleRef source, IntPtr weights);

		public virtual void InterpolateTuple(long i, vtkIdList ptIndices, vtkAbstractArray source, IntPtr weights)
		{
			vtkAbstractArray.vtkAbstractArray_InterpolateTuple_34(base.GetCppThis(), i, (ptIndices == null) ? default(HandleRef) : ptIndices.GetCppThis(), (source == null) ? default(HandleRef) : source.GetCppThis(), weights);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkAbstractArray_InterpolateTuple_35(HandleRef pThis, long i, long id1, HandleRef source1, long id2, HandleRef source2, double t);

		public virtual void InterpolateTuple(long i, long id1, vtkAbstractArray source1, long id2, vtkAbstractArray source2, double t)
		{
			vtkAbstractArray.vtkAbstractArray_InterpolateTuple_35(base.GetCppThis(), i, id1, (source1 == null) ? default(HandleRef) : source1.GetCppThis(), id2, (source2 == null) ? default(HandleRef) : source2.GetCppThis(), t);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkAbstractArray_IsA_36(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkAbstractArray.vtkAbstractArray_IsA_36(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkAbstractArray_IsNumeric_37(HandleRef pThis);

		public virtual int IsNumeric()
		{
			return vtkAbstractArray.vtkAbstractArray_IsNumeric_37(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkAbstractArray_IsTypeOf_38(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkAbstractArray.vtkAbstractArray_IsTypeOf_38(type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkAbstractArray_NewInstance_39(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkAbstractArray NewInstance()
		{
			vtkAbstractArray result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAbstractArray.vtkAbstractArray_NewInstance_39(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAbstractArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkAbstractArray_NewIterator_40(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkArrayIterator NewIterator()
		{
			vtkArrayIterator vtkArrayIterator = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAbstractArray.vtkAbstractArray_NewIterator_40(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern void vtkAbstractArray_Reset_41(HandleRef pThis);

		public void Reset()
		{
			vtkAbstractArray.vtkAbstractArray_Reset_41(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkAbstractArray_Resize_42(HandleRef pThis, long numTuples);

		public virtual int Resize(long numTuples)
		{
			return vtkAbstractArray.vtkAbstractArray_Resize_42(base.GetCppThis(), numTuples);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkAbstractArray_SafeDownCast_43(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkAbstractArray SafeDownCast(vtkObjectBase o)
		{
			vtkAbstractArray vtkAbstractArray = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAbstractArray.vtkAbstractArray_SafeDownCast_43((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAbstractArray = (vtkAbstractArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAbstractArray.Register(null);
				}
			}
			return vtkAbstractArray;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkAbstractArray_SetComponentName_44(HandleRef pThis, long component, string name);

		public void SetComponentName(long component, string name)
		{
			vtkAbstractArray.vtkAbstractArray_SetComponentName_44(base.GetCppThis(), component, name);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkAbstractArray_SetName_45(HandleRef pThis, string _arg);

		public virtual void SetName(string _arg)
		{
			vtkAbstractArray.vtkAbstractArray_SetName_45(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkAbstractArray_SetNumberOfComponents_46(HandleRef pThis, int _arg);

		public virtual void SetNumberOfComponents(int _arg)
		{
			vtkAbstractArray.vtkAbstractArray_SetNumberOfComponents_46(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkAbstractArray_SetNumberOfTuples_47(HandleRef pThis, long number);

		public virtual void SetNumberOfTuples(long number)
		{
			vtkAbstractArray.vtkAbstractArray_SetNumberOfTuples_47(base.GetCppThis(), number);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkAbstractArray_SetTuple_48(HandleRef pThis, long i, long j, HandleRef source);

		public virtual void SetTuple(long i, long j, vtkAbstractArray source)
		{
			vtkAbstractArray.vtkAbstractArray_SetTuple_48(base.GetCppThis(), i, j, (source == null) ? default(HandleRef) : source.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkAbstractArray_SetVoidArray_49(HandleRef pThis, IntPtr arg0, long arg1, int arg2);

		public virtual void SetVoidArray(IntPtr arg0, long arg1, int arg2)
		{
			vtkAbstractArray.vtkAbstractArray_SetVoidArray_49(base.GetCppThis(), arg0, arg1, arg2);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkAbstractArray_Squeeze_50(HandleRef pThis);

		public virtual void Squeeze()
		{
			vtkAbstractArray.vtkAbstractArray_Squeeze_50(base.GetCppThis());
		}
	}
}
