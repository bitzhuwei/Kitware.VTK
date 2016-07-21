using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public abstract class vtkRowQuery : vtkObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkRowQuery";

		public new static readonly string MRClassNameKey;

		static vtkRowQuery()
		{
			vtkRowQuery.MRClassNameKey = "class vtkRowQuery";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkRowQuery.MRClassNameKey, Type.GetType("Kitware.VTK.vtkRowQuery"));
		}

		public vtkRowQuery(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkRowQuery_CaseSensitiveFieldNamesOff_01(HandleRef pThis);

		public virtual void CaseSensitiveFieldNamesOff()
		{
			vtkRowQuery.vtkRowQuery_CaseSensitiveFieldNamesOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkRowQuery_CaseSensitiveFieldNamesOn_02(HandleRef pThis);

		public virtual void CaseSensitiveFieldNamesOn()
		{
			vtkRowQuery.vtkRowQuery_CaseSensitiveFieldNamesOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern byte vtkRowQuery_Execute_03(HandleRef pThis);

		public virtual bool Execute()
		{
			return vtkRowQuery.vtkRowQuery_Execute_03(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern byte vtkRowQuery_GetCaseSensitiveFieldNames_04(HandleRef pThis);

		public virtual bool GetCaseSensitiveFieldNames()
		{
			return vtkRowQuery.vtkRowQuery_GetCaseSensitiveFieldNames_04(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkRowQuery_GetFieldIndex_05(HandleRef pThis, string name);

		public int GetFieldIndex(string name)
		{
			return vtkRowQuery.vtkRowQuery_GetFieldIndex_05(base.GetCppThis(), name);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkRowQuery_GetFieldName_06(HandleRef pThis, int i);

		public virtual string GetFieldName(int i)
		{
			return Marshal.PtrToStringAnsi(vtkRowQuery.vtkRowQuery_GetFieldName_06(base.GetCppThis(), i));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkRowQuery_GetFieldType_07(HandleRef pThis, int i);

		public virtual int GetFieldType(int i)
		{
			return vtkRowQuery.vtkRowQuery_GetFieldType_07(base.GetCppThis(), i);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkRowQuery_GetLastErrorText_08(HandleRef pThis);

		public virtual string GetLastErrorText()
		{
			return Marshal.PtrToStringAnsi(vtkRowQuery.vtkRowQuery_GetLastErrorText_08(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkRowQuery_GetNumberOfFields_09(HandleRef pThis);

		public virtual int GetNumberOfFields()
		{
			return vtkRowQuery.vtkRowQuery_GetNumberOfFields_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern byte vtkRowQuery_HasError_10(HandleRef pThis);

		public virtual bool HasError()
		{
			return vtkRowQuery.vtkRowQuery_HasError_10(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkRowQuery_IsA_11(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkRowQuery.vtkRowQuery_IsA_11(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern byte vtkRowQuery_IsActive_12(HandleRef pThis);

		public virtual bool IsActive()
		{
			return vtkRowQuery.vtkRowQuery_IsActive_12(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkRowQuery_IsTypeOf_13(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkRowQuery.vtkRowQuery_IsTypeOf_13(type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkRowQuery_NewInstance_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkRowQuery NewInstance()
		{
			vtkRowQuery result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkRowQuery.vtkRowQuery_NewInstance_14(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRowQuery)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern byte vtkRowQuery_NextRow_15(HandleRef pThis);

		public virtual bool NextRow()
		{
			return vtkRowQuery.vtkRowQuery_NextRow_15(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern byte vtkRowQuery_NextRow_16(HandleRef pThis, HandleRef rowArray);

		public bool NextRow(vtkVariantArray rowArray)
		{
			return vtkRowQuery.vtkRowQuery_NextRow_16(base.GetCppThis(), (rowArray == null) ? default(HandleRef) : rowArray.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkRowQuery_SafeDownCast_17(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkRowQuery SafeDownCast(vtkObjectBase o)
		{
			vtkRowQuery vtkRowQuery = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkRowQuery.vtkRowQuery_SafeDownCast_17((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern void vtkRowQuery_SetCaseSensitiveFieldNames_18(HandleRef pThis, byte _arg);

		public virtual void SetCaseSensitiveFieldNames(bool _arg)
		{
			vtkRowQuery.vtkRowQuery_SetCaseSensitiveFieldNames_18(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}
	}
}
