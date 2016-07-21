using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkInformationIntegerVectorKey : vtkInformationKey
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkInformationIntegerVectorKey";

		public new static readonly string MRClassNameKey;

		static vtkInformationIntegerVectorKey()
		{
			vtkInformationIntegerVectorKey.MRClassNameKey = "class vtkInformationIntegerVectorKey";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkInformationIntegerVectorKey.MRClassNameKey, Type.GetType("Kitware.VTK.vtkInformationIntegerVectorKey"));
		}

		public vtkInformationIntegerVectorKey(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkInformationIntegerVectorKey_Append_01(HandleRef pThis, HandleRef info, int value);

		public void Append(vtkInformation info, int value)
		{
			vtkInformationIntegerVectorKey.vtkInformationIntegerVectorKey_Append_01(base.GetCppThis(), (info == null) ? default(HandleRef) : info.GetCppThis(), value);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkInformationIntegerVectorKey_Get_02(HandleRef pThis, HandleRef info);

		public IntPtr Get(vtkInformation info)
		{
			return vtkInformationIntegerVectorKey.vtkInformationIntegerVectorKey_Get_02(base.GetCppThis(), (info == null) ? default(HandleRef) : info.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkInformationIntegerVectorKey_Get_03(HandleRef pThis, HandleRef info, int idx);

		public int Get(vtkInformation info, int idx)
		{
			return vtkInformationIntegerVectorKey.vtkInformationIntegerVectorKey_Get_03(base.GetCppThis(), (info == null) ? default(HandleRef) : info.GetCppThis(), idx);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkInformationIntegerVectorKey_Get_04(HandleRef pThis, HandleRef info, IntPtr value);

		public void Get(vtkInformation info, IntPtr value)
		{
			vtkInformationIntegerVectorKey.vtkInformationIntegerVectorKey_Get_04(base.GetCppThis(), (info == null) ? default(HandleRef) : info.GetCppThis(), value);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkInformationIntegerVectorKey_IsA_05(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkInformationIntegerVectorKey.vtkInformationIntegerVectorKey_IsA_05(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkInformationIntegerVectorKey_IsTypeOf_06(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkInformationIntegerVectorKey.vtkInformationIntegerVectorKey_IsTypeOf_06(type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkInformationIntegerVectorKey_Length_07(HandleRef pThis, HandleRef info);

		public int Length(vtkInformation info)
		{
			return vtkInformationIntegerVectorKey.vtkInformationIntegerVectorKey_Length_07(base.GetCppThis(), (info == null) ? default(HandleRef) : info.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkInformationIntegerVectorKey_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkInformationIntegerVectorKey NewInstance()
		{
			vtkInformationIntegerVectorKey result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkInformationIntegerVectorKey.vtkInformationIntegerVectorKey_NewInstance_08(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkInformationIntegerVectorKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkInformationIntegerVectorKey_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkInformationIntegerVectorKey SafeDownCast(vtkObjectBase o)
		{
			vtkInformationIntegerVectorKey vtkInformationIntegerVectorKey = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkInformationIntegerVectorKey.vtkInformationIntegerVectorKey_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationIntegerVectorKey = (vtkInformationIntegerVectorKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationIntegerVectorKey.Register(null);
				}
			}
			return vtkInformationIntegerVectorKey;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkInformationIntegerVectorKey_Set_10(HandleRef pThis, HandleRef info, IntPtr value, int length);

		public void Set(vtkInformation info, IntPtr value, int length)
		{
			vtkInformationIntegerVectorKey.vtkInformationIntegerVectorKey_Set_10(base.GetCppThis(), (info == null) ? default(HandleRef) : info.GetCppThis(), value, length);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkInformationIntegerVectorKey_Set_11(HandleRef pThis, HandleRef info);

		public void Set(vtkInformation info)
		{
			vtkInformationIntegerVectorKey.vtkInformationIntegerVectorKey_Set_11(base.GetCppThis(), (info == null) ? default(HandleRef) : info.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkInformationIntegerVectorKey_ShallowCopy_12(HandleRef pThis, HandleRef from, HandleRef to);

		public override void ShallowCopy(vtkInformation from, vtkInformation to)
		{
			vtkInformationIntegerVectorKey.vtkInformationIntegerVectorKey_ShallowCopy_12(base.GetCppThis(), (from == null) ? default(HandleRef) : from.GetCppThis(), (to == null) ? default(HandleRef) : to.GetCppThis());
		}
	}
}
