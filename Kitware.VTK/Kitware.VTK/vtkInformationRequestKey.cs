using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkInformationRequestKey : vtkInformationKey
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkInformationRequestKey";

		public new static readonly string MRClassNameKey;

		static vtkInformationRequestKey()
		{
			vtkInformationRequestKey.MRClassNameKey = "class vtkInformationRequestKey";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkInformationRequestKey.MRClassNameKey, Type.GetType("Kitware.VTK.vtkInformationRequestKey"));
		}

		public vtkInformationRequestKey(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkInformationRequestKey_Has_01(HandleRef pThis, HandleRef info);

		public override int Has(vtkInformation info)
		{
			return vtkInformationRequestKey.vtkInformationRequestKey_Has_01(base.GetCppThis(), (info == null) ? default(HandleRef) : info.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkInformationRequestKey_IsA_02(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkInformationRequestKey.vtkInformationRequestKey_IsA_02(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkInformationRequestKey_IsTypeOf_03(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkInformationRequestKey.vtkInformationRequestKey_IsTypeOf_03(type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkInformationRequestKey_NewInstance_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkInformationRequestKey NewInstance()
		{
			vtkInformationRequestKey result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkInformationRequestKey.vtkInformationRequestKey_NewInstance_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkInformationRequestKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkInformationRequestKey_Remove_05(HandleRef pThis, HandleRef info);

		public override void Remove(vtkInformation info)
		{
			vtkInformationRequestKey.vtkInformationRequestKey_Remove_05(base.GetCppThis(), (info == null) ? default(HandleRef) : info.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkInformationRequestKey_SafeDownCast_06(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkInformationRequestKey SafeDownCast(vtkObjectBase o)
		{
			vtkInformationRequestKey vtkInformationRequestKey = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkInformationRequestKey.vtkInformationRequestKey_SafeDownCast_06((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationRequestKey = (vtkInformationRequestKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationRequestKey.Register(null);
				}
			}
			return vtkInformationRequestKey;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkInformationRequestKey_Set_07(HandleRef pThis, HandleRef info);

		public void Set(vtkInformation info)
		{
			vtkInformationRequestKey.vtkInformationRequestKey_Set_07(base.GetCppThis(), (info == null) ? default(HandleRef) : info.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkInformationRequestKey_ShallowCopy_08(HandleRef pThis, HandleRef from, HandleRef to);

		public override void ShallowCopy(vtkInformation from, vtkInformation to)
		{
			vtkInformationRequestKey.vtkInformationRequestKey_ShallowCopy_08(base.GetCppThis(), (from == null) ? default(HandleRef) : from.GetCppThis(), (to == null) ? default(HandleRef) : to.GetCppThis());
		}
	}
}
