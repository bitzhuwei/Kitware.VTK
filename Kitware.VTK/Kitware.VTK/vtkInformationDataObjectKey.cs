using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkInformationDataObjectKey : vtkInformationKey
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkInformationDataObjectKey";

		public new static readonly string MRClassNameKey;

		static vtkInformationDataObjectKey()
		{
			vtkInformationDataObjectKey.MRClassNameKey = "class vtkInformationDataObjectKey";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkInformationDataObjectKey.MRClassNameKey, Type.GetType("Kitware.VTK.vtkInformationDataObjectKey"));
		}

		public vtkInformationDataObjectKey(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkInformationDataObjectKey_Get_01(HandleRef pThis, HandleRef info, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkDataObject Get(vtkInformation info)
		{
			vtkDataObject vtkDataObject = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkInformationDataObjectKey.vtkInformationDataObjectKey_Get_01(base.GetCppThis(), (info == null) ? default(HandleRef) : info.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataObject = (vtkDataObject)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataObject.Register(null);
				}
			}
			return vtkDataObject;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkInformationDataObjectKey_IsA_02(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkInformationDataObjectKey.vtkInformationDataObjectKey_IsA_02(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkInformationDataObjectKey_IsTypeOf_03(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkInformationDataObjectKey.vtkInformationDataObjectKey_IsTypeOf_03(type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkInformationDataObjectKey_NewInstance_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkInformationDataObjectKey NewInstance()
		{
			vtkInformationDataObjectKey result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkInformationDataObjectKey.vtkInformationDataObjectKey_NewInstance_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkInformationDataObjectKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkInformationDataObjectKey_Report_05(HandleRef pThis, HandleRef info, HandleRef collector);

		public override void Report(vtkInformation info, vtkGarbageCollector collector)
		{
			vtkInformationDataObjectKey.vtkInformationDataObjectKey_Report_05(base.GetCppThis(), (info == null) ? default(HandleRef) : info.GetCppThis(), (collector == null) ? default(HandleRef) : collector.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkInformationDataObjectKey_SafeDownCast_06(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkInformationDataObjectKey SafeDownCast(vtkObjectBase o)
		{
			vtkInformationDataObjectKey vtkInformationDataObjectKey = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkInformationDataObjectKey.vtkInformationDataObjectKey_SafeDownCast_06((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationDataObjectKey = (vtkInformationDataObjectKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationDataObjectKey.Register(null);
				}
			}
			return vtkInformationDataObjectKey;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkInformationDataObjectKey_Set_07(HandleRef pThis, HandleRef info, HandleRef arg1);

		public void Set(vtkInformation info, vtkDataObject arg1)
		{
			vtkInformationDataObjectKey.vtkInformationDataObjectKey_Set_07(base.GetCppThis(), (info == null) ? default(HandleRef) : info.GetCppThis(), (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkInformationDataObjectKey_ShallowCopy_08(HandleRef pThis, HandleRef from, HandleRef to);

		public override void ShallowCopy(vtkInformation from, vtkInformation to)
		{
			vtkInformationDataObjectKey.vtkInformationDataObjectKey_ShallowCopy_08(base.GetCppThis(), (from == null) ? default(HandleRef) : from.GetCppThis(), (to == null) ? default(HandleRef) : to.GetCppThis());
		}
	}
}
