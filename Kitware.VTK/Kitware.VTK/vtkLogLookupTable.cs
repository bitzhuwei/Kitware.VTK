using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkLogLookupTable : vtkLookupTable
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkLogLookupTable";

		public new static readonly string MRClassNameKey;

		static vtkLogLookupTable()
		{
			vtkLogLookupTable.MRClassNameKey = "class vtkLogLookupTable";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkLogLookupTable.MRClassNameKey, Type.GetType("Kitware.VTK.vtkLogLookupTable"));
		}

		public vtkLogLookupTable(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkLogLookupTable_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkLogLookupTable New()
		{
			vtkLogLookupTable result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkLogLookupTable.vtkLogLookupTable_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLogLookupTable)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkLogLookupTable() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkLogLookupTable.vtkLogLookupTable_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkLogLookupTable_IsA_01(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkLogLookupTable.vtkLogLookupTable_IsA_01(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkLogLookupTable_IsTypeOf_02(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkLogLookupTable.vtkLogLookupTable_IsTypeOf_02(type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkLogLookupTable_NewInstance_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkLogLookupTable NewInstance()
		{
			vtkLogLookupTable result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkLogLookupTable.vtkLogLookupTable_NewInstance_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLogLookupTable)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkLogLookupTable_SafeDownCast_05(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkLogLookupTable SafeDownCast(vtkObjectBase o)
		{
			vtkLogLookupTable vtkLogLookupTable = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkLogLookupTable.vtkLogLookupTable_SafeDownCast_05((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkLogLookupTable = (vtkLogLookupTable)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkLogLookupTable.Register(null);
				}
			}
			return vtkLogLookupTable;
		}
	}
}
