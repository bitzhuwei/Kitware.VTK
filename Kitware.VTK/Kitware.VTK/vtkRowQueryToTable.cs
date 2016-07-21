using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkRowQueryToTable : vtkTableAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkRowQueryToTable";

		public new static readonly string MRClassNameKey;

		static vtkRowQueryToTable()
		{
			vtkRowQueryToTable.MRClassNameKey = "class vtkRowQueryToTable";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkRowQueryToTable.MRClassNameKey, Type.GetType("Kitware.VTK.vtkRowQueryToTable"));
		}

		public vtkRowQueryToTable(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkRowQueryToTable_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkRowQueryToTable New()
		{
			vtkRowQueryToTable result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkRowQueryToTable.vtkRowQueryToTable_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRowQueryToTable)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkRowQueryToTable() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkRowQueryToTable.vtkRowQueryToTable_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern uint vtkRowQueryToTable_GetMTime_01(HandleRef pThis);

		public override uint GetMTime()
		{
			return vtkRowQueryToTable.vtkRowQueryToTable_GetMTime_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkRowQueryToTable_GetQuery_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkRowQuery GetQuery()
		{
			vtkRowQuery vtkRowQuery = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkRowQueryToTable.vtkRowQueryToTable_GetQuery_02(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRowQuery = (vtkRowQuery)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRowQuery.Register(null);
				}
			}
			return vtkRowQuery;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkRowQueryToTable_IsA_03(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkRowQueryToTable.vtkRowQueryToTable_IsA_03(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkRowQueryToTable_IsTypeOf_04(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkRowQueryToTable.vtkRowQueryToTable_IsTypeOf_04(type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkRowQueryToTable_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkRowQueryToTable NewInstance()
		{
			vtkRowQueryToTable result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkRowQueryToTable.vtkRowQueryToTable_NewInstance_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRowQueryToTable)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkRowQueryToTable_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkRowQueryToTable SafeDownCast(vtkObjectBase o)
		{
			vtkRowQueryToTable vtkRowQueryToTable = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkRowQueryToTable.vtkRowQueryToTable_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRowQueryToTable = (vtkRowQueryToTable)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRowQueryToTable.Register(null);
				}
			}
			return vtkRowQueryToTable;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkRowQueryToTable_SetQuery_08(HandleRef pThis, HandleRef query);

		public void SetQuery(vtkRowQuery query)
		{
			vtkRowQueryToTable.vtkRowQueryToTable_SetQuery_08(base.GetCppThis(), (query == null) ? default(HandleRef) : query.GetCppThis());
		}
	}
}
