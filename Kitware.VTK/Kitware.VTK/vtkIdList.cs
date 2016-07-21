using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkIdList : vtkObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkIdList";

		public new static readonly string MRClassNameKey;

		static vtkIdList()
		{
			vtkIdList.MRClassNameKey = "class vtkIdList";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkIdList.MRClassNameKey, Type.GetType("Kitware.VTK.vtkIdList"));
		}

		public vtkIdList(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkIdList_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkIdList New()
		{
			vtkIdList result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkIdList.vtkIdList_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkIdList)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkIdList() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkIdList.vtkIdList_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkIdList_Allocate_01(HandleRef pThis, long sz, int strategy);

		public int Allocate(long sz, int strategy)
		{
			return vtkIdList.vtkIdList_Allocate_01(base.GetCppThis(), sz, strategy);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkIdList_DeepCopy_02(HandleRef pThis, HandleRef ids);

		public void DeepCopy(vtkIdList ids)
		{
			vtkIdList.vtkIdList_DeepCopy_02(base.GetCppThis(), (ids == null) ? default(HandleRef) : ids.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkIdList_DeleteId_03(HandleRef pThis, long vtkid);

		public void DeleteId(long vtkid)
		{
			vtkIdList.vtkIdList_DeleteId_03(base.GetCppThis(), vtkid);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern long vtkIdList_GetId_04(HandleRef pThis, long i);

		public long GetId(long i)
		{
			return vtkIdList.vtkIdList_GetId_04(base.GetCppThis(), i);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern long vtkIdList_GetNumberOfIds_05(HandleRef pThis);

		public long GetNumberOfIds()
		{
			return vtkIdList.vtkIdList_GetNumberOfIds_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkIdList_GetPointer_06(HandleRef pThis, long i);

		public IntPtr GetPointer(long i)
		{
			return vtkIdList.vtkIdList_GetPointer_06(base.GetCppThis(), i);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkIdList_Initialize_07(HandleRef pThis);

		public void Initialize()
		{
			vtkIdList.vtkIdList_Initialize_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkIdList_InsertId_08(HandleRef pThis, long i, long vtkid);

		public void InsertId(long i, long vtkid)
		{
			vtkIdList.vtkIdList_InsertId_08(base.GetCppThis(), i, vtkid);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern long vtkIdList_InsertNextId_09(HandleRef pThis, long vtkid);

		public long InsertNextId(long vtkid)
		{
			return vtkIdList.vtkIdList_InsertNextId_09(base.GetCppThis(), vtkid);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern long vtkIdList_InsertUniqueId_10(HandleRef pThis, long vtkid);

		public long InsertUniqueId(long vtkid)
		{
			return vtkIdList.vtkIdList_InsertUniqueId_10(base.GetCppThis(), vtkid);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkIdList_IntersectWith_11(HandleRef pThis, HandleRef otherIds);

		public void IntersectWith(vtkIdList otherIds)
		{
			vtkIdList.vtkIdList_IntersectWith_11(base.GetCppThis(), (otherIds == null) ? default(HandleRef) : otherIds.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkIdList_IsA_12(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkIdList.vtkIdList_IsA_12(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern long vtkIdList_IsId_13(HandleRef pThis, long vtkid);

		public long IsId(long vtkid)
		{
			return vtkIdList.vtkIdList_IsId_13(base.GetCppThis(), vtkid);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkIdList_IsTypeOf_14(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkIdList.vtkIdList_IsTypeOf_14(type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkIdList_NewInstance_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkIdList NewInstance()
		{
			vtkIdList result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkIdList.vtkIdList_NewInstance_16(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkIdList)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkIdList_Reset_17(HandleRef pThis);

		public void Reset()
		{
			vtkIdList.vtkIdList_Reset_17(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkIdList_SafeDownCast_18(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkIdList SafeDownCast(vtkObjectBase o)
		{
			vtkIdList vtkIdList = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkIdList.vtkIdList_SafeDownCast_18((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkIdList = (vtkIdList)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkIdList.Register(null);
				}
			}
			return vtkIdList;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkIdList_SetId_19(HandleRef pThis, long i, long vtkid);

		public void SetId(long i, long vtkid)
		{
			vtkIdList.vtkIdList_SetId_19(base.GetCppThis(), i, vtkid);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkIdList_SetNumberOfIds_20(HandleRef pThis, long number);

		public void SetNumberOfIds(long number)
		{
			vtkIdList.vtkIdList_SetNumberOfIds_20(base.GetCppThis(), number);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkIdList_Squeeze_21(HandleRef pThis);

		public void Squeeze()
		{
			vtkIdList.vtkIdList_Squeeze_21(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkIdList_WritePointer_22(HandleRef pThis, long i, long number);

		public IntPtr WritePointer(long i, long number)
		{
			return vtkIdList.vtkIdList_WritePointer_22(base.GetCppThis(), i, number);
		}
	}
}
