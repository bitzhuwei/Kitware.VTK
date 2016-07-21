using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkInformationObjectBaseVectorKey : vtkInformationKey
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkInformationObjectBaseVectorKey";

		public new static readonly string MRClassNameKey;

		static vtkInformationObjectBaseVectorKey()
		{
			vtkInformationObjectBaseVectorKey.MRClassNameKey = "class vtkInformationObjectBaseVectorKey";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkInformationObjectBaseVectorKey.MRClassNameKey, Type.GetType("Kitware.VTK.vtkInformationObjectBaseVectorKey"));
		}

		public vtkInformationObjectBaseVectorKey(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkInformationObjectBaseVectorKey_Append_01(HandleRef pThis, HandleRef info, HandleRef value);

		public void Append(vtkInformation info, vtkObjectBase value)
		{
			vtkInformationObjectBaseVectorKey.vtkInformationObjectBaseVectorKey_Append_01(base.GetCppThis(), (info == null) ? default(HandleRef) : info.GetCppThis(), (value == null) ? default(HandleRef) : value.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkInformationObjectBaseVectorKey_Clear_02(HandleRef pThis, HandleRef info);

		public void Clear(vtkInformation info)
		{
			vtkInformationObjectBaseVectorKey.vtkInformationObjectBaseVectorKey_Clear_02(base.GetCppThis(), (info == null) ? default(HandleRef) : info.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkInformationObjectBaseVectorKey_Get_03(HandleRef pThis, HandleRef info, int idx, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkObjectBase Get(vtkInformation info, int idx)
		{
			vtkObjectBase vtkObjectBase = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkInformationObjectBaseVectorKey.vtkInformationObjectBaseVectorKey_Get_03(base.GetCppThis(), (info == null) ? default(HandleRef) : info.GetCppThis(), idx, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkObjectBase = (vtkObjectBase)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkObjectBase.Register(null);
				}
			}
			return vtkObjectBase;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkInformationObjectBaseVectorKey_IsA_04(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkInformationObjectBaseVectorKey.vtkInformationObjectBaseVectorKey_IsA_04(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkInformationObjectBaseVectorKey_IsTypeOf_05(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkInformationObjectBaseVectorKey.vtkInformationObjectBaseVectorKey_IsTypeOf_05(type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkInformationObjectBaseVectorKey_Length_06(HandleRef pThis, HandleRef info);

		public int Length(vtkInformation info)
		{
			return vtkInformationObjectBaseVectorKey.vtkInformationObjectBaseVectorKey_Length_06(base.GetCppThis(), (info == null) ? default(HandleRef) : info.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkInformationObjectBaseVectorKey_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkInformationObjectBaseVectorKey NewInstance()
		{
			vtkInformationObjectBaseVectorKey result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkInformationObjectBaseVectorKey.vtkInformationObjectBaseVectorKey_NewInstance_07(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkInformationObjectBaseVectorKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkInformationObjectBaseVectorKey_Resize_08(HandleRef pThis, HandleRef info, int n);

		public void Resize(vtkInformation info, int n)
		{
			vtkInformationObjectBaseVectorKey.vtkInformationObjectBaseVectorKey_Resize_08(base.GetCppThis(), (info == null) ? default(HandleRef) : info.GetCppThis(), n);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkInformationObjectBaseVectorKey_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkInformationObjectBaseVectorKey SafeDownCast(vtkObjectBase o)
		{
			vtkInformationObjectBaseVectorKey vtkInformationObjectBaseVectorKey = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkInformationObjectBaseVectorKey.vtkInformationObjectBaseVectorKey_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationObjectBaseVectorKey = (vtkInformationObjectBaseVectorKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationObjectBaseVectorKey.Register(null);
				}
			}
			return vtkInformationObjectBaseVectorKey;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkInformationObjectBaseVectorKey_Set_10(HandleRef pThis, HandleRef info, HandleRef value, int i);

		public void Set(vtkInformation info, vtkObjectBase value, int i)
		{
			vtkInformationObjectBaseVectorKey.vtkInformationObjectBaseVectorKey_Set_10(base.GetCppThis(), (info == null) ? default(HandleRef) : info.GetCppThis(), (value == null) ? default(HandleRef) : value.GetCppThis(), i);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkInformationObjectBaseVectorKey_ShallowCopy_11(HandleRef pThis, HandleRef from, HandleRef to);

		public override void ShallowCopy(vtkInformation from, vtkInformation to)
		{
			vtkInformationObjectBaseVectorKey.vtkInformationObjectBaseVectorKey_ShallowCopy_11(base.GetCppThis(), (from == null) ? default(HandleRef) : from.GetCppThis(), (to == null) ? default(HandleRef) : to.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkInformationObjectBaseVectorKey_Size_12(HandleRef pThis, HandleRef info);

		public int Size(vtkInformation info)
		{
			return vtkInformationObjectBaseVectorKey.vtkInformationObjectBaseVectorKey_Size_12(base.GetCppThis(), (info == null) ? default(HandleRef) : info.GetCppThis());
		}
	}
}
