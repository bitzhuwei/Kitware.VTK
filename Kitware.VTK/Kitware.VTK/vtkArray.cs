using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public abstract class vtkArray : vtkObject
	{
		public enum DENSE_WrapperEnum
		{
			DENSE,
			SPARSE
		}

		public new const string MRFullTypeName = "Kitware.VTK.vtkArray";

		public new static readonly string MRClassNameKey;

		static vtkArray()
		{
			vtkArray.MRClassNameKey = "class vtkArray";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkArray.MRClassNameKey, Type.GetType("Kitware.VTK.vtkArray"));
		}

		public vtkArray(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkArray_CreateArray_01(int StorageType, int ValueType, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public static vtkArray CreateArray(int StorageType, int ValueType)
		{
			vtkArray vtkArray = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkArray.vtkArray_CreateArray_01(StorageType, ValueType, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkArray = (vtkArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkArray.Register(null);
				}
			}
			return vtkArray;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkArray_DeepCopy_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkArray DeepCopy()
		{
			vtkArray vtkArray = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkArray.vtkArray_DeepCopy_02(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkArray = (vtkArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkArray.Register(null);
				}
			}
			return vtkArray;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern long vtkArray_GetDimensions_03(HandleRef pThis);

		public long GetDimensions()
		{
			return vtkArray.vtkArray_GetDimensions_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern ulong vtkArray_GetNonNullSize_04(HandleRef pThis);

		public virtual ulong GetNonNullSize()
		{
			return vtkArray.vtkArray_GetNonNullSize_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern ulong vtkArray_GetSize_05(HandleRef pThis);

		public ulong GetSize()
		{
			return vtkArray.vtkArray_GetSize_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkArray_IsA_06(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkArray.vtkArray_IsA_06(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern byte vtkArray_IsDense_07(HandleRef pThis);

		public virtual bool IsDense()
		{
			return vtkArray.vtkArray_IsDense_07(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkArray_IsTypeOf_08(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkArray.vtkArray_IsTypeOf_08(type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkArray_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkArray NewInstance()
		{
			vtkArray result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkArray.vtkArray_NewInstance_09(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkArray_Resize_10(HandleRef pThis, long i);

		public void Resize(long i)
		{
			vtkArray.vtkArray_Resize_10(base.GetCppThis(), i);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkArray_Resize_11(HandleRef pThis, long i, long j);

		public void Resize(long i, long j)
		{
			vtkArray.vtkArray_Resize_11(base.GetCppThis(), i, j);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkArray_Resize_12(HandleRef pThis, long i, long j, long k);

		public void Resize(long i, long j, long k)
		{
			vtkArray.vtkArray_Resize_12(base.GetCppThis(), i, j, k);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkArray_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkArray SafeDownCast(vtkObjectBase o)
		{
			vtkArray vtkArray = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkArray.vtkArray_SafeDownCast_13((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkArray = (vtkArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkArray.Register(null);
				}
			}
			return vtkArray;
		}
	}
}
