using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkSQLiteQuery : vtkSQLQuery
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkSQLiteQuery";

		public new static readonly string MRClassNameKey;

		static vtkSQLiteQuery()
		{
			vtkSQLiteQuery.MRClassNameKey = "class vtkSQLiteQuery";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSQLiteQuery.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSQLiteQuery"));
		}

		public vtkSQLiteQuery(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkSQLiteQuery_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkSQLiteQuery New()
		{
			vtkSQLiteQuery result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSQLiteQuery.vtkSQLiteQuery_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSQLiteQuery)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkSQLiteQuery() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkSQLiteQuery.vtkSQLiteQuery_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern byte vtkSQLiteQuery_BeginTransaction_01(HandleRef pThis);

		public override bool BeginTransaction()
		{
			return vtkSQLiteQuery.vtkSQLiteQuery_BeginTransaction_01(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern byte vtkSQLiteQuery_BindParameter_02(HandleRef pThis, int index, byte value);

		public override bool BindParameter(int index, byte value)
		{
			return vtkSQLiteQuery.vtkSQLiteQuery_BindParameter_02(base.GetCppThis(), index, value) != 0;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern byte vtkSQLiteQuery_BindParameter_03(HandleRef pThis, int index, sbyte value);

		public override bool BindParameter(int index, sbyte value)
		{
			return vtkSQLiteQuery.vtkSQLiteQuery_BindParameter_03(base.GetCppThis(), index, value) != 0;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern byte vtkSQLiteQuery_BindParameter_04(HandleRef pThis, int index, ushort value);

		public override bool BindParameter(int index, ushort value)
		{
			return vtkSQLiteQuery.vtkSQLiteQuery_BindParameter_04(base.GetCppThis(), index, value) != 0;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern byte vtkSQLiteQuery_BindParameter_05(HandleRef pThis, int index, short value);

		public override bool BindParameter(int index, short value)
		{
			return vtkSQLiteQuery.vtkSQLiteQuery_BindParameter_05(base.GetCppThis(), index, value) != 0;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern byte vtkSQLiteQuery_BindParameter_06(HandleRef pThis, int index, uint value);

		public override bool BindParameter(int index, uint value)
		{
			return vtkSQLiteQuery.vtkSQLiteQuery_BindParameter_06(base.GetCppThis(), index, value) != 0;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern byte vtkSQLiteQuery_BindParameter_07(HandleRef pThis, int index, int value);

		public override bool BindParameter(int index, int value)
		{
			return vtkSQLiteQuery.vtkSQLiteQuery_BindParameter_07(base.GetCppThis(), index, value) != 0;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern byte vtkSQLiteQuery_BindParameter_08(HandleRef pThis, int index, ulong value);

		public override bool BindParameter(int index, ulong value)
		{
			return vtkSQLiteQuery.vtkSQLiteQuery_BindParameter_08(base.GetCppThis(), index, value) != 0;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern byte vtkSQLiteQuery_BindParameter_09(HandleRef pThis, int index, long value);

		public override bool BindParameter(int index, long value)
		{
			return vtkSQLiteQuery.vtkSQLiteQuery_BindParameter_09(base.GetCppThis(), index, value) != 0;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern byte vtkSQLiteQuery_BindParameter_10(HandleRef pThis, int index, float value);

		public override bool BindParameter(int index, float value)
		{
			return vtkSQLiteQuery.vtkSQLiteQuery_BindParameter_10(base.GetCppThis(), index, value) != 0;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern byte vtkSQLiteQuery_BindParameter_11(HandleRef pThis, int index, double value);

		public override bool BindParameter(int index, double value)
		{
			return vtkSQLiteQuery.vtkSQLiteQuery_BindParameter_11(base.GetCppThis(), index, value) != 0;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern byte vtkSQLiteQuery_BindParameter_12(HandleRef pThis, int index, string stringValue);

		public override bool BindParameter(int index, string stringValue)
		{
			return vtkSQLiteQuery.vtkSQLiteQuery_BindParameter_12(base.GetCppThis(), index, stringValue) != 0;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern byte vtkSQLiteQuery_BindParameter_13(HandleRef pThis, int index, string stringValue, uint length);

		public override bool BindParameter(int index, string stringValue, uint length)
		{
			return vtkSQLiteQuery.vtkSQLiteQuery_BindParameter_13(base.GetCppThis(), index, stringValue, length) != 0;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern byte vtkSQLiteQuery_BindParameter_14(HandleRef pThis, int index, IntPtr data, uint length);

		public override bool BindParameter(int index, IntPtr data, uint length)
		{
			return vtkSQLiteQuery.vtkSQLiteQuery_BindParameter_14(base.GetCppThis(), index, data, length) != 0;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern byte vtkSQLiteQuery_ClearParameterBindings_15(HandleRef pThis);

		public override bool ClearParameterBindings()
		{
			return vtkSQLiteQuery.vtkSQLiteQuery_ClearParameterBindings_15(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern byte vtkSQLiteQuery_CommitTransaction_16(HandleRef pThis);

		public override bool CommitTransaction()
		{
			return vtkSQLiteQuery.vtkSQLiteQuery_CommitTransaction_16(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern byte vtkSQLiteQuery_Execute_17(HandleRef pThis);

		public override bool Execute()
		{
			return vtkSQLiteQuery.vtkSQLiteQuery_Execute_17(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkSQLiteQuery_GetFieldName_18(HandleRef pThis, int i);

		public override string GetFieldName(int i)
		{
			return Marshal.PtrToStringAnsi(vtkSQLiteQuery.vtkSQLiteQuery_GetFieldName_18(base.GetCppThis(), i));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkSQLiteQuery_GetFieldType_19(HandleRef pThis, int i);

		public override int GetFieldType(int i)
		{
			return vtkSQLiteQuery.vtkSQLiteQuery_GetFieldType_19(base.GetCppThis(), i);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkSQLiteQuery_GetLastErrorText_20(HandleRef pThis);

		public override string GetLastErrorText()
		{
			return Marshal.PtrToStringAnsi(vtkSQLiteQuery.vtkSQLiteQuery_GetLastErrorText_20(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkSQLiteQuery_GetNumberOfFields_21(HandleRef pThis);

		public override int GetNumberOfFields()
		{
			return vtkSQLiteQuery.vtkSQLiteQuery_GetNumberOfFields_21(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern byte vtkSQLiteQuery_HasError_22(HandleRef pThis);

		public override bool HasError()
		{
			return vtkSQLiteQuery.vtkSQLiteQuery_HasError_22(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkSQLiteQuery_IsA_23(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkSQLiteQuery.vtkSQLiteQuery_IsA_23(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkSQLiteQuery_IsTypeOf_24(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkSQLiteQuery.vtkSQLiteQuery_IsTypeOf_24(type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkSQLiteQuery_NewInstance_26(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkSQLiteQuery NewInstance()
		{
			vtkSQLiteQuery result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSQLiteQuery.vtkSQLiteQuery_NewInstance_26(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSQLiteQuery)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern byte vtkSQLiteQuery_NextRow_27(HandleRef pThis);

		public override bool NextRow()
		{
			return vtkSQLiteQuery.vtkSQLiteQuery_NextRow_27(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern byte vtkSQLiteQuery_RollbackTransaction_28(HandleRef pThis);

		public override bool RollbackTransaction()
		{
			return vtkSQLiteQuery.vtkSQLiteQuery_RollbackTransaction_28(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkSQLiteQuery_SafeDownCast_29(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkSQLiteQuery SafeDownCast(vtkObjectBase o)
		{
			vtkSQLiteQuery vtkSQLiteQuery = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSQLiteQuery.vtkSQLiteQuery_SafeDownCast_29((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSQLiteQuery = (vtkSQLiteQuery)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSQLiteQuery.Register(null);
				}
			}
			return vtkSQLiteQuery;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern byte vtkSQLiteQuery_SetQuery_30(HandleRef pThis, string query);

		public override bool SetQuery(string query)
		{
			return vtkSQLiteQuery.vtkSQLiteQuery_SetQuery_30(base.GetCppThis(), query) != 0;
		}
	}
}
