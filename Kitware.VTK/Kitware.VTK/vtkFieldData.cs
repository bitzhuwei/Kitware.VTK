using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkFieldData : vtkObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkFieldData";

		public new static readonly string MRClassNameKey;

		static vtkFieldData()
		{
			vtkFieldData.MRClassNameKey = "class vtkFieldData";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkFieldData.MRClassNameKey, Type.GetType("Kitware.VTK.vtkFieldData"));
		}

		public vtkFieldData(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkFieldData_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkFieldData New()
		{
			vtkFieldData result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkFieldData.vtkFieldData_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkFieldData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkFieldData() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkFieldData.vtkFieldData_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkFieldData_AddArray_01(HandleRef pThis, HandleRef array);

		public int AddArray(vtkAbstractArray array)
		{
			return vtkFieldData.vtkFieldData_AddArray_01(base.GetCppThis(), (array == null) ? default(HandleRef) : array.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkFieldData_Allocate_02(HandleRef pThis, long sz, long ext);

		public int Allocate(long sz, long ext)
		{
			return vtkFieldData.vtkFieldData_Allocate_02(base.GetCppThis(), sz, ext);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkFieldData_AllocateArrays_03(HandleRef pThis, int num);

		public void AllocateArrays(int num)
		{
			vtkFieldData.vtkFieldData_AllocateArrays_03(base.GetCppThis(), num);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkFieldData_CopyAllOff_04(HandleRef pThis, int unused);

		public virtual void CopyAllOff(int unused)
		{
			vtkFieldData.vtkFieldData_CopyAllOff_04(base.GetCppThis(), unused);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkFieldData_CopyAllOn_05(HandleRef pThis, int unused);

		public virtual void CopyAllOn(int unused)
		{
			vtkFieldData.vtkFieldData_CopyAllOn_05(base.GetCppThis(), unused);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkFieldData_CopyFieldOff_06(HandleRef pThis, string name);

		public void CopyFieldOff(string name)
		{
			vtkFieldData.vtkFieldData_CopyFieldOff_06(base.GetCppThis(), name);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkFieldData_CopyFieldOn_07(HandleRef pThis, string name);

		public void CopyFieldOn(string name)
		{
			vtkFieldData.vtkFieldData_CopyFieldOn_07(base.GetCppThis(), name);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkFieldData_CopyStructure_08(HandleRef pThis, HandleRef arg0);

		public void CopyStructure(vtkFieldData arg0)
		{
			vtkFieldData.vtkFieldData_CopyStructure_08(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkFieldData_DeepCopy_09(HandleRef pThis, HandleRef da);

		public virtual void DeepCopy(vtkFieldData da)
		{
			vtkFieldData.vtkFieldData_DeepCopy_09(base.GetCppThis(), (da == null) ? default(HandleRef) : da.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkFieldData_GetAbstractArray_10(HandleRef pThis, int i, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkAbstractArray GetAbstractArray(int i)
		{
			vtkAbstractArray vtkAbstractArray = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkFieldData.vtkFieldData_GetAbstractArray_10(base.GetCppThis(), i, ref mteStatus, ref mteIndex, ref rawRefCount);
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

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkFieldData_GetAbstractArray_11(HandleRef pThis, string arrayName, ref int index, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkAbstractArray GetAbstractArray(string arrayName, ref int index)
		{
			vtkAbstractArray vtkAbstractArray = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkFieldData.vtkFieldData_GetAbstractArray_11(base.GetCppThis(), arrayName, ref index, ref mteStatus, ref mteIndex, ref rawRefCount);
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

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkFieldData_GetAbstractArray_12(HandleRef pThis, string arrayName, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkAbstractArray GetAbstractArray(string arrayName)
		{
			vtkAbstractArray vtkAbstractArray = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkFieldData.vtkFieldData_GetAbstractArray_12(base.GetCppThis(), arrayName, ref mteStatus, ref mteIndex, ref rawRefCount);
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

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern uint vtkFieldData_GetActualMemorySize_13(HandleRef pThis);

		public virtual uint GetActualMemorySize()
		{
			return vtkFieldData.vtkFieldData_GetActualMemorySize_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkFieldData_GetArray_14(HandleRef pThis, int i, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkDataArray GetArray(int i)
		{
			vtkDataArray vtkDataArray = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkFieldData.vtkFieldData_GetArray_14(base.GetCppThis(), i, ref mteStatus, ref mteIndex, ref rawRefCount);
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

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkFieldData_GetArray_15(HandleRef pThis, string arrayName, ref int index, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkDataArray GetArray(string arrayName, ref int index)
		{
			vtkDataArray vtkDataArray = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkFieldData.vtkFieldData_GetArray_15(base.GetCppThis(), arrayName, ref index, ref mteStatus, ref mteIndex, ref rawRefCount);
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

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkFieldData_GetArray_16(HandleRef pThis, string arrayName, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkDataArray GetArray(string arrayName)
		{
			vtkDataArray vtkDataArray = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkFieldData.vtkFieldData_GetArray_16(base.GetCppThis(), arrayName, ref mteStatus, ref mteIndex, ref rawRefCount);
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

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkFieldData_GetArrayContainingComponent_17(HandleRef pThis, int i, ref int arrayComp);

		public int GetArrayContainingComponent(int i, ref int arrayComp)
		{
			return vtkFieldData.vtkFieldData_GetArrayContainingComponent_17(base.GetCppThis(), i, ref arrayComp);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkFieldData_GetArrayName_18(HandleRef pThis, int i);

		public string GetArrayName(int i)
		{
			return Marshal.PtrToStringAnsi(vtkFieldData.vtkFieldData_GetArrayName_18(base.GetCppThis(), i));
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkFieldData_GetField_19(HandleRef pThis, HandleRef ptId, HandleRef f);

		public void GetField(vtkIdList ptId, vtkFieldData f)
		{
			vtkFieldData.vtkFieldData_GetField_19(base.GetCppThis(), (ptId == null) ? default(HandleRef) : ptId.GetCppThis(), (f == null) ? default(HandleRef) : f.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern uint vtkFieldData_GetMTime_20(HandleRef pThis);

		public override uint GetMTime()
		{
			return vtkFieldData.vtkFieldData_GetMTime_20(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkFieldData_GetNumberOfArrays_21(HandleRef pThis);

		public int GetNumberOfArrays()
		{
			return vtkFieldData.vtkFieldData_GetNumberOfArrays_21(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkFieldData_GetNumberOfComponents_22(HandleRef pThis);

		public int GetNumberOfComponents()
		{
			return vtkFieldData.vtkFieldData_GetNumberOfComponents_22(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern long vtkFieldData_GetNumberOfTuples_23(HandleRef pThis);

		public long GetNumberOfTuples()
		{
			return vtkFieldData.vtkFieldData_GetNumberOfTuples_23(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkFieldData_HasArray_24(HandleRef pThis, string name);

		public int HasArray(string name)
		{
			return vtkFieldData.vtkFieldData_HasArray_24(base.GetCppThis(), name);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkFieldData_Initialize_25(HandleRef pThis);

		public virtual void Initialize()
		{
			vtkFieldData.vtkFieldData_Initialize_25(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern long vtkFieldData_InsertNextTuple_26(HandleRef pThis, long j, HandleRef source);

		public long InsertNextTuple(long j, vtkFieldData source)
		{
			return vtkFieldData.vtkFieldData_InsertNextTuple_26(base.GetCppThis(), j, (source == null) ? default(HandleRef) : source.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkFieldData_InsertTuple_27(HandleRef pThis, long i, long j, HandleRef source);

		public void InsertTuple(long i, long j, vtkFieldData source)
		{
			vtkFieldData.vtkFieldData_InsertTuple_27(base.GetCppThis(), i, j, (source == null) ? default(HandleRef) : source.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkFieldData_IsA_28(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkFieldData.vtkFieldData_IsA_28(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkFieldData_IsTypeOf_29(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkFieldData.vtkFieldData_IsTypeOf_29(type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkFieldData_NewInstance_31(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkFieldData NewInstance()
		{
			vtkFieldData result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkFieldData.vtkFieldData_NewInstance_31(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkFieldData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkFieldData_PassData_32(HandleRef pThis, HandleRef fd);

		public virtual void PassData(vtkFieldData fd)
		{
			vtkFieldData.vtkFieldData_PassData_32(base.GetCppThis(), (fd == null) ? default(HandleRef) : fd.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkFieldData_RemoveArray_33(HandleRef pThis, string name);

		public virtual void RemoveArray(string name)
		{
			vtkFieldData.vtkFieldData_RemoveArray_33(base.GetCppThis(), name);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkFieldData_Reset_34(HandleRef pThis);

		public void Reset()
		{
			vtkFieldData.vtkFieldData_Reset_34(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkFieldData_SafeDownCast_35(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkFieldData SafeDownCast(vtkObjectBase o)
		{
			vtkFieldData vtkFieldData = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkFieldData.vtkFieldData_SafeDownCast_35((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkFieldData = (vtkFieldData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkFieldData.Register(null);
				}
			}
			return vtkFieldData;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkFieldData_SetNumberOfTuples_36(HandleRef pThis, long number);

		public void SetNumberOfTuples(long number)
		{
			vtkFieldData.vtkFieldData_SetNumberOfTuples_36(base.GetCppThis(), number);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkFieldData_SetTuple_37(HandleRef pThis, long i, long j, HandleRef source);

		public void SetTuple(long i, long j, vtkFieldData source)
		{
			vtkFieldData.vtkFieldData_SetTuple_37(base.GetCppThis(), i, j, (source == null) ? default(HandleRef) : source.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkFieldData_ShallowCopy_38(HandleRef pThis, HandleRef da);

		public virtual void ShallowCopy(vtkFieldData da)
		{
			vtkFieldData.vtkFieldData_ShallowCopy_38(base.GetCppThis(), (da == null) ? default(HandleRef) : da.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkFieldData_Squeeze_39(HandleRef pThis);

		public void Squeeze()
		{
			vtkFieldData.vtkFieldData_Squeeze_39(base.GetCppThis());
		}
	}
}
