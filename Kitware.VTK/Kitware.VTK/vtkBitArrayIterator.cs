using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkBitArrayIterator : vtkArrayIterator
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkBitArrayIterator";

		public new static readonly string MRClassNameKey;

		static vtkBitArrayIterator()
		{
			vtkBitArrayIterator.MRClassNameKey = "class vtkBitArrayIterator";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkBitArrayIterator.MRClassNameKey, Type.GetType("Kitware.VTK.vtkBitArrayIterator"));
		}

		public vtkBitArrayIterator(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkBitArrayIterator_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkBitArrayIterator New()
		{
			vtkBitArrayIterator result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkBitArrayIterator.vtkBitArrayIterator_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkBitArrayIterator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkBitArrayIterator() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkBitArrayIterator.vtkBitArrayIterator_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkBitArrayIterator_GetArray_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkAbstractArray GetArray()
		{
			vtkAbstractArray vtkAbstractArray = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkBitArrayIterator.vtkBitArrayIterator_GetArray_01(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAbstractArray = (vtkAbstractArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAbstractArray.Register(null);
				}
			}
			return vtkAbstractArray;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkBitArrayIterator_GetDataType_02(HandleRef pThis);

		public override int GetDataType()
		{
			return vtkBitArrayIterator.vtkBitArrayIterator_GetDataType_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkBitArrayIterator_GetDataTypeSize_03(HandleRef pThis);

		public int GetDataTypeSize()
		{
			return vtkBitArrayIterator.vtkBitArrayIterator_GetDataTypeSize_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkBitArrayIterator_GetNumberOfComponents_04(HandleRef pThis);

		public int GetNumberOfComponents()
		{
			return vtkBitArrayIterator.vtkBitArrayIterator_GetNumberOfComponents_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern long vtkBitArrayIterator_GetNumberOfTuples_05(HandleRef pThis);

		public long GetNumberOfTuples()
		{
			return vtkBitArrayIterator.vtkBitArrayIterator_GetNumberOfTuples_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern long vtkBitArrayIterator_GetNumberOfValues_06(HandleRef pThis);

		public long GetNumberOfValues()
		{
			return vtkBitArrayIterator.vtkBitArrayIterator_GetNumberOfValues_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkBitArrayIterator_GetTuple_07(HandleRef pThis, long id);

		public IntPtr GetTuple(long id)
		{
			return vtkBitArrayIterator.vtkBitArrayIterator_GetTuple_07(base.GetCppThis(), id);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkBitArrayIterator_GetValue_08(HandleRef pThis, long id);

		public int GetValue(long id)
		{
			return vtkBitArrayIterator.vtkBitArrayIterator_GetValue_08(base.GetCppThis(), id);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkBitArrayIterator_Initialize_09(HandleRef pThis, HandleRef array);

		public override void Initialize(vtkAbstractArray array)
		{
			vtkBitArrayIterator.vtkBitArrayIterator_Initialize_09(base.GetCppThis(), (array == null) ? default(HandleRef) : array.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkBitArrayIterator_IsA_10(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkBitArrayIterator.vtkBitArrayIterator_IsA_10(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkBitArrayIterator_IsTypeOf_11(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkBitArrayIterator.vtkBitArrayIterator_IsTypeOf_11(type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkBitArrayIterator_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkBitArrayIterator NewInstance()
		{
			vtkBitArrayIterator result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkBitArrayIterator.vtkBitArrayIterator_NewInstance_13(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkBitArrayIterator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkBitArrayIterator_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkBitArrayIterator SafeDownCast(vtkObjectBase o)
		{
			vtkBitArrayIterator vtkBitArrayIterator = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkBitArrayIterator.vtkBitArrayIterator_SafeDownCast_14((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkBitArrayIterator = (vtkBitArrayIterator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkBitArrayIterator.Register(null);
				}
			}
			return vtkBitArrayIterator;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkBitArrayIterator_SetValue_15(HandleRef pThis, long id, int value);

		public void SetValue(long id, int value)
		{
			vtkBitArrayIterator.vtkBitArrayIterator_SetValue_15(base.GetCppThis(), id, value);
		}
	}
}
