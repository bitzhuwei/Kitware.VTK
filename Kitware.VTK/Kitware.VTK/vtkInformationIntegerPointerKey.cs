using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkInformationIntegerPointerKey : vtkInformationKey
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkInformationIntegerPointerKey";

		public new static readonly string MRClassNameKey;

		static vtkInformationIntegerPointerKey()
		{
			vtkInformationIntegerPointerKey.MRClassNameKey = "class vtkInformationIntegerPointerKey";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkInformationIntegerPointerKey.MRClassNameKey, Type.GetType("Kitware.VTK.vtkInformationIntegerPointerKey"));
		}

		public vtkInformationIntegerPointerKey(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkInformationIntegerPointerKey_Get_01(HandleRef pThis, HandleRef info);

		public IntPtr Get(vtkInformation info)
		{
			return vtkInformationIntegerPointerKey.vtkInformationIntegerPointerKey_Get_01(base.GetCppThis(), (info == null) ? default(HandleRef) : info.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkInformationIntegerPointerKey_Get_02(HandleRef pThis, HandleRef info, IntPtr value);

		public void Get(vtkInformation info, IntPtr value)
		{
			vtkInformationIntegerPointerKey.vtkInformationIntegerPointerKey_Get_02(base.GetCppThis(), (info == null) ? default(HandleRef) : info.GetCppThis(), value);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkInformationIntegerPointerKey_IsA_03(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkInformationIntegerPointerKey.vtkInformationIntegerPointerKey_IsA_03(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkInformationIntegerPointerKey_IsTypeOf_04(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkInformationIntegerPointerKey.vtkInformationIntegerPointerKey_IsTypeOf_04(type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkInformationIntegerPointerKey_Length_05(HandleRef pThis, HandleRef info);

		public int Length(vtkInformation info)
		{
			return vtkInformationIntegerPointerKey.vtkInformationIntegerPointerKey_Length_05(base.GetCppThis(), (info == null) ? default(HandleRef) : info.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkInformationIntegerPointerKey_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkInformationIntegerPointerKey NewInstance()
		{
			vtkInformationIntegerPointerKey result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkInformationIntegerPointerKey.vtkInformationIntegerPointerKey_NewInstance_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkInformationIntegerPointerKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkInformationIntegerPointerKey_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkInformationIntegerPointerKey SafeDownCast(vtkObjectBase o)
		{
			vtkInformationIntegerPointerKey vtkInformationIntegerPointerKey = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkInformationIntegerPointerKey.vtkInformationIntegerPointerKey_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationIntegerPointerKey = (vtkInformationIntegerPointerKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationIntegerPointerKey.Register(null);
				}
			}
			return vtkInformationIntegerPointerKey;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkInformationIntegerPointerKey_Set_08(HandleRef pThis, HandleRef info, IntPtr value, int length);

		public void Set(vtkInformation info, IntPtr value, int length)
		{
			vtkInformationIntegerPointerKey.vtkInformationIntegerPointerKey_Set_08(base.GetCppThis(), (info == null) ? default(HandleRef) : info.GetCppThis(), value, length);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkInformationIntegerPointerKey_ShallowCopy_09(HandleRef pThis, HandleRef from, HandleRef to);

		public override void ShallowCopy(vtkInformation from, vtkInformation to)
		{
			vtkInformationIntegerPointerKey.vtkInformationIntegerPointerKey_ShallowCopy_09(base.GetCppThis(), (from == null) ? default(HandleRef) : from.GetCppThis(), (to == null) ? default(HandleRef) : to.GetCppThis());
		}
	}
}
