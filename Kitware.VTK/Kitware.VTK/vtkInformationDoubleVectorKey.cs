using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkInformationDoubleVectorKey : vtkInformationKey
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkInformationDoubleVectorKey";

		public new static readonly string MRClassNameKey;

		static vtkInformationDoubleVectorKey()
		{
			vtkInformationDoubleVectorKey.MRClassNameKey = "class vtkInformationDoubleVectorKey";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkInformationDoubleVectorKey.MRClassNameKey, Type.GetType("Kitware.VTK.vtkInformationDoubleVectorKey"));
		}

		public vtkInformationDoubleVectorKey(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkInformationDoubleVectorKey_Append_01(HandleRef pThis, HandleRef info, double value);

		public void Append(vtkInformation info, double value)
		{
			vtkInformationDoubleVectorKey.vtkInformationDoubleVectorKey_Append_01(base.GetCppThis(), (info == null) ? default(HandleRef) : info.GetCppThis(), value);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkInformationDoubleVectorKey_Get_02(HandleRef pThis, HandleRef info);

		public IntPtr Get(vtkInformation info)
		{
			return vtkInformationDoubleVectorKey.vtkInformationDoubleVectorKey_Get_02(base.GetCppThis(), (info == null) ? default(HandleRef) : info.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern double vtkInformationDoubleVectorKey_Get_03(HandleRef pThis, HandleRef info, int idx);

		public double Get(vtkInformation info, int idx)
		{
			return vtkInformationDoubleVectorKey.vtkInformationDoubleVectorKey_Get_03(base.GetCppThis(), (info == null) ? default(HandleRef) : info.GetCppThis(), idx);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkInformationDoubleVectorKey_Get_04(HandleRef pThis, HandleRef info, IntPtr value);

		public void Get(vtkInformation info, IntPtr value)
		{
			vtkInformationDoubleVectorKey.vtkInformationDoubleVectorKey_Get_04(base.GetCppThis(), (info == null) ? default(HandleRef) : info.GetCppThis(), value);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkInformationDoubleVectorKey_IsA_05(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkInformationDoubleVectorKey.vtkInformationDoubleVectorKey_IsA_05(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkInformationDoubleVectorKey_IsTypeOf_06(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkInformationDoubleVectorKey.vtkInformationDoubleVectorKey_IsTypeOf_06(type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkInformationDoubleVectorKey_Length_07(HandleRef pThis, HandleRef info);

		public int Length(vtkInformation info)
		{
			return vtkInformationDoubleVectorKey.vtkInformationDoubleVectorKey_Length_07(base.GetCppThis(), (info == null) ? default(HandleRef) : info.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkInformationDoubleVectorKey_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkInformationDoubleVectorKey NewInstance()
		{
			vtkInformationDoubleVectorKey result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkInformationDoubleVectorKey.vtkInformationDoubleVectorKey_NewInstance_08(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkInformationDoubleVectorKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkInformationDoubleVectorKey_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkInformationDoubleVectorKey SafeDownCast(vtkObjectBase o)
		{
			vtkInformationDoubleVectorKey vtkInformationDoubleVectorKey = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkInformationDoubleVectorKey.vtkInformationDoubleVectorKey_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationDoubleVectorKey = (vtkInformationDoubleVectorKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationDoubleVectorKey.Register(null);
				}
			}
			return vtkInformationDoubleVectorKey;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkInformationDoubleVectorKey_Set_10(HandleRef pThis, HandleRef info, IntPtr value, int length);

		public void Set(vtkInformation info, IntPtr value, int length)
		{
			vtkInformationDoubleVectorKey.vtkInformationDoubleVectorKey_Set_10(base.GetCppThis(), (info == null) ? default(HandleRef) : info.GetCppThis(), value, length);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkInformationDoubleVectorKey_ShallowCopy_11(HandleRef pThis, HandleRef from, HandleRef to);

		public override void ShallowCopy(vtkInformation from, vtkInformation to)
		{
			vtkInformationDoubleVectorKey.vtkInformationDoubleVectorKey_ShallowCopy_11(base.GetCppThis(), (from == null) ? default(HandleRef) : from.GetCppThis(), (to == null) ? default(HandleRef) : to.GetCppThis());
		}
	}
}
