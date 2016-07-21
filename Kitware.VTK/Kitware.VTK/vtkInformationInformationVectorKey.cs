using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkInformationInformationVectorKey : vtkInformationKey
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkInformationInformationVectorKey";

		public new static readonly string MRClassNameKey;

		static vtkInformationInformationVectorKey()
		{
			vtkInformationInformationVectorKey.MRClassNameKey = "class vtkInformationInformationVectorKey";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkInformationInformationVectorKey.MRClassNameKey, Type.GetType("Kitware.VTK.vtkInformationInformationVectorKey"));
		}

		public vtkInformationInformationVectorKey(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkInformationInformationVectorKey_DeepCopy_01(HandleRef pThis, HandleRef from, HandleRef to);

		public override void DeepCopy(vtkInformation from, vtkInformation to)
		{
			vtkInformationInformationVectorKey.vtkInformationInformationVectorKey_DeepCopy_01(base.GetCppThis(), (from == null) ? default(HandleRef) : from.GetCppThis(), (to == null) ? default(HandleRef) : to.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkInformationInformationVectorKey_Get_02(HandleRef pThis, HandleRef info, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkInformationVector Get(vtkInformation info)
		{
			vtkInformationVector vtkInformationVector = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkInformationInformationVectorKey.vtkInformationInformationVectorKey_Get_02(base.GetCppThis(), (info == null) ? default(HandleRef) : info.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationVector = (vtkInformationVector)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationVector.Register(null);
				}
			}
			return vtkInformationVector;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkInformationInformationVectorKey_IsA_03(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkInformationInformationVectorKey.vtkInformationInformationVectorKey_IsA_03(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkInformationInformationVectorKey_IsTypeOf_04(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkInformationInformationVectorKey.vtkInformationInformationVectorKey_IsTypeOf_04(type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkInformationInformationVectorKey_NewInstance_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkInformationInformationVectorKey NewInstance()
		{
			vtkInformationInformationVectorKey result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkInformationInformationVectorKey.vtkInformationInformationVectorKey_NewInstance_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkInformationInformationVectorKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkInformationInformationVectorKey_Report_06(HandleRef pThis, HandleRef info, HandleRef collector);

		public override void Report(vtkInformation info, vtkGarbageCollector collector)
		{
			vtkInformationInformationVectorKey.vtkInformationInformationVectorKey_Report_06(base.GetCppThis(), (info == null) ? default(HandleRef) : info.GetCppThis(), (collector == null) ? default(HandleRef) : collector.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkInformationInformationVectorKey_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkInformationInformationVectorKey SafeDownCast(vtkObjectBase o)
		{
			vtkInformationInformationVectorKey vtkInformationInformationVectorKey = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkInformationInformationVectorKey.vtkInformationInformationVectorKey_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationInformationVectorKey = (vtkInformationInformationVectorKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationInformationVectorKey.Register(null);
				}
			}
			return vtkInformationInformationVectorKey;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkInformationInformationVectorKey_Set_08(HandleRef pThis, HandleRef info, HandleRef arg1);

		public void Set(vtkInformation info, vtkInformationVector arg1)
		{
			vtkInformationInformationVectorKey.vtkInformationInformationVectorKey_Set_08(base.GetCppThis(), (info == null) ? default(HandleRef) : info.GetCppThis(), (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkInformationInformationVectorKey_ShallowCopy_09(HandleRef pThis, HandleRef from, HandleRef to);

		public override void ShallowCopy(vtkInformation from, vtkInformation to)
		{
			vtkInformationInformationVectorKey.vtkInformationInformationVectorKey_ShallowCopy_09(base.GetCppThis(), (from == null) ? default(HandleRef) : from.GetCppThis(), (to == null) ? default(HandleRef) : to.GetCppThis());
		}
	}
}
