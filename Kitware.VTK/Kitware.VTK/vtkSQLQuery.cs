using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public abstract class vtkSQLQuery : vtkRowQuery
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkSQLQuery";

		public new static readonly string MRClassNameKey;

		static vtkSQLQuery()
		{
			vtkSQLQuery.MRClassNameKey = "class vtkSQLQuery";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSQLQuery.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSQLQuery"));
		}

		public vtkSQLQuery(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern byte vtkSQLQuery_BeginTransaction_01(HandleRef pThis);

		public virtual bool BeginTransaction()
		{
			return vtkSQLQuery.vtkSQLQuery_BeginTransaction_01(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern byte vtkSQLQuery_BindParameter_02(HandleRef pThis, int index, byte value);

		public virtual bool BindParameter(int index, byte value)
		{
			return vtkSQLQuery.vtkSQLQuery_BindParameter_02(base.GetCppThis(), index, value) != 0;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern byte vtkSQLQuery_BindParameter_03(HandleRef pThis, int index, ushort value);

		public virtual bool BindParameter(int index, ushort value)
		{
			return vtkSQLQuery.vtkSQLQuery_BindParameter_03(base.GetCppThis(), index, value) != 0;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern byte vtkSQLQuery_BindParameter_04(HandleRef pThis, int index, uint value);

		public virtual bool BindParameter(int index, uint value)
		{
			return vtkSQLQuery.vtkSQLQuery_BindParameter_04(base.GetCppThis(), index, value) != 0;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern byte vtkSQLQuery_BindParameter_05(HandleRef pThis, int index, sbyte value);

		public virtual bool BindParameter(int index, sbyte value)
		{
			return vtkSQLQuery.vtkSQLQuery_BindParameter_05(base.GetCppThis(), index, value) != 0;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern byte vtkSQLQuery_BindParameter_06(HandleRef pThis, int index, short value);

		public virtual bool BindParameter(int index, short value)
		{
			return vtkSQLQuery.vtkSQLQuery_BindParameter_06(base.GetCppThis(), index, value) != 0;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern byte vtkSQLQuery_BindParameter_07(HandleRef pThis, int index, int value);

		public virtual bool BindParameter(int index, int value)
		{
			return vtkSQLQuery.vtkSQLQuery_BindParameter_07(base.GetCppThis(), index, value) != 0;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern byte vtkSQLQuery_BindParameter_08(HandleRef pThis, int index, ulong value);

		public virtual bool BindParameter(int index, ulong value)
		{
			return vtkSQLQuery.vtkSQLQuery_BindParameter_08(base.GetCppThis(), index, value) != 0;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern byte vtkSQLQuery_BindParameter_09(HandleRef pThis, int index, long value);

		public virtual bool BindParameter(int index, long value)
		{
			return vtkSQLQuery.vtkSQLQuery_BindParameter_09(base.GetCppThis(), index, value) != 0;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern byte vtkSQLQuery_BindParameter_10(HandleRef pThis, int index, float value);

		public virtual bool BindParameter(int index, float value)
		{
			return vtkSQLQuery.vtkSQLQuery_BindParameter_10(base.GetCppThis(), index, value) != 0;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern byte vtkSQLQuery_BindParameter_11(HandleRef pThis, int index, double value);

		public virtual bool BindParameter(int index, double value)
		{
			return vtkSQLQuery.vtkSQLQuery_BindParameter_11(base.GetCppThis(), index, value) != 0;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern byte vtkSQLQuery_BindParameter_12(HandleRef pThis, int index, string stringValue);

		public virtual bool BindParameter(int index, string stringValue)
		{
			return vtkSQLQuery.vtkSQLQuery_BindParameter_12(base.GetCppThis(), index, stringValue) != 0;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern byte vtkSQLQuery_BindParameter_13(HandleRef pThis, int index, string stringValue, uint length);

		public virtual bool BindParameter(int index, string stringValue, uint length)
		{
			return vtkSQLQuery.vtkSQLQuery_BindParameter_13(base.GetCppThis(), index, stringValue, length) != 0;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern byte vtkSQLQuery_BindParameter_14(HandleRef pThis, int index, IntPtr data, uint length);

		public virtual bool BindParameter(int index, IntPtr data, uint length)
		{
			return vtkSQLQuery.vtkSQLQuery_BindParameter_14(base.GetCppThis(), index, data, length) != 0;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern byte vtkSQLQuery_ClearParameterBindings_15(HandleRef pThis);

		public virtual bool ClearParameterBindings()
		{
			return vtkSQLQuery.vtkSQLQuery_ClearParameterBindings_15(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern byte vtkSQLQuery_CommitTransaction_16(HandleRef pThis);

		public virtual bool CommitTransaction()
		{
			return vtkSQLQuery.vtkSQLQuery_CommitTransaction_16(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkSQLQuery_EscapeString_17(HandleRef pThis, string src, byte addSurroundingQuotes);

		public string EscapeString(string src, bool addSurroundingQuotes)
		{
			return Marshal.PtrToStringAnsi(vtkSQLQuery.vtkSQLQuery_EscapeString_17(base.GetCppThis(), src, addSurroundingQuotes ? (byte)1 : (byte)0));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern byte vtkSQLQuery_Execute_18(HandleRef pThis);

		public override bool Execute()
		{
			return vtkSQLQuery.vtkSQLQuery_Execute_18(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkSQLQuery_GetDatabase_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkSQLDatabase GetDatabase()
		{
			vtkSQLDatabase vtkSQLDatabase = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSQLQuery.vtkSQLQuery_GetDatabase_19(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSQLDatabase = (vtkSQLDatabase)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSQLDatabase.Register(null);
				}
			}
			return vtkSQLDatabase;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkSQLQuery_GetQuery_20(HandleRef pThis);

		public virtual string GetQuery()
		{
			return Marshal.PtrToStringAnsi(vtkSQLQuery.vtkSQLQuery_GetQuery_20(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkSQLQuery_IsA_21(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkSQLQuery.vtkSQLQuery_IsA_21(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern byte vtkSQLQuery_IsActive_22(HandleRef pThis);

		public override bool IsActive()
		{
			return vtkSQLQuery.vtkSQLQuery_IsActive_22(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkSQLQuery_IsTypeOf_23(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkSQLQuery.vtkSQLQuery_IsTypeOf_23(type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkSQLQuery_NewInstance_24(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkSQLQuery NewInstance()
		{
			vtkSQLQuery result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSQLQuery.vtkSQLQuery_NewInstance_24(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSQLQuery)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern byte vtkSQLQuery_RollbackTransaction_25(HandleRef pThis);

		public virtual bool RollbackTransaction()
		{
			return vtkSQLQuery.vtkSQLQuery_RollbackTransaction_25(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkSQLQuery_SafeDownCast_26(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkSQLQuery SafeDownCast(vtkObjectBase o)
		{
			vtkSQLQuery vtkSQLQuery = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSQLQuery.vtkSQLQuery_SafeDownCast_26((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSQLQuery = (vtkSQLQuery)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSQLQuery.Register(null);
				}
			}
			return vtkSQLQuery;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern byte vtkSQLQuery_SetQuery_27(HandleRef pThis, string query);

		public virtual bool SetQuery(string query)
		{
			return vtkSQLQuery.vtkSQLQuery_SetQuery_27(base.GetCppThis(), query) != 0;
		}
	}
}
