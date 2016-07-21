using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkDataObjectToTable : vtkTableAlgorithm
	{
		public enum CELL_DATA_WrapperEnum
		{
			CELL_DATA = 2,
			EDGE_DATA = 4,
			FIELD_DATA = 0,
			POINT_DATA,
			VERTEX_DATA = 3
		}

		public new const string MRFullTypeName = "Kitware.VTK.vtkDataObjectToTable";

		public new static readonly string MRClassNameKey;

		static vtkDataObjectToTable()
		{
			vtkDataObjectToTable.MRClassNameKey = "class vtkDataObjectToTable";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDataObjectToTable.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDataObjectToTable"));
		}

		public vtkDataObjectToTable(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkDataObjectToTable_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkDataObjectToTable New()
		{
			vtkDataObjectToTable result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDataObjectToTable.vtkDataObjectToTable_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDataObjectToTable)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkDataObjectToTable() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkDataObjectToTable.vtkDataObjectToTable_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkDataObjectToTable_GetFieldType_01(HandleRef pThis);

		public virtual int GetFieldType()
		{
			return vtkDataObjectToTable.vtkDataObjectToTable_GetFieldType_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkDataObjectToTable_GetFieldTypeMaxValue_02(HandleRef pThis);

		public virtual int GetFieldTypeMaxValue()
		{
			return vtkDataObjectToTable.vtkDataObjectToTable_GetFieldTypeMaxValue_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkDataObjectToTable_GetFieldTypeMinValue_03(HandleRef pThis);

		public virtual int GetFieldTypeMinValue()
		{
			return vtkDataObjectToTable.vtkDataObjectToTable_GetFieldTypeMinValue_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkDataObjectToTable_IsA_04(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkDataObjectToTable.vtkDataObjectToTable_IsA_04(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkDataObjectToTable_IsTypeOf_05(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkDataObjectToTable.vtkDataObjectToTable_IsTypeOf_05(type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkDataObjectToTable_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkDataObjectToTable NewInstance()
		{
			vtkDataObjectToTable result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDataObjectToTable.vtkDataObjectToTable_NewInstance_07(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDataObjectToTable)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkDataObjectToTable_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkDataObjectToTable SafeDownCast(vtkObjectBase o)
		{
			vtkDataObjectToTable vtkDataObjectToTable = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDataObjectToTable.vtkDataObjectToTable_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataObjectToTable = (vtkDataObjectToTable)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataObjectToTable.Register(null);
				}
			}
			return vtkDataObjectToTable;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkDataObjectToTable_SetFieldType_09(HandleRef pThis, int _arg);

		public virtual void SetFieldType(int _arg)
		{
			vtkDataObjectToTable.vtkDataObjectToTable_SetFieldType_09(base.GetCppThis(), _arg);
		}
	}
}
