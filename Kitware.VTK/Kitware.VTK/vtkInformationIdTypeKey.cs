using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkInformationIdTypeKey : vtkInformationKey
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkInformationIdTypeKey";

		public new static readonly string MRClassNameKey;

		static vtkInformationIdTypeKey()
		{
			vtkInformationIdTypeKey.MRClassNameKey = "class vtkInformationIdTypeKey";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkInformationIdTypeKey.MRClassNameKey, Type.GetType("Kitware.VTK.vtkInformationIdTypeKey"));
		}

		public vtkInformationIdTypeKey(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern long vtkInformationIdTypeKey_Get_01(HandleRef pThis, HandleRef info);

		public long Get(vtkInformation info)
		{
			return vtkInformationIdTypeKey.vtkInformationIdTypeKey_Get_01(base.GetCppThis(), (info == null) ? default(HandleRef) : info.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkInformationIdTypeKey_IsA_02(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkInformationIdTypeKey.vtkInformationIdTypeKey_IsA_02(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkInformationIdTypeKey_IsTypeOf_03(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkInformationIdTypeKey.vtkInformationIdTypeKey_IsTypeOf_03(type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkInformationIdTypeKey_NewInstance_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkInformationIdTypeKey NewInstance()
		{
			vtkInformationIdTypeKey result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkInformationIdTypeKey.vtkInformationIdTypeKey_NewInstance_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkInformationIdTypeKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkInformationIdTypeKey_SafeDownCast_05(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkInformationIdTypeKey SafeDownCast(vtkObjectBase o)
		{
			vtkInformationIdTypeKey vtkInformationIdTypeKey = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkInformationIdTypeKey.vtkInformationIdTypeKey_SafeDownCast_05((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationIdTypeKey = (vtkInformationIdTypeKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationIdTypeKey.Register(null);
				}
			}
			return vtkInformationIdTypeKey;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkInformationIdTypeKey_Set_06(HandleRef pThis, HandleRef info, long arg1);

		public void Set(vtkInformation info, long arg1)
		{
			vtkInformationIdTypeKey.vtkInformationIdTypeKey_Set_06(base.GetCppThis(), (info == null) ? default(HandleRef) : info.GetCppThis(), arg1);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkInformationIdTypeKey_ShallowCopy_07(HandleRef pThis, HandleRef from, HandleRef to);

		public override void ShallowCopy(vtkInformation from, vtkInformation to)
		{
			vtkInformationIdTypeKey.vtkInformationIdTypeKey_ShallowCopy_07(base.GetCppThis(), (from == null) ? default(HandleRef) : from.GetCppThis(), (to == null) ? default(HandleRef) : to.GetCppThis());
		}
	}
}
