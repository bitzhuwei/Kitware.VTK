using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkInformationKeyVectorKey : vtkInformationKey
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkInformationKeyVectorKey";

		public new static readonly string MRClassNameKey;

		static vtkInformationKeyVectorKey()
		{
			vtkInformationKeyVectorKey.MRClassNameKey = "class vtkInformationKeyVectorKey";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkInformationKeyVectorKey.MRClassNameKey, Type.GetType("Kitware.VTK.vtkInformationKeyVectorKey"));
		}

		public vtkInformationKeyVectorKey(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkInformationKeyVectorKey_Append_01(HandleRef pThis, HandleRef info, HandleRef value);

		public void Append(vtkInformation info, vtkInformationKey value)
		{
			vtkInformationKeyVectorKey.vtkInformationKeyVectorKey_Append_01(base.GetCppThis(), (info == null) ? default(HandleRef) : info.GetCppThis(), (value == null) ? default(HandleRef) : value.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkInformationKeyVectorKey_AppendUnique_02(HandleRef pThis, HandleRef info, HandleRef value);

		public void AppendUnique(vtkInformation info, vtkInformationKey value)
		{
			vtkInformationKeyVectorKey.vtkInformationKeyVectorKey_AppendUnique_02(base.GetCppThis(), (info == null) ? default(HandleRef) : info.GetCppThis(), (value == null) ? default(HandleRef) : value.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkInformationKeyVectorKey_Get_03(HandleRef pThis, HandleRef info, int idx, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkInformationKey Get(vtkInformation info, int idx)
		{
			vtkInformationKey vtkInformationKey = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkInformationKeyVectorKey.vtkInformationKeyVectorKey_Get_03(base.GetCppThis(), (info == null) ? default(HandleRef) : info.GetCppThis(), idx, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationKey = (vtkInformationKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationKey.Register(null);
				}
			}
			return vtkInformationKey;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkInformationKeyVectorKey_IsA_04(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkInformationKeyVectorKey.vtkInformationKeyVectorKey_IsA_04(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkInformationKeyVectorKey_IsTypeOf_05(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkInformationKeyVectorKey.vtkInformationKeyVectorKey_IsTypeOf_05(type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkInformationKeyVectorKey_Length_06(HandleRef pThis, HandleRef info);

		public int Length(vtkInformation info)
		{
			return vtkInformationKeyVectorKey.vtkInformationKeyVectorKey_Length_06(base.GetCppThis(), (info == null) ? default(HandleRef) : info.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkInformationKeyVectorKey_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkInformationKeyVectorKey NewInstance()
		{
			vtkInformationKeyVectorKey result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkInformationKeyVectorKey.vtkInformationKeyVectorKey_NewInstance_07(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkInformationKeyVectorKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkInformationKeyVectorKey_RemoveItem_08(HandleRef pThis, HandleRef info, HandleRef value);

		public void RemoveItem(vtkInformation info, vtkInformationKey value)
		{
			vtkInformationKeyVectorKey.vtkInformationKeyVectorKey_RemoveItem_08(base.GetCppThis(), (info == null) ? default(HandleRef) : info.GetCppThis(), (value == null) ? default(HandleRef) : value.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkInformationKeyVectorKey_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkInformationKeyVectorKey SafeDownCast(vtkObjectBase o)
		{
			vtkInformationKeyVectorKey vtkInformationKeyVectorKey = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkInformationKeyVectorKey.vtkInformationKeyVectorKey_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationKeyVectorKey = (vtkInformationKeyVectorKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationKeyVectorKey.Register(null);
				}
			}
			return vtkInformationKeyVectorKey;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkInformationKeyVectorKey_ShallowCopy_10(HandleRef pThis, HandleRef from, HandleRef to);

		public override void ShallowCopy(vtkInformation from, vtkInformation to)
		{
			vtkInformationKeyVectorKey.vtkInformationKeyVectorKey_ShallowCopy_10(base.GetCppThis(), (from == null) ? default(HandleRef) : from.GetCppThis(), (to == null) ? default(HandleRef) : to.GetCppThis());
		}
	}
}
