using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkInformationStringVectorKey : vtkInformationKey
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkInformationStringVectorKey";

		public new static readonly string MRClassNameKey;

		static vtkInformationStringVectorKey()
		{
			vtkInformationStringVectorKey.MRClassNameKey = "class vtkInformationStringVectorKey";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkInformationStringVectorKey.MRClassNameKey, Type.GetType("Kitware.VTK.vtkInformationStringVectorKey"));
		}

		public vtkInformationStringVectorKey(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkInformationStringVectorKey_Append_01(HandleRef pThis, HandleRef info, string value);

		public void Append(vtkInformation info, string value)
		{
			vtkInformationStringVectorKey.vtkInformationStringVectorKey_Append_01(base.GetCppThis(), (info == null) ? default(HandleRef) : info.GetCppThis(), value);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkInformationStringVectorKey_Get_02(HandleRef pThis, HandleRef info, int idx);

		public string Get(vtkInformation info, int idx)
		{
			return Marshal.PtrToStringAnsi(vtkInformationStringVectorKey.vtkInformationStringVectorKey_Get_02(base.GetCppThis(), (info == null) ? default(HandleRef) : info.GetCppThis(), idx));
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkInformationStringVectorKey_IsA_03(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkInformationStringVectorKey.vtkInformationStringVectorKey_IsA_03(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkInformationStringVectorKey_IsTypeOf_04(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkInformationStringVectorKey.vtkInformationStringVectorKey_IsTypeOf_04(type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkInformationStringVectorKey_Length_05(HandleRef pThis, HandleRef info);

		public int Length(vtkInformation info)
		{
			return vtkInformationStringVectorKey.vtkInformationStringVectorKey_Length_05(base.GetCppThis(), (info == null) ? default(HandleRef) : info.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkInformationStringVectorKey_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkInformationStringVectorKey NewInstance()
		{
			vtkInformationStringVectorKey result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkInformationStringVectorKey.vtkInformationStringVectorKey_NewInstance_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkInformationStringVectorKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkInformationStringVectorKey_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkInformationStringVectorKey SafeDownCast(vtkObjectBase o)
		{
			vtkInformationStringVectorKey vtkInformationStringVectorKey = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkInformationStringVectorKey.vtkInformationStringVectorKey_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationStringVectorKey = (vtkInformationStringVectorKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationStringVectorKey.Register(null);
				}
			}
			return vtkInformationStringVectorKey;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkInformationStringVectorKey_Set_08(HandleRef pThis, HandleRef info, string value, int idx);

		public void Set(vtkInformation info, string value, int idx)
		{
			vtkInformationStringVectorKey.vtkInformationStringVectorKey_Set_08(base.GetCppThis(), (info == null) ? default(HandleRef) : info.GetCppThis(), value, idx);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkInformationStringVectorKey_ShallowCopy_09(HandleRef pThis, HandleRef from, HandleRef to);

		public override void ShallowCopy(vtkInformation from, vtkInformation to)
		{
			vtkInformationStringVectorKey.vtkInformationStringVectorKey_ShallowCopy_09(base.GetCppThis(), (from == null) ? default(HandleRef) : from.GetCppThis(), (to == null) ? default(HandleRef) : to.GetCppThis());
		}
	}
}
