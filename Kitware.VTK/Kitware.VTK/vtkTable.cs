using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkTable : vtkDataObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkTable";

		public new static readonly string MRClassNameKey;

		static vtkTable()
		{
			vtkTable.MRClassNameKey = "class vtkTable";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTable.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTable"));
		}

		public vtkTable(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkTable_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkTable New()
		{
			vtkTable result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTable.vtkTable_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTable)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkTable() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkTable.vtkTable_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkTable_AddColumn_01(HandleRef pThis, HandleRef arr);

		public void AddColumn(vtkAbstractArray arr)
		{
			vtkTable.vtkTable_AddColumn_01(base.GetCppThis(), (arr == null) ? default(HandleRef) : arr.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkTable_DeepCopy_02(HandleRef pThis, HandleRef src);

		public override void DeepCopy(vtkDataObject src)
		{
			vtkTable.vtkTable_DeepCopy_02(base.GetCppThis(), (src == null) ? default(HandleRef) : src.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkTable_Dump_03(HandleRef pThis, uint colWidth);

		public void Dump(uint colWidth)
		{
			vtkTable.vtkTable_Dump_03(base.GetCppThis(), colWidth);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern uint vtkTable_GetActualMemorySize_04(HandleRef pThis);

		public override uint GetActualMemorySize()
		{
			return vtkTable.vtkTable_GetActualMemorySize_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkTable_GetAttributesAsFieldData_05(HandleRef pThis, int type, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public override vtkFieldData GetAttributesAsFieldData(int type)
		{
			vtkFieldData vtkFieldData = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTable.vtkTable_GetAttributesAsFieldData_05(base.GetCppThis(), type, ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern IntPtr vtkTable_GetColumn_06(HandleRef pThis, long col, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkAbstractArray GetColumn(long col)
		{
			vtkAbstractArray vtkAbstractArray = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTable.vtkTable_GetColumn_06(base.GetCppThis(), col, ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern IntPtr vtkTable_GetColumnByName_07(HandleRef pThis, string name, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkAbstractArray GetColumnByName(string name)
		{
			vtkAbstractArray vtkAbstractArray = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTable.vtkTable_GetColumnByName_07(base.GetCppThis(), name, ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern IntPtr vtkTable_GetColumnName_08(HandleRef pThis, long col);

		public string GetColumnName(long col)
		{
			return Marshal.PtrToStringAnsi(vtkTable.vtkTable_GetColumnName_08(base.GetCppThis(), col));
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkTable_GetData_09(HandleRef info, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkTable GetData(vtkInformation info)
		{
			vtkTable vtkTable = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTable.vtkTable_GetData_09((info == null) ? default(HandleRef) : info.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTable = (vtkTable)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTable.Register(null);
				}
			}
			return vtkTable;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkTable_GetData_10(HandleRef v, int i, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkTable GetData(vtkInformationVector v, int i)
		{
			vtkTable vtkTable = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTable.vtkTable_GetData_10((v == null) ? default(HandleRef) : v.GetCppThis(), i, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTable = (vtkTable)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTable.Register(null);
				}
			}
			return vtkTable;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkTable_GetDataObjectType_11(HandleRef pThis);

		public override int GetDataObjectType()
		{
			return vtkTable.vtkTable_GetDataObjectType_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern long vtkTable_GetNumberOfColumns_12(HandleRef pThis);

		public long GetNumberOfColumns()
		{
			return vtkTable.vtkTable_GetNumberOfColumns_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern long vtkTable_GetNumberOfElements_13(HandleRef pThis, int type);

		public override long GetNumberOfElements(int type)
		{
			return vtkTable.vtkTable_GetNumberOfElements_13(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern long vtkTable_GetNumberOfRows_14(HandleRef pThis);

		public long GetNumberOfRows()
		{
			return vtkTable.vtkTable_GetNumberOfRows_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkTable_GetRow_15(HandleRef pThis, long row, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkVariantArray GetRow(long row)
		{
			vtkVariantArray vtkVariantArray = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTable.vtkTable_GetRow_15(base.GetCppThis(), row, ref mteStatus, ref mteIndex, ref rawRefCount);
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

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkTable_GetRow_16(HandleRef pThis, long row, HandleRef values);

		public void GetRow(long row, vtkVariantArray values)
		{
			vtkTable.vtkTable_GetRow_16(base.GetCppThis(), row, (values == null) ? default(HandleRef) : values.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkTable_GetRowData_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkDataSetAttributes GetRowData()
		{
			vtkDataSetAttributes vtkDataSetAttributes = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTable.vtkTable_GetRowData_17(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataSetAttributes = (vtkDataSetAttributes)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataSetAttributes.Register(null);
				}
			}
			return vtkDataSetAttributes;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkTable_Initialize_18(HandleRef pThis);

		public override void Initialize()
		{
			vtkTable.vtkTable_Initialize_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern long vtkTable_InsertNextBlankRow_19(HandleRef pThis, double default_num_val);

		public long InsertNextBlankRow(double default_num_val)
		{
			return vtkTable.vtkTable_InsertNextBlankRow_19(base.GetCppThis(), default_num_val);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern long vtkTable_InsertNextRow_20(HandleRef pThis, HandleRef arr);

		public long InsertNextRow(vtkVariantArray arr)
		{
			return vtkTable.vtkTable_InsertNextRow_20(base.GetCppThis(), (arr == null) ? default(HandleRef) : arr.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkTable_IsA_21(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkTable.vtkTable_IsA_21(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkTable_IsTypeOf_22(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkTable.vtkTable_IsTypeOf_22(type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkTable_NewInstance_24(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkTable NewInstance()
		{
			vtkTable result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTable.vtkTable_NewInstance_24(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTable)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkTable_RemoveColumn_25(HandleRef pThis, long col);

		public void RemoveColumn(long col)
		{
			vtkTable.vtkTable_RemoveColumn_25(base.GetCppThis(), col);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkTable_RemoveColumnByName_26(HandleRef pThis, string name);

		public void RemoveColumnByName(string name)
		{
			vtkTable.vtkTable_RemoveColumnByName_26(base.GetCppThis(), name);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkTable_RemoveRow_27(HandleRef pThis, long row);

		public void RemoveRow(long row)
		{
			vtkTable.vtkTable_RemoveRow_27(base.GetCppThis(), row);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkTable_SafeDownCast_28(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkTable SafeDownCast(vtkObjectBase o)
		{
			vtkTable vtkTable = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTable.vtkTable_SafeDownCast_28((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTable = (vtkTable)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTable.Register(null);
				}
			}
			return vtkTable;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkTable_SetNumberOfRows_29(HandleRef pThis, long arg0);

		public void SetNumberOfRows(long arg0)
		{
			vtkTable.vtkTable_SetNumberOfRows_29(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkTable_SetRow_30(HandleRef pThis, long row, HandleRef values);

		public void SetRow(long row, vtkVariantArray values)
		{
			vtkTable.vtkTable_SetRow_30(base.GetCppThis(), row, (values == null) ? default(HandleRef) : values.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkTable_SetRowData_31(HandleRef pThis, HandleRef data);

		public virtual void SetRowData(vtkDataSetAttributes data)
		{
			vtkTable.vtkTable_SetRowData_31(base.GetCppThis(), (data == null) ? default(HandleRef) : data.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkTable_ShallowCopy_32(HandleRef pThis, HandleRef src);

		public override void ShallowCopy(vtkDataObject src)
		{
			vtkTable.vtkTable_ShallowCopy_32(base.GetCppThis(), (src == null) ? default(HandleRef) : src.GetCppThis());
		}
	}
}
