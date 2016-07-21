using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkArrayData : vtkDataObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkArrayData";

		public new static readonly string MRClassNameKey;

		static vtkArrayData()
		{
			vtkArrayData.MRClassNameKey = "class vtkArrayData";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkArrayData.MRClassNameKey, Type.GetType("Kitware.VTK.vtkArrayData"));
		}

		public vtkArrayData(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkArrayData_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkArrayData New()
		{
			vtkArrayData result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkArrayData.vtkArrayData_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkArrayData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkArrayData() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkArrayData.vtkArrayData_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkArrayData_AddArray_01(HandleRef pThis, HandleRef arg0);

		public void AddArray(vtkArray arg0)
		{
			vtkArrayData.vtkArrayData_AddArray_01(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkArrayData_ClearArrays_02(HandleRef pThis);

		public void ClearArrays()
		{
			vtkArrayData.vtkArrayData_ClearArrays_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkArrayData_DeepCopy_03(HandleRef pThis, HandleRef other);

		public override void DeepCopy(vtkDataObject other)
		{
			vtkArrayData.vtkArrayData_DeepCopy_03(base.GetCppThis(), (other == null) ? default(HandleRef) : other.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkArrayData_GetArray_04(HandleRef pThis, long index, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkArray GetArray(long index)
		{
			vtkArray vtkArray = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkArrayData.vtkArrayData_GetArray_04(base.GetCppThis(), index, ref mteStatus, ref mteIndex, ref rawRefCount);
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

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkArrayData_GetArrayByName_05(HandleRef pThis, string name, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkArray GetArrayByName(string name)
		{
			vtkArray vtkArray = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkArrayData.vtkArrayData_GetArrayByName_05(base.GetCppThis(), name, ref mteStatus, ref mteIndex, ref rawRefCount);
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

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkArrayData_GetData_06(HandleRef info, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkArrayData GetData(vtkInformation info)
		{
			vtkArrayData vtkArrayData = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkArrayData.vtkArrayData_GetData_06((info == null) ? default(HandleRef) : info.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkArrayData = (vtkArrayData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkArrayData.Register(null);
				}
			}
			return vtkArrayData;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkArrayData_GetData_07(HandleRef v, int i, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkArrayData GetData(vtkInformationVector v, int i)
		{
			vtkArrayData vtkArrayData = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkArrayData.vtkArrayData_GetData_07((v == null) ? default(HandleRef) : v.GetCppThis(), i, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkArrayData = (vtkArrayData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkArrayData.Register(null);
				}
			}
			return vtkArrayData;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkArrayData_GetDataObjectType_08(HandleRef pThis);

		public override int GetDataObjectType()
		{
			return vtkArrayData.vtkArrayData_GetDataObjectType_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern long vtkArrayData_GetNumberOfArrays_09(HandleRef pThis);

		public long GetNumberOfArrays()
		{
			return vtkArrayData.vtkArrayData_GetNumberOfArrays_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkArrayData_IsA_10(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkArrayData.vtkArrayData_IsA_10(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkArrayData_IsTypeOf_11(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkArrayData.vtkArrayData_IsTypeOf_11(type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkArrayData_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkArrayData NewInstance()
		{
			vtkArrayData result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkArrayData.vtkArrayData_NewInstance_13(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkArrayData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkArrayData_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkArrayData SafeDownCast(vtkObjectBase o)
		{
			vtkArrayData vtkArrayData = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkArrayData.vtkArrayData_SafeDownCast_14((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkArrayData = (vtkArrayData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkArrayData.Register(null);
				}
			}
			return vtkArrayData;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkArrayData_ShallowCopy_15(HandleRef pThis, HandleRef other);

		public override void ShallowCopy(vtkDataObject other)
		{
			vtkArrayData.vtkArrayData_ShallowCopy_15(base.GetCppThis(), (other == null) ? default(HandleRef) : other.GetCppThis());
		}
	}
}
