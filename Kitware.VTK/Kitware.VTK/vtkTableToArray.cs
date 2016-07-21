using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkTableToArray : vtkArrayDataAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkTableToArray";

		public new static readonly string MRClassNameKey;

		static vtkTableToArray()
		{
			vtkTableToArray.MRClassNameKey = "class vtkTableToArray";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTableToArray.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTableToArray"));
		}

		public vtkTableToArray(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkTableToArray_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkTableToArray New()
		{
			vtkTableToArray result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTableToArray.vtkTableToArray_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTableToArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkTableToArray() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkTableToArray.vtkTableToArray_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkTableToArray_AddAllColumns_01(HandleRef pThis);

		public void AddAllColumns()
		{
			vtkTableToArray.vtkTableToArray_AddAllColumns_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkTableToArray_AddColumn_02(HandleRef pThis, string name);

		public void AddColumn(string name)
		{
			vtkTableToArray.vtkTableToArray_AddColumn_02(base.GetCppThis(), name);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkTableToArray_AddColumn_03(HandleRef pThis, long index);

		public void AddColumn(long index)
		{
			vtkTableToArray.vtkTableToArray_AddColumn_03(base.GetCppThis(), index);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkTableToArray_ClearColumns_04(HandleRef pThis);

		public void ClearColumns()
		{
			vtkTableToArray.vtkTableToArray_ClearColumns_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkTableToArray_IsA_05(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkTableToArray.vtkTableToArray_IsA_05(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkTableToArray_IsTypeOf_06(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkTableToArray.vtkTableToArray_IsTypeOf_06(type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkTableToArray_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkTableToArray NewInstance()
		{
			vtkTableToArray result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTableToArray.vtkTableToArray_NewInstance_08(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTableToArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkTableToArray_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkTableToArray SafeDownCast(vtkObjectBase o)
		{
			vtkTableToArray vtkTableToArray = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTableToArray.vtkTableToArray_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTableToArray = (vtkTableToArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTableToArray.Register(null);
				}
			}
			return vtkTableToArray;
		}
	}
}
