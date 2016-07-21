using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkInformationUnsignedLongKey : vtkInformationKey
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkInformationUnsignedLongKey";

		public new static readonly string MRClassNameKey;

		static vtkInformationUnsignedLongKey()
		{
			vtkInformationUnsignedLongKey.MRClassNameKey = "class vtkInformationUnsignedLongKey";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkInformationUnsignedLongKey.MRClassNameKey, Type.GetType("Kitware.VTK.vtkInformationUnsignedLongKey"));
		}

		public vtkInformationUnsignedLongKey(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern uint vtkInformationUnsignedLongKey_Get_01(HandleRef pThis, HandleRef info);

		public uint Get(vtkInformation info)
		{
			return vtkInformationUnsignedLongKey.vtkInformationUnsignedLongKey_Get_01(base.GetCppThis(), (info == null) ? default(HandleRef) : info.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkInformationUnsignedLongKey_IsA_02(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkInformationUnsignedLongKey.vtkInformationUnsignedLongKey_IsA_02(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkInformationUnsignedLongKey_IsTypeOf_03(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkInformationUnsignedLongKey.vtkInformationUnsignedLongKey_IsTypeOf_03(type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkInformationUnsignedLongKey_NewInstance_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkInformationUnsignedLongKey NewInstance()
		{
			vtkInformationUnsignedLongKey result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkInformationUnsignedLongKey.vtkInformationUnsignedLongKey_NewInstance_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkInformationUnsignedLongKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkInformationUnsignedLongKey_SafeDownCast_05(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkInformationUnsignedLongKey SafeDownCast(vtkObjectBase o)
		{
			vtkInformationUnsignedLongKey vtkInformationUnsignedLongKey = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkInformationUnsignedLongKey.vtkInformationUnsignedLongKey_SafeDownCast_05((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationUnsignedLongKey = (vtkInformationUnsignedLongKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationUnsignedLongKey.Register(null);
				}
			}
			return vtkInformationUnsignedLongKey;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkInformationUnsignedLongKey_Set_06(HandleRef pThis, HandleRef info, uint arg1);

		public void Set(vtkInformation info, uint arg1)
		{
			vtkInformationUnsignedLongKey.vtkInformationUnsignedLongKey_Set_06(base.GetCppThis(), (info == null) ? default(HandleRef) : info.GetCppThis(), arg1);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkInformationUnsignedLongKey_ShallowCopy_07(HandleRef pThis, HandleRef from, HandleRef to);

		public override void ShallowCopy(vtkInformation from, vtkInformation to)
		{
			vtkInformationUnsignedLongKey.vtkInformationUnsignedLongKey_ShallowCopy_07(base.GetCppThis(), (from == null) ? default(HandleRef) : from.GetCppThis(), (to == null) ? default(HandleRef) : to.GetCppThis());
		}
	}
}
