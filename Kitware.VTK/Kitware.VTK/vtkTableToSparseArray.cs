using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkTableToSparseArray : vtkArrayDataAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkTableToSparseArray";

		public new static readonly string MRClassNameKey;

		static vtkTableToSparseArray()
		{
			vtkTableToSparseArray.MRClassNameKey = "class vtkTableToSparseArray";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTableToSparseArray.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTableToSparseArray"));
		}

		public vtkTableToSparseArray(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkTableToSparseArray_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkTableToSparseArray New()
		{
			vtkTableToSparseArray result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTableToSparseArray.vtkTableToSparseArray_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTableToSparseArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkTableToSparseArray() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkTableToSparseArray.vtkTableToSparseArray_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkTableToSparseArray_AddCoordinateColumn_01(HandleRef pThis, string name);

		public void AddCoordinateColumn(string name)
		{
			vtkTableToSparseArray.vtkTableToSparseArray_AddCoordinateColumn_01(base.GetCppThis(), name);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkTableToSparseArray_ClearCoordinateColumns_02(HandleRef pThis);

		public void ClearCoordinateColumns()
		{
			vtkTableToSparseArray.vtkTableToSparseArray_ClearCoordinateColumns_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkTableToSparseArray_GetValueColumn_03(HandleRef pThis);

		public string GetValueColumn()
		{
			return Marshal.PtrToStringAnsi(vtkTableToSparseArray.vtkTableToSparseArray_GetValueColumn_03(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkTableToSparseArray_IsA_04(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkTableToSparseArray.vtkTableToSparseArray_IsA_04(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkTableToSparseArray_IsTypeOf_05(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkTableToSparseArray.vtkTableToSparseArray_IsTypeOf_05(type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkTableToSparseArray_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkTableToSparseArray NewInstance()
		{
			vtkTableToSparseArray result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTableToSparseArray.vtkTableToSparseArray_NewInstance_07(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTableToSparseArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkTableToSparseArray_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkTableToSparseArray SafeDownCast(vtkObjectBase o)
		{
			vtkTableToSparseArray vtkTableToSparseArray = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTableToSparseArray.vtkTableToSparseArray_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTableToSparseArray = (vtkTableToSparseArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTableToSparseArray.Register(null);
				}
			}
			return vtkTableToSparseArray;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkTableToSparseArray_SetValueColumn_09(HandleRef pThis, string name);

		public void SetValueColumn(string name)
		{
			vtkTableToSparseArray.vtkTableToSparseArray_SetValueColumn_09(base.GetCppThis(), name);
		}
	}
}
