using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkInformationStringKey : vtkInformationKey
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkInformationStringKey";

		public new static readonly string MRClassNameKey;

		static vtkInformationStringKey()
		{
			vtkInformationStringKey.MRClassNameKey = "class vtkInformationStringKey";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkInformationStringKey.MRClassNameKey, Type.GetType("Kitware.VTK.vtkInformationStringKey"));
		}

		public vtkInformationStringKey(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkInformationStringKey_Get_01(HandleRef pThis, HandleRef info);

		public string Get(vtkInformation info)
		{
			return Marshal.PtrToStringAnsi(vtkInformationStringKey.vtkInformationStringKey_Get_01(base.GetCppThis(), (info == null) ? default(HandleRef) : info.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkInformationStringKey_IsA_02(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkInformationStringKey.vtkInformationStringKey_IsA_02(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkInformationStringKey_IsTypeOf_03(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkInformationStringKey.vtkInformationStringKey_IsTypeOf_03(type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkInformationStringKey_NewInstance_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkInformationStringKey NewInstance()
		{
			vtkInformationStringKey result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkInformationStringKey.vtkInformationStringKey_NewInstance_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkInformationStringKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkInformationStringKey_SafeDownCast_05(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkInformationStringKey SafeDownCast(vtkObjectBase o)
		{
			vtkInformationStringKey vtkInformationStringKey = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkInformationStringKey.vtkInformationStringKey_SafeDownCast_05((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationStringKey = (vtkInformationStringKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationStringKey.Register(null);
				}
			}
			return vtkInformationStringKey;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkInformationStringKey_Set_06(HandleRef pThis, HandleRef info, string arg1);

		public void Set(vtkInformation info, string arg1)
		{
			vtkInformationStringKey.vtkInformationStringKey_Set_06(base.GetCppThis(), (info == null) ? default(HandleRef) : info.GetCppThis(), arg1);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkInformationStringKey_ShallowCopy_07(HandleRef pThis, HandleRef from, HandleRef to);

		public override void ShallowCopy(vtkInformation from, vtkInformation to)
		{
			vtkInformationStringKey.vtkInformationStringKey_ShallowCopy_07(base.GetCppThis(), (from == null) ? default(HandleRef) : from.GetCppThis(), (to == null) ? default(HandleRef) : to.GetCppThis());
		}
	}
}
