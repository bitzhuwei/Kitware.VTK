using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkSortDataArray : vtkObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkSortDataArray";

		public new static readonly string MRClassNameKey;

		static vtkSortDataArray()
		{
			vtkSortDataArray.MRClassNameKey = "class vtkSortDataArray";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSortDataArray.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSortDataArray"));
		}

		public vtkSortDataArray(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkSortDataArray_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkSortDataArray New()
		{
			vtkSortDataArray result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSortDataArray.vtkSortDataArray_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSortDataArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkSortDataArray() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkSortDataArray.vtkSortDataArray_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkSortDataArray_IsA_01(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkSortDataArray.vtkSortDataArray_IsA_01(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkSortDataArray_IsTypeOf_02(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkSortDataArray.vtkSortDataArray_IsTypeOf_02(type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkSortDataArray_NewInstance_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkSortDataArray NewInstance()
		{
			vtkSortDataArray result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSortDataArray.vtkSortDataArray_NewInstance_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSortDataArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkSortDataArray_SafeDownCast_05(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkSortDataArray SafeDownCast(vtkObjectBase o)
		{
			vtkSortDataArray vtkSortDataArray = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSortDataArray.vtkSortDataArray_SafeDownCast_05((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSortDataArray = (vtkSortDataArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSortDataArray.Register(null);
				}
			}
			return vtkSortDataArray;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkSortDataArray_Sort_06(HandleRef keys);

		public static void Sort(vtkIdList keys)
		{
			vtkSortDataArray.vtkSortDataArray_Sort_06((keys == null) ? default(HandleRef) : keys.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkSortDataArray_Sort_07(HandleRef keys);

		public static void Sort(vtkAbstractArray keys)
		{
			vtkSortDataArray.vtkSortDataArray_Sort_07((keys == null) ? default(HandleRef) : keys.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkSortDataArray_Sort_08(HandleRef keys, HandleRef values);

		public static void Sort(vtkIdList keys, vtkIdList values)
		{
			vtkSortDataArray.vtkSortDataArray_Sort_08((keys == null) ? default(HandleRef) : keys.GetCppThis(), (values == null) ? default(HandleRef) : values.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkSortDataArray_Sort_09(HandleRef keys, HandleRef values);

		public static void Sort(vtkIdList keys, vtkAbstractArray values)
		{
			vtkSortDataArray.vtkSortDataArray_Sort_09((keys == null) ? default(HandleRef) : keys.GetCppThis(), (values == null) ? default(HandleRef) : values.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkSortDataArray_Sort_10(HandleRef keys, HandleRef values);

		public static void Sort(vtkAbstractArray keys, vtkIdList values)
		{
			vtkSortDataArray.vtkSortDataArray_Sort_10((keys == null) ? default(HandleRef) : keys.GetCppThis(), (values == null) ? default(HandleRef) : values.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkSortDataArray_Sort_11(HandleRef keys, HandleRef values);

		public static void Sort(vtkAbstractArray keys, vtkAbstractArray values)
		{
			vtkSortDataArray.vtkSortDataArray_Sort_11((keys == null) ? default(HandleRef) : keys.GetCppThis(), (values == null) ? default(HandleRef) : values.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkSortDataArray_SortArrayByComponent_12(HandleRef arr, int k);

		public static void SortArrayByComponent(vtkAbstractArray arr, int k)
		{
			vtkSortDataArray.vtkSortDataArray_SortArrayByComponent_12((arr == null) ? default(HandleRef) : arr.GetCppThis(), k);
		}
	}
}
